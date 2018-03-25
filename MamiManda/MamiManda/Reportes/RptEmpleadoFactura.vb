Public Class RptEmpleadoFactura
    Public Sub New(Optional Id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_EmpleadoFacturaTableAdapter1.Fill(DsBakerySystem1.Sp_EmpleadoFactura, Id)
    End Sub
End Class