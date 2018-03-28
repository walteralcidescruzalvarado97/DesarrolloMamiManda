Imports System.Data.SqlClient
Public Class FrmBuscarInventario
    Friend Property DesdeProduccion As Boolean = False
    Friend Property DesdeReceta As Boolean = False
    Friend Property DesdePresentacion As Boolean = False
    Friend Property DesdeProductoTerminado As Boolean = False
    Private Sub FrmBuscarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridInventario()
    End Sub

    Private Sub LlenarGridInventario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarInventario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcInventario.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmInventario.Show()
        Me.Close()
    End Sub

    Private Sub GcInventario_DoubleClick(sender As Object, e As EventArgs) Handles GcInventario.DoubleClick
        If DesdeProduccion Then
            Dim fila As Integer = GridView1.FocusedRowHandle

            FrmProduccion.txtCodProducto.Text = GridView1.GetRowCellValue(fila, "IdInventario")
            FrmProduccion.txtProducto.Text = GridView1.GetRowCellValue(fila, "NombreProducto")
        End If

        If DesdeReceta Then
            Dim fila As Integer = GridView1.FocusedRowHandle

            FrmReceta.txtCodProducto.Text = GridView1.GetRowCellValue(fila, "IdInventario")
        End If

        If DesdePresentacion Then
            Dim fila As Integer = GridView1.FocusedRowHandle

            FrmPresentacionProducto.txtCodInventario.Text = GridView1.GetRowCellValue(fila, "IdInventario")
            FrmPresentacionProducto.txtNombre.Text = GridView1.GetRowCellValue(fila, "NombreProducto")
        End If

        If DesdeProductoTerminado Then
            Dim fila As Integer = GridView1.FocusedRowHandle

            FrmProductoPresentacion.txtCodInventario.Text = GridView1.GetRowCellValue(fila, "IdInventario")
            FrmProductoPresentacion.txtNombre.Text = GridView1.GetRowCellValue(fila, "NombreProducto")
        End If
        Me.Close()
    End Sub
    'Private Sub lsvMostrar_DoubleClick(sender As Object, e As EventArgs)
    '    Dim Dato As String = lsvMostrar.FocusedItem.SubItems(0).Text
    '    Dim Nombre As String = lsvMostrar.FocusedItem.SubItems(1).Text
    '    Dim InstanciaForm As IForm = CType(Me.Owner, IForm)
    '    Dim InstanciaForm2 As IForm2 = CType(Me.Owner, IForm2)

    '    If InstanciaForm IsNot Nothing Then
    '        InstanciaForm.ObtenerDato(Dato)
    '    End If

    '    If InstanciaForm2 IsNot Nothing Then
    '        InstanciaForm2.ObtenerNombre(Nombre)
    '    End If

    '    Close()
    'End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call LlenarGridInventario()
    End Sub
End Class