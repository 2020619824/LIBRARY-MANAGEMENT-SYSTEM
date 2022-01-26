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
            SQLCommandView(query, dgvBookReturnInfo)
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
            SQLCommandView(query, dgvBookReturnInfo)

            dgvBookReturnInfo().Columns(2).HeaderText = "Year"
            dgvBookReturnInfo().Columns(8).HeaderText = "Late Return Status"
            dgvBookReturnInfo().Columns(9).HeaderText = "Late Return Fines"
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub AddColumn()
        Dim newColumn As New DataGridViewCheckBoxColumn
        newColumn.HeaderText = "Select To Return Book"
        newColumn.Name = "SelectToReturnBook"
        newColumn.Width = 80
        dgvBookReturnInfo.Columns.Insert(0, newColumn)
    End Sub

    Private Sub RemoveColumn()
        dgvBookReturnInfo.Columns.RemoveAt(0)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles dgvBookReturnInfo.Click

        dgvBookReturnInfo.ReadOnly = False
        For Each dgvc As DataGridViewColumn In dgvBookReturnInfo.Columns
            dgvc.ReadOnly = True
        Next
        dgvBookReturnInfo.Columns(0).ReadOnly = False
    End Sub

    Private Sub LateReturnBook()
        Dim blnYesDisplayed As Boolean
        blnYesDisplayed = False
        Dim i As Integer
        For i = 0 To dgvBookReturnInfo.Rows.Count - 1
            If CStr(dgvBookReturnInfo.Rows(i).Cells(8).Value) = "Yes" And Not (blnYesDisplayed) Then
                MyMessageBox.ShowMessage("You have late return fines that need to be settled")
                btnLateReturn.Visible = True
                blnYesDisplayed = True
            End If
        Next

        If blnYesDisplayed = False Then
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

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click

        Dim query
        Dim blnUpdateMessageDisplayed As Boolean
        Dim blnFineMessageDisplayed As Boolean
        blnUpdateMessageDisplayed = False
        blnFineMessageDisplayed = False
        Dim borrowerIC = txtBorrowerIC.Text

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
                        " and BorrowerIC=" & borrowerIC & " and LateReturnStatus='No'"
                    SQLCommandBasic(query)
                    If (Not (blnUpdateMessageDisplayed)) Then
                        MyMessageBox.ShowMessage("Return Date Updated")
                        blnUpdateMessageDisplayed = True
                    End If
                End If
            End If
        Next

        If dgvBookReturnInfo.Rows.Count <> 0 Then
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