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
        Me.txtCurrentUser = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDisplayUser = New System.Windows.Forms.Button()
        Me.btnDisplayBookDetails = New System.Windows.Forms.Button()
        Me.btnDisplayBorrowers = New System.Windows.Forms.Button()
        Me.btnDisplayBookReturn = New System.Windows.Forms.Button()
        Me.btnBookIssue = New System.Windows.Forms.Button()
        Me.btnDisplayLateReturn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picLibraryLogo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picLibraryLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.txtCurrentUser)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 591)
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
        Me.txtTime.BackColor = System.Drawing.Color.Black
        Me.txtTime.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.White
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
        Me.txtDate.BackColor = System.Drawing.Color.Black
        Me.txtDate.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
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
        'txtCurrentUser
        '
        Me.txtCurrentUser.BackColor = System.Drawing.Color.Black
        Me.txtCurrentUser.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentUser.ForeColor = System.Drawing.Color.White
        Me.txtCurrentUser.Location = New System.Drawing.Point(24, 104)
        Me.txtCurrentUser.Name = "txtCurrentUser"
        Me.txtCurrentUser.Size = New System.Drawing.Size(139, 27)
        Me.txtCurrentUser.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(24, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 46)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDisplayUser
        '
        Me.btnDisplayUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDisplayUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisplayUser.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayUser.ForeColor = System.Drawing.Color.White
        Me.btnDisplayUser.Image = CType(resources.GetObject("btnDisplayUser.Image"), System.Drawing.Image)
        Me.btnDisplayUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDisplayUser.Location = New System.Drawing.Point(1, 3)
        Me.btnDisplayUser.Name = "btnDisplayUser"
        Me.btnDisplayUser.Size = New System.Drawing.Size(93, 36)
        Me.btnDisplayUser.TabIndex = 2
        Me.btnDisplayUser.Text = "User"
        Me.btnDisplayUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDisplayUser.UseVisualStyleBackColor = False
        '
        'btnDisplayBookDetails
        '
        Me.btnDisplayBookDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDisplayBookDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisplayBookDetails.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayBookDetails.ForeColor = System.Drawing.Color.White
        Me.btnDisplayBookDetails.Image = CType(resources.GetObject("btnDisplayBookDetails.Image"), System.Drawing.Image)
        Me.btnDisplayBookDetails.Location = New System.Drawing.Point(250, 3)
        Me.btnDisplayBookDetails.Name = "btnDisplayBookDetails"
        Me.btnDisplayBookDetails.Size = New System.Drawing.Size(171, 36)
        Me.btnDisplayBookDetails.TabIndex = 3
        Me.btnDisplayBookDetails.Text = "Book Details"
        Me.btnDisplayBookDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDisplayBookDetails.UseVisualStyleBackColor = False
        '
        'btnDisplayBorrowers
        '
        Me.btnDisplayBorrowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDisplayBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisplayBorrowers.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayBorrowers.ForeColor = System.Drawing.Color.White
        Me.btnDisplayBorrowers.Image = CType(resources.GetObject("btnDisplayBorrowers.Image"), System.Drawing.Image)
        Me.btnDisplayBorrowers.Location = New System.Drawing.Point(577, 3)
        Me.btnDisplayBorrowers.Name = "btnDisplayBorrowers"
        Me.btnDisplayBorrowers.Size = New System.Drawing.Size(163, 36)
        Me.btnDisplayBorrowers.TabIndex = 4
        Me.btnDisplayBorrowers.Text = "Borrowers"
        Me.btnDisplayBorrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDisplayBorrowers.UseVisualStyleBackColor = False
        '
        'btnDisplayBookReturn
        '
        Me.btnDisplayBookReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDisplayBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisplayBookReturn.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayBookReturn.ForeColor = System.Drawing.Color.White
        Me.btnDisplayBookReturn.Image = CType(resources.GetObject("btnDisplayBookReturn.Image"), System.Drawing.Image)
        Me.btnDisplayBookReturn.Location = New System.Drawing.Point(417, 3)
        Me.btnDisplayBookReturn.Name = "btnDisplayBookReturn"
        Me.btnDisplayBookReturn.Size = New System.Drawing.Size(163, 36)
        Me.btnDisplayBookReturn.TabIndex = 5
        Me.btnDisplayBookReturn.Text = "Book Return"
        Me.btnDisplayBookReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDisplayBookReturn.UseVisualStyleBackColor = False
        '
        'btnBookIssue
        '
        Me.btnBookIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBookIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBookIssue.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookIssue.ForeColor = System.Drawing.Color.White
        Me.btnBookIssue.Image = CType(resources.GetObject("btnBookIssue.Image"), System.Drawing.Image)
        Me.btnBookIssue.Location = New System.Drawing.Point(91, 3)
        Me.btnBookIssue.Name = "btnBookIssue"
        Me.btnBookIssue.Size = New System.Drawing.Size(163, 36)
        Me.btnBookIssue.TabIndex = 6
        Me.btnBookIssue.Text = "Book Issue"
        Me.btnBookIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBookIssue.UseVisualStyleBackColor = False
        '
        'btnDisplayLateReturn
        '
        Me.btnDisplayLateReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDisplayLateReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisplayLateReturn.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayLateReturn.ForeColor = System.Drawing.Color.White
        Me.btnDisplayLateReturn.Image = CType(resources.GetObject("btnDisplayLateReturn.Image"), System.Drawing.Image)
        Me.btnDisplayLateReturn.Location = New System.Drawing.Point(732, 3)
        Me.btnDisplayLateReturn.Name = "btnDisplayLateReturn"
        Me.btnDisplayLateReturn.Size = New System.Drawing.Size(154, 36)
        Me.btnDisplayLateReturn.TabIndex = 7
        Me.btnDisplayLateReturn.Text = "Late Return"
        Me.btnDisplayLateReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDisplayLateReturn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(259, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(366, 92)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "MENU"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLibraryLogo
        '
        Me.picLibraryLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLibraryLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLibraryLogo.Image = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.READOBRITE_PUBLIC_LOGO_3
        Me.picLibraryLogo.Location = New System.Drawing.Point(375, 105)
        Me.picLibraryLogo.Name = "picLibraryLogo"
        Me.picLibraryLogo.Size = New System.Drawing.Size(130, 131)
        Me.picLibraryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLibraryLogo.TabIndex = 9
        Me.picLibraryLogo.TabStop = False
        '
        'MenuList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 637)
        Me.Controls.Add(Me.picLibraryLogo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDisplayLateReturn)
        Me.Controls.Add(Me.btnBookIssue)
        Me.Controls.Add(Me.btnDisplayBookReturn)
        Me.Controls.Add(Me.btnDisplayBorrowers)
        Me.Controls.Add(Me.btnDisplayBookDetails)
        Me.Controls.Add(Me.btnDisplayUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picLibraryLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentUser As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDisplayUser As Button
    Friend WithEvents btnDisplayBookDetails As Button
    Friend WithEvents btnDisplayBorrowers As Button
    Friend WithEvents btnDisplayBookReturn As Button
    Friend WithEvents btnBookIssue As Button
    Friend WithEvents btnDisplayLateReturn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents picLibraryLogo As PictureBox
End Class