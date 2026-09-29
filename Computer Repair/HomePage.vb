Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Partial Class HomePage

    Public Sub New()
        InitializeComponent()
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        LoadCounts()
    End Sub

    Private Sub LoadCounts()
        Try
            lblOpenCount.Text = Convert.ToInt32(GetValue(
                "SELECT COUNT(*) FROM service_requests WHERE status NOT IN ('RELEASED','CANCELLED')"
            )).ToString()

            lblRepairingCount.Text = Convert.ToInt32(GetValue(
                "SELECT COUNT(*) FROM repair_jobs WHERE status IN ('IN_PROGRESS','WAITING_FOR_PARTS')"
            )).ToString()

            lblReadyCount.Text = Convert.ToInt32(GetValue(
                "SELECT COUNT(*) FROM service_requests WHERE status='READY_FOR_PICKUP'"
            )).ToString()

            lblReleasedCount.Text = Convert.ToInt32(GetValue(
                "SELECT COUNT(*) FROM device_releases"
            )).ToString()
        Catch ex As Exception
            lblOpenCount.Text = "0"
            lblRepairingCount.Text = "0"
            lblReadyCount.Text = "0"
            lblReleasedCount.Text = "0"
        End Try
    End Sub

End Class
