Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmUsuario

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxTipoUsuario()
        LLenarComboEstado()
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        MostrarUsuario()
    End Sub

#Region "Funciones"

    Private Function ImageToByte(ByVal img As Image) As Byte()
        Dim ms As MemoryStream = New MemoryStream()

        img.Save(ms, Imaging.ImageFormat.Png)

        ms.Close()
        Dim byteArray As Byte() = ms.ToArray()
        ms.Dispose()

        Return byteArray

    End Function

    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal actualizar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnInsertar.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnActualizar.Enabled = actualizar
        btnCancelar.Enabled = cancelar
        HabilitarTextBox(valor)
    End Sub

    Private Sub HabilitarTextBox(ByVal valor As Boolean)
        txtCodUsuario.Enabled = False
        txtUserName.Enabled = valor
        txtContrasena.Enabled = valor
        cboEstado.Enabled = valor
        txtEmpleado.Enabled = valor
        btnEmpleado.Enabled = valor
        cboTipoUsuario.Enabled = valor
        btnAbrir.Enabled = valor
        btnEliminarFoto.Enabled = valor
    End Sub

    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function

    Private Sub Limpiar()
        txtCodUsuario.Text = Nothing
        txtUserName.Text = Nothing
        txtEmpleado.Text = Nothing
        txtContrasena.Text = Nothing
        FotoAgregar.Image = Nothing
        cboEstado.SelectedIndex = -1
        cboTipoUsuario.SelectedIndex = -1
    End Sub

    Private Function ExisteRegistro() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 40).Value = txtUserName.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este usuario", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub InvestigarCorrelativo()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarUsuario As New SqlCommand("Sp_MostrarUsuarioIdentity", cnn)
            ListarUsuario.CommandType = CommandType.StoredProcedure
            Dim ListarUsuarios As SqlDataReader
            cnn.Open()
            ListarUsuarios = ListarUsuario.ExecuteReader
            If ListarUsuarios.Read = True Then
                If ListarUsuarios("Id") Is DBNull.Value Then
                    txtCodUsuario.Text = 1
                Else
                    txtCodUsuario.Text = ListarUsuarios("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Insert,delete"
    Private Sub AgregarUsuario()
        Dim foto As Byte()

        If FotoAgregar.Image Is Nothing Then
            foto = Nothing
        Else
            foto = ImageToByte(FotoAgregar.Image)
        End If

        If ExisteRegistro() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "SP_InsertarUsuario"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtUserName.Text.Trim
                        .Parameters.Add("@Password", SqlDbType.NVarChar).Value = SHA1(txtContrasena.Text.Trim)
                        .Parameters.Add("@Activo", SqlDbType.Int).Value = cboEstado.SelectedValue
                        .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = txtEmpleado.Text.Trim
                        .Parameters.Add("@TipoUsuario", SqlDbType.Int).Value = cboTipoUsuario.SelectedValue
                        If foto Is Nothing Then
                            .Parameters.Add("@Foto", SqlDbType.Image).Value = DBNull.Value
                        Else
                            .Parameters.Add("@Foto", SqlDbType.Image).Value = foto
                        End If
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de usuario ha sido agregado", "MamiManda", MessageBoxButtons.OK)
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try

        End If
    End Sub

    Private Sub ActualizarUsuario()

        Dim foto As Byte()

        If FotoAgregar.Image Is Nothing Then
            foto = Nothing
        Else
            foto = ImageToByte(FotoAgregar.Image)
        End If

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = txtCodUsuario.Text.Trim
                    .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtUserName.Text.Trim
                    .Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtContrasena.Text.Trim
                    .Parameters.Add("@Activo", SqlDbType.Int).Value = cboEstado.SelectedValue
                    .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = txtEmpleado.Text.Trim
                    .Parameters.Add("@TipoUsuario", SqlDbType.Int).Value = cboTipoUsuario.SelectedValue
                    If foto Is Nothing Then
                        .Parameters.Add("@Foto", SqlDbType.Image).Value = DBNull.Value
                    Else
                        .Parameters.Add("@Foto", SqlDbType.Image).Value = foto
                    End If
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de usuario ha sido actualizado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave duplicada") Then
                MessageBox.Show("Ya se encuentra registrado este usuario", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox(ex.Message)
            End If

        Finally
            cnn.Close()
        End Try
    End Sub
#End Region

#Region "Llenar"
    Private Sub MostrarUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerUsuario As SqlDataReader
                VerUsuario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerUsuario.Read = True
                    With Me.lsvMostrar.Items.Add(VerUsuario("IdUsuario").ToString)
                        .SubItems.Add(VerUsuario("UserName").ToString)
                        .SubItems.Add(VerUsuario("Password").ToString)
                        If VerUsuario("Activo").ToString = "True" Then
                            .SubItems.Add("Activo")
                        Else
                            .SubItems.Add("Inactivo")
                        End If
                        .SubItems.Add(VerUsuario("Nombre Completo").ToString)
                        .SubItems.Add(VerUsuario("TipoUsuario").ToString)
                        .SubItems.Add(VerUsuario("IdTipoUsuario").ToString)
                        .SubItems.Add(VerUsuario("IdEmpleado").ToString)
                        .SubItems.Add(VerUsuario("Foto").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ListarUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerUsuario As SqlDataReader
                VerUsuario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerUsuario.Read = True
                    With Me.lsvMostrar.Items.Add(VerUsuario("IdUsuario").ToString)
                        .SubItems.Add(VerUsuario("UserName").ToString)
                        .SubItems.Add(VerUsuario("Password").ToString)
                        If VerUsuario("Activo").ToString = "True" Then
                            .SubItems.Add("Activo")
                        Else
                            .SubItems.Add("Inactivo")
                        End If
                        .SubItems.Add(VerUsuario("Nombre Completo").ToString)
                        .SubItems.Add(VerUsuario("TipoUsuario").ToString)
                        .SubItems.Add(VerUsuario("IdTipoUsuario").ToString)
                        .SubItems.Add(VerUsuario("IdEmpleado").ToString)
                        .SubItems.Add(VerUsuario("Foto").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarComboboxTipoUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_LlenarComboTipoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoUsuario")
                Me.cboTipoUsuario.DataSource = ds.Tables(0)
                Me.cboTipoUsuario.DisplayMember = ds.Tables(0).Columns("TipoUsuario").ToString
                Me.cboTipoUsuario.ValueMember = ds.Tables(0).Columns("IdTipoUsuario").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub

    Sub LLenarComboEstado()
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Valor")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Valor") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Valor") = "0"
        dr("Descripcion") = "Desactivo"
        dt.Rows.Add(dr)

        cboEstado.DataSource = dt
        cboEstado.ValueMember = "Valor"
        cboEstado.DisplayMember = "Descripcion"
    End Sub
#End Region

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativo()
        txtUserName.Focus()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Validar(txtUserName, "Debe ingresar un nombre de usuario") Then
        ElseIf Validar(txtContrasena, "Debe ingresar una contraseña") Then
        ElseIf Validar(cboEstado, "Debe seleccionar un estado") Then
        ElseIf Validar(txtEmpleado, "Debe ingresar un empleado") Then
        ElseIf Validar(cboTipoUsuario, "Debe seleccionar un tipo de usuario") Then
        Else
            ActualizarUsuario()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarUsuario()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtUserName, "Debe ingresar un nombre de usuario") Then
        ElseIf Validar(txtContrasena, "Debe ingresar una contraseña") Then
        ElseIf Validar(cboEstado, "Debe seleccionar un estado") Then
        ElseIf Validar(txtEmpleado, "Debe ingresar un empleado") Then
        ElseIf Validar(cboTipoUsuario, "Debe seleccionar un tipo de usuario") Then
        Else
            AgregarUsuario()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarUsuario()
        End If

    End Sub

    Private Sub lsvMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMostrar.SelectedIndexChanged




        'Dim strAsBytes() As Byte = New System.Text.UTF8Encoding().GetBytes(lsvMostrar.FocusedItem.SubItems(8).Text)
        'Dim img As Image = Nothing

        'FotoAgregar.Image = byteArrayToImage(strAsBytes)

        btnEditar.Enabled = True
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        FrmBuscarEmpleado.ShowDialog()
    End Sub



#Region "Limpiar ErrorProvider"
    Private Sub txtCodUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtCodUsuario.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtEmpleado.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub cboTipoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoUsuario.SelectedIndexChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        btnEditar.Enabled = False
        ListarUsuario()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtCodUsuario.Text = lsvMostrar.FocusedItem.SubItems(0).Text
        txtUserName.Text = lsvMostrar.FocusedItem.SubItems(1).Text
        txtContrasena.Text = lsvMostrar.FocusedItem.SubItems(2).Text
        txtEmpleado.Text = lsvMostrar.FocusedItem.SubItems(7).Text
        cboTipoUsuario.SelectedValue = lsvMostrar.FocusedItem.SubItems(6).Text

        Dim var As String = lsvMostrar.FocusedItem.SubItems(3).Text
        If var = "True" Then
            cboEstado.SelectedValue = 1
        Else
            cboEstado.SelectedValue = 0
        End If

        HabilitarBotones(False, False, True, True, True)

        TabControl1.SelectedIndex = 0
        btnEditar.Enabled = False
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        AbrirFoto.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        AbrirFoto.Filter = "Imágenes (*.png, *.jpg)|*.png;*.jpg"
        AbrirFoto.FileName = "Seleccionar Imagen"


        If AbrirFoto.ShowDialog = DialogResult.OK Then

            FotoAgregar.Image = Image.FromFile(AbrirFoto.FileName)

        End If
    End Sub

    Private Sub btnEliminarFoto_Click(sender As Object, e As EventArgs) Handles btnEliminarFoto.Click
        FotoAgregar.Image = Nothing
    End Sub


#End Region


End Class