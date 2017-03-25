Imports System.Data.SqlClient
Public Class FrmBuscarMateriaPrima
    Private Sub FrmBuscarMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoMateriaPrima()
    End Sub

    Private Sub MostrarTodoMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerMateriaPrima As SqlDataReader
                VerMateriaPrima = cmd.ExecuteReader()
                LsvMostrarMateriaPrima.Items.Clear()
                While VerMateriaPrima.Read = True
                    With Me.LsvMostrarMateriaPrima.Items.Add(VerMateriaPrima("IdMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("NombreMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("ExistenciaMinima").ToString)
                        .SubItems.Add(VerMateriaPrima("Existencia").ToString)
                        .SubItems.Add(VerMateriaPrima("Cantidad").ToString)
                        .SubItems.Add(VerMateriaPrima("PrecioCostoM").ToString)
                        .SubItems.Add(VerMateriaPrima("Fecha").ToString)
                        .SubItems.Add(VerMateriaPrima("Medida").ToString)
                        .SubItems.Add(VerMateriaPrima("RtnProveedor").ToString)

                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerMateriaPrima As SqlDataReader
                VerMateriaPrima = cmd.ExecuteReader()
                LsvMostrarMateriaPrima.Items.Clear()
                While VerMateriaPrima.Read = True
                    With Me.LsvMostrarMateriaPrima.Items.Add(VerMateriaPrima("IdMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("NombreMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("ExistenciaMinima").ToString)
                        .SubItems.Add(VerMateriaPrima("Existencia").ToString)
                        .SubItems.Add(VerMateriaPrima("Cantidad").ToString)
                        .SubItems.Add(VerMateriaPrima("PrecioCostoM").ToString)
                        .SubItems.Add(VerMateriaPrima("Fecha").ToString)
                        .SubItems.Add(VerMateriaPrima("Medida").ToString)
                        .SubItems.Add(VerMateriaPrima("RtnProveedor").ToString)
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
        MostrarMateriaPrima()
    End Sub
End Class