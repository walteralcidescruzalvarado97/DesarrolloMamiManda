Public Class RptMateriaPrima
    Public Sub New(Optional Id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_RptMostrarMateriaPrimaTableAdapter1.Fill(DsBakerySystem1.Sp_RptMostrarMateriaPrima, Id)
    End Sub
End Class