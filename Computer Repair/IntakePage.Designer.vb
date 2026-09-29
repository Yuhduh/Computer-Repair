<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IntakePage
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents grid As DataGridView
    Friend WithEvents editorPanel As FlowLayoutPanel
    Friend WithEvents lblCustomer As Label
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents lblBrand As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents lblModel As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblSerial As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents lblColor As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblAccessories As Label
    Friend WithEvents txtAccessories As TextBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents lblProblem As Label
    Friend WithEvents txtProblem As TextBox
    Friend WithEvents lblFindings As Label
    Friend WithEvents txtFindings As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtRemarks As TextBox
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
        lblCustomer = New Label()
        cboCustomer = New ComboBox()
        lblType = New Label()
        txtType = New TextBox()
        lblBrand = New Label()
        txtBrand = New TextBox()
        lblModel = New Label()
        txtModel = New TextBox()
        lblSerial = New Label()
        txtSerial = New TextBox()
        lblColor = New Label()
        txtColor = New TextBox()
        lblAccessories = New Label()
        txtAccessories = New TextBox()
        lblCondition = New Label()
        txtCondition = New TextBox()
        lblProblem = New Label()
        txtProblem = New TextBox()
        lblFindings = New Label()
        txtFindings = New TextBox()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        lblRemarks = New Label()
        txtRemarks = New TextBox()
        btnNew = New Button()
        btnSave = New Button()
        buttonPanel = New FlowLayoutPanel()
        CType(splitMain, ComponentModel.ISupportInitialize).BeginInit()
        splitMain.Panel1.SuspendLayout()
        splitMain.Panel2.SuspendLayout()
        splitMain.SuspendLayout()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        editorPanel.SuspendLayout()
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
        splitMain.Size = New Size(1100, 765)
        splitMain.SplitterDistance = 762
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
        grid.Size = New Size(738, 741)
        grid.TabIndex = 0
        ' 
        ' editorPanel
        ' 
        editorPanel.AutoScroll = True
        editorPanel.BackColor = Color.White
        editorPanel.Controls.Add(lblCustomer)
        editorPanel.Controls.Add(cboCustomer)
        editorPanel.Controls.Add(lblType)
        editorPanel.Controls.Add(txtType)
        editorPanel.Controls.Add(lblBrand)
        editorPanel.Controls.Add(txtBrand)
        editorPanel.Controls.Add(lblModel)
        editorPanel.Controls.Add(txtModel)
        editorPanel.Controls.Add(lblSerial)
        editorPanel.Controls.Add(txtSerial)
        editorPanel.Controls.Add(lblColor)
        editorPanel.Controls.Add(txtColor)
        editorPanel.Controls.Add(lblAccessories)
        editorPanel.Controls.Add(txtAccessories)
        editorPanel.Controls.Add(lblCondition)
        editorPanel.Controls.Add(txtCondition)
        editorPanel.Controls.Add(lblProblem)
        editorPanel.Controls.Add(txtProblem)
        editorPanel.Controls.Add(lblFindings)
        editorPanel.Controls.Add(txtFindings)
        editorPanel.Controls.Add(lblStatus)
        editorPanel.Controls.Add(cboStatus)
        editorPanel.Controls.Add(lblRemarks)
        editorPanel.Controls.Add(txtRemarks)
        editorPanel.Controls.Add(btnNew)
        editorPanel.Controls.Add(btnSave)
        editorPanel.Controls.Add(buttonPanel)
        editorPanel.Dock = DockStyle.Fill
        editorPanel.FlowDirection = FlowDirection.TopDown
        editorPanel.Location = New Point(0, 0)
        editorPanel.Name = "editorPanel"
        editorPanel.Padding = New Padding(18)
        editorPanel.Size = New Size(334, 765)
        editorPanel.TabIndex = 0
        editorPanel.WrapContents = False
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Location = New Point(18, 24)
        lblCustomer.Margin = New Padding(0, 6, 0, 3)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(82, 20)
        lblCustomer.TabIndex = 1
        lblCustomer.Text = "Customer *"
        ' 
        ' cboCustomer
        ' 
        cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList
        cboCustomer.Location = New Point(21, 50)
        cboCustomer.Name = "cboCustomer"
        cboCustomer.Size = New Size(260, 28)
        cboCustomer.TabIndex = 2
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Location = New Point(18, 87)
        lblType.Margin = New Padding(0, 6, 0, 3)
        lblType.Name = "lblType"
        lblType.Size = New Size(97, 20)
        lblType.TabIndex = 3
        lblType.Text = "Device type *"
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(21, 113)
        txtType.Name = "txtType"
        txtType.Size = New Size(260, 27)
        txtType.TabIndex = 4
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Location = New Point(18, 149)
        lblBrand.Margin = New Padding(0, 6, 0, 3)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(48, 20)
        lblBrand.TabIndex = 5
        lblBrand.Text = "Brand"
        ' 
        ' txtBrand
        ' 
        txtBrand.Location = New Point(21, 175)
        txtBrand.Name = "txtBrand"
        txtBrand.Size = New Size(260, 27)
        txtBrand.TabIndex = 6
        ' 
        ' lblModel
        ' 
        lblModel.AutoSize = True
        lblModel.Location = New Point(18, 211)
        lblModel.Margin = New Padding(0, 6, 0, 3)
        lblModel.Name = "lblModel"
        lblModel.Size = New Size(52, 20)
        lblModel.TabIndex = 7
        lblModel.Text = "Model"
        ' 
        ' txtModel
        ' 
        txtModel.Location = New Point(21, 237)
        txtModel.Name = "txtModel"
        txtModel.Size = New Size(260, 27)
        txtModel.TabIndex = 8
        ' 
        ' lblSerial
        ' 
        lblSerial.AutoSize = True
        lblSerial.Location = New Point(18, 273)
        lblSerial.Margin = New Padding(0, 6, 0, 3)
        lblSerial.Name = "lblSerial"
        lblSerial.Size = New Size(70, 20)
        lblSerial.TabIndex = 9
        lblSerial.Text = "Serial no."
        ' 
        ' txtSerial
        ' 
        txtSerial.Location = New Point(21, 299)
        txtSerial.Name = "txtSerial"
        txtSerial.Size = New Size(260, 27)
        txtSerial.TabIndex = 10
        ' 
        ' lblColor
        ' 
        lblColor.AutoSize = True
        lblColor.Location = New Point(18, 335)
        lblColor.Margin = New Padding(0, 6, 0, 3)
        lblColor.Name = "lblColor"
        lblColor.Size = New Size(45, 20)
        lblColor.TabIndex = 11
        lblColor.Text = "Color"
        ' 
        ' txtColor
        ' 
        txtColor.Location = New Point(21, 361)
        txtColor.Name = "txtColor"
        txtColor.Size = New Size(260, 27)
        txtColor.TabIndex = 12
        ' 
        ' lblAccessories
        ' 
        lblAccessories.AutoSize = True
        lblAccessories.Location = New Point(18, 397)
        lblAccessories.Margin = New Padding(0, 6, 0, 3)
        lblAccessories.Name = "lblAccessories"
        lblAccessories.Size = New Size(105, 20)
        lblAccessories.TabIndex = 13
        lblAccessories.Text = "Items received"
        ' 
        ' txtAccessories
        ' 
        txtAccessories.Location = New Point(21, 423)
        txtAccessories.Multiline = True
        txtAccessories.Name = "txtAccessories"
        txtAccessories.ScrollBars = ScrollBars.Vertical
        txtAccessories.Size = New Size(260, 62)
        txtAccessories.TabIndex = 14
        ' 
        ' lblCondition
        ' 
        lblCondition.AutoSize = True
        lblCondition.Location = New Point(18, 494)
        lblCondition.Margin = New Padding(0, 6, 0, 3)
        lblCondition.Name = "lblCondition"
        lblCondition.Size = New Size(121, 20)
        lblCondition.TabIndex = 15
        lblCondition.Text = "Device condition"
        ' 
        ' txtCondition
        ' 
        txtCondition.Location = New Point(21, 520)
        txtCondition.Multiline = True
        txtCondition.Name = "txtCondition"
        txtCondition.ScrollBars = ScrollBars.Vertical
        txtCondition.Size = New Size(260, 62)
        txtCondition.TabIndex = 16
        ' 
        ' lblProblem
        ' 
        lblProblem.AutoSize = True
        lblProblem.Location = New Point(18, 591)
        lblProblem.Margin = New Padding(0, 6, 0, 3)
        lblProblem.Name = "lblProblem"
        lblProblem.Size = New Size(75, 20)
        lblProblem.TabIndex = 17
        lblProblem.Text = "Problem *"
        ' 
        ' txtProblem
        ' 
        txtProblem.Location = New Point(21, 617)
        txtProblem.Multiline = True
        txtProblem.Name = "txtProblem"
        txtProblem.ScrollBars = ScrollBars.Vertical
        txtProblem.Size = New Size(260, 62)
        txtProblem.TabIndex = 18
        ' 
        ' lblFindings
        ' 
        lblFindings.AutoSize = True
        lblFindings.Location = New Point(18, 688)
        lblFindings.Margin = New Padding(0, 6, 0, 3)
        lblFindings.Name = "lblFindings"
        lblFindings.Size = New Size(77, 20)
        lblFindings.TabIndex = 19
        lblFindings.Text = "First check"
        ' 
        ' txtFindings
        ' 
        txtFindings.Location = New Point(21, 714)
        txtFindings.Multiline = True
        txtFindings.Name = "txtFindings"
        txtFindings.ScrollBars = ScrollBars.Vertical
        txtFindings.Size = New Size(260, 62)
        txtFindings.TabIndex = 20
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(18, 785)
        lblStatus.Margin = New Padding(0, 6, 0, 3)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(49, 20)
        lblStatus.TabIndex = 21
        lblStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Location = New Point(21, 811)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(260, 28)
        cboStatus.TabIndex = 22
        ' 
        ' lblRemarks
        ' 
        lblRemarks.AutoSize = True
        lblRemarks.Location = New Point(18, 848)
        lblRemarks.Margin = New Padding(0, 6, 0, 3)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(48, 20)
        lblRemarks.TabIndex = 23
        lblRemarks.Text = "Notes"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(21, 874)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(260, 56)
        txtRemarks.TabIndex = 24
        ' 
        ' btnNew
        ' 
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.Location = New Point(21, 936)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(260, 34)
        btnNew.TabIndex = 0
        btnNew.Text = "New"
        ' 
        ' btnSave
        ' 
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(21, 976)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(260, 34)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        ' 
        ' buttonPanel
        ' 
        buttonPanel.AutoSize = True
        buttonPanel.Location = New Point(18, 1029)
        buttonPanel.Margin = New Padding(0, 16, 0, 8)
        buttonPanel.Name = "buttonPanel"
        buttonPanel.Size = New Size(0, 0)
        buttonPanel.TabIndex = 25
        buttonPanel.WrapContents = False
        ' 
        ' IntakePage
        ' 
        Controls.Add(splitMain)
        Name = "IntakePage"
        Size = New Size(1100, 765)
        splitMain.Panel1.ResumeLayout(False)
        splitMain.Panel2.ResumeLayout(False)
        CType(splitMain, ComponentModel.ISupportInitialize).EndInit()
        splitMain.ResumeLayout(False)
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        editorPanel.ResumeLayout(False)
        editorPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents buttonPanel As FlowLayoutPanel

End Class
