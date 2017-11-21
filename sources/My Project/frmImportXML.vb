Imports System.IO
Imports System
Imports System.Xml
Imports System.Text.RegularExpressions
Imports System.Data.SQLite
Public Class frmImportXML
    Dim _ProjectManager As New ProjectManager
    Dim _status As Integer
    Dim _dup As Boolean
    Dim SQLconnect As SQLiteConnection = New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    Dim Path1 As New TummoPath
    Private Sub frmImportXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btOK.Enabled = False
        'mUniform.ProjectTable = "new_table"
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
    End Sub

    Private Sub btPath_Click(sender As Object, e As EventArgs) Handles btPath.Click
        OpenFileDialog1.Filter = "XML Documents *.xml|*.xml"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fullpath As String = OpenFileDialog1.FileName

            txtPath.Text = fullpath
            btOK.Enabled = True
        End If
    End Sub

    Public Function AddProject(_filename As String) As Boolean
        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode

        'Create the XML Document
        m_xmld = New XmlDocument()
        'Load the Xml file
        m_xmld.Load(_filename)
        'Get the list of name nodes 
        m_nodelist = m_xmld.SelectNodes("/dataroot/ProfileOfDict")
        'Loop through the nodes
        For Each m_node In m_nodelist
            Dim arr(8) As String
            arr(0) = m_node.ChildNodes.Item(1).InnerText
            arr(1) = _ProjectManager.ChangeTittle(m_node.ChildNodes.Item(1).InnerText)
            Dim str1 As String = m_node.ChildNodes.Item(3).InnerText

            arr(2) = str1.Replace("'", "")
            arr(3) = "email:"
            arr(4) = "http://www.tummosoftware.com"
            arr(5) = m_node.ChildNodes.Item(7).InnerText
            arr(6) = m_node.ChildNodes.Item(5).InnerText
            arr(7) = "1"

            _ProjectManager.InsertProject(arr)
            _ProjectManager.CreateTable(arr(1))
            mUniform.ProjectTable = arr(1)
        Next
    End Function
    Public Function ReadProject(_filename)
        SQLconnect.ConnectionString = "Data Source=" & path1.PathOfProject & "\project.db;Version=3;Legacy Format=True;SQLITE_THREADSAFE=2"
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand

        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode
        Dim fileds As String = "word, pronunciation, notes, content"

        'Create the XML Document
        m_xmld = New XmlDocument()
        'Load the Xml file
        m_xmld.Load(_filename)
        'Get the list of name nodes 
        Dim _listEntry As New List(Of String)
        If _ProjectManager.ExitsTable(mUniform.ProjectTable) = True Then
            m_nodelist = m_xmld.SelectNodes("/dataroot/main/details")
            'Loop through the nodes
            For Each m_node In m_nodelist

                Dim _line As String = ""
                Dim _trans As String
                Dim _word As String
                Dim _content As String

                _word = m_node.ChildNodes.Item(1).InnerText
                _line = "word~" & _word & vbNewLine
                _trans = m_node.ChildNodes.Item(2).InnerText
                If _trans <> "" Then
                    _line = _line & "pron~" & _trans & vbNewLine
                End If
                _content = m_node.ChildNodes.Item(3).InnerText
                _content = _content.Replace("'", "''")
                _content = _content.Replace(vbCrLf, "¶")
                _content = _content.Replace("<ul>", "<span class='ul'>")
                _content = _content.Replace("</ul>", "</span>")
                _content = _content.Replace("<ol>", "<span class='ol'>")
                _content = _content.Replace("</ol>", "</span>")
                _content = _content.Replace("<li>", "<span class='li'>")
                _content = _content.Replace("</li>", "</span>")

                '"<span class='ul'>", "</span>"

                _line = _line & "def~" & _content

                Dim _value As String = "'" & _status & "', '" & _word & "', '" & _line & "'"

                SQLcommand.CommandText = "INSERT INTO " & mUniform.ProjectTable & "(status, word, content) VALUES (" & _value & ")"
                SQLcommand.ExecuteNonQuery()

            Next

            SQLcommand.Dispose()

        End If
    End Function

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        Dim pleasewait As New _pleaseWait
        pleasewait.Show()
        Application.DoEvents()
        'AddProject(txtPath.Text)
        ReadProject(txtPath.Text)
        pleasewait.Hide()

        frmMDI.frmWordList.ImportWordList("", 0)
        Me.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Me.Close()
    End Sub

    Private Sub checkDup_CheckedChanged(sender As Object, e As EventArgs) Handles checkDup.CheckedChanged
        If checkDup.Checked = True Then
            _dup = False
        Else
            _dup = True
        End If
    End Sub

    Private Sub checkIncomplete_CheckedChanged(sender As Object, e As EventArgs) Handles checkIncomplete.CheckedChanged
        If checkIncomplete.Checked = True Then
            _status = "0"
        Else
            _status = "1"
        End If
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub
End Class