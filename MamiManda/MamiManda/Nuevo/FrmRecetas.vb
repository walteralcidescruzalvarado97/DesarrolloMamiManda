Imports System.Data.SqlClient
Public Class FrmRecetas
    Private Sub FrmRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridReceta()
    End Sub

    Private Sub LlenarGridReceta()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CargarRecetas"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcClientes.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        FrmReceta.ShowDialog()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Call EditarReceta()
    End Sub

    Private Sub EditarReceta()
        Dim frm As New FrmReceta
        frm.ModoEdicion = True
        frm.IdProducto = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdInventario")
        frm.ShowDialog()
    End Sub

    Private Sub GcClientes_DoubleClick(sender As Object, e As EventArgs) Handles GcClientes.DoubleClick
        Call EditarReceta()
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        Call LlenarGridReceta()
    End Sub
End Class