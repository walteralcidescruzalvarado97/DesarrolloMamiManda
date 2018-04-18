Imports System.Data.SqlClient
Public Class ConfiguracionCai
    Friend Property ModoEdicion As Boolean = False
    Friend Property Cai As String = ""
    Sub Limpiar()
        TxtCai.Text = Nothing
        TxtInicio.Text = Nothing
        TxtFin.Text = Nothing
    End Sub
    Private Sub HabilitarControles(ByVal Habilitado As Boolean)
        TxtCai.Enabled = Habilitado
        DtFechaInicio.Enabled = Habilitado
        DtFechaFin.Enabled = Habilitado
        ChkUsado.Enabled = Habilitado
        TxtInicio.Enabled = Habilitado
        TxtFin.Enabled = Habilitado
    End Sub

    Private Sub LimpiarControles()
        TxtCai.Text = ""
        DtFechaInicio.Value = Now.Date
        DtFechaFin.Value = Now.Date.AddDays(365)
        ChkUsado.Checked = False
        TxtInicio.Text = ""
        TxtFin.Text = ""
        TxtCai.Focus()
    End Sub

    Private Sub HabilitarBotones(Guardar As Boolean, Cancelar As Boolean)
        BtnGuardar.Enabled = Guardar
        BtnCancelar.Enabled = Cancelar
    End Sub

    Private Sub ConfiguracionCai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, True)
        HabilitarControles(True)
        If ModoEdicion Then
            Call CargarDatosCai()
        End If
    End Sub
    Function Validar() As Boolean
        If TxtCai.Text.Length <> 37 Then
            EpValidar.SetError(TxtCai, "Ingrese el CAI")
            TxtCai.Focus()
            Validar = False
        Else
            EpValidar.SetError(TxtCai, "")
            Validar = True
        End If

        If TxtInicio.Text.Length <> 19 Then
            EpValidar.SetError(TxtInicio, "Ingrese el correlativo desde")
            TxtInicio.Focus()
            Validar = False
        Else
            EpValidar.SetError(TxtInicio, "")
            Validar = True
        End If

        If TxtFin.Text.Length <> 19 Then
            EpValidar.SetError(TxtFin, "Ingrese el correlativo hasta")
            TxtFin.Focus()
            Validar = False
        Else
            EpValidar.SetError(TxtFin, "")
            Validar = True
        End If

        Return Validar
    End Function

    Private Sub CargarDatosCai()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            cnn.Open()
            Try
                With cmd
                    .CommandText = "Sp_CargarDatosCai"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Cai", SqlDbType.NVarChar).Value = Cai
                End With

                Dim lector As SqlDataReader = cmd.ExecuteReader

                While lector.Read
                    TxtCai.Text = lector("Cai").ToString
                    DtFechaInicio.Value = lector("FechaInicio").ToString
                    DtFechaFin.Value = lector("FechaFinal").ToString
                    TxtInicio.Text = lector("CorrelativoDesde").ToString
                    TxtFin.Text = lector("CorrelativoHasta").ToString
                    ChkUsado.Checked = lector("Usado").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
    Private Sub InsertarCai()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarCai"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Cai", SqlDbType.NVarChar).Value = TxtCai.Text
                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = DtFechaInicio.Value
                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = DtFechaFin.Value
                    .Parameters.Add("@CorrelativoDesde", SqlDbType.NVarChar).Value = TxtInicio.Text
                    .Parameters.Add("@CorrelativoHasta", SqlDbType.NVarChar).Value = TxtFin.Text
                    .Parameters.Add("@Usado", SqlDbType.Bit).Value = ChkUsado.CheckState
                    .ExecuteNonQuery()
                    MessageBox.Show("El Cai ha sido agregado", "MamiManda", MessageBoxButtons.OK)
                End With

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ActualizarCai()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarCai"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Cai", SqlDbType.NVarChar).Value = TxtCai.Text
                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = DtFechaInicio.Value
                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = DtFechaFin.Value
                    .Parameters.Add("@CorrelativoDesde", SqlDbType.NVarChar).Value = TxtInicio.Text
                    .Parameters.Add("@CorrelativoHasta", SqlDbType.NVarChar).Value = TxtFin.Text
                    .Parameters.Add("@Usado", SqlDbType.Bit).Value = ChkUsado.CheckState
                    .ExecuteNonQuery()
                    MessageBox.Show("El Cai ha sido actualizado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function ExisteRegistro() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteCai"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Cai", SqlDbType.NVarChar).Value = TxtCai.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este Cai", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Validar() = True Then
            If ModoEdicion Then
                Call ActualizarCai()
            Else
                If ExisteRegistro() = False Then
                    Call InsertarCai()
                End If
            End If
            Limpiar()
            HabilitarControles(False)
            HabilitarBotones(False, False)
            FrmConfigSar.ActualizarTablas(True)
        End If

        Me.Close()
    End Sub

    Private Sub TxtCai_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtCai.MaskInputRejected
        EpValidar.Clear()
    End Sub

    Private Sub TxtInicio_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtInicio.MaskInputRejected
        EpValidar.Clear()
    End Sub

    Private Sub TxtFin_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtFin.MaskInputRejected
        EpValidar.Clear()
    End Sub
End Class