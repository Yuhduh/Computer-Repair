Imports System.Data
Imports System.Windows.Forms

Friend Module Ui
    Public Sub BindCombo(combo As ComboBox, table As DataTable)
        combo.DataSource = table
        combo.ValueMember = "id"
        combo.DisplayMember = "name"
        combo.SelectedIndex = If(table.Rows.Count = 0, -1, 0)
    End Sub

    Public Function SelectedId(combo As ComboBox) As Integer
        If combo.SelectedValue Is Nothing OrElse combo.SelectedValue Is DBNull.Value Then
            Return 0
        End If

        Return Convert.ToInt32(combo.SelectedValue)
    End Function

    Public Sub FormatGridIds(grid As DataGridView)
        For Each column As DataGridViewColumn In grid.Columns
            If column.Name.EndsWith("ID", StringComparison.OrdinalIgnoreCase) OrElse column.Name = "ID" Then
                column.DefaultCellStyle.Format = "000"
                column.FillWeight = 45
            End If
        Next
    End Sub

    Public Sub ShowError(owner As Control, ex As Exception)
        MessageBox.Show(owner, ex.Message, "Could not finish", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Module
