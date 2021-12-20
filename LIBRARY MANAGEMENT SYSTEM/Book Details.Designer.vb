<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetails
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.List_Book_Details = New LIBRARY_MANAGEMENT_SYSTEM.List_Book_Details()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.List_Book_DetailsTableAdapters.BookTableAdapter()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearOfPublicationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.List_Book_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(37, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.YearOfPublicationDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(37, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(602, 270)
        Me.DataGridView1.TabIndex = 1
        '
        'List_Book_Details
        '
        Me.List_Book_Details.DataSetName = "List_Book_Details"
        Me.List_Book_Details.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.List_Book_Details
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.Width = 125
        '
        'YearOfPublicationDataGridViewTextBoxColumn
        '
        Me.YearOfPublicationDataGridViewTextBoxColumn.DataPropertyName = "Year of Publication"
        Me.YearOfPublicationDataGridViewTextBoxColumn.HeaderText = "Year of Publication"
        Me.YearOfPublicationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.YearOfPublicationDataGridViewTextBoxColumn.Name = "YearOfPublicationDataGridViewTextBoxColumn"
        Me.YearOfPublicationDataGridViewTextBoxColumn.Width = 125
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 125
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Width = 125
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        Me.PublisherDataGridViewTextBoxColumn.Width = 125
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Width = 125
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(658, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(658, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 46)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BookDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BookDetails"
        Me.Text = "Book Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.List_Book_Details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents List_Book_Details As List_Book_Details
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As List_Book_DetailsTableAdapters.BookTableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearOfPublicationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
