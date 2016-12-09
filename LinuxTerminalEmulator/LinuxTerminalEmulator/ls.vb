Imports System.IO

Module ls

    Public directoriesAvailable As String

    Public Sub ls()

        If command = "ls" Then

            'Recognising the command
            recongnized = True

            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("")

            For Each Diry As String In System.IO.Directory.GetDirectories(currentDirectory)
                Dim dirInfo As New System.IO.DirectoryInfo(Diry)
                Console.WriteLine("     \" + dirInfo.Name + vbNewLine)
            Next
            Main()

        End If

    End Sub

End Module
