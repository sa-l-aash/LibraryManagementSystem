<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        label1 = New Label()
        label2 = New Label()
        label3 = New Label()
        label4 = New Label()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtYearPublish = New TextBox()
        txtGenre = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dvgBooks = New DataGridView()
        CType(dvgBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(36, 28)
        label1.Name = "label1"
        label1.Size = New Size(47, 25)
        label1.TabIndex = 0
        label1.Text = "Title"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(36, 96)
        label2.Name = "label2"
        label2.Size = New Size(67, 25)
        label2.TabIndex = 1
        label2.Text = "Author"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label3.Location = New Point(36, 169)
        label3.Name = "label3"
        label3.Size = New Size(131, 25)
        label3.TabIndex = 2
        label3.Text = "Year Published"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label4.Location = New Point(36, 238)
        label4.Name = "label4"
        label4.Size = New Size(60, 25)
        label4.TabIndex = 3
        label4.Text = "Genre"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(179, 28)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(150, 31)
        txtTitle.TabIndex = 4
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(179, 96)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(150, 31)
        txtAuthor.TabIndex = 5
        ' 
        ' txtYearPublish
        ' 
        txtYearPublish.Location = New Point(179, 169)
        txtYearPublish.Name = "txtYearPublish"
        txtYearPublish.Size = New Size(150, 31)
        txtYearPublish.TabIndex = 6
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(179, 238)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(150, 31)
        txtGenre.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(369, 350)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(549, 350)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(732, 350)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(922, 350)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dvgBooks
        ' 
        dvgBooks.AllowUserToAddRows = False
        dvgBooks.AllowUserToDeleteRows = False
        dvgBooks.BackgroundColor = SystemColors.HighlightText
        dvgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgBooks.GridColor = SystemColors.ScrollBar
        dvgBooks.Location = New Point(369, 12)
        dvgBooks.Name = "dvgBooks"
        dvgBooks.ReadOnly = True
        dvgBooks.RowHeadersWidth = 62
        dvgBooks.Size = New Size(719, 287)
        dvgBooks.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1100, 450)
        Controls.Add(dvgBooks)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtGenre)
        Controls.Add(txtYearPublish)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "Form1"
        Text = "Form1"
        CType(dvgBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublish As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dvgBooks As DataGridView

End Class
