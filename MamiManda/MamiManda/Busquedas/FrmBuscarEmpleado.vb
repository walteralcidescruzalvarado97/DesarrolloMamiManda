Imports System.Data.SqlClient
Public Class FrmBuscarEmpleado
    Friend Property DesdeUsuario As Boolean = False
    Private Sub LlenarGridEmpleado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcEmpleado.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGridEmpleado()
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "BEmpleado")
    End Sub

    'Private Sub lsvMostrar_DoubleClick(sender As Object, e As EventArgs)
    '    Dim Dato As String = lsvMostrar.FocusedItem.SubItems(0).Text

    '    Dim InstanciaForm As IForm = CType(Me.Owner, IForm)

    '    If InstanciaForm IsNot Nothing Then
    '        InstanciaForm.ObtenerDato(Dato)
    '    End If

    '    Close()
    'End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmEmpleado.ShowDialog()
    End Sub

    Private Sub GcEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles GcEmpleado.DoubleClick
        If DesdeUsuario Then
            Dim fila As Integer = GridView1.FocusedRowHandle
            FrmUsuario.txtEmpleado.Text = GridView1.GetRowCellValue(fila, "IdEmpleado")
        End If
        Me.Close()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call LlenarGridEmpleado()
    End Sub
End Class