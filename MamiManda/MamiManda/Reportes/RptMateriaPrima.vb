Public Class RptMateriaPrima
    Public Sub New(Optional Id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If (Id > 0) Then
            MateriaPrimaTableAdapter1.FillByID(DsBakerySystem1.MateriaPrima, Id)
        End If
    End Sub
End Class