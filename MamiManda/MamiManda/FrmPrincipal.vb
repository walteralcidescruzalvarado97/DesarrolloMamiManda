Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnMenu2.Hide()
        Panel3.Width = 227
    End Sub

    Private Sub BtnMenu2_Click(sender As Object, e As EventArgs) Handles BtnMenu2.Click
        Panel3.Width = 227
        BtnMenu2.Hide()
        BtnMenu.Show()
        PbUser.Show()
    End Sub
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Panel3.Width = 45
        BtnMenu.Hide()
        BtnMenu2.Show()
        PbUser.Show()
    End Sub

    Private Sub TileClientes_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileClientes.ItemClick
        FrmCliente.Show()
    End Sub

    Private Sub TileUsuario_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileUsuario.ItemClick
        FrmUsuario.Show()
    End Sub

    Private Sub TileEmpleado_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileEmpleado.ItemClick
        FrmEmpleado.Show()
    End Sub

    Private Sub TileProveedor_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileProveedor.ItemClick
        FrmProveedor.Show()
    End Sub

    Private Sub TileMateriaPrima_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileMateriaPrima.ItemClick
        FrmMateriaPrima.Show()
    End Sub

    Private Sub BtnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles BtnCambiarUsuario.Click
        FrmLogin.Show()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        FrmBusqueda.Show()
    End Sub

    Private Sub TileProduccion_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileProduccion.ItemClick
        FrmProduccion.Show()
    End Sub

    Private Sub TilePresentacionProducto_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TilePresentacionProducto.ItemClick
        FrmPresentacionProducto.Show()
    End Sub

    Private Sub TileAgregarMateriaPrima_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileAgregarMateriaPrima.ItemClick
        FrmAgregarMateria.Show()
    End Sub

    Private Sub TileReceta_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileReceta.ItemClick
        FrmReceta.Show()
    End Sub

    Private Sub TileInventario_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileInventario.ItemClick
        FrmInventario.Show()
    End Sub

    Private Sub TileVentas_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileVentas.ItemClick
        Venta.Show()
    End Sub

    Private Sub BtnOpciones_Click(sender As Object, e As EventArgs) Handles BtnOpciones.Click
        FrmConfiguracion.ShowDialog()
    End Sub

    Private Sub BtnLogAuditoria_Click(sender As Object, e As EventArgs) Handles BtnLogAuditoria.Click
        LogAuditoria.ShowDialog()
    End Sub
End Class