Imports System.Data.SqlClient

Public Class FrmMateriaPrima
    Dim existencia As Integer

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativo()
    End Sub

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
                        .Parameters.Add("@Fecha", SqlDbType.Date).Value = TxtFecha.Text.Trim
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

    Private Sub ActualizarEmpleado()
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
                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = TxtFecha.Text.Trim
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


    Private Sub MostrarMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerMateriaPrima As SqlDataReader
                VerMateriaPrima = cmd.ExecuteReader()
                LsvMostrarMateriaPrima.Items.Clear()
                While VerMateriaPrima.Read = True
                    With Me.LsvMostrarMateriaPrima.Items.Add(VerMateriaPrima("IdMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("NombreMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("ExistenciaMinima").ToString)
                        .SubItems.Add(VerMateriaPrima("Existencia").ToString)
                        .SubItems.Add(VerMateriaPrima("Fecha").ToString)
                        .SubItems.Add(VerMateriaPrima("Medida").ToString)
                        .SubItems.Add(VerMateriaPrima("Nombre").ToString)
                        .SubItems.Add(VerMateriaPrima("RtnProveedor").ToString)
                        .SubItems.Add(VerMateriaPrima("PrecioCostoM").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ListarMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerMateriaPrima As SqlDataReader
                VerMateriaPrima = cmd.ExecuteReader()
                LsvMostrarMateriaPrima.Items.Clear()
                While VerMateriaPrima.Read = True
                    With Me.LsvMostrarMateriaPrima.Items.Add(VerMateriaPrima("IdMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("NombreMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("ExistenciaMinima").ToString)
                        .SubItems.Add(VerMateriaPrima("Existencia").ToString)
                        .SubItems.Add(VerMateriaPrima("Fecha").ToString)
                        .SubItems.Add(VerMateriaPrima("Medida").ToString)
                        .SubItems.Add(VerMateriaPrima("Nombre").ToString)
                        .SubItems.Add(VerMateriaPrima("RtnProveedor").ToString)
                        .SubItems.Add(VerMateriaPrima("PrecioCostoM").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal actualizar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnInsertar.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnActualizar.Enabled = actualizar
        btnCancelar.Enabled = cancelar
        HabilitarTextBox(valor)
    End Sub

    Private Sub HabilitarTextBox(ByVal valor As Boolean)
        TxtIdMateriaPrima.Enabled = False
        TxtNombreMateriaPrima.Enabled = valor
        TxtExistenciaMinima.Enabled = valor
        TxtPrecio.Enabled = valor
        TxtFecha.Enabled = valor
        CboUnidadMedida.Enabled = valor
        TxtRtnProveedor.Enabled = valor
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
        MostrarMateriaPrima()
        HabilitarBotones(True, False, False, False, False)
        CboUnidadMedida.Text = Nothing
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        FrmBuscarProveedor.ShowDialog()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(TxtNombreMateriaPrima, "Debe ingresar un nombre de materia prima") Then
        ElseIf Validar(TxtPrecio, "Debe ingresar el precio") Then
        ElseIf Validar(TxtFecha, "Debe ingresar ula fecha") Then
        ElseIf Validar(CboUnidadMedida, "Debe seleccionar la unidad de medidan") Then
        ElseIf Validar(TxtRtnProveedor, "Debe seleccionar el rtn del proveedor") Then
        Else
            AgregarMateriaPrima()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarMateriaPrima()
        End If
    End Sub

    Private Sub Limpiar()
        TxtIdMateriaPrima.Text = Nothing
        TxtNombreMateriaPrima.Text = Nothing
        TxtExistenciaMinima.Text = Nothing
        TxtPrecio.Text = Nothing
        TxtFecha.Text = Nothing
        CboUnidadMedida.SelectedIndex = -1
        TxtRtnProveedor.Text = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Validar(TxtNombreMateriaPrima, "Debe ingresar un nombre de materia prima") Then
        ElseIf Validar(TxtPrecio, "Debe ingresar el precio") Then
        ElseIf Validar(TxtFecha, "Debe ingresar ula fecha") Then
        ElseIf Validar(CboUnidadMedida, "Debe seleccionar la unidad de medidan") Then
        ElseIf Validar(TxtRtnProveedor, "Debe seleccionar el rtn del proveedor") Then
        Else
            ActualizarEmpleado()
            HabilitarBotones(True, False, False, False, False)
            MostrarMateriaPrima()
            Limpiar()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        btnEditar.Enabled = False
        ListarMateriaPrima()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        TxtIdMateriaPrima.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(0).Text
        TxtNombreMateriaPrima.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(1).Text
        TxtExistenciaMinima.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(2).Text
        existencia = LsvMostrarMateriaPrima.FocusedItem.SubItems(3).Text
        TxtFecha.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(4).Text
        CboUnidadMedida.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(5).Text
        TxtRtnProveedor.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(7).Text
        TxtPrecio.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(8).Text
        HabilitarBotones(False, False, True, True, True)

        TabControl1.SelectedIndex = 0
        btnEditar.Enabled = False
        txtBuscar.Text = ""
    End Sub

    Private Sub LsvMostrarMateriaPrima_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvMostrarMateriaPrima.SelectedIndexChanged
        btnEditar.Enabled = True
    End Sub

End Class