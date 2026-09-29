<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuotesPage
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents grid As DataGridView
    Friend WithEvents editorPanel As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRequest As Label
    Friend WithEvents cboRequest As ComboBox
    Friend WithEvents lblLabor As Label
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents lblParts As Label
    Friend WithEvents txtParts As TextBox
    Friend WithEvents lblOther As Label
    Friend WithEvents txtOther As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblValid As Label
    Friend WithEvents dtValid As DateTimePicker
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
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
        lblRequest = New Label()
        cboRequest = New ComboBox()
        lblLabor = New Label()
        txtLabor = New TextBox()
        lblParts = New Label()
        txtParts = New TextBox()
        lblOther = New Label()
        txtOther = New TextBox()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        lblValid = New Label()
        dtValid = New DateTimePicker()
        lblNotes = New Label()
        txtNotes = New TextBox()
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
        editorPanel.Controls.Add(lblRequest)
        editorPanel.Controls.Add(cboRequest)
        editorPanel.Controls.Add(lblLabor)
        editorPanel.Controls.Add(txtLabor)
        editorPanel.Controls.Add(lblParts)
        editorPanel.Controls.Add(txtParts)
        editorPanel.Controls.Add(lblOther)
        editorPanel.Controls.Add(txtOther)
        editorPanel.Controls.Add(lblStatus)
        editorPanel.Controls.Add(cboStatus)
        editorPanel.Controls.Add(lblValid)
        editorPanel.Controls.Add(dtValid)
        editorPanel.Controls.Add(lblNotes)
        editorPanel.Controls.Add(txtNotes)
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
        lblTitle.Size = New Size(84, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Quote"
        ' 
        ' lblRequest
        ' 
        lblRequest.AutoSize = True
        lblRequest.Location = New Point(18, 68)
        lblRequest.Margin = New Padding(0, 6, 0, 3)
        lblRequest.Name = "lblRequest"
        lblRequest.Size = New Size(72, 20)
        lblRequest.TabIndex = 1
        lblRequest.Text = "Request *"
        ' 
        ' cboRequest
        ' 
        cboRequest.DropDownStyle = ComboBoxStyle.DropDownList
        cboRequest.Location = New Point(21, 94)
        cboRequest.Name = "cboRequest"
        cboRequest.Size = New Size(260, 28)
        cboRequest.TabIndex = 2
        ' 
        ' lblLabor
        ' 
        lblLabor.AutoSize = True
        lblLabor.Location = New Point(18, 131)
        lblLabor.Margin = New Padding(0, 6, 0, 3)
        lblLabor.Name = "lblLabor"
        lblLabor.Size = New Size(47, 20)
        lblLabor.TabIndex = 3
        lblLabor.Text = "Labor"
        ' 
        ' txtLabor
        ' 
        txtLabor.Location = New Point(21, 157)
        txtLabor.Name = "txtLabor"
        txtLabor.Size = New Size(260, 27)
        txtLabor.TabIndex = 4
        ' 
        ' lblParts
        ' 
        lblParts.AutoSize = True
        lblParts.Location = New Point(18, 193)
        lblParts.Margin = New Padding(0, 6, 0, 3)
        lblParts.Name = "lblParts"
        lblParts.Size = New Size(40, 20)
        lblParts.TabIndex = 5
        lblParts.Text = "Parts"
        ' 
        ' txtParts
        ' 
        txtParts.Location = New Point(21, 219)
        txtParts.Name = "txtParts"
        txtParts.Size = New Size(260, 27)
        txtParts.TabIndex = 6
        ' 
        ' lblOther
        ' 
        lblOther.AutoSize = True
        lblOther.Location = New Point(18, 255)
        lblOther.Margin = New Padding(0, 6, 0, 3)
        lblOther.Name = "lblOther"
        lblOther.Size = New Size(46, 20)
        lblOther.TabIndex = 7
        lblOther.Text = "Other"
        ' 
        ' txtOther
        ' 
        txtOther.Location = New Point(21, 281)
        txtOther.Name = "txtOther"
        txtOther.Size = New Size(260, 27)
        txtOther.TabIndex = 8
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(18, 317)
        lblStatus.Margin = New Padding(0, 6, 0, 3)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(49, 20)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Location = New Point(21, 343)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(260, 28)
        cboStatus.TabIndex = 10
        ' 
        ' lblValid
        ' 
        lblValid.AutoSize = True
        lblValid.Location = New Point(18, 380)
        lblValid.Margin = New Padding(0, 6, 0, 3)
        lblValid.Name = "lblValid"
        lblValid.Size = New Size(75, 20)
        lblValid.TabIndex = 11
        lblValid.Text = "Valid until"
        ' 
        ' dtValid
        ' 
        dtValid.Format = DateTimePickerFormat.Short
        dtValid.Location = New Point(21, 406)
        dtValid.Name = "dtValid"
        dtValid.ShowCheckBox = True
        dtValid.Size = New Size(260, 27)
        dtValid.TabIndex = 12
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.Location = New Point(18, 442)
        lblNotes.Margin = New Padding(0, 6, 0, 3)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(86, 20)
        lblNotes.TabIndex = 13
        lblNotes.Text = "Reply notes"
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(21, 468)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.ScrollBars = ScrollBars.Vertical
        txtNotes.Size = New Size(260, 62)
        txtNotes.TabIndex = 14
        ' 
        ' buttonPanel
        ' 
        buttonPanel.AutoSize = True
        buttonPanel.Controls.Add(btnNew)
        buttonPanel.Controls.Add(btnSave)
        buttonPanel.Location = New Point(18, 549)
        buttonPanel.Margin = New Padding(0, 16, 0, 8)
        buttonPanel.Name = "buttonPanel"
        buttonPanel.Size = New Size(192, 40)
        buttonPanel.TabIndex = 15
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
        ' QuotesPage
        ' 
        Controls.Add(splitMain)
        Name = "QuotesPage"
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
