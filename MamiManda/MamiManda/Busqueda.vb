Public Class FrmBusqueda

    Private Sub BtnProveedor_Click_2(sender As Object, e As EventArgs) Handles BtnProveedor.Click
        FrmBuscarProveedor.Show()
        Me.Close()
    End Sub

    Private Sub BtnClientes_Click_1(sender As Object, e As EventArgs) Handles BtnClientes.Click
        FrmBuscarCliente.Show()
        Me.Close()
    End Sub

    Private Sub BtnUsuarios_Click_1(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        FrmBuscarUsuario.Show()
        Me.Close()
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        FrmBuscarEmpleado.Show()
        Me.Close()
    End Sub

End Class