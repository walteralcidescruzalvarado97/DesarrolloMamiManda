Imports System.Data.SqlClient

Public Class FrmBuscarProveedor
    Private Sub FrmBuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoProveedor()
    End Sub



    Private Sub MostrarTodoProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerProveedor As SqlDataReader
                VerProveedor = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerProveedor.Read = True
                    With Me.lsvMostrar.Items.Add(VerProveedor("RTNProveedor").ToString)
                        .SubItems.Add(VerProveedor("Nombre").ToString)
                        .SubItems.Add(VerProveedor("Apellido").ToString)
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


    Private Sub MostrarProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerProveedor As SqlDataReader
                VerProveedor = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerProveedor.Read = True
                    With Me.lsvMostrar.Items.Add(VerProveedor("RTNProveedor").ToString)
                        .SubItems.Add(VerProveedor("Nombre").ToString)
                        .SubItems.Add(VerProveedor("Apellido").ToString)
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


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        MostrarProveedor()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmProveedor.Show()
        Close()
    End Sub

    Private Sub lsvMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMostrar.SelectedIndexChanged

    End Sub

    Private Sub lsvMostrar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lsvMostrar.MouseDoubleClick
        FrmMateriaPrima.TxtRtnProveedor.Text = lsvMostrar.FocusedItem.SubItems(0).Text
        Close()
    End Sub
End Class