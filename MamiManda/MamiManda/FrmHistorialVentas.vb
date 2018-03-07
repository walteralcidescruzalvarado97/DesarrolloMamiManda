Imports System.Data.SqlClient
Public Class FrmHistorialVentas

    Private Sub LlenarGridHistorial()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ListarFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@FechaDesde", SqlDbType.Date).Value = DtpFechaDesde.Value
                    .Parameters.Add("@FechaHasta", SqlDbType.Date).Value = DtpFechaHasta.Value
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcHistorial.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmHistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGridHistorial()
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Historial")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.DtpFechaDesde.Value > Me.DtpFechaHasta.Value Then
            MsgBox("No puede seleccionar una fecha inical mayor que la fecha final!")
            Return
        End If

        Call LlenarGridHistorial()
    End Sub

    Private Sub GcHistorial_DoubleClick(sender As Object, e As EventArgs) Handles GcHistorial.DoubleClick
        Dim frm As New Venta()
        frm.ModoConsulta = True
        frm.CodFacturaGuardada = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdFactura")
        frm.ShowDialog()
    End Sub
End Class