<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyMessageBox
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
        Me.OK = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.YesNo = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.picLibraryLogo = New System.Windows.Forms.PictureBox()
        Me.OK.SuspendLayout()
        Me.YesNo.SuspendLayout()
        CType(Me.picLibraryLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.BackColor = System.Drawing.Color.Transparent
        Me.OK.ColumnCount = 1
        Me.OK.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.OK.Controls.Add(Me.btnOK, 0, 0)
        Me.OK.Location = New System.Drawing.Point(281, 109)
        Me.OK.Margin = New System.Windows.Forms.Padding(4)
        Me.OK.Name = "OK"
        Me.OK.RowCount = 1
        Me.OK.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.OK.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OK.Size = New System.Drawing.Size(102, 36)
        Me.OK.TabIndex = 0
        Me.OK.Visible = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.BackColor = System.Drawing.Color.Black
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(6, 4)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(89, 28)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.Font = New System.Drawing.Font("Arial Narrow", 13.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(158, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(229, 96)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = """Message"""
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesNo
        '
        Me.YesNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YesNo.BackColor = System.Drawing.Color.Transparent
        Me.YesNo.ColumnCount = 2
        Me.YesNo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.YesNo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.YesNo.Controls.Add(Me.btnNo, 0, 0)
        Me.YesNo.Controls.Add(Me.btnYes, 0, 0)
        Me.YesNo.Location = New System.Drawing.Point(170, 109)
        Me.YesNo.Margin = New System.Windows.Forms.Padding(4)
        Me.YesNo.Name = "YesNo"
        Me.YesNo.RowCount = 1
        Me.YesNo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.YesNo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.YesNo.Size = New System.Drawing.Size(206, 36)
        Me.YesNo.TabIndex = 3
        Me.YesNo.Visible = False
        '
        'btnNo
        '
        Me.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNo.BackColor = System.Drawing.Color.Black
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNo.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.White
        Me.btnNo.Location = New System.Drawing.Point(110, 4)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(89, 28)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'btnYes
        '
        Me.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnYes.BackColor = System.Drawing.Color.Black
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnYes.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.White
        Me.btnYes.Location = New System.Drawing.Point(7, 4)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(89, 28)
        Me.btnYes.TabIndex = 0
        Me.btnYes.Text = "YES"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'picLibraryLogo
        '
        Me.picLibraryLogo.Image = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.READOBRITE_PUBLIC_LOGO_4
        Me.picLibraryLogo.Location = New System.Drawing.Point(24, 13)
        Me.picLibraryLogo.Name = "picLibraryLogo"
        Me.picLibraryLogo.Size = New System.Drawing.Size(128, 128)
        Me.picLibraryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLibraryLogo.TabIndex = 2
        Me.picLibraryLogo.TabStop = False
        '
        'MyMessageBox
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(399, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.picLibraryLogo)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.YesNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MyMessageBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MyMessageBox"
        Me.OK.ResumeLayout(False)
        Me.YesNo.ResumeLayout(False)
        CType(Me.picLibraryLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents picLibraryLogo As PictureBox
    Friend WithEvents YesNo As TableLayoutPanel
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
