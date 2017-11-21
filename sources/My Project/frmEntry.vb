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
Partial Public Class frmEntry
    Inherits DockContent

    Dim SQLconnect As SQLiteConnection = New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    Dim Path As New TummoPath
    Dim currentLine As Integer
    Dim getLineText As String
    Dim _ProjectManager1 As New ProjectManager
    Public EditMode As Boolean
    Public CurrentTextbox As Object
    Public CurrentTextboxLeave As Boolean
    Dim autoNotes As New AutocompleteMenu
    Dim autoAbbreviations As New AutocompleteMenu
    Dim _code As String
    Private Sub frmEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mUniform.SourceLanguage = "pali"
        SQLconnect.ConnectionString = "Data Source=" & Path.PathOfProject & "\project.db;"
        SQLconnect.Open()

        LoadAbbreviations()
        'LoadNotes()
        LoadAutoWord("pali1.txt")

        btComplete.Enabled = False
        CurrentTextboxLeave = True
        EnableInput(False)

    End Sub

    Public Sub EnableInput(enable As Boolean)
        If enable = False Then
            txtWord.Enabled = False
            txtPronunciation.Enabled = False
            txtDerive.Enabled = False
            txtEtymology.Enabled = False
            txtAbbreviations.Enabled = False
            txtNotes.Enabled = False
            txtCode.Enabled = False
            btComplete.Enabled = False
        Else
            txtWord.Enabled = True
            txtPronunciation.Enabled = True
            txtDerive.Enabled = True
            txtEtymology.Enabled = True
            txtAbbreviations.Enabled = True
            txtNotes.Enabled = True
            txtCode.Enabled = True
            btComplete.Enabled = True
        End If
    End Sub
    Public Sub LoadAutoWord(Filename As String)
        Dim engine As New FileHelperEngine(GetType(PaliAutocomplete))
        Dim result As New List(Of String)

        Dim res() As PaliAutocomplete = DirectCast(engine.ReadFile(Path.PathOfProject & "\" & Filename), PaliAutocomplete())
        'result.AddRange((From o In res Select o.Unicode).ToList())

        autoNotes.MaximumSize = New System.Drawing.Size(250, 200)
        Dim columnWidth1 = New Integer() {200}

        Dim dup As New Dictionary(Of String, String)
        Dim str1 As String
        For Each w1 In res
            autoNotes.AddItem(w1.Unicode)
            ' If dup.ContainsKey(w1.Unicode) = False Then
            'dup.Add(w1, "1")
            'str1 = str1 & w1 & vbNewLine
            'End If
        Next
        'txtCode.Text = str1
        'MsgBox("Finhish")
    End Sub
    Public Sub LoadAbbreviations()

        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM abbreviations WHERE language LIKE '" & mUniform.SourceLanguage & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim code, tittle As String

        autoAbbreviations.MaximumSize = New System.Drawing.Size(250, 200)
        Dim columnWidth1 = New Integer() {50, 200}

        While SQLreader.Read()


            code = SQLreader(1).ToString
            tittle = SQLreader(2).ToString
            'col.Add(code & " = " & tittle)
            autoAbbreviations.AddItem(New MulticolumnAutocompleteItem(New String() {code, tittle}, code) With {.ColumnWidth = columnWidth1})
        End While
    End Sub

    Public Sub LoadNotes()

        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM notes WHERE language LIKE '" & mUniform.SourceLanguage & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim code, tittle As String

        autoNotes.MaximumSize = New System.Drawing.Size(350, 200)
        Dim columnWidth1 = New Integer() {50, 300}


        While SQLreader.Read()

            code = SQLreader(3).ToString
            tittle = SQLreader(2).ToString
            'col.Add(code & " = " & tittle)
            autoNotes.AddItem(New MulticolumnAutocompleteItem(New String() {code, tittle}, code) With {.ColumnWidth = columnWidth1})
        End While
    End Sub

    Private Sub txtAbbreviations_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.Control And e.
    End Sub

    Private Sub btBold_Click(sender As Object, e As EventArgs)
        Heading("b")
    End Sub

    Private Sub txtCode_MouseDown(sender As Object, e As MouseEventArgs)
        currentLine = txtCode.Selection.ToLine
        getLineText = txtCode.GetLineText(currentLine)
    End Sub

    Private Sub btItalic_Click(sender As Object, e As EventArgs)
        Heading("i")
    End Sub

    Private Sub btUnderline_Click(sender As Object, e As EventArgs)
        Heading("u")
    End Sub

    Private Sub btLink_Click(sender As Object, e As EventArgs)
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<a href='" & selectedtext & "'>" & selectedtext & "</a>"
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
            Clipboard.SetText("<a href='YOUR TEXT'>YOUR TEXT</a>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btSubscript_Click(sender As Object, e As EventArgs)
        Heading("sup")
    End Sub

    Private Sub btSuperScript_Click(sender As Object, e As EventArgs)
        Heading("sup")
    End Sub

    Private Sub btLine_Click(sender As Object, e As EventArgs)
        Clipboard.SetText("<hr>")
        txtCode.Paste()
    End Sub

    Private Sub btParaLeft_Click(sender As Object, e As EventArgs)
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

    Private Sub btParaCenter_Click(sender As Object, e As EventArgs)
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

    Private Sub btParaRight_Click(sender As Object, e As EventArgs)
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

    Private Sub btUL_Click(sender As Object, e As EventArgs)
        Heading("ul")
    End Sub

    Private Sub btuLNum_Click(sender As Object, e As EventArgs)
        Heading("ol")
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
    Private Sub btH1_Click(sender As Object, e As EventArgs)
        Heading("h1")
    End Sub

    Private Sub btH2_Click(sender As Object, e As EventArgs)
        Heading("h2")
    End Sub

    Private Sub btH3_Click(sender As Object, e As EventArgs)
        Heading("h3")
    End Sub

    Private Sub btH4_Click(sender As Object, e As EventArgs)
        Heading("h4")
    End Sub

    Private Sub btReplace_Click(sender As Object, e As EventArgs)
        Dim selectedtext As String = txtCode.SelectedText.ToString

        If selectedtext <> "" Then
            txtCode.ShowReplaceDialog()
            txtCode.replaceForm.tbFind.Text = selectedtext
        Else
            txtCode.ShowReplaceDialog()
        End If


    End Sub

    Private Sub btClearFormating_Click(sender As Object, e As EventArgs)

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

    Private Sub btColors_Click(sender As Object, e As EventArgs)
        If colorsText.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            txtNotes.ForeColor = colorsText.Color
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

    Private Sub btTextColors_Click(sender As Object, e As EventArgs)
        If colorsText.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            txtNotes.ForeColor = colorsText.Color
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

    Private Sub btIndent_Click(sender As Object, e As EventArgs)
        ' LoadPaliWord()
    End Sub

    Private Sub autoNotes_Selected(sender As Object, e As SelectedEventArgs)

        'txtCode.Text = e.Item.Text
    End Sub

    Private Sub autoNotes_Selecting(sender As Object, e As SelectingEventArgs)

    End Sub

    Private Sub txtWord_Leave(sender As Object, e As EventArgs) Handles txtWord.Leave
        CurrentTextboxLeave = True
        If txtWord.Text <> "" Then

            txtWord.Text = txtWord.Text.ToLower
            Dim count As Integer = _ProjectManager1.ExitsWord(txtWord.Text)
            If count >= 1 Then
                If EditMode = False Then
                    txtWord.Text = txtWord.Text & " [" & count + 1 & "]"
                End If

            End If

            'BuildCode()
        Else
            If EditMode = True Then
                txtWord.Text = mUniform._word
            Else
                MsgBox("Word blank")
            End If
        End If
    End Sub

    Private Sub txtWord_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWord.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPronunciation.Focus()
        End If
    End Sub

    Private Sub txtPronunciation_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPronunciation.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDerive.Focus()
        End If
    End Sub

    Private Sub txtDerive_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDerive.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEtymology.Focus()
        End If
    End Sub
    Private Sub txtEtymology_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEtymology.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAbbreviations.Focus()
        End If
    End Sub

    Private Sub txtAbbreviations_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtAbbreviations.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNotes.Focus()
        End If
    End Sub

    Private Sub txtNotes_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCode.Focus()
        End If
    End Sub

    Private Sub btComplete_Click(sender As Object, e As EventArgs) Handles btComplete.Click
        Dim arr(8) As String

        arr(0) = "1"
        arr(1) = txtWord.Text
        arr(2) = txtPronunciation.Text
        arr(3) = txtDerive.Text
        arr(4) = txtEtymology.Text
        arr(5) = txtAbbreviations.Text
        arr(6) = txtNotes.Text
        arr(7) = txtCode.Text

        _ProjectManager1.NewEntry(arr)
        'frmMDI.ImportWordList()
    End Sub

    Private Sub txtWord_Enter(sender As Object, e As EventArgs) Handles txtWord.Enter
        CurrentTextbox = txtWord
        CurrentTextboxLeave = False
    End Sub

    Private Sub txtPronunciation_Enter(sender As Object, e As EventArgs) Handles txtPronunciation.Enter
        CurrentTextbox = txtPronunciation
        CurrentTextboxLeave = False
    End Sub

    Private Sub txtDerive_Enter(sender As Object, e As EventArgs) Handles txtDerive.Enter
        CurrentTextbox = txtDerive
        CurrentTextboxLeave = False
    End Sub

    Private Sub txtEtymology_Enter(sender As Object, e As EventArgs) Handles txtEtymology.Enter
        CurrentTextbox = txtEtymology
        CurrentTextboxLeave = False
    End Sub

    Private Sub txtAbbreviations_Enter(sender As Object, e As EventArgs) Handles txtAbbreviations.Enter
        CurrentTextbox = txtAbbreviations
        CurrentTextboxLeave = False
    End Sub

    Private Sub txtNotes_Enter(sender As Object, e As EventArgs) Handles txtNotes.Enter
        CurrentTextbox = txtNotes
        CurrentTextboxLeave = False
    End Sub

    Private Sub txtCode_Leave(sender As Object, e As EventArgs) Handles txtCode.Leave
        mUniform.txtCodeActive = False

    End Sub

    Private Sub txtCode_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCode.MouseClick
        mUniform.txtCodeActive = True
    End Sub

    Private Sub txtPronunciation_Leave(sender As Object, e As EventArgs) Handles txtPronunciation.Leave
        CurrentTextboxLeave = True
        'BuildCode()
    End Sub

    Private Sub txtDerive_Leave(sender As Object, e As EventArgs) Handles txtDerive.Leave
        CurrentTextboxLeave = True
        'BuildCode()
    End Sub

    Private Sub txtEtymology_Leave(sender As Object, e As EventArgs) Handles txtEtymology.Leave
        CurrentTextboxLeave = True
        'BuildCode()
    End Sub

    Private Sub txtAbbreviations_Leave(sender As Object, e As EventArgs) Handles txtAbbreviations.Leave
        CurrentTextboxLeave = True
        ' BuildCode()
    End Sub

    Private Sub txtNotes_Leave(sender As Object, e As EventArgs) Handles txtNotes.Leave
        CurrentTextboxLeave = True
        'BuildCode()
    End Sub

    Private Sub txtCode_Enter(sender As Object, e As EventArgs) Handles txtCode.Enter
        CurrentTextbox = txtCode
    End Sub


    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            'BuildCode()
        End If
    End Sub

    Private Sub btBold_Click_1(sender As Object, e As EventArgs) Handles btBold.Click

    End Sub

    Private Sub btParaLeft_Click_1(sender As Object, e As EventArgs) Handles btParaLeft.Click

    End Sub

    Private Sub btLine_Click_1(sender As Object, e As EventArgs) Handles btLine.Click

    End Sub

    Private Sub btReplace_Click_1(sender As Object, e As EventArgs) Handles btReplace.Click

    End Sub
End Class