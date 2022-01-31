Public NotInheritable Class SplashScreen
    ' To raise an event for the Progress/Loading Bar
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        progressBar.Width += 2 'Increment the Progress Bar's width by two

        ' Check the Progress Bar's event should stop or not
        If progressBar.Width >= 496 Then
            timer.Stop()
            Me.Hide()
            StartUp.ShowDialog() 'Redirect the user to Start-Up Page
        End If
    End Sub
End Class
