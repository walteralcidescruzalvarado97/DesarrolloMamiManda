Public Class RptEmpleado
    Public Sub New(Optional Id As Integer = 0)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Sp_RptMostrarEmpleadosTableAdapter1.Fill(DsBakerySystem1.Sp_RptMostrarEmpleados, Id)

    End Sub
End Class