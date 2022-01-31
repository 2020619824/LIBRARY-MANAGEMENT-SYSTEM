Imports System.Data.SqlClient
Public Class BookIssueInformation
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")
    Public Sub PutBorrowerName()

        Try
            con.Open()
            Dim query = "select BorrowerName From Borrower"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, con)
            adapter = New SqlDataAdapter(cmd)
            Dim tbl = New DataTable()
            adapter.Fill(tbl)
            cboBorrower.DataSource = tbl
            cboBorrower.DisplayMember = "BorrowerName"
            cboBorrower.ValueMember = "BorrowerName"
            con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Public Sub GetBorrowerName()

        Try
            con.Open()
            Dim query = "select BorrowerName from Borrower
                    where BorrowerName='" & cboBorrower.SelectedValue.ToString() & "'"

            Dim cmd = New SqlCommand(query, con)
            Dim dt = New DataTable()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                txtBorrower.Text = "" + reader(0).ToString
            End While
            con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        PutBorrowerName()
        txtBorrower.Clear()
        MyMessageBox.ShowMessage(cboBorrower.Items.Count & " Borrower found!")
        btnAdd.Visible = True
    End Sub

    Private Sub cboBorrower_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrower.SelectionChangeCommitted
        GetBorrowerName()
    End Sub
    Private Sub DisplayBook()

        Try
            Dim query = "select * from Book"
            SQLCommandView(query, dgvBookIssue)
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Private Sub DisplayHeader()
        Dim query = "select * from Book where ISBN is null"
        SQLCommandView(query, dgvBookIssue)
        dgvBookIssue().Columns(1).HeaderText = "Year"
    End Sub
    Dim key = 0
    Private Sub DataGridViewListofBook_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBookIssue.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBookIssue.Rows(e.RowIndex)

            txtISBN.Text = row.Cells(0).Value.ToString
            txtBookTitle.Text = row.Cells(2).Value.ToString

            key = Convert.ToInt64(row.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        DisplayBook()
    End Sub

    Private Sub BookIssueInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayHeader()
        dtpIssueDate.Format = DateTimePickerFormat.Custom
        dtpIssueDate.CustomFormat = "yyyy-MM-dd"
        dtpDueDate.Format = DateTimePickerFormat.Custom
        dtpDueDate.CustomFormat = "yyyy-MM-dd"
        dtpDueDate.Value = DateTime.Now.AddDays(+7)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        BorrowerInformation.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
    Dim intBorrowID As Integer
    Private Sub GetBorrowID()

        Try
            con.Open()
            Dim query = "select Max(BorrowID) as lastID from Borrow"

            Dim cmd = New SqlCommand(query, con)
            Dim dt = New DataTable()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                intBorrowID = CInt("" + reader(0).ToString)
            End While
            con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click

        If ValidateDueDate() Then
            GetBorrowID()
            GetBorrowerIC()
            Dim query = "Insert into borrow values (" & (intBorrowID + 1) & "," & txtISBN.Text & "," &
                intBorrowerIC & ",'" & dtpIssueDate.Text & "','" & dtpDueDate.Text & "', null, 'No')"
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("Book has been issued")
        End If
    End Sub
    Dim intBorrowerIC As Integer
    Private Sub GetBorrowerIC()

        Try
            con.Open()
            Dim query = "select BorrowerIC from Borrower
                    where BorrowerName='" & cboBorrower.SelectedValue.ToString() & "'"

            Dim cmd = New SqlCommand(query, con)
            Dim dt = New DataTable()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                intBorrowerIC = CInt("" + reader(0).ToString)
            End While
            con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Private Function ValidateTextBoxes() As Boolean
        If txtBorrower.Text = "" Or txtISBN.Text = "" Or txtBookTitle.Text = "" Or cboBorrower_SelectedIndex() = Nothing Then
            MyMessageBox.ShowMessage("Missing Information")
            txtISBN.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub LateReturnStatus()
        Dim query = "update Borrow set LateReturnStatus='Yes' where DueDate<'" & TodayDate() & "'"
        SQLCommandBasic(query)

        query = "update latereturnfines set latereturnfines.latereturnfines = Datesiff(day,borrow.DueDate,GateDate())
                 from latereturnfines inner join borrow on latereturnfines.BorrowID = borrow.BorrowID
                 where borrow.latereturnstatus = 'yes'"
        SQLCommandBasic(query)

        query = "update Borrow set LateReturnStatus='No' where DueDate>='" & TodayDate() & "'"
        SQLCommandBasic(query)

        query = "update LateReturnFines set latereturnfines = 0 WHERE borrowid IN (SELECT borrowid FROM borrow WHERE latereturnstatus = 'no')"
        SQLCommandBasic(query)
    End Sub
    Public Sub LateReturn()
        Dim query = "Insert into LateReturnFines (BorrowID, LateReturn, payment, DateOfPayment)
                     select BorrowID,Datediff(day, DueDate," & TodayDate() & "), null, null from borrow B where latereturnstatus = 'Yes'
                     and Not Exists (select * from LateReturnFines L where B.BorrowID = L.BorrowID)"
        SQLCommandBasic(query)

        query = "Insert into LateReturnFines (BorrowID, LateReturnFines, payment, DateOfPayment)
                 select BorrowID, 0, null, null from borrow B where latereturnstatus = 'No'
                 and Not Exists (select * from LateReturnFines L where B.BorrowID = L.BorrowID)"
        SQLCommandBasic(query)
    End Sub
    Private Sub BookIssueInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LateReturnStatus()
        LateReturn()
    End Sub
    Private Function ValidateDueDate() As Boolean
        Dim dtIssueDate As Date
        Dim dtDueDate As Date
        Dim intDiffDay As Integer

        If ValidateTextBoxes() Then
            dtIssueDate = Date.Parse(dtpIssueDate.Text)
            dtDueDate = Date.Parse(dtpDueDate.Text)
            intDiffDay = DateDiff(DateInterval.Day, dtIssueDate, dtDueDate)

            If intDiffDay < 0 Then
                MyMessageBox.ShowMessage("Invalid Due Date")
                Return False
            End If
            Return True
        End If
        Return False
    End Function
    Private Sub dtpIssueDate_CloseUp(sender As Object, e As EventArgs) Handles dtpIssueDate.CloseUp
        dtpDueDate.Value = dtpIssueDate.Value.AddDays(+7)
    End Sub

End Class