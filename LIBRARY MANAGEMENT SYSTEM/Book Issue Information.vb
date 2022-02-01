Imports System.Data.SqlClient
Public Class BookIssueInformation
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")
    'to select borrower name from data
    'to make user select their name in the combo box before borrow any book
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
    'to show the borrower name in the text box after user select their name
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
    'to find list of borrower
    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        PutBorrowerName()
        txtBorrower.Clear()
        MyMessageBox.ShowMessage(cboBorrower.Items.Count & " Borrower found!")
        btnAdd.Visible = True
    End Sub

    Private Sub cboBorrower_SelecttionChangeCommitted(sender As Object, e As EventArgs) Handles cboBorrower.SelectionChangeCommitted
        GetBorrowerName()
    End Sub
    'to fisplay list of books from database into data grid view
    Private Sub DisplayBook()

        Try
            Dim query = "select * from Book"
            SQLCommandView(query, dgvBookIssue)
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    'to display the header of book information from database into data grid view
    Private Sub DisplayHeader()
        Dim query = "select * from Book where ISBN is null"
        SQLCommandView(query, dgvBookIssue)
        dgvBookIssue().Columns(1).HeaderText = "Year"
    End Sub
    Dim key = 0
    'store information of primary key of the current selected row
    Private Sub DataGridViewListofBook_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBookIssue.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBookIssue.Rows(e.RowIndex)

            txtISBN.Text = row.Cells(0).Value.ToString
            txtBookTitle.Text = row.Cells(2).Value.ToString

            key = Convert.ToInt64(row.Cells(0).Value.ToString)

        End If
    End Sub
    'to display the list of book from database into data grid view
    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        DisplayBook()
    End Sub
    Private Sub BookIssueInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayHeader()
        dtpIssueDate.Format = DateTimePickerFormat.Custom
        dtpIssueDate.CustomFormat = "yyyy-MM-dd" 'to set the format of date to year month day e.g 2021-05-10
        dtpDueDate.Format = DateTimePickerFormat.Custom
        dtpDueDate.CustomFormat = "yyyy-MM-dd"
        dtpDueDate.Value = DateTime.Now.AddDays(+7)
    End Sub
    'to redirect the user to borrower information if they cannot find their name in the combo box
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        BorrowerInformation.ShowDialog()
    End Sub
    'to redirect to menu list page
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
    Dim intBorrowID As Integer
    'to get borrow id
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
    'to issue the book the user borrow
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
    'to get borrower ic from data
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
    'to validate text boxes if the text boxes is blank
    Private Function ValidateTextBoxes() As Boolean
        If txtBorrower.Text = "" Or txtISBN.Text = "" Or txtBookTitle.Text = "" Or cboBorrower.SelectedIndex = Nothing Then
            MyMessageBox.ShowMessage("Missing Information")
            txtISBN.Focus()
            Return False
        End If
        Return True
    End Function

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
                dtpDueDate.Focus()
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