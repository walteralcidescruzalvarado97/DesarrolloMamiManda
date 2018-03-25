Public Class RptProveedor
    Public Sub New(Optional RTN As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_MostrarTodoProveedorRTableAdapter1.Fill(DsBakerySystem1.Sp_MostrarTodoProveedorR, RTN)
    End Sub


End Class