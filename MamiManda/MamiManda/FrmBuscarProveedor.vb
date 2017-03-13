Imports System.Data.SqlClient

Public Class FrmBuscarProveedor
    Private Sub FrmBuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoProveedor()
        rbRtn.Checked = False
    End Sub

    Private Function ExisteProveedor() As Boolean
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
                    .Parameters.Add("@RTN", SqlDbType.NVarChar, 40).Value = txtBuscarRtn.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                    Val = False
                    MessageBox.Show("No se encuentra este proveedor en la base de datos", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub MostrarTodoProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerProveedor As SqlDataReader
                VerProveedor = cmd.ExecuteReader()
                lsvMostrarProveedor.Items.Clear()
                While VerProveedor.Read = True
                    With Me.lsvMostrarProveedor.Items.Add(VerProveedor("RTNProveedor").ToString)
                        .SubItems.Add(VerProveedor("Nombre Completo").ToString)
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

    Private Sub MostrarProveedorRTN()
        If ExisteProveedor() = True Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarProveedorxCodigo"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@RTN", SqlDbType.NVarChar).Value = txtBuscarRtn.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerProveedor As SqlDataReader
                    VerProveedor = cmd.ExecuteReader()
                    lsvMostrarProveedor.Items.Clear()
                    While VerProveedor.Read = True
                        With Me.lsvMostrarProveedor.Items.Add(VerProveedor("RTNProveedor").ToString)
                            .SubItems.Add(VerProveedor("Nombre Completo").ToString)
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
        End If
    End Sub

    Private Sub MostrarProveedorNombre()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarProveedorPorNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerProveedor As SqlDataReader
                VerProveedor = cmd.ExecuteReader()
                lsvMostrarProveedor.Items.Clear()
                While VerProveedor.Read = True
                    With Me.lsvMostrarProveedor.Items.Add(VerProveedor("RTNProveedor").ToString)
                        .SubItems.Add(VerProveedor("Nombre Completo").ToString)
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarRtn.Text = Nothing Then
            MostrarTodoProveedor()
            txtBuscarRtn.Focus()
        Else
            MostrarProveedorRTN()
            txtBuscarRtn.Text = ""
            txtBuscarRtn.Focus()
        End If
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        txtBuscar.Enabled = True
        txtBuscar.Focus()
        btnBuscar.Enabled = False
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarRtn.Visible = False
        MostrarTodoProveedor()
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
        MostrarProveedorNombre()
    End Sub
End Class