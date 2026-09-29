<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReleasesPage
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents grid As DataGridView
    Friend WithEvents editorPanel As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRepair As Label
    Friend WithEvents cboRepair As ComboBox
    Friend WithEvents lblReceivedBy As Label
    Friend WithEvents txtReceivedBy As TextBox
    Friend WithEvents lblRelation As Label
    Friend WithEvents txtRelation As TextBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtRemarks As TextBox
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
        lblRepair = New Label()
        cboRepair = New ComboBox()
        lblReceivedBy = New Label()
        txtReceivedBy = New TextBox()
        lblRelation = New Label()
        txtRelation = New TextBox()
        lblCondition = New Label()
        txtCondition = New TextBox()
        lblRemarks = New Label()
        txtRemarks = New TextBox()
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
        editorPanel.Controls.Add(lblRepair)
        editorPanel.Controls.Add(cboRepair)
        editorPanel.Controls.Add(lblReceivedBy)
        editorPanel.Controls.Add(txtReceivedBy)
        editorPanel.Controls.Add(lblRelation)
        editorPanel.Controls.Add(txtRelation)
        editorPanel.Controls.Add(lblCondition)
        editorPanel.Controls.Add(txtCondition)
        editorPanel.Controls.Add(lblRemarks)
        editorPanel.Controls.Add(txtRemarks)
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
        lblTitle.Size = New Size(99, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Release"
        ' 
        ' lblRepair
        ' 
        lblRepair.AutoSize = True
        lblRepair.Location = New Point(18, 68)
        lblRepair.Margin = New Padding(0, 6, 0, 3)
        lblRepair.Name = "lblRepair"
        lblRepair.Size = New Size(62, 20)
        lblRepair.TabIndex = 1
        lblRepair.Text = "Repair *"
        ' 
        ' cboRepair
        ' 
        cboRepair.DropDownStyle = ComboBoxStyle.DropDownList
        cboRepair.Location = New Point(21, 94)
        cboRepair.Name = "cboRepair"
        cboRepair.Size = New Size(260, 28)
        cboRepair.TabIndex = 2
        ' 
        ' lblReceivedBy
        ' 
        lblReceivedBy.AutoSize = True
        lblReceivedBy.Location = New Point(18, 131)
        lblReceivedBy.Margin = New Padding(0, 6, 0, 3)
        lblReceivedBy.Name = "lblReceivedBy"
        lblReceivedBy.Size = New Size(99, 20)
        lblReceivedBy.TabIndex = 3
        lblReceivedBy.Text = "Received by *"
        ' 
        ' txtReceivedBy
        ' 
        txtReceivedBy.Location = New Point(21, 157)
        txtReceivedBy.Name = "txtReceivedBy"
        txtReceivedBy.Size = New Size(260, 27)
        txtReceivedBy.TabIndex = 4
        ' 
        ' lblRelation
        ' 
        lblRelation.AutoSize = True
        lblRelation.Location = New Point(18, 193)
        lblRelation.Margin = New Padding(0, 6, 0, 3)
        lblRelation.Name = "lblRelation"
        lblRelation.Size = New Size(64, 20)
        lblRelation.TabIndex = 5
        lblRelation.Text = "Relation"
        ' 
        ' txtRelation
        ' 
        txtRelation.Location = New Point(21, 219)
        txtRelation.Name = "txtRelation"
        txtRelation.Size = New Size(260, 27)
        txtRelation.TabIndex = 6
        ' 
        ' lblCondition
        ' 
        lblCondition.AutoSize = True
        lblCondition.Location = New Point(18, 255)
        lblCondition.Margin = New Padding(0, 6, 0, 3)
        lblCondition.Name = "lblCondition"
        lblCondition.Size = New Size(121, 20)
        lblCondition.TabIndex = 7
        lblCondition.Text = "Device condition"
        ' 
        ' txtCondition
        ' 
        txtCondition.Location = New Point(21, 281)
        txtCondition.Multiline = True
        txtCondition.Name = "txtCondition"
        txtCondition.ScrollBars = ScrollBars.Vertical
        txtCondition.Size = New Size(260, 62)
        txtCondition.TabIndex = 8
        ' 
        ' lblRemarks
        ' 
        lblRemarks.AutoSize = True
        lblRemarks.Location = New Point(18, 352)
        lblRemarks.Margin = New Padding(0, 6, 0, 3)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(48, 20)
        lblRemarks.TabIndex = 9
        lblRemarks.Text = "Notes"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(21, 378)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(260, 62)
        txtRemarks.TabIndex = 10
        ' 
        ' buttonPanel
        ' 
        buttonPanel.AutoSize = True
        buttonPanel.Controls.Add(btnNew)
        buttonPanel.Controls.Add(btnSave)
        buttonPanel.Location = New Point(18, 459)
        buttonPanel.Margin = New Padding(0, 16, 0, 8)
        buttonPanel.Name = "buttonPanel"
        buttonPanel.Size = New Size(192, 40)
        buttonPanel.TabIndex = 11
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
        ' ReleasesPage
        ' 
        Controls.Add(splitMain)
        Name = "ReleasesPage"
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
