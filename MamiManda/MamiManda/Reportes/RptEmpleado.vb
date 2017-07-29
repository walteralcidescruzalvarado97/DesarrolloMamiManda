Public Class RptEmpleado
    Public Sub New(Optional Id As Integer = 0)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        If Id > 0 Then
            EmpleadoTableAdapter1.FillById(DsBakerySystem2.Empleado, Id)
        End If

    End Sub
End Class