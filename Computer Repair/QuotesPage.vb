Imports System.Globalization
Imports System.ComponentModel
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Partial Class QuotesPage
    Private ReadOnly employeeId As Integer
    Private selectedQuoteId As Integer

    Public Sub New()
        Me.New(1)
    End Sub

    Public Sub New(currentEmployeeId As Integer)
        employeeId = currentEmployeeId
        InitializeComponent()
        cboStatus.Items.AddRange(New Object() {"DRAFT", "SENT", "APPROVED", "REJECTED", "CANCELLED"})
        cboStatus.SelectedIndex = 0
        txtLabor.Text = "0.00"
        txtParts.Text = "0.00"
        txtOther.Text = "0.00"

        AddHandler btnNew.Click, AddressOf ClearForm
        AddHandler btnSave.Click, AddressOf SaveQuote
        AddHandler grid.SelectionChanged, AddressOf SelectQuote
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        LoadRequestList()
        LoadQuotes()
    End Sub

    Private Sub LoadRequestList()
        Dim sql As String =
            "SELECT r.request_id id," &
            "CONCAT(LPAD(r.request_id,3,'0'),' - ',c.last_name,' / ',d.device_type) name " &
            "FROM service_requests r " &
            "JOIN devices d ON d.device_id=r.device_id " &
            "JOIN customers c ON c.customer_id=d.customer_id " &
            "WHERE r.status NOT IN ('RELEASED','CANCELLED') ORDER BY r.request_id DESC"

        BindCombo(cboRequest, GetTable(sql))
    End Sub

    Private Sub LoadQuotes()
        Try
            Dim sql As String =
                "SELECT q.quotation_id ID,q.request_id RequestID," &
                "CONCAT(c.last_name,', ',c.first_name) Customer,d.device_type Device," &
                "q.labor_cost Labor,q.parts_cost Parts,q.other_cost Other," &
                "q.total_estimated_cost Total,q.status Status,q.valid_until ValidUntil " &
                "FROM quotations q " &
                "JOIN service_requests r ON r.request_id=q.request_id " &
                "JOIN devices d ON d.device_id=r.device_id " &
                "JOIN customers c ON c.customer_id=d.customer_id " &
                "ORDER BY q.quotation_id DESC"

            grid.DataSource = GetTable(sql)
            FormatGridIds(grid)
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub SelectQuote(sender As Object, e As EventArgs)
        If grid.CurrentRow Is Nothing Then Return
        selectedQuoteId = Convert.ToInt32(grid.CurrentRow.Cells("ID").Value)
        cboRequest.SelectedValue = Convert.ToInt32(grid.CurrentRow.Cells("RequestID").Value)
        txtLabor.Text = Convert.ToDecimal(grid.CurrentRow.Cells("Labor").Value).ToString("0.00")
        txtParts.Text = Convert.ToDecimal(grid.CurrentRow.Cells("Parts").Value).ToString("0.00")
        txtOther.Text = Convert.ToDecimal(grid.CurrentRow.Cells("Other").Value).ToString("0.00")
        cboStatus.SelectedItem = grid.CurrentRow.Cells("Status").Value.ToString()
        Dim table = GetTable("SELECT customer_response_notes,valid_until FROM quotations WHERE quotation_id=@p0", selectedQuoteId)
        txtNotes.Text = table.Rows(0)("customer_response_notes").ToString()
        dtValid.Checked = table.Rows(0)("valid_until") IsNot DBNull.Value
        If dtValid.Checked Then dtValid.Value = Convert.ToDateTime(table.Rows(0)("valid_until"))
    End Sub

    Private Sub ClearForm(sender As Object, e As EventArgs)
        selectedQuoteId = 0
        txtLabor.Text = "0.00"
        txtParts.Text = "0.00"
        txtOther.Text = "0.00"
        txtNotes.Clear()
        cboStatus.SelectedIndex = 0
        dtValid.Checked = False
    End Sub

    Private Function ReadMoney(box As TextBox, ByRef amount As Decimal) As Boolean
        Return Decimal.TryParse(box.Text, NumberStyles.Number, CultureInfo.CurrentCulture, amount) AndAlso amount >= 0D
    End Function

    Private Sub SaveQuote(sender As Object, e As EventArgs)
        Dim labor As Decimal
        Dim parts As Decimal
        Dim other As Decimal

        If SelectedId(cboRequest) = 0 OrElse Not ReadMoney(txtLabor, labor) OrElse Not ReadMoney(txtParts, parts) OrElse Not ReadMoney(txtOther, other) Then
            MessageBox.Show(Me, "Choose a request and enter valid costs.", "Quote", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim requestId As Integer = SelectedId(cboRequest)

            If selectedQuoteId = 0 AndAlso QuoteExists(requestId) Then
                MessageBox.Show(Me, "This request already has a quote.", "Quote", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim total As Decimal = labor + parts + other
            Dim valid As Object = If(dtValid.Checked, CType(dtValid.Value.Date, Object), CType(DBNull.Value, Object))

            Using connection As MySqlConnection = OpenConnection()
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    If selectedQuoteId = 0 Then
                        InsertQuote(connection, transaction, requestId, labor, parts, other, total, valid)
                    Else
                        UpdateQuote(connection, transaction, requestId, labor, parts, other, total, valid)
                    End If

                    InsertQuoteItem(connection, transaction, "LABOR", "Labor", labor)
                    InsertQuoteItem(connection, transaction, "PART", "Parts", parts)
                    InsertQuoteItem(connection, transaction, "OTHER", "Other", other)
                    UpdateRequestStatus(connection, transaction, requestId)
                    transaction.Commit()
                End Using
            End Using

            LoadQuotes()
            MessageBox.Show(Me, "Quote saved. Total: " & total.ToString("N2"), "Quote")
            cboRequest.Focus()
            txtLabor.Clear()
            txtParts.Clear()
            txtOther.Clear()
            txtNotes.Clear()
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Function QuoteExists(requestId As Integer) As Boolean
        Dim count As Integer = Convert.ToInt32(GetValue(
            "SELECT COUNT(*) FROM quotations WHERE request_id=@p0", requestId))

        Return count > 0
    End Function

    Private Sub InsertQuote(connection As MySqlConnection, transaction As MySqlTransaction,
                            requestId As Integer, labor As Decimal, parts As Decimal,
                            other As Decimal, total As Decimal, validUntil As Object)
        Dim sql As String =
            "INSERT INTO quotations(request_id,prepared_by,labor_cost,parts_cost,other_cost," &
            "total_estimated_cost,status,customer_response_notes,valid_until) " &
            "VALUES(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)"

        Dim values As Object() = {
            requestId,
            employeeId,
            labor,
            parts,
            other,
            total,
            cboStatus.Text,
            NullIfBlank(txtNotes.Text),
            validUntil
        }

        Using command As MySqlCommand = CreateCommand(connection, sql, values, transaction)
            command.ExecuteNonQuery()
            selectedQuoteId = Convert.ToInt32(command.LastInsertedId)
        End Using
    End Sub

    Private Sub UpdateQuote(connection As MySqlConnection, transaction As MySqlTransaction,
                            requestId As Integer, labor As Decimal, parts As Decimal,
                            other As Decimal, total As Decimal, validUntil As Object)
        Dim sql As String =
            "UPDATE quotations SET request_id=@p0,labor_cost=@p1,parts_cost=@p2,other_cost=@p3," &
            "total_estimated_cost=@p4,status=@p5,customer_response_notes=@p6,valid_until=@p7," &
            "approved_at=IF(@p5='APPROVED',COALESCE(approved_at,NOW()),NULL)," &
            "rejected_at=IF(@p5='REJECTED',COALESCE(rejected_at,NOW()),NULL) " &
            "WHERE quotation_id=@p8"

        Dim values As Object() = {
            requestId,
            labor,
            parts,
            other,
            total,
            cboStatus.Text,
            NullIfBlank(txtNotes.Text),
            validUntil,
            selectedQuoteId
        }

        Using command As MySqlCommand = CreateCommand(connection, sql, values, transaction)
            command.ExecuteNonQuery()
        End Using

        Using command As MySqlCommand = CreateCommand(
            connection,
            "DELETE FROM quotation_items WHERE quotation_id=@p0",
            {selectedQuoteId},
            transaction)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub UpdateRequestStatus(connection As MySqlConnection, transaction As MySqlTransaction,
                                    requestId As Integer)
        Dim requestStatus As String

        Select Case cboStatus.Text
            Case "APPROVED"
                requestStatus = "APPROVED"
            Case "REJECTED"
                requestStatus = "REJECTED"
            Case "CANCELLED"
                requestStatus = "CANCELLED"
            Case "SENT"
                requestStatus = "AWAITING_APPROVAL"
            Case Else
                requestStatus = "FOR_QUOTATION"
        End Select

        Using command As MySqlCommand = CreateCommand(
            connection,
            "UPDATE service_requests SET status=@p0 WHERE request_id=@p1",
            {requestStatus, requestId},
            transaction)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub InsertQuoteItem(connection As MySqlConnection, transaction As MySqlTransaction,
                                itemType As String, description As String, amount As Decimal)
        If amount = 0D Then Return

        Dim sql As String =
            "INSERT INTO quotation_items(quotation_id,item_type,description,quantity,unit_price,subtotal) " &
            "VALUES(@p0,@p1,@p2,1,@p3,@p3)"

        Using command As MySqlCommand = CreateCommand(
            connection, sql, {selectedQuoteId, itemType, description, amount}, transaction)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub cboRequest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRequest.SelectedIndexChanged

    End Sub

    Private Sub txtLabor_TextChanged(sender As Object, e As EventArgs) Handles txtLabor.TextChanged

    End Sub

    Private Sub txtParts_TextChanged(sender As Object, e As EventArgs) Handles txtParts.TextChanged

    End Sub

    Private Sub txtOther_TextChanged(sender As Object, e As EventArgs) Handles txtOther.TextChanged

    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged

    End Sub
End Class
