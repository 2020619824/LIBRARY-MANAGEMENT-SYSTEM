Imports System.Data.SqlClient
Public Class LateReturnInformation

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30 ")
    Dim i As Integer 'to store current primary key selected data from data grid

    Private Sub LateReturnInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LateReturnStatus()
        LateReturn()
        Dim query
        query = "Select BR.BorrowerName, BRW.BorrowerIC, BR.PhoneNum, BRW.ISBN,
                 B.YearofPublication, B.Title, B.Author, B.Publisher, 
                 BRW.IssueDate, BRW.DueDate, L.LateReturnFines
                 From Book B, Borrower BR, Borrow BRW, LateReturnFines L
                 Where B.ISBN = BRW.ISBN
                 AND BRW.BorrowerIC = BR.BorrowerIC
                 AND L.BorrowID = BRW.BorrowID
                 AND L.LateReturnFines <> 0.00
                 AND L.Payment is null
                 AND L.DateofPayment is null"
        SQLCommandView(query, dgvLateReturnFine)
        dtpDatePaynment.Format = DateTimePickerFormat.Custom
        dtpDatePaynment.CustomFormat = "yyyy-MM-dd"

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
    Dim decSearchICNumber As Decimal
    Private Function ValidateICNumber() As Boolean
        If Not Decimal.TryParse(txtSearchLateReturnInformation.Text, decSearchICNumber) Then
            MyMessageBox.ShowMessage("Please input the IC number correctly")
            Return False
        End If
        Return True
    End Function
    Private Sub cmdSearchLateReturnFines_Click(sender As Object, e As EventArgs) Handles btnSearchLateReturnFines.Click
        Dim strSearchBorrowerName As String


        Dim blnInvalidICNum As Boolean
        blnInvalidICNum = False

        If txtSearchLateReturnInformation.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
        Else
            Dim query = ""
            If cboSearchBy.SelectedIndex = 0 Then
                strSearchBorrowerName = txtSearchLateReturnInformation.Text
                query = "Select BR.BorrowerName, BRW.BorrowerIC, BR.PhoneNum, BRW.ISBN,
                 B.YearofPublication, B.Title, B.Author, B.Publisher, 
                 BRW.IssueDate, BRW.DueDate, L.LateReturnFines
                 From Book B, Borrower BR, Borrow BRW, LateReturnFines L
                 Where B.ISBN = BRW.ISBN
                 AND BRW.BorrowerIC = BR.BorrowerIC
                 AND L.BorrowID = BRW.BorrowID
                 AND L.LateReturnFines <> 0.00
                 AND L.Payment is null
                 AND L.DateofPayment is null
                 AND BR.BorrowerName like '%" & strSearchBorrowerName & "%'"
                SQLCommandView(query, dgvLateReturnFine)

            ElseIf cboSearchBy.SelectedIndex = 1 Then
                If ValidateICNumber() Then
                    query = "Select BR.BorrowerName, BRW.BorrowerIC, BR.PhoneNum, BRW.ISBN,
                 B.YearofPublication, B.Title, B.Author, B.Publisher, 
                 BRW.IssueDate, BRW.DueDate, L.LateReturnFines
                 From Book B, Borrower BR, Borrow BRW, LateReturnFines L
                 Where B.ISBN = BRW.ISBN
                 AND BRW.BorrowerIC = BR.BorrowerIC
                 AND L.BorrowID = BRW.BorrowID
                 AND L.LateReturnFines <> 0.00
                 AND L.Payment is null
                 AND L.DateofPayment is null
                 And BR.BorrowerIC like '%" & decSearchICNumber & "%'"
                    SQLCommandView(query, dgvLateReturnFine)
                Else
                    blnInvalidICNum = True
                End If
            End If

            If blnInvalidICNum = False Then
                If dgvLateReturnFine.Rows.Count = 0 Then
                    MyMessageBox.ShowMessage("Sorry, no information found")
                Else
                    MyMessageBox.ShowMessage(dgvLateReturnFine.Rows.Count & " Information found!")
                End If
            End If
        End If
    End Sub

    Private Sub DataGridViewLateReturnFine_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLateReturnFine.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLateReturnFine.Rows(e.RowIndex)
            txtBorrowerName.Text = row.Cells(0).Value.ToString
            txtBorrowerIC.Text = row.Cells(1).Value.ToString
            txtTotalLateReturnFines.Text = row.Cells(10).Value.ToString
            i = Convert.ToInt64(row.Cells(1).Value.ToString)
            txtFinePayment.Focus()
        End If
    End Sub

    ' Function to get the total balance of the paynment
    Private Sub totalBalance()
        Dim decTotBal As Decimal

        decTotBal = CDec(txtFinePayment.Text) - CDec(txtTotalLateReturnFines.Text)
        txtBalance.Text = decTotBal.ToString("n")
    End Sub

    Dim decPayment As Decimal
    Private Function ValidatePayment() As Boolean
        If Not Decimal.TryParse(txtFinePayment.Text, decPayment) Then
            MyMessageBox.ShowMessage("Please input the payment correctly")
            txtFinePayment.Clear()
            Return False
        End If
        Return True
    End Function
    Private Sub btnGenerateReceipt_Click(sender As Object, e As EventArgs) Handles btnGenerateReceipt.Click

        If i = 0 Then
            MyMessageBox.ShowMessage("Please fill the boxes by select data from list of Late Return Books! ")
        ElseIf txtBorrowerName.Text = "" Then
            MyMessageBox.ShowMessage("Missing borrower's name input! ")
        ElseIf txtBorrowerIC.Text = "" Then
            MyMessageBox.ShowMessage("Missing borrowers's IC input! ")
        ElseIf txtTotalLateReturnFines.Text = "" Then
            MyMessageBox.ShowMessage("Missing total fine input! ")
        ElseIf txtFinePayment.Text = "" Then
            MyMessageBox.ShowMessage("Missing payment input! ")
        ElseIf ValidatePayment() Then
            If CDec(txtFinePayment.Text) < CDec(txtTotalLateReturnFines.Text) Then 'this condition to compare between total late fine and the amount of payment given
                MyMessageBox.ShowMessage("Amount is not enough for payment! " & ControlChars.CrLf & "Please put new payment.")
                txtFinePayment.Clear()
            Else
                totalBalance()
                UpdateBorrow()
                UpdateDatePayment()
                UpdatePayment()
                pdReceipt.Print()
            End If
        End If

    End Sub

    ' Function to update the status and return date in Borrow database
    Private Sub UpdateBorrow()
        Dim query
        query = "Update Borrow
                 Set ReturnDate = '" & dtpDatePaynment.Text & "'
                 Where BorrowerIC = " & txtBorrowerIC.Text & "
                 And BorrowID in (Select BorrowID from LateReturnFines where LateReturnFines = " & txtTotalLateReturnFines.Text & ")"
        SQLCommandBasic(query)
    End Sub

    ' Function to update fine payment given in LateReturnFines database
    Private Sub UpdatePayment()
        Dim query
        query = "Update LateReturnFines 
                 Set Payment = " & decPayment & " 
                 Where BorrowID in (Select BorrowID from Borrow where BorrowerIC = " & txtBorrowerIC.Text & ")
                 And LateReturnFines = " & txtTotalLateReturnFines.Text & ""
        SQLCommandBasic(query)
    End Sub
    ' Function to update date of payment in LateReturnFines database
    Private Sub UpdateDatePayment()
        Dim query
        query = "Update LateReturnFines 
                 Set DateofPayment = '" & dtpDatePaynment.Text & "'
                 Where BorrowID in (Select BorrowID from Borrow where BorrowerIC = " & txtBorrowerIC.Text & ")
                 And LateReturnFines = " & txtTotalLateReturnFines.Text & ""
        SQLCommandBasic(query)
    End Sub

    Private Sub pdReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdReceipt.PrintPage


        e.Graphics.DrawString("RECEIPT", New Font("Times New Roman", 24,
            FontStyle.Bold), Brushes.Black, 300, 50)

        e.Graphics.DrawString("=======================================", New Font("Times New Roman", 24,
            FontStyle.Bold), Brushes.Black, 50, 80)

        e.Graphics.DrawString("READ O BRITE", New Font("Times New Roman", 24,
            FontStyle.Bold), Brushes.Black, 300, 110)

        e.Graphics.DrawString("PUBLIC LIBRARY", New Font("Times New Roman", 24,
            FontStyle.Bold), Brushes.Black, 280, 140)

        e.Graphics.DrawString("=======================================", New Font("Times New Roman", 24,
            FontStyle.Bold), Brushes.Black, 50, 170)


        e.Graphics.DrawString("Name: " & txtBorrowerName.Text, New Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 120, 200)
        e.Graphics.DrawString("IC: " & txtBorrowerIC.Text, New Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 120, 230)
        e.Graphics.DrawString("Total late fine: RM" & txtTotalLateReturnFines.Text, New Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 120, 260)
        e.Graphics.DrawString("Payment: RM" & txtFinePayment.Text, New Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 120, 290)
        e.Graphics.DrawString("Balance: RM" & txtBalance.Text, New Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 120, 320)

        e.Graphics.DrawString("Date Payment: " & dtpDatePaynment.Text, New Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 120, 350)

        e.Graphics.DrawString("=======================================", New Font("Times New Roman", 24,
            FontStyle.Bold), Brushes.Black, 50, 380)

        e.Graphics.DrawString("THANK YOU FOR YOUR SINCERITY!", New Font("Times New Roman", 14,
            FontStyle.Bold), Brushes.Black, 250, 410)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBorrowerName.Clear()
        txtBorrowerIC.Clear()
        txtTotalLateReturnFines.Clear()
        txtFinePayment.Clear()
        txtBalance.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnListLateReturn_Click(sender As Object, e As EventArgs) Handles btnListLateReturn.Click
        Dim query
        query = "Select BR.BorrowerName, BRW.BorrowerIC, BR.PhoneNum, BRW.ISBN,
                 B.YearofPublication, B.Title, B.Author, B.Publisher, 
                 BRW.IssueDate, BRW.DueDate, L.LateReturnFines
                 From Book B, Borrower BR, Borrow BRW, LateReturnFines L
                 Where B.ISBN = BRW.ISBN
                 AND BRW.BorrowerIC = BR.BorrowerIC
                 AND L.BorrowID = BRW.BorrowID
                 AND L.LateReturnFines <> 0.00
                 AND L.Payment is null
                 AND L.DateofPayment is null"
        SQLCommandView(query, dgvLateReturnFine)
    End Sub

End Class