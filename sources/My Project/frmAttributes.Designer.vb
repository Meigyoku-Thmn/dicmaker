Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttributes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttributes))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gridInfo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tittle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboAttributes = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.gridInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gridInfo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboAttributes, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(241, 315)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'gridInfo
        '
        Me.gridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridInfo.ColumnHeadersVisible = False
        Me.gridInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.Code, Me.Tittle})
        Me.gridInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridInfo.Location = New System.Drawing.Point(4, 29)
        Me.gridInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.gridInfo.Name = "gridInfo"
        Me.gridInfo.ReadOnly = True
        Me.gridInfo.RowHeadersVisible = False
        Me.gridInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridInfo.Size = New System.Drawing.Size(233, 286)
        Me.gridInfo.TabIndex = 5
        '
        'Status
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
        Me.Status.DefaultCellStyle = DataGridViewCellStyle1
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 20
        '
        'Code
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Code.DefaultCellStyle = DataGridViewCellStyle2
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        Me.Code.Width = 50
        '
        'Tittle
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Chocolate
        Me.Tittle.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tittle.HeaderText = "Tittle"
        Me.Tittle.Name = "Tittle"
        Me.Tittle.ReadOnly = True
        Me.Tittle.Width = 150
        '
        'cboAttributes
        '
        Me.cboAttributes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboAttributes.ForeColor = System.Drawing.Color.DarkGreen
        Me.cboAttributes.FormattingEnabled = True
        Me.cboAttributes.Location = New System.Drawing.Point(3, 3)
        Me.cboAttributes.Name = "cboAttributes"
        Me.cboAttributes.Size = New System.Drawing.Size(235, 21)
        Me.cboAttributes.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ic_chevron_right_black_18dp.png")
        '
        'frmAttributes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 315)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAttributes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "References"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.gridInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cboAttributes As ComboBox
    Friend WithEvents gridInfo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Status As DataGridViewImageColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Tittle As DataGridViewTextBoxColumn
End Class
