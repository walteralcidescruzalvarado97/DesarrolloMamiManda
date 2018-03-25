Public Class RptClienteMCA
    Public Sub New(Optional Id As Integer = 2017)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_ClienteMayorCompraAnoTableAdapter1.Fill(DsBakerySystem1.Sp_ClienteMayorCompraAno, Id)
    End Sub
End Class