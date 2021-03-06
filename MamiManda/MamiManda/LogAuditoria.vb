﻿Imports System.Data.SqlClient

Public Class LogAuditoria

    Private Sub LogAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()

        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("ManualAyuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "LogAuditoria")
    End Sub

    Private Sub MostrarTodo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_LogAuditoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerLog As SqlDataReader
                VerLog = cmd.ExecuteReader()
                LsvLogAuditoria.Items.Clear()
                While VerLog.Read = True
                    With Me.LsvLogAuditoria.Items.Add(VerLog("IdLogAuditoria").ToString)
                        .SubItems.Add(VerLog("IdUsuario").ToString)
                        .SubItems.Add(VerLog("Descripcion").ToString)
                        .SubItems.Add(VerLog("TipoTransaccion").ToString)
                        .SubItems.Add(VerLog("Fecha"))
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

End Class