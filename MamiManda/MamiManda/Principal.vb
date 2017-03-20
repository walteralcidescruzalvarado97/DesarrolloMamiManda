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
End Class