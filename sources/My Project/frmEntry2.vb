Imports AutocompleteMenuNS
Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite
Imports System.Drawing
Imports FileHelpers
Imports WeifenLuo.WinFormsUI.Docking
Imports FastColoredTextBoxNS
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms

Partial Public Class frmEntry2
    Inherits DockContent

    Public _rowIndex As Integer
    Public _rowSelected As Boolean

    Dim _item As ToolStripItem
    Private m_ControlKeyPressed As Boolean = False
    Dim dicAttributes As New Dictionary(Of String, String)
    Dim _projectManager As New ProjectManager
    Dim _currentword As String
    Dim _status As Integer
    'Public EditMode As Boolean
    Dim _wordChanged As Boolean
    Dim _oldWord As String
    Dim countChange As Integer
    Dim build1 As New BuildCode
    Dim cssCode As String
    Dim htmlCode As String
    Dim oldStyle As String
    Dim currentKey As String
    ' Dim _autoCompleteMenu As AutocompleteMenuNS.AutocompleteMenu
    Dim path1 As New TummoPath
    Private editControl As Control
    Private Sub frmEntry2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' mUniform.PackageTable = "new_table"
            dicAttributes.Add("Word", "word")
            dicAttributes.Add("Hyphenation", "hyph")
            dicAttributes.Add("Pronunciation", "pron")
            dicAttributes.Add("Derive", "der")
            dicAttributes.Add("Etymology", "etym")
            dicAttributes.Add("Part of speech", "subc")
            dicAttributes.Add("Categorization", "category")
            dicAttributes.Add("Definitions", "def")
            dicAttributes.Add("Examples", "eg")
            dicAttributes.Add("Translations", "trans")
            dicAttributes.Add("References", "ref")
            dicAttributes.Add("Tittle", "tittle")
            dicAttributes.Add("Info", "info")
            dicAttributes.Add("Table", "table")

            For Each w1 In dicAttributes
                dropItems.DropDownItems.Add(w1.Key).Tag = "0"
                btInsertAt.DropDownItems.Add(w1.Key).Tag = "0"
            Next
            dropItems.DropDownItems.Item(0).Enabled = False
            btInsertAt.DropDownItems.Item(0).Enabled = False
            listEntry.Columns.Item(0).Width = 30
            listEntry.Columns.Item(1).Width = 100

            listEntry.Columns.Item(2).Width = Me.Width - 160
            listEntry.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 120)
            listEntry.DefaultCellStyle.SelectionForeColor = Color.FromArgb(190, 10, 10)

            listEntry.Rows.Add()
            listEntry.Item(1, 0).Value = "Word"
            listEntry.Item(1, 0).Tag = "word"
            ' listEntry.Rows.Item(0).DefaultCellStyle.ForeColor = Color.Green
            btDelete.Enabled = False
            btComplete.Enabled = False
            cboStatus.SelectedIndex = 1
            btTable.Enabled = False

            cssCode = _projectManager.LoadStyle(mUniform.StyleCSS)
            oldStyle = mUniform.StyleCSS
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        'mUniform.ProjectTable = "new_table"

        'CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub AddField(_tag As String, _key As String, _value As String)

        Dim _row As Integer = listEntry.Rows.Count

        listEntry.Rows.Add()
        listEntry.Item(1, _row).Tag = _tag
        listEntry.Item(1, _row).Value = _key
        listEntry.Item(2, _row).Value = _value
        'LockMenu(_key)
    End Sub

    Public Sub InsertField(_row As Integer, _tag As String, _key As String, _value As String)
        listEntry.Item(1, _row).Tag = _tag
        listEntry.Item(1, _row).Value = _key
        listEntry.Item(2, _row).Value = _value
        ' LockMenu(_key)
    End Sub

    Private Function GetIndexOfKey(_key As String) As Integer
        Dim _index2 As Integer = 0
        For Each w1 In dicAttributes.Keys

            If _key = w1 Then
                Return _index2
            End If
            _index2 = _index2 + 1
        Next
    End Function

    Public Sub UnLockMenu(_key As String)
        If _key = "-1" Then
            For i = 0 To dropItems.DropDownItems.Count - 1
                dropItems.DropDownItems.Item(i).Tag = "0"
                dropItems.DropDownItems.Item(i).Enabled = True
            Next
        Else
            Dim _index As Integer = GetIndexOfKey(_key)
            Dim _tag As Object = dropItems.DropDownItems.Item(_index).Tag
            Dim newtag As Integer = _tag - 1

            dropItems.DropDownItems.Item(_index).Tag = "0"
            dropItems.DropDownItems.Item(_index).Enabled = True
        End If

    End Sub
    Public Sub LockMenu(_key As String, _value As String)
        Dim _index As Integer = GetIndexOfKey(_key)
        Dim _tag As Object = dropItems.DropDownItems.Item(_index).Tag
        Dim newtag As Integer = _tag + 1

        dropItems.DropDownItems.Item(_index).Tag = newtag
        If _key = "Hyphenation" Then
            If newtag >= 1 Then
                dropItems.DropDownItems.Item(_index).Enabled = False
            End If
        ElseIf _key = "Pronunciation" Then
            If newtag >= 1 Then
                dropItems.DropDownItems.Item(_index).Enabled = False
            End If
        ElseIf _key = "Derive" Then
            If newtag >= 1 Then
                dropItems.DropDownItems.Item(_index).Enabled = False
            End If
        ElseIf _key = "Etymology" Then
            If newtag >= 1 Then
                dropItems.DropDownItems.Item(_index).Enabled = False
            End If
        ElseIf _key = "Categorization" Then
            If newtag >= 1 Then
                dropItems.DropDownItems.Item(_index).Enabled = False
            End If
        ElseIf _key = "References" Then
            If newtag >= 1 Then
                dropItems.DropDownItems.Item(_index).Enabled = False
            End If
        End If
    End Sub

    Private Sub dropItems_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles dropItems.DropDownItemClicked
        Dim _key As String = e.ClickedItem.Text

        AddField(GetTag(_key), _key, "")

        If listEntry.Item(2, 0).Value <> "" Then
            btComplete.Enabled = True
        End If
    End Sub

    Private Sub frmEntry2_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        listEntry.Columns.Item(0).Width = 30
        listEntry.Columns.Item(1).Width = 100
        listEntry.Columns.Item(2).Width = Me.Width - 160
    End Sub

    Private Sub listEntry_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles listEntry.CellFormatting
        '  e.CellStyle.BackColor = Color.WhiteSmoke
        'e.CellStyle.
    End Sub


    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        listEntry.Item(2, _rowIndex).Value = txtCode.Text


    End Sub

    Private Sub listEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles listEntry.KeyDown
        If e.KeyCode = Keys.Enter Then
            '  listEntry.Item(2, _rowIndex).e
        End If
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        If _rowIndex > 0 Then
            Dim _key As String = listEntry.Item(1, _rowIndex).Value
            listEntry.Rows.RemoveAt(_rowIndex)
            UnLockMenu(_key)
        End If

    End Sub

    Private Sub Heading(style As String)
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<" & style & ">" & selectedtext & "</" & style & ">"
        Dim newline As New List(Of String)

        If selectedtext <> "" Then
            Dim result As String
            Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
            Dim getLine As Integer = range.End.iLine
            Dim SelecttionStart As Integer = txtCode.SelectionStart
            Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

            Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
            Dim endchar As Integer = SelecttionStart + selectedtext.Length
            Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

            txtCode.Text = sub1 & s1 & sub2
            txtCode.SelectionStart = SelecttionStart + s1.Length
        Else
            Clipboard.SetText("<" & style & "></" & style & ">")
            txtCode.Paste()
        End If
    End Sub
    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        BackRowSelect()
    End Sub

    Private Sub btBold_Click(sender As Object, e As EventArgs) Handles btBold.Click
        Heading("b")
    End Sub

    Private Sub btItalic_Click(sender As Object, e As EventArgs) Handles btItalic.Click
        Heading("i")
    End Sub

    Private Sub btUnderline_Click(sender As Object, e As EventArgs) Handles btUnderline.Click
        Heading("u")
    End Sub

    Private Sub btSuperScript_Click(sender As Object, e As EventArgs) Handles btSuperScript.Click
        Heading("sup")
    End Sub

    Private Sub btParaLeft_Click(sender As Object, e As EventArgs) Handles btParaLeft.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<div align='left'>" & selectedtext & "</div>"
        Dim newline As New List(Of String)

        If selectedtext <> "" Then
            Dim result As String
            Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
            Dim getLine As Integer = range.End.iLine
            Dim SelecttionStart As Integer = txtCode.SelectionStart
            Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

            Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
            Dim endchar As Integer = SelecttionStart + selectedtext.Length
            Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

            txtCode.Text = sub1 & s1 & sub2
            txtCode.SelectionStart = SelecttionStart + s1.Length
        Else
            Clipboard.SetText("<div align='left'></div>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btParaCenter_Click(sender As Object, e As EventArgs) Handles btParaCenter.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<div align='center'>" & selectedtext & "</div>"
        Dim newline As New List(Of String)

        If selectedtext <> "" Then
            Dim result As String
            Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
            Dim getLine As Integer = range.End.iLine
            Dim SelecttionStart As Integer = txtCode.SelectionStart
            Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

            Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
            Dim endchar As Integer = SelecttionStart + selectedtext.Length
            Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

            txtCode.Text = sub1 & s1 & sub2
            txtCode.SelectionStart = SelecttionStart + s1.Length
        Else
            Clipboard.SetText("<div align='center'></div>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btParaRight_Click(sender As Object, e As EventArgs) Handles btParaRight.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<div align='right'>" & selectedtext & "</div>"
        Dim newline As New List(Of String)

        If selectedtext <> "" Then
            Dim result As String
            Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
            Dim getLine As Integer = range.End.iLine
            Dim SelecttionStart As Integer = txtCode.SelectionStart
            Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

            Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
            Dim endchar As Integer = SelecttionStart + selectedtext.Length
            Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

            txtCode.Text = sub1 & s1 & sub2
            txtCode.SelectionStart = SelecttionStart + s1.Length
        Else
            Clipboard.SetText("<div align='right'></div>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btLink_Click(sender As Object, e As EventArgs) Handles btLink.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<a href='#" & selectedtext & "'>" & selectedtext & "</a>"
        Dim newline As New List(Of String)

        If selectedtext <> "" Then
            Dim result As String
            Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
            Dim getLine As Integer = range.End.iLine
            Dim SelecttionStart As Integer = txtCode.SelectionStart
            Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

            Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
            Dim endchar As Integer = SelecttionStart + selectedtext.Length
            Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

            txtCode.Text = sub1 & s1 & sub2
            txtCode.SelectionStart = SelecttionStart + s1.Length
        Else
            Clipboard.SetText("<a href='#YOUR TEXT'>YOUR TEXT</a>")
            txtCode.Paste()
        End If
    End Sub


    Private Sub btLine_Click(sender As Object, e As EventArgs) Handles btLine.Click
        Clipboard.SetText("<p id='line'></p>")
        txtCode.Paste()
    End Sub

    Private Sub btClearFormating_Click(sender As Object, e As EventArgs) Handles btClearFormating.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = Regex.Replace(selectedtext, "<.*?>", String.Empty)
        Dim newline As New List(Of String)

        If selectedtext <> "" Then
            Dim result As String
            Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
            Dim getLine As Integer = range.End.iLine
            Dim SelecttionStart As Integer = txtCode.SelectionStart
            Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

            Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
            Dim endchar As Integer = SelecttionStart + selectedtext.Length
            Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

            txtCode.Text = sub1 & s1 & sub2
            txtCode.SelectionStart = SelecttionStart + s1.Length
            'Else
            '  Clipboard.SetText("<" & style & "></" & style & ">")
            'txtCode.Paste()
        End If
    End Sub

    Private Sub btTextColors_Click(sender As Object, e As EventArgs) Handles btTextColors.Click

        If colorsText.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then

            Dim colorHTML As String = String.Format("#{0:X2}{1:X2}{2:X2}", colorsText.Color.R, colorsText.Color.G, colorsText.Color.B)

            Dim selectedtext As String = txtCode.SelectedText.ToString
            Dim s1 As String = "<span style='background-color:" & colorHTML & "'>" & selectedtext & "</span>"
            Dim newline As New List(Of String)

            If selectedtext <> "" Then
                Dim result As String
                Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
                Dim getLine As Integer = range.End.iLine
                Dim SelecttionStart As Integer = txtCode.SelectionStart
                Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

                Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
                Dim endchar As Integer = SelecttionStart + selectedtext.Length
                Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

                txtCode.Text = sub1 & s1 & sub2
                txtCode.SelectionStart = SelecttionStart + s1.Length
            Else
                Clipboard.SetText("<span style='background-color:" & colorHTML & "'></span>")
                txtCode.Paste()
            End If
        End If
    End Sub

    Private Sub btColors_Click(sender As Object, e As EventArgs) Handles btColors.Click
        If colorsText.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then

            Dim colorHTML As String = String.Format("#{0:X2}{1:X2}{2:X2}", colorsText.Color.R, colorsText.Color.G, colorsText.Color.B)

            Dim selectedtext As String = txtCode.SelectedText.ToString
            Dim s1 As String = "<font color='" & colorHTML & "'>" & selectedtext & "</font>"
            Dim newline As New List(Of String)

            If selectedtext <> "" Then
                Dim result As String
                Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
                Dim getLine As Integer = range.End.iLine
                Dim SelecttionStart As Integer = txtCode.SelectionStart
                Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

                Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
                Dim endchar As Integer = SelecttionStart + selectedtext.Length
                Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

                txtCode.Text = sub1 & s1 & sub2
                txtCode.SelectionStart = SelecttionStart + s1.Length
            Else
                Clipboard.SetText("<font color='" & colorHTML & "'></font>")
                txtCode.Paste()
            End If
        End If
    End Sub

    Private Sub btReplace_Click(sender As Object, e As EventArgs) Handles btReplace.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString

        If selectedtext <> "" Then
            txtCode.ShowReplaceDialog()
            txtCode.replaceForm.tbFind.Text = selectedtext
        Else
            txtCode.ShowReplaceDialog()
        End If
    End Sub

    Private Function NumberRange(_symbol As Integer) As String
        Dim _textbox2 As New FastColoredTextBox

        _textbox2.Text = txtCode.SelectedText
        Dim _line As String = ""
        Dim sym1(10) As String
        sym1(0) = "I"
        sym1(1) = "II"
        sym1(2) = "III"
        sym1(3) = "IV"
        sym1(4) = "V"
        sym1(5) = "VI"
        sym1(6) = "VII"
        sym1(7) = "VIII"
        sym1(8) = "IX"
        sym1(9) = "X"

        Dim sym2(10) As String
        sym2(0) = "A"
        sym2(1) = "B"
        sym2(2) = "C"
        sym2(3) = "D"
        sym2(4) = "E"
        sym2(5) = "F"
        sym2(6) = "G"
        sym2(7) = "H"
        sym2(8) = "I"
        sym2(9) = "J"
        Dim leng1 As Integer = _textbox2.LinesCount - 1
        For i = 0 To leng1
            Dim w1 As String = _textbox2.GetLineText(i)
            If _symbol = 0 Then
                If i < leng1 Then
                    _line = _line & "<b>" & i + 1 & ".</b> " & w1 & vbNewLine
                Else
                    _line = _line & "<b>" & i + 1 & ".</b> " & w1
                End If

            ElseIf _symbol = 1 Then
                If i < sym1.Length Then
                    If i < leng1 Then
                        _line = _line & "<b>" & sym1(i) & ".</b> " & w1 & vbNewLine
                    Else
                        _line = _line & "<b>" & sym1(i) & ".</b> " & w1
                    End If

                Else
                    _line = _line & w1 & vbNewLine
                End If
            ElseIf _symbol = 2 Then
                If i < sym1.Length Then
                    If i < leng1 Then
                        _line = _line & "<b>" & sym2(i) & ".</b> " & w1 & vbNewLine
                    Else
                        _line = _line & "<b>" & sym2(i) & ".</b> " & w1
                    End If

                Else
                    _line = _line & w1 & vbNewLine
                End If
            End If

        Next

        Return _line
    End Function
    Private Sub btuLNum_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles btuLNum.DropDownItemClicked
        If e.ClickedItem.Text = "1,2,3..." Then
            If txtCode.SelectedText <> "" Then
                Clipboard.SetText(NumberRange(0))
            Else
                Clipboard.SetText("<b>1</b>")
            End If

            txtCode.Paste()
        ElseIf e.ClickedItem.Text = "I,II,III..." Then
            If txtCode.SelectedText <> "" Then
                Clipboard.SetText(NumberRange(1))
            Else
                Clipboard.SetText("<b>I</b>")
            End If

            txtCode.Paste()
        ElseIf e.ClickedItem.Text = "a,b,c..." Then
            If txtCode.SelectedText <> "" Then
                Clipboard.SetText(NumberRange(2))
            Else
                Clipboard.SetText("<b>A</b>")
            End If

            txtCode.Paste()
        End If
    End Sub

    Private Function InsertRangeTag(_symbol1 As String, _symbol2 As String) As String
        Dim _textbox2 As New FastColoredTextBox

        _textbox2.Text = txtCode.SelectedText
        Dim _line As String = ""
        For i = 0 To _textbox2.LinesCount - 1
            Dim w1 As String = _textbox2.GetLineText(i)
            If i < _textbox2.LinesCount - 1 Then
                _line = _line & _symbol1 & w1 & _symbol2 & vbNewLine
            Else
                _line = _line & _symbol1 & w1 & _symbol2
            End If

        Next

        Return _line
    End Function
    Private Sub btUL1_Click(sender As Object, e As EventArgs) Handles btUL1.Click
        Dim _textbox2 As New FastColoredTextBox
        _textbox2.Text = txtCode.SelectedText
        If _textbox2.LinesCount - 1 > 0 Then
            Clipboard.SetText(InsertRangeTag("<span class='ul'>", "</span>"))
            txtCode.Paste()
        Else
            OtherTag("<span class='ul'>", "</span>")
        End If

    End Sub

    Private Sub btOL1_Click(sender As Object, e As EventArgs) Handles btOL1.Click
        Dim _textbox2 As New FastColoredTextBox
        _textbox2.Text = txtCode.SelectedText
        If _textbox2.LinesCount - 1 > 0 Then
            Clipboard.SetText(InsertRangeTag("<span class='ol'>", "</span>"))
            txtCode.Paste()
        Else
            OtherTag("<span class='ol'>", "</span>")
        End If

    End Sub

    Private Sub btLI1_Click(sender As Object, e As EventArgs) Handles btLI1.Click
        Dim _textbox2 As New FastColoredTextBox
        _textbox2.Text = txtCode.SelectedText
        If _textbox2.LinesCount - 1 > 0 Then
            Clipboard.SetText(InsertRangeTag("<span class='li'>", "</span>"))
            txtCode.Paste()
        Else
            OtherTag("<span class='li'>", "</span>")
        End If

    End Sub

    Private Sub OtherTag(_begin1 As String, _end As String)
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = _begin1 & selectedtext & _end
        Dim newline As New List(Of String)

        If selectedtext <> "" Then
            Dim result As String
            Dim range As FastColoredTextBoxNS.Range = txtCode.Selection
            Dim getLine As Integer = range.End.iLine
            Dim SelecttionStart As Integer = txtCode.SelectionStart
            Dim returnCarretPosition As Integer = SelecttionStart - range.Start.iChar

            Dim sub1 = txtCode.Text.Substring(0, SelecttionStart)
            Dim endchar As Integer = SelecttionStart + selectedtext.Length
            Dim sub2 = txtCode.Text.Substring(endchar, txtCode.Text.Length - endchar)

            txtCode.Text = sub1 & s1 & sub2
            txtCode.SelectionStart = SelecttionStart + s1.Length
        Else
            Clipboard.SetText(_begin1 & _end)
            txtCode.Paste()
        End If
    End Sub

    Public Sub NextRowSelect()
        Dim counter As Integer = _rowIndex + 1
        Dim nextRow As DataGridViewRow
        If counter = listEntry.RowCount Then
            nextRow = listEntry.Rows(0)
        Else
            nextRow = listEntry.Rows(counter)
        End If

        listEntry.CurrentCell = nextRow.Cells(0)
        nextRow.Selected = True
    End Sub

    Public Sub BackRowSelect()
        Dim counter As Integer = _rowIndex - 1
        Dim nextRow As DataGridViewRow
        If counter >= 0 Then
            nextRow = listEntry.Rows(counter)

        Else
            nextRow = listEntry.Rows(0)
        End If

        listEntry.CurrentCell = nextRow.Cells(0)
        nextRow.Selected = True
    End Sub
    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        NextRowSelect()
    End Sub

    Private Sub btLabel_Click(sender As Object, e As EventArgs) Handles btLabel.Click
        OtherTag("<span class='label'>", "</span>")
    End Sub

    Public Sub NewEntry()
        listEntry.Rows.Clear()
        AddField("word", "Word", "")
        btComplete.Enabled = False
        'EditMode = False
        countChange = 0
        _oldWord = ""
        _currentword = ""
        frmMDI.lblEntry.Text = _projectManager.CountEntry
    End Sub
    Private Sub btNewEntry_Click(sender As Object, e As EventArgs) Handles btNewEntry.Click
        NewEntry()
        UnLockMenu("-1")
    End Sub

    Public Function RemoveTag(_word As String) As String
        Return Regex.Replace(_word, "<.*?>", "")
    End Function

    Private Sub ExtractText(_text As String, ByVal _key As String, ByVal _value As String)
        '<p id="word">careen</p>
        If _text.StartsWith("<p id='def'>") Then
            _key = "Definitions"
            _text = _text.Replace("<p id='def'>", "")
        End If

        _text = _text.Replace("</p>", "")
        _value = _text

        '  MsgBox(_value)
    End Sub

    Public Function GetEntry() As String
        Dim _line As String = ""
        For i = 0 To listEntry.RowCount - 1
            Dim _tag As String = listEntry.Item(1, i).Tag
            Dim _value As String = listEntry.Item(2, i).Value

            If _value <> "" Then
                ' -------------------------VALUE
                Dim _textbox1 As New FastColoredTextBox
                _textbox1.Text = _value
                If _textbox1.LinesCount - 1 > 0 Then
                    Dim str2 As String = ""
                    For j = 0 To _textbox1.LinesCount - 1
                        Dim str1 = _textbox1.GetLineText(j)
                        If str1 <> "" Then
                            str2 = str2 & str1 & "¶"
                        End If
                    Next
                    str2 = str2.Substring(0, str2.Length - 1)
                    _line = _line & _tag & "~" & str2 & vbNewLine
                Else
                    _line = _line & _tag & "~" & _value & vbNewLine
                End If
                ' -----------------------VALUE  
            End If
        Next

        Return _line
    End Function
    Private Sub mnExample1_Click(sender As Object, e As EventArgs) Handles mnExample1.Click
        '  If e.ClickedItem.Text = "Example 1" Then
        ' EditMode = False
        countChange = 0
        _oldWord = ""
        _currentword = ""
        listEntry.Rows.Clear()

        AddField(GetTag("Word"), "Word", "action")
        AddField(GetTag("Pronunciation"), "Pronunciation", "['ækʃn]")
        AddField(GetTag("Part of speech"), "Abbreviations", "► noun")
        AddField(GetTag("Definitions"), "Definitions", "▪ 1. something done (usually as opposed to something said)")
        AddField(GetTag("Examples"), "Examples", "→ a man of action. ǁ → to take prompt action.")
        '
        AddField(GetTag("Definitions"), "Definitions", "▪ 2. the state of being active")
        AddField(GetTag("Part of speech"), "Part of speech", "► verb")
        AddField(GetTag("Definitions"), "Definitions", "▪ 1. institute legal proceedings against; file a suit against")
        AddField(GetTag("Definitions"), "Definitions", "▪ 2. put in effect")
    End Sub

    Public Function GetTag(_key As String) As String
        Dim _tag As String

        If dicAttributes.ContainsKey(_key) Then
            _tag = dicAttributes.Item(_key)
        End If

        Return _tag
    End Function

    Public Function GetKey(_value As String) As String
        Dim _tag As String

        For Each w1 In dicAttributes
            If w1.Value = _value Then
                _tag = w1.Key
            End If
        Next

        Return _tag
    End Function
    Public Sub LoadEntry(_word As String)
        Dim arr() = _projectManager.LoadEntry(_word)
        Dim _textbox1 As New FastColoredTextBox

        _textbox1.Text = arr(3)
        listEntry.Rows.Clear()

        For i = 0 To _textbox1.LinesCount - 1
            Dim _str As String = _textbox1.GetLineText(i)
            If _str <> "" Then
                'MsgBox(_str)
                Dim _item() As String = _str.Split("~")
                Dim arr2() As String = _item(1).Split("¶")
                If arr2.Count - 1 > 0 Then
                    _item(1) = _item(1).Replace("¶", vbNewLine)
                    AddField(_item(0), GetKey(_item(0)), _item(1))
                Else
                    AddField(_item(0), GetKey(_item(0)), _item(1))
                End If

            End If

        Next
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        For i = 0 To listEntry.Rows.Count - 1
            listEntry.Item(2, i).Value = ""
        Next
        btComplete.Enabled = False
        'EditMode = False
        countChange = 0
        _oldWord = ""
        _currentword = ""
        UnLockMenu("-1")

    End Sub

    Private Sub listEntry_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles listEntry.CellLeave

        If btComplete.Enabled = False Then
            If listEntry.Item(2, 0).Value <> "" Then
                btComplete.Enabled = True
            End If
        End If

    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        _status = cboStatus.SelectedIndex
    End Sub

    Public Sub SaveEntry()
        Dim _word As String = listEntry.Item(2, 0).Value
        Dim _text As String = GetEntry()
        Dim arr(4) As String
        arr(0) = _status
        arr(1) = _word.ToLower

        arr(2) = _text

        ' MsgBox("ss" & _projectManager.ExitsWord(_word))
        If _projectManager.ExitsWord(_word) = 0 Then

            _projectManager.NewEntry(arr)
            If Application.OpenForms().OfType(Of frmWordList).Any Then
                frmMDI.frmWordList.ImportWordList("", 0)
            End If
        Else
            _projectManager.UpdateEntry(_word, arr)
        End If
    End Sub
    Private Sub btComplete_Click(sender As Object, e As EventArgs) Handles btComplete.Click
        SaveEntry()
        frmMDI.frmWordList.ImportWordList("", 0)
        'If EditMode = False Then
        For i = 0 To listEntry.Rows.Count - 1
            listEntry.Item(2, i).Value = ""
        Next
        btComplete.Enabled = False
        'EditMode = False
        countChange = 0
        _oldWord = ""
        _currentword = ""
        UnLockMenu("-1")
        'End If

    End Sub

    Private Sub txtCode_Leave(sender As Object, e As EventArgs) Handles txtCode.Leave
        Try
            If txtCode.Text <> "" Then
                listEntry.Item(2, _rowIndex).Value = txtCode.Text
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub listEntry_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles listEntry.CellEndEdit
        Dim _w1 As String = listEntry.Item(2, 0).Value

        If e.RowIndex = 0 Then

            'listEntry.Item(2, 0).Value = _w1.ToLower
            ' If EditMode = False Then
            If _w1 <> "" Then
                If _w1.Length > 100 Then
                    listEntry.Item(2, 0).Value = ""
                    _w1 = ""
                    MsgBox("Word too long", MsgBoxStyle.Exclamation)

                End If

                listEntry.Item(2, 0).Value = _w1.ToLower

                If _w1.Contains("<") = False Then
                    Dim _countword As Int16 = _projectManager.CountWord(_w1)

                    If _countword >= 1 Then
                        If MsgBox("Do you want to overwrite this word?", MsgBoxStyle.YesNo, "Alarm") = MsgBoxResult.Yes Then
                            listEntry.Item(2, 0).Value = _w1 & " <" & _countword + 1 & ">"
                        End If

                    End If
                End If
                _w1 = listEntry.Item(2, 0).Value
            End If

            _currentword = _w1

            If countChange > 0 Then
                'If EditMode = True Then
                _wordChanged = True
                'End If
            End If

            countChange = countChange + 1
            ' txtCode.Text = _w1
            '  Else
            'txtCode.Text = _w1
        End If
    End Sub

    Private Sub btReview_Click(sender As Object, e As EventArgs) Handles btReview.Click

        If oldStyle <> mUniform.StyleCSS Then
            cssCode = _projectManager.LoadStyle(mUniform.StyleCSS)
            oldStyle = mUniform.StyleCSS
        End If

        htmlCode = build1.BuildField(listEntry)
        Dim pathHTML As String = build1.SaveHTML(cssCode, htmlCode)
        ' MsgBox(css)
        frmMDI.frmView.webView.Url = New System.Uri(pathHTML, System.UriKind.Absolute)
    End Sub

    Private Sub BuildCode1()
        htmlCode = build1.BuildField(listEntry)
        Dim pathHTML As String = build1.SaveHTML(cssCode, htmlCode)
        ' MsgBox(css)
        frmMDI.frmView.webView.Url = New System.Uri(pathHTML, System.UriKind.Absolute)
    End Sub

    Private Sub txtCode_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCode.MouseClick
        If e.Button = MouseButtons.Right Then
            menuOnText.Show()
        End If
    End Sub

    Private Sub mnCut_Click(sender As Object, e As EventArgs) Handles mnCut.Click
        txtCode.Cut()
    End Sub

    Private Sub mnCopy_Click(sender As Object, e As EventArgs) Handles mnCopy.Click
        txtCode.Copy()
    End Sub

    Private Sub mnPaste_Click(sender As Object, e As EventArgs) Handles mnPaste.Click
        txtCode.Paste()
    End Sub

    Private Function InsertRange(_symbol As String) As String
        Dim _textbox2 As New FastColoredTextBox

        _textbox2.Text = txtCode.SelectedText
        Dim _line As String = ""
        For i = 0 To _textbox2.LinesCount - 1
            Dim w1 As String = _textbox2.GetLineText(i)
            If i < _textbox2.LinesCount - 1 Then
                _line = _line & _symbol & " " & w1 & vbNewLine
            Else
                _line = _line & _symbol & " " & w1
            End If

        Next

        Return _line
    End Function
    Private Sub btInsert_Click(sender As Object, e As EventArgs) Handles btInsert.Click
        If txtCode.SelectedText <> "" Then
            Dim rg1 As String = InsertRange(cboSymbol.Text)
            Clipboard.SetText(rg1)
        Else
            Clipboard.SetText(cboSymbol.Text)
        End If

        txtCode.Paste()
    End Sub

    Private Sub mnExample2_Click(sender As Object, e As EventArgs) Handles mnExample2.Click
        ' EditMode = False
        countChange = 0
        _oldWord = ""
        _currentword = ""
        listEntry.Rows.Clear()

        AddField(GetTag("Word"), "Word", "execute")
        AddField(GetTag("Pronunciation"), "Pronunciation", "['eksikju:t]")
        AddField(GetTag("Etymology"), "Etymology", "[<sup>pl</sup> executes, executing, executed]")
        AddField(GetTag("Part of speech"), "Part of speech", "► ngoại động từ")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>1.</b> thực hiện, thi hành, thừa hành, chấp hành")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>2.</b> thể hiện; biểu diễn (bản nhạc...)")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>3.</b> (pháp lý) làm thủ tục để cho có giá trị (hiệp ước, giao kèo...) (bằng cách ký vào, đóng dấu vào...)")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>4.</b> hành hình")
    End Sub

    Private Sub mnExample3_Click(sender As Object, e As EventArgs) Handles mnExample3.Click
        'EditMode = False
        countChange = 0
        _oldWord = ""
        _currentword = ""
        listEntry.Rows.Clear()

        AddField(GetTag("Word"), "Word", "mouse")
        AddField(GetTag("Pronunciation"), "Pronunciation", "[maus - mauz]")
        AddField(GetTag("Etymology"), "Etymology", "[<sup>pl</sup> mice]")
        AddField(GetTag("Part of speech"), "Part of speech", "► danh từ")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>1.</b> chuột <span class='label'>ĐỘNG VẬT HỌC</span>")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>2.</b> mắt sưng húp, mắt thâm tím <span class='label'>TỪ LÓNG</span>")
        AddField(GetTag("Part of speech"), "Part of speech", "► nội động từ")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>1.</b> bắt chuột, săn chuột")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>2.</b> đi rón rén, lén, lần mò")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>3.</b> (+ about) lục lọi, tìm kiếm, bới <span class='label'>THÔNG TỤC</span>")
        AddField(GetTag("Part of speech"), "Part of speech", "► ngoại động từ")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>1.</b> rình bắt đến cùng")
        AddField(GetTag("Definitions"), "Definitions", "▪ <b>2.</b> kiên nhẫn, tìm kiếm")
    End Sub

    Private Sub mnExample4_Click(sender As Object, e As EventArgs) Handles mnExample4.Click
        ' EditMode = False
        countChange = 0
        _oldWord = ""
        _currentword = ""
        listEntry.Rows.Clear()
        AddField(GetTag("Word"), "Word", "Print Dictionaries")
        AddField(GetTag("Tittle"), "Tittle", "The Structure of Dictionary Entries")
        AddField(GetTag("Definitions"), "Definitions", "A simple dictionary entry may contain information about the form of the word treated, its grammatical characterization, its definition, synonyms, or translation equivalents, its etymology, cross-references to other entries, usage information, and examples. These we refer to as the constituent parts or constituents of the entry; some dictionary constituents possess no internal structure, while others are most naturally viewed as groups of smaller elements, which may be marked in their own right. In some styles of markup, tags will be applied only to the low-level items, leaving the constituent groups which contain them untagged. We distinguish the class of top-level constituents of dictionary entries, which can occur directly within entries, from the class of phrase-level constituents, which can normally occur only within top-level constituents. The top-level constituents of dictionary entries are described in section 12.2.2, Groups and Constituents , and documented more fully, together with their phrase-level sub-constituents, in section 12.3, Top-level Constituents of Entries . ")
        AddField(GetTag("Tittle"), "Tittle", "Hierarchical Levels")
        AddField(GetTag("Definitions"), "Definitions", "The outermost structural level of an entry is marked with the elements <entry> or <entryFree>. The <hom> element marks the subdivision of entries into part-of-speech homographs. The <sense> element marks the subdivision of entries and part-of-speech homographs into senses; this element nests recursively in order to provide for a hierarchy of sub-senses of any depth. All of these levels may each contain any of the constituent parts of an entry. A special case of hierarchical structure is represented by the <re> (related entry) element, which is discussed in section 12.3.6, Related Entries . ")
        AddField(GetTag("Definitions"), "Definitions", "<hr>")
        AddField(GetTag("References"), "References", "[1] Moe, Ron. 2001. Lexicography and mass production. Notes on linguistics 4:3.")
        AddField(GetTag("References"), "References", "[2] Moe, Ron. 2006. Dictionary development process. SIL International. ")
    End Sub

    Private Sub btTable_Click(sender As Object, e As EventArgs) Handles btTable.Click
        mUniform.TableCode = ""
        If txtCode.Text.StartsWith("{tittle}") Then
            mUniform.TableCode = txtCode.Text
        End If

        frmTable.Show()
    End Sub

    Private Sub mnUpcase_Click(sender As Object, e As EventArgs) Handles mnUpcase.Click
        txtCode.UpperCase()
    End Sub

    Private Sub mnLowcase_Click(sender As Object, e As EventArgs) Handles mnLowcase.Click
        txtCode.LowerCase()
    End Sub

    Private Sub mnTittleCase_Click(sender As Object, e As EventArgs) Handles mnTittleCase.Click
        txtCode.TitleCase()
    End Sub

    Public Sub LoadAutocomplete(Filename As String)
        Dim pleasewait As New _pleaseWait
        pleasewait.Show()
        Application.DoEvents()

        Dim engine As New FileHelperEngine(GetType(PaliAutocomplete))
        Dim res() As PaliAutocomplete = DirectCast(engine.ReadFile("E:\DESKTOP\Dictionary Maker\Dictionary Maker\bin\Debug\project\pali_autocomplete.txt"), PaliAutocomplete())

        ' Dim engine As New FileHelperEngine(GetType(PaliAutocomplete))
        '  Dim result As New List(Of String)

        'Dim res() As PaliAutocomplete = DirectCast(engine.ReadFile(path1.PathOfProject & "\" & Filename), PaliAutocomplete())
        'result.AddRange((From o In res Select o.Unicode).ToList())

        '_autoCompleteMenu.MaximumSize = New System.Drawing.Size(250, 200)
        Dim columnWidth1 = New Integer() {200}
        Dim _autoCompleteMenu As AutocompleteMenuNS.AutocompleteMenu
        Dim dup As New Dictionary(Of String, String)
        Dim items = New List(Of AutocompleteMenuNS.AutocompleteItem)()
        '_autoCompleteMenu.Items.
        For Each w1 In res
            ' items.Add(New AutocompleteMenuNS.AutocompleteItem(w1.NonUnicode))
            _autoCompleteMenu.AddItem(w1.Unicode)
            ' If dup.ContainsKey(w1.Unicode) = False Then
            'dup.Add(w1, "1")
            'str1 = str1 & w1 & vbNewLine
            'End If
        Next
        pleasewait.Hide()
    End Sub

    Private Sub btInsertAt_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles btInsertAt.DropDownItemClicked
        Dim row1 As New DataGridViewRow
        row1.SetValues(New String() {"0", "1", "2"})
        listEntry.Rows.Insert(_rowIndex + 1, row1)

        Dim _key As String = e.ClickedItem.Text

        InsertField(_rowIndex + 1, GetTag(_key), _key, "")

        If listEntry.Item(2, 0).Value <> "" Then
            btComplete.Enabled = True
        End If


    End Sub

    Private Sub btMoveUp_Click(sender As Object, e As EventArgs) Handles btMoveUp.Click
        If _rowIndex > 1 Then
            Dim currentRow As New clsMoveRow
            currentRow.vTag = listEntry.Item(1, _rowIndex).Tag
            currentRow.vKey = listEntry.Item(1, _rowIndex).Value
            currentRow.vValue = listEntry.Item(2, _rowIndex).Value

            Dim upRow As New clsMoveRow
            upRow.vTag = listEntry.Item(1, _rowIndex - 1).Tag
            upRow.vKey = listEntry.Item(1, _rowIndex - 1).Value
            upRow.vValue = listEntry.Item(2, _rowIndex - 1).Value

            listEntry.Item(1, _rowIndex - 1).Tag = currentRow.vTag
            listEntry.Item(1, _rowIndex - 1).Value = currentRow.vKey
            listEntry.Item(2, _rowIndex - 1).Value = currentRow.vValue

            listEntry.Item(1, _rowIndex).Tag = upRow.vTag
            listEntry.Item(1, _rowIndex).Value = upRow.vKey
            listEntry.Item(2, _rowIndex).Value = upRow.vValue

            BackRowSelect()
        End If

        'BackRowSelect()
    End Sub

    Private Sub btMoveDown_Click(sender As Object, e As EventArgs) Handles btMoveDown.Click
        If _rowIndex < listEntry.RowCount - 1 Then
            Dim currentRow As New clsMoveRow
            currentRow.vTag = listEntry.Item(1, _rowIndex).Tag
            currentRow.vKey = listEntry.Item(1, _rowIndex).Value
            currentRow.vValue = listEntry.Item(2, _rowIndex).Value

            Dim upRow As New clsMoveRow
            upRow.vTag = listEntry.Item(1, _rowIndex + 1).Tag
            upRow.vKey = listEntry.Item(1, _rowIndex + 1).Value
            upRow.vValue = listEntry.Item(2, _rowIndex + 1).Value

            listEntry.Item(1, _rowIndex + 1).Tag = currentRow.vTag
            listEntry.Item(1, _rowIndex + 1).Value = currentRow.vKey
            listEntry.Item(2, _rowIndex + 1).Value = currentRow.vValue

            listEntry.Item(1, _rowIndex).Tag = upRow.vTag
            listEntry.Item(1, _rowIndex).Value = upRow.vKey
            listEntry.Item(2, _rowIndex).Value = upRow.vValue

            NextRowSelect()
        End If
    End Sub

    Private Sub frmEntry2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode And Not Keys.Modifiers) = Keys.S AndAlso e.Modifiers = Keys.Control Then
            SaveEntry()
            frmMDI.frmWordList.ImportWordList("", 0)
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.N AndAlso e.Modifiers = Keys.Control Then
            NewEntry()
            UnLockMenu("-1")
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.Q AndAlso e.Modifiers = Keys.Control Then
            For i = 0 To listEntry.Rows.Count - 1
                listEntry.Item(2, i).Value = ""
            Next
            btComplete.Enabled = False
            ' EditMode = False
            countChange = 0
            _oldWord = ""
            _currentword = ""
            UnLockMenu("-1")
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.F1 AndAlso e.Modifiers = Keys.Control Then
            'NextRowSelect()
            listEntry.Focus()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.F2 AndAlso e.Modifiers = Keys.Control Then
            txtCode.Focus()
        End If



        ' If listEntry.Item(2, 0).Value <> "" Then
        'btComplete.Enabled = True
        'End If
    End Sub

    Private Sub listEntry_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles listEntry.RowEnter
        _rowIndex = e.RowIndex
        txtCode.Text = listEntry.Item(2, e.RowIndex).Value
        _currentword = listEntry.Item(2, 0).Value
        currentKey = listEntry.Item(1, e.RowIndex).Value
        frmMDI.lblWord.Text = _currentword
        If currentKey = "Table" Then
            btTable.Enabled = True
        Else
            btTable.Enabled = False
        End If

        If listEntry.RowCount > 1 Then
            btDelete.Enabled = True
        Else
            btDelete.Enabled = False
        End If


    End Sub

    Private Sub mnJoinLines_Click(sender As Object, e As EventArgs) Handles mnJoinLines.Click
        Dim _textbox2 As New FastColoredTextBox

        _textbox2.Text = txtCode.SelectedText
        If _textbox2.Text <> "" Then
            Dim _line As String = ""
            Dim _char1 As String = InputBox("Join lines with a character: ", "Join lines", " ")
            If _char1 <> " " Then
                _char1 = _char1 & " "
            End If
            For i = 0 To _textbox2.LinesCount - 1
                Dim w1 As String = _textbox2.GetLineText(i)
                If i < _textbox2.LinesCount - 1 Then
                    _line = _line & w1 & _char1
                Else
                    _line = _line & w1
                End If

            Next
            Clipboard.SetText(_line)
            txtCode.Paste()
        End If
    End Sub

    Private Sub mnSplitLines_Click(sender As Object, e As EventArgs) Handles mnSplitLines.Click
        Dim _text As String = txtCode.SelectedText

        If _text <> "" Then
            Dim _line As String = ""
            Dim _char1 As String = InputBox("Split lines with a character: ", "Split lines", ",")
            Dim _char2 As Char = _char1.Substring(0, 1)
            Dim arr() As String = _text.Split(_char2)
            For i = 0 To arr.Length - 1
                Dim w1 As String = arr(i).Trim
                If i < arr.Length - 1 Then
                    _line = _line & w1 & vbNewLine
                Else
                    _line = _line & w1
                End If
            Next
            Clipboard.SetText(_line)
            txtCode.Paste()
        End If
    End Sub

    Private Sub mnTrimSpaces_Click(sender As Object, e As EventArgs) Handles mnTrimSpaces.Click
        Dim _text As String = txtCode.SelectedText
        If _text <> "" Then
            _text = _text.Trim
            Clipboard.SetText(_text)
            txtCode.Paste()
        End If

    End Sub

End Class

Public Class clsMoveRow
    Public vTag As String
    Public vKey As String
    Public vValue As String
End Class