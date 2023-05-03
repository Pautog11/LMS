<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet7 = New libra2.Database1DataSet7()
        Me.BooksTableAdapter = New libra2.Database1DataSet7TableAdapters.booksTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TittleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet8 = New libra2.Database1DataSet8()
        Me.BooksTableAdapter1 = New libra2.Database1DataSet8TableAdapters.booksTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "List of book that are currently Available"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(482, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 41)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.Database1DataSet7
        '
        'Database1DataSet7
        '
        Me.Database1DataSet7.DataSetName = "Database1DataSet7"
        Me.Database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(629, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 41)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.TittleDataGridViewTextBoxColumn1, Me.AuthorDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.BooksBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(12, 79)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(766, 301)
        Me.DataGridView2.TabIndex = 47
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TittleDataGridViewTextBoxColumn1
        '
        Me.TittleDataGridViewTextBoxColumn1.DataPropertyName = "Tittle"
        Me.TittleDataGridViewTextBoxColumn1.HeaderText = "Tittle"
        Me.TittleDataGridViewTextBoxColumn1.Name = "TittleDataGridViewTextBoxColumn1"
        '
        'AuthorDataGridViewTextBoxColumn1
        '
        Me.AuthorDataGridViewTextBoxColumn1.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn1.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn1.Name = "AuthorDataGridViewTextBoxColumn1"
        '
        'BooksBindingSource1
        '
        Me.BooksBindingSource1.DataMember = "books"
        Me.BooksBindingSource1.DataSource = Me.Database1DataSet8
        '
        'Database1DataSet8
        '
        Me.Database1DataSet8.DataSetName = "Database1DataSet8"
        Me.Database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksTableAdapter1
        '
        Me.BooksTableAdapter1.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(328, 404)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(116, 400)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 27)
        Me.TextBox1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Tittle"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form12"
        Me.Text = "Form12"
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Database1DataSet7 As Database1DataSet7
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As Database1DataSet7TableAdapters.booksTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Database1DataSet8 As Database1DataSet8
    Friend WithEvents BooksBindingSource1 As BindingSource
    Friend WithEvents BooksTableAdapter1 As Database1DataSet8TableAdapters.booksTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TittleDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
