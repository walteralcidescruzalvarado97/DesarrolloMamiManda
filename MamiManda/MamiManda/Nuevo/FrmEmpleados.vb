Imports System.Data.SqlClient
Public Class FrmEmpleados
    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridEmpleado()
    End Sub

    Sub Actualizar(valor As Boolean)
        If valor Then
            LlenarGridEmpleado()
        End If
    End Sub
    Private Sub LlenarGridEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcEmpleados.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GcEmpleados_Click(sender As Object, e As EventArgs) Handles GcEmpleados.Click
        Dim fila As Integer = GridView1.FocusedRowHandle

        TxtIdEmpleado.Text = GridView1.GetRowCellValue(fila, "IdEmpleado")
        TxtNombreCompleto.Text = GridView1.GetRowCellValue(fila, "NombreCompleto")
        TxtEmail.Text = GridView1.GetRowCellValue(fila, "EMail")
        TxtTelefono.Text = GridView1.GetRowCellValue(fila, "Telefono")
        TxtTipoEmpleado.Text = GridView1.GetRowCellValue(fila, "TipoEmpleado")
        TxtDireccion.Text = GridView1.GetRowCellValue(fila, "direccion")
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        FrmEmpleado.ShowDialog()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Call EditarEmpleado()
    End Sub

    Private Sub EditarEmpleado()
        Dim frm As New FrmEmpleado
        frm.ModoEdicion = True
        frm.IdEmpleado = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdEmpleado")
        frm.ShowDialog(Me)
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        Call LlenarGridEmpleado()
    End Sub

    Private Sub GcEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles GcEmpleados.DoubleClick
        Call EditarEmpleado()
    End Sub
End Class