Imports System.Data.SqlClient
Public Class FrmBuscarUsuario
    Private Sub FrmBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuario()
    End Sub

#Region "Llenar"

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

    Private Sub ListarUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ListarUsuario()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmUsuario.Show()
        Close()
    End Sub


End Class