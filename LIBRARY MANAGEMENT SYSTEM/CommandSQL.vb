Imports System.Data.SqlClient
Module CommandSQL

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    ' To execute SQL Command such as Insert, Update and Delete
    Public Sub SQLCommandBasic(ByVal strQuery As String)
        Try
            Con.Open()
            Dim query = strQuery
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    ' To execute SQL Command such as Select and Display the result in DataGridView
    Public Sub SQLCommandView(ByVal strQuery As String, ByVal TempDataGridView As DataGridView)
        Try
            Con.Open()
            Dim query = strQuery
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            TempDataGridView.DataSource = ds.Tables(0)
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    ' To format date of today that will being used in SQL Command
    Public Function TodayDate() As String
        ' SQL Date Format: YYYY-MM-DD
        Dim dateSQLFormat = Date.Today.Year.ToString & "-"
        dateSQLFormat += Date.Today.Month.ToString & "-"
        dateSQLFormat += Date.Today.Day.ToString

        Return dateSQLFormat
    End Function

    'This function will update the status and latereturnfine column based on the current date when the application open 
    'For every one day the borrower late to return the book, the fine will increase by one ringgit
    Public Sub LateReturnStatus()
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
End Module