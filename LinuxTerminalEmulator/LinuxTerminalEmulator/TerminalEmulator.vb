Imports LinuxTerminalEmulator.ConsoleExtender

Module TerminalEmulator

    Public command As String
    Public pcUser As String = System.Environment.UserName
    Public pcName As String = System.Environment.MachineName
    Public currentDirectory As String
    Public recongnized As Boolean

    Public Sub Main()

        'Resetting the command recognition
        recongnized = False

        'Intro
        Console.CursorSize = 1
        Console.Title = "Bash Emulator"
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write(pcUser)
        Console.Write(" @ ")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write(pcName)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write(" $ ")
        command = Console.ReadLine()

        'Checking all the commands
        echo.echo()
        cd.cd()
        ls.ls()
        cls.cls()

        'Making sure noting would happen if no command was entered
        If command = "" Then
            recongnized = True
            Main()
        End If

        'Command recognition
        If recongnized = False Then
            Console.BackgroundColor = ConsoleColor.Red
            Console.WriteLine("The command '" + command + "' is not recognised.")
            Console.BackgroundColor = ConsoleColor.Black
            Main()
        End If

    End Sub

End Module
