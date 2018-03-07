Imports System.Data.SqlClient
Public Class FrmPresentacionProducto
    Implements IForm
    Implements IForm2
    Friend Property ModoEdicion As Boolean = False
    Friend Property Codigo
    Public Sub ObtenerCuenta(cuenta As String) Implements IForm.ObtenerDato
        txtCodInventario.Text = cuenta
    End Sub

    Public Sub ObtenerNombre(Nombre As String) Implements IForm2.ObtenerNombre
        txtNombre.Text = Nombre
    End Sub

    Private Sub FrmPresentacionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, True, True)
        LlenarComboboxTipoPresentacion()
        Limpiar()

        If ModoEdicion Then
            Call CargarDatosPresentacion()
        End If

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Presentacion")
    End Sub

#Region "Funciones"
    Private Sub HabilitarBotones(ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnGuardar.Enabled = guardar
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
            ErrorProvider1.SetError(Control, "")
            Validar = False
        End If
    End Function
#End Region

#Region "Llenar"

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

   
 
#End Region

#Region "SCRUD"

    Private Sub CargarDatosPresentacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            cnn.Open()
            Try
                With cmd
                    .CommandText = "Sp_CargarDatosPresentacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.Int).Value = Codigo
                End With

                Dim lector As SqlDataReader = cmd.ExecuteReader

                While lector.Read
                    txtCodInventario.Text = lector("IdInventario").ToString
                    txtNombre.Text = lector("NombreProducto").ToString
                    cboPresentacion.SelectedValue = lector("IdTipoPresentacio").ToString
                    txtPreMayorista.Text = lector("PrecioMayorista").ToString
                    txtPreDetalle.Text = lector("PrecioDetalle").ToString
                    txtPreCosto.Text = lector("PrecioCosto").ToString
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

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
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = UsuarioActivo.IdUsuario
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
                    .Parameters.Add("@PrecioMayorista", SqlDbType.Money).Value = txtPreMayorista.Text.Trim
                    .Parameters.Add("@PrecioDetalle", SqlDbType.Money).Value = txtPreDetalle.Text.Trim
                    .Parameters.Add("@PrecioCosto", SqlDbType.Money).Value = txtPreCosto.Text.Trim
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodInventario.Text.Trim
                    .Parameters.Add("@IdTipoPresentacio", SqlDbType.Int).Value = cboPresentacion.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = UsuarioActivo.IdUsuario
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



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtCodInventario, "Debe ingresar un código de producto") Then
        ElseIf Validar(cboPresentacion, "Debe seleccionar un tipo de presentación") Then
        ElseIf Validar(txtPreMayorista, "Debe ingresar el precio para mayorista") Then
        ElseIf Validar(txtPreDetalle, "Debe ingresar el precio al detalle") Then
        ElseIf Validar(txtPreCosto, "Debe ingresar el precio de costo") Then
        Else
            If ModoEdicion Then
                Call ActualizarPresentacion()
            Else
                AgregarPresentacion()
            End If
            HabilitarBotones(False, False, False)
            Limpiar()
            FrmPresentacion.ActualizarTablas(True)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(False, False, False)
        Limpiar()
        Me.Close()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim BuscarInventario As New FrmBuscarInventario
        BuscarInventario.DesdePresentacion = True
        BuscarInventario.Show(Me)
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

    Private Sub txtPreMayorista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreMayorista.KeyPress
        e.Handled = txtNumerico(txtPreMayorista, e.KeyChar, True)
    End Sub

    Private Sub txtPreDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreDetalle.KeyPress
        e.Handled = txtNumerico(txtPreDetalle, e.KeyChar, True)
    End Sub

    Private Sub txtPreCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreCosto.KeyPress
        e.Handled = txtNumerico(txtPreCosto, e.KeyChar, True)
    End Sub

    
End Class