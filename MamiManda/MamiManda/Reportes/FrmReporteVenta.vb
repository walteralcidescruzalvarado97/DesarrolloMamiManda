Imports DevExpress.XtraReports.UI
Public Class FrmReporteVenta
    Private Sub FrmReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEdit1.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then

            Dim rpt As New RptVentasAno(DateEdit1.DateTime.Year)
            Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowRibbonPreview()

        ElseIf (RadioButton3.Checked = True) Then

            Dim Reporte As New RptVentasDia(DateEdit1.DateTime)
            Reporte.ShowRibbonPreview


        ElseIf (RadioButton2.Checked = True) Then

            Dim Reporte As New RptVentasMes(DateEdit1.DateTime.Month)
            Reporte.ShowRibbonPreview

        Else
            MessageBox.Show("No ha seleccionado nada", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DateEdit1.Enabled = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DateEdit1.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DateEdit1.Enabled = True
    End Sub

    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit1.EditValueChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class