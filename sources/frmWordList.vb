Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite
Imports WeifenLuo.WinFormsUI.Docking
Imports Zuby.ADGV

Partial Public Class frmWordList
    Inherits DockContent
    Dim newproject As New ProjectManager
    Dim SQLconnect As SQLiteConnection = New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    Dim Path1 As New TummoPath

    Dim _tablename As String
    Dim _status As Integer
    Private _dataTable As DataTable = Nothing
    Private _dataSet As DataSet = Nothing
    Dim build1 As New BuildCode
    Public _css As String
    Dim oldStyle As String
    Dim _rowIndex As Integer
    'Dim dicAttributes As New Dictionary(Of String, String)
    Private Sub frmWordList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLconnect.ConnectionString = "Data Source=" & Path1.PathOfProject & "\project.db;Version=3;Legacy Format=True;SQLITE_THREADSAFE=2;"
        SQLconnect.Open()
        'mUniform.ProjectTable = "new_table"
        _tablename = mUniform.ProjectTable

        _dataTable = New DataTable()
        _dataSet = New DataSet()

        _status = 0
        bindingSource_main.DataSource = _dataSet

        _dataTable = _dataSet.Tables.Add("TableTest")
        _dataTable.Columns.Add("selected", GetType(Boolean))
        _dataTable.Columns.Add("status", GetType(Bitmap))
        _dataTable.Columns.Add("word", GetType(String))

        bindingSource_main.DataMember = _dataTable.TableName
        gridWords.Columns.Clear()
        ImportWordList("", 0)
        _css = newproject.LoadStyle(mUniform.StyleCSS)
        oldStyle = mUniform.StyleCSS

        gridWords.DefaultCellStyle.SelectionBackColor = Color.FromArgb(114, 204, 255)
        gridWords.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 25, 200)
    End Sub

    Private Sub frmWordList_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        gridWords.Columns.Item(2).Width = Me.Width - 90
    End Sub

    Private Sub contextFilter_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles contextFilter.ItemClicked

        If e.ClickedItem.Text = "Incomplete" Then
            '  newproject.ImportWordList(gridWords, ImageList1, mUniform.ProjectTable, 1, "")
        ElseIf e.ClickedItem.Text = "Complete" Then
            'newproject.ImportWordList(gridWords, ImageList1, mUniform.ProjectTable, 2, "")
        Else
            'newproject.ImportWordList(gridWords, ImageList1, mUniform.ProjectTable, 0, "")
        End If
        '

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        If EntryReady = True Then
            'newproject.ImportWordList(gridWords, ImageList1, mUniform.ProjectTable, 0, txtSearch.Text)
        End If

    End Sub

    Public Sub ImportWordList(v As String, filter As Integer)
        'gridWords.BackgroundColor = Color.White
        SQLcommand = SQLconnect.CreateCommand

        If v = "" Then
            If filter = 0 Then
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable
            ElseIf filter = 1 Then
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '0'"
            ElseIf filter = 2 Then
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '1'"
            End If
        Else
            SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE word LIKE '" & v.ToLower & "%'"
        End If

        ' SQLcommand.CommandText = "SELECT * FROM new_table"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        _dataTable.Rows.Clear()
        Dim i As Integer = 0
        While SQLreader.Read()
            'gridWords.Rows.Add()
            Dim id As Object = SQLreader(0)
            Dim status As Object = SQLreader(1)
            Dim word As String = SQLreader(2).ToString
            Dim content As String = SQLreader(3).ToString

            Dim sampleimages As Image() = New Image(1) {}
            sampleimages(0) = Image.FromFile(Path.Combine(Application.StartupPath, "img\incomplete.png"))
            sampleimages(1) = Image.FromFile(Path.Combine(Application.StartupPath, "img\completed.png"))
            Dim newrow As Object()

            If status = 0 Then
                newrow = New Object() {False, sampleimages(0), word}
            Else
                newrow = New Object() {False, sampleimages(1), word}
            End If

            _dataTable.Rows.Add(newrow)

            i = i + 1

        End While
        SQLcommand.Dispose()
        EntryReady = True

        gridWords.DataSource = _dataTable
        gridWords.Columns.Item(0).Width = 30
        gridWords.Columns.Item(1).Width = 30
        gridWords.Columns.Item(2).Width = 150
        'gridWords.DataBindings()
        'Throw New NotImplementedException()
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        ImportWordList(txtSearch.Text, _status)
    End Sub

    Private Sub gridWords_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gridWords.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub mnFilter0_Click(sender As Object, e As EventArgs) Handles mnFilter0.Click
        mnFilter0.Checked = True
        If mnFilter1.Checked = True Then
            mnFilter1.Checked = False
        End If
        If mnFilter2.Checked = True Then
            mnFilter2.Checked = False
        End If
        ImportWordList("", 0)
        _status = 0
    End Sub

    Private Sub mnFilter1_Click(sender As Object, e As EventArgs) Handles mnFilter1.Click
        mnFilter1.Checked = True
        If mnFilter0.Checked = True Then
            mnFilter0.Checked = False
        End If
        If mnFilter2.Checked = True Then
            mnFilter2.Checked = False
        End If
        ImportWordList("", 2)
        _status = 2
    End Sub

    Private Sub mnFilter2_Click(sender As Object, e As EventArgs) Handles mnFilter2.Click
        mnFilter2.Checked = True
        If mnFilter0.Checked = True Then
            mnFilter0.Checked = False
        End If
        If mnFilter1.Checked = True Then
            mnFilter1.Checked = False
        End If
        ImportWordList("", 1)
        _status = 1
    End Sub

    Private Sub gridWords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridWords.CellClick
        If gridWords.RowCount - 1 > 0 Then

            Dim completed As String = gridWords.Item(1, e.RowIndex).Tag

            If frmMDI.btDelete.Enabled = False Then
                frmMDI.btDelete.Enabled = True
            End If

            mUniform._word = gridWords.Item(2, e.RowIndex).Value
            frmMDI.lblWord.Text = mUniform._word
            If mUniform._word <> "" Then

                If oldStyle <> mUniform.StyleCSS Then
                    _css = newproject.LoadStyle(mUniform.StyleCSS)
                    oldStyle = mUniform.StyleCSS
                End If

                Dim code As String = ""

                frmMDI.frmInput.LoadEntry(mUniform._word)
                '  frmMDI.frmInput.EditMode = True
                Dim code1 As String = build1.BuildField(frmMDI.frmInput.listEntry)
                frmMDI.frmInput.txtCode.Text = ""
                'ReplaceTag(code1)
                Dim pathHTML As String = build1.SaveHTML(_css, code1)
                'MsgBox(_css)
                frmMDI.frmView.webView.Url = New System.Uri(pathHTML, System.UriKind.Absolute)
            End If
        End If
    End Sub

    Public Sub NextRowSelect()
        Dim counter As Integer = _rowIndex + 1
        Dim nextRow As DataGridViewRow
        If counter = gridWords.RowCount Then
            nextRow = gridWords.Rows(0)
        Else
            nextRow = gridWords.Rows(counter)
        End If

        gridWords.CurrentCell = nextRow.Cells(0)
        nextRow.Selected = True
    End Sub

    Public Sub BackRowSelect()
        Dim counter As Integer = _rowIndex - 1
        Dim nextRow As DataGridViewRow
        If counter >= 0 Then
            nextRow = gridWords.Rows(counter)

        Else
            nextRow = gridWords.Rows(0)
        End If

        gridWords.CurrentCell = nextRow.Cells(0)
        nextRow.Selected = True
    End Sub

    Public Sub BackFirstRow()
        Dim counter As Integer = 0

        Dim nextRow As DataGridViewRow
        If counter >= 0 Then
            nextRow = gridWords.Rows(counter)

        Else
            nextRow = gridWords.Rows(0)
        End If

        gridWords.CurrentCell = nextRow.Cells(0)
        nextRow.Selected = True
    End Sub

    Public Sub GoEndRow()
        Dim counter As Integer = gridWords.RowCount - 1

        Dim nextRow As DataGridViewRow
        If counter >= 0 Then
            nextRow = gridWords.Rows(counter)

        Else
            nextRow = gridWords.Rows(0)
        End If

        gridWords.CurrentCell = nextRow.Cells(0)
        nextRow.Selected = True
    End Sub
    Private Sub gridWords_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridWords.CellEnter
        _rowIndex = e.RowIndex
    End Sub

    Public Function SelectedRange() As List(Of String)
        Dim result As New List(Of String)
        'MsgBox(gridWords.SelectedRows.Count)
        For Each row As DataGridViewRow In gridWords.SelectedRows
            ' Dim dr As New DataGridViewRow
            '[Dim data As New DataGridViewTextBoxCell
            'Data.Value = row.Cells(2).Value
            Dim word As String = gridWords.Item(2, row.Index).Value
            result.Add(word)
            ' MsgBox(word)
        Next


        Return result
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) 
        Dim vl = SelectedRange()

    End Sub
End Class