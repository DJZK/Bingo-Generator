Public Class SplashScreen
    Dim A As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        A += 1
        If A = 100 Then
            Timer1.Enabled = False
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class