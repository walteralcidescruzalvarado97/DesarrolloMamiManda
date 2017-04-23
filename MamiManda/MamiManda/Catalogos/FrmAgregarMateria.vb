﻿Imports System.Data.SqlClient
Imports MamiManda

Public Class FrmAgregarMateria
    Implements IAgregarMateria

    Private Sub FrmAgregarMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False)
    End Sub

#Region "Funciones"
    Private Sub HabilitarBotones(ByVal insertar As Boolean, ByVal guardar As Boolean, ByVal cancelar As Boolean, ByVal valor As Boolean)
        btnInsertar.Enabled = insertar
        btnGuardar.Enabled = guardar
        btnCancelar.Enabled = cancelar
        HabilitarTextBox(valor)
    End Sub

    Private Sub HabilitarTextBox(ByVal valor As Boolean)
        txtCodMateria.Enabled = False
        txtCantidad.Enabled = valor
        btnMateria.Enabled = valor
        txtMateria.Enabled = False
        txtMedida.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtCodMateria.Text = Nothing
        txtCantidad.Text = Nothing
        txtMateria.Text = Nothing
        txtMedida.Text = Nothing
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

#Region "SCRUD"
    Private Sub AgregarExistencia()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_AgregarExistenciaMateria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdMateriaPrima", SqlDbType.Int).Value = txtCodMateria.Text.Trim
                    .Parameters.Add("@Cantidad", SqlDbType.Int).Value = txtCantidad.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("Se ha agregado la existencia de materia prima", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
#End Region

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        HabilitarBotones(False, True, True, True)
        Limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar(txtCodMateria, "Debe ingresar el código de materia prima") Then
        ElseIf Validar(txtCantidad, "Debe ingresar la cantidad de materia prima") Then
        Else
            AgregarExistencia()
            HabilitarBotones(True, False, False, False)
            Limpiar()
        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()
    End Sub

    Private Sub btnMateria_Click(sender As Object, e As EventArgs) Handles btnMateria.Click
        Dim BuscarMateriaPrima As New FrmBuscarMateriaPrima
        BuscarMateriaPrima.Show(Me)
        txtCantidad.Focus()
    End Sub

    Public Sub ObtenerCodReceta(Codigo As String) Implements IAgregarMateria.ObtenerCodReceta
        txtCodMateria.Text = Codigo
    End Sub

    Public Sub ObtenerMateria(Materia As String) Implements IAgregarMateria.ObtenerMateria
        txtMateria.Text = Materia
    End Sub

    Public Sub ObtenerMedida(Medida As String) Implements IAgregarMateria.ObtenerMedida
        txtMedida.Text = Medida
    End Sub

    Private Sub txtCodMateria_TextChanged(sender As Object, e As EventArgs) Handles txtCodMateria.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtMateria_TextChanged(sender As Object, e As EventArgs) Handles txtMateria.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtMedida_TextChanged(sender As Object, e As EventArgs) Handles txtMedida.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        ErrorProvider1.Clear()
    End Sub
End Class