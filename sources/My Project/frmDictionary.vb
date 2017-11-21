Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite
Imports WeifenLuo.WinFormsUI.Docking
Partial Public Class frmDictionary
    Inherits DockContent

    Dim SQLconnect As SQLiteConnection = New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    Dim Path As New TummoPath
    Dim checked As List(Of Integer)
    Dim strHTML(6) As String
    Dim f1 As frmResultDictionary
    Dim DBready As Boolean = False
    Dim oldWord As String
    Private Sub frmDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMenu()
        LoadCss("styles.css")
        f1 = New frmResultDictionary(Me.Top, Me.Left, Me.Width)
        LoadListWord("a")

        listWord.DefaultCellStyle.SelectionBackColor = Color.FromArgb(114, 204, 255)
        listWord.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 25, 200)
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs)
        'If txtSearch.Text = "Search" Then
        ' txtSearch.Text = ""

        'End If
    End Sub

    Private Sub LoadListWord(strword As String)
        If strword <> oldWord Then
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT * FROM index_" & mUniform.PackageTable & " WHERE word1 LIKE '" & strword & "%' OR word LIKE '" & txtSearch.Text & "%' ORDER BY word ASC"
            Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
            Dim word, word1 As String

            listWord.Rows.Clear()

            Dim i As Integer = 0
            While SQLreader.Read()
                If i <= 300 Then
                    word = SQLreader(0).ToString
                    word1 = SQLreader(1).ToString
                    listWord.Rows.Add()
                    listWord.Item(0, i).Value = word1
                    'listWord.Items.Add(word1)
                Else
                    Exit Sub
                End If

                i = i + 1
            End While
            oldWord = strword
        End If

    End Sub
    Private Sub LoadMenu()
        SQLconnect.ConnectionString = "Data Source=" & Path.PathOfDict & "\tummodic.db;"
        SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM info_dictionary"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim tittle As String
        Dim used As Integer
        Dim id As Integer
        Dim author As String
        Dim shortname As String
        Dim table As String
        checked = New List(Of Integer)
        Dim i As Integer = 0
        While SQLreader.Read()
            id = SQLreader(0).ToString
            tittle = SQLreader(1).ToString
            shortname = SQLreader(2).ToString
            author = SQLreader(3).ToString
            table = SQLreader(4).ToString
            used = SQLreader(6)
            If used = 1 Then
                contextDictionaries.Items.Add(tittle, ImageList1.Images(0)).Tag = "1|" & id & "|" & i

                checked.Add(1)
                mUniform.PackageTable = table
                mUniform.PackLongName = tittle
                mUniform.PackShortName = shortname
            Else
                checked.Add(0)
                contextDictionaries.Items.Add(tittle).Tag = "0|" & id & "|" & i
            End If
            i = i + 1
        End While
        contextDictionaries.Items.Add("-").Tag = "0|0|0"
        contextDictionaries.Items.Add("All Dictionaries").Tag = "-1|-1|-1"
        DBready = True
    End Sub

    Private Sub LoadDictionary(_id As Integer)
        'SQLconnect.ConnectionString = "Data Source=" & Path.PathOfDict & "\tummodic.db;"
        'SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM info_dictionary WHERE stt='" & _id & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim tittle As String
        Dim used As Integer
        Dim id As Integer
        Dim author As String
        Dim shortname As String
        Dim table As String
        checked = New List(Of Integer)
        Dim i As Integer = 0
        While SQLreader.Read()
            id = SQLreader(0).ToString
            tittle = SQLreader(1).ToString
            shortname = SQLreader(2).ToString
            'author = SQLreader(3).ToString
            table = SQLreader(4).ToString
            'used = SQLreader(6)
            mUniform.PackageDict = id
            mUniform.PackageTable = table
            mUniform.PackLongName = tittle
            mUniform.PackShortName = shortname
        End While
    End Sub

    Private Sub contextDictionaries_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles contextDictionaries.ItemClicked
        Dim toolitem As ToolStripItem = e.ClickedItem
        Dim getTag As String = toolitem.Tag
        Dim arr() As Object = getTag.Split("|"c)
        Dim used As Integer = arr(0)
        Dim dicindex As Integer = arr(1)
        Dim stt As Integer = arr(2)

        For i = 0 To contextDictionaries.Items.Count - 1
            If stt = i Then
                contextDictionaries.Items(i).Image = ImageList1.Images(0)
            Else
                contextDictionaries.Items(i).Image = Nothing
            End If
        Next

        LoadDictionary(dicindex)
    End Sub

    Private Sub LoadCss(cssfile As String)
        Dim Path As New TummoPath
        Dim objReader As New System.IO.StreamReader(Path.PathOfStyle & "\" & cssfile)
        strHTML(0) = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>"
        strHTML(1) = "<html xmlns='http://www.w3.org/1999/xhtml'>"
        strHTML(2) = "<head><title>Tummo Dictionary</title><meta http-equiv='Content-Type' content='text/html; charset=UTF-8'><style type='text/css'>"
        strHTML(4) = "</style></head><body>"
        strHTML(3) = objReader.ReadToEnd()

    End Sub

    Public Function SearchWord(strWord As String, tablename As String)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM " & tablename & " WHERE word LIKE" & "'" & strWord & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim word, word1 As String


        Dim strContent, strWords As String
        Dim dictindex As Object

        Dim i As Integer = 0
        Using oWrite As StreamWriter = New StreamWriter(Path.PathOfStyle & "\keywords.html")
            oWrite.WriteLine(strHTML(0))
            oWrite.WriteLine(strHTML(1))
            oWrite.WriteLine(strHTML(2))
            oWrite.WriteLine(strHTML(3))
            oWrite.WriteLine(strHTML(4))
            While SQLreader.Read()
                dictindex = SQLreader(1)
                strWords = SQLreader(2).ToString
                strContent = SQLreader(3).ToString

                If strContent <> "" Then
                    If mUniform.PackageDict = 0 Then
                        'If dictindex = 2 Then
                        'mUniform.PackLongName = "Buddhist Dictionary"
                        'ElseIf dictindex = 3 Then
                        'mUniform.PackLongName = "Concise Pali-English"
                        'ElseIf dictindex = 4 Then
                        'mUniform.PackLongName = "The Pali Text Society"
                        'ElseIf dictindex = 5 Then
                        'mUniform.PackLongName = "Pali Proper Names"
                        'ElseIf dictindex = 6 Then
                        'mUniform.PackLongName = "Vipassana Research Institute"
                        'End If
                    ElseIf mUniform.PackageDict = 2 Then
                        If dictindex = 7 Then
                            mUniform.PackLongName = "by Bửu Chơn"
                        ElseIf dictindex = 8 Then
                            mUniform.PackLongName = "by tỳ khưu Giác Nguyên"
                        ElseIf dictindex = 9 Then
                            mUniform.PackLongName = "by Tịnh Sự"
                        End If
                    End If
                    strContent = strContent.Replace("</br>", "<p></p>")
                    oWrite.WriteLine("<div id='dict' class='dict'>" & mUniform.PackLongName & "</div>")
                    oWrite.WriteLine("<div id='words' class='words'>" & strWords & "</div>")

                    oWrite.WriteLine("<div id='content' class='content'>" & strContent & "</div>")
                End If
            End While
            oWrite.WriteLine("</body></html>")
        End Using
    End Function


    Private Sub listWord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listWord.CellContentClick
        Dim sword As String = listWord.Item(0, e.RowIndex).Value
        'LoadListWord(mUniform.PackageTable) ' txtSearch.Text = sword
        SearchWord(sword, mUniform.PackageTable)
        Try
            f1.Show()
            f1.Text = sword
            f1.WebBrowser1.Url = New System.Uri(Path.PathOfStyle & "\keywords.html", System.UriKind.Absolute)
            'txtSearch.Text = sword
        Catch ex As Exception
            f1 = New frmResultDictionary(Me.Top, Me.Left, Me.Width)
            f1.Show()
            f1.Text = sword
            f1.WebBrowser1.Url = New System.Uri(Path.PathOfStyle & "\keywords.html", System.UriKind.Absolute)
            'txtSearch.Text = sword
        End Try
        'LoadListWord(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        LoadListWord(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchWord(txtSearch.Text, mUniform.PackageTable)
            Dim f1 As New frmResultDictionary(Me.Top, Me.Left, Me.Width)
            f1.Show()
        End If
    End Sub

    Private Sub listWord_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles listWord.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.WhiteSmoke
        End If
    End Sub
End Class