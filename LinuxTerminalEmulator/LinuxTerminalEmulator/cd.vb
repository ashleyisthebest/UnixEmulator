Imports System
Imports System.IO
Imports System.Collections

Module cd

    Public Sub cd()
        If command.StartsWith("cd ") Then
            command = command.Remove(0, 3)
            recongnized = True
            If Directory.Exists(command) Then
                currentDirectory = command
                Main()
            Else
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("'" + command + "' is not a valid directory.")
                Console.BackgroundColor = ConsoleColor.Black
                Main()
            End If
        End If

    End Sub

End Module
