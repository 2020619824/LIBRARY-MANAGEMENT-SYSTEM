<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuList))
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 597)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login Information"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Current time :"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(24, 290)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(139, 27)
        Me.txtTime.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Current date :"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(24, 195)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(139, 27)
        Me.txtDate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current user :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 27)
        Me.TextBox1.TabIndex = 1
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(24, 390)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(139, 46)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdDisplayUser
        '
        Me.cmdDisplayUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDisplayUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDisplayUser.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisplayUser.ForeColor = System.Drawing.Color.White
        Me.cmdDisplayUser.Image = CType(resources.GetObject("cmdDisplayUser.Image"), System.Drawing.Image)
        Me.cmdDisplayUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdDisplayUser.Location = New System.Drawing.Point(1, 3)
        Me.cmdDisplayUser.Name = "cmdDisplayUser"
        Me.cmdDisplayUser.Size = New System.Drawing.Size(93, 36)
        Me.cmdDisplayUser.TabIndex = 2
        Me.cmdDisplayUser.Text = "User"
        Me.cmdDisplayUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDisplayUser.UseVisualStyleBackColor = False
        '
        'cmdDisplayBookDetails
        '
        Me.cmdDisplayBookDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDisplayBookDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDisplayBookDetails.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisplayBookDetails.ForeColor = System.Drawing.Color.White
        Me.cmdDisplayBookDetails.Image = CType(resources.GetObject("cmdDisplayBookDetails.Image"), System.Drawing.Image)
        Me.cmdDisplayBookDetails.Location = New System.Drawing.Point(250, 3)
        Me.cmdDisplayBookDetails.Name = "cmdDisplayBookDetails"
        Me.cmdDisplayBookDetails.Size = New System.Drawing.Size(171, 36)
        Me.cmdDisplayBookDetails.TabIndex = 3
        Me.cmdDisplayBookDetails.Text = "Book Details"
        Me.cmdDisplayBookDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDisplayBookDetails.UseVisualStyleBackColor = False
        '
        'cmdDisplayBorrowers
        '
        Me.cmdDisplayBorrowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDisplayBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDisplayBorrowers.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisplayBorrowers.ForeColor = System.Drawing.Color.White
        Me.cmdDisplayBorrowers.Image = CType(resources.GetObject("cmdDisplayBorrowers.Image"), System.Drawing.Image)
        Me.cmdDisplayBorrowers.Location = New System.Drawing.Point(723, 3)
        Me.cmdDisplayBorrowers.Name = "cmdDisplayBorrowers"
        Me.cmdDisplayBorrowers.Size = New System.Drawing.Size(163, 36)
        Me.cmdDisplayBorrowers.TabIndex = 4
        Me.cmdDisplayBorrowers.Text = "Borrowers"
        Me.cmdDisplayBorrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDisplayBorrowers.UseVisualStyleBackColor = False
        '
        'cmdDisplayBookReturn
        '
        Me.cmdDisplayBookReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDisplayBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDisplayBookReturn.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisplayBookReturn.ForeColor = System.Drawing.Color.White
        Me.cmdDisplayBookReturn.Image = CType(resources.GetObject("cmdDisplayBookReturn.Image"), System.Drawing.Image)
        Me.cmdDisplayBookReturn.Location = New System.Drawing.Point(568, 3)
        Me.cmdDisplayBookReturn.Name = "cmdDisplayBookReturn"
        Me.cmdDisplayBookReturn.Size = New System.Drawing.Size(163, 36)
        Me.cmdDisplayBookReturn.TabIndex = 5
        Me.cmdDisplayBookReturn.Text = "Book Return"
        Me.cmdDisplayBookReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDisplayBookReturn.UseVisualStyleBackColor = False
        '
        'cmdBookIssue
        '
        Me.cmdBookIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdBookIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBookIssue.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBookIssue.ForeColor = System.Drawing.Color.White
        Me.cmdBookIssue.Image = CType(resources.GetObject("cmdBookIssue.Image"), System.Drawing.Image)
        Me.cmdBookIssue.Location = New System.Drawing.Point(91, 3)
        Me.cmdBookIssue.Name = "cmdBookIssue"
        Me.cmdBookIssue.Size = New System.Drawing.Size(163, 36)
        Me.cmdBookIssue.TabIndex = 6
        Me.cmdBookIssue.Text = "Book Issue"
        Me.cmdBookIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdBookIssue.UseVisualStyleBackColor = False
        '
        'cmdDisplayLateReturn
        '
        Me.cmdDisplayLateReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDisplayLateReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDisplayLateReturn.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisplayLateReturn.ForeColor = System.Drawing.Color.White
        Me.cmdDisplayLateReturn.Image = CType(resources.GetObject("cmdDisplayLateReturn.Image"), System.Drawing.Image)
        Me.cmdDisplayLateReturn.Location = New System.Drawing.Point(419, 3)
        Me.cmdDisplayLateReturn.Name = "cmdDisplayLateReturn"
        Me.cmdDisplayLateReturn.Size = New System.Drawing.Size(154, 36)
        Me.cmdDisplayLateReturn.TabIndex = 7
        Me.cmdDisplayLateReturn.Text = "Late Return"
        Me.cmdDisplayLateReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDisplayLateReturn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(247, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(394, 92)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "MENU"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 637)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdDisplayLateReturn)
        Me.Controls.Add(Me.cmdBookIssue)
        Me.Controls.Add(Me.cmdDisplayBookReturn)
        Me.Controls.Add(Me.cmdDisplayBorrowers)
        Me.Controls.Add(Me.cmdDisplayBookDetails)
        Me.Controls.Add(Me.cmdDisplayUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents Label4 As Label
End Class
