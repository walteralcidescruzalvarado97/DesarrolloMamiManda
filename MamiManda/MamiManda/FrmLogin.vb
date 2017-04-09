Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            cnn.Open()
            Dim user As String = Replace(TxtUser.Text, "'", "")
            Dim pass As String = SHA1(TxtPassword.Text)
            Using cmd As New SqlCommand

                With cmd
                    .CommandText = "Sp_Login"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user
                    .Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass
                End With
                Dim reader As SqlDataReader = cmd.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    FrmPrincipal.Show()
                    Me.Close()
                    FrmPrincipal.LblId.Text = String.Format("{0}", reader.GetValue(0))
                    FrmPrincipal.LblUser.Text = String.Format("{0} {1}", reader.GetValue(2), reader.GetValue(3))
                    Dim imagen As New System.IO.MemoryStream(DirectCast(reader("Foto"), [Byte]()))
                    Dim ObjImagen As Image = Image.FromStream(imagen)
                    FrmPrincipal.PbUser.BackgroundImage = ObjImagen
                Else
                    MsgBox("Usuario y Contrasena invalido")
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.ConexionTemporal = My.Settings.Conexion
        My.Settings.Save()


        If Conexion() = False Then
            FrmConfiguracion.ShowDialog()
        End If
    End Sub

    Private Function Conexion() As Boolean
        Try
            cnn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
