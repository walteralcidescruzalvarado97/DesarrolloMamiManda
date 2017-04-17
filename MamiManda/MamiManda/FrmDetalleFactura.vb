Imports System.Data.SqlClient
Public Class FrmDetalleFactura
    Public codigo As Integer
    Private Sub FrmDetalleFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDetalle()
    End Sub

    Private Sub MostrarDetalle()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarDetalle"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = codigo
                    .Connection = cnn
                End With
                Dim VerDetalle As SqlDataReader
                VerDetalle = cmd.ExecuteReader()
                LsvMostrarVentas.Items.Clear()
                While VerDetalle.Read = True
                    With Me.LsvMostrarVentas.Items.Add(VerDetalle("NombreProducto").ToString)
                        .SubItems.Add(VerDetalle("TipoPresentacion").ToString)
                        .SubItems.Add(VerDetalle("Cantidad").ToString)
                        .SubItems.Add(VerDetalle("Precio").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
End Class