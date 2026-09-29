<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeesPage
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents grid As DataGridView
    Friend WithEvents editorPanel As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents lblMiddle As Label
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents lblLast As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents buttonPanel As FlowLayoutPanel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        splitMain = New SplitContainer()
        grid = New DataGridView()
        editorPanel = New FlowLayoutPanel()
        lblTitle = New Label()
        lblFirst = New Label()
        txtFirst = New TextBox()
        lblMiddle = New Label()
        txtMiddle = New TextBox()
        lblLast = New Label()
        txtLast = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblPhone = New Label()
        txtPhone = New TextBox()
        lblRole = New Label()
        cboRole = New ComboBox()
        lblUser = New Label()
        txtUser = New TextBox()
        lblPass = New Label()
        txtPass = New TextBox()
        chkActive = New CheckBox()
        buttonPanel = New FlowLayoutPanel()
        btnNew = New Button()
        btnSave = New Button()
        CType(splitMain, ComponentModel.ISupportInitialize).BeginInit()
        splitMain.Panel1.SuspendLayout()
        splitMain.Panel2.SuspendLayout()
        splitMain.SuspendLayout()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        editorPanel.SuspendLayout()
        buttonPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' splitMain
        ' 
        splitMain.Dock = DockStyle.Fill
        splitMain.FixedPanel = FixedPanel.Panel2
        splitMain.Location = New Point(0, 0)
        splitMain.Name = "splitMain"
        ' 
        ' splitMain.Panel1
        ' 
        splitMain.Panel1.Controls.Add(grid)
        splitMain.Panel1.Padding = New Padding(12)
        ' 
        ' splitMain.Panel2
        ' 
        splitMain.Panel2.Controls.Add(editorPanel)
        splitMain.Panel2MinSize = 330
        splitMain.Size = New Size(1100, 700)
        splitMain.SplitterDistance = 750
        splitMain.TabIndex = 0
        ' 
        ' grid
        ' 
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.BackgroundColor = Color.White
        grid.ColumnHeadersHeight = 29
        grid.Dock = DockStyle.Fill
        grid.Location = New Point(12, 12)
        grid.MultiSelect = False
        grid.Name = "grid"
        grid.ReadOnly = True
        grid.RowHeadersVisible = False
        grid.RowHeadersWidth = 51
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.Size = New Size(726, 676)
        grid.TabIndex = 0
        ' 
        ' editorPanel
        ' 
        editorPanel.AutoScroll = True
        editorPanel.BackColor = Color.White
        editorPanel.Controls.Add(lblTitle)
        editorPanel.Controls.Add(lblFirst)
        editorPanel.Controls.Add(txtFirst)
        editorPanel.Controls.Add(lblMiddle)
        editorPanel.Controls.Add(txtMiddle)
        editorPanel.Controls.Add(lblLast)
        editorPanel.Controls.Add(txtLast)
        editorPanel.Controls.Add(lblEmail)
        editorPanel.Controls.Add(txtEmail)
        editorPanel.Controls.Add(lblPhone)
        editorPanel.Controls.Add(txtPhone)
        editorPanel.Controls.Add(lblRole)
        editorPanel.Controls.Add(cboRole)
        editorPanel.Controls.Add(lblUser)
        editorPanel.Controls.Add(txtUser)
        editorPanel.Controls.Add(lblPass)
        editorPanel.Controls.Add(txtPass)
        editorPanel.Controls.Add(chkActive)
        editorPanel.Controls.Add(buttonPanel)
        editorPanel.Dock = DockStyle.Fill
        editorPanel.FlowDirection = FlowDirection.TopDown
        editorPanel.Location = New Point(0, 0)
        editorPanel.Name = "editorPanel"
        editorPanel.Padding = New Padding(18)
        editorPanel.Size = New Size(346, 700)
        editorPanel.TabIndex = 0
        editorPanel.WrapContents = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTitle.Location = New Point(18, 18)
        lblTitle.Margin = New Padding(0, 0, 0, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(66, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Staff"
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Location = New Point(18, 68)
        lblFirst.Margin = New Padding(0, 6, 0, 3)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(87, 20)
        lblFirst.TabIndex = 1
        lblFirst.Text = "First name *"
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(21, 94)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(260, 27)
        txtFirst.TabIndex = 2
        ' 
        ' lblMiddle
        ' 
        lblMiddle.AutoSize = True
        lblMiddle.Location = New Point(18, 130)
        lblMiddle.Margin = New Padding(0, 6, 0, 3)
        lblMiddle.Name = "lblMiddle"
        lblMiddle.Size = New Size(97, 20)
        lblMiddle.TabIndex = 3
        lblMiddle.Text = "Middle name"
        ' 
        ' txtMiddle
        ' 
        txtMiddle.Location = New Point(21, 156)
        txtMiddle.Name = "txtMiddle"
        txtMiddle.Size = New Size(260, 27)
        txtMiddle.TabIndex = 4
        ' 
        ' lblLast
        ' 
        lblLast.AutoSize = True
        lblLast.Location = New Point(18, 192)
        lblLast.Margin = New Padding(0, 6, 0, 3)
        lblLast.Name = "lblLast"
        lblLast.Size = New Size(86, 20)
        lblLast.TabIndex = 5
        lblLast.Text = "Last name *"
        ' 
        ' txtLast
        ' 
        txtLast.Location = New Point(21, 218)
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(260, 27)
        txtLast.TabIndex = 6
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(18, 254)
        lblEmail.Margin = New Padding(0, 6, 0, 3)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(21, 280)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(260, 27)
        txtEmail.TabIndex = 8
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(18, 316)
        lblPhone.Margin = New Padding(0, 6, 0, 3)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 9
        lblPhone.Text = "Phone"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(21, 342)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(260, 27)
        txtPhone.TabIndex = 10
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(18, 378)
        lblRole.Margin = New Padding(0, 6, 0, 3)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(39, 20)
        lblRole.TabIndex = 11
        lblRole.Text = "Role"
        ' 
        ' cboRole
        ' 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.Location = New Point(21, 404)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(260, 28)
        cboRole.TabIndex = 12
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Location = New Point(18, 441)
        lblUser.Margin = New Padding(0, 6, 0, 3)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(48, 20)
        lblUser.TabIndex = 13
        lblUser.Text = "User *"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(21, 467)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(260, 27)
        txtUser.TabIndex = 14
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(18, 503)
        lblPass.Margin = New Padding(0, 6, 0, 3)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(70, 20)
        lblPass.TabIndex = 15
        lblPass.Text = "Password"
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(21, 529)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(260, 27)
        txtPass.TabIndex = 16
        txtPass.UseSystemPasswordChar = True
        ' 
        ' chkActive
        ' 
        chkActive.AutoSize = True
        chkActive.Checked = True
        chkActive.CheckState = CheckState.Checked
        chkActive.Location = New Point(21, 562)
        chkActive.Name = "chkActive"
        chkActive.Size = New Size(72, 24)
        chkActive.TabIndex = 17
        chkActive.Text = "Active"
        ' 
        ' buttonPanel
        ' 
        buttonPanel.AutoSize = True
        buttonPanel.Controls.Add(btnNew)
        buttonPanel.Controls.Add(btnSave)
        buttonPanel.Location = New Point(18, 605)
        buttonPanel.Margin = New Padding(0, 16, 0, 8)
        buttonPanel.Name = "buttonPanel"
        buttonPanel.Size = New Size(192, 40)
        buttonPanel.TabIndex = 18
        buttonPanel.WrapContents = False
        ' 
        ' btnNew
        ' 
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.Location = New Point(3, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(90, 34)
        btnNew.TabIndex = 0
        btnNew.Text = "New"
        ' 
        ' btnSave
        ' 
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(99, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(90, 34)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        ' 
        ' EmployeesPage
        ' 
        Controls.Add(splitMain)
        Name = "EmployeesPage"
        Size = New Size(1100, 700)
        splitMain.Panel1.ResumeLayout(False)
        splitMain.Panel2.ResumeLayout(False)
        CType(splitMain, ComponentModel.ISupportInitialize).EndInit()
        splitMain.ResumeLayout(False)
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        editorPanel.ResumeLayout(False)
        editorPanel.PerformLayout()
        buttonPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
End Class
