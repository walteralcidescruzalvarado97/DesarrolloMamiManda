Imports System.Data.SqlClient
Public Class FrmProduccion
    Implements IForm
    Implements IForm2

    Public Sub ObtenerCuenta(cuenta As String) Implements IForm.ObtenerDato
        txtCodProducto.Text = cuenta
    End Sub

    Public Sub ObtenerNombre(Nombre As String) Implements IForm2.ObtenerNombre
        txtProducto.Text = Nombre
    End Sub

    Private Sub FrmProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False)
        Limpiar()

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Produccion")
    End Sub

#Region "Funciones"
    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnInsertar.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        HabilitarTextBox(valor)
    End Sub

    Private Sub HabilitarTextBox(ByVal valor As Boolean)
        txtCodProducto.Enabled = False
        txtCantidad.Enabled = valor
        btnProducto.Enabled = valor
    End Sub

    Private Sub Limpiar()
        txtCodProducto.Text = Nothing
        txtCantidad.Text = Nothing
        txtProducto.Text = Nothing
        lsvMostrar.Items.Clear()

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

#Region "SCRUD"
    Private Sub AgregarProduccion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_AgregarProduccion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodProducto.Text.Trim
                    .Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = txtCantidad.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("Se ha agregado el producto a produccion", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave duplicada") Then
                MessageBox.Show("Ya se encuentra registrado este usuario", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox(ex.Message)
            End If

        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub RestarMateriaPrima(ByVal inventario As String, ByVal materia As Integer, ByVal cantidad As Decimal)
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_RestarMateria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = inventario
                    .Parameters.Add("@IdMateriaPrima", SqlDbType.Int).Value = materia
                    .Parameters.Add("@CantidadProduccion", SqlDbType.Decimal).Value = cantidad
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

#Region "Llenar"
    Private Sub MostrarReceta()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarReceta"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.VarChar).Value = txtCodProducto.Text.Trim
                    .Connection = cnn

                End With
                Dim VerReceta As SqlDataReader
                VerReceta = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerReceta.Read = True
                    With Me.lsvMostrar.Items.Add(VerReceta("NombreProducto").ToString)
                        .SubItems.Add(VerReceta("NombreMateriaPrima").ToString)
                        .SubItems.Add(VerReceta("IdInventario").ToString)
                        .SubItems.Add(VerReceta("IdMateriaPrima").ToString)
                        .SubItems.Add(VerReceta("ExistenciaMinima").ToString)
                        .SubItems.Add(VerReceta("Existencia").ToString)
                        .SubItems.Add(VerReceta("CantidadMateriaPrima").ToString)
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

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, True, True)
        Limpiar()
    End Sub

    Private Sub RestarMateria()
        Dim producto As String
        Dim materia As Integer
        Dim existenciaMinima As Integer
        Dim existencia As Integer
        Dim cantidadMateria As Integer
        Dim nombreMateria As String
        Dim valor As Integer = 1

        For i As Integer = 0 To lsvMostrar.Items.Count() - 1
            existenciaMinima = lsvMostrar.Items(i).SubItems(4).Text
            existencia = lsvMostrar.Items(i).SubItems(5).Text
            producto = lsvMostrar.Items(i).SubItems(2).Text
            materia = lsvMostrar.Items(i).SubItems(3).Text
            cantidadMateria = lsvMostrar.Items(i).SubItems(6).Text
            nombreMateria = lsvMostrar.Items(i).SubItems(1).Text

            If cantidadMateria * txtCantidad.Text > existencia Then
                valor = 0
                MsgBox("No hay suficiente: " + nombreMateria)
            ElseIf existencia - (cantidadMateria * txtCantidad.Text) <= existenciaMinima Then
                MsgBox("El ingrediente: " + nombreMateria + " ha llegado a su existencia mínima")
            Else
            End If
        Next

        If valor = 1 Then
            For i As Integer = 0 To lsvMostrar.Items.Count() - 1
                producto = lsvMostrar.Items(i).SubItems(2).Text
                materia = lsvMostrar.Items(i).SubItems(3).Text
                RestarMateriaPrima(producto, materia, txtCantidad.Text)
            Next

            AgregarProduccion()
            HabilitarBotones(True, False, False, False)
            Limpiar()
        End If


    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtCodProducto, "Debe ingresar un código de producto") Then
        ElseIf Validar(txtCantidad, "Debe ingresar la cantidad de unidades a producir") Then
        Else
            RestarMateria()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Dim BuscarInventario As New FrmBuscarInventario
        BuscarInventario.Show(Me)
    End Sub

    Private Sub txtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCodProducto.TextChanged
        MostrarReceta()
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
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
End Class