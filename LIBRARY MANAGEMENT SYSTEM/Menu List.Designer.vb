<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdDisplayUser = New System.Windows.Forms.Button()
        Me.cmdDisplayBookDetails = New System.Windows.Forms.Button()
        Me.cmdDisplayBorrowers = New System.Windows.Forms.Button()
        Me.cmdDisplayBookReturn = New System.Windows.Forms.Button()
        Me.cmdBookIssue = New System.Windows.Forms.Button()
        Me.cmdDisplayLateReturn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 329)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login Information"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Current time :"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(21, 258)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(124, 22)
        Me.txtTime.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(18, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Current date :"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(21, 173)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(124, 22)
        Me.txtDate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current user :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 22)
        Me.TextBox1.TabIndex = 1
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(24, 378)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(168, 39)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdDisplayUser
        '
        Me.cmdDisplayUser.Location = New System.Drawing.Point(251, 27)
        Me.cmdDisplayUser.Name = "cmdDisplayUser"
        Me.cmdDisplayUser.Size = New System.Drawing.Size(166, 62)
        Me.cmdDisplayUser.TabIndex = 2
        Me.cmdDisplayUser.Text = "User"
        Me.cmdDisplayUser.UseVisualStyleBackColor = True
        '
        'cmdDisplayBookDetails
        '
        Me.cmdDisplayBookDetails.Location = New System.Drawing.Point(251, 160)
        Me.cmdDisplayBookDetails.Name = "cmdDisplayBookDetails"
        Me.cmdDisplayBookDetails.Size = New System.Drawing.Size(166, 62)
        Me.cmdDisplayBookDetails.TabIndex = 3
        Me.cmdDisplayBookDetails.Text = "Book Details"
        Me.cmdDisplayBookDetails.UseVisualStyleBackColor = True
        '
        'cmdDisplayBorrowers
        '
        Me.cmdDisplayBorrowers.Location = New System.Drawing.Point(251, 294)
        Me.cmdDisplayBorrowers.Name = "cmdDisplayBorrowers"
        Me.cmdDisplayBorrowers.Size = New System.Drawing.Size(166, 62)
        Me.cmdDisplayBorrowers.TabIndex = 4
        Me.cmdDisplayBorrowers.Text = "Borrowers"
        Me.cmdDisplayBorrowers.UseVisualStyleBackColor = True
        '
        'cmdDisplayBookReturn
        '
        Me.cmdDisplayBookReturn.Location = New System.Drawing.Point(519, 160)
        Me.cmdDisplayBookReturn.Name = "cmdDisplayBookReturn"
        Me.cmdDisplayBookReturn.Size = New System.Drawing.Size(166, 62)
        Me.cmdDisplayBookReturn.TabIndex = 5
        Me.cmdDisplayBookReturn.Text = "Book Return"
        Me.cmdDisplayBookReturn.UseVisualStyleBackColor = True
        '
        'cmdBookIssue
        '
        Me.cmdBookIssue.Location = New System.Drawing.Point(519, 27)
        Me.cmdBookIssue.Name = "cmdBookIssue"
        Me.cmdBookIssue.Size = New System.Drawing.Size(166, 62)
        Me.cmdBookIssue.TabIndex = 6
        Me.cmdBookIssue.Text = "Book Issue"
        Me.cmdBookIssue.UseVisualStyleBackColor = True
        '
        'cmdDisplayLateReturn
        '
        Me.cmdDisplayLateReturn.Location = New System.Drawing.Point(519, 294)
        Me.cmdDisplayLateReturn.Name = "cmdDisplayLateReturn"
        Me.cmdDisplayLateReturn.Size = New System.Drawing.Size(166, 62)
        Me.cmdDisplayLateReturn.TabIndex = 7
        Me.cmdDisplayLateReturn.Text = "Late Return"
        Me.cmdDisplayLateReturn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'MenuList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 450)
        Me.Controls.Add(Me.cmdDisplayLateReturn)
        Me.Controls.Add(Me.cmdBookIssue)
        Me.Controls.Add(Me.cmdDisplayBookReturn)
        Me.Controls.Add(Me.cmdDisplayBorrowers)
        Me.Controls.Add(Me.cmdDisplayBookDetails)
        Me.Controls.Add(Me.cmdDisplayUser)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MenuList"
        Me.Text = "Menu List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdDisplayUser As Button
    Friend WithEvents cmdDisplayBookDetails As Button
    Friend WithEvents cmdDisplayBorrowers As Button
    Friend WithEvents cmdDisplayBookReturn As Button
    Friend WithEvents cmdBookIssue As Button
    Friend WithEvents cmdDisplayLateReturn As Button
    Friend WithEvents Timer1 As Timer
End Class
