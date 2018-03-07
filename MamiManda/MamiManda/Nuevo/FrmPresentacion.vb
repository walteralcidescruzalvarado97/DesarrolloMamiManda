Imports System.Data.SqlClient
Public Class FrmPresentacion

    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    .CommandText = "Sp_MostrarPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
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

    Private Sub GcPresentacion_Click(sender As Object, e As EventArgs) Handles GcPresentacion.Click
        Dim fila As Integer = GridView1.FocusedRowHandle

        TxtNombre.Text = GridView1.GetRowCellValue(fila, "NombreProducto")
        TxtPresentacion.Text = GridView1.GetRowCellValue(fila, "TipoPresentacion")
        TxtPm.Text = GridView1.GetRowCellValue(fila, "PrecioMayorista")
        TxtPd.Text = GridView1.GetRowCellValue(fila, "PrecioDetalle")
        TxtPc.Text = GridView1.GetRowCellValue(fila, "PrecioCosto")
        TxtUnidades.Text = GridView1.GetRowCellValue(fila, "Unidades")
    End Sub

    Private Sub EditarPresentacion()
        Dim Frm As New FrmPresentacionProducto
        Frm.ModoEdicion = True
        Frm.Codigo = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdInventario")
        Frm.ShowDialog(Me)
    End Sub

    Private Sub GcPresentacion_DoubleClick(sender As Object, e As EventArgs) Handles GcPresentacion.DoubleClick
        Call EditarPresentacion()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Call EditarPresentacion()
    End Sub

    Sub ActualizarTablas(valor As Boolean)
        If valor Then
            Call LlenarGridPresentacion()
        End If
    End Sub
    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        FrmPresentacionProducto.ShowDialog()
    End Sub
End Class