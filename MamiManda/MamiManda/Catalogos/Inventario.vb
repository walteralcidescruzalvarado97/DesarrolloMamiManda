Imports System.Data.SqlClient
Public Class FrmInventario
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        MostrarInventario()
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
            Validar = False
        End If
    End Function
#End Region

#Region "Llenar"

    Private Sub MostrarInventario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerInventario As SqlDataReader
                VerInventario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerInventario.Read = True
                    With Me.lsvMostrar.Items.Add(VerInventario("IdInventario").ToString)
                        .SubItems.Add(VerInventario("NombreProducto").ToString)
                        .SubItems.Add(VerInventario("ExistenciaMaxima").ToString)
                        .SubItems.Add(VerInventario("ExistenciaMinima").ToString)
                        .SubItems.Add(VerInventario("Existencia").ToString)
                        .SubItems.Add(VerInventario("IdUsuario").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ListarInventario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerInventario As SqlDataReader
                VerInventario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerInventario.Read = True
                    With Me.lsvMostrar.Items.Add(VerInventario("IdInventario").ToString)
                        .SubItems.Add(VerInventario("NombreProducto").ToString)
                        .SubItems.Add(VerInventario("ExistenciaMaxima").ToString)
                        .SubItems.Add(VerInventario("ExistenciaMinima").ToString)
                        .SubItems.Add(VerInventario("Existencia").ToString)
                        .SubItems.Add(VerInventario("IdUsuario").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ListarInventario()
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
                        .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = FrmPrincipal.LblId.Text
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
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = FrmPrincipal.LblId.Text
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

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, False, True, True)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtCodInventario, "Debe ingresar el código del producto") Then
        ElseIf Validar(txtNombre, "Debe ingresar un nombre del producto") Then
        ElseIf Validar(txtExistenciaMaxima, "Debe ingresar la existencia máxima") Then
        ElseIf Validar(txtExistenciaMinima, "Debe ingresar la existencia mínima") Then
        Else
            AgregarInventario()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarInventario()
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Validar(txtNombre, "Debe ingresar un nombre del producto") Then
        ElseIf Validar(txtExistenciaMaxima, "Debe ingresar la existencia máxima") Then
        ElseIf Validar(txtExistenciaMinima, "Debe ingresar la existencia mínima") Then
        Else
            ActualizarInventario()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarInventario()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtCodInventario.Text = lsvMostrar.FocusedItem.SubItems(0).Text
        txtNombre.Text = lsvMostrar.FocusedItem.SubItems(1).Text
        txtExistenciaMaxima.Text = lsvMostrar.FocusedItem.SubItems(2).Text
        txtExistenciaMinima.Text = lsvMostrar.FocusedItem.SubItems(3).Text
        HabilitarBotones(False, False, True, True, True)

        TabControl1.SelectedIndex = 0
        btnEditar.Enabled = False
        txtBuscar.Text = ""
    End Sub

    Private Sub lsvMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMostrar.SelectedIndexChanged
        btnEditar.Enabled = True
    End Sub
End Class