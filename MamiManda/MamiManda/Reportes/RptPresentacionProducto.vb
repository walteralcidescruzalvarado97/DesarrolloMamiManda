Public Class RptPresentacionProducto
    Public Sub New(Optional RTN As String = "")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'If RTN > 0 Then
        '    ClienteTableAdapter.FillByRTN(DsBakerySystem1, RTN)
        'End If
        ' ClienteTableAdapter.FillByRTN(DsBakerySystem1.Cliente, RTN)

        Sp_MostrarPresentacionProductoTableAdapter1.Fill(DsBakerySystem1.Sp_MostrarPresentacionProducto, RTN)
    End Sub
End Class