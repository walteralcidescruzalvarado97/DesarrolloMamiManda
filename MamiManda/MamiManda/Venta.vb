﻿Imports System.Data.SqlClient
Imports MamiManda

Public Class Venta
    Implements ICliente
    Implements IPresentacion

    Dim Existencia As Integer
    Dim registro As Integer = 0


    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False)
        LlenarComboTipoDocumento()
        LlenarComboTipoFactura()
        Limpiar()
    End Sub

#Region "Funciones"

    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnNuevo.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        HabilitarTexbox(valor)
    End Sub

    Private Sub HabilitarTexbox(ByVal valor As Boolean)
        txtCliente.Enabled = valor
        btnBuscarCliente.Enabled = valor
        cboTipoFactura.Enabled = valor
        cboEstado.Enabled = valor
        dtpFecha.Enabled = valor
        txtCantidad.Enabled = valor
        txtPrecio.Enabled = valor
        btnBuscarProducto.Enabled = valor
        btnAgregar.Enabled = valor
    End Sub

    Private Sub Limpiar()
        txtCodFactura.Text = Nothing
        txtCliente.Text = Nothing
        cboEstado.SelectedIndex = -1
        cboTipoFactura.SelectedIndex = -1
        txtSubTotal.Text = Nothing
        txtIsv.Text = Nothing
        txtTotal.Text = Nothing
        lsvMostrar.Items.Clear()
    End Sub

    Private Sub LimpiarArticulos()
        txtCodProducto.Text = Nothing
        txtPresentacion.Text = Nothing
        txtUnidad.Text = Nothing
        lblCodPresentacion.Text = Nothing
        txtCantidad.Text = Nothing
        txtPrecio.Text = Nothing
    End Sub

    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            ErrorProvider1.SetError(Control, "")
            Validar = False
        End If
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        HabilitarBotones(False, True, True, True)
        InvestigarCorrelativo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Validar(txtCliente, "Debe ingresar el código del cliente") Then
        ElseIf Validar(cboTipoFactura, "Debe seleccionar un tipo de factura") Then
        ElseIf Validar(cboEstado, "Debe seleccionar un tipo de documento") Then
        Else
            HabilitarBotones(True, False, False, False)
            AgregarFactura()
            AgregarDetalle()
            Limpiar()
            LimpiarArticulos()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False)
        SumarProducto()
        Limpiar()
        LimpiarArticulos()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim BuscarCliente As New FrmBuscarCliente
        BuscarCliente.Show(Me)
    End Sub

    Public Sub ObtenerCodCliente(Codigo As String) Implements ICliente.ObtenerCodCliente
        txtCliente.Text = Codigo
    End Sub

#End Region

#Region "Llenar"

    Private Sub LlenarComboTipoFactura()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboTipoFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoFactura")
                Me.cboTipoFactura.DataSource = ds.Tables(0)
                Me.cboTipoFactura.DisplayMember = ds.Tables(0).Columns("TipoFactura").ToString
                Me.cboTipoFactura.ValueMember = ds.Tables(0).Columns("IdTipoFactura").ToString
            End Using
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub LlenarComboTipoDocumento()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboTipoDocumento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoDocumento")
                Me.cboEstado.DataSource = ds.Tables(0)
                Me.cboEstado.DisplayMember = ds.Tables(0).Columns("TipoDocumento").ToString
                Me.cboEstado.ValueMember = ds.Tables(0).Columns("IdTipoDocumento").ToString
            End Using
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub InvestigarCorrelativo()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarFactura As New SqlCommand("Sp_MostrarIdFacturaIdentity", cnn)
            ListarFactura.CommandType = CommandType.StoredProcedure
            Dim ListarFacturas As SqlDataReader
            cnn.Open()
            ListarFacturas = ListarFactura.ExecuteReader
            If ListarFacturas.Read = True Then
                If ListarFacturas("Id") Is DBNull.Value Then
                    txtCodFactura.Text = 1
                Else
                    txtCodFactura.Text = ListarFacturas("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


#End Region

#Region "SCRUD"

    Private Sub RestarProducto()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_RestarProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodProducto.Text.Trim
                    .Parameters.Add("@Cantidad", SqlDbType.Int).Value = txtCantidad.Text.Trim
                    .Parameters.Add("@CantidadPresentacion", SqlDbType.Int).Value = txtUnidad.Text.Trim
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub SumarProducto()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            For i As Integer = 0 To lsvMostrar.Items.Count - 1
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_SumarProducto"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = lsvMostrar.Items(i).SubItems(0).Text
                        .Parameters.Add("@Cantidad", SqlDbType.Int).Value = lsvMostrar.Items(i).SubItems(4).Text
                        .Parameters.Add("@CantidadPresentacion", SqlDbType.Int).Value = lsvMostrar.Items(i).SubItems(7).Text
                        .ExecuteNonQuery()
                    End With
                End Using
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub AgregarDetalle()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            For i As Integer = 0 To lsvMostrar.Items.Count - 1
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertDetalleFactura"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@IdFactura", SqlDbType.Int).Value = txtCodFactura.Text.Trim
                        .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = lsvMostrar.Items(i).SubItems(0).Text
                        .Parameters.Add("@IdTipoPresentacio", SqlDbType.Int).Value = lsvMostrar.Items(i).SubItems(6).Text
                        .Parameters.Add("@Cantidad", SqlDbType.Int).Value = lsvMostrar.Items(i).SubItems(4).Text
                        .Parameters.Add("@Precio", SqlDbType.Money).Value = lsvMostrar.Items(i).SubItems(3).Text
                        .ExecuteNonQuery()
                    End With
                End Using
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub AgregarFactura()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = dtpFecha.Value
                    .Parameters.Add("@IdTipoDocumento", SqlDbType.Int).Value = cboEstado.SelectedValue
                    .Parameters.Add("@RTNCliente", SqlDbType.NVarChar).Value = txtCliente.Text
                    .Parameters.Add("@IdTipoFactura", SqlDbType.Int).Value = cboTipoFactura.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = FrmPrincipal.LblId.Text
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
#End Region

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Dim BuscarProducto As New FrmBuscarPresentacion
        BuscarProducto.Show(Me)
    End Sub

    Public Sub ObtenerCodProducto(Codigo As String) Implements IPresentacion.ObtenerCodProducto
        txtCodProducto.Text = Codigo
    End Sub

    Public Sub ObtenerPresentacion(Presentacion As String) Implements IPresentacion.ObtenerPresentacion
        txtPresentacion.Text = Presentacion
    End Sub

    Public Sub ObtenerCodPresentacion(CodPresentacion As String) Implements IPresentacion.ObtenerCodPresentacion
        lblCodPresentacion.Text = CodPresentacion
    End Sub

    Public Sub ObtenerPrecio(Precio As String) Implements IPresentacion.ObtenerPrecio
        txtPrecio.Text = Precio
    End Sub

    Public Sub ObtenerUnidades(Unidades As String) Implements IPresentacion.ObtenerUnidades
        txtUnidad.Text = Unidades
    End Sub

    Public Sub ObtenerNombre(Nombre As String) Implements IPresentacion.ObtenerNombreProducto
        lblNombreProducto.Text = Nombre
    End Sub

    Public Sub ObtenerExistencia(Valor As String) Implements IPresentacion.ObtenerExistencia
        Existencia = Valor
    End Sub

    Private Sub Calculos()
        Dim Subtotal As Decimal = 0
        Dim Isv As Decimal
        Dim Total As Decimal

        For i As Integer = 0 To lsvMostrar.Items.Count - 1
            Subtotal = Subtotal + lsvMostrar.Items(i).SubItems(5).Text
        Next

        Isv = Subtotal * 0.15
        Total = Subtotal + Isv

        txtSubTotal.Text = Subtotal
        txtIsv.Text = Isv
        txtTotal.Text = Total


    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Validar(txtCodProducto, "Debe seleccionar un producto") Then
        ElseIf Validar(txtPresentacion, "Debe seleccionar un producto") Then
        ElseIf Validar(txtPrecio, "Debe ingresar el precio") Then
        ElseIf Validar(txtCantidad, "Debe ingresar la cantidad de productos a comprar") Then
        Else


            If (txtCantidad.Text * txtUnidad.Text) > Existencia Then
                MessageBox.Show("No hay suficientes productos", "BakerySystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Try

                    Dim existe As Integer = 0
                    Dim cantidad As Integer = 0
                    Dim total As Decimal = 0

                    If lsvMostrar.Items.Count = 0 Then

                        total = txtCantidad.Text * txtPrecio.Text
                        With Me.lsvMostrar.Items.Add(txtCodProducto.Text)
                            .SubItems.Add(lblNombreProducto.Text)
                            .SubItems.Add(txtPresentacion.Text)
                            .SubItems.Add(txtPrecio.Text)
                            .SubItems.Add(txtCantidad.Text)
                            .SubItems.Add(total.ToString)
                            .SubItems.Add(lblCodPresentacion.Text)
                            .SubItems.Add(txtUnidad.Text)
                        End With

                    Else

                        For i As Integer = 0 To lsvMostrar.Items.Count - 1
                            If lsvMostrar.Items(i).SubItems(0).Text = txtCodProducto.Text And lsvMostrar.Items(i).SubItems(6).Text = lblCodPresentacion.Text Then
                                cantidad = lsvMostrar.Items(i).SubItems(4).Text
                                lsvMostrar.Items(i).SubItems(4).Text = cantidad + txtCantidad.Text
                                lsvMostrar.Items(i).SubItems(5).Text = lsvMostrar.Items(i).SubItems(4).Text * lsvMostrar.Items(i).SubItems(3).Text
                                existe = 1
                            End If
                        Next

                        If existe = 0 Then
                            total = total + txtCantidad.Text * txtPrecio.Text
                            With Me.lsvMostrar.Items.Add(txtCodProducto.Text)
                                .SubItems.Add(lblNombreProducto.Text)
                                .SubItems.Add(txtPresentacion.Text)
                                .SubItems.Add(txtPrecio.Text)
                                .SubItems.Add(txtCantidad.Text)
                                .SubItems.Add(total.ToString)
                                .SubItems.Add(lblCodPresentacion.Text)
                                .SubItems.Add(txtUnidad.Text)
                            End With
                            existe = 0
                        End If
                    End If


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Calculos()
                RestarProducto()
                LimpiarArticulos()
                registro = 1
            End If

        End If
    End Sub

End Class