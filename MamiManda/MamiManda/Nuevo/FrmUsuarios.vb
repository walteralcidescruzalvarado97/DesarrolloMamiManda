Imports System.Data.SqlClient
Imports System.IO
Public Class FrmUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridUsuario()
    End Sub

    Private Sub LlenarGridUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTodoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcUsuario.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarImagen()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        'Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BakerySystem;Integrated Security=True")
        Dim command As New SqlCommand("SELECT Foto FROM Usuario where IdUsuario = @var", cnn)
        command.Parameters.Add("@var", SqlDbType.VarChar).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdUsuario")

        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)

        If IsDBNull(table.Rows(0)(0)) Then
        Else
            Dim img() As Byte
            img = table.Rows(0)(0)
            Dim ms As New MemoryStream(img)
            FotoAgregar.Image = Image.FromStream(ms)
        End If
    End Sub

    Sub ActualizarTablas(valor As Boolean)
        If valor Then
            LlenarGridUsuario()
        End If
    End Sub
    Private Sub GcUsuario_Click(sender As Object, e As EventArgs) Handles GcUsuario.Click
        Dim fila As Integer = GridView1.FocusedRowHandle

        TxtIdUsuario.Text = GridView1.GetRowCellValue(fila, "IdUsuario")
        TxtNombre.Text = GridView1.GetRowCellValue(fila, "Nombre Completo")
        TxtUsuario.Text = GridView1.GetRowCellValue(fila, "UserName")
        TxtTIpoUsuario.Text = GridView1.GetRowCellValue(fila, "TipoUsuario")

        MostrarImagen()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        EditarUsuario()
    End Sub

    Private Sub EditarUsuario()
        Dim frm As New FrmUsuario
        frm.ModoEdicion = True
        frm.IdUsuario = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdUsuario")
        frm.ShowDialog()
    End Sub

    Private Sub GcUsuario_DoubleClick(sender As Object, e As EventArgs) Handles GcUsuario.DoubleClick
        Call EditarUsuario()
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        FrmUsuario.ShowDialog()
    End Sub
End Class