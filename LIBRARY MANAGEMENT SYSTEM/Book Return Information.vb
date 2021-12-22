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
        DataGridView1.ReadOnly = False
        For Each dgvc As DataGridViewColumn In DataGridView1.Columns
            dgvc.ReadOnly = True
        Next
        DataGridView1.Columns(0).ReadOnly = False
    End Sub

    Private Sub BookReturnInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddColumn()
        DataGridView1.ColumnHeadersVisible = False
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        Dim row As DataGridViewRow = DataGridView1.Rows(0)
        Dim query

        'query = "update borrow set ReturnDate='23/12/2021' where ISBN=9780439023481 and BorrowerIC=1002"
        If row.Cells(0).Value.ToString = True Then
            SQLCommandBasic(query)
        End If
    End Sub
End Class