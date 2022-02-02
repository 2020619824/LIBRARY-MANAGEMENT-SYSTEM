Imports System.Data.SqlClient
Public Class BookReturnInformation

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    ' To add all Borrowers' name that has already borrow at least one Book into ComboBox
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

    ' To get and display Borrower's name that is currently being selected
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

    ' To get and display Borrower's IC that is currently being selected
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

    ' To display all Borrows' information for the current Borrower from Database into DataGridView
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
            SQLCommandView(query, dgvBookReturnInfo)
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    ' To display the header of borrow's information from Database into DataGridView
    Private Sub DisplayHeader()
        Try
            Dim query = "select B.ISBN, B.YearofPublication, B.Title, B.Author, B.Publisher,
                Br.IssueDate, Br.DueDate, Br.LateReturnStatus, L.LateReturnFines
                from Book B, Borrow Br, Borrower Bw, LateReturnFines L
                where B.ISBN = Br.ISBN
                and Bw.BorrowerIC = Br.BorrowerIC
                and Br.BorrowID = L.BorrowID
                and B.ISBN is null"
            SQLCommandView(query, dgvBookReturnInfo)

            ' Rename the headers
            dgvBookReturnInfo().Columns(2).HeaderText = "Year"
            dgvBookReturnInfo().Columns(8).HeaderText = "Late Return Status"
            dgvBookReturnInfo().Columns(9).HeaderText = "Late Return Fines"
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    ' To add new column with CheckBoxes
    Private Sub AddColumn()
        Dim newColumn As New DataGridViewCheckBoxColumn
        newColumn.HeaderText = "Select To Return Book"
        newColumn.Name = "SelectToReturnBook"
        newColumn.Width = 80
        dgvBookReturnInfo.Columns.Insert(0, newColumn)
    End Sub

    ' To remove the CheckBoxes column
    Private Sub RemoveColumn()
        dgvBookReturnInfo.Columns.RemoveAt(0)
    End Sub

    ' To only enable edit for column with CheckBoxes
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles dgvBookReturnInfo.Click

        dgvBookReturnInfo.ReadOnly = False
        For Each dgvc As DataGridViewColumn In dgvBookReturnInfo.Columns
            dgvc.ReadOnly = True
        Next
        dgvBookReturnInfo.Columns(0).ReadOnly = False
    End Sub

    Private Sub LateReturnBook()
        Dim blnYesDisplayed As Boolean 'Flag to indicate the message will only be displayed once
        blnYesDisplayed = False

        ' Check if there any book that want to be returned has a late return fine
        Dim i As Integer
        For i = 0 To dgvBookReturnInfo.Rows.Count - 1
            If CStr(dgvBookReturnInfo.Rows(i).Cells(8).Value) = "Yes" And Not (blnYesDisplayed) Then
                MyMessageBox.ShowMessage("You have late return fines that need to be settled")
                btnLateReturn.Visible = True 'Reveal the btnLateReturn that will redirect the user to Late Return Information Page
                blnYesDisplayed = True
            End If
        Next

        If blnYesDisplayed = False Then
            btnLateReturn.Visible = False 'Hide the btnLateReturn that will redirect the user to Late Return Information Page
        End If
    End Sub

    ' To clear/reset all displayed information
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

        LateReturnStatus() 'invoke method in module CommandSQL
        LateReturn() 'invoke method in module CommandSQL
    End Sub

    ' To search Borrower's details based on their name and will be displayed into ComboBox
    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        FillBorrowerName()
        DisplayHeader()
        txtBorrowerName.Clear()
        txtBorrowerIC.Clear()
        btnLateReturn.Visible = False
        MyMessageBox.ShowMessage(cboBorrowerName.Items.Count & " Borrower found!")
    End Sub

    ' To show all borrow's details of current selected Borrower
    Private Sub cboBorrowerName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBorrowerName.SelectionChangeCommitted
        GetBorrowerName()
        GetBorrowerIC()
        DisplayBorrrowedBook()
        LateReturnBook()
    End Sub

    ' To update the return date of selected Books that has been returned
    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click

        Dim query
        Dim blnUpdateMessageDisplayed As Boolean 'Flag to indicate the message will only be displayed once
        Dim blnFineMessageDisplayed As Boolean 'Flag to indicate the message will only be displayed once
        blnUpdateMessageDisplayed = False
        blnFineMessageDisplayed = False

        ' Check if the selected Book can be returned or not
        Dim i As Integer
        For i = 0 To dgvBookReturnInfo.Rows.Count - 1
            If CBool(dgvBookReturnInfo.Rows(i).Cells(0).Value) = True Then
                If CStr(dgvBookReturnInfo.Rows(i).Cells(8).Value) = "Yes" Then
                    If Not (blnFineMessageDisplayed) Then
                        MyMessageBox.ShowMessage("Please settle the fines before return it")
                        blnFineMessageDisplayed = True
                    End If
                Else
                    query = "update borrow set ReturnDate='" & TodayDate() & "' where ISBN=" & dgvBookReturnInfo.Rows(i).Cells(1).Value.ToString &
                            " and BorrowerIC=" & txtBorrowerIC.Text & " and LateReturnStatus='No'"
                    SQLCommandBasic(query)
                    If (Not (blnUpdateMessageDisplayed)) Then
                        MyMessageBox.ShowMessage("The Book Has Been Returned" & ControlChars.CrLf & "Thank You!")
                        blnUpdateMessageDisplayed = True
                    End If
                End If
            End If
        Next

        If dgvBookReturnInfo.Rows.Count <> 0 Then
            DisplayBorrrowedBook()
        End If
    End Sub

    ' To redirect the user to Late Return Information Page
    Private Sub btnLateReturn_Click(sender As Object, e As EventArgs) Handles btnLateReturn.Click
        Reset()
        RemoveColumn()
        Me.Hide()
        LateReturnInformation.ShowDialog()
    End Sub

    ' To redirect the user to Menu List Page
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Reset()
        RemoveColumn()
        Me.Close()
    End Sub
End Class