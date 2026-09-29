Imports System.Globalization
Imports System.ComponentModel
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Partial Class RepairsPage
    Private selectedRepairId As Integer

    Public Sub New()
        InitializeComponent()
        cboStatus.Items.AddRange(New Object() {"PENDING", "IN_PROGRESS", "WAITING_FOR_PARTS", "COMPLETED", "CANCELLED"})
        cboStatus.SelectedIndex = 0
        txtQty.Text = "1"
        txtUnitCost.Text = "0.00"
        AddHandler btnNew.Click, AddressOf ClearForm
        AddHandler btnSave.Click, AddressOf SaveRepair
        AddHandler btnAddPart.Click, AddressOf AddPart
        AddHandler btnRemovePart.Click, AddressOf RemovePart
        AddHandler grid.SelectionChanged, AddressOf SelectRepair
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        LoadLists()
        LoadRepairs()
    End Sub

    Private Sub LoadLists()
        Dim quoteSql As String =
            "SELECT q.quotation_id id," &
            "CONCAT(LPAD(q.quotation_id,3,'0'),' - Req ',LPAD(q.request_id,3,'0'),' / ',c.last_name) name " &
            "FROM quotations q " &
            "JOIN service_requests r ON r.request_id=q.request_id " &
            "JOIN devices d ON d.device_id=r.device_id " &
            "JOIN customers c ON c.customer_id=d.customer_id " &
            "WHERE q.status='APPROVED' ORDER BY q.quotation_id DESC"

        Dim technicianSql As String =
            "SELECT employee_id id," &
            "CONCAT(LPAD(employee_id,3,'0'),' - ',first_name,' ',last_name) name " &
            "FROM employees WHERE role IN ('TECHNICIAN','ADMIN') AND is_active=1 " &
            "ORDER BY last_name"

        BindCombo(cboQuote, GetTable(quoteSql))
        BindCombo(cboTech, GetTable(technicianSql))
    End Sub

    Private Sub LoadRepairs()
        Try
            Dim sql As String =
                "SELECT j.repair_id ID,j.quotation_id QuoteID,j.request_id RequestID," &
                "CONCAT(c.last_name,', ',c.first_name) Customer,d.device_type Device," &
                "CONCAT(e.first_name,' ',e.last_name) Tech,j.status Status," &
                "j.start_date Started,j.completion_date Finished " &
                "FROM repair_jobs j " &
                "JOIN service_requests r ON r.request_id=j.request_id " &
                "JOIN devices d ON d.device_id=r.device_id " &
                "JOIN customers c ON c.customer_id=d.customer_id " &
                "JOIN employees e ON e.employee_id=j.technician_id " &
                "ORDER BY j.repair_id DESC"

            grid.DataSource = GetTable(sql)
            FormatGridIds(grid)
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub LoadParts()
        If selectedRepairId = 0 Then
            partsGrid.DataSource = Nothing
            Return
        End If
        Dim sql As String =
            "SELECT repair_part_id ID,part_name Part,quantity Qty,unit_cost Cost,subtotal Total " &
            "FROM repair_parts WHERE repair_id=@p0 ORDER BY repair_part_id"

        partsGrid.DataSource = GetTable(sql, selectedRepairId)
        FormatGridIds(partsGrid)
    End Sub

    Private Sub SelectRepair(sender As Object, e As EventArgs)
        If grid.CurrentRow Is Nothing Then Return
        selectedRepairId = Convert.ToInt32(grid.CurrentRow.Cells("ID").Value)
        Dim sql As String =
            "SELECT quotation_id,technician_id,diagnosis,repair_action,repair_notes,status " &
            "FROM repair_jobs WHERE repair_id=@p0"

        Dim table = GetTable(sql, selectedRepairId)
        If table.Rows.Count = 0 Then Return
        Dim row = table.Rows(0)
        cboQuote.SelectedValue = row("quotation_id")
        cboTech.SelectedValue = row("technician_id")
        txtDiagnosis.Text = row("diagnosis").ToString()
        txtAction.Text = row("repair_action").ToString()
        txtNotes.Text = row("repair_notes").ToString()
        cboStatus.SelectedItem = row("status").ToString()
        LoadParts()
    End Sub

    Private Sub ClearForm(sender As Object, e As EventArgs)
        selectedRepairId = 0
        txtDiagnosis.Clear()
        txtAction.Clear()
        txtNotes.Clear()
        txtPart.Clear()
        txtPartDesc.Clear()
        txtQty.Text = "1"
        txtUnitCost.Text = "0.00"
        cboStatus.SelectedIndex = 0
        LoadParts()
    End Sub

    Private Sub SaveRepair(sender As Object, e As EventArgs)
        Dim quotationId As Integer = SelectedId(cboQuote)
        Dim technicianId As Integer = SelectedId(cboTech)

        If quotationId = 0 OrElse technicianId = 0 Then
            MessageBox.Show(Me, "Choose a quote and technician.", "Repair", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim requestId As Integer = Convert.ToInt32(GetValue(
                "SELECT request_id FROM quotations WHERE quotation_id=@p0", quotationId))

            If selectedRepairId = 0 AndAlso RepairExists(quotationId) Then
                MessageBox.Show(Me, "This quote already has a repair.", "Repair", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As MySqlConnection = OpenConnection()
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    If selectedRepairId = 0 Then
                        InsertRepair(connection, transaction, requestId, quotationId, technicianId)
                    Else
                        UpdateRepair(connection, transaction, technicianId)
                    End If

                    UpdateRequestStatus(connection, transaction, requestId)
                    transaction.Commit()
                End Using
            End Using

            LoadRepairs()
            LoadParts()
            MessageBox.Show(Me, "Repair saved.", "Repair")
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Function RepairExists(quotationId As Integer) As Boolean
        Dim count As Integer = Convert.ToInt32(GetValue(
            "SELECT COUNT(*) FROM repair_jobs WHERE quotation_id=@p0", quotationId))

        Return count > 0
    End Function

    Private Sub InsertRepair(connection As MySqlConnection, transaction As MySqlTransaction,
                             requestId As Integer, quotationId As Integer, technicianId As Integer)
        Dim sql As String =
            "INSERT INTO repair_jobs(request_id,quotation_id,technician_id,start_date,completion_date," &
            "diagnosis,repair_action,repair_notes,status) " &
            "VALUES(@p0,@p1,@p2,IF(@p3='PENDING',NULL,NOW())," &
            "IF(@p3='COMPLETED',NOW(),NULL),@p4,@p5,@p6,@p3)"

        Dim values As Object() = {
            requestId,
            quotationId,
            technicianId,
            cboStatus.Text,
            NullIfBlank(txtDiagnosis.Text),
            NullIfBlank(txtAction.Text),
            NullIfBlank(txtNotes.Text)
        }

        Using command As MySqlCommand = CreateCommand(connection, sql, values, transaction)
            command.ExecuteNonQuery()
            selectedRepairId = Convert.ToInt32(command.LastInsertedId)
        End Using

        cboQuote.Focus()
        txtDiagnosis.Clear()
        txtAction.Clear()
        txtNotes.Clear()
        txtPart.Clear()
        txtPartDesc.Clear()
        txtQty.Clear()
        txtUnitCost.Clear()
    End Sub

    Private Sub UpdateRepair(connection As MySqlConnection, transaction As MySqlTransaction,
                             technicianId As Integer)
        Dim sql As String =
            "UPDATE repair_jobs SET technician_id=@p0,diagnosis=@p1,repair_action=@p2,repair_notes=@p3," &
            "status=@p4,start_date=IF(@p4='PENDING',start_date,COALESCE(start_date,NOW()))," &
            "completion_date=IF(@p4='COMPLETED',COALESCE(completion_date,NOW()),NULL) " &
            "WHERE repair_id=@p5"

        Dim values As Object() = {
            technicianId,
            NullIfBlank(txtDiagnosis.Text),
            NullIfBlank(txtAction.Text),
            NullIfBlank(txtNotes.Text),
            cboStatus.Text,
            selectedRepairId
        }

        Using command As MySqlCommand = CreateCommand(connection, sql, values, transaction)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub UpdateRequestStatus(connection As MySqlConnection, transaction As MySqlTransaction,
                                    requestId As Integer)
        Dim requestStatus As String

        Select Case cboStatus.Text
            Case "COMPLETED"
                requestStatus = "READY_FOR_PICKUP"
            Case "CANCELLED"
                requestStatus = "CANCELLED"
            Case "PENDING"
                requestStatus = "FOR_REPAIR"
            Case Else
                requestStatus = "REPAIRING"
        End Select

        Using command As MySqlCommand = CreateCommand(
            connection,
            "UPDATE service_requests SET status=@p0 WHERE request_id=@p1",
            {requestStatus, requestId},
            transaction)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub AddPart(sender As Object, e As EventArgs)
        Dim quantity As Integer
        Dim cost As Decimal

        If selectedRepairId = 0 Then
            MessageBox.Show(Me, "Save the repair first.", "Parts", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsPartValid(quantity, cost) Then
            MessageBox.Show(Me, "Enter a part, quantity, and valid cost.", "Parts", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim sql As String =
                "INSERT INTO repair_parts(repair_id,part_name,part_description,quantity,unit_cost,subtotal) " &
                "VALUES(@p0,@p1,@p2,@p3,@p4,@p5)"

            Execute(sql,
                selectedRepairId,
                txtPart.Text.Trim(),
                NullIfBlank(txtPartDesc.Text),
                quantity,
                cost,
                quantity * cost)

            txtPart.Clear()
            txtPartDesc.Clear()
            txtQty.Clear()
            txtUnitCost.Clear()
            LoadParts()
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Function IsPartValid(ByRef quantity As Integer, ByRef cost As Decimal) As Boolean
        If txtPart.Text.Trim() = "" Then Return False
        If Not Integer.TryParse(txtQty.Text, quantity) Then Return False
        If quantity < 1 Then Return False

        If Not Decimal.TryParse(
            txtUnitCost.Text,
            NumberStyles.Number,
            CultureInfo.CurrentCulture,
            cost) Then
            Return False
        End If

        Return cost >= 0D
    End Function

    Private Sub RemovePart(sender As Object, e As EventArgs)
        If partsGrid.CurrentRow Is Nothing Then Return
        Try
            Execute("DELETE FROM repair_parts WHERE repair_part_id=@p0", Convert.ToInt32(partsGrid.CurrentRow.Cells("ID").Value))
            LoadParts()
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub cboQuote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboQuote.SelectedIndexChanged

    End Sub

    Private Sub txtDiagnosis_TextChanged(sender As Object, e As EventArgs) Handles txtDiagnosis.TextChanged

    End Sub

    Private Sub txtAction_TextChanged(sender As Object, e As EventArgs) Handles txtAction.TextChanged

    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged

    End Sub

    Private Sub txtPart_TextChanged(sender As Object, e As EventArgs) Handles txtPart.TextChanged

    End Sub

    Private Sub txtPartDesc_TextChanged(sender As Object, e As EventArgs) Handles txtPartDesc.TextChanged

    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub txtUnitCost_TextChanged(sender As Object, e As EventArgs) Handles txtUnitCost.TextChanged

    End Sub
End Class
