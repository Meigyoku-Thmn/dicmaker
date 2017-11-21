Imports ComponentFactory.Krypton.Toolkit
Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDictionary
    Inherits DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDictionary))
        Me._table = New System.Windows.Forms.TableLayoutPanel()
        Me.listWord = New System.Windows.Forms.DataGridView()
        Me.Word = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripDictionaries = New System.Windows.Forms.ToolStripDropDownButton()
        Me.contextDictionaries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me._table.SuspendLayout()
        CType(Me.listWord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_table
        '
        Me._table.ColumnCount = 1
        Me._table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._table.Controls.Add(Me.listWord, 0, 1)
        Me._table.Controls.Add(Me.ToolStrip1, 0, 0)
        Me._table.Dock = System.Windows.Forms.DockStyle.Fill
        Me._table.Location = New System.Drawing.Point(0, 0)
        Me._table.Margin = New System.Windows.Forms.Padding(5)
        Me._table.Name = "_table"
        Me._table.RowCount = 2
        Me._table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me._table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me._table.Size = New System.Drawing.Size(246, 372)
        Me._table.TabIndex = 2
        '
        'listWord
        '
        Me.listWord.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listWord.ColumnHeadersVisible = False
        Me.listWord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Word})
        Me.listWord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listWord.Location = New System.Drawing.Point(3, 40)
        Me.listWord.Name = "listWord"
        Me.listWord.RowHeadersVisible = False
        Me.listWord.Size = New System.Drawing.Size(240, 346)
        Me.listWord.TabIndex = 3
        '
        'Word
        '
        Me.Word.HeaderText = "Column1"
        Me.Word.Name = "Word"
        Me.Word.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.txtSearch, Me.toolstripDictionaries})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(246, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'txtSearch
        '
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(135, 25)
        '
        'toolstripDictionaries
        '
        Me.toolstripDictionaries.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripDictionaries.DropDown = Me.contextDictionaries
        Me.toolstripDictionaries.Image = CType(resources.GetObject("toolstripDictionaries.Image"), System.Drawing.Image)
        Me.toolstripDictionaries.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripDictionaries.Name = "toolstripDictionaries"
        Me.toolstripDictionaries.Size = New System.Drawing.Size(29, 22)
        Me.toolstripDictionaries.Text = "Manage Dictionaries"
        '
        'contextDictionaries
        '
        Me.contextDictionaries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contextDictionaries.Name = "contextDictionaries"
        Me.contextDictionaries.Size = New System.Drawing.Size(61, 4)
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ContextMenuStrip = Me.contextDictionaries
        Me.ButtonSpecAny1.Image = Global.Dictionary_Maker.My.Resources.Resources.books_infront
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.ButtonSpecAny1.UniqueName = "C797BA4DFF9F4C63D4A6A49B8D728C6B"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "agt_action_success.png")
        '
        'frmDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 372)
        Me.Controls.Add(Me._table)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDictionary"
        Me.Text = "Dictionary"
        Me._table.ResumeLayout(False)
        Me._table.PerformLayout()
        CType(Me.listWord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _table As TableLayoutPanel
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents contextDictionaries As ContextMenuStrip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents listWord As DataGridView
    Friend WithEvents Word As DataGridViewTextBoxColumn
    Friend WithEvents toolstripDictionaries As ToolStripDropDownButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
