Imports System.Data.SqlClient
Public Class FrmMateriasPrimas
    Private Sub FrmMateriasPrimas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarMateriaPrima()
    End Sub

    Private Sub LlenarMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcMateriaPrima.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GcMateriaPrima_Click(sender As Object, e As EventArgs) Handles GcMateriaPrima.Click
        Dim fila As Integer = GridView1.FocusedRowHandle

        TxtCodigo.Text = GridView1.GetRowCellValue(fila, "IdMateriaPrima")
        TxtMateriaPrima.Text = GridView1.GetRowCellValue(fila, "NombreMateriaPrima")
        TxtExistenciaMinima.Text = GridView1.GetRowCellValue(fila, "ExistenciaMinima")
        TxtExistencia.Text = GridView1.GetRowCellValue(fila, "Existencia")
        TxtMedida.Text = GridView1.GetRowCellValue(fila, "Medida")
        TxtProveedor.Text = GridView1.GetRowCellValue(fila, "NombreCompleto")
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        FrmMateriaPrima.ShowDialog(Me)
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Call EditarMateriaPrima()
    End Sub

    Private Sub EditarMateriaPrima()
        Dim Frm As New FrmMateriaPrima
        Frm.ModoEdicion = True
        Frm.IdMateria = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdMateriaPrima")
        Frm.ShowDialog(Me)
    End Sub

    Private Sub GcMateriaPrima_DoubleClick(sender As Object, e As EventArgs) Handles GcMateriaPrima.DoubleClick
        Call EditarMateriaPrima()
    End Sub


    Sub ActualizarTablas(valor As Boolean)
        If valor Then
            Call LlenarMateriaPrima()
        End If
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        Call LlenarMateriaPrima()
    End Sub
End Class