Imports System.Data.SqlClient
Public Class FrmBuscarMateriaPrima
    Private Sub FrmBuscarMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoMateriaPrima()
    End Sub

    Private Sub MostrarTodoMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerMateriaPrima As SqlDataReader
                VerMateriaPrima = cmd.ExecuteReader()
                LsvMostrarMateriaPrima.Items.Clear()
                While VerMateriaPrima.Read = True
                    With Me.LsvMostrarMateriaPrima.Items.Add(VerMateriaPrima("IdMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("NombreMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("ExistenciaMinima").ToString)
                        .SubItems.Add(VerMateriaPrima("Existencia").ToString)
                        .SubItems.Add(VerMateriaPrima("PrecioCostoM").ToString)
                        .SubItems.Add(VerMateriaPrima("Fecha").ToString)
                        .SubItems.Add(VerMateriaPrima("Medida").ToString)
                        .SubItems.Add(VerMateriaPrima("RtnProveedor").ToString)
                        .SubItems.Add(VerMateriaPrima("Nombre").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerMateriaPrima As SqlDataReader
                VerMateriaPrima = cmd.ExecuteReader()
                LsvMostrarMateriaPrima.Items.Clear()
                While VerMateriaPrima.Read = True
                    With Me.LsvMostrarMateriaPrima.Items.Add(VerMateriaPrima("IdMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("NombreMateriaPrima").ToString)
                        .SubItems.Add(VerMateriaPrima("ExistenciaMinima").ToString)
                        .SubItems.Add(VerMateriaPrima("Existencia").ToString)
                        .SubItems.Add(VerMateriaPrima("PrecioCostoM").ToString)
                        .SubItems.Add(VerMateriaPrima("Fecha").ToString)
                        .SubItems.Add(VerMateriaPrima("Medida").ToString)
                        .SubItems.Add(VerMateriaPrima("RtnProveedor").ToString)
                        .SubItems.Add(VerMateriaPrima("Nombre").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        MostrarMateriaPrima()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmMateriaPrima.Show()
        Close()
    End Sub

    Private Sub LsvMostrarMateriaPrima_DoubleClick(sender As Object, e As EventArgs) Handles LsvMostrarMateriaPrima.DoubleClick
        FrmAgregarMateria.txtCodMateria.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(0).Text
        FrmAgregarMateria.txtMateria.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(1).Text
        FrmAgregarMateria.txtMedida.Text = LsvMostrarMateriaPrima.FocusedItem.SubItems(6).Text

        Dim Codigo As String = LsvMostrarMateriaPrima.FocusedItem.SubItems(0).Text
        Dim InstanciaIReceta As IReceta = CType(Me.Owner, IReceta)

        If InstanciaIReceta IsNot Nothing Then
            InstanciaIReceta.ObtenerCodReceta(Codigo)
        End If

        Close()
    End Sub
End Class