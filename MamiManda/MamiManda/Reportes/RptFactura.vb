Public Class RptFactura
    Public Sub New(Optional Id As Integer = 0, Optional Isv As Double = 0, Optional Total As Double = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Id > 0 Then
            DataTable1TableAdapter1.FillById(DsBakerySystem1.DataTable1, Id)
            XrLabel21.Text = FormatCurrency(Isv)
            XrLabel23.Text = FormatCurrency(Total)
        End If
    End Sub
End Class