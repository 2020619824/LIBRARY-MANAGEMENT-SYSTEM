Public Class MenuList
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub cmdDisplayUser_Click(sender As Object, e As EventArgs) Handles btnDisplayUser.Click
        UserInformation.ShowDialog()
    End Sub

    Private Sub cmdDisplayBookDetails_Click(sender As Object, e As EventArgs) Handles btnDisplayBookDetails.Click
        BookDetails.ShowDialog()
    End Sub

    Private Sub cmdDisplayBorrowers_Click(sender As Object, e As EventArgs) Handles btnDisplayBorrowers.Click
        BorrowerInformation.ShowDialog()
    End Sub

    Private Sub cmdBookIssue_Click(sender As Object, e As EventArgs) Handles btnBookIssue.Click
        BookIssueInformation.ShowDialog()
    End Sub

    Private Sub cmdDisplayBookReturn_Click(sender As Object, e As EventArgs) Handles btnDisplayBookReturn.Click
        BookReturnInformation.ShowDialog()
    End Sub

    Private Sub cmdDisplayLateReturn_Click(sender As Object, e As EventArgs) Handles btnDisplayLateReturn.Click
        LateReturnInformation.ShowDialog()
    End Sub

    Private Sub MenuList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LateReturnStatus()
        LateReturn()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = Date.Now.ToString("t") 'this will set the format of time to hour:minute, eg: 10:30
        txtDate.Text = Date.Now.ToString("D") ' this will set the the format of date to day month year, eg: 13 September 2020
    End Sub

    'This function will update the status and latereturnfine column based on the current date when the application open 
    'For every one day the borrower late to return the book, the fine will increase by one ringgit
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
    Public Sub LateReturn() 'to automatically insert each borrow data into LateReturnFine table 
        Dim query = "Insert into LateReturnFines (BorrowID,LateReturnFines,Payment,DateOfPayment)
                     select BorrowID,Datediff(day,DueDate," & TodayDate() & "),null,null from borrow B where latereturnstatus = 'Yes' 
                     and Not Exists (select * from LateReturnFines L where B.BorrowID = L.BorrowID)"
        'use not exist because to avoid repeated new data
        SQLCommandBasic(query)

        query = "Insert into LateReturnFines (BorrowID,LateReturnFines,Payment,DateOfPayment)
                 select BorrowID,0,null,null from borrow B where latereturnstatus = 'No'
                 and Not Exists (select * from LateReturnFines L where B.BorrowID = L.BorrowID)"
        SQLCommandBasic(query)
    End Sub

End Class