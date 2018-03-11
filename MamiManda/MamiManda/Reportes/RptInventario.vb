Public Class RptInventario
    Public Sub New(Optional RTN As String = "")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'If RTN > 0 Then
        '    ClienteTableAdapter.FillByRTN(DsBakerySystem1, RTN)
        'End If
        ' ClienteTableAdapter.FillByRTN(DsBakerySystem1.Cliente, RTN)

        Sp_RptMostrarInventarioTableAdapter1.Fill(DsBakerySystem1.Sp_RptMostrarInventario, RTN)
    End Sub
End Class