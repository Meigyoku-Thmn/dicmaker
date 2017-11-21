Imports System
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Windows.Forms
Imports WeifenLuo.WinFormsUI.Docking

Public Class frmMDI

    Dim frmDic As frmDictionary
    Private WithEvents _frmProjectCenter As ProjectCenter
    Dim _ProjectManage As New ProjectManager
    Public frmInput As frmEntry2 = New frmEntry2
    Public frmWordList As frmWordList = New frmWordList
    ' Public frmSymbol As frmSymbol = New frmSymbol
    Public frmAttribtes As frmAttributes = New frmAttributes
    Public frmView As frmWebView = New frmWebView
    Private Sub _frmProjectCenter_Opening(ByVal isOpeing As Boolean) Handles _frmProjectCenter.Opening
        If isOpeing = False Then
            ' MsgBox("opeing ")
        End If

    End Sub
    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadDesign()
        Catch ex As Exception
            Dim randomproject As String = _ProjectManage.RandomProject
            _ProjectManage.ChangeCurrentProject(randomproject)
            LoadDesign()
        End Try

    End Sub

    Public Sub LoadDesign()
        AutoScaleMode = AutoScaleMode.Dpi

        btSave.Enabled = False
        btDelete.Enabled = False

        _ProjectManage.FindCurrentProject()

        If mUniform.ProjectTable = "" Then
            btBegining.Enabled = False
            btUpward.Enabled = False
            btDownward.Enabled = False
            btEnd.Enabled = False
        End If

        mUniform.StyleCSS = "Default"
        Me.Text = "Tummo Dictionary Maker - [" & mUniform.ProjectName & "]"
        'dockPanel.hi
        frmWordList.Show(dockPanel, DockState.DockLeft)
        frmWordList.CloseButtonVisible = False

        'frmDic = New frmDictionary
        ' frmDic.Show(dockPanel, DockState.DockLeft)

        frmView.Show(dockPanel, DockState.DockRight)
        frmView.CloseButtonVisible = False

        frmInput.Show(dockPanel, DockState.Document)
        frmInput.CloseButtonVisible = False
        'frmInput.Text = "New Entry"

        '  frmSymbol.Show(dockPanel, DockState.DockLeftAutoHide)
        'frmSymbol.CloseButtonVisible = False

        frmAttribtes.Show(dockPanel, DockState.DockLeftAutoHide)
        frmAttribtes.CloseButtonVisible = False
        ' ImportWordList()
    End Sub


    ' ---------------
    ' MENU
    Private Sub File_newProject_Click(sender As Object, e As EventArgs) Handles mnFile_newProject.Click
        _frmProjectCenter = New ProjectCenter
        _frmProjectCenter.Show()
    End Sub

    Private Sub btNewEntry_Click(sender As Object, e As EventArgs) Handles btNewEntry.Click
        btSave.Enabled = True

        frmInput.NewEntry()

        EnableInput(True)
    End Sub

    Public Sub EnableInput(_enabled As Boolean)
        'frmInput.EnableInput(Enabled)
    End Sub

    Private Sub mnImportCSV_Click(sender As Object, e As EventArgs) Handles mnImportCSV.Click
        frmImport.Show()
    End Sub

    Private Sub mnImportXML_Click(sender As Object, e As EventArgs) Handles mnImportXML.Click
        frmImportXML.Show()
    End Sub

    Private Sub mnAttributes_Click(sender As Object, e As EventArgs) Handles mnAttributes.Click
        frmIndex.Show()
    End Sub

    Private Sub mnExport_Click(sender As Object, e As EventArgs) Handles mnExport.Click
        Dim frmExport1 As frmExport = New frmExport

        frmExport1.Show(Me)
    End Sub

    Private Sub mnExit_Click(sender As Object, e As EventArgs) Handles mnExit.Click
        Me.Close()
    End Sub

    Private Sub mnTextViewer_Click(sender As Object, e As EventArgs) Handles mnTextViewer.Click
        Dim frmTextViewer As frmTextView = New frmTextView
        frmTextViewer.Show(dockPanel, DockState.DockRight)
    End Sub

    Private Sub AboutUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUSToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub mnNewProject1_Click(sender As Object, e As EventArgs) Handles mnNewProject1.Click
        frmNewProject.Show()
    End Sub

    Private Sub mnWebsite_Click(sender As Object, e As EventArgs) Handles mnWebsite.Click
        Dim webpage As String = "https://tummosoftware.com"
        Process.Start(webpage)
    End Sub

    Private Sub mnFacebook_Click(sender As Object, e As EventArgs) Handles mnFacebook.Click
        Dim webpage As String = "https://facebook.com/tummosoft"
        Process.Start(webpage)
    End Sub

    Private Sub btUpward_Click(sender As Object, e As EventArgs) Handles btUpward.Click
        frmWordList.BackRowSelect()
    End Sub

    Private Sub btDownward_Click(sender As Object, e As EventArgs) Handles btDownward.Click
        frmWordList.NextRowSelect()
    End Sub

    Private Sub btBegining_Click(sender As Object, e As EventArgs) Handles btBegining.Click
        frmWordList.BackFirstRow()
    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click
        frmWordList.GoEndRow()
    End Sub

    Private Sub mnFile_openProject_Click(sender As Object, e As EventArgs) Handles mnFile_openProject.Click
        ProjectCenter.Show()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        frmInput.SaveEntry()
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim rangeWord As List(Of String) = frmWordList.SelectedRange
        Dim length As Integer = rangeWord.Count
        If length > 0 Then
            Dim asked = MsgBox("Are you sure delete " & length & " entries?", MsgBoxStyle.YesNo)
            If asked = MsgBoxResult.Yes Then
                For Each w1 In rangeWord
                    _ProjectManage.DeleteRow(mUniform.ProjectTable, "word", w1)
                Next

                frmWordList.ImportWordList("", 0)
            End If


        Else
            Dim asked = MsgBox("Are you sure delete entry '" & mUniform._word & "' ?", MsgBoxStyle.YesNo)
            If asked = MsgBoxResult.Yes Then
                _ProjectManage.DeleteRow(mUniform.ProjectTable, "word", mUniform._word)
                frmWordList.ImportWordList("", 0)
            End If
        End If

    End Sub

    Private Sub mnImageViewer_Click(sender As Object, e As EventArgs) Handles mnImageViewer.Click
        Dim frmImageView As frmImageViewer = New frmImageViewer
        frmImageView.Show(dockPanel, DockState.DockRight)
    End Sub

    Private Sub btInternet_Click(sender As Object, e As EventArgs) Handles btInternet.Click
        Dim frmImageView As frmInternetExplorer = New frmInternetExplorer
        frmImageView.Show(dockPanel, DockState.DockRight)
    End Sub


End Class