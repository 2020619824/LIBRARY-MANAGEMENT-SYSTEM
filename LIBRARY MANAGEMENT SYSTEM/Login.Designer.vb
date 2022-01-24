<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGetUserName = New System.Windows.Forms.TextBox()
        Me.txtGetPassword = New System.Windows.Forms.TextBox()
        Me.txtLoginMesage = New System.Windows.Forms.TextBox()
        Me.cnbReturn = New System.Windows.Forms.Button()
        Me.lbltitleLogin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGetUserName
        '
        Me.txtGetUserName.Location = New System.Drawing.Point(157, 69)
        Me.txtGetUserName.Multiline = True
        Me.txtGetUserName.Name = "txtGetUserName"
        Me.txtGetUserName.Size = New System.Drawing.Size(593, 28)
        Me.txtGetUserName.TabIndex = 2
        '
        'txtGetPassword
        '
        Me.txtGetPassword.Location = New System.Drawing.Point(157, 115)
        Me.txtGetPassword.Multiline = True
        Me.txtGetPassword.Name = "txtGetPassword"
        Me.txtGetPassword.Size = New System.Drawing.Size(593, 28)
        Me.txtGetPassword.TabIndex = 3
        '
        'txtLoginMesage
        '
        Me.txtLoginMesage.BackColor = System.Drawing.Color.Black
        Me.txtLoginMesage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoginMesage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginMesage.ForeColor = System.Drawing.Color.White
        Me.txtLoginMesage.Location = New System.Drawing.Point(49, 151)
        Me.txtLoginMesage.Multiline = True
        Me.txtLoginMesage.Name = "txtLoginMesage"
        Me.txtLoginMesage.Size = New System.Drawing.Size(568, 43)
        Me.txtLoginMesage.TabIndex = 4
        Me.txtLoginMesage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cnbReturn
        '
        Me.cnbReturn.BackColor = System.Drawing.Color.Red
        Me.cnbReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cnbReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnbReturn.ForeColor = System.Drawing.Color.Black
        Me.cnbReturn.Location = New System.Drawing.Point(623, 169)
        Me.cnbReturn.Name = "cnbReturn"
        Me.cnbReturn.Size = New System.Drawing.Size(127, 43)
        Me.cnbReturn.TabIndex = 5
        Me.cnbReturn.Text = "Return"
        Me.cnbReturn.UseVisualStyleBackColor = False
        '
        'lbltitleLogin
        '
        Me.lbltitleLogin.AutoSize = True
        Me.lbltitleLogin.BackColor = System.Drawing.Color.Black
        Me.lbltitleLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitleLogin.ForeColor = System.Drawing.Color.White
        Me.lbltitleLogin.Location = New System.Drawing.Point(29, 23)
        Me.lbltitleLogin.Name = "lbltitleLogin"
        Me.lbltitleLogin.Size = New System.Drawing.Size(518, 24)
        Me.lbltitleLogin.TabIndex = 6
        Me.lbltitleLogin.Text = "Welcome, Please enter your Username and Password."
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(779, 244)
        Me.Controls.Add(Me.lbltitleLogin)
        Me.Controls.Add(Me.cnbReturn)
        Me.Controls.Add(Me.txtLoginMesage)
        Me.Controls.Add(Me.txtGetPassword)
        Me.Controls.Add(Me.txtGetUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGetUserName As TextBox
    Friend WithEvents txtGetPassword As TextBox
    Friend WithEvents txtLoginMesage As TextBox
    Friend WithEvents cnbReturn As Button
    Friend WithEvents lbltitleLogin As Label
End Class
