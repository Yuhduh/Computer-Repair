Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class MainForm
    Private ReadOnly employeeId As Integer

    Public Sub New()
        Me.New(1, "User", "ADMIN")
    End Sub

    Public Sub New(id As Integer, name As String, role As String)
        employeeId = id
        InitializeComponent()
        'BindNav(btnHome, Function() New HomePage())
        'BindNav(btnCustomers, Function() New CustomersPage())
        'BindNav(btnIntake, Function() New IntakePage(employeeId))
        'BindNav(btnQuotes, Function() New QuotesPage(employeeId))
        'BindNav(btnRepairs, Function() New RepairsPage())
        'BindNav(btnRelease, Function() New ReleasesPage(employeeId))
        'BindNav(btnStaff, Function() New EmployeesPage())
        'btnStaff.Visible = role = "ADMIN"
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        ShowPage(New HomePage())
    End Sub

    Private Sub BindNav(button As Button, pageFactory As Func(Of UserControl))
        AddHandler button.Click, Sub(sender, e) ShowPage(pageFactory())
    End Sub

    Private Sub ShowPage(page As UserControl)
        content.Controls.Clear()
        page.Dock = DockStyle.Fill
        content.Controls.Add(page)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowPage(New HomePage())
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ShowPage(New CustomersPage())
    End Sub

    Private Sub btnIntake_Click(sender As Object, e As EventArgs) Handles btnIntake.Click
        ShowPage(New IntakePage(employeeId))
    End Sub

    Private Sub btnQuotes_Click(sender As Object, e As EventArgs) Handles btnQuotes.Click
        ShowPage(New QuotesPage(employeeId))
    End Sub

    Private Sub btnRepairs_Click(sender As Object, e As EventArgs) Handles btnRepairs.Click
        ShowPage(New RepairsPage())
    End Sub

    Private Sub btnRelease_Click(sender As Object, e As EventArgs) Handles btnRelease.Click
        ShowPage(New ReleasesPage(employeeId))
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        ShowPage(New EmployeesPage)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Dispose()
        LoginForm.Show()
    End Sub
End Class
