Imports DevExpress.XtraReports.UI
Public Class FrmReporteCliente
    Private Sub FrmReporteCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsBakerySystem.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DsBakerySystem.Cliente)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporte As New RptCliente()
        Dim viewer As New ReportPrintTool(reporte)

        If (RadioButton1.Checked = True) Then
            If (TxtRTN.Text = Nothing) Then
                MessageBox.Show("Ingrese el RTN Cliente", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRTN.Focus()
            Else
                Dim rpt As New RptCliente(TxtRTN.Text)
                Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowRibbonPreview()
            End If
        ElseIf (RadioButton3.Checked = True) Then
            If (TxtRTN.Text = Nothing) Then
                MessageBox.Show("Ingrese el RTN Cliente", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRTN.Focus()
            Else
                Dim ReporteClienteFactura As New RptClientesFactura(TxtRTN.Text)
                ReporteClienteFactura.ShowRibbonPreview
            End If

        ElseIf (RadioButton2.Checked = True)Then
            viewer.ShowRibbonPreview()
        Else
            MessageBox.Show("No ha seleccionado nada", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TxtRTN.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TxtRTN.Enabled = False
        TxtRTN.Clear()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TxtRTN.Enabled = True
    End Sub
End Class