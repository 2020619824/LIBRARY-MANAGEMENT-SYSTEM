<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Me.picLibraryLogo = New System.Windows.Forms.PictureBox()
        Me.loadingBar = New System.Windows.Forms.Panel()
        Me.progressBar = New System.Windows.Forms.Panel()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLibraryLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loadingBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLibraryLogo
        '
        Me.picLibraryLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLibraryLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLibraryLogo.Image = Global.LIBRARY_MANAGEMENT_SYSTEM.My.Resources.Resources.READOBRITE_PUBLIC_LOGO_3
        Me.picLibraryLogo.Location = New System.Drawing.Point(149, 34)
        Me.picLibraryLogo.Name = "picLibraryLogo"
        Me.picLibraryLogo.Size = New System.Drawing.Size(199, 199)
        Me.picLibraryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLibraryLogo.TabIndex = 5
        Me.picLibraryLogo.TabStop = False
        '
        'loadingBar
        '
        Me.loadingBar.BackColor = System.Drawing.Color.White
        Me.loadingBar.Controls.Add(Me.progressBar)
        Me.loadingBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.loadingBar.Location = New System.Drawing.Point(0, 293)
        Me.loadingBar.Name = "loadingBar"
        Me.loadingBar.Size = New System.Drawing.Size(496, 10)
        Me.loadingBar.TabIndex = 6
        '
        'progressBar
        '
        Me.progressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressBar.Location = New System.Drawing.Point(0, 0)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(34, 13)
        Me.progressBar.TabIndex = 7
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 15
        '
        'SplashScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.loadingBar)
        Me.Controls.Add(Me.picLibraryLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picLibraryLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loadingBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLibraryLogo As PictureBox
    Friend WithEvents loadingBar As Panel
    Friend WithEvents progressBar As Panel
    Friend WithEvents timer As Timer
End Class
