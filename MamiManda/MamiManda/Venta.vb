Imports System.Data.SqlClient
Imports MamiManda
Imports DevExpress.XtraReports.UI
Public Class Venta
    Friend Property Existencia As Integer = 0
    Friend Property NombreProducto As String = ""
    Friend Property CodPresentacion As Integer = 0
    Dim registro As Integer = 0

    Friend Property _Dias As Integer = 0

    Private Property Cai As String = ""
    Private Property FechaInicio As Date
    Private Property FechaFinal As Date
    Private Property CorrelativoDesde As String = ""
    Private Property CorrelativoHasta As String = ""
    Friend Property ModoConsulta As Boolean = False
    Friend Property CodFacturaGuardada As String = ""

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InvestigarCai()
        HabilitarBotones(True, False, False, False)
        Limpiar()
        LlenarComboTipoPago()
        CboTipoPago.SelectedIndex = -1
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Ventas")
        btnNuevo.Focus()
        RdbNo.Checked = True
        If ModoConsulta Then
            Call CargarFacturaGuardada()
            Call CargarDetalleFacturaGuardada()
            Call BloquearControles()
        End If
    End Sub

#Region "Funciones"

    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnNuevo.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        HabilitarTexbox(valor)
    End Sub

    Private Sub HabilitarTexbox(ByVal valor As Boolean)
        btnBuscarCliente.Enabled = valor
        dtpFecha.Enabled = valor
        txtCantidad.Enabled = valor
        txtPrecio.Enabled = valor
        btnBuscarProducto.Enabled = valor
        btnAgregar.Enabled = valor
        CboTipoPago.Enabled = valor
        NuDiasPlazo.Enabled = valor
        TxtFechaVence.Enabled = valor
        TxtNombreCliente.Enabled = valor
        RdbSi.Enabled = valor
        RdbNo.Enabled = valor
        TxtDes.Enabled = valor
    End Sub


    Private Sub BloquearControles()
        btnNuevo.Visible = False
        btnGuardar.Visible = False
        btnCancelar.Visible = False
        Me.lsvMostrar.Enabled = False
        LblNuevo.Visible = False
        LblGuardar.Visible = False
        LblCancelar.Visible = False
        BtnImprimir.Visible = True
    End Sub
    Private Sub Limpiar()
        txtCodFactura.Text = Nothing
        txtCliente.Text = Nothing
        txtSubTotal.Text = Nothing
        txtIsv.Text = Nothing
        txtTotal.Text = Nothing
        lsvMostrar.Items.Clear()
        CboTipoPago.SelectedIndex = -1
        TxtFechaVence.Text = Nothing
        NuDiasPlazo.Value = Nothing
        TxtNombreCliente.Text = Nothing
        TxtDes.Text = Nothing
        TxtDescuento.Text = Nothing
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
        NuevoIdFactura()
        btnBuscarCliente.Focus()
        CboTipoPago.SelectedIndex = 0
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Validar(txtCliente, "Debe ingresar el código del cliente") Then
        Else
            If lsvMostrar.Items.Count <= 0 Then
                MessageBox.Show("No se han ingresado productos a facturar", "BakerySystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            HabilitarBotones(True, False, False, False)
            AgregarFactura()
            AgregarDetalle()
            If MessageBox.Show("¿Desea imprimir la factura?", "BakerySystem", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ImprimirFactura()
            End If
            Limpiar()
            LimpiarArticulos()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False)
        SumarProducto()
        estado = True
        Limpiar()
        LimpiarArticulos()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        _Dias = 0
        Dim BuscarCliente As New FrmBuscarCliente
        BuscarCliente.DesdeFactura = True
        BuscarCliente.Show(Me)
        btnBuscarProducto.Focus()
        BuscarCliente.Focus()
    End Sub

    'Public Sub ObtenerCodCliente(Codigo As String) Implements ICliente.ObtenerCodCliente
    '    txtCliente.Text = Codigo
    'End Sub

    'Public Sub ObtenerNombreCliente(Nombre As String) Implements ICliente.ObtenerNombreCliente
    '    TxtNombreCliente.Text = Nombre
    'End Sub

    'Public Sub ObtenerDiasPlazoCLiente(DiasPlazo As Integer) Implements ICliente.ObtenerDiasPlazoCliente
    '    NuDiasPlazo.Value = DiasPlazo
    '    _Dias = DiasPlazo
    'End Sub
#End Region

#Region "Llenar"

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

    Private Sub InvestigarCai()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InvestigarCai"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                Dim reader As SqlDataReader = cmd.ExecuteReader

                If reader.Read Then
                    Cai = reader("Cai").ToString
                    FechaInicio = reader("FechaInicio").ToString
                    FechaFinal = reader("FechaFinal").ToString
                    CorrelativoDesde = reader("CorrelativoDesde").ToString
                    CorrelativoHasta = reader("CorrelativoHasta").ToString
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NuevoIdFactura()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InvestigarNumFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Cai", SqlDbType.NVarChar).Value = Cai
                End With

                Dim reader As SqlDataReader = cmd.ExecuteReader
                If reader.Read Then
                    If reader("IdFactura") Is DBNull.Value Then
                        txtCodFactura.Text = CorrelativoDesde
                    Else
                        Dim IdUltimaFactura As String = reader("IdFactura").ToString
                        Dim IdUltimaFactura2 As String() = IdUltimaFactura.Split("-")
                        Dim Correlativo As String = IdUltimaFactura2(3) + 1
                        Dim NumFactura As String = ""
                        Dim caracter As String = ""
                        Dim Ultimo As String = CorrelativoHasta
                        Dim Ultimo2 As String() = Ultimo.Split("-")

                        For num As Integer = 1 To (8 - Correlativo.Length)
                            caracter = caracter & 0
                        Next
                        If Now.Date <> FechaFinal Then
                            If (Integer.Parse(Ultimo2(3)) - Correlativo) <= 10 Then
                                MessageBox.Show("Solo quedan" & " " & Integer.Parse(Ultimo2(3)) - Correlativo & " " & "correlativos disponibles, Por favor revise su configuración SAR", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ElseIf Correlativo > Integer.Parse(Ultimo2(3)) Then
                                MessageBox.Show("Ya no hay Correlativos disponibles, Por favor registre una nueva configuración del SAR", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                HabilitarBotones(True, False, False, False)
                                Limpiar()
                                LimpiarArticulos()
                                Return
                            End If
                            'NumFactura = "001-001-01-" & caracter & Correlativo
                            NumFactura = IdUltimaFactura2(0).ToString & "-" & IdUltimaFactura2(1).ToString & "-" & IdUltimaFactura2(2).ToString & "-" & caracter & Correlativo
                            txtCodFactura.Text = NumFactura
                        Else
                            MessageBox.Show("Ha llegado a su fecha límite de Emisión, Por favor relalice una nueva configuracón SAR", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            HabilitarBotones(True, False, False, False)
                            Limpiar()
                            LimpiarArticulos()
                            Return
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub CargarFacturaGuardada()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_DatosFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@CodFactura", SqlDbType.nvarchar).Value = CodFacturaGuardada
                End With

                Dim lector As SqlDataReader
                lector = cmd.ExecuteReader

                While lector.Read
                    txtCodFactura.Text = lector.Item("IdFactura").ToString
                    dtpFecha.Value = lector.Item("Fecha").ToString
                    txtCliente.Text = lector.Item("RTNCliente").ToString
                    TxtNombreCliente.Text = lector.Item("Cliente").ToString
                    NuDiasPlazo.Value = lector.Item("DiasPlazo").ToString

                    Dim FechaVence As String = lector.Item("FechaVence").ToString
                    Dim FechaVence1 As String() = FechaVence.Split(" ")

                    TxtFechaVence.Text = FechaVence1(0).ToString
                    CboTipoPago.SelectedValue = CInt(lector("IdTipoPago").ToString)
                    TxtDescuento.Text = CDbl(lector("Descuento").ToString)
                End While

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CargarDetalleFacturaGuardada()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CargarDetalleFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@CodFactura", SqlDbType.NVarChar).Value = CodFacturaGuardada
                End With

                Dim lector As SqlDataReader
                lector = cmd.ExecuteReader
                Me.lsvMostrar.Items.Clear()

                While lector.Read
                    With Me.lsvMostrar.Items.Add(lector("IdInventario").ToString)
                        .SubItems.Add(lector("NombreProducto").ToString)
                        .SubItems.Add(lector("TipoPresentacion").ToString)
                        .SubItems.Add(FormatCurrency(lector("Precio").ToString))
                        .SubItems.Add(lector("Cantidad").ToString)
                        .SubItems.Add(FormatCurrency(lector("Total").ToString))
                    End With
                End While
            End Using
            Call Calculos()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub


    Sub LlenarComboTipoPago()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.CommandText = "Select IdTipoPago, TipoPago From TipoPago Order By IdTipoPago"
                cmd.CommandType = CommandType.Text
                cmd.Connection = cnn

                Dim Da As New SqlDataAdapter(cmd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "TipoPago")
                Me.CboTipoPago.DataSource = Ds.Tables(0)
                Me.CboTipoPago.DisplayMember = Ds.Tables(0).Columns("TipoPago").ToString
                Me.CboTipoPago.ValueMember = Ds.Tables(0).Columns("IdTIpoPago").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
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
                    .CommandText = "Sp_RestarProductoPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Cantidad", SqlDbType.Int).Value = txtCantidad.Text.Trim
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodProducto.Text.Trim
                    .Parameters.Add("@IdTipoPresentacion", SqlDbType.Int).Value = CodPresentacion
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
                        .CommandText = "Sp_SumarProductoPresentacion"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@Cantidad", SqlDbType.Int).Value = lsvMostrar.Items(i).SubItems(4).Text
                        .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = lsvMostrar.Items(i).SubItems(0).Text
                        .Parameters.Add("@IdTipoPresentacion", SqlDbType.Int).Value = lsvMostrar.Items(i).SubItems(6).Text
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

    Private Sub QuitarProducto()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_SumarProductoPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Cantidad", SqlDbType.Int).Value = lsvMostrar.FocusedItem.SubItems(4).Text
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = lsvMostrar.FocusedItem.SubItems(0).Text
                    .Parameters.Add("@IdTipoPresentacion", SqlDbType.Int).Value = lsvMostrar.FocusedItem.SubItems(6).Text
                    .ExecuteNonQuery()
                End With
            End Using
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
                        .Parameters.Add("@IdFactura", SqlDbType.NVarChar).Value = txtCodFactura.Text.Trim
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
                    .Parameters.Add("@IdFactura", SqlDbType.NVarChar).Value = txtCodFactura.Text.Trim
                    .Parameters.Add("@Fecha", SqlDbType.Date).Value = dtpFecha.Value
                    .Parameters.Add("@RTNCliente", SqlDbType.NVarChar).Value = txtCliente.Text
                    If CboTipoPago.SelectedIndex = 1 Then
                        .Parameters.Add("DiasPlazo", SqlDbType.Int).Value = 0
                        .Parameters.Add("FechaVence", SqlDbType.Date).Value = Now.Date.AddDays(1)
                        .Parameters.Add("EstadoFactura", SqlDbType.Int).Value = 2
                    Else
                        .Parameters.Add("DiasPlazo", SqlDbType.Int).Value = NuDiasPlazo.Value
                        .Parameters.Add("FechaVence", SqlDbType.Date).Value = TxtFechaVence.Text
                        .Parameters.Add("EstadoFactura", SqlDbType.Int).Value = 1
                    End If
                    .Parameters.Add("TipoPago", SqlDbType.Int).Value = CboTipoPago.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = UsuarioActivo.IdUsuario
                    .Parameters.Add("@Cai", SqlDbType.NVarChar).Value = Cai
                    .Parameters.Add("@Descuento", SqlDbType.Money).Value = TxtDescuento.Text
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
        BuscarProducto.DesdeFactura = True
        BuscarProducto.Show(Me)
        txtCantidad.Focus()
        BuscarProducto.Focus()
    End Sub

    'Public Sub ObtenerCodProducto(Codigo As String) Implements IPresentacion.ObtenerCodProducto
    '    txtCodProducto.Text = Codigo
    'End Sub

    'Public Sub ObtenerPresentacion(Presentacion As String) Implements IPresentacion.ObtenerPresentacion
    '    txtPresentacion.Text = Presentacion
    'End Sub

    'Public Sub ObtenerCodPresentacion(CodPresentacion As String) Implements IPresentacion.ObtenerCodPresentacion
    '    lblCodPresentacion.Text = CodPresentacion
    'End Sub

    'Public Sub ObtenerPrecio(Precio As String) Implements IPresentacion.ObtenerPrecio
    '    txtPrecio.Text = Precio
    'End Sub

    'Public Sub ObtenerUnidades(Unidades As String) Implements IPresentacion.ObtenerUnidades
    '    txtUnidad.Text = Unidades
    'End Sub

    'Public Sub ObtenerNombre(Nombre As String) Implements IPresentacion.ObtenerNombreProducto
    '    lblNombreProducto.Text = Nombre
    'End Sub

    'Public Sub ObtenerExistencia(Valor As String) Implements IPresentacion.ObtenerExistencia
    '    Existencia = Valor
    'End Sub

    Private Sub Calculos()
        Dim Subtotal As Decimal = 0
        Dim Isv As Decimal
        'Dim Descuento As Decimal = CDec(TxtDescuento.Text)
        Dim Total As Decimal
        For i As Integer = 0 To lsvMostrar.Items.Count - 1
            Subtotal = Subtotal + lsvMostrar.Items(i).SubItems(5).Text
        Next

        Isv = Subtotal * 0.15
        Total = Subtotal + Isv - TxtDescuento.Text
        txtSubTotal.Text = FormatCurrency(Subtotal, 2)
        txtIsv.Text = FormatCurrency(Isv, 2)
        TxtDescuento.Text = FormatCurrency(TxtDescuento.Text, 2)
        txtTotal.Text = FormatCurrency(Total, 2)

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Validar(txtCodProducto, "Debe seleccionar un producto") Then
        ElseIf Validar(txtPresentacion, "Debe seleccionar un producto") Then
        ElseIf Validar(txtPrecio, "Debe ingresar el precio") Then
        ElseIf Validar(txtCantidad, "Debe ingresar la cantidad de productos a comprar") Then
        Else
            If RdbSi.Checked And TxtDes.Text = 0 Then
                MessageBox.Show("El descuento debe ser mayora 0", "BakerySystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If txtCantidad.Text > Existencia Then
                MessageBox.Show("No hay suficientes productos", "BakerySystem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Try

                    Dim existe As Integer = 0
                    Dim cantidad As Integer = 0
                    Dim total As Decimal = 0

                    If lsvMostrar.Items.Count = 0 Then

                        total = txtCantidad.Text * txtPrecio.Text
                        With Me.lsvMostrar.Items.Add(txtCodProducto.Text)
                            .SubItems.Add(NombreProducto)
                            .SubItems.Add(txtPresentacion.Text)
                            .SubItems.Add(FormatCurrency(txtPrecio.Text))
                            .SubItems.Add(txtCantidad.Text)
                            .SubItems.Add(FormatCurrency(total.ToString))
                            .SubItems.Add(CodPresentacion)
                            .SubItems.Add(txtUnidad.Text)
                            TxtDescuento.Text = TxtDes.Text
                        End With

                    Else

                        For i As Integer = 0 To lsvMostrar.Items.Count - 1
                            If lsvMostrar.Items(i).SubItems(0).Text = txtCodProducto.Text And lsvMostrar.Items(i).SubItems(6).Text = CodPresentacion Then
                                cantidad = lsvMostrar.Items(i).SubItems(4).Text
                                lsvMostrar.Items(i).SubItems(4).Text = cantidad + txtCantidad.Text
                                lsvMostrar.Items(i).SubItems(5).Text = lsvMostrar.Items(i).SubItems(4).Text * lsvMostrar.Items(i).SubItems(3).Text
                                TxtDescuento.Text = TxtDes.Text
                                existe = 1
                            End If
                        Next

                        If existe = 0 Then
                            total = total + txtCantidad.Text * txtPrecio.Text
                            With Me.lsvMostrar.Items.Add(txtCodProducto.Text)
                                .SubItems.Add(NombreProducto)
                                .SubItems.Add(txtPresentacion.Text)
                                .SubItems.Add(FormatCurrency(txtPrecio.Text))
                                .SubItems.Add(txtCantidad.Text)
                                .SubItems.Add(FormatCurrency(total.ToString))
                                .SubItems.Add(CodPresentacion)
                                .SubItems.Add(txtUnidad.Text)
                                TxtDescuento.Text = TxtDes.Text
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
                btnBuscarProducto.Focus()
            End If

        End If

    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub cboTipoFactura_SelectedIndexChanged(sender As Object, e As EventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCodProducto.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtPresentacion_TextChanged(sender As Object, e As EventArgs) Handles txtPresentacion.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtUnidad_TextChanged(sender As Object, e As EventArgs) Handles txtUnidad.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.Handled = txtNumerico(txtPrecio, e.KeyChar, True)
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

    Private Sub CboTipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoPago.SelectedIndexChanged
        Dim index As Integer = CboTipoPago.SelectedIndex

        If index = 1 Then
            Me.LblDias.Visible = False
            Me.LblFechaVence.Visible = False
            NuDiasPlazo.Visible = False
            TxtFechaVence.Visible = False
        Else
            Me.LblDias.Visible = True
            Me.LblFechaVence.Visible = True
            NuDiasPlazo.Visible = True
            TxtFechaVence.Visible = True
        End If
    End Sub
    Dim estado As Boolean = False
    Private Sub NuDiasPlazo_ValueChanged(sender As Object, e As EventArgs) Handles NuDiasPlazo.ValueChanged


        TxtFechaVence.Text = Now.Date.AddDays(NuDiasPlazo.Value)
        If _Dias <= 0 Then
            Return
        End If


        If Me.NuDiasPlazo.Value > _Dias Then
            MsgBox("No se puede exceder el número de días de plazo para este cliente")
            Me.NuDiasPlazo.Value = _Dias
            Return
        End If

        If estado = True Then
            If Me.NuDiasPlazo.Value <= 0 Then
                MsgBox("No se puede asignar dias plazo menores e iguales a cero")
                Me.NuDiasPlazo.Value = _Dias
            End If
        End If
    End Sub

    Private Sub QuitarItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarItemToolStripMenuItem.Click
        QuitarProducto()
        Me.lsvMostrar.FocusedItem.Remove()
        Calculos()
    End Sub

    Sub ImprimirFactura()
        Dim texto As New ConvertirCantidadesLetras
        Dim Text As String = texto.Letras(txtTotal.Text)
        Dim id As String = txtCodFactura.Text
        Dim total As Double = txtTotal.Text
        Dim rpt As New RptFactura(id, Text)
        Dim printTool As New ReportPrintTool(rpt)
        printTool.ShowRibbonPreview()
    End Sub
    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        ImprimirFactura()
    End Sub

    Private Sub RdbSi_CheckedChanged(sender As Object, e As EventArgs) Handles RdbSi.CheckedChanged
        LblDes.Visible = True
        TxtDes.Visible = True
        TxtDes.Enabled = True
        TxtDes.Focus()
    End Sub

    Private Sub RdbNo_CheckedChanged(sender As Object, e As EventArgs) Handles RdbNo.CheckedChanged
        LblDes.Visible = False
        TxtDes.Visible = False
        TxtDes.Text = 0
    End Sub
End Class