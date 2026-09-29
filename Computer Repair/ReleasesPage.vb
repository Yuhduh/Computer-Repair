Imports System.ComponentModel
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Partial Class ReleasesPage
    Private ReadOnly employeeId As Integer
    Private selectedReleaseId As Integer

    Public Sub New()
        Me.New(1)
    End Sub

    Public Sub New(currentEmployeeId As Integer)
        employeeId = currentEmployeeId
        InitializeComponent()
        AddHandler btnNew.Click, AddressOf ClearForm
        AddHandler btnSave.Click, AddressOf SaveRelease
        AddHandler grid.SelectionChanged, AddressOf SelectRelease
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        LoadRepairList()
        LoadReleases()
    End Sub

    Private Sub LoadRepairList()
        Dim sql As String =
            "SELECT j.repair_id id," &
            "CONCAT(LPAD(j.repair_id,3,'0'),' - ',c.last_name,' / ',d.device_type) name " &
            "FROM repair_jobs j " &
            "JOIN service_requests r ON r.request_id=j.request_id " &
            "JOIN devices d ON d.device_id=r.device_id " &
            "JOIN customers c ON c.customer_id=d.customer_id " &
            "WHERE j.status='COMPLETED' ORDER BY j.repair_id DESC"

        BindCombo(cboRepair, GetTable(sql))
    End Sub

    Private Sub LoadReleases()
        Try
            Dim sql As String =
                "SELECT x.release_id ID,x.repair_id RepairID," &
                "CONCAT(c.last_name,', ',c.first_name) Customer,d.device_type Device," &
                "x.received_by_name ReceivedBy,x.relationship_to_customer Relation," &
                "x.release_date Released,CONCAT(e.first_name,' ',e.last_name) Staff " &
                "FROM device_releases x " &
                "JOIN repair_jobs j ON j.repair_id=x.repair_id " &
                "JOIN service_requests r ON r.request_id=j.request_id " &
                "JOIN devices d ON d.device_id=r.device_id " &
                "JOIN customers c ON c.customer_id=x.customer_id " &
                "JOIN employees e ON e.employee_id=x.released_by " &
                "ORDER BY x.release_id DESC"

            grid.DataSource = GetTable(sql)
            FormatGridIds(grid)
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub SelectRelease(sender As Object, e As EventArgs)
        If grid.CurrentRow Is Nothing Then Return
        selectedReleaseId = Convert.ToInt32(grid.CurrentRow.Cells("ID").Value)
        Dim sql As String =
            "SELECT repair_id,received_by_name,relationship_to_customer," &
            "device_condition_on_release,remarks FROM device_releases WHERE release_id=@p0"

        Dim table = GetTable(sql, selectedReleaseId)
        If table.Rows.Count = 0 Then Return
        Dim row = table.Rows(0)
        cboRepair.SelectedValue = row("repair_id")
        txtReceivedBy.Text = row("received_by_name").ToString()
        txtRelation.Text = row("relationship_to_customer").ToString()
        txtCondition.Text = row("device_condition_on_release").ToString()
        txtRemarks.Text = row("remarks").ToString()
    End Sub

    Private Sub ClearForm(sender As Object, e As EventArgs)
        selectedReleaseId = 0
        txtReceivedBy.Clear()
        txtRelation.Clear()
        txtCondition.Clear()
        txtRemarks.Clear()
    End Sub

    Private Sub SaveRelease(sender As Object, e As EventArgs)
        Dim repairId As Integer = SelectedId(cboRepair)

        If repairId = 0 OrElse txtReceivedBy.Text.Trim() = "" Then
            MessageBox.Show(Me, "Choose a repair and enter who received it.", "Release", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim table = GetTable(
                "SELECT r.request_id,d.customer_id FROM repair_jobs j " &
                "JOIN service_requests r ON r.request_id=j.request_id " &
                "JOIN devices d ON d.device_id=r.device_id WHERE j.repair_id=@p0",
                repairId)

            If table.Rows.Count = 0 Then Return

            Dim requestId = Convert.ToInt32(table.Rows(0)("request_id"))
            Dim customerId = Convert.ToInt32(table.Rows(0)("customer_id"))

            If selectedReleaseId = 0 AndAlso ReleaseExists(repairId) Then
                MessageBox.Show(Me, "This device was already released.", "Release", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As MySqlConnection = OpenConnection()
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    If selectedReleaseId = 0 Then
                        InsertRelease(connection, transaction, repairId, customerId)
                    Else
                        UpdateRelease(connection, transaction)
                    End If

                    MarkRequestAsReleased(connection, transaction, requestId)
                    transaction.Commit()
                End Using
            End Using

            LoadReleases()
            MessageBox.Show(Me, "Release saved.", "Release")
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Function ReleaseExists(repairId As Integer) As Boolean
        Dim count As Integer = Convert.ToInt32(GetValue(
            "SELECT COUNT(*) FROM device_releases WHERE repair_id=@p0", repairId))

        Return count > 0
    End Function

    Private Sub InsertRelease(connection As MySqlConnection, transaction As MySqlTransaction,
                              repairId As Integer, customerId As Integer)
        Dim sql As String =
            "INSERT INTO device_releases(repair_id,customer_id,released_by,received_by_name," &
            "relationship_to_customer,device_condition_on_release,remarks) " &
            "VALUES(@p0,@p1,@p2,@p3,@p4,@p5,@p6)"

        Dim values As Object() = {
            repairId,
            customerId,
            employeeId,
            txtReceivedBy.Text.Trim(),
            NullIfBlank(txtRelation.Text),
            NullIfBlank(txtCondition.Text),
            NullIfBlank(txtRemarks.Text)
        }

        Using command As MySqlCommand = CreateCommand(connection, sql, values, transaction)
            command.ExecuteNonQuery()
        End Using

        cboRepair.SelectedIndex = -1
        cboRepair.Focus()
        txtReceivedBy.Clear()
        txtRelation.Clear()
        txtCondition.Clear()
        txtRemarks.Clear()
    End Sub

    Private Sub UpdateRelease(connection As MySqlConnection, transaction As MySqlTransaction)
        Dim sql As String =
            "UPDATE device_releases SET received_by_name=@p0,relationship_to_customer=@p1," &
            "device_condition_on_release=@p2,remarks=@p3 WHERE release_id=@p4"

        Dim values As Object() = {
            txtReceivedBy.Text.Trim(),
            NullIfBlank(txtRelation.Text),
            NullIfBlank(txtCondition.Text),
            NullIfBlank(txtRemarks.Text),
            selectedReleaseId
        }

        Using command As MySqlCommand = CreateCommand(connection, sql, values, transaction)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub MarkRequestAsReleased(connection As MySqlConnection, transaction As MySqlTransaction,
                                      requestId As Integer)
        Using command As MySqlCommand = CreateCommand(
            connection,
            "UPDATE service_requests SET status='RELEASED' WHERE request_id=@p0",
            {requestId},
            transaction)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub cboRepair_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRepair.SelectedIndexChanged

    End Sub
End Class
