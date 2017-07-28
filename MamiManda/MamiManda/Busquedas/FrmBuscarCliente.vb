Imports System.Data.SqlClient
Public Class FrmBuscarCliente
    Private Sub MostrarTodoCliente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerCliente As SqlDataReader
                VerCliente = cmd.ExecuteReader()
                LsvMostrarCliente.Items.Clear()
                While VerCliente.Read = True
                    With Me.LsvMostrarCliente.Items.Add(VerCliente("RTNCliente").ToString)
                        .SubItems.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellido").ToString)
                        .SubItems.Add(VerCliente("EMail").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaNac").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("Municipio").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarCliente()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarCLiente"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerCliente As SqlDataReader
                VerCliente = cmd.ExecuteReader()
                LsvMostrarCliente.Items.Clear()
                While VerCliente.Read = True
                    With Me.LsvMostrarCliente.Items.Add(VerCliente("RTNCliente").ToString)
                        .SubItems.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellido").ToString)
                        .SubItems.Add(VerCliente("EMail").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaNac").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("Municipio").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmBusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoCliente()
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "BCliente")
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        MostrarCliente()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmCliente.Show()
        Close()
    End Sub

    Private Sub LsvMostrarCliente_DoubleClick(sender As Object, e As EventArgs) Handles LsvMostrarCliente.DoubleClick
        Dim Codigo As String = LsvMostrarCliente.FocusedItem.SubItems(0).Text
        Dim InstanciaICliente As ICliente = CType(Me.Owner, ICliente)

        If InstanciaICliente IsNot Nothing Then
            InstanciaICliente.ObtenerCodCliente(Codigo)
        End If
        Close()
    End Sub
End Class