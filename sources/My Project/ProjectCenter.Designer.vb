Imports ComponentFactory.Krypton.Toolkit.KryptonForm
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectCenter
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectCenter))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.gridInfo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Tittle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Words = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btNew = New System.Windows.Forms.ToolStripButton()
        Me.btOpen = New System.Windows.Forms.ToolStripButton()
        Me.btDelete = New System.Windows.Forms.ToolStripButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.gridInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.gridInfo)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(670, 286)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(670, 311)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'gridInfo
        '
        Me.gridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridInfo.ColumnHeadersVisible = False
        Me.gridInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.Tittle, Me.Description, Me.Words})
        Me.gridInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.gridInfo.Name = "gridInfo"
        Me.gridInfo.ReadOnly = True
        Me.gridInfo.RowHeadersVisible = False
        Me.gridInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridInfo.Size = New System.Drawing.Size(670, 286)
        Me.gridInfo.TabIndex = 4
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 50
        '
        'Tittle
        '
        Me.Tittle.HeaderText = "Tittle"
        Me.Tittle.Name = "Tittle"
        Me.Tittle.ReadOnly = True
        Me.Tittle.Width = 200
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 300
        '
        'Words
        '
        Me.Words.HeaderText = "Words"
        Me.Words.Name = "Words"
        Me.Words.ReadOnly = True
        Me.Words.Width = 80
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNew, Me.btOpen, Me.btDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(81, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'btNew
        '
        Me.btNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btNew.Image = CType(resources.GetObject("btNew.Image"), System.Drawing.Image)
        Me.btNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(23, 22)
        Me.btNew.Text = "New project"
        '
        'btOpen
        '
        Me.btOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btOpen.Image = CType(resources.GetObject("btOpen.Image"), System.Drawing.Image)
        Me.btOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btOpen.Name = "btOpen"
        Me.btOpen.Size = New System.Drawing.Size(23, 22)
        Me.btOpen.Text = "Open project"
        '
        'btDelete
        '
        Me.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(23, 22)
        Me.btDelete.Text = "Delete project"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "books_infront.png")
        Me.ImageList1.Images.SetKeyName(1, "folder_red.png")
        '
        'ProjectCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 311)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProjectCenter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Center"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.gridInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btNew As ToolStripButton
    Friend WithEvents gridInfo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btDelete As ToolStripButton
    Friend WithEvents btOpen As ToolStripButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Status As DataGridViewImageColumn
    Friend WithEvents Tittle As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Words As DataGridViewTextBoxColumn
End Class
