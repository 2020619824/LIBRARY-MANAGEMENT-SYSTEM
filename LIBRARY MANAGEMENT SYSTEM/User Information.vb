Imports System.Data
Imports System.Data.SqlClient


Public Class UserInformation
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Me.Close()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

    End Sub
    Private Sub UserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewListOfUsers.CellContentClick

    End Sub

    Private Sub cmdListOfUsers_Click(sender As Object, e As EventArgs) Handles cmdListOfUsers.Click
        Dim query = "select StaffID, StaffName, PhoneNo, Username from Users"
        SQLCommandView(query, DataGridViewListOfUsers)
    End Sub
End Class