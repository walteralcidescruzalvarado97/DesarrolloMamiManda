Imports System.Data.SqlClient
Public Class FrmProveedor
    Friend Property ModoEdicion As Boolean = False
    Friend Property RtnProveedor As String = ""
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, True, True)
        Limpiar()

        If ModoEdicion Then
            Call CargarDatosProveedor()
            txtRtn.ReadOnly = True
        End If

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Proveedor")
    End Sub

#Region "Funciones"

    Private Sub HabilitarBotones(ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnGuardar.Enabled = guardar
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

    Private Sub CargarDatosProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CargarDatosProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@RtnProveedor", SqlDbType.NVarChar).Value = RtnProveedor
                End With

                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    txtRtn.Text = reader("RTNProveedor").ToString
                    txtNombre.Text = reader("Nombre").ToString
                    txtApellido.Text = reader("Apellido").ToString
                    txtEmail.Text = reader("Email").ToString
                    mtbTelefono.Text = reader("Telefono").ToString
                    txtDireccion.Text = reader("direccion").ToString
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(False, False, False)
        Limpiar()
    End Sub
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
        "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
       emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtRtn, "Debe ingresar el RTN del proveedor") Then
        ElseIf txtRtn.TextLength < 16 Then
            ErrorProvider1.SetError(txtRtn, "Debe ingresar un RTN válido")
        ElseIf Validar(txtNombre, "Debe ingresar el nombre del proveedor") Then
        ElseIf Validar(txtApellido, "Debe ingresar el apellido del proveedor") Then
        ElseIf Validar(txtEmail, "Debe ingresar el email del proveedor") Then
        ElseIf ValidateEmail(txtEmail.Text) = False Then
            ErrorProvider1.SetError(txtEmail, "Debe ingresar un email válido")
        ElseIf Validar(mtbTelefono, "Debe ingresar el telefono del proveedor") Then
        ElseIf mtbTelefono.TextLength < 8 Then
            ErrorProvider1.SetError(mtbTelefono, "Debe ingresar un teléfono válido")
        ElseIf Validar(txtDireccion, "Debe ingresar la dirección del proveedor") Then
        Else
            If ModoEdicion Then
                Call ActualizarProveedor()
            Else
                Call AgregarProveedor()
            End If
            Limpiar()
            FrmProveedores.ActualizarGrid(True)
            Me.Close()
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

    Private Sub mtbTelefono_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        ErrorProvider1.Clear()
    End Sub



#End Region

    Private Sub txtAlfabetico(e)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        txtAlfabetico(e)
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        txtAlfabetico(e)
    End Sub

    Private Sub mtbTelefono_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles mtbTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class