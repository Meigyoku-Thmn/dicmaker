<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIndex))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboGroup = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNewGroup = New System.Windows.Forms.ToolStripButton()
        Me.btDeleteGroup = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNewAttributes = New System.Windows.Forms.ToolStripButton()
        Me.btDeleteItems = New System.Windows.Forms.ToolStripLabel()
        Me.listGroup = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Text = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.listGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboGroup, Me.ToolStripSeparator1, Me.btNewGroup, Me.btDeleteGroup, Me.ToolStripSeparator2, Me.btNewAttributes, Me.btDeleteItems})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(625, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel1.Text = "Group"
        '
        'cboGroup
        '
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btNewGroup
        '
        Me.btNewGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btNewGroup.Image = CType(resources.GetObject("btNewGroup.Image"), System.Drawing.Image)
        Me.btNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNewGroup.Name = "btNewGroup"
        Me.btNewGroup.Size = New System.Drawing.Size(71, 22)
        Me.btNewGroup.Text = "New Group"
        '
        'btDeleteGroup
        '
        Me.btDeleteGroup.Name = "btDeleteGroup"
        Me.btDeleteGroup.Size = New System.Drawing.Size(76, 22)
        Me.btDeleteGroup.Text = "Delete Group"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btNewAttributes
        '
        Me.btNewAttributes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btNewAttributes.Image = CType(resources.GetObject("btNewAttributes.Image"), System.Drawing.Image)
        Me.btNewAttributes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNewAttributes.Name = "btNewAttributes"
        Me.btNewAttributes.Size = New System.Drawing.Size(67, 22)
        Me.btNewAttributes.Text = "New Items"
        '
        'btDeleteItems
        '
        Me.btDeleteItems.Name = "btDeleteItems"
        Me.btDeleteItems.Size = New System.Drawing.Size(72, 22)
        Me.btDeleteItems.Text = "Delete Items"
        '
        'listGroup
        '
        Me.listGroup.AllowUserToAddRows = False
        Me.listGroup.AllowUserToDeleteRows = False
        Me.listGroup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listGroup.ColumnHeadersVisible = False
        Me.listGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Text, Me.Code})
        Me.listGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listGroup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.listGroup.Location = New System.Drawing.Point(0, 25)
        Me.listGroup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listGroup.MultiSelect = False
        Me.listGroup.Name = "listGroup"
        Me.listGroup.ReadOnly = True
        Me.listGroup.RowHeadersVisible = False
        Me.listGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listGroup.Size = New System.Drawing.Size(625, 390)
        Me.listGroup.TabIndex = 9
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Text
        '
        Me.Text.HeaderText = "Text"
        Me.Text.Name = "Text"
        Me.Text.ReadOnly = True
        Me.Text.Width = 450
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        Me.Code.Width = 150
        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 415)
        Me.Controls.Add(Me.listGroup)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIndex"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.listGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboGroup As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents listGroup As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Text As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents btNewAttributes As ToolStripButton
    Friend WithEvents btNewGroup As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btDeleteGroup As ToolStripLabel
    Friend WithEvents btDeleteItems As ToolStripLabel
End Class
