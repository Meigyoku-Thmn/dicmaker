<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrDictionary
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me._table = New System.Windows.Forms.TableLayoutPanel()
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.contextDictionaries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.listWord = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._table.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(380, 383)
        Me.KryptonPanel1.TabIndex = 0
        '
        '_table
        '
        Me._table.ColumnCount = 1
        Me._table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._table.Controls.Add(Me.KryptonHeader1, 0, 0)
        Me._table.Controls.Add(Me.txtSearch, 0, 1)
        Me._table.Controls.Add(Me.listWord, 0, 2)
        Me._table.Location = New System.Drawing.Point(0, 0)
        Me._table.Margin = New System.Windows.Forms.Padding(4)
        Me._table.Name = "_table"
        Me._table.RowCount = 3
        Me._table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me._table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me._table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._table.Size = New System.Drawing.Size(349, 383)
        Me._table.TabIndex = 1
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Custom1
        Me.KryptonHeader1.Location = New System.Drawing.Point(4, 4)
        Me.KryptonHeader1.Margin = New System.Windows.Forms.Padding(4, 4, 6, 4)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(339, 32)
        Me.KryptonHeader1.TabIndex = 0
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Dictionary"
        Me.KryptonHeader1.Values.Image = Global.Dictionary_Maker.My.Resources.Resources.books_infront
        '
        'txtSearch
        '
        Me.txtSearch.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny2})
        Me.txtSearch.ContextMenuStrip = Me.contextDictionaries
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSearch.Location = New System.Drawing.Point(4, 44)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 6, 4)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(339, 27)
        Me.txtSearch.StateNormal.Border.Color1 = System.Drawing.Color.White
        Me.txtSearch.StateNormal.Border.Color2 = System.Drawing.Color.White
        Me.txtSearch.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearch.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = "Search"
        '
        'ButtonSpecAny2
        '
        Me.ButtonSpecAny2.ContextMenuStrip = Me.contextDictionaries
        Me.ButtonSpecAny2.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ButtonSpec
        Me.ButtonSpecAny2.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip
        Me.ButtonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.ButtonSpecAny2.UniqueName = "CF2A59D326CA45EB4FB5774B144375D9"
        '
        'contextDictionaries
        '
        Me.contextDictionaries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contextDictionaries.Name = "contextDictionaries"
        Me.contextDictionaries.Size = New System.Drawing.Size(61, 4)
        '
        'listWord
        '
        Me.listWord.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonButtonSpec
        Me.listWord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listWord.Location = New System.Drawing.Point(5, 79)
        Me.listWord.Margin = New System.Windows.Forms.Padding(5, 4, 7, 3)
        Me.listWord.Name = "listWord"
        Me.listWord.Size = New System.Drawing.Size(337, 306)
        Me.listWord.TabIndex = 0
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ContextMenuStrip = Me.contextDictionaries
        Me.ButtonSpecAny1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem
        Me.ButtonSpecAny1.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.ButtonSpecAny1.UniqueName = "42946F47E8964CD284BFAB1D821C4B71"
        '
        'ctrDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._table)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ctrDictionary"
        Me.Size = New System.Drawing.Size(380, 383)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._table.ResumeLayout(False)
        Me._table.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents _table As TableLayoutPanel
    Private WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents contextDictionaries As ContextMenuStrip
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents listWord As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Private WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
End Class
