<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer
    Friend WithEvents cards As FlowLayoutPanel
    Friend WithEvents pnlOpen As Panel
    Friend WithEvents lblOpenCount As Label
    Friend WithEvents lblOpen As Label
    Friend WithEvents pnlRepairing As Panel
    Friend WithEvents lblRepairingCount As Label
    Friend WithEvents lblRepairing As Label
    Friend WithEvents pnlReady As Panel
    Friend WithEvents lblReadyCount As Label
    Friend WithEvents lblReady As Label
    Friend WithEvents pnlReleased As Panel
    Friend WithEvents lblReleasedCount As Label
    Friend WithEvents lblReleased As Label

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        cards = New FlowLayoutPanel()
        pnlOpen = New Panel()
        lblOpen = New Label()
        lblOpenCount = New Label()
        pnlRepairing = New Panel()
        lblRepairing = New Label()
        lblRepairingCount = New Label()
        pnlReady = New Panel()
        lblReady = New Label()
        lblReadyCount = New Label()
        pnlReleased = New Panel()
        lblReleased = New Label()
        lblReleasedCount = New Label()
        cards.SuspendLayout()
        pnlOpen.SuspendLayout()
        pnlRepairing.SuspendLayout()
        pnlReady.SuspendLayout()
        pnlReleased.SuspendLayout()
        SuspendLayout()
        ' 
        ' cards
        ' 
        cards.Controls.Add(pnlOpen)
        cards.Controls.Add(pnlRepairing)
        cards.Controls.Add(pnlReady)
        cards.Controls.Add(pnlReleased)
        cards.Dock = DockStyle.Top
        cards.Location = New Point(0, 0)
        cards.Name = "cards"
        cards.Padding = New Padding(18)
        cards.Size = New Size(1100, 150)
        cards.TabIndex = 0
        cards.WrapContents = False
        ' 
        ' pnlOpen
        ' 
        pnlOpen.BackColor = Color.White
        pnlOpen.Controls.Add(lblOpen)
        pnlOpen.Controls.Add(lblOpenCount)
        pnlOpen.Location = New Point(18, 18)
        pnlOpen.Margin = New Padding(0, 0, 14, 0)
        pnlOpen.Name = "pnlOpen"
        pnlOpen.Size = New Size(263, 105)
        pnlOpen.TabIndex = 0
        ' 
        ' lblOpen
        ' 
        lblOpen.Dock = DockStyle.Bottom
        lblOpen.ForeColor = Color.DimGray
        lblOpen.Location = New Point(0, 73)
        lblOpen.Name = "lblOpen"
        lblOpen.Size = New Size(263, 32)
        lblOpen.TabIndex = 0
        lblOpen.Text = "Open"
        lblOpen.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblOpenCount
        ' 
        lblOpenCount.Dock = DockStyle.Top
        lblOpenCount.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblOpenCount.ForeColor = Color.FromArgb(CByte(55), CByte(115), CByte(165))
        lblOpenCount.Location = New Point(0, 0)
        lblOpenCount.Name = "lblOpenCount"
        lblOpenCount.Size = New Size(263, 62)
        lblOpenCount.TabIndex = 1
        lblOpenCount.Text = "0"
        lblOpenCount.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' pnlRepairing
        ' 
        pnlRepairing.BackColor = Color.White
        pnlRepairing.Controls.Add(lblRepairing)
        pnlRepairing.Controls.Add(lblRepairingCount)
        pnlRepairing.Location = New Point(295, 18)
        pnlRepairing.Margin = New Padding(0, 0, 14, 0)
        pnlRepairing.Name = "pnlRepairing"
        pnlRepairing.Size = New Size(234, 105)
        pnlRepairing.TabIndex = 1
        ' 
        ' lblRepairing
        ' 
        lblRepairing.Dock = DockStyle.Bottom
        lblRepairing.ForeColor = Color.DimGray
        lblRepairing.Location = New Point(0, 73)
        lblRepairing.Name = "lblRepairing"
        lblRepairing.Size = New Size(234, 32)
        lblRepairing.TabIndex = 0
        lblRepairing.Text = "Repairing"
        lblRepairing.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblRepairingCount
        ' 
        lblRepairingCount.Dock = DockStyle.Top
        lblRepairingCount.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblRepairingCount.ForeColor = Color.FromArgb(CByte(55), CByte(115), CByte(165))
        lblRepairingCount.Location = New Point(0, 0)
        lblRepairingCount.Name = "lblRepairingCount"
        lblRepairingCount.Size = New Size(234, 62)
        lblRepairingCount.TabIndex = 1
        lblRepairingCount.Text = "0"
        lblRepairingCount.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' pnlReady
        ' 
        pnlReady.BackColor = Color.White
        pnlReady.Controls.Add(lblReady)
        pnlReady.Controls.Add(lblReadyCount)
        pnlReady.Location = New Point(543, 18)
        pnlReady.Margin = New Padding(0, 0, 14, 0)
        pnlReady.Name = "pnlReady"
        pnlReady.Size = New Size(240, 105)
        pnlReady.TabIndex = 2
        ' 
        ' lblReady
        ' 
        lblReady.Dock = DockStyle.Bottom
        lblReady.ForeColor = Color.DimGray
        lblReady.Location = New Point(0, 73)
        lblReady.Name = "lblReady"
        lblReady.Size = New Size(240, 32)
        lblReady.TabIndex = 0
        lblReady.Text = "Ready"
        lblReady.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblReadyCount
        ' 
        lblReadyCount.Dock = DockStyle.Top
        lblReadyCount.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblReadyCount.ForeColor = Color.FromArgb(CByte(55), CByte(115), CByte(165))
        lblReadyCount.Location = New Point(0, 0)
        lblReadyCount.Name = "lblReadyCount"
        lblReadyCount.Size = New Size(240, 62)
        lblReadyCount.TabIndex = 1
        lblReadyCount.Text = "0"
        lblReadyCount.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' pnlReleased
        ' 
        pnlReleased.BackColor = Color.White
        pnlReleased.Controls.Add(lblReleased)
        pnlReleased.Controls.Add(lblReleasedCount)
        pnlReleased.Location = New Point(797, 18)
        pnlReleased.Margin = New Padding(0, 0, 14, 0)
        pnlReleased.Name = "pnlReleased"
        pnlReleased.Size = New Size(257, 105)
        pnlReleased.TabIndex = 3
        ' 
        ' lblReleased
        ' 
        lblReleased.Dock = DockStyle.Bottom
        lblReleased.ForeColor = Color.DimGray
        lblReleased.Location = New Point(0, 73)
        lblReleased.Name = "lblReleased"
        lblReleased.Size = New Size(257, 32)
        lblReleased.TabIndex = 0
        lblReleased.Text = "Released"
        lblReleased.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblReleasedCount
        ' 
        lblReleasedCount.Dock = DockStyle.Top
        lblReleasedCount.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblReleasedCount.ForeColor = Color.FromArgb(CByte(55), CByte(115), CByte(165))
        lblReleasedCount.Location = New Point(0, 0)
        lblReleasedCount.Name = "lblReleasedCount"
        lblReleasedCount.Size = New Size(257, 62)
        lblReleasedCount.TabIndex = 1
        lblReleasedCount.Text = "0"
        lblReleasedCount.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' HomePage
        ' 
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        Controls.Add(cards)
        Name = "HomePage"
        Size = New Size(1100, 700)
        cards.ResumeLayout(False)
        pnlOpen.ResumeLayout(False)
        pnlRepairing.ResumeLayout(False)
        pnlReady.ResumeLayout(False)
        pnlReleased.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
End Class
