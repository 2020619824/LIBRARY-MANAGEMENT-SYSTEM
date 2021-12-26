Public Class LateReturnInformation
    Private Sub DataGridViewLateReturnFine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLateReturnFine.CellContentClick

    End Sub

    Private Sub LateReturnInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query
        query = "Select BR.BorrowerName, BRW.BorrowerIC, BR.PhoneNum, BRW.ISBN,
                 B.YearofPublication, B.Title, B.Author, B.Publisher, 
                 BRW.IssueDate, BRW.DueDate
                 From Book B, Borrower BR, Borrow BRW
                 Where B.ISBN = BRW.ISBN
                 AND BRW.BorrowerIC = BR.BorrowerIC"
        SQLCommandView(query, DataGridViewLateReturnFine)

    End Sub
End Class