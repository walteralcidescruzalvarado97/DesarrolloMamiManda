Imports DevExpress.XtraReports.UI
Public Class FrmReporteVentasCliente
    Private Sub FrmReporteVentasCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEdit1.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then

            Dim rpt As New RptClienteMCA(DateEdit1.DateTime.Year)
            Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowRibbonPreview()

        ElseIf (RadioButton2.Checked = True) Then

            Dim Reporte As New RptClienteMCM(DateEdit1.DateTime.Month)
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


End Class