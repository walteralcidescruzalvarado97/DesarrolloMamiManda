Imports System.Data.SqlClient
Public Class FrmLogin
    Friend Property ModoInicio As Boolean = True
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        If Validar(TxtUser, "Debe ingresar un nombre de usuario") Then
        ElseIf Validar(TxtPassword, "Debe ingresar una contraseña") Then
        Else

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
                        UsuarioActivo.NombreCompleto = reader("NombreCompleto").ToString
                        UsuarioActivo.IdUsuario = reader("IdUsuario").ToString

                        Dim TipoUsuario As Integer = reader("IdTipoUsuario").ToString

                        If TipoUsuario = 1 Then
                            UsuarioActivo.EsAdmin = True
                        Else
                            UsuarioActivo.EsAdmin = False
                        End If

                        MenuPrincipal.Show()

                        'Dim name As String = reader("Nombre")
                        'Dim username As String() = name.Split(" ")
                        'Dim name2 As String = reader("Apellido")
                        'Dim username2 As String() = name2.Split(" ")
                        'FrmPrincipal.Show()


                        'FrmPrincipal.LblId.Text = String.Format("{0}", reader.GetValue(0))
                        'FrmPrincipal.LblUser.Text = String.Format("{0} {1}", username(0), username2(0))


                        'If IsDBNull(reader("Foto")) Then
                        'Else
                        '    Dim imagen As New System.IO.MemoryStream(DirectCast(reader("Foto"), [Byte]()))
                        '    Dim ObjImagen As Image = Image.FromStream(imagen)

                        '    FrmPrincipal.PbUser.BackgroundImage = ObjImagen
                        'End If

                        Me.Close()
                    Else
                        MsgBox("Usuario y Contrasena invalido")
                    End If
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Login")

        If ModoInicio Then
            My.Settings.ConexionTemporal = My.Settings.Conexion
            My.Settings.Save()
            If Conexion() = False Then
                Dim frm As New FrmConfiguracion()
                frm.Show()
                Me.Close()
            End If
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

    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            ErrorProvider1.SetError(Control, "")
            Validar = False
        End If
    End Function
End Class
