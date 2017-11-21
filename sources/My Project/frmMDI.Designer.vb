Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFile_newProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnNewProject1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFile_openProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFile_closedProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindAndReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEntry_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEntry_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnEntry_Import = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnImportCSV = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnImportXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAttributes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnTextViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnImageViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btInternet = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnWebsite = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnFacebook = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btNewEntry = New System.Windows.Forms.ToolStripButton()
        Me.btSave = New System.Windows.Forms.ToolStripButton()
        Me.btDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBegining = New System.Windows.Forms.ToolStripButton()
        Me.btUpward = New System.Windows.Forms.ToolStripButton()
        Me.btDownward = New System.Windows.Forms.ToolStripButton()
        Me.btEnd = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblWord = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEntry = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dockPanel = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnFile, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnFile
        '
        Me.mnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnFile_newProject, Me.mnFile_openProject, Me.mnFile_closedProject, Me.ToolStripSeparator2, Me.mnExport, Me.ToolStripSeparator3, Me.mnExit})
        Me.mnFile.Name = "mnFile"
        Me.mnFile.Size = New System.Drawing.Size(37, 20)
        Me.mnFile.Text = "File"
        '
        'mnFile_newProject
        '
        Me.mnFile_newProject.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNewProject1})
        Me.mnFile_newProject.Image = CType(resources.GetObject("mnFile_newProject.Image"), System.Drawing.Image)
        Me.mnFile_newProject.Name = "mnFile_newProject"
        Me.mnFile_newProject.Size = New System.Drawing.Size(152, 22)
        Me.mnFile_newProject.Text = "New"
        '
        'mnNewProject1
        '
        Me.mnNewProject1.Name = "mnNewProject1"
        Me.mnNewProject1.Size = New System.Drawing.Size(138, 22)
        Me.mnNewProject1.Text = "New Project"
        '
        'mnFile_openProject
        '
        Me.mnFile_openProject.Image = CType(resources.GetObject("mnFile_openProject.Image"), System.Drawing.Image)
        Me.mnFile_openProject.Name = "mnFile_openProject"
        Me.mnFile_openProject.Size = New System.Drawing.Size(152, 22)
        Me.mnFile_openProject.Text = "Open Project"
        '
        'mnFile_closedProject
        '
        Me.mnFile_closedProject.Image = CType(resources.GetObject("mnFile_closedProject.Image"), System.Drawing.Image)
        Me.mnFile_closedProject.Name = "mnFile_closedProject"
        Me.mnFile_closedProject.Size = New System.Drawing.Size(152, 22)
        Me.mnFile_closedProject.Text = "Close"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'mnExport
        '
        Me.mnExport.Image = CType(resources.GetObject("mnExport.Image"), System.Drawing.Image)
        Me.mnExport.Name = "mnExport"
        Me.mnExport.Size = New System.Drawing.Size(152, 22)
        Me.mnExport.Text = "Export"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'mnExit
        '
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(152, 22)
        Me.mnExit.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator5, Me.FindAndReplaceToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.Dictionary_Maker.My.Resources.Resources.Copy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.Dictionary_Maker.My.Resources.Resources.Paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(161, 6)
        '
        'FindAndReplaceToolStripMenuItem
        '
        Me.FindAndReplaceToolStripMenuItem.Image = Global.Dictionary_Maker.My.Resources.Resources.Find
        Me.FindAndReplaceToolStripMenuItem.Name = "FindAndReplaceToolStripMenuItem"
        Me.FindAndReplaceToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FindAndReplaceToolStripMenuItem.Text = "Find and Replace"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnEntry_New, Me.mnEntry_Delete, Me.ToolStripSeparator4, Me.mnEntry_Import})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ViewToolStripMenuItem.Text = "Entry"
        '
        'mnEntry_New
        '
        Me.mnEntry_New.Image = CType(resources.GetObject("mnEntry_New.Image"), System.Drawing.Image)
        Me.mnEntry_New.Name = "mnEntry_New"
        Me.mnEntry_New.Size = New System.Drawing.Size(137, 22)
        Me.mnEntry_New.Text = "New entry"
        '
        'mnEntry_Delete
        '
        Me.mnEntry_Delete.Image = CType(resources.GetObject("mnEntry_Delete.Image"), System.Drawing.Image)
        Me.mnEntry_Delete.Name = "mnEntry_Delete"
        Me.mnEntry_Delete.Size = New System.Drawing.Size(137, 22)
        Me.mnEntry_Delete.Text = "Delete entry"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(134, 6)
        '
        'mnEntry_Import
        '
        Me.mnEntry_Import.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnImportCSV, Me.mnImportXML})
        Me.mnEntry_Import.Image = CType(resources.GetObject("mnEntry_Import.Image"), System.Drawing.Image)
        Me.mnEntry_Import.Name = "mnEntry_Import"
        Me.mnEntry_Import.Size = New System.Drawing.Size(137, 22)
        Me.mnEntry_Import.Text = "Import"
        '
        'mnImportCSV
        '
        Me.mnImportCSV.Name = "mnImportCSV"
        Me.mnImportCSV.Size = New System.Drawing.Size(307, 22)
        Me.mnImportCSV.Text = "Import entries from CSV"
        '
        'mnImportXML
        '
        Me.mnImportXML.Name = "mnImportXML"
        Me.mnImportXML.Size = New System.Drawing.Size(307, 22)
        Me.mnImportXML.Text = "Import entries from Tummo Dictionary XML"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAttributes, Me.ToolStripSeparator9, Me.mnTextViewer, Me.ToolStripSeparator8, Me.mnImageViewer, Me.ToolStripSeparator10, Me.btInternet, Me.ToolStripSeparator11})
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ToolToolStripMenuItem.Text = "Tool"
        '
        'mnAttributes
        '
        Me.mnAttributes.Image = CType(resources.GetObject("mnAttributes.Image"), System.Drawing.Image)
        Me.mnAttributes.Name = "mnAttributes"
        Me.mnAttributes.Size = New System.Drawing.Size(160, 22)
        Me.mnAttributes.Text = "References"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(157, 6)
        '
        'mnTextViewer
        '
        Me.mnTextViewer.Image = CType(resources.GetObject("mnTextViewer.Image"), System.Drawing.Image)
        Me.mnTextViewer.Name = "mnTextViewer"
        Me.mnTextViewer.Size = New System.Drawing.Size(160, 22)
        Me.mnTextViewer.Text = "Text Viewer"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(157, 6)
        '
        'mnImageViewer
        '
        Me.mnImageViewer.Image = CType(resources.GetObject("mnImageViewer.Image"), System.Drawing.Image)
        Me.mnImageViewer.Name = "mnImageViewer"
        Me.mnImageViewer.Size = New System.Drawing.Size(160, 22)
        Me.mnImageViewer.Text = "Image Viewer"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(157, 6)
        '
        'btInternet
        '
        Me.btInternet.Image = CType(resources.GetObject("btInternet.Image"), System.Drawing.Image)
        Me.btInternet.Name = "btInternet"
        Me.btInternet.Size = New System.Drawing.Size(160, 22)
        Me.btInternet.Text = "Internet Explorer"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(157, 6)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnWebsite, Me.ToolStripSeparator6, Me.mnFacebook, Me.ToolStripSeparator7, Me.AboutUSToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'mnWebsite
        '
        Me.mnWebsite.Image = CType(resources.GetObject("mnWebsite.Image"), System.Drawing.Image)
        Me.mnWebsite.Name = "mnWebsite"
        Me.mnWebsite.Size = New System.Drawing.Size(125, 22)
        Me.mnWebsite.Text = "Website"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(122, 6)
        '
        'mnFacebook
        '
        Me.mnFacebook.Image = CType(resources.GetObject("mnFacebook.Image"), System.Drawing.Image)
        Me.mnFacebook.Name = "mnFacebook"
        Me.mnFacebook.Size = New System.Drawing.Size(125, 22)
        Me.mnFacebook.Text = "Facebook"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(122, 6)
        '
        'AboutUSToolStripMenuItem
        '
        Me.AboutUSToolStripMenuItem.Image = CType(resources.GetObject("AboutUSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutUSToolStripMenuItem.Name = "AboutUSToolStripMenuItem"
        Me.AboutUSToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AboutUSToolStripMenuItem.Text = "About US"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNewEntry, Me.btSave, Me.btDelete, Me.ToolStripSeparator1, Me.btBegining, Me.btUpward, Me.btDownward, Me.btEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(690, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'btSave
        '
        Me.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(23, 22)
        Me.btSave.Text = "Save entry"
        '
        'btDelete
        '
        Me.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(23, 22)
        Me.btDelete.Text = "Delete entry"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btBegining
        '
        Me.btBegining.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btBegining.Image = CType(resources.GetObject("btBegining.Image"), System.Drawing.Image)
        Me.btBegining.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBegining.Name = "btBegining"
        Me.btBegining.Size = New System.Drawing.Size(23, 22)
        Me.btBegining.Text = "Scroll to the begining"
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
        'btEnd
        '
        Me.btEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btEnd.Image = CType(resources.GetObject("btEnd.Image"), System.Drawing.Image)
        Me.btEnd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEnd.Name = "btEnd"
        Me.btEnd.Size = New System.Drawing.Size(23, 22)
        Me.btEnd.Text = "Scroll to the end"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblWord, Me.ToolStripStatusLabel2, Me.lblEntry})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 337)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(690, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Word:"
        '
        'lblWord
        '
        Me.lblWord.ForeColor = System.Drawing.Color.Crimson
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(35, 17)
        Me.lblWord.Text = "Hello"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel2.Text = "Entries:"
        '
        'lblEntry
        '
        Me.lblEntry.ForeColor = System.Drawing.Color.Crimson
        Me.lblEntry.Name = "lblEntry"
        Me.lblEntry.Size = New System.Drawing.Size(25, 17)
        Me.lblEntry.Text = "123"
        '
        'dockPanel
        '
        Me.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockPanel.DockBottomPortion = 100.0R
        Me.dockPanel.DockLeftPortion = 200.0R
        Me.dockPanel.DockRightPortion = 350.0R
        Me.dockPanel.DockTopPortion = 100.0R
        Me.dockPanel.Location = New System.Drawing.Point(0, 49)
        Me.dockPanel.Name = "dockPanel"
        Me.dockPanel.Size = New System.Drawing.Size(690, 288)
        Me.dockPanel.TabIndex = 4
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 359)
        Me.Controls.Add(Me.dockPanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tummo Dictionary Maker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents mnFile As ToolStripMenuItem
    Friend WithEvents btNewEntry As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents dockPanel As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents btSave As ToolStripButton
    Friend WithEvents btDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnFile_newProject As ToolStripMenuItem
    Friend WithEvents mnFile_openProject As ToolStripMenuItem
    Friend WithEvents mnFile_closedProject As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnExport As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnExit As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btBegining As ToolStripButton
    Friend WithEvents ToolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btUpward As ToolStripButton
    Friend WithEvents mnEntry_New As ToolStripMenuItem
    Friend WithEvents mnEntry_Delete As ToolStripMenuItem
    Friend WithEvents btDownward As ToolStripButton
    Friend WithEvents btEnd As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnEntry_Import As ToolStripMenuItem
    Friend WithEvents mnImportCSV As ToolStripMenuItem
    Friend WithEvents mnImportXML As ToolStripMenuItem
    Friend WithEvents mnNewProject1 As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents FindAndReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnAttributes As ToolStripMenuItem
    Friend WithEvents mnWebsite As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents mnFacebook As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents AboutUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents mnTextViewer As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents mnImageViewer As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents btInternet As ToolStripMenuItem
    Friend WithEvents lblWord As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblEntry As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
End Class
