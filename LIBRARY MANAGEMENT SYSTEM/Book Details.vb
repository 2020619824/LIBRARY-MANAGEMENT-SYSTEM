Imports System.Data.SqlClient
Public Class BookDetails
    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'List_Book_Details.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.List_Book_Details.Book)

    End Sub

    Dim Con As New SqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BookBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.BookBindingSource.EndEdit()
        Me.BookTableAdapter.Update(Me.List_Book_Details)
        If 
    End Sub
End Class