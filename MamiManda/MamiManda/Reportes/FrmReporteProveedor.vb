Imports DevExpress.XtraReports.UI
Public Class FrmReporteVentas
    Private Sub FrmReporteProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsBakerySystem.Proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.DsBakerySystem.Proveedor)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporte As New RptProveedor()
        Dim viewer As New ReportPrintTool(reporte)

        If (RadioButton1.Checked = True) Then
            If (TxtRTN.Text = Nothing) Then
                MessageBox.Show("Ingrese el RTN del Proveedor", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRTN.Focus()
            Else
                Dim rpt As New RptProveedor(TxtRTN.Text)
                Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowRibbonPreview()
            End If

        ElseIf (RadioButton2.Checked = True)
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TxtRTN_TextChanged(sender As Object, e As EventArgs) Handles TxtRTN.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class