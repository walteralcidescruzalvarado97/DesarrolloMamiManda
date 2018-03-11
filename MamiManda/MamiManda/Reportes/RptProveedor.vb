Public Class RptProveedor
    Public Sub New(Optional RTN As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_MostrarTodoProveedorTableAdapter1.Fill(DsBakerySystem1.Sp_MostrarTodoProveedor, RTN)
    End Sub
End Class