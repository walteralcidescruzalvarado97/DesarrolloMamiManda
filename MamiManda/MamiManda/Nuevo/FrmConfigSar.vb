Imports System.Data.SqlClient
Public Class FrmConfigSar
    Private Sub FrmConfigSar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGrid()
    End Sub

    Private Sub LlenarGrid()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarCai"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Da As New SqlDataAdapter(cmd)
                    Dim Dt As New DataTable

                    Da.Fill(Dt)
                    Me.DtgCai.AutoGenerateColumns = False

                    With Me.DtgCai
                        .Columns("DtCai").DataPropertyName = "Cai"
                        .Columns("DtFechaInicial").DataPropertyName = "FechaInicio"
                        .Columns("DtFechaFinal").DataPropertyName = "FechaFinal"
                        .Columns("DtUsado").DataPropertyName = "Usado"
                        .Columns("DtInicio").DataPropertyName = "CorrelativoDesde"
                        .Columns("DtFin").DataPropertyName = "CorrelativoHasta"
                    End With

                    Me.DtgCai.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ActualizarTablas(valor As Boolean)
        If valor Then
            LlenarGrid()
        End If
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Call EditarCai()
    End Sub

    Private Sub EditarCai()
        Dim frm As New ConfiguracionCai
        frm.Cai = DtgCai.CurrentRow.Cells(0).Value
        frm.ModoEdicion = True
        frm.ShowDialog(Me)
    End Sub
    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        ConfiguracionCai.ShowDialog(Me)
    End Sub

    Private Sub DtgCai_DoubleClick(sender As Object, e As EventArgs) Handles DtgCai.DoubleClick
        Call EditarCai()
    End Sub
End Class