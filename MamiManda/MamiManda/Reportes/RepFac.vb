Public Class RepFac
    Public Sub New(Optional Id As String = "001-001-01-00000006")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        FacturaTableAdapter1.FillByIdFac(BakerySystemDataSet1.Factura, Id)

    End Sub
End Class