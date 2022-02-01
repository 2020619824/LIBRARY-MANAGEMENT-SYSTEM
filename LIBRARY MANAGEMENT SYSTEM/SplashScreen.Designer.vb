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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.picLibraryLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBar = New System.Windows.Forms.Panel()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLibraryLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBar.SuspendLayout()
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
        'pnlBar
        '
        Me.pnlBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlBar.Controls.Add(Me.pnlProgress)
        Me.pnlBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBar.Location = New System.Drawing.Point(0, 293)
        Me.pnlBar.Name = "pnlBar"
        Me.pnlBar.Size = New System.Drawing.Size(496, 10)
        Me.pnlBar.TabIndex = 6
        '
        'pnlProgress
        '
        Me.pnlProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlProgress.Location = New System.Drawing.Point(0, 0)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(34, 13)
        Me.pnlProgress.TabIndex = 7
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
        Me.Controls.Add(Me.pnlBar)
        Me.Controls.Add(Me.picLibraryLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picLibraryLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLibraryLogo As PictureBox
    Friend WithEvents pnlBar As Panel
    Friend WithEvents pnlProgress As Panel
    Friend WithEvents timer As Timer
End Class
