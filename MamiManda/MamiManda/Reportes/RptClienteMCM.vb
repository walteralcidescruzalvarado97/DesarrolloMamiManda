Public Class RptClienteMCM
    Public Sub New(Optional Id As Integer = 1)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Sp_ClienteMayorCompraMesTableAdapter1.Fill(DsBakerySystem1.Sp_ClienteMayorCompraMes, Id)
    End Sub
End Class