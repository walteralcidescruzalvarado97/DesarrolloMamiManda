Imports System.Data.SqlClient
Public Class FrmBuscarCliente
    Friend Property DesdeFactura As Boolean = False
    Private Sub FrmBusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridCliente()
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "BCliente")
    End Sub

    Private Sub LlenarGridCliente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcCliente.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub LsvMostrarCliente_DoubleClick(sender As Object, e As EventArgs) Handles LsvMostrarCliente.DoubleClick
    '    Dim Codigo As String = LsvMostrarCliente.FocusedItem.SubItems(0).Text
    '    Dim DiasPlazo As Integer = LsvMostrarCliente.FocusedItem.SubItems(8).Text
    '    Dim Nombre As String = LsvMostrarCliente.FocusedItem.SubItems(1).Text
    '    Dim InstanciaICliente As ICliente = CType(Me.Owner, ICliente)

    '    If InstanciaICliente IsNot Nothing Then
    '        InstanciaICliente.ObtenerCodCliente(Codigo)
    '        InstanciaICliente.ObtenerDiasPlazoCliente(DiasPlazo)
    '        InstanciaICliente.ObtenerNombreCliente(Nombre)
    '    End If
    '    Close()
    'End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmCliente.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Call LlenarGridCliente()
    End Sub

    Private Sub GcCliente_DoubleClick(sender As Object, e As EventArgs) Handles GcCliente.DoubleClick
        Dim fila As Integer = GridView1.FocusedRowHandle

        If DesdeFactura Then
            Venta.txtCliente.Text = GridView1.GetRowCellValue(fila, "RTNCliente")
            Venta.TxtNombreCliente.Text = GridView1.GetRowCellValue(fila, "NombreCompleto")
            Venta.NuDiasPlazo.Value = GridView1.GetRowCellValue(fila, "DiasPlazo")
            Venta._Dias = GridView1.GetRowCellValue(fila, "DiasPlazo")
        End If
        Me.Close()
    End Sub
End Class