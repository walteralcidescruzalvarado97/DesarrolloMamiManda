Imports DevExpress.XtraReports.UI
Public Class FrmReporteMateriaPrima
    Private Sub FrmReporteMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsBakerySystem.Sp_MostrarMate' table. You can move, or remove it, as needed.
        Me.Sp_MostrarMateTableAdapter.Fill(Me.DsBakerySystem.Sp_MostrarMate)
        'TODO: This line of code loads data into the 'DsBakerySystem.Sp_MostrarMate' table. You can move, or remove it, as needed.
        Me.Sp_MostrarMateTableAdapter.Fill(Me.DsBakerySystem.Sp_MostrarMate)
        'TODO: This line of code loads data into the 'DsBakerySystem.Sp_MostrarMate' table. You can move, or remove it, as needed.
        Me.Sp_MostrarMateTableAdapter.Fill(Me.DsBakerySystem.Sp_MostrarMate)
        'TODO: This line of code loads data into the 'DsBakerySystem.MateriaPrima' table. You can move, or remove it, as needed.
        Me.Sp_MostrarMateTableAdapter.Fill(Me.DsBakerySystem.Sp_MostrarMate)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporte As New RptMateriaPrima()
        Dim viewer As New ReportPrintTool(reporte)

        If (TxtID.Enabled = True) Then
            If (TxtID.Text = Nothing) Then
                MessageBox.Show("Ingrese el Id de Materia Prima", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtID.Focus()
            Else
                Dim rpt As New RptMateriaPrima(TxtID.Text)
                Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowRibbonPreview()
            End If
        ElseIf (RadioButton2.Checked = True)
            viewer.ShowRibbonPreview()
        Else
            MessageBox.Show("No ha seleccionado nada", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TxtID.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TxtID.Enabled = False
        TxtID.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class