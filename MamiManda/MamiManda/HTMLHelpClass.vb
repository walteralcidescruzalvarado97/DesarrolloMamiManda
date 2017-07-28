Public Class HTMLHelpClass

    Shared Function GetLocalHelpFileName(ByVal FileName As String) As String
        Dim ExeName, DirName, HelpFileName As String
        ExeName = Environment.GetCommandLineArgs(0)
        DirName = System.IO.Path.GetDirectoryName(ExeName)
        HelpFileName = DirName + "\" + FileName
        Return HelpFileName
    End Function

End Class
