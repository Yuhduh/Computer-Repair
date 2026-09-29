Imports System.ComponentModel
Imports System.Windows.Forms

Public Partial Class CustomersPage
    Private selectedId As Integer

    Public Sub New()
        InitializeComponent()
        AddHandler grid.SelectionChanged, AddressOf SelectCustomer
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()
        Try
            Dim sql As String =
                "SELECT customer_id ID, first_name First, middle_name Middle, last_name Last, " &
                "phone Phone, email Email, address Address " &
                "FROM customers ORDER BY customer_id DESC"

            grid.DataSource = GetTable(sql)
            FormatGridIds(grid)
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub SelectCustomer(sender As Object, e As EventArgs)
        If grid.CurrentRow Is Nothing Then Return
        selectedId = Convert.ToInt32(grid.CurrentRow.Cells("ID").Value)
        txtFirst.Text = grid.CurrentRow.Cells("First").Value.ToString()
        txtMiddle.Text = grid.CurrentRow.Cells("Middle").Value.ToString()
        txtLast.Text = grid.CurrentRow.Cells("Last").Value.ToString()
        txtPhone.Text = grid.CurrentRow.Cells("Phone").Value.ToString()
        txtEmail.Text = grid.CurrentRow.Cells("Email").Value.ToString()
        txtAddress.Text = grid.CurrentRow.Cells("Address").Value.ToString()
    End Sub


    Private Function HasRequiredFields() As Boolean
        If txtFirst.Text.Trim() = "" OrElse txtLast.Text.Trim() = "" OrElse txtPhone.Text.Trim() = "" Then
            MessageBox.Show(Me, "Enter first name, last name, and phone.", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not HasRequiredFields() Then Return

        Try
            If selectedId = 0 Then
                Dim sql As String =
                    "INSERT INTO customers(first_name,middle_name,last_name,phone,email,address) " &
                    "VALUES(@p0,@p1,@p2,@p3,@p4,@p5)"

                Execute(sql,
                    txtFirst.Text.Trim(),
                    NullIfBlank(txtMiddle.Text),
                    txtLast.Text.Trim(),
                    txtPhone.Text.Trim(),
                    NullIfBlank(txtEmail.Text),
                    NullIfBlank(txtAddress.Text))
            Else
                Dim sql As String =
                    "UPDATE customers SET first_name=@p0,middle_name=@p1,last_name=@p2,phone=@p3," &
                    "email=@p4,address=@p5 WHERE customer_id=@p6"

                Execute(sql,
                    txtFirst.Text.Trim(),
                    NullIfBlank(txtMiddle.Text),
                    txtLast.Text.Trim(),
                    txtPhone.Text.Trim(),
                    NullIfBlank(txtEmail.Text),
                    NullIfBlank(txtAddress.Text),
                    selectedId)
            End If
            LoadCustomers()
            MessageBox.Show(Me, "Customer saved.", "Customer")
            txtFirst.Focus()
            txtFirst.Clear()
            txtMiddle.Clear()
            txtLast.Clear()
            txtPhone.Clear()
            txtEmail.Clear()
            txtAddress.Clear()
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedId = 0 Then Return
        If MessageBox.Show(Me, "Delete this customer?", "Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Execute("DELETE FROM customers WHERE customer_id=@p0", selectedId)
            btnNew_Click(sender, e)
            LoadCustomers()
        Catch ex As Exception
            ShowError(Me, New Exception("This customer has a device or request and cannot be deleted."))
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        selectedId = 0
        For Each box In {txtFirst, txtMiddle, txtLast, txtPhone, txtEmail, txtAddress}
            box.Clear()
        Next
        txtFirst.Focus()
    End Sub
End Class
