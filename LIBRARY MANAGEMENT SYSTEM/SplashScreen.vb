Public NotInheritable Class SplashScreen
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        progressBar.Width += 2

        If progressBar.Width >= 496 Then
            timer.Stop()
            Me.Hide()
            StartUp.ShowDialog()
        End If
    End Sub
End Class
