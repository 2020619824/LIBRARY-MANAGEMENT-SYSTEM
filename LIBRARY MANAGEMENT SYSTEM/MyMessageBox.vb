Imports System.Windows.Forms

Public Class MyMessageBox

    Public Sub ShowMessage(ByVal strMessage As String)
        lblMessage.Text = strMessage
        OK.Visible = True
        YesNo.Visible = False
        Me.ShowDialog()
    End Sub

    Public Function ShowConfirmation(ByVal strMessage As String) As DialogResult
        lblMessage.Text = strMessage
        YesNo.Visible = True
        OK.Visible = False
        Me.ShowDialog()
        Return Me.DialogResult
    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub MyMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
