Imports System.Data.SqlClient
Public Class FrmBuscarEmpleado
    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        txtBuscar.Enabled = True
        txtBuscar.Focus()
        btnBuscar.Enabled = False
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarCodigo.Visible = False
        MostrarTodoEmpleado()
    End Sub

    Private Sub MostrarTodoEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("NombreCompleto").ToString)
                        .SubItems.Add(VerEmpleado("EMail").ToString)
                        .SubItems.Add(VerEmpleado("Telefono").ToString)
                        .SubItems.Add(VerEmpleado("direccion").ToString)
                        .SubItems.Add(VerEmpleado("TipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("sexo").ToString)
                        .SubItems.Add(VerEmpleado("IdTipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("IdSexo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarEmpleadoCodigo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarEmpleadoxCodigo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = txtBuscarCodigo.Text.Trim
                    .Connection = cnn
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("NombreCompleto").ToString)
                        .SubItems.Add(VerEmpleado("EMail").ToString)
                        .SubItems.Add(VerEmpleado("Telefono").ToString)
                        .SubItems.Add(VerEmpleado("direccion").ToString)
                        .SubItems.Add(VerEmpleado("TipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("sexo").ToString)
                        .SubItems.Add(VerEmpleado("IdTipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("IdSexo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarEmpleadoNombre()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarEmpleadoxNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("NombreCompleto").ToString)
                        .SubItems.Add(VerEmpleado("EMail").ToString)
                        .SubItems.Add(VerEmpleado("Telefono").ToString)
                        .SubItems.Add(VerEmpleado("direccion").ToString)
                        .SubItems.Add(VerEmpleado("TipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("sexo").ToString)
                        .SubItems.Add(VerEmpleado("IdTipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("IdSexo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged
        txtBuscar.Enabled = True
        txtBuscar.Focus()
        btnBuscar.Enabled = True
        txtBuscar.Text = ""
        txtBuscar.Visible = False
        txtBuscarCodigo.Visible = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscarCodigo.Text = Nothing Then
            MostrarTodoEmpleado()
        Else
            If rbCodigo.Checked = True Then
                If txtBuscarCodigo.Text.Trim = Nothing Then
                    MessageBox.Show("El código de empleado es requerido", "MamiManda", MessageBoxButtons.OK)
                    txtBuscarCodigo.Focus()
                Else
                    MostrarEmpleadoCodigo()
                    txtBuscarCodigo.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub FrmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoEmpleado()
        rbCodigo.Checked = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        MostrarEmpleadoNombre()
    End Sub

    Private Sub lsvMostrar_DoubleClick(sender As Object, e As EventArgs) Handles lsvMostrar.DoubleClick
        Me.Close()
    End Sub
End Class