Imports WeifenLuo.WinFormsUI.Docking

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntry))
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtAbbreviations = New System.Windows.Forms.TextBox()
        Me.txtEtymology = New System.Windows.Forms.TextBox()
        Me.txtDerive = New System.Windows.Forms.TextBox()
        Me.txtPronunciation = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtCode = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.colorsText = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btComplete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBold = New System.Windows.Forms.ToolStripButton()
        Me.btItalic = New System.Windows.Forms.ToolStripButton()
        Me.btUnderline = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btH1 = New System.Windows.Forms.ToolStripButton()
        Me.btH2 = New System.Windows.Forms.ToolStripButton()
        Me.btH3 = New System.Windows.Forms.ToolStripButton()
        Me.btH4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btParaLeft = New System.Windows.Forms.ToolStripButton()
        Me.btParaCenter = New System.Windows.Forms.ToolStripButton()
        Me.btParaRight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btUL = New System.Windows.Forms.ToolStripButton()
        Me.btuLNum = New System.Windows.Forms.ToolStripButton()
        Me.btIndent = New System.Windows.Forms.ToolStripButton()
        Me.btOutdent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btLink = New System.Windows.Forms.ToolStripButton()
        Me.btSubscript = New System.Windows.Forms.ToolStripButton()
        Me.btSuperScript = New System.Windows.Forms.ToolStripButton()
        Me.btLine = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btColors = New System.Windows.Forms.ToolStripButton()
        Me.btTextColors = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btClearFormating = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btReplace = New System.Windows.Forms.ToolStripButton()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.Beige
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtNotes.Location = New System.Drawing.Point(108, 133)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(637, 22)
        Me.txtNotes.TabIndex = 5
        '
        'txtAbbreviations
        '
        Me.txtAbbreviations.BackColor = System.Drawing.Color.Beige
        Me.txtAbbreviations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAbbreviations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbbreviations.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtAbbreviations.Location = New System.Drawing.Point(108, 108)
        Me.txtAbbreviations.Name = "txtAbbreviations"
        Me.txtAbbreviations.Size = New System.Drawing.Size(637, 22)
        Me.txtAbbreviations.TabIndex = 4
        '
        'txtEtymology
        '
        Me.txtEtymology.BackColor = System.Drawing.Color.Beige
        Me.txtEtymology.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEtymology.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtymology.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtEtymology.Location = New System.Drawing.Point(108, 83)
        Me.txtEtymology.Name = "txtEtymology"
        Me.txtEtymology.Size = New System.Drawing.Size(637, 22)
        Me.txtEtymology.TabIndex = 3
        '
        'txtDerive
        '
        Me.txtDerive.BackColor = System.Drawing.Color.Beige
        Me.txtDerive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDerive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDerive.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDerive.Location = New System.Drawing.Point(108, 58)
        Me.txtDerive.Name = "txtDerive"
        Me.txtDerive.Size = New System.Drawing.Size(637, 22)
        Me.txtDerive.TabIndex = 2
        '
        'txtPronunciation
        '
        Me.txtPronunciation.BackColor = System.Drawing.Color.Beige
        Me.txtPronunciation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPronunciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPronunciation.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtPronunciation.Location = New System.Drawing.Point(108, 33)
        Me.txtPronunciation.Name = "txtPronunciation"
        Me.txtPronunciation.Size = New System.Drawing.Size(637, 22)
        Me.txtPronunciation.TabIndex = 1
        '
        'txtWord
        '
        Me.txtWord.BackColor = System.Drawing.Color.Beige
        Me.txtWord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWord.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtWord.Location = New System.Drawing.Point(108, 8)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(637, 22)
        Me.txtWord.TabIndex = 0
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtCode.AutoIndentCharsPatterns = ""
        Me.txtCode.AutoScrollMinSize = New System.Drawing.Size(0, 18)
        Me.txtCode.BackBrush = Nothing
        Me.txtCode.BackColor = System.Drawing.Color.Beige
        Me.txtCode.CharHeight = 18
        Me.txtCode.CharWidth = 10
        Me.txtCode.CommentPrefix = Nothing
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.txtCode.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtCode.IsReplaceMode = False
        Me.txtCode.Language = FastColoredTextBoxNS.Language.HTML
        Me.txtCode.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.txtCode.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtCode.Location = New System.Drawing.Point(3, 33)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtCode.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.txtCode.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtCode.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.ServiceColors = CType(resources.GetObject("txtCode.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.txtCode.Size = New System.Drawing.Size(747, 169)
        Me.txtCode.TabIndex = 6
        Me.txtCode.Text = "FastColoredTextBox1"
        Me.txtCode.WordWrap = True
        Me.txtCode.Zoom = 100
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(759, 376)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtNotes, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAbbreviations, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEtymology, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDerive, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPronunciation, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtWord, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(753, 159)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Reference"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Abbreviations"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Etymology (√)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Derive"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pronunciation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Word"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ToolStrip2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtCode, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 168)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(753, 205)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btComplete, Me.ToolStripSeparator8, Me.btBold, Me.btItalic, Me.btUnderline, Me.ToolStripSeparator3, Me.btH1, Me.btH2, Me.btH3, Me.btH4, Me.ToolStripSeparator1, Me.btParaLeft, Me.btParaCenter, Me.btParaRight, Me.ToolStripSeparator4, Me.btUL, Me.btuLNum, Me.btIndent, Me.btOutdent, Me.ToolStripSeparator5, Me.btLink, Me.btSubscript, Me.btSuperScript, Me.btLine, Me.ToolStripSeparator6, Me.btColors, Me.btTextColors, Me.ToolStripSeparator7, Me.btClearFormating, Me.ToolStripSeparator2, Me.btReplace})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(747, 25)
        Me.ToolStrip2.TabIndex = 19
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btComplete
        '
        Me.btComplete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btComplete.Image = CType(resources.GetObject("btComplete.Image"), System.Drawing.Image)
        Me.btComplete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btComplete.Name = "btComplete"
        Me.btComplete.Size = New System.Drawing.Size(23, 22)
        Me.btComplete.Text = "ToolStripButton1"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btBold
        '
        Me.btBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btBold.Image = Global.Dictionary_Maker.My.Resources.Resources.Bold
        Me.btBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBold.Name = "btBold"
        Me.btBold.Size = New System.Drawing.Size(23, 22)
        Me.btBold.Text = "Bold"
        '
        'btItalic
        '
        Me.btItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btItalic.Image = Global.Dictionary_Maker.My.Resources.Resources.Italic
        Me.btItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btItalic.Name = "btItalic"
        Me.btItalic.Size = New System.Drawing.Size(23, 22)
        Me.btItalic.Text = "Italic"
        '
        'btUnderline
        '
        Me.btUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btUnderline.Image = Global.Dictionary_Maker.My.Resources.Resources.Underline
        Me.btUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btUnderline.Name = "btUnderline"
        Me.btUnderline.Size = New System.Drawing.Size(23, 22)
        Me.btUnderline.Text = "Underline"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btH1
        '
        Me.btH1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btH1.Image = CType(resources.GetObject("btH1.Image"), System.Drawing.Image)
        Me.btH1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btH1.Name = "btH1"
        Me.btH1.Size = New System.Drawing.Size(23, 22)
        Me.btH1.Text = "ToolStripButton1"
        '
        'btH2
        '
        Me.btH2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btH2.Image = CType(resources.GetObject("btH2.Image"), System.Drawing.Image)
        Me.btH2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btH2.Name = "btH2"
        Me.btH2.Size = New System.Drawing.Size(23, 22)
        Me.btH2.Text = "ToolStripButton2"
        '
        'btH3
        '
        Me.btH3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btH3.Image = CType(resources.GetObject("btH3.Image"), System.Drawing.Image)
        Me.btH3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btH3.Name = "btH3"
        Me.btH3.Size = New System.Drawing.Size(23, 22)
        Me.btH3.Text = "ToolStripButton3"
        '
        'btH4
        '
        Me.btH4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btH4.Image = CType(resources.GetObject("btH4.Image"), System.Drawing.Image)
        Me.btH4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btH4.Name = "btH4"
        Me.btH4.Size = New System.Drawing.Size(23, 22)
        Me.btH4.Text = "ToolStripButton4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btParaLeft
        '
        Me.btParaLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btParaLeft.Image = Global.Dictionary_Maker.My.Resources.Resources.JustifyLeft
        Me.btParaLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btParaLeft.Name = "btParaLeft"
        Me.btParaLeft.Size = New System.Drawing.Size(23, 22)
        Me.btParaLeft.Text = "Left"
        '
        'btParaCenter
        '
        Me.btParaCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btParaCenter.Image = Global.Dictionary_Maker.My.Resources.Resources.JustifyCenter
        Me.btParaCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btParaCenter.Name = "btParaCenter"
        Me.btParaCenter.Size = New System.Drawing.Size(23, 22)
        Me.btParaCenter.Text = "Center"
        '
        'btParaRight
        '
        Me.btParaRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btParaRight.Image = Global.Dictionary_Maker.My.Resources.Resources.JustifyRight
        Me.btParaRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btParaRight.Name = "btParaRight"
        Me.btParaRight.Size = New System.Drawing.Size(23, 22)
        Me.btParaRight.Text = "Right"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btUL
        '
        Me.btUL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btUL.Image = Global.Dictionary_Maker.My.Resources.Resources.InsertUnorderedList
        Me.btUL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btUL.Name = "btUL"
        Me.btUL.Size = New System.Drawing.Size(23, 22)
        Me.btUL.Text = "Bullets"
        '
        'btuLNum
        '
        Me.btuLNum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btuLNum.Image = Global.Dictionary_Maker.My.Resources.Resources.InsertOrderedList
        Me.btuLNum.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btuLNum.Name = "btuLNum"
        Me.btuLNum.Size = New System.Drawing.Size(23, 22)
        Me.btuLNum.Text = "Numbering"
        '
        'btIndent
        '
        Me.btIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btIndent.Image = Global.Dictionary_Maker.My.Resources.Resources.Indent
        Me.btIndent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btIndent.Name = "btIndent"
        Me.btIndent.Size = New System.Drawing.Size(23, 22)
        Me.btIndent.Text = "Indent"
        '
        'btOutdent
        '
        Me.btOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btOutdent.Image = Global.Dictionary_Maker.My.Resources.Resources.Outdent
        Me.btOutdent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btOutdent.Name = "btOutdent"
        Me.btOutdent.Size = New System.Drawing.Size(23, 22)
        Me.btOutdent.Text = "Outdent"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btLink
        '
        Me.btLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btLink.Image = Global.Dictionary_Maker.My.Resources.Resources.CreateLink
        Me.btLink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btLink.Name = "btLink"
        Me.btLink.Size = New System.Drawing.Size(23, 22)
        Me.btLink.Text = "Link"
        '
        'btSubscript
        '
        Me.btSubscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btSubscript.Image = CType(resources.GetObject("btSubscript.Image"), System.Drawing.Image)
        Me.btSubscript.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSubscript.Name = "btSubscript"
        Me.btSubscript.Size = New System.Drawing.Size(23, 22)
        Me.btSubscript.Text = "Subscript"
        '
        'btSuperScript
        '
        Me.btSuperScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btSuperScript.Image = CType(resources.GetObject("btSuperScript.Image"), System.Drawing.Image)
        Me.btSuperScript.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSuperScript.Name = "btSuperScript"
        Me.btSuperScript.Size = New System.Drawing.Size(23, 22)
        Me.btSuperScript.Text = "SuperScript"
        '
        'btLine
        '
        Me.btLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btLine.Image = CType(resources.GetObject("btLine.Image"), System.Drawing.Image)
        Me.btLine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btLine.Name = "btLine"
        Me.btLine.Size = New System.Drawing.Size(23, 22)
        Me.btLine.Text = "Line"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btColors
        '
        Me.btColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btColors.Image = Global.Dictionary_Maker.My.Resources.Resources.BackColor
        Me.btColors.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btColors.Name = "btColors"
        Me.btColors.Size = New System.Drawing.Size(23, 22)
        Me.btColors.Text = "Background colors"
        '
        'btTextColors
        '
        Me.btTextColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btTextColors.Image = Global.Dictionary_Maker.My.Resources.Resources.ForeColor
        Me.btTextColors.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btTextColors.Name = "btTextColors"
        Me.btTextColors.Size = New System.Drawing.Size(23, 22)
        Me.btTextColors.Text = "Text colors"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'btClearFormating
        '
        Me.btClearFormating.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btClearFormating.Image = Global.Dictionary_Maker.My.Resources.Resources.RemoveFormat
        Me.btClearFormating.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btClearFormating.Name = "btClearFormating"
        Me.btClearFormating.Size = New System.Drawing.Size(23, 22)
        Me.btClearFormating.Text = "Clear tag"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btReplace
        '
        Me.btReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btReplace.Image = CType(resources.GetObject("btReplace.Image"), System.Drawing.Image)
        Me.btReplace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btReplace.Name = "btReplace"
        Me.btReplace.Size = New System.Drawing.Size(23, 22)
        Me.btReplace.Text = "Find and Replace"
        '
        'frmEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 376)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmEntry"
        Me.Text = "New Entry"
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colorsText As ColorDialog
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtAbbreviations As TextBox
    Friend WithEvents txtEtymology As TextBox
    Friend WithEvents txtDerive As TextBox
    Friend WithEvents txtPronunciation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btBold As ToolStripButton
    Friend WithEvents btItalic As ToolStripButton
    Friend WithEvents btUnderline As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btH1 As ToolStripButton
    Friend WithEvents btH2 As ToolStripButton
    Friend WithEvents btH3 As ToolStripButton
    Friend WithEvents btH4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btParaLeft As ToolStripButton
    Friend WithEvents btParaCenter As ToolStripButton
    Friend WithEvents btParaRight As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btUL As ToolStripButton
    Friend WithEvents btuLNum As ToolStripButton
    Friend WithEvents btIndent As ToolStripButton
    Friend WithEvents btOutdent As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btLink As ToolStripButton
    Friend WithEvents btSubscript As ToolStripButton
    Friend WithEvents btSuperScript As ToolStripButton
    Friend WithEvents btLine As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btColors As ToolStripButton
    Friend WithEvents btTextColors As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents btClearFormating As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btReplace As ToolStripButton
    Friend WithEvents txtCode As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents btComplete As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
End Class
