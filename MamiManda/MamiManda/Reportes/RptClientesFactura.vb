Public Class RptClientesFactura
    Public Sub New(Optional ByVal RTNCliente As String = "0601-1997-008410")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_ClienteFacturaTableAdapter1.Fill(DsBakerySystem1.Sp_ClienteFactura, RTNCliente)

    End Sub

End Class