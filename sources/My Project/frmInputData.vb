Imports AutocompleteMenuNS
Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite
Imports WeifenLuo.WinFormsUI.Docking
Partial Public Class frmInputData
    Inherits DockContent
    Dim SQLconnect As SQLiteConnection = New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    Dim Path As New TummoPath

    ' -----------------------
    ' BUTTON
    Private Sub btParaLeft_Click(sender As Object, e As EventArgs) Handles btParaLeft.Click
        ' MsgBox()
    End Sub

    Private Sub btLink_Click(sender As Object, e As EventArgs) Handles btLink.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<a href='" & selectedtext & "'>" & selectedtext & "</a>"
        If selectedtext <> "" Then
            txtCode.Text = txtCode.Text.Replace(selectedtext, s1)
        Else
            Clipboard.SetText("<a href='YOUR TEXT'>YOUR TEXT</a>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btSubscript_Click(sender As Object, e As EventArgs) Handles btSubscript.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<sup>" & selectedtext & "</sup>"
        If selectedtext <> "" Then
            txtCode.Text = txtCode.Text.Replace(selectedtext, s1)
        Else
            Clipboard.SetText("<sup></sup>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btBold_Click(sender As Object, e As EventArgs) Handles btBold.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<b>" & selectedtext & "</b>"
        If selectedtext <> "" Then
            txtCode.Text = txtCode.Text.Replace(selectedtext, s1)
        Else
            Clipboard.SetText("<b></b>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btItalic_Click(sender As Object, e As EventArgs) Handles btItalic.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<i>" & selectedtext & "</i>"
        If selectedtext <> "" Then
            txtCode.Text = txtCode.Text.Replace(selectedtext, s1)
        Else
            Clipboard.SetText("<i></i>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btUnderline_Click(sender As Object, e As EventArgs) Handles btUnderline.Click
        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<u>" & selectedtext & "</u>"
        If selectedtext <> "" Then
            txtCode.Text = txtCode.Text.Replace(selectedtext, s1)
        Else
            Clipboard.SetText("<u></u>")
            txtCode.Paste()
        End If
    End Sub

    Private Sub btUL_Click(sender As Object, e As EventArgs) Handles btUL.Click

        Dim selectedtext As String = txtCode.SelectedText.ToString
        Dim s1 As String = "<ul>" & selectedtext & "</ul>"
        If selectedtext <> "" Then
            txtCode.Text = txtCode.Text.Replace(selectedtext, s1)
        Else
            Clipboard.SetText("<ul></ul>")
            txtCode.Paste()
        End If

    End Sub

    Private Sub btNewEntry_Click(sender As Object, e As EventArgs) Handles btNewEntry.Click
        ' MsgBox(txtCode.)
    End Sub

    Private Sub btLine_Click(sender As Object, e As EventArgs) Handles btLine.Click
        Clipboard.SetText("<hr>")

        txtCode.Paste()

    End Sub

    Private Sub txtCode_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            contextEdit.Show()
        End If
    End Sub

    Private Sub frmInputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mUniform.SourceLanguage = "pali"
        SQLconnect.ConnectionString = "Data Source=" & Path.PathOfProject & "\project.db;"
        SQLconnect.Open()

        LoadAbbreviations()
        LoadNotes()


        '  txtAbbreviations.AutoCompleteMode = AutoCompleteMode.Suggest
        ' txtAbbreviations.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Dim Data1 As New AutoCompleteStringCollection()
        'LoadAbbreviations(Data1)
        'txtAbbreviations.AutoCompleteCustomSource = Data1
    End Sub

    Private Sub btClearFormating_Click(sender As Object, e As EventArgs) Handles btClearFormating.Click
        Dim line As Integer
        'MsgBox(txtCode.get)
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

        autoAbbreviations.MaximumSize = New System.Drawing.Size(350, 200)
        Dim columnWidth1 = New Integer() {50, 300}


        While SQLreader.Read()

            code = SQLreader(3).ToString
            tittle = SQLreader(2).ToString
            'col.Add(code & " = " & tittle)
            autoAbbreviations.AddItem(New MulticolumnAutocompleteItem(New String() {code, tittle}, code) With {.ColumnWidth = columnWidth1})
        End While
    End Sub

    Private Sub txtAbbreviations_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAbbreviations.KeyDown
        ' If e.KeyCode = Keys.Enter Then
        'If txtAbbreviations.Text.Contains("=") = True Then
        'Dim arr() As String = txtAbbreviations.Text.Split("=")
        'txtAbbreviations.Text = arr(0)
        'txtAbbreviations.SelectionStart = txtAbbreviations.Text.Length
        'End If
        'End If
    End Sub

    Private Sub btSaveEntry_Click(sender As Object, e As EventArgs) Handles btSaveEntry.Click
        '  Dim currentLine As Integer = txtCode.Selection.ToLine
        ' Dim getLineText As String = txtCode.GetLineText(currentLine)
        'MsgBox(getLineText)
    End Sub
End Class