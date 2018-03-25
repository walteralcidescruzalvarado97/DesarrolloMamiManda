Public Class RptVentasMes
    Public Sub New(Optional Id As Integer = 2)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_VentasMesTableAdapter1.Fill(DsBakerySystem1.Sp_VentasMes, Id)
    End Sub
End Class