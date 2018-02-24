Imports System.Data.SqlClient


Public Class FrmBuscarMateriaPrima
    Friend Property DesdeAgregarMateriaPrima As Boolean = False
    Friend Property DesdeReceta As Boolean = False
    Private Sub FrmBuscarMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGridMateriaPrima()
    End Sub


    Private Sub LlenarGridMateriaPrima()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarMateriaPrima"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                If cmd.ExecuteNonQuery Then
                    Dim Dt As New DataTable
                    Dim Da As New SqlDataAdapter(cmd)

                    Da.Fill(Dt)

                    GcMateriaPrima.DataSource = Dt
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmMateriaPrima.Show()
        Close()
    End Sub

    Private Sub GcMateriaPrima_DoubleClick(sender As Object, e As EventArgs) Handles GcMateriaPrima.DoubleClick
        If DesdeAgregarMateriaPrima Then
            Dim fila As Integer = GridView1.FocusedRowHandle

            FrmAgregarMateria.txtCodMateria.Text = GridView1.GetRowCellValue(fila, "IdMateriaPrima")
            FrmAgregarMateria.txtMateria.Text = GridView1.GetRowCellValue(fila, "NombreMateriaPrima")
            FrmAgregarMateria.txtMedida.Text = GridView1.GetRowCellValue(fila, "Medida")
        End If

        If DesdeReceta Then
            Dim fila As Integer = GridView1.FocusedRowHandle

            FrmReceta.txtCodMateria.Text = GridView1.GetRowCellValue(fila, "IdMateriaPrima")
        End If
        Me.Close()
    End Sub

    'Private Sub LsvMostrarMateriaPrima_DoubleClick(sender As Object, e As EventArgs)
    '    Dim Codigo As String = LsvMostrarMateriaPrima.FocusedItem.SubItems(0).Text
    '    Dim Materia As String = LsvMostrarMateriaPrima.FocusedItem.SubItems(1).Text
    '    Dim Medida As String = LsvMostrarMateriaPrima.FocusedItem.SubItems(6).Text

    '    Dim InstanciaIAgregarMateria As IAgregarMateria = CType(Me.Owner, IAgregarMateria)

    '    If InstanciaIAgregarMateria IsNot Nothing Then
    '        InstanciaIAgregarMateria.ObtenerCodReceta(Codigo)
    '        InstanciaIAgregarMateria.ObtenerMateria(Materia)
    '        InstanciaIAgregarMateria.ObtenerMedida(Medida)
    '    End If
    '    Close()
    'End Sub

End Class