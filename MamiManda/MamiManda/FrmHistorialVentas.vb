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
                    .Connection = cnn
                    .Parameters.Add("@FechaDesde", SqlDbType.Date).Value = DtpFechaDesde.Value
                    .Parameters.Add("@FechaHasta", SqlDbType.Date).Value = DtpFechaHasta.Value
                End With
                Dim VerFactura As SqlDataReader
                VerFactura = cmd.ExecuteReader()
                LsvMostrarVentas.Items.Clear()
                While VerFactura.Read = True
                    Dim Fecha As String = VerFactura("Fecha").ToString
                    Dim Fecha1 As String() = Fecha.Split(" ")
                    With Me.LsvMostrarVentas.Items.Add(VerFactura("IdFactura").ToString)
                        .SubItems.Add(VerFactura("Cliente").ToString)
                        .SubItems.Add(Fecha1(0).ToString)
                        .SubItems.Add(VerFactura("TipoPago").ToString)
                        .SubItems.Add(VerFactura("EstadoFactura").ToString)
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        MostrarFactura()
    End Sub

    Private Sub LsvMostrarVentas_DoubleClick(sender As Object, e As EventArgs) Handles LsvMostrarVentas.DoubleClick
        Dim frm As New Venta()
        frm.ModoConsulta = True
        frm.CodFacturaGuardada = LsvMostrarVentas.FocusedItem.SubItems(0).Text
        frm.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.DtpFechaDesde.Value > Me.DtpFechaHasta.Value Then
            MsgBox("No puede seleccionar una fecha inical mayor que la fecha final!")
            Return
        End If

        Call MostrarFactura()
    End Sub
End Class