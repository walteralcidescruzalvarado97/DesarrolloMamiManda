Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Configuration
Public Class FrmConfiguracion
    Dim EC As Estado_Conexion
    Dim CSBuilder As New SqlConnectionStringBuilder
    Private Enum Estado_Conexion
        NoComprobada
        Establecida
        NoEstablecida
    End Enum
    Private Sub txts_TextChanged(sender As Object, e As EventArgs) Handles _
        txtServer.TextChanged, txtDB.TextChanged, txtUsername.TextChanged, txtPassword.TextChanged
        EC = Estado_Conexion.NoComprobada
        lblConnStatus.Text = "Conexión no comprobada."
        If Not String.IsNullOrWhiteSpace(txtServer.Text) And Not String.IsNullOrWhiteSpace(txtDB.Text) And
                Not String.IsNullOrWhiteSpace(txtUsername.Text) And Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
            btnTestConnection.Enabled = True
        Else
            btnTestConnection.Enabled = False
        End If
    End Sub
    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        btnTestConnection.Enabled = False
        lblConnStatus.Text = "Comprobando la conexión..."
        lblConnStatus.Refresh()
        With CSBuilder
            .DataSource = txtServer.Text : .InitialCatalog = txtDB.Text
            .UserID = txtUsername.Text : .Password = txtPassword.Text
        End With
        Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
        Try
            Cnx.Open()
            EC = Estado_Conexion.Establecida
            lblConnStatus.Text = "Conexión establecida exitosamente."
            Dim nuevaCadenaConexion As String = "Data Source=" & txtServer.Text & ";Initial Catalog=" & txtDB.Text & ";User ID=" & txtUsername.Text & ";Password=" & txtPassword.Text & ""
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)

            Dim connectionStringsSection As ConnectionStringsSection = DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)

            connectionStringsSection.ConnectionStrings("MamiManda.My.MySettings.Conexion").ConnectionString = nuevaCadenaConexion

            config.Save(ConfigurationSaveMode.Modified, False)

            My.Settings.Save()
            My.Settings.ConexionTemporal = nuevaCadenaConexion
            My.Settings.Save()
            cnn = New SqlConnection(My.Settings.ConexionTemporal)



        Catch ex As Exception
            If ex.ToString.Contains("No se encontró el servidor") Then
                MessageBox.Show("El nombre o direccion del servidor no es correcto", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If ex.ToString.Contains("No se puede abrir la base de datos") Then
                MessageBox.Show("El nombre de la base de datos es incoreccto", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If ex.ToString.Contains("Error de inicio de sesión del usuario") Then
                MessageBox.Show("El nombre de usuario o contraseña para la base de datos es incorecto", "MamiManda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            EC = Estado_Conexion.NoEstablecida
            lblConnStatus.Text = "Error en la conexión"
        Finally
            btnTestConnection.Enabled = True
            Cnx.Close()
        End Try

    End Sub
    Private Sub FrmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim cadena As String = My.Settings.ConexionTemporal.ToString
        If cadena <> String.Empty Then
            Dim c As String() = cadena.Split(";")
            txtServer.Text = Replace(c(0), "Data Source=", "")
            txtDB.Text = Replace(c(1), "Initial Catalog=", "")
            Dim n As String = Replace(c(2), "User ID=", "")
            txtUsername.Text = Replace(n, " ", "")
            txtPassword.Text = Replace(c(3), "Password=", "")
        End If
    End Sub
End Class