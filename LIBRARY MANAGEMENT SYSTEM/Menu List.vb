Public Class MenuList
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Application.Exit()
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
        LateReturnStatus()
        LateReturn()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = Date.Now.ToString("hh:mm")
        txtDate.Text = Date.Now.ToString("dd MMM yyyy")
    End Sub

    Private Function TodayDate() As String
        'SQL Date Format: YYYYMMDD
        Dim dateSQLFormat = Date.Today.Year.ToString & "-"
        dateSQLFormat += Date.Today.Month.ToString & "-"
        dateSQLFormat += Date.Today.Day.ToString

        Return dateSQLFormat
    End Function

    Private Sub LateReturnStatus()
        Dim query = "update Borrow set LateReturnStatus='Yes' where DueDate<'" & TodayDate() & "'"
        SQLCommandBasic(query)
        query = "update latereturnfines 
                 set latereturnfines.latereturnfines = Datediff(day,borrow.DueDate,GetDate()) 
                 from latereturnfines 
                 inner join borrow
                 on latereturnfines.BorrowID = borrow.BorrowID
                  where borrow.latereturnstatus = 'yes'"
        SQLCommandBasic(query)

        query = "update Borrow set LateReturnStatus='No' where DueDate>='" & TodayDate() & "'"
        SQLCommandBasic(query)

        query = "update LateReturnFines set latereturnfines = 0 WHERE borrowid IN (SELECT borrowid FROM borrow WHERE latereturnstatus = 'no')"
        SQLCommandBasic(query)
    End Sub
    Public Sub LateReturn()
        Dim query = "Insert into LateReturnFines (BorrowID,LateReturnFines,Payment,DateOfPayment)
                     select BorrowID,Datediff(day,DueDate," & TodayDate() & "),null,null from borrow B where latereturnstatus = 'Yes' 
                     and Not Exists (select * from LateReturnFines L where B.BorrowID = L.BorrowID)"
        SQLCommandBasic(query)

        query = "Insert into LateReturnFines (BorrowID,LateReturnFines,Payment,DateOfPayment)
                 select BorrowID,0,null,null from borrow B where latereturnstatus = 'No'
                 and Not Exists (select * from LateReturnFines L where B.BorrowID = L.BorrowID)"
        SQLCommandBasic(query)
    End Sub

End Class