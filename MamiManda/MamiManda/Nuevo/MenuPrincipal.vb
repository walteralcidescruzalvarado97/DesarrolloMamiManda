Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars

Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosUsuario()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinHelper.InitSkinGallery(SkinRibbonGalleryBarItem1, True)

        If My.Settings.Tema <> Nothing Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.Tema
        End If

    End Sub

    Sub ValidarPermisosUsuario()
        Using TaPermisos As New BakerySystemDataSetTableAdapters.UsuarioModulosTableAdapter
            Dim DtPermisos As New BakerySystemDataSet.UsuarioModulosDataTable
            DtPermisos = TaPermisos.GetDataById(UsuarioActivo.IdUsuario)

            Try
                For Each Elemento As Object In RibbonControl.Items
                    Dim TipoElemento As Type = Elemento.GetType

                    If TipoElemento.FullName = "DevExpress.XtraBars.BarButtonItem" Then
                        Dim BarButtom As BarButtonItem = DirectCast(Elemento, BarButtonItem)

                        For Each DRPermiso As BakerySystemDataSet.UsuarioModulosRow In DtPermisos.Rows
                            If BarButtom.Tag = DRPermiso.IdModulo Then
                                BarButtom.Enabled = True
                                Exit For
                            End If
                        Next
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub HabilitarMenu(ByVal Habilitar As Boolean)
        For Each Elemento As Object In RibbonControl.Items
            Dim TipoElemento As Type = Elemento.GetType

            If TipoElemento.FullName = "DevExpress.XtraBars.BarButtonItem" Then
                Dim BarButtom As BarButtonItem = DirectCast(Elemento, BarButtonItem)

                If Habilitar Then
                    BarButtom.Enabled = True
                Else
                    BarButtom.Enabled = False
                End If
            End If
        Next
    End Sub

    Private Sub DatosUsuario()
        Try
            If UsuarioActivo.EsAdmin Then
                HabilitarMenu(True)
            Else
                HabilitarMenu(False)
                ValidarPermisosUsuario()
            End If
            Me.BsIUsuario.Caption = UsuarioActivo.NombreCompleto
            BbiCambiar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        My.Settings.Save()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        AbrirForm(FrmClientes)
    End Sub

    Sub AbrirForm(frm As Form)
        With frm
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BbiCambiar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BbiCambiar.ItemClick
        If MsgBox("Está seguro de cambiar de usuario?", MsgBoxStyle.Question + vbYesNo, "Confirme") = vbYes Then
            Try
                Dim Formularios() As Form
                Formularios = Me.MdiChildren

                For Each Formulario In Formularios
                    Formulario.Close()
                Next
            Catch ex As Exception
            End Try

            HabilitarMenu(False)
            BbiCambiar.Enabled = True
            BsIUsuario.Caption = "No hay sesión activa"

            Using FormInicio As New FrmLogin
                FormInicio.ModoInicio = False
                FormInicio.ShowDialog()
                If FormInicio.DialogResult = DialogResult.OK Then
                    DatosUsuario()
                End If
                DatosUsuario()
                BbiCambiar.Enabled = True
            End Using
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        AbrirForm(FrmEmpleados)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        AbrirForm(FrmInventarios)
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        AbrirForm(FrmProveedores)
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Venta.Show()
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        FrmConfiguracion.ShowDialog()
    End Sub

    Private Sub XtraTabbedMdiManager1_SelectedPageChanged(sender As Object, e As EventArgs) Handles XtraTabbedMdiManager1.SelectedPageChanged
        If XtraTabbedMdiManager1.Pages.Count <> 0 Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        AbrirForm(FrmAgregarMateria)
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        AbrirForm(FrmProduccion)
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        AbrirForm(FrmMateriasPrimas)
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        AbrirForm(FrmConfigSar)
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        AbrirForm(FrmRecetas)
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        AbrirForm(FrmUsuarios)
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        AbrirForm(FrmAsignarPermisos)
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        AbrirForm(FrmHistorialVentas)
    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded, XtraTabbedMdiManager1.PageRemoved
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub
End Class