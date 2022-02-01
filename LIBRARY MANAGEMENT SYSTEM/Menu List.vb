Public Class MenuList

    ' to terminate application
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' to display user information form
    Private Sub cmdDisplayUser_Click(sender As Object, e As EventArgs) Handles btnDisplayUser.Click
        UserInformation.ShowDialog()
    End Sub

    ' to display book details form
    Private Sub cmdDisplayBookDetails_Click(sender As Object, e As EventArgs) Handles btnDisplayBookDetails.Click
        BookDetails.ShowDialog()
    End Sub

    ' to display borrower information form
    Private Sub cmdDisplayBorrowers_Click(sender As Object, e As EventArgs) Handles btnDisplayBorrowers.Click
        BorrowerInformation.ShowDialog()
    End Sub

    ' to display book issue information form
    Private Sub cmdBookIssue_Click(sender As Object, e As EventArgs) Handles btnBookIssue.Click
        BookIssueInformation.ShowDialog()
    End Sub

    ' to display book return information form
    Private Sub cmdDisplayBookReturn_Click(sender As Object, e As EventArgs) Handles btnDisplayBookReturn.Click
        BookReturnInformation.ShowDialog()
    End Sub

    ' to display late return information form
    Private Sub cmdDisplayLateReturn_Click(sender As Object, e As EventArgs) Handles btnDisplayLateReturn.Click
        LateReturnInformation.ShowDialog()
    End Sub

    Private Sub MenuList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LateReturnStatus() ' invoke method in Module CommandSQL
        LateReturn() 'invoke method in Module CommandSQL

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = Date.Now.ToString("t") 'this will set the short format of time 
        txtDate.Text = Date.Now.ToString("D") ' this will set the long date format of date 
    End Sub

End Class