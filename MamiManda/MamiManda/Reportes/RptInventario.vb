Public Class RptInventario
    Public Sub New(Optional Id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If (Id > 0) Then
            InventarioTableAdapter1.FillById(DsBakerySystem1.Inventario, Id)
        End If
    End Sub
End Class