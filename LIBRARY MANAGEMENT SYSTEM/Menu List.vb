Public Class MenuList
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdDisplayUser_Click(sender As Object, e As EventArgs) Handles cmdDisplayUser.Click
        Dim UserInformation As New MenuList

        UserInformation.ShowDialog()

    End Sub

    Private Sub cmdDisplayBookDetails_Click(sender As Object, e As EventArgs) Handles cmdDisplayBookDetails.Click
        Dim BookDetails As New MenuList

        BookDetails.ShowDialog()
    End Sub

    Private Sub cmdDisplayBorrowers_Click(sender As Object, e As EventArgs) Handles cmdDisplayBorrowers.Click
        Dim BorrowerInformation As New MenuList

        BorrowerInformation.ShowDialog()
    End Sub

    Private Sub cmdBookIssue_Click(sender As Object, e As EventArgs) Handles cmdBookIssue.Click
        Dim BookIssueInformation As New MenuList

        BookIssueInformation.ShowDialog()
    End Sub

    Private Sub cmdDisplayBookReturn_Click(sender As Object, e As EventArgs) Handles cmdDisplayBookReturn.Click
        Dim BookReturnInformation As New MenuList

        BookReturnInformation.ShowDialog()
    End Sub

    Private Sub cmdDisplayLateReturn_Click(sender As Object, e As EventArgs) Handles cmdDisplayLateReturn.Click
        Dim LateReturnInformation As New MenuList

        LateReturnInformation.ShowDialog()
    End Sub
End Class