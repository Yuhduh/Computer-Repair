Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Windows.Forms

Partial Public Class IntakePage
    Private ReadOnly employeeId As Integer
    Private selectedRequestId As Integer
    Private selectedDeviceId As Integer

    Public Sub New()
        Me.New(1)
    End Sub

    Public Sub New(currentEmployeeId As Integer)
        employeeId = currentEmployeeId
        InitializeComponent()
        cboStatus.Items.AddRange(New Object() {
            "RECEIVED", "FOR_QUOTATION", "AWAITING_APPROVAL", "APPROVED", "REJECTED",
            "FOR_REPAIR", "REPAIRING", "REPAIR_COMPLETED", "READY_FOR_PICKUP", "RELEASED", "CANCELLED"
        })
        cboStatus.SelectedIndex = 0
        AddHandler btnNew.Click, AddressOf ClearForm
        AddHandler btnSave.Click, AddressOf SaveIntake
        AddHandler grid.SelectionChanged, AddressOf SelectRequest
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        LoadCustomerList()
        LoadRequests()
    End Sub

    Private Sub LoadCustomerList()
        Dim sql As String =
            "SELECT customer_id id, " &
            "CONCAT(LPAD(customer_id,3,'0'),' - ',last_name,', ',first_name) name " &
            "FROM customers ORDER BY last_name,first_name"

        BindCombo(cboCustomer, GetTable(sql))
    End Sub

    Private Sub LoadRequests()
        Try
            Dim sql As String =
                "SELECT r.request_id ID,r.device_id DeviceID," &
                "CONCAT(c.last_name,', ',c.first_name) Customer,d.device_type Device," &
                "d.brand Brand,d.model Model,d.serial_number Serial,r.reported_problem Problem," &
                "r.initial_findings Findings,r.status Status,r.remarks Notes " &
                "FROM service_requests r " &
                "JOIN devices d ON d.device_id=r.device_id " &
                "JOIN customers c ON c.customer_id=d.customer_id " &
                "ORDER BY r.request_id DESC"

            grid.DataSource = GetTable(sql)
            FormatGridIds(grid)
            If grid.Columns.Contains("DeviceID") Then grid.Columns("DeviceID").Visible = False
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub SelectRequest(sender As Object, e As EventArgs)
        If grid.CurrentRow Is Nothing Then Return
        selectedRequestId = Convert.ToInt32(grid.CurrentRow.Cells("ID").Value)
        selectedDeviceId = Convert.ToInt32(grid.CurrentRow.Cells("DeviceID").Value)
        Dim sql As String =
            "SELECT d.customer_id,d.device_type,d.brand,d.model,d.serial_number,d.color," &
            "d.accessories_received,d.device_condition,r.reported_problem,r.initial_findings," &
            "r.status,r.remarks FROM devices d " &
            "JOIN service_requests r ON r.device_id=d.device_id WHERE r.request_id=@p0"

        Dim table = GetTable(sql, selectedRequestId)
        If table.Rows.Count = 0 Then Return
        Dim row = table.Rows(0)
        cboCustomer.SelectedValue = row("customer_id")
        txtType.Text = row("device_type").ToString()
        txtBrand.Text = row("brand").ToString()
        txtModel.Text = row("model").ToString()
        txtSerial.Text = row("serial_number").ToString()
        txtColor.Text = row("color").ToString()
        txtAccessories.Text = row("accessories_received").ToString()
        txtCondition.Text = row("device_condition").ToString()
        txtProblem.Text = row("reported_problem").ToString()
        txtFindings.Text = row("initial_findings").ToString()
        cboStatus.SelectedItem = row("status").ToString()
        txtRemarks.Text = row("remarks").ToString()
    End Sub

    Private Sub ClearForm(sender As Object, e As EventArgs)
        selectedRequestId = 0
        selectedDeviceId = 0
        For Each box In {txtType, txtBrand, txtModel, txtSerial, txtColor, txtAccessories, txtCondition, txtProblem, txtFindings, txtRemarks}
            box.Clear()
        Next
        cboStatus.SelectedIndex = 0
        txtType.Focus()
    End Sub

    Private Sub SaveIntake(sender As Object, e As EventArgs)
        Dim customerId As Integer = SelectedId(cboCustomer)

        If customerId = 0 OrElse txtType.Text.Trim() = "" OrElse txtProblem.Text.Trim() = "" Then
            MessageBox.Show(Me, "Choose a customer and enter the device type and problem.", "Intake", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using connection As MySqlConnection = OpenConnection()
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    If selectedRequestId = 0 Then
                        InsertIntake(connection, transaction, customerId)
                    Else
                        UpdateIntake(connection, transaction, customerId)
                    End If

                    transaction.Commit()
                End Using
            End Using

            LoadRequests()
            MessageBox.Show(Me, "Intake saved.", "Intake")
            cboCustomer.Focus()
            txtType.Clear()
            txtBrand.Clear()
            txtModel.Clear()
            txtSerial.Clear()
            txtColor.Clear()
            txtRemarks.Clear()
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub InsertIntake(connection As MySqlConnection, transaction As MySqlTransaction, customerId As Integer)
        Dim deviceValues As Object() = {
            customerId,
            txtType.Text.Trim(),
            NullIfBlank(txtBrand.Text),
            NullIfBlank(txtModel.Text),
            NullIfBlank(txtSerial.Text),
            NullIfBlank(txtColor.Text),
            NullIfBlank(txtAccessories.Text),
            NullIfBlank(txtCondition.Text)
        }

        Dim deviceSql As String =
            "INSERT INTO devices(customer_id,device_type,brand,model,serial_number,color,accessories_received,device_condition) " &
            "VALUES(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7)"

        Using deviceCommand As MySqlCommand = CreateCommand(connection, deviceSql, deviceValues, transaction)
            deviceCommand.ExecuteNonQuery()
            selectedDeviceId = Convert.ToInt32(deviceCommand.LastInsertedId)
        End Using

        Dim requestValues As Object() = {
            selectedDeviceId,
            employeeId,
            txtProblem.Text.Trim(),
            NullIfBlank(txtFindings.Text),
            cboStatus.Text,
            NullIfBlank(txtRemarks.Text)
        }

        Dim requestSql As String =
            "INSERT INTO service_requests(device_id,received_by,reported_problem,initial_findings,status,remarks) " &
            "VALUES(@p0,@p1,@p2,@p3,@p4,@p5)"

        Using requestCommand As MySqlCommand = CreateCommand(connection, requestSql, requestValues, transaction)
            requestCommand.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub UpdateIntake(connection As MySqlConnection, transaction As MySqlTransaction, customerId As Integer)
        Dim deviceValues As Object() = {
            customerId,
            txtType.Text.Trim(),
            NullIfBlank(txtBrand.Text),
            NullIfBlank(txtModel.Text),
            NullIfBlank(txtSerial.Text),
            NullIfBlank(txtColor.Text),
            NullIfBlank(txtAccessories.Text),
            NullIfBlank(txtCondition.Text),
            selectedDeviceId
        }

        Dim deviceSql As String =
            "UPDATE devices SET customer_id=@p0,device_type=@p1,brand=@p2,model=@p3,serial_number=@p4," &
            "color=@p5,accessories_received=@p6,device_condition=@p7 WHERE device_id=@p8"

        Using deviceCommand As MySqlCommand = CreateCommand(connection, deviceSql, deviceValues, transaction)
            deviceCommand.ExecuteNonQuery()
        End Using

        Dim requestValues As Object() = {
            txtProblem.Text.Trim(),
            NullIfBlank(txtFindings.Text),
            cboStatus.Text,
            NullIfBlank(txtRemarks.Text),
            selectedRequestId
        }

        Dim requestSql As String =
            "UPDATE service_requests SET reported_problem=@p0,initial_findings=@p1,status=@p2,remarks=@p3 " &
            "WHERE request_id=@p4"

        Using requestCommand As MySqlCommand = CreateCommand(connection, requestSql, requestValues, transaction)
            requestCommand.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomer.SelectedIndexChanged

    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged

    End Sub

    Private Sub txtBrand_TextChanged(sender As Object, e As EventArgs) Handles txtBrand.TextChanged

    End Sub

    Private Sub txtModel_TextChanged(sender As Object, e As EventArgs) Handles txtModel.TextChanged

    End Sub

    Private Sub txtSerial_TextChanged(sender As Object, e As EventArgs) Handles txtSerial.TextChanged

    End Sub

    Private Sub txtColor_TextChanged(sender As Object, e As EventArgs) Handles txtColor.TextChanged

    End Sub

    Private Sub txtRemarks_TextChanged(sender As Object, e As EventArgs) Handles txtRemarks.TextChanged

    End Sub
End Class
