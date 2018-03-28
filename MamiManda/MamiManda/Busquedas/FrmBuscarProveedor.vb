Imports System.Data.SqlClient

Public Class FrmBuscarProveedor
    Friend Property DesdeMateriaPrima As Boolean = False
    Private Sub FrmBuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridProveedor()

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "BProveedor")
    End Sub

    Private Sub LlenarGridProveedor()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTodoProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcProveedor.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmProveedor.ShowDialog()
    End Sub

    Private Sub GcProveedor_DoubleClick(sender As Object, e As EventArgs) Handles GcProveedor.DoubleClick
        If DesdeMateriaPrima Then
            Dim fila As Integer = GridView1.FocusedRowHandle

            FrmMateriaPrima.TxtRtnProveedor.Text = GridView1.GetRowCellValue(fila, "RTNProveedor")
        End If
        Me.Close()
    End Sub

    'Private Sub lsvMostrar_MouseDoubleClick(sender As Object, e As MouseEventArgs)
    '    Dim Dato As String = lsvMostrar.FocusedItem.SubItems(0).Text

    '    Dim InstanciaForm As IForm = CType(Me.Owner, IForm)

    '    If InstanciaForm IsNot Nothing Then
    '        InstanciaForm.ObtenerDato(Dato)
    '    End If
    '    Close()
    'End Sub


    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call LlenarGridProveedor()
    End Sub
End Class