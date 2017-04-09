Imports System.Data.SqlClient
Module Conexion
    Public cnn As New SqlConnection(My.Settings.ConexionTemporal)
End Module