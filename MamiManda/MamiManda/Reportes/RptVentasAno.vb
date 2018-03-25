Public Class RptVentasAno
    Public Sub New(Optional Id As Integer = 2017)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_VentasAnoTableAdapter1.Fill(DsBakerySystem1.Sp_VentasAno, Id)
    End Sub
End Class