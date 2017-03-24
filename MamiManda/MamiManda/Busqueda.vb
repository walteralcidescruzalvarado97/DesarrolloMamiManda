Public Class FrmBusqueda
    Private Sub BtnProveedor_Click(sender As Object, e As EventArgs) 
        FrmBuscarProveedor.Show()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) 
        FrmBuscarCliente.Show()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) 
        FrmBuscarUsuario.Show()
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) 
        FrmBuscarEmpleado.Show()
    End Sub

    Private Sub BtnProveedor_Click_1(sender As Object, e As EventArgs) Handles BtnProveedor.Click
        FrmBuscarProveedor.Show()
    End Sub

    Private Sub BtnClientes_Click_1(sender As Object, e As EventArgs) Handles BtnClientes.Click
        FrmBuscarCliente.Show()
    End Sub

    Private Sub BtnUsuarios_Click_1(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        FrmBuscarUsuario.Show()
    End Sub

    Private Sub BtnEmpleados_Click_1(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        FrmBuscarEmpleado.Show()
    End Sub
End Class