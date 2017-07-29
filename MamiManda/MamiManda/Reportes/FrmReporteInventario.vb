Imports DevExpress.XtraReports.UI
Public Class FrmReporteInventario
    Private Sub FrmReporteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsBakerySystem.Inventario' table. You can move, or remove it, as needed.
        Me.InventarioTableAdapter.Fill(Me.DsBakerySystem.Inventario)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TxtId.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TxtId.Enabled = False
        TxtId.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporte As New RptInventario()
        Dim viewer As New ReportPrintTool(reporte)

        If (RadioButton1.Checked = True) Then
            If (TxtId.Text = Nothing) Then
                MessageBox.Show("Ingrese el Id del Inventario", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtId.Focus()
            Else
                Dim rpt As New RptInventario(TxtId.Text)
                Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowRibbonPreview()
            End If
        ElseIf (RadioButton2.Checked = True)
            viewer.ShowRibbonPreview()
        Else
            MessageBox.Show("No ha seleccionado nada", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class