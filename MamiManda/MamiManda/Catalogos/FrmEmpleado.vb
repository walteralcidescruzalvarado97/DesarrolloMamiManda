Imports System.Data.SqlClient
Public Class FrmEmpleado
    Friend Property ModoEdicion As Boolean = False
    Friend Property IdEmpleado As Integer = 0
    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxTipoEmpleado()
        LlenarComboboxSexo()
        HabilitarBotones(True, True, true)
        CboTipoEmpleado.Text = Nothing
        CboSexo.Text = Nothing

        If ModoEdicion Then
            CargarDatosEmpleado()
        Else
            InvestigarCorrelativo()
        End If
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Empleado")
    End Sub

#Region "SCRUD"
    Private Sub AgregarEmpleado()
        If ExisteEmpleado() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "SP_InsertEmpleados"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = TxtNombre.Text.Trim
                        .Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = TxtApellido.Text.Trim
                        .Parameters.Add("@Email", SqlDbType.VarChar).Value = TxtEmail.Text.Trim
                        .Parameters.Add("@Telefono", SqlDbType.VarChar).Value = mtbTelefono.Text.Trim
                        .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text.Trim
                        .Parameters.Add("@TipoEmpleado", SqlDbType.Int).Value = CboTipoEmpleado.SelectedValue
                        .Parameters.Add("@Sexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de Empleado ha sido agregado", "MamiManda", MessageBoxButtons.OK)
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try

        End If
    End Sub

    Private Sub ActualizarEmpleado()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdEMpleado", SqlDbType.NVarChar).Value = TxtCodEmpleado.Text.Trim
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@Email", SqlDbType.VarChar).Value = TxtEmail.Text.Trim
                    .Parameters.Add("@Telefono", SqlDbType.VarChar).Value = mtbTelefono.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text.Trim
                    .Parameters.Add("@TipoEmpleado", SqlDbType.Int).Value = CboTipoEmpleado.SelectedValue
                    .Parameters.Add("@Sexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de empleado ha sido actualizado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave duplicada") Then
                MessageBox.Show("Ya se encuentra registrado este empleado", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox(ex.Message)
            End If

        Finally
            cnn.Close()
        End Try
    End Sub
#End Region

#Region "Funciones"

    Private Sub HabilitarBotones(ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        HabilitarTextBox(valor)
    End Sub

    Private Sub HabilitarTextBox(ByVal valor As Boolean)
        TxtCodEmpleado.Enabled = False
        TxtNombre.Enabled = valor
        TxtApellido.Enabled = valor
        TxtEmail.Enabled = valor
        mtbTelefono.Enabled = valor
        TxtDireccion.Enabled = valor
        CboSexo.Enabled = valor
        CboTipoEmpleado.Enabled = valor
    End Sub

    Private Function ExisteEmpleado() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CodEmpleado", SqlDbType.NVarChar, 40).Value = TxtCodEmpleado.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este Empleado", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim ListarEmpleado As New SqlCommand("Sp_MostrarCodEmpleadoIdentity", cnn)
            ListarEmpleado.CommandType = CommandType.StoredProcedure
            Dim Listarempleados As SqlDataReader
            cnn.Open()
            Listarempleados = ListarEmpleado.ExecuteReader
            If Listarempleados.Read = True Then
                If Listarempleados("Id") Is DBNull.Value Then
                    TxtCodEmpleado.Text = 1
                Else
                    TxtCodEmpleado.Text = Listarempleados("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            MessageBox.Show(Mensaje, "MamiManda", MessageBoxButtons.OK)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function

    Private Sub Limpiar()
        TxtCodEmpleado.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellido.Text = Nothing
        TxtEmail.Text = Nothing
        mtbTelefono.Text = Nothing
        TxtDireccion.Text = Nothing
        CboTipoEmpleado.SelectedIndex = -1
        CboSexo.SelectedIndex = -1
    End Sub
#End Region

#Region "Llenar"

    Private Sub CargarDatosEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.close
        End If

        Try
            cnn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CargarDatosEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = IdEmpleado
                End With

                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    TxtCodEmpleado.Text = reader("IdEmpleado").ToString
                    TxtNombre.Text = reader("Nombre").ToString
                    TxtApellido.Text = reader("Apellido").ToString
                    TxtEmail.Text = reader("EMail").ToString
                    mtbTelefono.Text = reader("Telefono").ToString
                    TxtDireccion.Text = reader("direccion").ToString
                    CboTipoEmpleado.Text = reader("TipoEmpleado").ToString
                    CboSexo.Text = reader("sexo").ToString
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboboxTipoEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_LlenarComboTipoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoEmpleado")
                Me.CboTipoEmpleado.DataSource = ds.Tables(0)
                Me.CboTipoEmpleado.DisplayMember = ds.Tables(0).Columns("TipoEmpleado").ToString
                Me.CboTipoEmpleado.ValueMember = ds.Tables(0).Columns("IdTipoEmpleado").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub

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
                Me.CboSexo.DataSource = ds.Tables(0)
                Me.CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                Me.CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString
            End Using
        Catch ex As Exception

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
    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        Close()
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

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        txtAlfabetico(e)
    End Sub

    Private Sub TxtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido.KeyPress
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

    Private Sub mtbTelefono_TextChanged(sender As Object, e As EventArgs) Handles mtbTelefono.TextChanged

    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(TxtNombre, "Debe ingresar un nombre de empleado") Then
        ElseIf Validar(TxtApellido, "Debe ingresar un apellido") Then
        ElseIf Validar(TxtEmail, "Debe seleccionar un Email") Then
        ElseIf ValidateEmail(TxtEmail.Text) = False Then
            MessageBox.Show("Debe ingresar un correo válido", "MamiManda", MessageBoxButtons.OK)
        ElseIf Validar(mtbTelefono, "Debe ingresar un número de teléfono") Then
        ElseIf mtbTelefono.TextLength < 8 Then
            MessageBox.Show("Debe ingresar un número de teléfono válido", "MamiManda", MessageBoxButtons.OK)
        ElseIf Validar(TxtDireccion, "Debe ingresar una dirección") Then
        ElseIf Validar(CboTipoEmpleado, "Debe seleccionar un tipo de Empleado") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un Sexo") Then
        Else
            If ModoEdicion Then
                Call ActualizarEmpleado()
            Else
                Call AgregarEmpleado()
            End If

            HabilitarBotones(False, False, False)
            Limpiar()
            FrmEmpleados.Actualizar(True)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(False, False, False)
        Limpiar()
        Me.Close()
    End Sub
End Class