Imports System.Data.SqlClient
Public Class FrmInventarios
    Private Sub FrmInventariosvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridInventario()
    End Sub

    Private Sub LlenarGridInventario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcInventario.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GcInventario_Click(sender As Object, e As EventArgs) Handles GcInventario.Click
        Dim filas As Integer = GridView1.FocusedRowHandle

        TxtCodInventario.Text = GridView1.GetRowCellValue(filas, "IdInventario")
        TxtNombreProducto.Text = GridView1.GetRowCellValue(filas, "NombreProducto")
        TxtExistenciaMaxima.Text = GridView1.GetRowCellValue(filas, "ExistenciaMaxima")
        TxtExistenciaMinima.Text = GridView1.GetRowCellValue(filas, "ExistenciaMinima")
        TxtExistencia.Text = GridView1.GetRowCellValue(filas, "Existencia")
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        FrmInventario.ShowDialog()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Dim frm As New FrmInventario
        frm.ModoEdicion = True
        frm.IdInventario = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdInventario")
        frm.ShowDialog(Me)
    End Sub

    Sub ActualizarGrid(valor As Boolean)
        If valor Then
            Call LlenarGridInventario()
        End If
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        Call LlenarGridInventario()
    End Sub
End Class