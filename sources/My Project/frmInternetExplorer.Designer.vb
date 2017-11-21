Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInternetExplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInternetExplorer))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btOpen = New System.Windows.Forms.ToolStripButton()
        Me.txtAddress = New System.Windows.Forms.ToolStripTextBox()
        Me.btGo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btUpward = New System.Windows.Forms.ToolStripButton()
        Me.btDownward = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btOpen, Me.txtAddress, Me.btGo, Me.ToolStripSeparator1, Me.btUpward, Me.btDownward})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(530, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btOpen
        '
        Me.btOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btOpen.Image = CType(resources.GetObject("btOpen.Image"), System.Drawing.Image)
        Me.btOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btOpen.Name = "btOpen"
        Me.btOpen.Size = New System.Drawing.Size(23, 22)
        Me.btOpen.Text = "Open file"
        '
        'txtAddress
        '
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(190, 25)
        '
        'btGo
        '
        Me.btGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btGo.Image = CType(resources.GetObject("btGo.Image"), System.Drawing.Image)
        Me.btGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btGo.Name = "btGo"
        Me.btGo.Size = New System.Drawing.Size(23, 22)
        Me.btGo.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btUpward
        '
        Me.btUpward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btUpward.Image = CType(resources.GetObject("btUpward.Image"), System.Drawing.Image)
        Me.btUpward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btUpward.Name = "btUpward"
        Me.btUpward.Size = New System.Drawing.Size(23, 22)
        Me.btUpward.Text = "Upwards"
        '
        'btDownward
        '
        Me.btDownward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btDownward.Image = CType(resources.GetObject("btDownward.Image"), System.Drawing.Image)
        Me.btDownward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btDownward.Name = "btDownward"
        Me.btDownward.Size = New System.Drawing.Size(23, 22)
        Me.btDownward.Text = "DownWards"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.WebBrowser1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 236)
        Me.Panel1.TabIndex = 4
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(530, 236)
        Me.WebBrowser1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmInternetExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInternetExplorer"
        Me.Text = "Internet Explorer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtAddress As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btUpward As ToolStripButton
    Friend WithEvents btDownward As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btGo As ToolStripButton
    Friend WithEvents btOpen As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
