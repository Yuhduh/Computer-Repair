Imports System.ComponentModel
Imports System.Windows.Forms

Public Partial Class EmployeesPage

    Private selectedId As Integer

    Public Sub New()
        InitializeComponent()
        cboRole.Items.AddRange(New Object() {"ADMIN", "RECEPTIONIST", "TECHNICIAN"})
        cboRole.SelectedIndex = 1
        txtPass.UseSystemPasswordChar = True
        AddHandler btnNew.Click, AddressOf ClearForm
        AddHandler btnSave.Click, AddressOf SaveEmployee
        AddHandler grid.SelectionChanged, AddressOf SelectEmployee
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        LoadEmployees()
    End Sub

    Private Sub LoadEmployees()
        Try
            Dim sql As String =
                "SELECT employee_id ID,first_name First,middle_name Middle,last_name Last," &
                "email Email,phone Phone,role Role,username User,is_active Active " &
                "FROM employees ORDER BY employee_id"

            grid.DataSource = GetTable(sql)
            FormatGridIds(grid)
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Sub SelectEmployee(sender As Object, e As EventArgs)
        If grid.CurrentRow Is Nothing Then Return
        selectedId = Convert.ToInt32(grid.CurrentRow.Cells("ID").Value)
        txtFirst.Text = grid.CurrentRow.Cells("First").Value.ToString()
        txtMiddle.Text = grid.CurrentRow.Cells("Middle").Value.ToString()
        txtLast.Text = grid.CurrentRow.Cells("Last").Value.ToString()
        txtEmail.Text = grid.CurrentRow.Cells("Email").Value.ToString()
        txtPhone.Text = grid.CurrentRow.Cells("Phone").Value.ToString()
        cboRole.SelectedItem = grid.CurrentRow.Cells("Role").Value.ToString()
        txtUser.Text = grid.CurrentRow.Cells("User").Value.ToString()
        txtPass.Clear()
        chkActive.Checked = Convert.ToBoolean(grid.CurrentRow.Cells("Active").Value)
    End Sub

    Private Sub ClearForm(sender As Object, e As EventArgs)
        selectedId = 0
        For Each box In {txtFirst, txtMiddle, txtLast, txtEmail, txtPhone, txtUser, txtPass}
            box.Clear()
        Next
        cboRole.SelectedIndex = 1
        chkActive.Checked = True
    End Sub

    Private Sub SaveEmployee(sender As Object, e As EventArgs)
        If Not HasRequiredFields() Then
            MessageBox.Show(Me, "Enter name, user, and password.", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If selectedId = 0 Then
                Dim sql As String =
                    "INSERT INTO employees(first_name,middle_name,last_name,email,phone,role," &
                    "username,password_hash,is_active) VALUES(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)"

                Execute(sql,
                    txtFirst.Text.Trim(),
                    NullIfBlank(txtMiddle.Text),
                    txtLast.Text.Trim(),
                    NullIfBlank(txtEmail.Text),
                    NullIfBlank(txtPhone.Text),
                    cboRole.Text,
                    txtUser.Text.Trim(),
                    txtPass.Text,
                    chkActive.Checked)
            Else
                Dim sql As String =
                    "UPDATE employees SET first_name=@p0,middle_name=@p1,last_name=@p2,email=@p3," &
                    "phone=@p4,role=@p5,username=@p6,is_active=@p7," &
                    "password_hash=IF(@p8='',password_hash,@p8) WHERE employee_id=@p9"

                Execute(sql,
                    txtFirst.Text.Trim(),
                    NullIfBlank(txtMiddle.Text),
                    txtLast.Text.Trim(),
                    NullIfBlank(txtEmail.Text),
                    NullIfBlank(txtPhone.Text),
                    cboRole.Text,
                    txtUser.Text.Trim(),
                    chkActive.Checked,
                    txtPass.Text,
                    selectedId)
            End If

            LoadEmployees()
            MessageBox.Show(Me, "Staff saved.", "Staff")
            txtFirst.Focus()
            txtFirst.Clear()
            txtMiddle.Clear()
            txtLast.Clear()
            txtEmail.Clear()
            txtPhone.Clear()
            txtUser.Clear()
            txtPass.Clear()
            cboRole.SelectedIndex = 1
            chkActive.Checked = True
        Catch ex As Exception
            ShowError(Me, ex)
        End Try
    End Sub

    Private Function HasRequiredFields() As Boolean
        If txtFirst.Text.Trim() = "" Then Return False
        If txtLast.Text.Trim() = "" Then Return False
        If txtUser.Text.Trim() = "" Then Return False
        If selectedId = 0 AndAlso txtPass.Text = "" Then Return False

        Return True
    End Function

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged

    End Sub
End Class
