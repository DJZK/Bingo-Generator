Public Class MainForm
    Dim validator As Boolean
    Dim counter As Integer = 1
    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles buttonDraw.Click
        fakeDraw.Enabled = True
        'drawNumber()
        counter += 1
        buttonDraw.Enabled = False
        Button1.Enabled = False
        playSound("Tick")
        playSound("Draw")
    End Sub

    Private Sub FakeDraw_Tick(sender As Object, e As EventArgs) Handles fakeDraw.Tick


        If fakeProgress.Value = 100 Then
            fakeDraw.Enabled = False
            fakeProgress.Value = 0
        End If
        fakeProgress.Value += 1
        Label1.Text = Val(generateNumber())
        If fakeDraw.Enabled = False Then
            fakeProgress.Value -= 1
            drawNumber()
            '    MsgBox("Number draw")
        End If
    End Sub

    Private Sub drawNumber()
        buttonDraw.Enabled = True
        Button1.Enabled = True
        Dim drawer As Integer
        Label1.Text = Val(generateNumber()) + 1
        drawer = Label1.Text - 1
        While validator
            If Bingo(drawer) Then
                'MsgBox("Not available", vbInformation, "Hello")
                Label1.Text = Val(generateNumber()) + 1
                drawer = Val(Label1.Text) - 1
                validator = True
            Else
                Bingo(drawer) = True
                'MsgBox("Dont exist")
                validator = False
                comboHistory.Text = Label1.Text
                comboHistory.Items.Add(Label1.Text)
                playSound("Done")

            End If
        End While
        validator = True
        If counter = 75 Then
            playSound("Game Over")
            buttonDraw.Enabled = False
            MsgBox("75 numbers done :D Somebody should've won? Or maybe no one... idk tbh...", vbInformation + vbOKOnly, "DJZK Says")
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validator = True
        initBingo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        playSound("Tick")
        Dim a As Integer
        a = MsgBox("Are you sure you want to reset? This can't be undone!", vbQuestion + vbYesNo, "DJZK Asks")
        If a = vbYes Then
            SplashScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        playSound("Tick")
        Dim a As Integer
        a = MsgBox("Are you sure you want to exit the bingo generator? You'll lose all the progress", vbQuestion + vbYesNo, "DJZK Asks")
        If a = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
