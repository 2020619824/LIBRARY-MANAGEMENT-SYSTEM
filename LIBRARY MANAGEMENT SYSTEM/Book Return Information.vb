Imports System.Data.SqlClient
Public Class BookReturnInformation
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\CS110\SEMESTER 3\CSC301\GROUP PROJECT\PROJECT\LIBRARY MANAGEMENT SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    Private Sub FillBorrowerName()
        Con.Open()
        Dim query = "select Distinct BW.BorrowerName
                    from Borrow B, Borrower BW
                    where B.BorrowerIC = BW.BorrowerIC"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim tbl = New DataTable()
        adapter.Fill(tbl)
        cboBorrowerName.DataSource = tbl
        cboBorrowerName.DisplayMember = "BorrowerName"
        cboBorrowerName.ValueMember = "BorrowerName"
        Con.Close()
    End Sub

    Private Sub GetBorrowerName()
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
    End Sub

    Private Sub GetBorrowerIC()
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
    End Sub

    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        FillBorrowerName()
        DataGridView1.ColumnHeadersVisible = True
    End Sub

    Private Sub cboBorrowerName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBorrowerName.SelectionChangeCommitted
        GetBorrowerName()
        GetBorrowerIC()
    End Sub

    Private Sub cboBorrowerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowerName.SelectedIndexChanged
        Dim query
        query = "select B.ISBN, B.YearofPublication, B.Title, B.Author, B.Publisher,
                Br.IssueDate, Br.DueDate, Br.LateReturnStatus
                from Book B, Borrow Br, Borrower Bw
                where B.ISBN = Br.ISBN
                and Bw.BorrowerIC = Br.BorrowerIC
                and Bw.BorrowerName='" & cboBorrowerName.SelectedValue.ToString() & "'"

        SQLCommandView(query, DataGridView1)

    End Sub

    Private Sub AddColumn()
        Dim newColumn As New DataGridViewCheckBoxColumn
        newColumn.HeaderText = "Select To Return Book"
        newColumn.Name = "SelectToReturnBook"
        newColumn.Width = 80
        DataGridView1.Columns.Insert(0, newColumn)

    End Sub

    Private Sub BookReturnInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnHeadersVisible = False
        AddColumn()
    End Sub

    Dim key = 0
    Dim ISBN = 0
    Private Sub DataGridViewListofBook_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            'Dim chkC As DataGridViewCheckBoxColumn = DataGridView1.Columns(e.ColumnIndex)

            'DataGridView1.SelectedCells = row.Cells(0).Value.ToString
            ISBN = row.Cells(1).Value.ToString

            'key = Convert.ToBoolean(row.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click

        Dim query

        'SQL Date Format: YYYYMMDD
        Dim dateSQLFormat = Date.Today.Year.ToString
        dateSQLFormat += Date.Today.Month.ToString
        dateSQLFormat += Date.Today.Day.ToString

        Dim borrowerIC = txtBorrowerIC.Text
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            If CBool(DataGridView1.Rows(i).Cells(0).Value) = True Then
                query = "update borrow set ReturnDate='" & dateSQLFormat & "' where ISBN=" & DataGridView1.Rows(i).Cells(1).Value.ToString & " and BorrowerIC=" & borrowerIC & ""
                SQLCommandBasic(query)
                MsgBox("Return Date Updated")
            End If
        Next
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        DataGridView1.ReadOnly = False
        For Each dgvc As DataGridViewColumn In DataGridView1.Columns
            dgvc.ReadOnly = True
        Next
        DataGridView1.Columns(0).ReadOnly = False
    End Sub
End Class