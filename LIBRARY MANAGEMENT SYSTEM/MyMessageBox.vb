Imports System.Windows.Forms

' A Custom-Made MessageBox
Public Class MyMessageBox
    ' To show a simple message to the user with OK button
    Public Sub ShowMessage(ByVal strMessage As String)
        lblMessage.Text = strMessage
        tlpOK.Visible = True
        tlpYesNo.Visible = False
        Me.ShowDialog()
    End Sub

    ' To show a message to get a confirmation from the user with Yes and No buttons
    Public Function ShowConfirmation(ByVal strMessage As String) As DialogResult
        lblMessage.Text = strMessage
        tlpYesNo.Visible = True
        tlpOK.Visible = False
        Me.ShowDialog()
        Return Me.DialogResult
    End Function

    ' To return the Dialog Result as OK and close the MessageBox 
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ' To return the Dialog Result as Yes and close the MessageBox 
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    ' To return the Dialog Result as No and close the MessageBox 
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
End Class