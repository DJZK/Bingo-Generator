Module GeneralFunctions
    Public Bingo(74) As Boolean ' Array for numbers



    Public Function generateNumber() As Integer
        Dim draw As Integer
        draw = Fix(Rnd() * 75)
        Return draw
    End Function


    Public Sub initBingo()
        Randomize()
        Dim looper As Integer
        looper = 0
        'MsgBox("initialized")
        While looper <= 74
            Bingo(looper) = False
            '    MsgBox("Number has been falsified" & Bingo(looper), vbInformation)
            looper += 1

        End While
    End Sub

    Public Sub playSound(Sound As String)
        Select Case Sound
            Case "Ding"
                My.Computer.Audio.Play(My.Resources.Ding_Sound_Effect, AudioPlayMode.Background)
            Case "Tick"
                My.Computer.Audio.Play(My.Resources.ButtonClick, AudioPlayMode.Background)
            Case "Cling"
                My.Computer.Audio.Play(My.Resources.Message, AudioPlayMode.Background)
            Case "Draw"
                My.Computer.Audio.Play(My.Resources.SOUND560, AudioPlayMode.Background)
            Case "Done"
                My.Computer.Audio.Play(My.Resources.SOUND528, AudioPlayMode.Background)
            Case "Game Over"
                My.Computer.Audio.Play(My.Resources.SOUND9, AudioPlayMode.Background)
        End Select
    End Sub
End Module
