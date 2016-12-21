Module ping

    Public Sub ping()
        If command.Contains("ping ") Then
            'Recognising command
            recongnized = True
            'Removing "ping  "
            command = command.Remove(0, 5)


        End If
    End Sub

End Module
