Imports System.Data.SqlClient
Public Class FrmBuscarInventario
    Private Sub FrmBuscarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarInventario()
    End Sub

    Private Sub MostrarInventario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerInventario As SqlDataReader
                VerInventario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerInventario.Read = True
                    With Me.lsvMostrar.Items.Add(VerInventario("IdInventario").ToString)
                        .SubItems.Add(VerInventario("NombreProducto").ToString)
                        .SubItems.Add(VerInventario("ExistenciaMaxima").ToString)
                        .SubItems.Add(VerInventario("ExistenciaMinima").ToString)
                        .SubItems.Add(VerInventario("Existencia").ToString)
                        .SubItems.Add(VerInventario("Tamano").ToString)
                        .SubItems.Add(VerInventario("IdUsuario").ToString)
                        .SubItems.Add(VerInventario("IdTamano").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ListarInventario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerInventario As SqlDataReader
                VerInventario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerInventario.Read = True
                    With Me.lsvMostrar.Items.Add(VerInventario("IdInventario").ToString)
                        .SubItems.Add(VerInventario("NombreProducto").ToString)
                        .SubItems.Add(VerInventario("ExistenciaMaxima").ToString)
                        .SubItems.Add(VerInventario("ExistenciaMinima").ToString)
                        .SubItems.Add(VerInventario("Existencia").ToString)
                        .SubItems.Add(VerInventario("Tamano").ToString)
                        .SubItems.Add(VerInventario("IdUsuario").ToString)
                        .SubItems.Add(VerInventario("IdTamano").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmInventario.Show()
        Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ListarInventario()
    End Sub

    Private Sub lsvMostrar_DoubleClick(sender As Object, e As EventArgs) Handles lsvMostrar.DoubleClick
        Dim Dato As String = lsvMostrar.FocusedItem.SubItems(0).Text
        Dim Nombre As String = lsvMostrar.FocusedItem.SubItems(1).Text
        Dim InstanciaForm As IForm = CType(Me.Owner, IForm)
        Dim InstanciaForm2 As IForm2 = CType(Me.Owner, IForm2)

        If InstanciaForm IsNot Nothing Then
            InstanciaForm.ObtenerDato(Dato)
        End If

        If InstanciaForm2 IsNot Nothing Then
            InstanciaForm2.ObtenerNombre(Nombre)
        End If

        Close()
    End Sub
End Class