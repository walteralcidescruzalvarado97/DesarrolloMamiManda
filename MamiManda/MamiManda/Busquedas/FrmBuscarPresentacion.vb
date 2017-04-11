Imports System.Data.SqlClient
Public Class FrmBuscarPresentacion
    Private Sub FrmBuscarPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPresentacion()
    End Sub

#Region "Llenar"


    Private Sub ListarPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarPresentacionProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("NombreProducto").ToString)
                        .SubItems.Add(VerEmpleado("TipoPresentacion").ToString)
                        .SubItems.Add(VerEmpleado("Unidades").ToString)
                        .SubItems.Add(VerEmpleado("PrecioMayorista").ToString)
                        .SubItems.Add(VerEmpleado("PrecioDetalle").ToString)
                        .SubItems.Add(VerEmpleado("PrecioCosto").ToString)
                        .SubItems.Add(VerEmpleado("IdInventario").ToString)
                        .SubItems.Add(VerEmpleado("IdTipoPresentacio").ToString)
                        .SubItems.Add(VerEmpleado("Existencia").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub


#End Region

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ListarPresentacion()
    End Sub


    Private Sub lsvMostrar_DoubleClick_1(sender As Object, e As EventArgs) Handles lsvMostrar.DoubleClick
        Dim Codigo As String = lsvMostrar.FocusedItem.SubItems(6).Text
        Dim Presentacion As String = lsvMostrar.FocusedItem.SubItems(1).Text
        Dim Nombre As String = lsvMostrar.FocusedItem.SubItems(0).Text
        Dim CodPresentacion As String = lsvMostrar.FocusedItem.SubItems(7).Text
        Dim Precio As String = lsvMostrar.FocusedItem.SubItems(3).Text
        Dim Unidades As String = lsvMostrar.FocusedItem.SubItems(2).Text
        Dim Existencia As String = lsvMostrar.FocusedItem.SubItems(8).Text


        Dim InstanciaIProducto As IPresentacion = CType(Me.Owner, IPresentacion)

        If InstanciaIProducto IsNot Nothing Then
            InstanciaIProducto.ObtenerCodProducto(Codigo)
            InstanciaIProducto.ObtenerNombreProducto(Nombre)
            InstanciaIProducto.ObtenerPresentacion(Presentacion)
            InstanciaIProducto.ObtenerCodPresentacion(CodPresentacion)
            InstanciaIProducto.ObtenerPrecio(Precio)
            InstanciaIProducto.ObtenerUnidades(Unidades)
            InstanciaIProducto.ObtenerExistencia(Existencia)
        End If
        Close()
    End Sub
End Class