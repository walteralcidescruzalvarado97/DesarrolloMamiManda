Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmUsuario
    Friend Property ModoEdicion As Boolean = False
    Friend Property IdUsuario As Integer = 0
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxTipoUsuario()
        LLenarComboEstado()
        HabilitarBotones(True, True, True)
        Limpiar()

        If ModoEdicion Then
            CargarDatosUsuario()
        Else
            InvestigarCorrelativo()
        End If

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Usuario")
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

    Private Sub HabilitarBotones(ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        HabilitarTextBox(valor)
    End Sub

    Private Sub HabilitarTextBox(ByVal valor As Boolean)
        txtCodUsuario.Enabled = False
        txtUserName.Enabled = valor
        txtContrasena.Enabled = valor
        cboEstado.Enabled = valor
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
        'FotoAgregar.Image = Image.FromFile("../../Resources/silueta.png")
        FotoAgregar.Image = My.Resources.silueta
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

    Private Sub CargarDatosUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()
                With cmd
                    .CommandText = "Sp_CargarDatosUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario
                End With

                Dim lector As SqlDataReader = cmd.ExecuteReader

                While lector.Read
                    txtCodUsuario.Text = lector("IdUsuario").ToString
                    txtUserName.Text = lector("UserName").ToString
                    txtContrasena.Text = lector("Password").ToString
                    If lector("Activo") Then
                        cboEstado.SelectedIndex = 0
                    Else
                        cboEstado.SelectedIndex = 1
                    End If
                    txtEmpleado.Text = lector("IdEmpleado").ToString
                    cboTipoUsuario.SelectedValue = lector("IdTipoUsuario").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
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


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(False, False, False)
        Limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtUserName, "Debe ingresar un nombre de usuario") Then
        ElseIf Validar(txtContrasena, "Debe ingresar una contraseña") Then
        ElseIf Validar(cboEstado, "Debe seleccionar un estado") Then
        ElseIf Validar(txtEmpleado, "Debe ingresar un empleado") Then
        ElseIf Validar(cboTipoUsuario, "Debe seleccionar un tipo de usuario") Then
        Else
            If ModoEdicion Then
                Call ActualizarUsuario()
            Else
                Call AgregarUsuario()
            End If
            HabilitarBotones(False, False, False)
            Limpiar()
            FrmUsuarios.ActualizarTablas(True)
            Me.Close()
        End If

    End Sub
    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        Dim BuscarEmpleado As New FrmBuscarEmpleado
        BuscarEmpleado.DesdeUsuario = True
        BuscarEmpleado.Show(Me)
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

    Private Sub MostrarImagen()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        'Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BakerySystem;Integrated Security=True")
        Dim command As New SqlCommand("SELECT Foto FROM Usuario where IdUsuario = @var", cnn)
        command.Parameters.Add("@var", SqlDbType.VarChar).Value = IdUsuario

        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)

        If IsDBNull(table.Rows(0)(0)) Then
        Else
            Dim img() As Byte
            img = table.Rows(0)(0)
            Dim ms As New MemoryStream(img)
            FotoAgregar.Image = Image.FromStream(ms)
        End If
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
        'FotoAgregar.Image = Image.FromFile(My.Resources.silueta.ToBitmap())
        FotoAgregar.Image = My.Resources.silueta
    End Sub


#End Region


End Class