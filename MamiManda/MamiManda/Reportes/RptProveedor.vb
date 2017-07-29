Public Class RptProveedor
    Public Sub New(Optional RTN As String = "0000-0000-000000")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ProveedorTableAdapter1.FillByRTN(DsBakerySystem1.Proveedor, RTN)
    End Sub
End Class