Public Class FrmPrincipal
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) 
        FrmCliente.Show()
    End Sub

    Private Sub BtnProveedor_Click(sender As Object, e As EventArgs) 
        FrmProveedor.Show()
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) 
        FrmEmpleado.Show()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) 
        FrmUsuario.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) 
        FrmBusqueda.Show()
    End Sub

    Private Sub BtnUsuarios_Click_1(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        FrmUsuario.Show()
    End Sub

    Private Sub BtnProveedor_Click_1(sender As Object, e As EventArgs) Handles BtnProveedor.Click

        FrmProveedor.Show()
    End Sub

    Private Sub BtnClientes_Click_1(sender As Object, e As EventArgs) Handles BtnClientes.Click
        FrmCliente.Show()
    End Sub

    Private Sub BtnEmpleados_Click_1(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        FrmEmpleado.Show()
    End Sub

    Private Sub BtnBuscar_Click_1(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        FrmBusqueda.Show()
    End Sub
End Class