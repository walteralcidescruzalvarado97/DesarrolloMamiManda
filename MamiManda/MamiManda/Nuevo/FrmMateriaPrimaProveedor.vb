Imports System.Data.SqlClient
Public Class FrmMateriaPrimaProveedor

    Private Sub FrmMateriaPrimaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridProveedores()
    End Sub

    Private Sub LlenarGridProveedores()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarGridProveedores"
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

    Private Sub LlenarGridMateriaPrimaDisponible()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ConsultarMateriaPrimaDisponible"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@RTNProveedor", SqlDbType.NVarChar).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RTNProveedor")
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcMateriaPrimaD.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LlenarGridMateriaPrimaAsignada()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ConsultarMateriaPrimaAsignada"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@RTNProveedor", SqlDbType.NVarChar).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RTNProveedor")
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcMateriaPrimaA.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertarMateriaPrimaProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            cnn.Open()
            Try
                With cmd
                    .CommandText = "Sp_InsertarMateriaPrimaProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdMateriaPrima", SqlDbType.Int).Value = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "IdMateriaPrima")
                    .Parameters.Add("@RTNProveedor", SqlDbType.NVarChar).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RTNProveedor")
                    .ExecuteNonQuery()
                    MessageBox.Show("Materia prima asignada con éxito", "MamiManda", MessageBoxButtons.OK)
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub EliminarMateriaPrimaProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            cnn.Open()
            Try
                With cmd
                    .CommandText = "Sp_EliminarMateriaPrimaProvedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdMateriaPrima", SqlDbType.Int).Value = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "IdMateriaPrima")
                    .Parameters.Add("@RTNProveedor", SqlDbType.NVarChar).Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RTNProveedor")
                    .ExecuteNonQuery()
                    MessageBox.Show("Materia prima eliminada con éxito", "MamiManda", MessageBoxButtons.OK)
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub GcProveedores_Click(sender As Object, e As EventArgs) Handles GcProveedores.Click
        Call LlenarGridMateriaPrimaDisponible()
        Call LlenarGridMateriaPrimaAsignada()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Call InsertarMateriaPrimaProveedor()
        Call LlenarGridMateriaPrimaAsignada()
        Call LlenarGridMateriaPrimaDisponible()
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        Call EliminarMateriaPrimaProveedor()
        Call LlenarGridMateriaPrimaAsignada()
        Call LlenarGridMateriaPrimaDisponible()
    End Sub
End Class