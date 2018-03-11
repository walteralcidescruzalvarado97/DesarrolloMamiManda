Public Class RptCliente
    Public Sub New(Optional RTN As String = "")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'If RTN > 0 Then
        '    ClienteTableAdapter.FillByRTN(DsBakerySystem1, RTN)
        'End If
        ' ClienteTableAdapter.FillByRTN(DsBakerySystem1.Cliente, RTN)

        Sp_RptMostrarClientesTableAdapter1.Fill(DsBakerySystem1.Sp_RptMostrarClientes, RTN)
    End Sub
End Class