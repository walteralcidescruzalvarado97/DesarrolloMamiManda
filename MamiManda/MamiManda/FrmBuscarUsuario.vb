Imports System.Data.SqlClient
Public Class FrmBuscarUsuario
    Private Sub FrmBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuario()
        rbCodigo.Checked = False
    End Sub

#Region "Llenar"

    Private Function ExisteUsuario() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteUsuarioCodigo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Usuario", SqlDbType.Int).Value = txtBuscarCodigo.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                    Val = False
                    MessageBox.Show("No se encuentra este usuario en la base de datos", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub MostrarUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerUsuario As SqlDataReader
                VerUsuario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerUsuario.Read = True
                    With Me.lsvMostrar.Items.Add(VerUsuario("IdUsuario").ToString)
                        .SubItems.Add(VerUsuario("UserName").ToString)
                        If VerUsuario("Activo").ToString = "True" Then
                            .SubItems.Add("Activo")
                        Else
                            .SubItems.Add("Inactivo")
                        End If
                        .SubItems.Add(VerUsuario("Nombre Completo").ToString)
                        .SubItems.Add(VerUsuario("TipoUsuario").ToString)
                        .SubItems.Add(VerUsuario("IdTipoUsuario").ToString)
                        .SubItems.Add(VerUsuario("IdEmpleado").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarUsuarioCodigo()
        If ExisteUsuario() = True Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarUsuarioxCodigo"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = txtBuscarCodigo.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerUsuario As SqlDataReader
                    VerUsuario = cmd.ExecuteReader()
                    lsvMostrar.Items.Clear()
                    While VerUsuario.Read = True
                        With Me.lsvMostrar.Items.Add(VerUsuario("IdUsuario").ToString)
                            .SubItems.Add(VerUsuario("UserName").ToString)
                            If VerUsuario("Activo").ToString = "True" Then
                                .SubItems.Add("Activo")
                            Else
                                .SubItems.Add("Inactivo")
                            End If
                            .SubItems.Add(VerUsuario("Nombre Completo").ToString)
                            .SubItems.Add(VerUsuario("TipoUsuario").ToString)
                            .SubItems.Add(VerUsuario("IdTipoUsuario").ToString)
                            .SubItems.Add(VerUsuario("IdEmpleado").ToString)
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

    Private Sub MostrarUsuarioNombre()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarUsuarioxNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerUsuario As SqlDataReader
                VerUsuario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerUsuario.Read = True
                    With Me.lsvMostrar.Items.Add(VerUsuario("IdUsuario").ToString)
                        .SubItems.Add(VerUsuario("UserName").ToString)
                        If VerUsuario("Activo").ToString = "True" Then
                            .SubItems.Add("Activo")
                        Else
                            .SubItems.Add("Inactivo")
                        End If
                        .SubItems.Add(VerUsuario("Nombre Completo").ToString)
                        .SubItems.Add(VerUsuario("TipoUsuario").ToString)
                        .SubItems.Add(VerUsuario("IdTipoUsuario").ToString)
                        .SubItems.Add(VerUsuario("IdEmpleado").ToString)
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

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        txtBuscar.Enabled = True
        txtBuscar.Focus()
        btnBuscar.Enabled = False
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarCodigo.Visible = False
        MostrarUsuario()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarCodigo.Text = Nothing Then
            MostrarUsuario()
            txtBuscarCodigo.Focus()
        Else
            MostrarUsuarioCodigo()
            txtBuscarCodigo.Text = ""
            txtBuscarCodigo.Focus()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        MostrarUsuarioNombre()
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