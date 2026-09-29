Imports System.Drawing
Imports System.Windows.Forms

Public Class LoginForm
    Inherits Form
    Friend EmployeeId As Integer
    Friend EmployeeName As String = ""
    Friend EmployeeRole As String = ""

    Public Sub New()
        InitializeComponent()
        'AddHandler signInButton.Click, AddressOf SignIn
        AcceptButton = signInButton
        txtUser.Text = "admin"
    End Sub

    Private Sub signInButton_Click(sender As Object, e As EventArgs) Handles signInButton.Click
        Try
            Dim table = GetTable("SELECT employee_id, CONCAT(first_name, ' ', last_name) name, role " &
                                 "FROM employees WHERE username=@p0 AND password_hash=@p1 AND is_active=1",
                                 txtUser.Text.Trim(), txtPass.Text)
            If table.Rows.Count = 0 Then
                MessageBox.Show(Me, "Wrong user or password.", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            EmployeeId = Convert.ToInt32(table.Rows(0)("employee_id"))
            EmployeeName = table.Rows(0)("name").ToString()
            EmployeeRole = table.Rows(0)("role").ToString()
            Dim main As New MainForm(EmployeeId, EmployeeName, EmployeeRole)
            AddHandler main.FormClosed, Sub() Close()
            txtUser.Clear()
            txtPass.Clear()
            Hide()
            main.Show()
        Catch ex As Exception
            ShowError(Me, New Exception("Database connection failed. Check MySQL and the computer_repair database." & Environment.NewLine & ex.Message))
        End Try
    End Sub
End Class
