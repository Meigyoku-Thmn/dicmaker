Imports System.IO
Imports FastColoredTextBoxNS
Imports System.Windows.Forms
Public Class BuildCode
    Public Event BuildFinished As EventHandler
    Public Finished As Boolean = False
    Dim path1 As New TummoPath
    Dim dicAttributes As New Dictionary(Of String, String)
    Dim _projectManager As New ProjectManager
    Sub New()
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
    End Sub
    Public Function BuildField(_datagird As DataGridView) As String
        Dim _textbox1 As New FastColoredTextBox

        Dim _line As String = ""
        For i = 0 To _datagird.RowCount - 1
            Dim _tag As String = _datagird.Item(1, i).Tag
            Dim _value As String = _datagird.Item(2, i).Value
            'Dim _key1 As String = dicAttributes.Item(_key)
            _textbox1.Text = _value
            'Dim _tag As String

            If _tag <> "" Then
                If _tag = "table" Then
                    Dim _table As String = _projectManager.ExtractTable(_value)
                    _line = _line & _table & vbNewLine
                Else
                    If _textbox1.LinesCount - 1 >= 1 Then
                        For j = 0 To _textbox1.LinesCount - 1
                            Dim _temp1 As String = _textbox1.GetLineText(j)
                            Dim _tag1 As String = "<p id=" & Chr(34) & _tag & Chr(34) & ">" & _temp1 & "</p>"
                            _line = _line & _tag1 & vbNewLine
                        Next
                    Else
                        _tag = "<p id=" & Chr(34) & _tag & Chr(34) & ">" & _value & "</p>"
                        _line = _line & _tag & vbNewLine
                    End If
                End If
            End If
        Next

        Return _line
    End Function

    Public Function SaveHTML(_style As String, _code As String) As String
        'Dim _style As String = _projectManager.LoadStyle(_StyleName)

        Dim strHTML(5) As String
        strHTML(0) = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>"
        strHTML(1) = "<html xmlns='http://www.w3.org/1999/xhtml'>"
        strHTML(2) = "<head><title>Tummo Dictionary</title><meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>"
        strHTML(4) = "</head><body>"

        Dim _pathfile As String = path1.PathOfStyle & "\result.html"
        Using oWrite As StreamWriter = New StreamWriter(_pathfile)
            oWrite.WriteLine(strHTML(0))
            oWrite.WriteLine(strHTML(1))
            oWrite.WriteLine(strHTML(2))
            oWrite.WriteLine(_style)
            oWrite.WriteLine(strHTML(4))
            oWrite.WriteLine(_code)
            oWrite.WriteLine("</body></html>")
        End Using

        Return _pathfile
    End Function

End Class
