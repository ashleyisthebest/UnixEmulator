Module echo

    Public Sub echo()
        If command.StartsWith("echo ") Then
            recongnized = True
            command = command.Remove(0, 5)
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(command)
            Main()
        End If
    End Sub


End Module
