Public Class StartUp
    ' To redirect the user to Registration Page 
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Registration.ShowDialog()
    End Sub

    ' To redirect the user to Login Page 
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Login.ShowDialog()
    End Sub

    ' To exit the Application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
