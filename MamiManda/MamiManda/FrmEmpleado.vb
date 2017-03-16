Imports System.Data.SqlClient
Public Class FrmEmpleado
    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxTipoEmpleado()
        LlenarComboboxSexo()
        HabilitarBotones(True, False, False, False, False)
        MostrarEmpleado()
        CboTipoEmpleado.Text = Nothing
        CboSexo.Text = Nothing
    End Sub


    Private Function ExisteEmpleado() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CodEmpleado", SqlDbType.NVarChar, 40).Value = TxtCodEmpleado.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este Empleado", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub InvestigarCorrelativo()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarEmpleado As New SqlCommand("Sp_MostrarCodEmpleadoIdentity", cnn)
            ListarEmpleado.CommandType = CommandType.StoredProcedure
            Dim Listarempleados As SqlDataReader
            cnn.Open()
            Listarempleados = ListarEmpleado.ExecuteReader
            If Listarempleados.Read = True Then
                If Listarempleados("Id") Is DBNull.Value Then
                    TxtCodEmpleado.Text = 1
                Else
                    TxtCodEmpleado.Text = Listarempleados("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal actualizar As Boolean, ByVal cancelar As Boolean, ByVal grupbox As Boolean)
        btnInsertar.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnActualizar.Enabled = actualizar
        btnCancelar.Enabled = cancelar
        GbDatos.Enabled = grupbox
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

    Private Sub Limpiar()
        TxtCodEmpleado.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellido.Text = Nothing
        TxtEmail.Text = Nothing
        TxtTelefono.Text = Nothing
        TxtDireccion.Text = Nothing
        CboTipoEmpleado.SelectedIndex = -1
        CboSexo.SelectedIndex = -1
        chkVer.Enabled = True
    End Sub


    Private Sub LlenarComboboxTipoEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_LlenarComboTipoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoEmpleado")
                Me.CboTipoEmpleado.DataSource = ds.Tables(0)
                Me.CboTipoEmpleado.DisplayMember = ds.Tables(0).Columns("TipoEmpleado").ToString
                Me.CboTipoEmpleado.ValueMember = ds.Tables(0).Columns("IdTipoEmpleado").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub LlenarComboboxSexo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_LlenarComboSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Sexo")
                Me.CboSexo.DataSource = ds.Tables(0)
                Me.CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                Me.CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub AgregarEmpleado()
        If ExisteEmpleado() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "SP_InsertEmpleados"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = TxtNombre.Text.Trim
                        .Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = TxtApellido.Text.Trim
                        .Parameters.Add("@Email", SqlDbType.VarChar).Value = TxtEmail.Text.Trim
                        .Parameters.Add("@Telefono", SqlDbType.VarChar).Value = TxtTelefono.Text.Trim
                        .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text.Trim
                        .Parameters.Add("@TipoEmpleado", SqlDbType.Int).Value = CboTipoEmpleado.SelectedValue
                        .Parameters.Add("@Sexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de Empleado ha sido agregado", "MamiManda", MessageBoxButtons.OK)
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
                    .CommandText = "Sp_ActualizarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdEMpleado", SqlDbType.NVarChar).Value = TxtCodEmpleado.Text.Trim
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@Email", SqlDbType.VarChar).Value = TxtEmail.Text.Trim
                    .Parameters.Add("@Telefono", SqlDbType.VarChar).Value = TxtTelefono.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text.Trim
                    .Parameters.Add("@TipoEmpleado", SqlDbType.Int).Value = CboTipoEmpleado.SelectedValue
                    .Parameters.Add("@Sexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de empleado ha sido actualizado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave duplicada") Then
                MessageBox.Show("Ya se encuentra registrado este empleado", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox(ex.Message)
            End If

        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub MostrarEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                LsvMostrarEmpleado.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.LsvMostrarEmpleado.Items.Add(VerEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("Nombre").ToString)
                        .SubItems.Add(VerEmpleado("Apellido").ToString)
                        .SubItems.Add(VerEmpleado("EMail").ToString)
                        .SubItems.Add(VerEmpleado("Telefono").ToString)
                        .SubItems.Add(VerEmpleado("Direccion").ToString)
                        .SubItems.Add(VerEmpleado("TipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("Sexo").ToString)

                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(TxtNombre, "Debe ingresar un nombre de empleado") Then
        ElseIf Validar(TxtApellido, "Debe ingresar un apellido") Then
        ElseIf Validar(TxtEmail, "Debe seleccionar un Email") Then
        ElseIf Validar(TxtTelefono, "Debe ingresar unnúmero de teléfono") Then
        ElseIf Validar(TxtDireccion, "Debe ingresar una dirección") Then
        ElseIf Validar(CboTipoEmpleado, "Debe seleccionar un tipo de Empleado") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un Sexo") Then
        Else
            AgregarEmpleado()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarEmpleado()
        End If
    End Sub

    Private Sub LsvMostrarEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvMostrarEmpleado.SelectedIndexChanged

        TxtCodEmpleado.Text = LsvMostrarEmpleado.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvMostrarEmpleado.FocusedItem.SubItems(1).Text
        TxtApellido.Text = LsvMostrarEmpleado.FocusedItem.SubItems(2).Text
        TxtEmail.Text = LsvMostrarEmpleado.FocusedItem.SubItems(3).Text
        TxtTelefono.Text = LsvMostrarEmpleado.FocusedItem.SubItems(4).Text
        TxtDireccion.Text = LsvMostrarEmpleado.FocusedItem.SubItems(5).Text
        CboTipoEmpleado.Text = LsvMostrarEmpleado.FocusedItem.SubItems(6).Text
        CboSexo.Text = LsvMostrarEmpleado.FocusedItem.SubItems(7).Text
        HabilitarBotones(False, False, True, True, True)
    End Sub

    Private Sub chkVer_CheckedChanged(sender As Object, e As EventArgs) Handles chkVer.CheckedChanged
        If chkVer.CheckState = CheckState.Checked Then
            Height = 562


        Else
            Height = 401

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Validar(TxtNombre, "Debe ingresar un nombre de empleado") Then
        ElseIf Validar(TxtApellido, "Debe ingresar un apellido") Then
        ElseIf Validar(TxtEmail, "Debe seleccionar un Email") Then
        ElseIf Validar(TxtTelefono, "Debe ingresar unnúmero de teléfono") Then
        ElseIf Validar(TxtDireccion, "Debe ingresar una dirección") Then
        ElseIf Validar(CboTipoEmpleado, "Debe seleccionar un tipo de Empleado") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un Sexo") Then
        Else
            ActualizarEmpleado()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarEmpleado()
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) 
        Close()
    End Sub
End Class