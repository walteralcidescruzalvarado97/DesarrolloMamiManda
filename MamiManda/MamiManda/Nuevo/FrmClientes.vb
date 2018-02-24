Imports System.Data.SqlClient
Public Class FrmClientes
    Private Sub LlenarGridCliente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarCliente"
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

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGridCliente()
    End Sub

    Sub ActualizarTablas(valor As Boolean)
        If valor Then
            LlenarGridCliente()
        End If
    End Sub
    Private Sub GcClientes_Click(sender As Object, e As EventArgs) Handles GcClientes.Click
        Dim filas As Integer = GridView1.FocusedRowHandle

        TxtRtnCliente.Text = GridView1.GetRowCellValue(filas, "RTNCliente")
        TxtNombreCompleto.Text = GridView1.GetRowCellValue(filas, "NombreCompleto")
        TxtEmail.Text = GridView1.GetRowCellValue(filas, "EMail")
        TxtTelefono.Text = GridView1.GetRowCellValue(filas, "Telefono")
        TxtDiazPlazo.Text = GridView1.GetRowCellValue(filas, "DiasPlazo")
        TxtDireccion.Text = GridView1.GetRowCellValue(filas, "Direccion")
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        FrmCliente.ShowDialog(Me)
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Call EditarCliente()
    End Sub
    Private Sub EditarCliente()
        Dim Frm As New FrmCliente
        Frm.ModoEdicion = True
        Frm.RtnCliente = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RTNCliente")
        Frm.ShowDialog(Me)
    End Sub
    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        Call LlenarGridCliente()
    End Sub

    Private Sub GcClientes_DoubleClick(sender As Object, e As EventArgs) Handles GcClientes.DoubleClick
        Call EditarCliente()
    End Sub
End Class