<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents content As Panel
    Friend WithEvents nav As FlowLayoutPanel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnIntake As Button
    Friend WithEvents btnQuotes As Button
    Friend WithEvents btnRepairs As Button
    Friend WithEvents btnRelease As Button
    Friend WithEvents btnStaff As Button

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        content = New Panel()
        btnStaff = New Button()
        btnRelease = New Button()
        btnRepairs = New Button()
        btnQuotes = New Button()
        btnIntake = New Button()
        btnCustomers = New Button()
        btnHome = New Button()
        title = New Label()
        nav = New FlowLayoutPanel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnLogout = New Button()
        Label1 = New Label()
        nav.SuspendLayout()
        SuspendLayout()
        ' 
        ' content
        ' 
        content.BackColor = Color.FromArgb(244, 246, 248)
        content.Dock = DockStyle.Fill
        content.Location = New Point(150, 0)
        content.Name = "content"
        content.Size = New Size(1082, 713)
        content.TabIndex = 0
        ' 
        ' btnStaff
        ' 
        btnStaff.ForeColor = SystemColors.ControlLightLight
        btnStaff.Location = New Point(15, 360)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(120, 40)
        btnStaff.TabIndex = 7
        btnStaff.Text = "Staff"
        ' 
        ' btnRelease
        ' 
        btnRelease.ForeColor = SystemColors.ControlLightLight
        btnRelease.Location = New Point(15, 314)
        btnRelease.Name = "btnRelease"
        btnRelease.Size = New Size(120, 40)
        btnRelease.TabIndex = 6
        btnRelease.Text = "Release"
        ' 
        ' btnRepairs
        ' 
        btnRepairs.ForeColor = SystemColors.ControlLightLight
        btnRepairs.Location = New Point(15, 268)
        btnRepairs.Name = "btnRepairs"
        btnRepairs.Size = New Size(120, 40)
        btnRepairs.TabIndex = 5
        btnRepairs.Text = "Repair"
        ' 
        ' btnQuotes
        ' 
        btnQuotes.ForeColor = SystemColors.ControlLightLight
        btnQuotes.Location = New Point(15, 222)
        btnQuotes.Name = "btnQuotes"
        btnQuotes.Size = New Size(120, 40)
        btnQuotes.TabIndex = 4
        btnQuotes.Text = "Quote"
        ' 
        ' btnIntake
        ' 
        btnIntake.ForeColor = SystemColors.ControlLightLight
        btnIntake.Location = New Point(15, 176)
        btnIntake.Name = "btnIntake"
        btnIntake.Size = New Size(120, 40)
        btnIntake.TabIndex = 3
        btnIntake.Text = "Intake"
        ' 
        ' btnCustomers
        ' 
        btnCustomers.ForeColor = SystemColors.ControlLightLight
        btnCustomers.Location = New Point(15, 130)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(120, 40)
        btnCustomers.TabIndex = 2
        btnCustomers.Text = "Customer"
        ' 
        ' btnHome
        ' 
        btnHome.ForeColor = SystemColors.ControlLightLight
        btnHome.Location = New Point(15, 84)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(120, 40)
        btnHome.TabIndex = 1
        btnHome.Text = "Dashboard"
        ' 
        ' title
        ' 
        title.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        title.ForeColor = Color.White
        title.Location = New Point(15, 18)
        title.Name = "title"
        title.Size = New Size(125, 63)
        title.TabIndex = 0
        title.Text = "REPAIR SHOP"
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' nav
        ' 
        nav.BackColor = Color.FromArgb(42, 57, 76)
        nav.Controls.Add(title)
        nav.Controls.Add(btnHome)
        nav.Controls.Add(btnCustomers)
        nav.Controls.Add(btnIntake)
        nav.Controls.Add(btnQuotes)
        nav.Controls.Add(btnRepairs)
        nav.Controls.Add(btnRelease)
        nav.Controls.Add(btnStaff)
        nav.Controls.Add(Label1)
        nav.Controls.Add(Label2)
        nav.Controls.Add(Label3)
        nav.Controls.Add(Label4)
        nav.Controls.Add(Label5)
        nav.Controls.Add(btnLogout)
        nav.Dock = DockStyle.Left
        nav.FlowDirection = FlowDirection.TopDown
        nav.Location = New Point(0, 0)
        nav.Name = "nav"
        nav.Padding = New Padding(12, 18, 12, 12)
        nav.Size = New Size(150, 713)
        nav.TabIndex = 1
        nav.WrapContents = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(15, 448)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 45)
        Label2.TabIndex = 9
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(15, 493)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 45)
        Label3.TabIndex = 10
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(15, 538)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 45)
        Label4.TabIndex = 11
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(15, 583)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 45)
        Label5.TabIndex = 12
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogout
        ' 
        btnLogout.ForeColor = SystemColors.ControlLightLight
        btnLogout.Location = New Point(15, 631)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(120, 40)
        btnLogout.TabIndex = 14
        btnLogout.Text = "Logout"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(15, 403)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 45)
        Label1.TabIndex = 8
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MainForm
        ' 
        ClientSize = New Size(1232, 713)
        Controls.Add(content)
        Controls.Add(nav)
        MinimumSize = New Size(1050, 650)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Computer Repair"
        nav.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private Shared Sub SetupNavButton(button As Button, text As String)
        button.Text = text
        button.Size = New Size(125, 42)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.ForeColor = Color.White
        button.BackColor = Color.FromArgb(42, 57, 76)
        button.TextAlign = ContentAlignment.MiddleLeft
        button.Padding = New Padding(12, 0, 0, 0)
    End Sub

    Friend WithEvents title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
End Class
