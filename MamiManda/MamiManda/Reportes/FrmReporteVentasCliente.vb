Imports DevExpress.XtraReports.UI
Public Class FrmReporteVentasCliente
    Private Sub FrmReporteVentasCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then
            If (TxtRTN.Text = Nothing) Then
                MessageBox.Show("Ingrese el Año", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRTN.Focus()
            Else
                Dim rpt As New RptClienteMCA(TxtRTN.Text)
                Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowRibbonPreview()
            End If
        ElseIf (RadioButton2.Checked = True) Then
            If (TxtRTN.Text = Nothing) Then
                MessageBox.Show("Ingrese el Mes", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRTN.Focus()
            Else
                Dim Reporte As New RptClienteMCM(TxtRTN.Text)
                Reporte.ShowRibbonPreview
            End If
        Else
            MessageBox.Show("No ha seleccionado nada", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TxtRTN.Enabled = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TxtRTN.Enabled = True
    End Sub


End Class