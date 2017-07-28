Imports System.Data.SqlClient
Public Class FrmCliente
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        LlenarComboboxSexo()
        LlenarComboboxMunicipio()
        MostrarCliente()
        cboSexo.SelectedIndex = -1
        cboMunicipio.SelectedIndex = -1

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Cliente")
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

    Private Sub MostrarCliente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerCliente As SqlDataReader
                VerCliente = cmd.ExecuteReader()
                LsvMostrarCliente.Items.Clear()
                While VerCliente.Read = True
                    With Me.LsvMostrarCliente.Items.Add(VerCliente("RTNCliente").ToString)
                        .SubItems.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellido").ToString)
                        .SubItems.Add(VerCliente("EMail").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("FechaNac").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("Municipio").ToString)

                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ListarCliente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarCLiente"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerCliente As SqlDataReader
                VerCliente = cmd.ExecuteReader()
                LsvMostrarCliente.Items.Clear()
                While VerCliente.Read = True
                    With Me.LsvMostrarCliente.Items.Add(VerCliente("RTNCliente").ToString)
                        .SubItems.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellido").ToString)
                        .SubItems.Add(VerCliente("EMail").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("FechaNac").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("Municipio").ToString)
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
            AgregarCliente()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarCliente()
        End If
    End Sub


    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnInsertar_Click_1(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, False, True, True)
    End Sub

    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Validar(txtRtn, "Debe ingresar un RTN") Then
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
            ActualizarCliente()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarCliente()
        End If
    End Sub

    Private Sub LsvMostrarCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvMostrarCliente.SelectedIndexChanged
        btnEditar.Enabled = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtRtn.Text = LsvMostrarCliente.FocusedItem.SubItems(0).Text
        txtNombre.Text = LsvMostrarCliente.FocusedItem.SubItems(1).Text
        txtApellido.Text = LsvMostrarCliente.FocusedItem.SubItems(2).Text
        txtEmail.Text = LsvMostrarCliente.FocusedItem.SubItems(3).Text
        mtbTelefono.Text = LsvMostrarCliente.FocusedItem.SubItems(4).Text
        txtDireccion.Text = LsvMostrarCliente.FocusedItem.SubItems(7).Text
        dtpFecha.Text = LsvMostrarCliente.FocusedItem.SubItems(5).Text
        cboSexo.Text = LsvMostrarCliente.FocusedItem.SubItems(6).Text
        cboMunicipio.Text = LsvMostrarCliente.FocusedItem.SubItems(8).Text
        HabilitarBotones(False, False, True, True, True)

        TabControl1.SelectedIndex = 0
        btnEditar.Enabled = False
        txtBuscar.Text = ""
        txtRtn.Enabled = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        btnEditar.Enabled = False
        ListarCliente()
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

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

    End Sub
End Class