Imports System.Data.SqlClient
Public Class FrmHistorialVentas

    Private Sub MostrarFactura()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerFactura As SqlDataReader
                VerFactura = cmd.ExecuteReader()
                LsvMostrarVentas.Items.Clear()
                While VerFactura.Read = True
                    With Me.LsvMostrarVentas.Items.Add(VerFactura("IdFactura").ToString)
                        .SubItems.Add(VerFactura("RTNCliente").ToString)
                        .SubItems.Add(VerFactura("Fecha").ToString)
                        .SubItems.Add(VerFactura("TipoDocumento").ToString)
                        .SubItems.Add(VerFactura("TipoFactura").ToString)
                        .SubItems.Add(VerFactura("Subtotal").ToString)
                        .SubItems.Add(VerFactura("ISV").ToString)
                        .SubItems.Add(VerFactura("Total").ToString)
                        .SubItems.Add(VerFactura("UserName").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmHistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarFactura()

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Historial")
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        MostrarFactura()
    End Sub

    Private Sub LsvMostrarVentas_DoubleClick(sender As Object, e As EventArgs) Handles LsvMostrarVentas.DoubleClick
        Dim frm As New FrmDetalleFactura()
        frm.codigo = LsvMostrarVentas.FocusedItem.SubItems(0).Text
        frm.ShowDialog()
    End Sub
End Class