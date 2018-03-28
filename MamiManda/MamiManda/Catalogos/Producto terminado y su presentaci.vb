Imports System.Data.SqlClient
Public Class FrmProductoPresentacion
    Friend Property Unidades As Integer = 0
    Friend Property CodigoPresentacion As Integer = 0
    Private Sub InsertarProductoPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            cnn.Open()
            Try
                With cmd
                    .CommandText = "Sp_InsertarProductoPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Existencia", SqlDbType.Int).Value = TxtExistencia.Text
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodInventario.Text
                    .Parameters.Add("@IdTipoPresentacio", SqlDbType.Int).Value = CodigoPresentacion
                    .ExecuteNonQuery()
                    MessageBox.Show("El Producto con su presentación han sido creados", "MamiManda", MessageBoxButtons.OK)
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub RestarProducto()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_RestarProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodInventario.Text.Trim
                    .Parameters.Add("@CantidadExistencia", SqlDbType.Int).Value = TxtExistencia.Text
                    .Parameters.Add("@CantidadPresentacion", SqlDbType.Int).Value = Unidades
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            ErrorProvider1.SetError(Control, "")
            Validar = False
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtCodInventario, "Debe seleccionar un producto") Then
        ElseIf Validar(TxtExistencia, "Debe ingresar la existencia para producir el producto con su presentación") Then
        Else
            Call InsertarProductoPresentacion()
            Call RestarProducto()
            Call Limpiar()
        End If
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim BuscarInventario As New FrmBuscarInventario
        BuscarInventario.DesdeProductoTerminado = True
        BuscarInventario.Show(Me)
    End Sub

    Private Sub BtnBuscarPresentacion_Click(sender As Object, e As EventArgs) Handles BtnBuscarPresentacion.Click
        Dim frm As New FrmBusquedaPresentacionesProductos
        frm.IdInventario = txtCodInventario.Text
        frm.ShowDialog()
        frm.Focus()
    End Sub

    Private Sub Limpiar()
        txtCodInventario.Text = Nothing
        txtNombre.Text = Nothing
        TxtExistencia.Text = Nothing
        TxtNombrePresentacion.Text = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call Limpiar()
        Me.Close()
    End Sub

    Private Sub FrmProductoPresentacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Call Limpiar()
    End Sub
End Class