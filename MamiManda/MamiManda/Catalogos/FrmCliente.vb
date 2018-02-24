Imports System.Data.SqlClient
Public Class FrmCliente

    Friend Property ModoEdicion As Boolean = False
    Friend Property RtnCliente As String = ""
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, True, False)
        Limpiar()
        LlenarComboboxSexo()
        LlenarComboboxMunicipio()
        cboSexo.SelectedIndex = -1
        cboMunicipio.SelectedIndex = -1
        HabilitarTexbox(True)
        txtRtn.Focus()

        If ModoEdicion Then
            Call CargarDatosCliente()
        End If

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Cliente")
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
        dtpFecha.Enabled = valor
        cboMunicipio.Enabled = valor
        cboSexo.Enabled = valor
    End Sub

    Private Sub Limpiar()
        txtRtn.Text = Nothing
        txtNombre.Text = Nothing
        txtApellido.Text = Nothing
        txtEmail.Text = Nothing
        mtbTelefono.Text = Nothing
        txtDireccion.Text = Nothing
        cboSexo.Text = Nothing
        cboMunicipio.Text = Nothing
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

    Private Sub CargarDatosCliente()
        If cnn.State = ConnectionState.Open Then
            cnn.close
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CargarDatosCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@RtnCliente", SqlDbType.NVarChar).Value = RtnCliente
                End With

                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    txtRtn.Text = reader("RTNCliente").ToString
                    txtNombre.Text = reader("Nombre").ToString
                    txtApellido.Text = reader("Apellido").ToString
                    txtEmail.Text = reader("EMail").ToString
                    mtbTelefono.Text = reader("Telefono").ToString
                    txtDireccion.Text = reader("Direccion").ToString
                    dtpFecha.Value = reader("FechaNac").ToString
                    cboSexo.Text = reader("sexo").ToString
                    cboMunicipio.Text = reader("Municipio").ToString
                    NuDiasPlazo.Value = reader("DiasPlazo").ToString
                End While

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ExisteCliente() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@RtnCliente", SqlDbType.NVarChar, 40).Value = txtRtn.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este Cliente", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function




#End Region

#Region "LLenar Combobox"


    Private Sub LlenarComboboxSexo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_LlenarComboSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Sexo")
                Me.cboSexo.DataSource = ds.Tables(0)
                Me.cboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                Me.cboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub LlenarComboboxMunicipio()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_LlenarComboMunicipio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Municipio")
                Me.cboMunicipio.DataSource = ds.Tables(0)
                Me.cboMunicipio.DisplayMember = ds.Tables(0).Columns("Municipio").ToString
                Me.cboMunicipio.ValueMember = ds.Tables(0).Columns("IdMunicipio").ToString
                Me.cboMunicipio.ValueMember = ds.Tables(0).Columns("IdDepto").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub
#End Region


#Region "Insert, Update"

    Private Sub AgregarCliente()
        If ExisteCliente() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "SP_InsertCliente"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@RtnCliente", SqlDbType.NVarChar).Value = txtRtn.Text.Trim
                        .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtNombre.Text.Trim
                        .Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text.Trim
                        .Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim
                        .Parameters.Add("@Telefono", SqlDbType.VarChar).Value = mtbTelefono.Text.Trim
                        .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = txtDireccion.Text.Trim
                        .Parameters.Add("@Fecha", SqlDbType.Date).Value = dtpFecha.Value
                        .Parameters.Add("@DiasPlazo", SqlDbType.Int).Value = NuDiasPlazo.Value
                        .Parameters.Add("@Sexo", SqlDbType.Int).Value = cboSexo.SelectedValue
                        .Parameters.Add("@Municipio", SqlDbType.Int).Value = cboMunicipio.SelectedValue
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de cliente ha sido agregado", "MamiManda", MessageBoxButtons.OK)
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try

        End If
    End Sub

    Private Sub ActualizarCliente()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@RtnCliente", SqlDbType.NVarChar).Value = txtRtn.Text.Trim
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtNombre.Text.Trim
                    .Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text.Trim
                    .Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim
                    .Parameters.Add("@Telefono", SqlDbType.VarChar).Value = mtbTelefono.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = txtDireccion.Text.Trim
                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = dtpFecha.Value
                    .Parameters.Add("@DiasPlazo", SqlDbType.Int).Value = NuDiasPlazo.Value
                    .Parameters.Add("@Sexo", SqlDbType.Int).Value = cboSexo.SelectedValue
                    .Parameters.Add("@Municipio", SqlDbType.Int).Value = cboMunicipio.SelectedValue
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de cliente ha sido actualizado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave duplicada") Then
                MessageBox.Show("Ya se encuentra registrado este cliente", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox(ex.Message)
            End If

        Finally
            cnn.Close()
        End Try
    End Sub
#End Region

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
        "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
       emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtRtn, "Debe ingresar un RTN") Then
        ElseIf txtRtn.TextLength < 16 Then
            ErrorProvider1.SetError(txtRtn, "Debe ingresar un RTN válido")
        ElseIf Validar(txtNombre, "Debe ingresar un nombre de empleado") Then
        ElseIf Validar(txtApellido, "Debe ingresar un apellido") Then
        ElseIf Validar(txtEmail, "Debe seleccionar un Email") Then
        ElseIf ValidateEmail(txtEmail.Text) = False Then
            ErrorProvider1.SetError(txtEmail, "Debe ingresar un correo válido")
        ElseIf Validar(mtbTelefono, "Debe ingresar unnúmero de teléfono") Then
        ElseIf mtbTelefono.TextLength < 8 Then
            ErrorProvider1.SetError(mtbTelefono, "Debe ingresar un número de teléfono válido")
        ElseIf Validar(txtDireccion, "Debe ingresar una dirección") Then
        ElseIf Validar(cboSexo, "Debe seleccionar un sexo") Then
        ElseIf Validar(cboMunicipio, "Debe seleccionar un municipio") Then
        Else
            If ModoEdicion Then
                ActualizarCliente()
            Else
                AgregarCliente()
            End If

            HabilitarBotones(False, False, False)
            Limpiar()
            FrmClientes.ActualizarTablas(True)
            Me.Close()
        End If
    End Sub


    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(False, False, False)
        Limpiar()
        Me.Close()
    End Sub

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

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub cboSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSexo.SelectedIndexChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub mtbTelefono_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        txtAlfabetico(e)
    End Sub

    Private Sub txtAlfabetico(e)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        txtAlfabetico(e)
    End Sub

    Private Sub mtbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub mtbTelefono_TextChanged(sender As Object, e As EventArgs) Handles mtbTelefono.TextChanged
        ErrorProvider1.Clear()
    End Sub

End Class