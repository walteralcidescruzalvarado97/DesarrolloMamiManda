Imports System.Data.SqlClient
Public Class FrmPresentacionProducto
    Private Sub FrmPresentacionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        LlenarComboboxTipoPresentacion()
        Limpiar()
        MostrarPresentacion()
    End Sub

#Region "Funciones"
    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal actualizar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnInsertar.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnActualizar.Enabled = actualizar
        btnCancelar.Enabled = cancelar
        HabilitarTexbox(valor)
    End Sub

    Private Sub HabilitarTexbox(ByVal valor As Boolean)
        cboPresentacion.Enabled = valor
        txtPreMayorista.Enabled = valor
        txtPreDetalle.Enabled = valor
        txtPreCosto.Enabled = valor
        btnInventario.Enabled = valor
    End Sub

    Private Sub Limpiar()
        txtCodPresentacion.Text = Nothing
        txtCodInventario.Text = Nothing
        txtNombre.Text = Nothing
        txtPreMayorista.Text = Nothing
        txtPreDetalle.Text = Nothing
        txtPreCosto.Text = Nothing
        cboPresentacion.SelectedIndex = -1
    End Sub

    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function
#End Region

#Region "Llenar"
    Private Sub InvestigarCorrelativo()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarPresentacion As New SqlCommand("Sp_MostrarCodPresentacionIdentity", cnn)
            ListarPresentacion.CommandType = CommandType.StoredProcedure
            Dim ListarPresentaciones As SqlDataReader
            cnn.Open()
            ListarPresentaciones = ListarPresentacion.ExecuteReader
            If ListarPresentaciones.Read = True Then
                If ListarPresentaciones("Id") Is DBNull.Value Then
                    txtCodPresentacion.Text = 1
                Else
                    txtCodPresentacion.Text = ListarPresentaciones("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboboxTipoPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboTipoPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoPresentacion")
                Me.cboPresentacion.DataSource = ds.Tables(0)
                Me.cboPresentacion.DisplayMember = ds.Tables(0).Columns("TipoPresentacion").ToString
                Me.cboPresentacion.ValueMember = ds.Tables(0).Columns("IdTipoPresentacio").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub MostrarPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarPresentacionProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdPresentacionProducto").ToString)
                        .SubItems.Add(VerEmpleado("NombreProducto").ToString)
                        .SubItems.Add(VerEmpleado("TipoPresentacion").ToString)
                        .SubItems.Add(VerEmpleado("PrecioMayorista").ToString)
                        .SubItems.Add(VerEmpleado("PrecioDetalle").ToString)
                        .SubItems.Add(VerEmpleado("PrecioCosto").ToString)
                        .SubItems.Add(VerEmpleado("IdInventario").ToString)
                        .SubItems.Add(VerEmpleado("IdTipoPresentacio").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub ListarPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarPresentacionProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdPresentacionProducto").ToString)
                        .SubItems.Add(VerEmpleado("NombreProducto").ToString)
                        .SubItems.Add(VerEmpleado("TipoPresentacion").ToString)
                        .SubItems.Add(VerEmpleado("PrecioMayorista").ToString)
                        .SubItems.Add(VerEmpleado("PrecioDetalle").ToString)
                        .SubItems.Add(VerEmpleado("PrecioCosto").ToString)
                        .SubItems.Add(VerEmpleado("IdInventario").ToString)
                        .SubItems.Add(VerEmpleado("IdTipoPresentacio").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
#End Region

#Region "SCRUD"
    Private Sub AgregarPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@PrecioMayorista", SqlDbType.Money).Value = txtPreMayorista.Text.Trim
                    .Parameters.Add("@PrecioDetalle", SqlDbType.Money).Value = txtPreDetalle.Text.Trim
                    .Parameters.Add("@PrecioCosto", SqlDbType.Money).Value = txtPreCosto.Text.Trim
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodInventario.Text.Trim
                    .Parameters.Add("@IdTipoPresentacio", SqlDbType.Int).Value = cboPresentacion.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = FrmPrincipal.LblId.Text
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de presentación ha sido guardado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ActualizarPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdPresentacionProducto", SqlDbType.Int).Value = txtCodPresentacion.Text.Trim
                    .Parameters.Add("@PrecioMayorista", SqlDbType.Money).Value = txtPreMayorista.Text.Trim
                    .Parameters.Add("@PrecioDetalle", SqlDbType.Money).Value = txtPreDetalle.Text.Trim
                    .Parameters.Add("@PrecioCosto", SqlDbType.Money).Value = txtPreCosto.Text.Trim
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodInventario.Text.Trim
                    .Parameters.Add("@IdTipoPresentacio", SqlDbType.Int).Value = cboPresentacion.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = FrmPrincipal.LblId.Text
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de presentación ha sido actualizado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
#End Region


    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativo()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Validar(txtCodInventario, "Debe ingresar un código de producto") Then
        ElseIf Validar(cboPresentacion, "Debe seleccionar un tipo de presentación") Then
        ElseIf Validar(txtPreMayorista, "Debe ingresar el precio para mayorista") Then
        ElseIf Validar(txtPreDetalle, "Debe ingresar el precio al detalle") Then
        ElseIf Validar(txtPreCosto, "Debe ingresar el precio de costo") Then
        Else
            ActualizarPresentacion()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarPresentacion()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtCodInventario, "Debe ingresar un código de producto") Then
        ElseIf Validar(cboPresentacion, "Debe seleccionar un tipo de presentación") Then
        ElseIf Validar(txtPreMayorista, "Debe ingresar el precio para mayorista") Then
        ElseIf Validar(txtPreDetalle, "Debe ingresar el precio al detalle") Then
        ElseIf Validar(txtPreCosto, "Debe ingresar el precio de costo") Then
        Else
            AgregarPresentacion()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarPresentacion()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        FrmBuscarInventario.ShowDialog()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ListarPresentacion()
        btnEditar.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtCodPresentacion.Text = lsvMostrar.FocusedItem.SubItems(0).Text
        txtNombre.Text = lsvMostrar.FocusedItem.SubItems(1).Text
        txtCodInventario.Text = lsvMostrar.FocusedItem.SubItems(6).Text
        cboPresentacion.SelectedValue = lsvMostrar.FocusedItem.SubItems(7).Text
        txtPreMayorista.Text = lsvMostrar.FocusedItem.SubItems(3).Text
        txtPreDetalle.Text = lsvMostrar.FocusedItem.SubItems(4).Text
        txtPreCosto.Text = lsvMostrar.FocusedItem.SubItems(5).Text
        HabilitarBotones(False, False, True, True, True)

        TabControl1.SelectedIndex = 0
        btnEditar.Enabled = False
        txtBuscar.Text = ""
    End Sub

    Private Sub lsvMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMostrar.SelectedIndexChanged
        btnEditar.Enabled = True
    End Sub
End Class