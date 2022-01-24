
Imports System.Data.SqlClient
Public Class LateReturnInformation

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30 ")
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub DataGridViewLateReturnFine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLateReturnFine.CellContentClick

    End Sub

    Private Sub LateReturnInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query
        query = "Select BR.BorrowerName, BRW.BorrowerIC, BR.PhoneNum, BRW.ISBN,
                 B.YearofPublication, B.Title, B.Author, B.Publisher, 
                 BRW.IssueDate, BRW.DueDate, L.LateReturnFines
                 From Book B, Borrower BR, Borrow BRW, LateReturnFines L
                 Where B.ISBN = BRW.ISBN
                 AND BRW.BorrowerIC = BR.BorrowerIC
                 AND L.BorrowerIC = BR.BorrowerIC"
        SQLCommandView(query, DataGridViewLateReturnFine)

    End Sub

    Dim decSearchICNumber As Decimal
    Private Function ValidateICNumber() As Boolean
        If Not Decimal.TryParse(txtSearchLateReturnInformation.Text, decSearchICNumber) Then
            MyMessageBox.ShowMessage("Please input the IC number correctly")
            Return False
        End If
        Return True
    End Function
    Private Sub cmdSearchLateReturnFines_Click(sender As Object, e As EventArgs) Handles cmdSearchLateReturnFines.Click
        Dim strSearchBorrowerName As String


        Dim blnInvalidICNum As Boolean
        blnInvalidICNum = False

        If txtSearchLateReturnInformation.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
        Else
            Dim query = ""
            ' ada error 
            If cboSearchBy.SelectedIndex = 0 Then
                strSearchBorrowerName = txtSearchLateReturnInformation.Text
                query = "select B.BorrowerName,  L.ISBN, L.BorrowerIC, L.LateReturnFines, L.Payment, L.DateofPayment
                         from LateReturnFines L, Borrower B
                         where L.BorrowerIC = B.BorrowerIC
                         AND B.BorrowerName= " & strSearchBorrowerName & ""
                SQLCommandView(query, DataGridViewLateReturnFine)

            ElseIf cboSearchBy.SelectedIndex = 1 Then
                If ValidateICNumber() Then
                    query = "select *  from LateReturnFines where BorrowerIC =" & decSearchICNumber & ""
                    SQLCommandView(query, DataGridViewLateReturnFine)
                Else
                    blnInvalidICNum = True
                End If
            End If



            If blnInvalidICNum = False Then
                If DataGridViewLateReturnFine.Rows.Count = 0 Then
                    MyMessageBox.ShowMessage("Sorry, no information found")
                Else
                    MyMessageBox.ShowMessage(DataGridViewLateReturnFine.Rows.Count & " Information found!")
                End If
            End If

            'ClearTextBoxes()
        End If
    End Sub

    ' tak siap lagi 
    Private Sub DataGridViewLateReturnFine_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLateReturnFine.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            i = Convert.ToInt32(DataGridViewLateReturnFine.SelectedCells.Item(2).Value.ToString())
            'key = Convert.ToInt32(DataGridViewListOfUsers.SelectedCells.Item(0).Value.ToString())
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " select * from LateReturnFines where BorrowerIC = " & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                txtTotalAmountLateFine.Text = dr.GetSqlDecimal(3).ToString()


            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGenerateReceipt_Click(sender As Object, e As EventArgs) Handles cmdGenerateReceipt.Click
        pdReceipt.Print()
    End Sub

    Private Sub pdReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdReceipt.PrintPage
        'e.Graphics.DrawString()
    End Sub
End Class