Public Class MenuList
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdDisplayUser_Click(sender As Object, e As EventArgs) Handles cmdDisplayUser.Click
        UserInformation.ShowDialog()
    End Sub

    Private Sub cmdDisplayBookDetails_Click(sender As Object, e As EventArgs) Handles cmdDisplayBookDetails.Click
        BookDetails.ShowDialog()
    End Sub

    Private Sub cmdDisplayBorrowers_Click(sender As Object, e As EventArgs) Handles cmdDisplayBorrowers.Click

        BorrowerInformation.ShowDialog()
    End Sub

    Private Sub cmdBookIssue_Click(sender As Object, e As EventArgs) Handles cmdBookIssue.Click
        BookIssueInformation.ShowDialog()
    End Sub

    Private Sub cmdDisplayBookReturn_Click(sender As Object, e As EventArgs) Handles cmdDisplayBookReturn.Click
        BookReturnInformation.ShowDialog()
    End Sub

    Private Sub cmdDisplayLateReturn_Click(sender As Object, e As EventArgs) Handles cmdDisplayLateReturn.Click
        LateReturnInformation.ShowDialog()
    End Sub

    Private Sub MenuList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = Date.Now.ToString("hh:mm:ss")
        txtDate.Text = Date.Now.ToString("dd MMM yyyy")
    End Sub
End Class