<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepairsPage
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents grid As DataGridView
    Friend WithEvents editorPanel As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblQuote As Label
    Friend WithEvents cboQuote As ComboBox
    Friend WithEvents lblTech As Label
    Friend WithEvents cboTech As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblDiagnosis As Label
    Friend WithEvents txtDiagnosis As TextBox
    Friend WithEvents lblAction As Label
    Friend WithEvents txtAction As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents jobButtonPanel As FlowLayoutPanel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblPartsGrid As Label
    Friend WithEvents partsGrid As DataGridView
    Friend WithEvents lblPart As Label
    Friend WithEvents txtPart As TextBox
    Friend WithEvents lblPartDesc As Label
    Friend WithEvents txtPartDesc As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblUnitCost As Label
    Friend WithEvents txtUnitCost As TextBox
    Friend WithEvents partButtonPanel As FlowLayoutPanel
    Friend WithEvents btnAddPart As Button
    Friend WithEvents btnRemovePart As Button

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        splitMain = New SplitContainer()
        grid = New DataGridView()
        editorPanel = New FlowLayoutPanel()
        lblTitle = New Label()
        lblQuote = New Label()
        cboQuote = New ComboBox()
        lblTech = New Label()
        cboTech = New ComboBox()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        lblDiagnosis = New Label()
        txtDiagnosis = New TextBox()
        lblAction = New Label()
        txtAction = New TextBox()
        lblNotes = New Label()
        txtNotes = New TextBox()
        jobButtonPanel = New FlowLayoutPanel()
        btnNew = New Button()
        btnSave = New Button()
        lblPartsGrid = New Label()
        partsGrid = New DataGridView()
        lblPart = New Label()
        txtPart = New TextBox()
        lblPartDesc = New Label()
        txtPartDesc = New TextBox()
        lblQty = New Label()
        txtQty = New TextBox()
        lblUnitCost = New Label()
        txtUnitCost = New TextBox()
        partButtonPanel = New FlowLayoutPanel()
        btnRemovePart = New Button()
        btnAddPart = New Button()
        CType(splitMain, ComponentModel.ISupportInitialize).BeginInit()
        splitMain.Panel1.SuspendLayout()
        splitMain.Panel2.SuspendLayout()
        splitMain.SuspendLayout()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        editorPanel.SuspendLayout()
        jobButtonPanel.SuspendLayout()
        CType(partsGrid, ComponentModel.ISupportInitialize).BeginInit()
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
        editorPanel.Controls.Add(lblQuote)
        editorPanel.Controls.Add(cboQuote)
        editorPanel.Controls.Add(lblTech)
        editorPanel.Controls.Add(cboTech)
        editorPanel.Controls.Add(lblStatus)
        editorPanel.Controls.Add(cboStatus)
        editorPanel.Controls.Add(lblDiagnosis)
        editorPanel.Controls.Add(txtDiagnosis)
        editorPanel.Controls.Add(lblAction)
        editorPanel.Controls.Add(txtAction)
        editorPanel.Controls.Add(lblNotes)
        editorPanel.Controls.Add(txtNotes)
        editorPanel.Controls.Add(jobButtonPanel)
        editorPanel.Controls.Add(lblPartsGrid)
        editorPanel.Controls.Add(partsGrid)
        editorPanel.Controls.Add(lblPart)
        editorPanel.Controls.Add(txtPart)
        editorPanel.Controls.Add(lblPartDesc)
        editorPanel.Controls.Add(txtPartDesc)
        editorPanel.Controls.Add(lblQty)
        editorPanel.Controls.Add(txtQty)
        editorPanel.Controls.Add(lblUnitCost)
        editorPanel.Controls.Add(txtUnitCost)
        editorPanel.Controls.Add(btnRemovePart)
        editorPanel.Controls.Add(btnAddPart)
        editorPanel.Controls.Add(partButtonPanel)
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
        lblTitle.Size = New Size(87, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Repair"
        ' 
        ' lblQuote
        ' 
        lblQuote.AutoSize = True
        lblQuote.Location = New Point(18, 68)
        lblQuote.Margin = New Padding(0, 6, 0, 3)
        lblQuote.Name = "lblQuote"
        lblQuote.Size = New Size(60, 20)
        lblQuote.TabIndex = 1
        lblQuote.Text = "Quote *"
        ' 
        ' cboQuote
        ' 
        cboQuote.DropDownStyle = ComboBoxStyle.DropDownList
        cboQuote.Location = New Point(21, 94)
        cboQuote.Name = "cboQuote"
        cboQuote.Size = New Size(260, 28)
        cboQuote.TabIndex = 2
        ' 
        ' lblTech
        ' 
        lblTech.AutoSize = True
        lblTech.Location = New Point(18, 131)
        lblTech.Margin = New Padding(0, 6, 0, 3)
        lblTech.Name = "lblTech"
        lblTech.Size = New Size(88, 20)
        lblTech.TabIndex = 3
        lblTech.Text = "Technician *"
        ' 
        ' cboTech
        ' 
        cboTech.DropDownStyle = ComboBoxStyle.DropDownList
        cboTech.Location = New Point(21, 157)
        cboTech.Name = "cboTech"
        cboTech.Size = New Size(260, 28)
        cboTech.TabIndex = 4
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(18, 194)
        lblStatus.Margin = New Padding(0, 6, 0, 3)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(49, 20)
        lblStatus.TabIndex = 5
        lblStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Location = New Point(21, 220)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(260, 28)
        cboStatus.TabIndex = 6
        ' 
        ' lblDiagnosis
        ' 
        lblDiagnosis.AutoSize = True
        lblDiagnosis.Location = New Point(18, 257)
        lblDiagnosis.Margin = New Padding(0, 6, 0, 3)
        lblDiagnosis.Name = "lblDiagnosis"
        lblDiagnosis.Size = New Size(74, 20)
        lblDiagnosis.TabIndex = 7
        lblDiagnosis.Text = "Diagnosis"
        ' 
        ' txtDiagnosis
        ' 
        txtDiagnosis.Location = New Point(21, 283)
        txtDiagnosis.Multiline = True
        txtDiagnosis.Name = "txtDiagnosis"
        txtDiagnosis.ScrollBars = ScrollBars.Vertical
        txtDiagnosis.Size = New Size(260, 62)
        txtDiagnosis.TabIndex = 8
        ' 
        ' lblAction
        ' 
        lblAction.AutoSize = True
        lblAction.Location = New Point(18, 354)
        lblAction.Margin = New Padding(0, 6, 0, 3)
        lblAction.Name = "lblAction"
        lblAction.Size = New Size(81, 20)
        lblAction.TabIndex = 9
        lblAction.Text = "Work done"
        ' 
        ' txtAction
        ' 
        txtAction.Location = New Point(21, 380)
        txtAction.Multiline = True
        txtAction.Name = "txtAction"
        txtAction.ScrollBars = ScrollBars.Vertical
        txtAction.Size = New Size(260, 62)
        txtAction.TabIndex = 10
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.Location = New Point(18, 451)
        lblNotes.Margin = New Padding(0, 6, 0, 3)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(48, 20)
        lblNotes.TabIndex = 11
        lblNotes.Text = "Notes"
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(21, 477)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.ScrollBars = ScrollBars.Vertical
        txtNotes.Size = New Size(260, 62)
        txtNotes.TabIndex = 12
        ' 
        ' jobButtonPanel
        ' 
        jobButtonPanel.AutoSize = True
        jobButtonPanel.Controls.Add(btnNew)
        jobButtonPanel.Controls.Add(btnSave)
        jobButtonPanel.Location = New Point(18, 558)
        jobButtonPanel.Margin = New Padding(0, 16, 0, 8)
        jobButtonPanel.Name = "jobButtonPanel"
        jobButtonPanel.Size = New Size(192, 40)
        jobButtonPanel.TabIndex = 13
        jobButtonPanel.WrapContents = False
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
        ' lblPartsGrid
        ' 
        lblPartsGrid.AutoSize = True
        lblPartsGrid.Location = New Point(18, 612)
        lblPartsGrid.Margin = New Padding(0, 6, 0, 3)
        lblPartsGrid.Name = "lblPartsGrid"
        lblPartsGrid.Size = New Size(75, 20)
        lblPartsGrid.TabIndex = 14
        lblPartsGrid.Text = "Parts used"
        ' 
        ' partsGrid
        ' 
        partsGrid.AllowUserToAddRows = False
        partsGrid.AllowUserToDeleteRows = False
        partsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        partsGrid.ColumnHeadersHeight = 29
        partsGrid.Location = New Point(21, 638)
        partsGrid.MultiSelect = False
        partsGrid.Name = "partsGrid"
        partsGrid.ReadOnly = True
        partsGrid.RowHeadersVisible = False
        partsGrid.RowHeadersWidth = 51
        partsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        partsGrid.Size = New Size(280, 120)
        partsGrid.TabIndex = 15
        ' 
        ' lblPart
        ' 
        lblPart.AutoSize = True
        lblPart.Location = New Point(18, 767)
        lblPart.Margin = New Padding(0, 6, 0, 3)
        lblPart.Name = "lblPart"
        lblPart.Size = New Size(75, 20)
        lblPart.TabIndex = 16
        lblPart.Text = "Part name"
        ' 
        ' txtPart
        ' 
        txtPart.Location = New Point(21, 793)
        txtPart.Name = "txtPart"
        txtPart.Size = New Size(260, 27)
        txtPart.TabIndex = 17
        ' 
        ' lblPartDesc
        ' 
        lblPartDesc.AutoSize = True
        lblPartDesc.Location = New Point(18, 829)
        lblPartDesc.Margin = New Padding(0, 6, 0, 3)
        lblPartDesc.Name = "lblPartDesc"
        lblPartDesc.Size = New Size(82, 20)
        lblPartDesc.TabIndex = 18
        lblPartDesc.Text = "Part details"
        ' 
        ' txtPartDesc
        ' 
        txtPartDesc.Location = New Point(21, 855)
        txtPartDesc.Name = "txtPartDesc"
        txtPartDesc.Size = New Size(260, 27)
        txtPartDesc.TabIndex = 19
        ' 
        ' lblQty
        ' 
        lblQty.AutoSize = True
        lblQty.Location = New Point(18, 891)
        lblQty.Margin = New Padding(0, 6, 0, 3)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(32, 20)
        lblQty.TabIndex = 20
        lblQty.Text = "Qty"
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(21, 917)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(260, 27)
        txtQty.TabIndex = 21
        ' 
        ' lblUnitCost
        ' 
        lblUnitCost.AutoSize = True
        lblUnitCost.Location = New Point(18, 953)
        lblUnitCost.Margin = New Padding(0, 6, 0, 3)
        lblUnitCost.Name = "lblUnitCost"
        lblUnitCost.Size = New Size(67, 20)
        lblUnitCost.TabIndex = 22
        lblUnitCost.Text = "Unit cost"
        ' 
        ' txtUnitCost
        ' 
        txtUnitCost.Location = New Point(21, 979)
        txtUnitCost.Name = "txtUnitCost"
        txtUnitCost.Size = New Size(260, 27)
        txtUnitCost.TabIndex = 23
        ' 
        ' partButtonPanel
        ' 
        partButtonPanel.AutoSize = True
        partButtonPanel.Location = New Point(18, 1105)
        partButtonPanel.Margin = New Padding(0, 16, 0, 8)
        partButtonPanel.Name = "partButtonPanel"
        partButtonPanel.Size = New Size(0, 0)
        partButtonPanel.TabIndex = 24
        partButtonPanel.WrapContents = False
        ' 
        ' btnRemovePart
        ' 
        btnRemovePart.FlatStyle = FlatStyle.Flat
        btnRemovePart.Location = New Point(21, 1012)
        btnRemovePart.Name = "btnRemovePart"
        btnRemovePart.Size = New Size(260, 34)
        btnRemovePart.TabIndex = 1
        btnRemovePart.Text = "Remove"
        ' 
        ' btnAddPart
        ' 
        btnAddPart.FlatStyle = FlatStyle.Flat
        btnAddPart.Location = New Point(21, 1052)
        btnAddPart.Name = "btnAddPart"
        btnAddPart.Size = New Size(260, 34)
        btnAddPart.TabIndex = 0
        btnAddPart.Text = "Add part"
        ' 
        ' RepairsPage
        ' 
        Controls.Add(splitMain)
        Name = "RepairsPage"
        Size = New Size(1100, 700)
        splitMain.Panel1.ResumeLayout(False)
        splitMain.Panel2.ResumeLayout(False)
        CType(splitMain, ComponentModel.ISupportInitialize).EndInit()
        splitMain.ResumeLayout(False)
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        editorPanel.ResumeLayout(False)
        editorPanel.PerformLayout()
        jobButtonPanel.ResumeLayout(False)
        CType(partsGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
