Imports System.Data.SqlClient
Public Class FrmBusquedaPresentacionesProductos
    Friend Property IdInventario As String = ""
    Private Sub FrmBusquedaPresentacionesProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridPresentacion()
    End Sub

    Private Sub LlenarGridPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CargarPresentacionProductos"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = IdInventario
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcPresentacion.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GcPresentacion_DoubleClick(sender As Object, e As EventArgs) Handles GcPresentacion.DoubleClick
        Dim fila As Integer = GridView1.FocusedRowHandle

        FrmProductoPresentacion.CodigoPresentacion = GridView1.GetRowCellValue(fila, "IdTipopresentacio")
        FrmProductoPresentacion.Unidades = GridView1.GetRowCellValue(fila, "Unidades")
        FrmProductoPresentacion.TxtNombrePresentacion.Text = GridView1.GetRowCellValue(fila, "TipoPresentacion")
        Me.Close()
    End Sub
End Class