Public Class FrmGraficoVenta
    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit1.EditValueChanged
        Dim ano As Integer = DateEdit1.DateTime.Year

        Sp_GraficoVentasTableAdapter.Fill(DsBakerySystem.Sp_GraficoVentas, ano)
    End Sub

    Private Sub FrmGraficoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sp_GraficoVentasTableAdapter.Fill(DsBakerySystem.Sp_GraficoVentas, Now.Year)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ChartControl1.ShowRibbonPrintPreview()
    End Sub
End Class