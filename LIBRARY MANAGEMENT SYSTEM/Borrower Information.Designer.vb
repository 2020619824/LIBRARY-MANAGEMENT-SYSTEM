<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowerInformation
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
        Me.cnbReturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cnbReturn
        '
        Me.cnbReturn.BackColor = System.Drawing.Color.Black
        Me.cnbReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cnbReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnbReturn.ForeColor = System.Drawing.Color.Red
        Me.cnbReturn.Location = New System.Drawing.Point(574, 280)
        Me.cnbReturn.Name = "cnbReturn"
        Me.cnbReturn.Size = New System.Drawing.Size(127, 43)
        Me.cnbReturn.TabIndex = 6
        Me.cnbReturn.Text = "Return"
        Me.cnbReturn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'BorrowerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 357)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cnbReturn)
        Me.Name = "BorrowerInformation"
        Me.Text = "Borrower Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cnbReturn As Button
    Friend WithEvents Label1 As Label
End Class
