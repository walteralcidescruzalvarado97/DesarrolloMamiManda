Public Class RptCliente
    Public Sub New(Optional RTN As String = "0000-0000-00000")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'If RTN > 0 Then
        '    ClienteTableAdapter.FillByRTN(DsBakerySystem1, RTN)
        'End If
        ClienteTableAdapter.FillByRTN(DsBakerySystem1.Cliente, RTN)
    End Sub
End Class