Imports System.Data.SqlClient

Public Class FrmMateriaPrima
    Dim existencia As Integer
    Friend Property ModoEdicion As Boolean = False
    Friend Property IdMateria As Integer = 0
    Private Sub InvestigarCorrelativo()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarEmpleado As New SqlCommand("Sp_MostrarIdMateriaPrimaIdentity", cnn)
            ListarEmpleado.CommandType = CommandType.StoredProcedure
            Dim Listarempleados As SqlDataReader
            cnn.Open()
            Listarempleados = ListarEmpleado.ExecuteReader
            If Listarempleados.Read = True Then
                If Listarempleados("Id") Is DBNull.Value Then
                    TxtIdMateriaPrima.Text = 1
                Else
                    TxtIdMateriaPrima.Text = Listarempleados("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboboxUnidadMedida()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboUnidadMedida"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "UnidadMedida")
                Me.CboUnidadMedida.DataSource = ds.Tables(0)
                Me.CboUnidadMedida.DisplayMember = ds.Tables(0).Columns("Medida").ToString
                Me.CboUnidadMedida.ValueMember = ds.Tables(0).Columns("IdUnidadMedida").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub CargarDatosMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            cnn.Open()

            Try
                With cmd
                    .CommandText = "Sp_CargarDatosMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdMateriaPrima", SqlDbType.Int).Value = IdMateria
                End With

                Dim lector As SqlDataReader = cmd.ExecuteReader

                While lector.Read
                    TxtIdMateriaPrima.Text = lector("IdMateriaPrima").ToString
                    TxtNombreMateriaPrima.Text = lector("NombreMateriaPrima").ToString
                    TxtExistenciaMinima.Text = lector("ExistenciaMinima").ToString
                    TxtPrecio.Text = lector("PrecioCostoM").ToString
                    CboUnidadMedida.SelectedValue = lector("IdUnidadMedida").ToString
                    TxtRtnProveedor.Text = lector("RTNProveedor").ToString
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
    Private Sub AgregarMateriaPrima()
        If ExisteMateriaPrima() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertMateriaPrima"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@NombreMateriaPrima", SqlDbType.NVarChar).Value = TxtNombreMateriaPrima.Text.Trim
                        .Parameters.Add("@ExistenciaMinima", SqlDbType.Int).Value = TxtExistenciaMinima.Text.Trim
                        .Parameters.Add("@Existencia", SqlDbType.Int).Value = 0
                        .Parameters.Add("@PrecioCostoM", SqlDbType.Money).Value = TxtPrecio.Text.Trim
                        .Parameters.Add("@Fecha", SqlDbType.Date).Value = TxtFecha.Value
                        .Parameters.Add("@UnidadMedida", SqlDbType.Int).Value = CboUnidadMedida.SelectedValue
                        .Parameters.Add("@RtnProveedor", SqlDbType.NVarChar).Value = TxtRtnProveedor.Text.Trim
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de Materia Prima ha sido agregado", "MamiManda", MessageBoxButtons.OK)
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try

        End If
    End Sub

    Private Sub ActualizarMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdMateriPrima", SqlDbType.Int).Value = TxtIdMateriaPrima.Text.Trim
                    .Parameters.Add("@NombreMateriaPrima", SqlDbType.NVarChar).Value = TxtNombreMateriaPrima.Text.Trim
                    .Parameters.Add("@ExistenciaMinima", SqlDbType.Int).Value = TxtExistenciaMinima.Text.Trim
                    .Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia
                    .Parameters.Add("@PrecioCostoM", SqlDbType.Money).Value = TxtPrecio.Text.Trim
                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = TxtFecha.Value
                    .Parameters.Add("@UnidadMedida", SqlDbType.Int).Value = CboUnidadMedida.SelectedValue
                    .Parameters.Add("@RtnProveedor", SqlDbType.NVarChar).Value = TxtRtnProveedor.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de materia prima ha sido actualizado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave duplicada") Then
                MessageBox.Show("Ya se encuentra registrado esta materia prima", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox(ex.Message)
            End If

        Finally
            cnn.Close()
        End Try
    End Sub

    Private Function ExisteMateriaPrima() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdMateriaPrima", SqlDbType.Int, 40).Value = TxtIdMateriaPrima.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrada esta materia prima", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function


    Private Sub HabilitarBotones(ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        HabilitarTextBox(valor)
    End Sub

    Private Sub HabilitarTextBox(ByVal valor As Boolean)
        TxtIdMateriaPrima.Enabled = False
        TxtNombreMateriaPrima.Enabled = valor
        TxtExistenciaMinima.Enabled = valor
        TxtPrecio.Enabled = valor
        CboUnidadMedida.Enabled = valor
        btnProveedor.Enabled = valor

    End Sub

    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            MessageBox.Show(Mensaje, "MamiManda", MessageBoxButtons.OK)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function

    Private Sub FrmMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxUnidadMedida()
        HabilitarBotones(True, True, True)
        CboUnidadMedida.Text = Nothing
        If ModoEdicion Then
            Call CargarDatosMateriaPrima()
        Else
            Call InvestigarCorrelativo()
        End If
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "MateriaPrima")
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        Dim BuscarProveedor As New FrmBuscarProveedor
        BuscarProveedor.DesdeMateriaPrima = True
        BuscarProveedor.Show(Me)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(TxtNombreMateriaPrima, "Debe ingresar un nombre de materia prima") Then
        ElseIf Validar(TxtExistenciaMinima, "Debe ingresar la existencia minima") Then
        ElseIf Validar(TxtPrecio, "Debe ingresar el precio") Then
        ElseIf Validar(CboUnidadMedida, "Debe seleccionar la unidad de medidan") Then
        ElseIf Validar(TxtRtnProveedor, "Debe seleccionar el rtn del proveedor") Then
        Else
            If ModoEdicion Then
                Call ActualizarMateriaPrima()
            Else
                Call AgregarMateriaPrima()
            End If

            HabilitarBotones(False, False, False)
            Limpiar()
            FrmMateriasPrimas.ActualizarTablas(True)
            Me.Close()
        End If
    End Sub

    Private Sub Limpiar()
        TxtIdMateriaPrima.Text = Nothing
        TxtNombreMateriaPrima.Text = Nothing
        TxtExistenciaMinima.Text = Nothing
        TxtPrecio.Text = Nothing
        CboUnidadMedida.SelectedIndex = -1
        TxtRtnProveedor.Text = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(False, False, False)
        Limpiar()
        Me.Close()
    End Sub

    Private Function txtNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub TxtExistenciaMinima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtExistenciaMinima.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        e.Handled = txtNumerico(TxtPrecio, e.KeyChar, True)
    End Sub
End Class