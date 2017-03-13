Imports System.Data.SqlClient
Public Class FrmBuscarCliente
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
                    .Parameters.Add("@RtnCliente", SqlDbType.NVarChar, 40).Value = txtBuscarRtn.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                    Val = False
                    MessageBox.Show("No se encuentra este cliente en la base de datos", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub MostrarTodoCliente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerCliente As SqlDataReader
                VerCliente = cmd.ExecuteReader()
                LsvMostrarCliente.Items.Clear()
                While VerCliente.Read = True
                    With Me.LsvMostrarCliente.Items.Add(VerCliente("RTNCliente").ToString)
                        .SubItems.Add(VerCliente("Nombre Completo").ToString)
                        .SubItems.Add(VerCliente("EMail").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaNac").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
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

    Private Sub MostrarClienteCodigo()
        If ExisteCliente() = True Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarClientexCodigo"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@RtnCliente", SqlDbType.NVarChar).Value = txtBuscarRtn.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerCliente As SqlDataReader
                    VerCliente = cmd.ExecuteReader()
                    LsvMostrarCliente.Items.Clear()
                    While VerCliente.Read = True
                        With Me.LsvMostrarCliente.Items.Add(VerCliente("RTNCliente").ToString)
                            .SubItems.Add(VerCliente("Nombre Completo").ToString)
                            .SubItems.Add(VerCliente("EMail").ToString)
                            .SubItems.Add(VerCliente("Telefono").ToString)
                            .SubItems.Add(VerCliente("Direccion").ToString)
                            .SubItems.Add(VerCliente("FechaNac").ToString)
                            .SubItems.Add(VerCliente("Sexo").ToString)
                            .SubItems.Add(VerCliente("Municipio").ToString)
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


    Private Sub MostrarClienteNombre()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarClientexNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerCliente As SqlDataReader
                VerCliente = cmd.ExecuteReader()
                LsvMostrarCliente.Items.Clear()
                While VerCliente.Read = True
                    With Me.LsvMostrarCliente.Items.Add(VerCliente("RTNCliente").ToString)
                        .SubItems.Add(VerCliente("Nombre Completo").ToString)
                        .SubItems.Add(VerCliente("EMail").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaNac").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
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

    Private Sub FrmBusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoCliente()
        rbRtn.Checked = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarRtn.Text = Nothing Then
            MostrarTodoCliente()
            txtBuscarRtn.Focus()
        Else
            MostrarClienteCodigo()
            txtBuscarRtn.Text = ""
            txtBuscarRtn.Focus()
        End If
    End Sub

    Private Sub rbRtn_CheckedChanged(sender As Object, e As EventArgs) Handles rbRtn.CheckedChanged
        txtBuscar.Enabled = True
        txtBuscar.Focus()
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtBuscar.Visible = False
        txtBuscarRtn.Visible = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        MostrarClienteNombre()
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        txtBuscar.Enabled = True
        txtBuscar.Focus()
        btnBuscar.Enabled = False
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarRtn.Visible = False
        MostrarTodoCliente()
    End Sub
End Class