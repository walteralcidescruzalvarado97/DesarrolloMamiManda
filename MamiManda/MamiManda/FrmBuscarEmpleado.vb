Imports System.Data.SqlClient
Public Class FrmBuscarEmpleado
    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        txtBuscar.Enabled = True
        txtBuscar.Focus()
        btnBuscar.Enabled = False
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarCodigo.Visible = False
        MostrarTodoEmpleado()
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
                    .Parameters.Add("@CodEmpleado", SqlDbType.NVarChar, 40).Value = txtBuscarCodigo.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                    Val = False
                    MessageBox.Show("No se encuentra este empleado en la base de datos", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub MostrarTodoEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("NombreCompleto").ToString)
                        .SubItems.Add(VerEmpleado("EMail").ToString)
                        .SubItems.Add(VerEmpleado("Telefono").ToString)
                        .SubItems.Add(VerEmpleado("direccion").ToString)
                        .SubItems.Add(VerEmpleado("TipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("sexo").ToString)
                        .SubItems.Add(VerEmpleado("IdTipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("IdSexo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarEmpleadoCodigo()
        If ExisteEmpleado() = True Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarEmpleadoxCodigo"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = txtBuscarCodigo.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerEmpleado As SqlDataReader
                    VerEmpleado = cmd.ExecuteReader()
                    lsvMostrar.Items.Clear()
                    While VerEmpleado.Read = True
                        With Me.lsvMostrar.Items.Add(VerEmpleado("IdEmpleado").ToString)
                            .SubItems.Add(VerEmpleado("NombreCompleto").ToString)
                            .SubItems.Add(VerEmpleado("EMail").ToString)
                            .SubItems.Add(VerEmpleado("Telefono").ToString)
                            .SubItems.Add(VerEmpleado("direccion").ToString)
                            .SubItems.Add(VerEmpleado("TipoEmpleado").ToString)
                            .SubItems.Add(VerEmpleado("sexo").ToString)
                            .SubItems.Add(VerEmpleado("IdTipoEmpleado").ToString)
                            .SubItems.Add(VerEmpleado("IdSexo").ToString)
                        End With
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub MostrarEmpleadoNombre()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarEmpleadoxNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("NombreCompleto").ToString)
                        .SubItems.Add(VerEmpleado("EMail").ToString)
                        .SubItems.Add(VerEmpleado("Telefono").ToString)
                        .SubItems.Add(VerEmpleado("direccion").ToString)
                        .SubItems.Add(VerEmpleado("TipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("sexo").ToString)
                        .SubItems.Add(VerEmpleado("IdTipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("IdSexo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged
        txtBuscar.Enabled = True
        txtBuscar.Focus()
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtBuscar.Visible = False
        txtBuscarCodigo.Visible = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarCodigo.Text = Nothing Then
            MostrarTodoEmpleado()
            txtBuscarCodigo.Focus()
        Else
            MostrarEmpleadoCodigo()
            txtBuscarCodigo.Text = ""
            txtBuscarCodigo.Focus()
        End If
    End Sub

    Private Sub FrmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoEmpleado()
        rbCodigo.Checked = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        MostrarEmpleadoNombre()
    End Sub

    Private Sub lsvMostrar_DoubleClick(sender As Object, e As EventArgs) Handles lsvMostrar.DoubleClick
        Usuario.txtEmpleado.Text = lsvMostrar.FocusedItem.SubItems(0).Text
        Close()
    End Sub

    Private Sub txtBuscarCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarCodigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class