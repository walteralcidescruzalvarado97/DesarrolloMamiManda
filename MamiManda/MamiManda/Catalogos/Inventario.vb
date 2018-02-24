Imports System.Data.SqlClient
Public Class FrmInventario
    Friend Property ModoEdicion As Boolean = False
    Friend Property IdInventario As String = ""
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, True, True)
        Limpiar()

        If ModoEdicion Then
            Call CargarDatosInventario()
            txtCodInventario.ReadOnly = True
        End If
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Inventario")
    End Sub

#Region "Funciones"
    Private Sub HabilitarBotones(ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        HabilitarTexbox(valor)
    End Sub

    Private Sub HabilitarTexbox(ByVal valor As Boolean)
        txtCodInventario.Enabled = valor
        txtNombre.Enabled = valor
        txtExistenciaMaxima.Enabled = valor
        txtExistenciaMinima.Enabled = valor
    End Sub

    Private Sub Limpiar()
        txtCodInventario.Text = Nothing
        txtNombre.Text = Nothing
        txtExistenciaMaxima.Text = Nothing
        txtExistenciaMinima.Text = Nothing
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
#End Region

#Region "Llenar"

    Private Sub CargarDatosInventario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CargarDatosInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = IdInventario
                End With

                Dim reader As SqlDataReader = cmd.ExecuteReader

                While reader.Read
                    txtCodInventario.Text = reader("IdInventario").ToString
                    txtNombre.Text = reader("NombreProducto").ToString
                    txtExistenciaMaxima.Text = reader("ExistenciaMaxima").ToString
                    txtExistenciaMinima.Text = reader("ExistenciaMinima").ToString
                End While

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "CRUD"

    Private Function ExisteInventario() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar, 4).Value = txtCodInventario.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este producto", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub AgregarInventario()
        If ExisteInventario() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "SP_InsertInventario"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodInventario.Text.Trim
                        .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtNombre.Text.Trim
                        .Parameters.Add("@ExistenciaMaxima", SqlDbType.Decimal).Value = txtExistenciaMaxima.Text.Trim
                        .Parameters.Add("@ExistenciaMinima", SqlDbType.Decimal).Value = txtExistenciaMinima.Text.Trim
                        .Parameters.Add("@Existencia", SqlDbType.Decimal).Value = 0
                        .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = UsuarioActivo.IdUsuario
                        .ExecuteNonQuery()
                        MessageBox.Show("El producto ha sido agregado", "MamiManda", MessageBoxButtons.OK)
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub ActualizarInventario()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodInventario.Text.Trim
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtNombre.Text.Trim
                    .Parameters.Add("@ExistenciaMaxima", SqlDbType.Decimal).Value = txtExistenciaMaxima.Text.Trim
                    .Parameters.Add("@ExistenciaMinima", SqlDbType.Decimal).Value = txtExistenciaMinima.Text.Trim
                    .Parameters.Add("@Existencia", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = UsuarioActivo.IdUsuario
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de inventario ha sido actualizado", "MamiManda", MessageBoxButtons.OK)
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
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(False, False, False)
        Limpiar()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim minima As Integer = txtExistenciaMinima.Text
        Dim maxima As Integer = txtExistenciaMaxima.Text


        If Validar(txtCodInventario, "Debe ingresar el código del producto") Then
        ElseIf txtCodInventario.TextLength < 4 Then
            ErrorProvider1.SetError(txtCodInventario, "Debe ingredar un código válido")
        ElseIf Validar(txtNombre, "Debe ingresar un nombre del producto") Then
        ElseIf Validar(txtExistenciaMaxima, "Debe ingresar la existencia máxima") Then
        ElseIf Validar(txtExistenciaMinima, "Debe ingresar la existencia mínima") Then
        ElseIf maxima <= minima Then
            MessageBox.Show("La existencia máxima debe ser mayor a la mínima", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf maxima > minima Then
            If ModoEdicion Then
                Call ActualizarInventario()
            Else
                Call AgregarInventario()
            End If

            HabilitarBotones(False, False, False)
            Limpiar()
            FrmInventarios.ActualizarGrid(True)
            Me.Close()
        End If
    End Sub
    Private Sub txtAlfabetico(e)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtExistenciaMaxima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExistenciaMaxima.KeyPress
        txtAlfabetico(e)
    End Sub

    Private Sub txtExistenciaMinima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExistenciaMinima.KeyPress
        txtAlfabetico(e)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

End Class