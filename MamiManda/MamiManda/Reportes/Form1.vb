Imports DevExpress.XtraReports.UI
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = 2
        Dim isv As Double = 51
        Dim total As Double = 300
        Dim rpt As New RptFactura(id, isv, total)
        Dim viewer As New ReportPrintTool(rpt)
        viewer.ShowRibbonPreview()
    End Sub
End Class