Imports ComponentFactory.Krypton.Toolkit
Imports WeifenLuo.WinFormsUI.Docking

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWordList
    Inherits DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWordList))
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.contextFilter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnNewWord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCompleted = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bindingSource_main = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gridWords = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnFilter0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFilter1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFilter2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextFilter.SuspendLayout()
        CType(Me.bindingSource_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.gridWords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ContextMenuStrip = Me.contextFilter
        Me.ButtonSpecAny1.Image = Global.Dictionary_Maker.My.Resources.Resources.filter
        Me.ButtonSpecAny1.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.[Auto]
        Me.ButtonSpecAny1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ButtonSpec
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.ButtonSpecAny1.UniqueName = "2E62CB4C8ABE4B3B188F7970501DA0BB"
        '
        'contextFilter
        '
        Me.contextFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contextFilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNewWord, Me.mnCompleted, Me.mnAll})
        Me.contextFilter.Name = "contextDictionaries"
        Me.contextFilter.Size = New System.Drawing.Size(135, 70)
        '
        'mnNewWord
        '
        Me.mnNewWord.Name = "mnNewWord"
        Me.mnNewWord.Size = New System.Drawing.Size(134, 22)
        Me.mnNewWord.Text = "Incomplete"
        '
        'mnCompleted
        '
        Me.mnCompleted.Name = "mnCompleted"
        Me.mnCompleted.Size = New System.Drawing.Size(134, 22)
        Me.mnCompleted.Text = "Completed"
        '
        'mnAll
        '
        Me.mnAll.Name = "mnAll"
        Me.mnAll.Size = New System.Drawing.Size(134, 22)
        Me.mnAll.Text = "All entries"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "agt_action_success.png")
        Me.ImageList1.Images.SetKeyName(1, "new.png")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gridWords, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(293, 379)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'gridWords
        '
        Me.gridWords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridWords.ColumnHeadersVisible = False
        Me.gridWords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.gridWords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridWords.Location = New System.Drawing.Point(3, 30)
        Me.gridWords.Name = "gridWords"
        Me.gridWords.ReadOnly = True
        Me.gridWords.RowHeadersVisible = False
        Me.gridWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridWords.Size = New System.Drawing.Size(287, 346)
        Me.gridWords.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.txtSearch, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(293, 25)
        Me.ToolStrip1.TabIndex = 0
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
        Me.txtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(135, 25)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnFilter0, Me.mnFilter1, Me.mnFilter2})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'mnFilter0
        '
        Me.mnFilter0.Checked = True
        Me.mnFilter0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnFilter0.Name = "mnFilter0"
        Me.mnFilter0.Size = New System.Drawing.Size(134, 22)
        Me.mnFilter0.Text = "All Entries"
        '
        'mnFilter1
        '
        Me.mnFilter1.Name = "mnFilter1"
        Me.mnFilter1.Size = New System.Drawing.Size(134, 22)
        Me.mnFilter1.Text = "Completed"
        '
        'mnFilter2
        '
        Me.mnFilter2.Name = "mnFilter2"
        Me.mnFilter2.Size = New System.Drawing.Size(134, 22)
        Me.mnFilter2.Text = "Incomplete"
        '
        'frmWordList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 379)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HideOnClose = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmWordList"
        Me.Text = "Entries"
        Me.contextFilter.ResumeLayout(False)
        CType(Me.bindingSource_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.gridWords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents contextFilter As ContextMenuStrip
    Friend WithEvents mnNewWord As ToolStripMenuItem
    Friend WithEvents mnCompleted As ToolStripMenuItem
    Friend WithEvents ButtonSpecAny1 As ButtonSpecAny
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents mnAll As ToolStripMenuItem
    Friend WithEvents bindingSource_main As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents gridWords As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents mnFilter0 As ToolStripMenuItem
    Friend WithEvents mnFilter1 As ToolStripMenuItem
    Friend WithEvents mnFilter2 As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
