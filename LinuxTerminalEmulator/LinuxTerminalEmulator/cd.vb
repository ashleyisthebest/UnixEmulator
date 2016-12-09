Imports System
Imports System.IO
Imports System.Collections

Module cd
    Public Sub cd()
        If command.StartsWith("cd ") Then

            'Removing "cd "
            command = command.Remove(0, 3)

            'Recognisng the command
            recongnized = True

            'Checking if the directory entered is a hard drive root
            If command.Contains(":") Then
                If Directory.Exists(command) Then
                    currentDirectory = command
                    Console.WriteLine(currentDirectory)
                    Main()
                Else
                    Console.BackgroundColor = ConsoleColor.Red
                    Console.WriteLine("'" + command + "' is not a valid directory.")
                    Console.BackgroundColor = ConsoleColor.Black
                    Main()
                End If
            End If

            'Adding on the directory extension
            If Directory.Exists(currentDirectory + command) Then
                currentDirectory = currentDirectory + command
                Console.WriteLine(currentDirectory)
                Main()
            Else
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("'" + currentDirectory + command + "' is not a valid directory.")
                Console.BackgroundColor = ConsoleColor.Black
                Main()
            End If
        End If
    End Sub
End Module
