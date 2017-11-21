Imports ComponentFactory.Krypton.Toolkit
Imports AutocompleteMenuNS
Imports WeifenLuo.WinFormsUI.Docking

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInputData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputData))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWord = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtPronounciation = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtDerive = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.contextDerive = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnDeriveChinese = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDeriveEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDeriveVietnamese = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDerivePali = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEtymology = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny4 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtAbbreviations = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNotes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny5 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btNewEntry = New System.Windows.Forms.ToolStripButton()
        Me.btSaveEntry = New System.Windows.Forms.ToolStripButton()
        Me.btFinish = New System.Windows.Forms.ToolStripButton()
        Me.btDeleteEntry = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBold = New System.Windows.Forms.ToolStripButton()
        Me.btItalic = New System.Windows.Forms.ToolStripButton()
        Me.btUnderline = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.btTable = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btColors = New System.Windows.Forms.ToolStripButton()
        Me.btTextColors = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btClearFormating = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btReplace = New System.Windows.Forms.ToolStripButton()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.txtCode = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.contextEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnUpcase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLowcase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnTittleCase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnFindReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonCheckBox1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.contextEtymology = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.autoAbbreviations = New AutocompleteMenuNS.AutocompleteMenu()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.contextDerive.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.contextEdit.SuspendLayout()
        Me.contextEtymology.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtWord, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPronounciation, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDerive, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEtymology, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAbbreviations, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNotes, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStrip2, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl2, 1, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(831, 363)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(8, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Notes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(8, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Abbreviations"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(8, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(94, 30)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Content"
        '
        'txtWord
        '
        Me.autoAbbreviations.SetAutocompleteMenu(Me.txtWord, Nothing)
        Me.txtWord.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny2})
        Me.txtWord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWord.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWord.Location = New System.Drawing.Point(105, 5)
        Me.txtWord.Margin = New System.Windows.Forms.Padding(0)
        Me.txtWord.Name = "txtSearchEntry"
        Me.txtWord.Size = New System.Drawing.Size(721, 24)
        Me.txtWord.TabIndex = 0
        '
        'ButtonSpecAny2
        '
        Me.ButtonSpecAny2.Image = CType(resources.GetObject("ButtonSpecAny2.Image"), System.Drawing.Image)
        Me.ButtonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Previous
        Me.ButtonSpecAny2.UniqueName = "A050A1FD61D042A4078C613BFC5067EF"
        '
        'txtPronounciation
        '
        Me.autoAbbreviations.SetAutocompleteMenu(Me.txtPronounciation, Nothing)
        Me.txtPronounciation.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny3})
        Me.txtPronounciation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPronounciation.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPronounciation.Location = New System.Drawing.Point(105, 30)
        Me.txtPronounciation.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPronounciation.Name = "txtSearchEntry"
        Me.txtPronounciation.Size = New System.Drawing.Size(721, 24)
        Me.txtPronounciation.TabIndex = 0
        '
        'ButtonSpecAny3
        '
        Me.ButtonSpecAny3.Image = CType(resources.GetObject("ButtonSpecAny3.Image"), System.Drawing.Image)
        Me.ButtonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Previous
        Me.ButtonSpecAny3.UniqueName = "BE872B7DE2E24F08A9B71AACBC5A6DC7"
        '
        'txtDerive
        '
        Me.autoAbbreviations.SetAutocompleteMenu(Me.txtDerive, Nothing)
        Me.txtDerive.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1})
        Me.txtDerive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDerive.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDerive.Location = New System.Drawing.Point(105, 55)
        Me.txtDerive.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDerive.Name = "txtSearchEntry"
        Me.txtDerive.Size = New System.Drawing.Size(721, 24)
        Me.txtDerive.TabIndex = 0
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ContextMenuStrip = Me.contextDerive
        Me.ButtonSpecAny1.Image = CType(resources.GetObject("ButtonSpecAny1.Image"), System.Drawing.Image)
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.ButtonSpecAny1.UniqueName = "427DABD3E0064AD93CA2FEF7D10917D1"
        '
        'contextDerive
        '
        Me.contextDerive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contextDerive.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDeriveChinese, Me.mnDeriveEnglish, Me.mnDeriveVietnamese, Me.mnDerivePali})
        Me.contextDerive.Name = "contextEdit"
        Me.contextDerive.Size = New System.Drawing.Size(165, 92)
        '
        'mnDeriveChinese
        '
        Me.mnDeriveChinese.Name = "mnDeriveChinese"
        Me.mnDeriveChinese.Size = New System.Drawing.Size(164, 22)
        Me.mnDeriveChinese.Text = "C: -> Chinese"
        '
        'mnDeriveEnglish
        '
        Me.mnDeriveEnglish.Name = "mnDeriveEnglish"
        Me.mnDeriveEnglish.Size = New System.Drawing.Size(164, 22)
        Me.mnDeriveEnglish.Text = "E: -> English"
        '
        'mnDeriveVietnamese
        '
        Me.mnDeriveVietnamese.Name = "mnDeriveVietnamese"
        Me.mnDeriveVietnamese.Size = New System.Drawing.Size(164, 22)
        Me.mnDeriveVietnamese.Text = "V: -> Vietnamese"
        '
        'mnDerivePali
        '
        Me.mnDerivePali.Name = "mnDerivePali"
        Me.mnDerivePali.Size = New System.Drawing.Size(164, 22)
        Me.mnDerivePali.Text = "P: -> Pali"
        '
        'txtEtymology
        '
        Me.autoAbbreviations.SetAutocompleteMenu(Me.txtEtymology, Nothing)
        Me.txtEtymology.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny4})
        Me.txtEtymology.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEtymology.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtymology.Location = New System.Drawing.Point(105, 80)
        Me.txtEtymology.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEtymology.Name = "txtSearchEntry"
        Me.txtEtymology.Size = New System.Drawing.Size(721, 24)
        Me.txtEtymology.TabIndex = 0
        Me.txtEtymology.Text = "√"
        '
        'ButtonSpecAny4
        '
        Me.ButtonSpecAny4.Image = CType(resources.GetObject("ButtonSpecAny4.Image"), System.Drawing.Image)
        Me.ButtonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.[Next]
        Me.ButtonSpecAny4.UniqueName = "D563995A464045820E9E8D7D83F466A9"
        '
        'txtAbbreviations
        '
        Me.autoAbbreviations.SetAutocompleteMenu(Me.txtAbbreviations, Me.autoAbbreviations)
        Me.txtAbbreviations.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1})
        Me.txtAbbreviations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAbbreviations.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbbreviations.Location = New System.Drawing.Point(105, 105)
        Me.txtAbbreviations.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAbbreviations.Name = "txtSearchEntry"
        Me.txtAbbreviations.Size = New System.Drawing.Size(721, 24)
        Me.txtAbbreviations.TabIndex = 0
        '
        'txtNotes
        '
        Me.autoAbbreviations.SetAutocompleteMenu(Me.txtNotes, Me.autoAbbreviations)
        Me.txtNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtNotes.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny5})
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(105, 130)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(721, 24)
        Me.txtNotes.TabIndex = 0
        '
        'ButtonSpecAny5
        '
        Me.ButtonSpecAny5.Image = CType(resources.GetObject("ButtonSpecAny5.Image"), System.Drawing.Image)
        Me.ButtonSpecAny5.UniqueName = "AD710D50904444A867BE2BBD2C342F66"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Word"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNewEntry, Me.btSaveEntry, Me.btFinish, Me.btDeleteEntry, Me.ToolStripSeparator1, Me.btBold, Me.btItalic, Me.btUnderline, Me.ToolStripSeparator3, Me.btParaLeft, Me.btParaCenter, Me.btParaRight, Me.ToolStripSeparator4, Me.btUL, Me.btuLNum, Me.btIndent, Me.btOutdent, Me.ToolStripSeparator5, Me.btLink, Me.btSubscript, Me.btSuperScript, Me.btLine, Me.btTable, Me.ToolStripSeparator6, Me.btColors, Me.btTextColors, Me.ToolStripSeparator7, Me.btClearFormating, Me.ToolStripSeparator2, Me.btReplace})
        Me.ToolStrip2.Location = New System.Drawing.Point(108, 160)
        Me.ToolStrip2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(715, 25)
        Me.ToolStrip2.TabIndex = 18
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btNewEntry
        '
        Me.btNewEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btNewEntry.Image = CType(resources.GetObject("btNewEntry.Image"), System.Drawing.Image)
        Me.btNewEntry.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNewEntry.Name = "btNewEntry"
        Me.btNewEntry.Size = New System.Drawing.Size(23, 22)
        Me.btNewEntry.Text = "New entry"
        '
        'btSaveEntry
        '
        Me.btSaveEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btSaveEntry.Image = CType(resources.GetObject("btSaveEntry.Image"), System.Drawing.Image)
        Me.btSaveEntry.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSaveEntry.Name = "btSaveEntry"
        Me.btSaveEntry.Size = New System.Drawing.Size(23, 22)
        Me.btSaveEntry.Text = "Save entry"
        '
        'btFinish
        '
        Me.btFinish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btFinish.Image = Global.Dictionary_Maker.My.Resources.Resources.agt_action_success
        Me.btFinish.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btFinish.Name = "btFinish"
        Me.btFinish.Size = New System.Drawing.Size(23, 22)
        Me.btFinish.Text = "Finish"
        '
        'btDeleteEntry
        '
        Me.btDeleteEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btDeleteEntry.Image = CType(resources.GetObject("btDeleteEntry.Image"), System.Drawing.Image)
        Me.btDeleteEntry.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btDeleteEntry.Name = "btDeleteEntry"
        Me.btDeleteEntry.Size = New System.Drawing.Size(23, 22)
        Me.btDeleteEntry.Text = "Delete entry"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'btTable
        '
        Me.btTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btTable.Image = Global.Dictionary_Maker.My.Resources.Resources.InsertTable
        Me.btTable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btTable.Name = "btTable"
        Me.btTable.Size = New System.Drawing.Size(23, 22)
        Me.btTable.Text = "Table"
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
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(108, 188)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(715, 167)
        Me.TabControl2.TabIndex = 21
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.txtCode)
        Me.TabPage8.ImageIndex = 7
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(707, 141)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "Code"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.autoAbbreviations.SetAutocompleteMenu(Me.txtCode, Nothing)
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Location = New System.Drawing.Point(3, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(701, 135)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Text = ""
        '
        'contextEdit
        '
        Me.contextEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contextEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnCut, Me.mnCopy, Me.mnPaste, Me.ToolStripSeparator8, Me.mnUpcase, Me.mnLowcase, Me.mnTittleCase, Me.ToolStripSeparator9, Me.mnFindReplace})
        Me.contextEdit.Name = "contextEdit"
        Me.contextEdit.Size = New System.Drawing.Size(165, 170)
        '
        'mnCut
        '
        Me.mnCut.Image = Global.Dictionary_Maker.My.Resources.Resources.Cut
        Me.mnCut.Name = "mnCut"
        Me.mnCut.Size = New System.Drawing.Size(164, 22)
        Me.mnCut.Text = "Cut"
        '
        'mnCopy
        '
        Me.mnCopy.Image = Global.Dictionary_Maker.My.Resources.Resources.Copy
        Me.mnCopy.Name = "mnCopy"
        Me.mnCopy.Size = New System.Drawing.Size(164, 22)
        Me.mnCopy.Text = "Copy"
        '
        'mnPaste
        '
        Me.mnPaste.Image = Global.Dictionary_Maker.My.Resources.Resources.Paste
        Me.mnPaste.Name = "mnPaste"
        Me.mnPaste.Size = New System.Drawing.Size(164, 22)
        Me.mnPaste.Text = "Paste"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(161, 6)
        '
        'mnUpcase
        '
        Me.mnUpcase.Name = "mnUpcase"
        Me.mnUpcase.Size = New System.Drawing.Size(164, 22)
        Me.mnUpcase.Text = "UPCASE"
        '
        'mnLowcase
        '
        Me.mnLowcase.Name = "mnLowcase"
        Me.mnLowcase.Size = New System.Drawing.Size(164, 22)
        Me.mnLowcase.Text = "lowcase"
        '
        'mnTittleCase
        '
        Me.mnTittleCase.Name = "mnTittleCase"
        Me.mnTittleCase.Size = New System.Drawing.Size(164, 22)
        Me.mnTittleCase.Text = "Tittle Case"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(161, 6)
        '
        'mnFindReplace
        '
        Me.mnFindReplace.Name = "mnFindReplace"
        Me.mnFindReplace.Size = New System.Drawing.Size(164, 22)
        Me.mnFindReplace.Text = "Find and Replace"
        '
        'KryptonCheckBox1
        '
        Me.KryptonCheckBox1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonCheckBox1.Name = "KryptonCheckBox1"
        Me.KryptonCheckBox1.TabIndex = 0
        '
        'contextEtymology
        '
        Me.contextEtymology.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contextEtymology.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripSeparator10, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripSeparator11, Me.ToolStripMenuItem7})
        Me.contextEtymology.Name = "contextEdit"
        Me.contextEtymology.Size = New System.Drawing.Size(165, 170)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Dictionary_Maker.My.Resources.Resources.Cut
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem1.Text = "Cut"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Dictionary_Maker.My.Resources.Resources.Copy
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem2.Text = "Copy"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.Dictionary_Maker.My.Resources.Resources.Paste
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem3.Text = "Paste"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem4.Text = "UPCASE"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem5.Text = "lowcase"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem6.Text = "Tittle Case"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem7.Text = "Find and Replace"
        '
        'autoAbbreviations
        '
        Me.autoAbbreviations.Colors = CType(resources.GetObject("autoAbbreviations.Colors"), AutocompleteMenuNS.Colors)
        Me.autoAbbreviations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.autoAbbreviations.ImageList = Nothing
        Me.autoAbbreviations.Items = New String(-1) {}
        Me.autoAbbreviations.TargetControlWrapper = Nothing
        '
        'frmInputData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 363)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputData"
        Me.Text = "Input"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.contextDerive.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.contextEdit.ResumeLayout(False)
        Me.contextEtymology.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Private WithEvents txtWord As KryptonTextBox
    Private WithEvents txtPronounciation As KryptonTextBox
    Private WithEvents txtDerive As KryptonTextBox
    Private WithEvents txtEtymology As KryptonTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btBold As ToolStripButton
    Friend WithEvents btItalic As ToolStripButton
    Friend WithEvents btUnderline As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
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
    Friend WithEvents btTable As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btColors As ToolStripButton
    Friend WithEvents btTextColors As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents btClearFormating As ToolStripButton
    Friend WithEvents btSaveEntry As ToolStripButton
    Friend WithEvents btFinish As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btNewEntry As ToolStripButton
    Friend WithEvents btDeleteEntry As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btReplace As ToolStripButton
    Friend WithEvents contextEdit As ContextMenuStrip
    Friend WithEvents mnCut As ToolStripMenuItem
    Friend WithEvents mnCopy As ToolStripMenuItem
    Friend WithEvents mnPaste As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents mnUpcase As ToolStripMenuItem
    Friend WithEvents mnLowcase As ToolStripMenuItem
    Friend WithEvents mnTittleCase As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents mnFindReplace As ToolStripMenuItem
    Private WithEvents KryptonCheckBox1 As KryptonCheckBox
    Friend WithEvents contextDerive As ContextMenuStrip
    Friend WithEvents mnDeriveChinese As ToolStripMenuItem
    Friend WithEvents mnDeriveEnglish As ToolStripMenuItem
    Friend WithEvents mnDeriveVietnamese As ToolStripMenuItem
    Friend WithEvents mnDerivePali As ToolStripMenuItem
    Friend WithEvents ButtonSpecAny1 As ButtonSpecAny
    Friend WithEvents contextEtymology As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents Label5 As Label
    Private WithEvents txtAbbreviations As KryptonTextBox
    Friend WithEvents autoAbbreviations As AutocompleteMenuNS.AutocompleteMenu
    Private WithEvents txtNotes As KryptonTextBox
    Friend WithEvents ButtonSpecAny2 As ButtonSpecAny
    Friend WithEvents ButtonSpecAny3 As ButtonSpecAny
    Friend WithEvents ButtonSpecAny4 As ButtonSpecAny
    Friend WithEvents ButtonSpecAny5 As ButtonSpecAny
    Friend WithEvents Label6 As Label
    Private WithEvents txtCode As KryptonRichTextBox
End Class
