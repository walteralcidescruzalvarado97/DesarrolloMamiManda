Public Class Splash_BakerySystem
    Dim i As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i = 0 Then
            LblInitial.Text = "Initializing."
        ElseIf i = 1 Then
            LblInitial.Text = "Initializing.."
        ElseIf i = 2 Then
            LblInitial.Text = "Initializing..."
        ElseIf i = 3 Then
            LblInitial.Text = "Initializing."
        ElseIf i = 4 Then
            LblInitial.Text = "Initializing.."
        ElseIf i = 5 Then
            LblInitial.Text = "Initializing..."
        ElseIf i = 6 Then
            LblInitial.Text = "Initializing."
        ElseIf i = 7 Then
            LblInitial.Text = "Initializing.."
        ElseIf i = 8 Then
            LblInitial.Text = "Initializing..."
            Timer1.Interval = 1000
        ElseIf i = 9 Then
            LblInitial.Text = "C:\Program Files\IIS Express\AppServer\root\ServerFile_Connection"
        ElseIf i = 10 Then
            LblInitial.Text = "C:\Program Files\IIS Express\AppServer\root\Server_BakerySystem"
        ElseIf i = 11 Then
            LblInitial.Text = "C:\BakerySystem_Database\Connection-successfully"
            Timer1.Interval = 500
        ElseIf i = 12 Then
            LblInitial.Text = "C:\BakerySystem\Program\Download.File\Starter"
        ElseIf i = 13 Then
            LblInitial.Text = "C:\BakerySystem\Program\Download.File\Runnig"
        ElseIf i = 14 Then
            LblInitial.Text = "C:\Enable\cmd\BakerySystem.exe"
        ElseIf i = 15 Then
            LblInitial.Text = "C:\Load:File\Interfaces.\Login"
        ElseIf i = 16 Then
            LblInitial.Text = "Load Complete. Open Program"
        ElseIf i = 20 Then
            FrmLogin.Show()
            Me.Hide()
        End If

        i += 1
    End Sub
End Class