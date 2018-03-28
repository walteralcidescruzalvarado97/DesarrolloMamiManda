Public Class RptFactura
    Public Sub New(Optional Id As String = "000-000-00-00000000", Optional Text As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'FacturaTableAdapter1.FillByIdFac(BakerySystemDataSet1.Factura, Id)

        Sp_ReporteFacturaTableAdapter2.Fill(DsBakerySystem1.Sp_ReporteFactura, Id)
        TotalTexto.Text = Text

    End Sub
End Class