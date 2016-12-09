Imports System.IO

Module ls

    Public directoriesAvailable As String

    Public Sub ls()

        If command = "ls" Then

            'Recognising the command
            recongnized = True

            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("")

            'Getting all the directories
            For Each Diry As String In System.IO.Directory.GetDirectories(currentDirectory)

                'Creating a variable for the directories and their info
                Dim dirInfo As New System.IO.DirectoryInfo(Diry)

                'Writing them out
                Console.WriteLine("     \" + dirInfo.Name + vbNewLine)
            Next
            Main()

        End If

    End Sub

End Module
