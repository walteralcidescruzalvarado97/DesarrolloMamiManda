Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            cnn.Open()
            Dim user As String = Replace(TxtUser.Text, "'", "")
            Dim pass As String = SHA1(TxtPassword.Text)
            Using cmd As New SqlCommand("SELECT * FROM Usuario WHERE UserName = '" & user & "' AND Password = '" & pass & "'", cnn)

                Dim reader As SqlDataReader = cmd.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    'Aqui va el MDI
                    MsgBox("Bienvenido")
                Else
                    MsgBox("Usuario y Contrasena invalido")
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class
