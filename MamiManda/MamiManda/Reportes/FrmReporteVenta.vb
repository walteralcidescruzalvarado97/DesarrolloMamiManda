Imports DevExpress.XtraReports.UI
Public Class FrmReporteVenta
    Private Sub FrmReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then
            If (TxtRTN.Text = Nothing) Then
                MessageBox.Show("Ingrese el Año de las Ventas a Mostrar", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRTN.Focus()
            Else
                Dim rpt As New RptVentasAno(TxtRTN.Text)
                Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowRibbonPreview()
            End If
        ElseIf (RadioButton3.Checked = True) Then
            If (dtpFecha.Text = Nothing) Then
                MessageBox.Show("Ingrese la Fecha de las Ventas", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRTN.Focus()
            Else
                Dim Reporte As New RptVentasDia(dtpFecha.Text)
                Reporte.ShowRibbonPreview
            End If

        ElseIf (RadioButton2.Checked = True) Then
            If (TxtRTN.Text = Nothing) Then
                MessageBox.Show("Ingrese el Mes de las Ventas", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRTN.Focus()
            Else
                Dim Reporte As New RptVentasMes(TxtRTN.Text)
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

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        dtpFecha.Enabled = True
        TxtRTN.Enabled = False
        TxtRTN.Clear()
    End Sub
End Class