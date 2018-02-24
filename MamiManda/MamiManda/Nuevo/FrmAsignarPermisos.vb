Imports System.Data.SqlClient
Public Class FrmAsignarPermisos

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

    Private Sub LlenarModulosDisponibles()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ConsultarModulos"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcModulosDisponibles.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LlenarGridModulosDisponibles()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ConsultarModulosDisponibles"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdUsuario")
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcModulosDisponibles.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LlenarGridModulosAsignados()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ModulosAsignados"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdUsuario")
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcModulosAsignados.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertarPermisos()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            cnn.Open()
            Try
                With cmd
                    .CommandText = "Sp_InsertarPermisos"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdUsuario")
                    .Parameters.Add("@IdModulo", SqlDbType.Int).Value = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "IdModulo")
                    .ExecuteNonQuery()
                    MessageBox.Show("Permiso asignado con éxito", "MamiManda", MessageBoxButtons.OK)
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub RemoverPermisos()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            cnn.Open()
            Try
                With cmd
                    .CommandText = "Sp_RemoverPermiso"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdUsuario")
                    .Parameters.Add("@IdModulo", SqlDbType.Int).Value = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "IdModulo")
                    .ExecuteNonQuery()
                    MessageBox.Show("Permiso removido con éxito", "MamiManda", MessageBoxButtons.OK)
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
    Private Sub FrmAsignarPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridUsuario()
        Call LlenarModulosDisponibles()
    End Sub

    Private Sub GcUsuario_Click(sender As Object, e As EventArgs) Handles GcUsuario.Click
        Call LlenarGridModulosDisponibles()
        Call LlenarGridModulosAsignados()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Call InsertarPermisos()
        Call LlenarModulosDisponibles()
        Call LlenarGridModulosAsignados()
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        Call RemoverPermisos()
        Call LlenarGridModulosAsignados()
        Call LlenarGridModulosDisponibles()
    End Sub
End Class