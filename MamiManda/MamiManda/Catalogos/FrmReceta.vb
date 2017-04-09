Imports System.Data.SqlClient
Public Class FrmReceta
    Implements IForm
    Implements IForm2
    Implements IReceta
    Dim err As Integer = 0

    Public Sub ObtenerDato(dato As String) Implements IForm.ObtenerDato
        txtCodProducto.Text = dato
    End Sub

    Public Sub ObtenerNombre(Nombre As String) Implements IForm2.ObtenerNombre
        'txtCodMateria.Text = Nombre
    End Sub

    Public Sub ObtenerCodReceta(Codigo As String) Implements IReceta.ObtenerCodReceta
        txtCodMateria.Text = Codigo
    End Sub

    Private Sub FrmReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        ListarReceta()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Dim BuscarInventario As New FrmBuscarInventario
        BuscarInventario.Show(Me)
    End Sub

    Private Sub btnMateriaPrima_Click(sender As Object, e As EventArgs) Handles btnMateriaPrima.Click
        Dim BuscarMateriaPrima As New FrmBuscarMateriaPrima
        BuscarMateriaPrima.Show(Me)
    End Sub

#Region "Funciones"
    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal actualizar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnNuevo.Enabled = insertar
        btnAgregar.Enabled = guardar
        btnEditar.Enabled = actualizar
        btnCancelar.Enabled = cancelar
        HabilitarTexbox(valor)
    End Sub

    Private Sub HabilitarTexbox(ByVal valor As Boolean)
        txtCodProducto.Enabled = False
        txtCodMateria.Enabled = valor
        txtCantidad.Enabled = valor
        btnMateriaPrima.Enabled = valor
        btnProducto.Enabled = valor
    End Sub

    Private Sub LimpiarTodo()
        txtCodProducto.Text = Nothing
        txtCodMateria.Text = Nothing
        txtCantidad.Text = Nothing
    End Sub

    Private Sub Limpiar()
        txtCodMateria.Text = Nothing
        txtCantidad.Text = Nothing
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
    Private Sub ListarReceta()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarReceta"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn

                End With
                Dim VerReceta As SqlDataReader
                VerReceta = cmd.ExecuteReader()
                lsvMostrarListar.Items.Clear()
                While VerReceta.Read = True
                    With Me.lsvMostrarListar.Items.Add(VerReceta("NombreProducto").ToString)
                        .SubItems.Add(VerReceta("NombreMateriaPrima").ToString)
                        .SubItems.Add(VerReceta("CantidadMateriaPrima").ToString)
                        .SubItems.Add(VerReceta("Medida").ToString)
                        .SubItems.Add(VerReceta("IdInventario").ToString)
                        .SubItems.Add(VerReceta("IdMateriaPrima").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

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
                        .SubItems.Add(VerReceta("CantidadMateriaPrima").ToString)
                        .SubItems.Add(VerReceta("Medida").ToString)
                        .SubItems.Add(VerReceta("IdInventario").ToString)
                        .SubItems.Add(VerReceta("IdMateriaPrima").ToString)
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
    Private Sub AgregarIngrediente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_InsertReceta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodProducto.Text.Trim
                    .Parameters.Add("@IdMateria", SqlDbType.Int).Value = txtCodMateria.Text.Trim
                    .Parameters.Add("@Cantidad", SqlDbType.Int).Value = txtCantidad.Text.Trim
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave duplicada") Then
                MessageBox.Show("Ya se encuentra registrado este ingrediente", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                err = 1
            Else
                MsgBox(ex.Message)
                err = 1
            End If
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ActualizarIngrediente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_ActualizarReceta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdInventario", SqlDbType.VarChar).Value = txtCodProducto.Text.Trim
                    .Parameters.Add("@IdMateria", SqlDbType.Int).Value = txtCodMateria.Text.Trim
                    .Parameters.Add("@Cantidad", SqlDbType.Int).Value = txtCantidad.Text.Trim
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
#End Region

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        LimpiarTodo()
        lsvMostrar.Items.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        LimpiarTodo()
        lsvMostrar.Items.Clear()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Validar(txtCodProducto, "Debe ingresar el código del producto") Then
        ElseIf Validar(txtCodMateria, "Debe ingresar el código de materia prima") Then
        ElseIf Validar(txtCantidad, "Debe ingresar la cantidad de materia prima") Then
        Else
            AgregarIngrediente()
            If err = 0 Then
                HabilitarBotones(False, True, False, True, True)
                MostrarReceta()
                Limpiar()
            Else
                err = 0
            End If

        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If Validar(txtCodProducto, "Debe ingresar el código del producto") Then
        ElseIf Validar(txtCodMateria, "Debe ingresar el código de materia prima") Then
        ElseIf Validar(txtCantidad, "Debe ingresar la cantidad de materia prima") Then
        Else
            ActualizarIngrediente()
            HabilitarBotones(False, True, False, True, True)
            MostrarReceta()
            Limpiar()
            btnAgregar.Enabled = True
            btnEditar.Enabled = False
        End If

    End Sub

    Private Sub lsvMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMostrar.SelectedIndexChanged
        txtCodMateria.Text = lsvMostrar.FocusedItem.SubItems(5).Text
        txtCantidad.Text = lsvMostrar.FocusedItem.SubItems(2).Text
        btnEditar.Enabled = True
        btnAgregar.Enabled = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ListarReceta()
    End Sub

    Private Sub btnEditarListar_Click(sender As Object, e As EventArgs) Handles btnEditarListar.Click
        txtCodProducto.Text = lsvMostrarListar.FocusedItem.SubItems(4).Text
        MostrarReceta()
        HabilitarBotones(False, True, False, True, True)
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub lsvMostrarListar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMostrarListar.SelectedIndexChanged
        btnEditarListar.Enabled = True
    End Sub

    Private Sub txtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCodProducto.TextChanged
        MostrarReceta()
    End Sub
End Class