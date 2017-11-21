<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTable))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btColumn = New System.Windows.Forms.ToolStripButton()
        Me.btClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboNum = New System.Windows.Forms.ToolStripComboBox()
        Me.btMulti = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btApcept = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.listRow = New System.Windows.Forms.DataGridView()
        Me.listHeader = New System.Windows.Forms.DataGridView()
        Me.txtTittle = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.listRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btColumn, Me.btClear, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.cboNum, Me.btMulti, Me.ToolStripSeparator1, Me.btApcept})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btColumn
        '
        Me.btColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btColumn.Image = CType(resources.GetObject("btColumn.Image"), System.Drawing.Image)
        Me.btColumn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btColumn.Name = "btColumn"
        Me.btColumn.Size = New System.Drawing.Size(23, 22)
        Me.btColumn.Text = "Add column"
        '
        'btClear
        '
        Me.btClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btClear.Image = CType(resources.GetObject("btClear.Image"), System.Drawing.Image)
        Me.btClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(23, 22)
        Me.btClear.Text = "Clear table"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel1.Text = "Multiples"
        '
        'cboNum
        '
        Me.cboNum.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboNum.Name = "cboNum"
        Me.cboNum.Size = New System.Drawing.Size(75, 25)
        Me.cboNum.Text = "3"
        '
        'btMulti
        '
        Me.btMulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btMulti.Image = CType(resources.GetObject("btMulti.Image"), System.Drawing.Image)
        Me.btMulti.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btMulti.Name = "btMulti"
        Me.btMulti.Size = New System.Drawing.Size(23, 22)
        Me.btMulti.Text = "Add columns"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btApcept
        '
        Me.btApcept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btApcept.Image = CType(resources.GetObject("btApcept.Image"), System.Drawing.Image)
        Me.btApcept.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btApcept.Name = "btApcept"
        Me.btApcept.Size = New System.Drawing.Size(23, 22)
        Me.btApcept.Text = "Apcept"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 345)
        Me.Panel1.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(744, 345)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.listRow, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.listHeader, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTittle, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(736, 337)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'listRow
        '
        Me.listRow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listRow.ColumnHeadersVisible = False
        Me.listRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listRow.Location = New System.Drawing.Point(3, 93)
        Me.listRow.Name = "listRow"
        Me.listRow.RowHeadersVisible = False
        Me.listRow.Size = New System.Drawing.Size(730, 241)
        Me.listRow.TabIndex = 5
        '
        'listHeader
        '
        Me.listHeader.AllowUserToAddRows = False
        Me.listHeader.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listHeader.ColumnHeadersVisible = False
        Me.listHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listHeader.Location = New System.Drawing.Point(3, 33)
        Me.listHeader.Name = "listHeader"
        Me.listHeader.RowHeadersVisible = False
        Me.listHeader.Size = New System.Drawing.Size(730, 54)
        Me.listHeader.TabIndex = 4
        '
        'txtTittle
        '
        Me.txtTittle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTittle.Location = New System.Drawing.Point(4, 4)
        Me.txtTittle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTittle.Name = "txtTittle"
        Me.txtTittle.Size = New System.Drawing.Size(728, 22)
        Me.txtTittle.TabIndex = 0
        Me.txtTittle.Text = "Table 1"
        '
        'frmTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 370)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.listRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btClear As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents listRow As DataGridView
    Friend WithEvents listHeader As DataGridView
    Friend WithEvents txtTittle As TextBox
    Friend WithEvents btMulti As ToolStripButton
    Friend WithEvents btColumn As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents cboNum As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btApcept As ToolStripButton
End Class
