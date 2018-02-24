Imports System.Data.SqlClient
Public Class FrmProveedores
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridProveedor()
    End Sub

    Private Sub LlenarGridProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTodoProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcProveedores.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GcProveedores_Click(sender As Object, e As EventArgs) Handles GcProveedores.Click
        Dim fila As Integer = GridView1.FocusedRowHandle

        TxtRtnProveedor.Text = GridView1.GetRowCellValue(fila, "RTNProveedor")
        TxtNombreCompleto.Text = GridView1.GetRowCellValue(fila, "NombreCompleto")
        TxtEmail.Text = GridView1.GetRowCellValue(fila, "Email")
        TxtTelefono.Text = GridView1.GetRowCellValue(fila, "Telefono")
        TxtDireccion.Text = GridView1.GetRowCellValue(fila, "direccion")
    End Sub

    Sub ActualizarGrid(valor As Boolean)
        If valor Then
            Call LlenarGridProveedor()
        End If
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        FrmProveedor.ShowDialog()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Call ActualizarInventario()
    End Sub


    Private Sub ActualizarInventario()
        Dim frm As New FrmProveedor
        frm.ModoEdicion = True
        frm.RtnProveedor = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RTNProveedor")
        frm.ShowDialog()
    End Sub
    Private Sub GcProveedores_DoubleClick(sender As Object, e As EventArgs) Handles GcProveedores.DoubleClick
        Call ActualizarInventario()
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        Call LlenarGridProveedor()
    End Sub
End Class