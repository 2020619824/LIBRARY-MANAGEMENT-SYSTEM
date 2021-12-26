Imports System.Data
Imports System.Data.SqlClient


Public Class UserInformation
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

    End Sub

    Private Sub UserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_dataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter1.Fill(Me.User_dataSet.User)
        'TODO: This line of code loads data into the 'Database1DataSet1.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.Database1DataSet1.User)

    End Sub
End Class