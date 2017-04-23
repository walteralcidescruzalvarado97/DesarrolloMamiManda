Imports System.Data.SqlClient
Public Class FrmProveedor
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        MostrarProveedor()
    End Sub

#Region "Funciones"

    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal actualizar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnInsertar.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnActualizar.Enabled = actualizar
        btnCancelar.Enabled = cancelar
        HabilitarTexbox(valor)
    End Sub

    Private Sub HabilitarTexbox(ByVal valor As Boolean)
        txtRtn.Enabled = valor
        txtNombre.Enabled = valor
        txtApellido.Enabled = valor
        txtEmail.Enabled = valor
        mtbTelefono.Enabled = valor
        txtDireccion.Enabled = valor
    End Sub

    Private Sub Limpiar()
        txtRtn.Text = Nothing
        txtNombre.Text = Nothing
        txtApellido.Text = Nothing
        txtEmail.Text = Nothing
        mtbTelefono.Text = Nothing
        txtDireccion.Text = Nothing
    End Sub

    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            ErrorProvider1.SetError(Control, "")
            Validar = False
        End If
    End Function

    Private Function ExisteRegistro() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@RTN", SqlDbType.NVarChar, 16).Value = txtRtn.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este proveedor", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

#End Region

#Region "InsertUpdate"

    Private Sub AgregarProveedor()
        If ExisteRegistro() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "SP_InsertarProveedor"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@RTN", SqlDbType.NVarChar).Value = txtRtn.Text.Trim
                        .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtNombre.Text.Trim
                        .Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text.Trim
                        .Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim
                        .Parameters.Add("@Telefono", SqlDbType.VarChar).Value = mtbTelefono.Text.Trim
                        .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = txtDireccion.Text.Trim
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de proveedor ha sido agregado", "MamiManda", MessageBoxButtons.OK)
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub ActualizarProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_ActualizarProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@RTN", SqlDbType.NVarChar).Value = txtRtn.Text.Trim
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtNombre.Text.Trim
                    .Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text.Trim
                    .Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim
                    .Parameters.Add("@Telefono", SqlDbType.VarChar).Value = mtbTelefono.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = txtDireccion.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de proveedor ha sido actualizado con éxito", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

#End Region

#Region "Llenar"

    Private Sub MostrarProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerProveedor As SqlDataReader
                VerProveedor = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerProveedor.Read = True
                    With Me.lsvMostrar.Items.Add(VerProveedor("RTNProveedor").ToString)
                        .SubItems.Add(VerProveedor("Nombre").ToString)
                        .SubItems.Add(VerProveedor("Apellido").ToString)
                        .SubItems.Add(VerProveedor("Email").ToString)
                        .SubItems.Add(VerProveedor("Telefono").ToString)
                        .SubItems.Add(VerProveedor("direccion").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub


#End Region

#Region "Listar"

    Private Sub ListarProveedores()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerProveedor As SqlDataReader
                VerProveedor = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerProveedor.Read = True
                    With Me.lsvMostrar.Items.Add(VerProveedor("RTNProveedor").ToString)
                        .SubItems.Add(VerProveedor("Nombre").ToString)
                        .SubItems.Add(VerProveedor("Apellido").ToString)
                        .SubItems.Add(VerProveedor("Email").ToString)
                        .SubItems.Add(VerProveedor("Telefono").ToString)
                        .SubItems.Add(VerProveedor("direccion").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub


#End Region

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, False, True, True)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtRtn, "Debe ingresar el RTN del proveedor") Then
        ElseIf Validar(txtNombre, "Debe ingresar el nombre del proveedor") Then
        ElseIf Validar(txtApellido, "Debe ingresar el apellido del proveedor") Then
        ElseIf Validar(txtEmail, "Debe ingresar el email del proveedor") Then
        ElseIf Validar(mtbTelefono, "Debe ingresar el telefono del proveedor") Then
        ElseIf Validar(txtDireccion, "Debe ingresar la dirección del proveedor") Then
        Else
            AgregarProveedor()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarProveedor()
        End If


    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Validar(txtRtn, "Debe ingresar el RTN del proveedor") Then
        ElseIf Validar(txtNombre, "Debe ingresar el nombre del proveedor") Then
        ElseIf Validar(txtApellido, "Debe ingresar el apellido del proveedor") Then
        ElseIf Validar(txtEmail, "Debe ingresar el email del proveedor") Then
        ElseIf Validar(mtbTelefono, "Debe ingresar el telefono del proveedor") Then
        ElseIf Validar(txtDireccion, "Debe ingresar la dirección del proveedor") Then
        Else
            ActualizarProveedor()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarProveedor()
        End If
    End Sub

#Region "Limpiar ErrorProvider"
    Private Sub txtRtn_TextChanged(sender As Object, e As EventArgs) Handles txtRtn.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub mtbTelefono_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbTelefono.MaskInputRejected
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        ErrorProvider1.Clear()
    End Sub



#End Region

    Private Sub lsvMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMostrar.SelectedIndexChanged
        btnEditar.Enabled = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        btnEditar.Enabled = False

        If txtBuscar.Text = "" Then
            MostrarProveedor()
        Else
            ListarProveedores()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtRtn.Text = lsvMostrar.FocusedItem.SubItems(0).Text
        txtNombre.Text = lsvMostrar.FocusedItem.SubItems(1).Text
        txtApellido.Text = lsvMostrar.FocusedItem.SubItems(2).Text
        txtEmail.Text = lsvMostrar.FocusedItem.SubItems(3).Text
        mtbTelefono.Text = lsvMostrar.FocusedItem.SubItems(4).Text
        txtDireccion.Text = lsvMostrar.FocusedItem.SubItems(5).Text
        HabilitarBotones(False, False, True, True, True)

        TabControl1.SelectedIndex = 0
        btnEditar.Enabled = False
        txtBuscar.Text = ""
    End Sub
End Class