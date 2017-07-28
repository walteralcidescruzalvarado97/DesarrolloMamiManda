Imports System.Data.SqlClient
Public Class FrmBuscarEmpleado

    Private Sub MostrarTodoEmpleado()
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
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("Nombre").ToString)
                        .SubItems.Add(VerEmpleado("Apellido").ToString)
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

    Private Sub ListarEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerEmpleado As SqlDataReader
                VerEmpleado = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerEmpleado.Read = True
                    With Me.lsvMostrar.Items.Add(VerEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("Nombre").ToString)
                        .SubItems.Add(VerEmpleado("Apellido").ToString)
                        .SubItems.Add(VerEmpleado("EMail").ToString)
                        .SubItems.Add(VerEmpleado("Telefono").ToString)
                        .SubItems.Add(VerEmpleado("Direccion").ToString)
                        .SubItems.Add(VerEmpleado("TipoEmpleado").ToString)
                        .SubItems.Add(VerEmpleado("Sexo").ToString)
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


    Private Sub FrmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoEmpleado()
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "BEmpleado")
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ListarEmpleado()
    End Sub

    Private Sub lsvMostrar_DoubleClick(sender As Object, e As EventArgs) Handles lsvMostrar.DoubleClick
        Dim Dato As String = lsvMostrar.FocusedItem.SubItems(0).Text

        Dim InstanciaForm As IForm = CType(Me.Owner, IForm)

        If InstanciaForm IsNot Nothing Then
            InstanciaForm.ObtenerDato(Dato)
        End If

        Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmEmpleado.Show()
        Close()
    End Sub
End Class