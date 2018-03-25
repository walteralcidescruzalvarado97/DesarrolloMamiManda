Public Class RptVentasDia
    Public Sub New(Optional Id As String = "2018-01-08")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_VentasDiaTableAdapter1.Fill(DsBakerySystem1.Sp_VentasDia, Id)
    End Sub
End Class