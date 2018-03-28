Imports System.Data.SqlClient
Public Class FrmBuscarPresentacion
    Friend Property DesdeFactura As Boolean = False

    Private Sub FrmBuscarPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridPresentacion()
        GridView1.Columns(1).Visible = False
    End Sub
    Private Sub LlenarGridPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcPresentacion.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub lsvMostrar_DoubleClick_1(sender As Object, e As EventArgs) Handles lsvMostrar.DoubleClick
    '    Dim Codigo As String = lsvMostrar.FocusedItem.SubItems(6).Text
    '    Dim Presentacion As String = lsvMostrar.FocusedItem.SubItems(1).Text
    '    Dim Nombre As String = lsvMostrar.FocusedItem.SubItems(0).Text
    '    Dim CodPresentacion As String = lsvMostrar.FocusedItem.SubItems(7).Text
    '    Dim Precio As String = lsvMostrar.FocusedItem.SubItems(3).Text
    '    Dim Unidades As String = lsvMostrar.FocusedItem.SubItems(2).Text
    '    Dim Existencia As String = lsvMostrar.FocusedItem.SubItems(8).Text


    '    Dim InstanciaIProducto As IPresentacion = CType(Me.Owner, IPresentacion)

    '    If InstanciaIProducto IsNot Nothing Then
    '        InstanciaIProducto.ObtenerCodProducto(Codigo)
    '        InstanciaIProducto.ObtenerNombreProducto(Nombre)
    '        InstanciaIProducto.ObtenerPresentacion(Presentacion)
    '        InstanciaIProducto.ObtenerCodPresentacion(CodPresentacion)
    '        InstanciaIProducto.ObtenerPrecio(Precio)
    '        InstanciaIProducto.ObtenerUnidades(Unidades)
    '        InstanciaIProducto.ObtenerExistencia(Existencia)
    '    End If
    '    Close()
    'End Sub

    Private Sub GcPresentacion_DoubleClick(sender As Object, e As EventArgs) Handles GcPresentacion.DoubleClick
        Dim fila As Integer = GridView1.FocusedRowHandle
        Dim existencia As Integer = GridView1.GetRowCellValue(fila, "Existencia")

        If DesdeFactura Then
            If existencia <> 0 Then
                Venta.txtCodProducto.Text = GridView1.GetRowCellValue(fila, "IdInventario")
                Venta.CodPresentacion = GridView1.GetRowCellValue(fila, "IdTipopresentacio")
                Venta.NombreProducto = GridView1.GetRowCellValue(fila, "NombreProducto")
                Venta.txtPresentacion.Text = GridView1.GetRowCellValue(fila, "TipoPresentacion")
                Venta.txtUnidad.Text = GridView1.GetRowCellValue(fila, "Unidades")
                Venta.Existencia = GridView1.GetRowCellValue(fila, "Existencia")
                If RdbMayorista.Checked Then
                    Venta.txtPrecio.Text = GridView1.GetRowCellValue(fila, "PrecioMayorista")
                ElseIf RdbDetalle.Checked Then
                    Venta.txtPrecio.Text = GridView1.GetRowCellValue(fila, "PrecioDetalle")
                Else
                    Venta.txtPrecio.Text = GridView1.GetRowCellValue(fila, "PrecioCosto")
                End If
                Me.Close()
            Else
                MessageBox.Show("No hay suficientes productos", "BakerySystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
        End If
    End Sub

End Class