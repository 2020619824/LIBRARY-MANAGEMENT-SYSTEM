Imports System.Data.SqlClient
Public Class BookReturnInformation

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    Private Sub FillBorrowerName()
        Try
            Con.Open()
            Dim query = "select Distinct BW.BorrowerName
                    from Borrow B, Borrower BW
                    where B.BorrowerIC = BW.BorrowerIC
                    and B.ReturnDate is null"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim tbl = New DataTable()
            adapter.Fill(tbl)
            cboBorrowerName.DataSource = tbl
            cboBorrowerName.DisplayMember = "BorrowerName"
            cboBorrowerName.ValueMember = "BorrowerName"
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub GetBorrowerName()
        Try
            Con.Open()
            Dim query = "select BorrowerName from Borrower
                    where BorrowerName='" & cboBorrowerName.SelectedValue.ToString() & "'"

            Dim cmd = New SqlCommand(query, Con)
            Dim dt = New DataTable()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                txtBorrowerName.Text = "" + reader(0).ToString
            End While
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub GetBorrowerIC()
        Try
            Con.Open()
            Dim query = "select BorrowerIC from Borrower
                    where BorrowerName='" & cboBorrowerName.SelectedValue.ToString() & "'"

            Dim cmd = New SqlCommand(query, Con)
            Dim dt = New DataTable()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                txtBorrowerIC.Text = "" + reader(0).ToString
            End While
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub DisplayBorrrowedBook()
        Try
            Dim query = "select B.ISBN, B.YearofPublication, B.Title, B.Author, B.Publisher,
                Br.IssueDate, Br.DueDate, Br.LateReturnStatus, L.LateReturnFines
                from Book B, Borrow Br, Borrower Bw, LateReturnFines L
                where B.ISBN = Br.ISBN
                and Bw.BorrowerIC = Br.BorrowerIC
                and Br.BorrowID = L.BorrowID
                and Bw.BorrowerName='" & cboBorrowerName.SelectedValue.ToString() &
                    "' and Br.ReturnDate is null"
            SQLCommandView(query, DataGridView1)
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub DisplayHeader()
        Try
            Dim query = "select B.ISBN, B.YearofPublication, B.Title, B.Author, B.Publisher,
                Br.IssueDate, Br.DueDate, Br.LateReturnStatus, L.LateReturnFines
                from Book B, Borrow Br, Borrower Bw, LateReturnFines L
                where B.ISBN = Br.ISBN
                and Bw.BorrowerIC = Br.BorrowerIC
                and Br.BorrowID = L.BorrowID
                and B.ISBN is null"
            SQLCommandView(query, DataGridView1)

            DataGridView1().Columns(2).HeaderText = "Year"
            DataGridView1().Columns(8).HeaderText = "Late Return Status"
            DataGridView1().Columns(9).HeaderText = "Late Return Fines"
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub AddColumn()
        Dim newColumn As New DataGridViewCheckBoxColumn
        newColumn.HeaderText = "Select To Return Book"
        newColumn.Name = "SelectToReturnBook"
        newColumn.Width = 80
        DataGridView1.Columns.Insert(0, newColumn)
    End Sub

    Private Sub RemoveColumn()
        DataGridView1.Columns.RemoveAt(0)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        DataGridView1.ReadOnly = False
        For Each dgvc As DataGridViewColumn In DataGridView1.Columns
            dgvc.ReadOnly = True
        Next
        DataGridView1.Columns(0).ReadOnly = False
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
        query = "update LateReturnFines set latereturnfines = 10 WHERE borrowid IN (SELECT borrowid FROM borrow WHERE latereturnstatus = 'yes')"
        SQLCommandBasic(query)

        query = "update Borrow set LateReturnStatus='No' where DueDate>='" & TodayDate() & "'"
        SQLCommandBasic(query)
        query = "update LateReturnFines set latereturnfines = 0 WHERE borrowid IN (SELECT borrowid FROM borrow WHERE latereturnstatus = 'no')"
        SQLCommandBasic(query)
    End Sub

    Public Sub LateReturn()
        Dim query = "Insert into LateReturnFines (BorrowID,LateReturnFines,Payment,DateOfPayment)
                    select BorrowID,10,null,null from borrow B where latereturnstatus = 'Yes' 
                    and Not Exists (select * from LateReturnFines L where B.BorrowID = L.BorrowID)"
        SQLCommandBasic(query)

        query = "Insert into LateReturnFines (BorrowID,LateReturnFines,Payment,DateOfPayment)
                select BorrowID,0,null,null from borrow B where latereturnstatus = 'No'
                and Not Exists (select * from LateReturnFines L where B.BorrowID = L.BorrowID)"
        SQLCommandBasic(query)
    End Sub

    Private Sub LateReturnBook()
        Dim yesDisplayed As Boolean
        yesDisplayed = False
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            If CStr(DataGridView1.Rows(i).Cells(8).Value) = "Yes" And Not (yesDisplayed) Then
                MyMessageBox.ShowMessage("You have late return fines that need to be settled")
                btnLateReturn.Visible = True
                yesDisplayed = True
            End If
        Next

        If yesDisplayed = False Then
            btnLateReturn.Visible = False
        End If
    End Sub

    Private Sub Reset()
        txtBorrowerName.Clear()
        txtBorrowerIC.Clear()
        cboBorrowerName.Text = String.Empty
        btnLateReturn.Visible = False
        Try
            Con.Open()
            Dim query = "select Distinct BW.BorrowerName
                    from Borrow B, Borrower BW
                    where B.BorrowerIC = BW.BorrowerIC
                    and BW.BorrowerIC is null"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim tbl = New DataTable()
            adapter.Fill(tbl)
            cboBorrowerName.DataSource = tbl
            cboBorrowerName.DisplayMember = "BorrowerName"
            cboBorrowerName.ValueMember = "BorrowerName"
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub BookReturnInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddColumn()
        DisplayHeader()
        LateReturnStatus()
        LateReturn()
    End Sub

    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        FillBorrowerName()
        DisplayHeader()
        txtBorrowerName.Clear()
        txtBorrowerIC.Clear()
        btnLateReturn.Visible = False
        MyMessageBox.ShowMessage(cboBorrowerName.Items.Count & " Borrower found!")
    End Sub

    Private Sub cboBorrowerName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBorrowerName.SelectionChangeCommitted
        GetBorrowerName()
        GetBorrowerIC()
        DisplayBorrrowedBook()
        LateReturnBook()
    End Sub

    Private Sub cboBorrowerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowerName.SelectedIndexChanged

    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click

        Dim query
        Dim updateMessageDisplayed As Boolean
        Dim fineMessageDisplayed As Boolean
        updateMessageDisplayed = False
        fineMessageDisplayed = False
        Dim borrowerIC = txtBorrowerIC.Text

        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            If CBool(DataGridView1.Rows(i).Cells(0).Value) = True Then
                If CStr(DataGridView1.Rows(i).Cells(8).Value) = "Yes" Then
                    If Not (fineMessageDisplayed) Then
                        MyMessageBox.ShowMessage("Please settle the fines before return it")
                        fineMessageDisplayed = True
                    End If
                Else
                    query = "update borrow set ReturnDate='" & TodayDate() & "' where ISBN=" & DataGridView1.Rows(i).Cells(1).Value.ToString &
                        " and BorrowerIC=" & borrowerIC & " and LateReturnStatus='No'"
                    SQLCommandBasic(query)
                    If (Not (updateMessageDisplayed)) Then
                        MyMessageBox.ShowMessage("Return Date Updated")
                        updateMessageDisplayed = True
                    End If
                End If
            End If
        Next

        If DataGridView1.Rows.Count <> 0 Then
            DisplayBorrrowedBook()
        End If
    End Sub

    Private Sub btnLateReturn_Click(sender As Object, e As EventArgs) Handles btnLateReturn.Click
        Reset()
        RemoveColumn()
        Me.Hide()
        LateReturnInformation.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Reset()
        RemoveColumn()
        Me.Close()
    End Sub

End Class