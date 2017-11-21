Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite
Imports FileHelpers
Public Class frmImport
    Dim lstTarget As New Dictionary(Of String, String)
    Dim _ProjectManager As New ProjectManager
    Dim SQLString As String
    Dim _status As String
    Dim _dup As Boolean
    Dim dicAttributes As New Dictionary(Of String, String)
    Dim SQLconnect As SQLiteConnection = New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    Dim path1 As New TummoPath

    Private Sub btSendTo_Click(sender As Object, e As EventArgs) Handles btSendTo.Click
        Dim newItem As String = listSources.Items(listSources.SelectedIndex).ToString()
        If lstTarget.ContainsKey(newItem) = False Then
            lstTarget.Add(newItem, "")
            listTarget.Items.Add(newItem)
            If listSources.SelectedIndex + 1 <= listSources.Items.Count - 1 Then
                listSources.SelectedIndex = listSources.SelectedIndex + 1
            End If

        End If

        btOK.Enabled = True
    End Sub

    Private Sub listSources_SelectedValueChanged(sender As Object, e As EventArgs) Handles listSources.SelectedValueChanged

    End Sub


    Private Sub btSendBack_Click(sender As Object, e As EventArgs) Handles btSendBack.Click
        Dim newItem As String = listTarget.Items(listTarget.SelectedIndex).ToString()
        If newItem <> "word" Then
            If lstTarget.ContainsKey(newItem) = True Then
                lstTarget.Remove(newItem)
                listTarget.Items.RemoveAt(listTarget.SelectedIndex)
            End If
        End If

        If listTarget.Items.Count = 0 Then btOK.Enabled = False
    End Sub

    Private Sub btPath_Click(sender As Object, e As EventArgs) Handles btPath.Click
        OpenFileDialog1.Filter = "CSV Documents *.csv|*.csv|*.txt|*.txt"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fullpath As String = OpenFileDialog1.FileName

            txtPath.Text = fullpath
        End If
    End Sub

    Sub ImportFile(path As String, row As Integer)
        ' Dim engine As New FileHelperEngine(GetType(ImprotCSV1Row))

        SQLconnect.ConnectionString = "Data Source=" & path1.PathOfProject & "\project.db;Version=3;Legacy Format=True;SQLITE_THREADSAFE=2"
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand

        Dim res() = File.ReadAllLines(path)
        Dim _tempList As New List(Of String)
        'MsgBox(res.Length)
        For Each w1 In res
            Dim _text1 As String = w1
            Dim arr() As String = _text1.Split(txtSeparator.Text)
            Dim _word As String = arr(0).ToLower

            Dim _line As String = ""
            For i = 0 To listTarget.Items.Count - 1
                Dim _key As String = listTarget.Items(i)
                _key = GetTag(_key)

                If _key = "word" Then
                    arr(i) = arr(i).ToLower
                End If

                arr(i) = _key & "~" & arr(i)
                _line = _line & arr(i) & vbNewLine
            Next
            '_line = _line.Substring(0, _line.Length - 1)
            _line = "'" & _status & "', '" & _word & "', '" & _line & "'"

            SQLcommand.CommandText = "INSERT INTO " & mUniform.ProjectTable & "(status, word, content) VALUES (" & _line & ")"
            SQLcommand.ExecuteNonQuery()

        Next

        SQLcommand.Dispose()

    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        'D 'im word As String = "vidiue <2>"

        'MsgBox(_ProjectManager.ExitsWord2("row1"))
        Me.Close()
    End Sub


    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        Dim pleasewait As New _pleaseWait
        pleasewait.Show()
        Application.DoEvents()

        Try
            If listTarget.Items.Count >= 1 Then
                'MsgBox(listTarget.Items.Count)
                ImportFile(txtPath.Text, listTarget.Items.Count)
            End If
        Catch ex As Exception
            pleasewait.Hide()
        End Try

        pleasewait.Hide()
        frmMDI.frmWordList.ImportWordList("", 0)
        Me.Close()
    End Sub

    Private Sub checkIncomplete_CheckedChanged(sender As Object, e As EventArgs) Handles checkIncomplete.CheckedChanged
        If checkIncomplete.Checked = True Then
            _status = "0"
        Else
            _status = "1"
        End If
    End Sub

    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mUniform.ProjectTable = "new_table"
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
            listSources.Items.Add(w1.Key)
        Next

        lstTarget.Add("Word", "")

        If checkIncomplete.Checked = True Then
            _status = "0"
        Else
            _status = "1"
        End If

        If checkDup.Checked = True Then
            _dup = False
        Else
            _dup = True
        End If

        btOK.Enabled = False
    End Sub

    Public Function GetTag(_key As String) As String
        Dim _tag As String

        If dicAttributes.ContainsKey(_key) Then
            _tag = dicAttributes.Item(_key)
        End If

        Return _tag
    End Function
    Private Sub checkDup_CheckedChanged(sender As Object, e As EventArgs) Handles checkDup.CheckedChanged
        If checkDup.Checked = True Then
            _dup = False
        Else
            _dup = True
        End If
    End Sub

    Private Sub txtSeparator_Leave(sender As Object, e As EventArgs) Handles txtSeparator.Leave
        If txtSeparator.Text = "" Then
            txtSeparator.Text = "|"
        End If

        If txtSeparator.Text.Length > 1 Then
            txtSeparator.Text = "|"
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub txtQuote_Leave(sender As Object, e As EventArgs) Handles txtQuote.Leave
        If txtQuote.Text.Length > 1 Then
            txtQuote.Text = "|"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' ImportFile(txtPath.Text, listTarget.Items.Count)
    End Sub
End Class