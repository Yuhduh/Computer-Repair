<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Private components As System.ComponentModel.IContainer
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents signInButton As Button

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        txtUser = New TextBox()
        txtPass = New TextBox()
        signInButton = New Button()
        card = New FlowLayoutPanel()
        title = New Label()
        userLabel = New Label()
        passLabel = New Label()
        card.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(61, 111)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(260, 27)
        txtUser.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(61, 173)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(260, 27)
        txtPass.TabIndex = 4
        txtPass.UseSystemPasswordChar = True
        ' 
        ' signInButton
        ' 
        signInButton.FlatStyle = FlatStyle.Flat
        signInButton.Location = New Point(58, 219)
        signInButton.Margin = New Padding(0, 16, 0, 0)
        signInButton.Name = "signInButton"
        signInButton.Size = New Size(260, 34)
        signInButton.TabIndex = 5
        signInButton.Text = "Sign in"
        ' 
        ' card
        ' 
        card.Controls.Add(title)
        card.Controls.Add(userLabel)
        card.Controls.Add(txtUser)
        card.Controls.Add(passLabel)
        card.Controls.Add(txtPass)
        card.Controls.Add(signInButton)
        card.Dock = DockStyle.Fill
        card.FlowDirection = FlowDirection.TopDown
        card.Location = New Point(0, 0)
        card.Name = "card"
        card.Padding = New Padding(58, 35, 40, 25)
        card.Size = New Size(380, 300)
        card.TabIndex = 0
        card.WrapContents = False
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        title.Location = New Point(58, 35)
        title.Margin = New Padding(0, 0, 0, 12)
        title.Name = "title"
        title.Size = New Size(151, 32)
        title.TabIndex = 0
        title.Text = "Repair Shop"
        ' 
        ' userLabel
        ' 
        userLabel.AutoSize = True
        userLabel.Location = New Point(58, 85)
        userLabel.Margin = New Padding(0, 6, 0, 3)
        userLabel.Name = "userLabel"
        userLabel.Size = New Size(38, 20)
        userLabel.TabIndex = 1
        userLabel.Text = "User"
        ' 
        ' passLabel
        ' 
        passLabel.AutoSize = True
        passLabel.Location = New Point(58, 147)
        passLabel.Margin = New Padding(0, 6, 0, 3)
        passLabel.Name = "passLabel"
        passLabel.Size = New Size(70, 20)
        passLabel.TabIndex = 3
        passLabel.Text = "Password"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        ClientSize = New Size(380, 300)
        Controls.Add(card)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Repair Shop - Sign in"
        card.ResumeLayout(False)
        card.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents card As FlowLayoutPanel
    Friend WithEvents title As Label
    Friend WithEvents userLabel As Label
    Friend WithEvents passLabel As Label
End Class
