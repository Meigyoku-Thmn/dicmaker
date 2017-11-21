Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SQLite
Imports ComponentFactory.Krypton.Toolkit
Imports FastColoredTextBoxNS
Imports Novacode

Class ProjectManager
    Dim SQLconnect As SQLiteConnection = New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    Dim Path As New TummoPath
    Public listProject As List(Of String)
    Dim colorTable As New Dictionary(Of String, String)
    Sub New()

        SQLconnect.ConnectionString = "Data Source=" & Path.PathOfProject & "\project.db;Version=3;Legacy Format=True;SQLITE_THREADSAFE=2"
        SQLconnect.Open()

        colorTable.Add("word", "#CE0346")
        colorTable.Add("hyph", "#70AD47")
        colorTable.Add("pron", "#70AD47")
        colorTable.Add("der", "#6A6A6A")
        colorTable.Add("etym", "#6A6A6A")
        colorTable.Add("subc", "#EEAA47")
        colorTable.Add("category", "#C45911")
        colorTable.Add("def", "#00B0F0")
        colorTable.Add("eg", "#515456")
        colorTable.Add("trans", "#515456")
        colorTable.Add("ref", "#C45911")
        colorTable.Add("Tittle", "#00B0F0")
        colorTable.Add("info", "#FFF99F")
    End Sub

    Sub Close()
        SQLconnect.Close()
    End Sub

    Sub DeleteProject(id As Integer)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "DELETE FROM info_project WHERE id = '" & id & "'"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
    End Sub

    Sub DeleteTable(_table As String)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "DROP TABLE IF EXISTS " & _table & ""
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
    End Sub

    Sub DeleteRow(_table As String, _id As String, _value As String)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "DELETE FROM " & _table & " WHERE " & _id & " = '" & _value & "'"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
    End Sub

    Public Sub InsertProject(arr() As String)

        Dim tittle As String = "'" & arr(0) & "', "
        Dim tablename As String = "'" & arr(1) & "', "
        Dim description As String = "'" & arr(2) & "', "
        Dim email As String = "'" & arr(3) & "', "
        Dim website As String = "'" & arr(4) & "', "
        Dim copyright As String = "'" & arr(5) & "', "
        Dim version As String = "'" & arr(6) & "', "
        Dim used As String = "'" & arr(7) & "'"


        Dim _value As String = tittle & tablename & description & email & website & copyright & version & used
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "INSERT INTO info_project (tittle, tablename, description, email, website, copyright, version, used) VALUES (" & _value & ")"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
        ChangeCurrentProject(arr(1))
    End Sub

    Public Sub AddEntry(_table As String, _status As String, _word As String, _content As String)
        Dim _value As String = "'" & _status & "', '" & _word & "', '" & _content & "'"

        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "INSERT INTO " & _table & " (status, word, content) VALUES (" & _value & ")"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
    End Sub

    Public Sub InsertRow(_table As String, field() As String, value() As String)

        Dim _field As String = ""
        Dim _value As String = ""
        For i = 0 To field.Count - 1
            If field(i) <> "" Then
                _field = _field & field(i) & ","
            End If
        Next
        _field = _field.Substring(0, _field.Length - 1)
        For i = 0 To value.Count - 1
            If value(i) <> "" Then
                _value = _value & "'" & value(i) & "',"
            End If

        Next
        _value = _value.Substring(0, _value.Length - 1)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "INSERT INTO " & _table & " (" & _field & ") VALUES (" & _value & ")"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
    End Sub
    Public Sub ImportEntry(_listEntry As List(Of String), checkExit As Boolean)

        Using t As SQLiteTransaction = SQLconnect.BeginTransaction
            SQLcommand = SQLconnect.CreateCommand
            For i = 0 To _listEntry.Count - 1
                Dim _row As String = _listEntry.Item(i)
                If _row <> "" Then
                    SQLcommand.CommandText = "INSERT INTO " & mUniform.ProjectTable & "(status,word,content) VALUES (" & _row & ")"
                    SQLcommand.ExecuteNonQuery()
                End If
            Next
        End Using
        ' SQLcommand = SQLconnect.CreateCommand


        SQLcommand.Dispose()
    End Sub

    Public Sub RennameWord(OldWord As String, NewWord As String)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "UPDATE " & mUniform.ProjectTable & " Set word = '" & NewWord & "' WHERE word = '" & OldWord & "'"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
    End Sub
    Public Function tableExits(_table As String) As Boolean
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT EXISTS(SELECT tablename FROM info_project WHERE tablename='" & _table & "' LIMIT 1)"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim result As Boolean

        While SQLreader.Read()
            Dim w1 As String = SQLreader(0)
            If w1 = "1" Then
                result = True
            Else
                result = False
            End If
        End While

        SQLcommand.Dispose()

        Return result
    End Function

    Public Function CreateTable(_tablename As String) As Boolean
        Try
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "CREATE TABLE '" & _tablename & "' ('id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 'status'	INTEGER, 'word'	TEXT, 'content' TEXT)"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function RandomProject() As String
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM info_project WHERE used ='0'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        Dim result As String = ""
        While SQLreader.Read()
            If i = 1 Then
                result = SQLreader(2)
                i = i + 1
                Exit While
            End If
        End While

        SQLcommand.Dispose()

        Return result
    End Function
    Public Sub ChangeCurrentProject(_tablename As String)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "UPDATE info_project SET used = '0'"
        SQLcommand.ExecuteNonQuery()

        SQLcommand.CommandText = "UPDATE info_project SET used = '1' WHERE tablename = '" & _tablename & "'"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
    End Sub

    Public Function FindCurrentProject() As String()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM info_project WHERE used ='1'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim result(9) As String
        While SQLreader.Read()
            result(0) = SQLreader(0)
            result(1) = SQLreader(1)
            result(2) = SQLreader(2)
            result(3) = SQLreader(3)
            result(4) = SQLreader(4)
            result(5) = SQLreader(5)
            result(6) = SQLreader(6)
            result(7) = SQLreader(7)
            result(8) = SQLreader(8)
            mUniform.ProjectName = result(1)
            mUniform.ProjectTable = result(2)
        End While

        SQLcommand.Dispose()

        Return result
    End Function

    Public Function CountWord(_word As String) As Int16
        Dim theQuery As String = "SELECT COUNT(*) FROM " & mUniform.ProjectTable & " WHERE word LIKE '" & _word & "' OR word LIKE '" & _word & " <%>'"
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = theQuery

        Dim _count As Int16 = Convert.ToInt16(SQLcommand.ExecuteScalar())

        Return _count
    End Function

    Public Function CountEntry() As Int16
        Dim theQuery As String = "SELECT COUNT(*) FROM " & mUniform.ProjectTable
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = theQuery

        Dim _count As Int16 = Convert.ToInt16(SQLcommand.ExecuteScalar())

        Return _count
    End Function
    Public Function DupWord(_word As String) As Integer
        Dim theQuery As String = "SELECT COUNT(*) FROM " & mUniform.ProjectTable & " WHERE word ='" & _word & "'"
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = theQuery
        '  Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        ' Dim i As Integer = 0
        Dim _count As Int16 = Convert.ToInt16(SQLcommand.ExecuteScalar())
        ' While SQLreader.Read()
        'Dim id As Object = SQLreader(1)
        MsgBox(_count)
        ' End While

        SQLcommand.Dispose()
    End Function

    Public Sub DupWordChange(_word As String)
        Dim theQuery As String = "SELECT word FROM " & mUniform.ProjectTable & " WHERE word ='" & _word & "'"
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = theQuery
        ' Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        'Dim i As Integer = 0

        Using reader As SQLiteDataReader = SQLcommand.ExecuteReader
            If reader.HasRows Then
                RennameWord(_word, _word & "<1>")
            End If
        End Using

        SQLcommand.Dispose()
        'Return i
    End Sub

    Public Function ExitsWord(_word As String) As Integer
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT word FROM " & mUniform.ProjectTable & " WHERE word ='" & _word & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim i As Integer = 0

        While SQLreader.Read()
            i = i + 1
        End While

        SQLcommand.Dispose()
        Return i

    End Function

    Public Function ExitsTable(_tablename As String) As Boolean
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' AND name ='" & _tablename & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim i As Integer = 0

        While SQLreader.Read()
            i = i + 1
        End While

        SQLcommand.Dispose()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ExitsWord2(_word As String) As Integer
        Dim listNum As New List(Of Integer)

        For j = 0 To 10

            SQLcommand = SQLconnect.CreateCommand
            'SELECT * FROM T5_6i5n_ti4ng_Vi1t WHERE word LIKE '%<%>'
            SQLcommand.CommandText = "SELECT id, word FROM " & mUniform.ProjectTable & " WHERE word LIKE '" & _word.ToLower & "%<%>'"
            Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

            While SQLreader.Read()
                ' Dim id As Object = SQLreader(0)
                Dim word As String = SQLreader(1)
                Dim arr() As String = word.Split("<")
                Dim num1 As Object = arr(1).Replace(">", "")
                'MsgBox(num1)
                listNum.Add(num1)
            End While
            SQLcommand.Dispose()
        Next

        If listNum.Count > 0 Then
            listNum.Sort()
            Dim v1 As Object = listNum.Item(listNum.Count - 1)
            ' MsgBox(v1)
            Return v1
        Else
            Return 0
        End If

    End Function

    Public Function CheckDup(ByVal _word As String) As String

        If ExitsWord(_word) > 0 Then
            Dim oldword As String = _word
            Dim newworld As String = _word & " <1>"
            RennameWord(oldword, newworld)
            Return _word & " <2>"
            ' MsgBox("")
        Else
            Dim num1 As Integer = ExitsWord2(_word)
            If num1 <> 0 Then
                Dim oldword As String = _word
                Dim newworld As String = _word & " <" & num1 + 1 & ">"
                'RennameWord(oldword, newworld)
                Return newworld
            Else
                Return _word
            End If
        End If
    End Function

    Public Sub NewEntry(arr() As String)

        Dim status As String = "'" & arr(0) & "', "
        Dim word As String = "'" & arr(1) & "', "
        arr(2) = arr(2).Replace("'", "''")
        Dim content As String = "'" & arr(2) & "'"

        Dim _value As String = status & word & content
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "INSERT INTO " & mUniform.ProjectTable & " (status, word, content) VALUES (" & _value & ")"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()

    End Sub

    Public Sub UpdateEntry(_word As String, arr() As String)

        Dim status As String = "status ='" & arr(0) & "', "
        Dim word As String = "word ='" & arr(1) & "', "
        arr(2) = arr(2).Replace("'", "''")
        Dim content As String = "content ='" & arr(2) & "'"

        Dim _value As String = status & word & content
        SQLcommand = SQLconnect.CreateCommand
        'SQLcommand.CommandText = "UPDATE info_project SET used = '0'"
        SQLcommand.CommandText = "UPDATE " & mUniform.ProjectTable & " SET " & _value & " WHERE word = '" & _word & "'"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()

    End Sub

    Public Sub UpdateAtrributes(_rowID As String, _tittle As String, _code1 As String)

        Dim status As String = "tittle ='" & _tittle & "', "
        Dim word As String = "code ='" & _code1 & "'"

        Dim _value As String = status & word
        SQLcommand = SQLconnect.CreateCommand
        'SQLcommand.CommandText = "UPDATE info_project SET used = '0'"
        SQLcommand.CommandText = "UPDATE Attributes SET " & _value & " WHERE id = '" & _rowID & "'"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()

    End Sub
    Public Function LoadEntry(_word As String) As String()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE word = '" & _word.ToLower & "'"

        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim result(9) As String
        While SQLreader.Read()
            Dim id As Object = SQLreader(0)
            Dim status As Object = SQLreader(1)
            Dim word As String = SQLreader(2).ToString
            Dim content As String = SQLreader(3).ToString

            If Not IsDBNull(id) Then
                result(0) = id
            Else
                result(0) = 0
            End If

            result(1) = status
            result(2) = word
            result(3) = content

        End While
        SQLcommand.Dispose()
        Return result
    End Function

    Public Sub ImportWordList(ByVal gridWords As DataGridView, imagelist1 As ImageList, _tablename As String, filter As Integer, v As String)
        gridWords.BackgroundColor = Color.White
        SQLcommand = SQLconnect.CreateCommand

        If v = "" Then
            If filter = 0 Then
                SQLcommand.CommandText = "SELECT * FROM " & _tablename
            ElseIf filter = 1 Then
                SQLcommand.CommandText = "SELECT * FROM " & _tablename & " WHERE status = '0'"
            ElseIf filter = 2 Then
                SQLcommand.CommandText = "SELECT * FROM " & _tablename & " WHERE status = '1'"
            End If
        Else
            SQLcommand.CommandText = "SELECT * FROM " & _tablename & " WHERE word LIKE '" & v.ToLower & "%'"
        End If


        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        gridWords.Rows.Clear()
        Dim i As Integer = 0
        While SQLreader.Read()
            gridWords.Rows.Add()
            Dim id As Object = SQLreader(0)
            Dim status As Object = SQLreader(1)
            Dim word As String = SQLreader(2).ToString
            Dim pronunciation As String = SQLreader(3).ToString
            Dim derive As String = SQLreader(4).ToString
            Dim etymology As String = SQLreader(5).ToString
            Dim abbreviations As String = SQLreader(6).ToString
            Dim notes As String = SQLreader(7).ToString
            Dim content As String = SQLreader(8).ToString

            If status = 0 Then
                gridWords.Item(1, i).Value = imagelist1.Images(1)
                gridWords.Item(1, i).Tag = 1
            Else
                gridWords.Item(1, i).Value = imagelist1.Images(0)
                gridWords.Item(1, i).Tag = 0
            End If

            gridWords.Item(2, i).Value = word

            i = i + 1

        End While
        SQLcommand.Dispose()
        EntryReady = True

        'Throw New NotImplementedException()
    End Sub


    Public Sub LoadInfoProject(ByVal grid As KryptonDataGridView, imagelist1 As ImageList)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM info_project"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        grid.Rows.Clear()

        While SQLreader.Read()
            grid.Rows.Add()
            Dim id As Object = SQLreader(0)
            Dim tittle As String = SQLreader(1)
            Dim tablename As String = SQLreader(2)
            Dim description As String = SQLreader(3)
            Dim email As String = SQLreader(4)
            Dim website As String = SQLreader(5)
            Dim copyright As String = SQLreader(6)
            Dim version As String = SQLreader(7)
            Dim used As Object = SQLreader(8)

            If used = 1 Then
                grid.Item(0, i).Value = imagelist1.Images(1)
            Else
                grid.Item(0, i).Value = imagelist1.Images(0)
            End If

            grid.Item(1, i).Value = SQLreader(1).ToString ' tittle
            grid.Item(2, i).Value = SQLreader(3).ToString ' description
            grid.Item(3, i).Value = SQLreader(7).ToString ' version
            listProject.Add(id & "|" & tittle & "|" & tablename & "|" & description & "|" & email & "|" & website & "|" & version & "|" & used)
            i = i + 1


        End While
        SQLcommand.Dispose()
    End Sub

    Public Function RemoveTag(_word As String) As String
        If _word <> "" Then
            Return Regex.Replace(_word, "<.*?>", "")
        Else
            Return String.Empty
        End If

    End Function

    Private Function GetRamdom(ByVal min As Integer, ByVal max As Integer) As Integer
        Static Generator As System.Random = New System.Random
        Return Generator.Next(min, max)
    End Function

    Public Function ChangeTittle(tittle As String) As String

        Dim _ascii As Encoding = Encoding.ASCII
        Dim _uni As Encoding = Encoding.Unicode

        Dim unicodebytes As Byte() = _uni.GetBytes(tittle)
        Dim asciiBytes As Byte() = Encoding.Convert(_uni, _ascii, unicodebytes)
        Dim asciiChars(_ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length - 1)) As Char
        _ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0)
        Dim asciiString As New String(asciiChars)

        Dim result As String
        For i = 0 To asciiString.Length - 1
            Dim ch1 As Char = asciiString.Substring(i, 1)
            If ch1 = "?" Then
                ch1 = GetRamdom(0, 9).ToString
                result = result & ch1
            ElseIf ch1 = " " Then
                ch1 = "_"
                result = result & ch1
            Else
                result = result & ch1
            End If

        Next

        Return result
    End Function

    Public Function ToAttributesGroup(_table As String, _combobox As ComboBox, _value As String, _tag As String) As Dictionary(Of Integer, String)
        Dim field As String = _tag & "," & _value
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM AttributesGroup"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim result As New Dictionary(Of Integer, String)
        While SQLreader.Read()

            Dim value As String = SQLreader(1)
            Dim tag As String = SQLreader(0)

            _combobox.Items.Add(value)
            result.Add(tag, value)
        End While
        SQLcommand.Dispose()

        Return result
    End Function

    Public Function ToAttributesGroup2(_table As String, _list As Object, _value As String, _tag As String) As Dictionary(Of Integer, String)
        Dim field As String = _tag & "," & _value
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM AttributesGroup"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim result As New Dictionary(Of Integer, String)
        While SQLreader.Read()

            Dim value As String = SQLreader(1)
            Dim tag As String = SQLreader(0)

            _list.Items.Add(value)
            result.Add(tag, value)

        End While
        SQLcommand.Dispose()

        Return result
    End Function

    Public Sub ToAttributes(_id As Integer, grid As KryptonDataGridView, _image As ImageList)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM Attributes WHERE idgroup = '" & _id & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        grid.Rows.Clear()

        While SQLreader.Read()

            Dim id As Object = SQLreader(0)
            Dim idgroup As String = SQLreader(1)
            Dim tittle As String = SQLreader(2)
            Dim code As String = SQLreader(3)
            grid.Rows.Add()
            grid.Item(0, i).Value = _image.Images(0)
            grid.Item(1, i).Value = code
            grid.Item(2, i).Value = tittle

            i = i + 1

        End While
        SQLcommand.Dispose()
    End Sub

    Public Sub ToAttributes2(_id As Integer, grid As DataGridView)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM Attributes WHERE idgroup = '" & _id & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        grid.Rows.Clear()

        While SQLreader.Read()

            Dim id As Object = SQLreader(0)
            Dim idgroup As String = SQLreader(1)
            Dim tittle As String = SQLreader(2)
            Dim code As String = SQLreader(3)
            grid.Rows.Add()
            grid.Item(0, i).Value = id
            grid.Item(1, i).Value = tittle
            grid.Item(2, i).Value = code

            i = i + 1

        End While
        SQLcommand.Dispose()
    End Sub

    Public Function LoadStyle(_stylename As String) As String
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT code FROM style WHERE tittle = '" & _stylename & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim _code As String = ""
        While SQLreader.Read()
            _code = SQLreader(0)
        End While
        SQLcommand.Dispose()

        Return _code
    End Function

    Public Function ToCombobox(_tablename As String, _field As String, ByVal _cobo As ComboBox)
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT " & _field & " FROM " & _tablename
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        _cobo.Items.Clear()

        While SQLreader.Read()
            _cobo.Items.Add(SQLreader(0))
        End While
        SQLcommand.Dispose()

        ' Return _code
    End Function

    ' /////////////////////////////
    '' EXPORT
    ' ///////////////////////////

    Public Sub ExportToTummo(_saveto As String, _option As Integer)
        Dim sw As New StreamWriter(_saveto)
        ' _option = -1 (all)
        ' _option
        ' reference explains properties
        Dim header() = FindCurrentProject()
        sw.WriteLine("###Title:" & header(1))
        sw.WriteLine("###Description:" & header(3))
        sw.WriteLine("###Author:" & header(6))
        sw.WriteLine("###Email:" & header(4))
        sw.WriteLine("###Website:" & header(5))
        sw.WriteLine("###Copyright:" & header(6))
        sw.WriteLine("")

        SQLcommand = SQLconnect.CreateCommand
        If _option = -1 Then
            SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " ORDER BY word ASC"
        Else
            SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "' ORDER BY word ASC"
        End If

        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        Dim _textbox1 As New FastColoredTextBox
        While SQLreader.Read()
            Dim _line As String
            Dim id As Object = SQLreader(0)
            Dim status As String = SQLreader(1)
            Dim word As String = SQLreader(2)
            Dim code As String = SQLreader(3)

            ' code = Replace(code, vbCr, "¶")
            _textbox1.Text = code

            Dim length1 As Integer = _textbox1.LinesCount - 1
            If length1 > 0 Then
                For i = 0 To length1
                    Dim str1 As String = _textbox1.GetLineText(i)
                    If i <= length1 Then
                        _line = _line & str1 & "§"
                    End If
                Next
            Else
                _line = code
            End If

            _line = _line.Substring(0, _line.Length - 2)
            _line = word & "|" & _line
            sw.WriteLine(_line)
            word = ""
            _line = ""
        End While
        sw.Dispose()
        sw.Close()
        SQLcommand.Dispose()
        MsgBox("Finished!", MsgBoxStyle.Information)
    End Sub


    Public Sub ExportToCSV(_saveto As String, _option As Integer)
        Dim sw As New StreamWriter(_saveto)
        ' _option = -1 (all)
        ' _option
        ' reference explains properties
        '  Dim header() = FindCurrentProject()
        'sw.WriteLine("###Title:" & header(1))
        'sw.WriteLine("###Description:" & header(3))
        ' sw.WriteLine("###Author:" & header(6))
        'sw.WriteLine("###Email:" & header(4))
        'sw.WriteLine("###Website:" & header(5))
        'sw.WriteLine("###Copyright:" & header(6))
        ' sw.WriteLine("")

        SQLcommand = SQLconnect.CreateCommand
        If _option = -1 Then
            SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " ORDER BY word ASC"
        Else
            SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "' ORDER BY word ASC"
        End If

        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        Dim _textbox1 As New FastColoredTextBox
        While SQLreader.Read()
            Dim _line As String
            Dim id As Object = SQLreader(0)
            Dim status As String = SQLreader(1)
            Dim word As String = SQLreader(2)
            Dim code As String = SQLreader(3)

            ' code = Replace(code, vbCr, "¶")
            _textbox1.Text = code

            Dim length1 As Integer = _textbox1.LinesCount - 1
            If length1 > 0 Then
                For i = 0 To length1
                    Dim str1 As String = _textbox1.GetLineText(i)
                    If i <= length1 Then
                        _line = _line & str1 & "§"
                    End If
                Next
            Else
                _line = code
            End If

            _line = _line.Substring(0, _line.Length - 2)
            _line = word & "|" & _line
            sw.WriteLine(_line)
            _line = ""
            _word = ""
        End While
        sw.Dispose()
        sw.Close()
        SQLcommand.Dispose()
        Process.Start(_saveto)
        'MsgBox("Finished!", MsgBoxStyle.Information)
    End Sub

    Public Function ConvertStyleToHTML(cssCode As String) As Dictionary(Of String, String)
        Dim _textbox As New FastColoredTextBox

        _textbox.Text = cssCode
        Dim _result As New Dictionary(Of String, String)
        For i = 0 To _textbox.LinesCount - 1
            Dim _key As String
            Dim _value As String
            Dim haskey As Boolean = False
            Dim str1 As String = _textbox.GetLineText(i)
            If str1.StartsWith("#") Then
                _key = Replace(str1, "{", "")
                _key = _key.Trim
                haskey = True
            Else
                If str1.StartsWith("color:") Then
                    'If haskey = True Then
                    Dim arr() = str1.Split(":")
                        _value = arr(1)
                        If _result.ContainsKey(_key) = False Then
                            _result.Add(_key, _value)
                            ' MsgBox(_key)
                            haskey = False
                        End If
                        'Else
                        haskey = False
                    'End If

                End If
            End If
        Next

        Return _result
    End Function
    Public Sub ExportToLDF(_saveto As String, _option As Integer)
        Dim sw As New StreamWriter(_saveto)
        ' _option = -1 (all)
        ' _option
        ' reference explains properties
        Dim header() = FindCurrentProject()
        sw.WriteLine("###Title:" & header(1))
        sw.WriteLine("###Description:" & header(3))
        sw.WriteLine("###Author:" & header(6))
        sw.WriteLine("###Email:" & header(4))
        sw.WriteLine("###Website:" & header(5))
        sw.WriteLine("###Copyright:" & header(6))
        sw.WriteLine("")

        SQLcommand = SQLconnect.CreateCommand
        If _option = -1 Then
            SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " ORDER BY word ASC"
        Else
            SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "' ORDER BY word ASC"
        End If
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        '  Dim csscode = LoadStyle(cssStyle)
        'Dim StyleColor = ConvertStyleToHTML(csscode)

        While SQLreader.Read()
            Dim _line As String
            Dim id As Object = SQLreader(0)
            Dim status As String = SQLreader(1)
            Dim word As String = SQLreader(2)

            Dim _textbox As New FastColoredTextBox
            Dim _line1 As String
            Dim _line2 As String
            _textbox.Text = SQLreader(3)

            sw.WriteLine(word)
            _line1 = ""
            _line2 = ""
            For i = 0 To _textbox.LinesCount - 1
                Dim str1 As String = _textbox.GetLineText(i)
                If str1 <> "" Then
                    Dim arr() = str1.Split("~")
                    If str1.StartsWith("word") Then
                        _line1 = arr(1)
                    ElseIf str1.StartsWith("pron") Then
                        _line1 = _line1 & " " & arr(1)
                    ElseIf str1.StartsWith("table") Then
                    Else
                        Dim color1 = "<font color=" & Chr(34) & colorTable.Item(arr(0)) & Chr(34) & ">"
                        Dim value2 As String = color1 & arr(1) & "</font>"
                        _line2 = _line2 & value2 & "<br/>"
                    End If
                End If
            Next
            ' Dim color1 = StyleColor.Item("word")
            _line1 = "<font color=" & Chr(34) & "#CE0346" & Chr(34) & ">" & _line1 & "</font>"
            sw.WriteLine(_line1 & "<br/>" & _line2.Substring(0, _line2.Length - 5))
            sw.WriteLine("")
        End While
        sw.Dispose()
        sw.Close()
        SQLcommand.Dispose()
        'MsgBox("Finished!", MsgBoxStyle.Information)
    End Sub

    Public Sub ExportToDOCX(_saveto As String, _option As Integer, _breakline As Boolean, _language As Integer, _start As String)

        SQLcommand = SQLconnect.CreateCommand
        If _language = 0 Then 'ENGLISH
            If _start = "-1" Then
                If _option = -1 Then
                    SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " ORDER BY word ASC"
                Else
                    SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "' ORDER BY word ASC"
                End If
            Else
                If _option = -1 Then
                    SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE substr(word,1,1) = '" & _start & "' ORDER BY word ASC"
                Else
                    SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE substr(word,1,1) = '" & _start & "' AND status = '" & _option & "' ORDER BY word ASC"
                End If
            End If

        ElseIf _language = 1 Then 'PALI
            If _option = -1 Then
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " ORDER BY CASE WHEN substr(word,1,1) = 'a' THEN 1 WHEN substr(word,1,1) = 'ā' THEN 2 WHEN substr(word,1,1) = 'b' THEN 3 WHEN substr(word,1,1) = 'c' THEN 4 WHEN substr(word,1,1) = 'd' THEN 5 WHEN substr(word,1,1) = 'ḍ' THEN 6 WHEN substr(word,1,1) = 'e' THEN 7 WHEN substr(word,1,1) = 'f' THEN 8 WHEN substr(word,1,1) = 'g' THEN 9 WHEN substr(word,1,1) = 'h' THEN 10 WHEN substr(word,1,1) = 'i' THEN 11 WHEN substr(word,1,1) = 'ī' THEN 12 WHEN substr(word,1,1) = 'j' THEN 13 WHEN substr(word,1,1) = 'k' THEN 14 WHEN substr(word,1,1) = 'l' THEN 15 WHEN substr(word,1,1) = 'm' THEN 16 WHEN substr(word,1,1) = 'n' THEN 17 WHEN substr(word,1,1) = 'ṅ' THEN 18 WHEN substr(word,1,1) = 'ñ' THEN 19 WHEN substr(word,1,1) = 'ṇ' THEN 20 WHEN substr(word,1,1) = 'o' THEN 21 WHEN substr(word,1,1) = 'p' THEN 22 WHEN substr(word,1,1) = 'q' THEN 23 WHEN substr(word,1,1) = 'r' THEN 24 WHEN substr(word,1,1) = 's' THEN 25 WHEN substr(word,1,1) = 't' THEN 26 WHEN substr(word,1,1) = 'ṭ' THEN 27 WHEN substr(word,1,1) = 'u' THEN 28 WHEN substr(word,1,1) = 'ū' THEN 29 WHEN substr(word,1,1) = 'v' THEN 30 WHEN substr(word,1,1) = 'w' THEN 31 WHEN substr(word,1,1) = 'x' THEN 32 WHEN substr(word,1,1) = 'y' THEN 33 WHEN substr(word,1,1) = 'z' THEN 34 END;"
            Else
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "'  ORDER BY CASE WHEN substr(word,1,1) = 'a' THEN 1 WHEN substr(word,1,1) = 'ā' THEN 2 WHEN substr(word,1,1) = 'b' THEN 3 WHEN substr(word,1,1) = 'c' THEN 4 WHEN substr(word,1,1) = 'd' THEN 5 WHEN substr(word,1,1) = 'ḍ' THEN 6 WHEN substr(word,1,1) = 'e' THEN 7 WHEN substr(word,1,1) = 'f' THEN 8 WHEN substr(word,1,1) = 'g' THEN 9 WHEN substr(word,1,1) = 'h' THEN 10 WHEN substr(word,1,1) = 'i' THEN 11 WHEN substr(word,1,1) = 'ī' THEN 12 WHEN substr(word,1,1) = 'j' THEN 13 WHEN substr(word,1,1) = 'k' THEN 14 WHEN substr(word,1,1) = 'l' THEN 15 WHEN substr(word,1,1) = 'm' THEN 16 WHEN substr(word,1,1) = 'n' THEN 17 WHEN substr(word,1,1) = 'ṅ' THEN 18 WHEN substr(word,1,1) = 'ñ' THEN 19 WHEN substr(word,1,1) = 'ṇ' THEN 20 WHEN substr(word,1,1) = 'o' THEN 21 WHEN substr(word,1,1) = 'p' THEN 22 WHEN substr(word,1,1) = 'q' THEN 23 WHEN substr(word,1,1) = 'r' THEN 24 WHEN substr(word,1,1) = 's' THEN 25 WHEN substr(word,1,1) = 't' THEN 26 WHEN substr(word,1,1) = 'ṭ' THEN 27 WHEN substr(word,1,1) = 'u' THEN 28 WHEN substr(word,1,1) = 'ū' THEN 29 WHEN substr(word,1,1) = 'v' THEN 30 WHEN substr(word,1,1) = 'w' THEN 31 WHEN substr(word,1,1) = 'x' THEN 32 WHEN substr(word,1,1) = 'y' THEN 33 WHEN substr(word,1,1) = 'z' THEN 34 END;"
            End If
        End If

        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        Dim indexChar As New Dictionary(Of Char, Char)

        Dim listtag As New Dictionary(Of String, String)

        listtag.Add("<b>", "§{b}")
        listtag.Add("</b>", "§")
        listtag.Add("<i>", "§{i}")
        listtag.Add("</i>", "§")
        listtag.Add("<u>", "§{u}")
        listtag.Add("</u>", "§")

        Using document As DocX = DocX.Create(_saveto)

            While SQLreader.Read()
                Dim _line As String
                Dim id As Object = SQLreader(0)
                Dim status As String = SQLreader(1)
                Dim word As String = SQLreader(2)

                Dim _textbox As New FastColoredTextBox
                Dim _line1 As String
                Dim _line2 As String
                _textbox.Text = SQLreader(3)

                _line1 = ""
                _line2 = ""
                Dim p As Paragraph

                Dim char1 As Char = word.Substring(0, 1).ToUpper
                If indexChar.ContainsKey(char1) = False Then
                    indexChar.Add(char1, "")
                    p = document.InsertParagraph()
                    p.Append(char1).Font(New FontFamily("Arial")).FontSize(18).Color(Color.Black).Bold()
                End If

                p = document.InsertParagraph()
                For i = 0 To _textbox.LinesCount - 1
                    Dim str1 As String = _textbox.GetLineText(i)
                    For Each w1 In listtag
                        str1 = Replace(str1, w1.Key, w1.Value)
                    Next
                    If str1 <> "" Then
                        Dim arr() = str1.Split("~")
                        arr(1) = arr(1) & " "
                        Dim str2 As String = arr(1)
                        If str1.StartsWith("word") Then
                            _line1 = arr(1)
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(12).Color(Color.FromArgb(181, 29, 44)).Bold()
                        ElseIf str1.StartsWith("pron") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(98, 153, 93)).Italic()
                        ElseIf str1.StartsWith("hyph") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(12).Color(Color.FromArgb(181, 29, 44)).Bold()

                        ElseIf str1.StartsWith("der") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(220, 71, 102))
                        ElseIf str1.StartsWith("etym") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(220, 71, 102))
                        ElseIf str1.StartsWith("subc") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(238, 170, 71)).Bold()
                        ElseIf str1.StartsWith("category") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(220, 71, 102))
                        ElseIf str1.StartsWith("def") Then
                            Dim ptArr() = arr(1).Split("§")

                            If ptArr.Count - 1 >= 0 Then
                                For Each w1 In ptArr
                                    If w1.StartsWith("{i}") Then
                                        w1 = Replace(w1, "{i}", "")
                                        If _breakline = True Then
                                            w1 = Replace(w1, "¶", vbCrLf)
                                        Else
                                            w1 = Replace(w1, "¶", " ")
                                        End If
                                        w1 = RemoveTag(w1)
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.Black).Italic()
                                    ElseIf w1.StartsWith("{b}") Then
                                        w1 = Replace(w1, "{b}", "")
                                        If _breakline = True Then
                                            w1 = Replace(w1, "¶", vbCrLf)
                                        Else
                                            w1 = Replace(w1, "¶", " ")
                                        End If
                                        w1 = RemoveTag(w1)
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.Black).Bold()
                                    ElseIf w1.StartsWith("{u}") Then
                                        w1 = Replace(w1, "{u}", "")
                                        If _breakline = True Then
                                            w1 = Replace(w1, "¶", vbCrLf)
                                        Else
                                            w1 = Replace(w1, "¶", " ")
                                        End If
                                        w1 = RemoveTag(w1)
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.Black).Bold()
                                    Else
                                        If _breakline = True Then
                                            w1 = Replace(w1, "¶", vbCrLf)
                                        Else
                                            w1 = Replace(w1, "¶", " ")
                                        End If
                                        w1 = RemoveTag(w1)
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.Black)
                                    End If
                                Next
                            Else
                                If _breakline = True Then
                                    p.AppendLine(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(0, 176, 240))
                                Else
                                    p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(0, 176, 240))
                                End If

                            End If

                        ElseIf str1.StartsWith("eg") Then
                            Dim ptArr() = arr(1).Split("§")
                            If ptArr.Count - 1 >= 0 Then
                                For Each w1 In ptArr
                                    w1 = RemoveTag(w1)
                                    If w1.StartsWith("{i}") Then
                                        w1 = Replace(w1, "{i}", "")
                                        If _breakline = True Then
                                            w1 = Replace(w1, "¶", vbCrLf)
                                        Else
                                            w1 = Replace(w1, "¶", " ")
                                        End If
                                        w1 = RemoveTag(w1)
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100)).Italic()
                                    ElseIf w1.StartsWith("{b}") Then
                                        w1 = Replace(w1, "{b}", "")
                                        If _breakline = True Then
                                            w1 = Replace(w1, "¶", vbCrLf)
                                        Else
                                            w1 = Replace(w1, "¶", " ")
                                        End If
                                        w1 = RemoveTag(w1)
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100)).Bold()
                                    ElseIf w1.StartsWith("{u}") Then
                                        w1 = Replace(w1, "{u}", "")
                                        If _breakline = True Then
                                            w1 = Replace(w1, "¶", vbCrLf)
                                        Else
                                            w1 = Replace(w1, "¶", " ")
                                        End If
                                        w1 = RemoveTag(w1)
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100)).Bold()
                                    Else
                                        If _breakline = True Then
                                            w1 = Replace(w1, "¶", vbCrLf)
                                        Else
                                            w1 = Replace(w1, "¶", " ")
                                        End If
                                        w1 = RemoveTag(w1)
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100))
                                    End If
                                Next
                            Else
                                p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100))
                            End If
                        ElseIf str1.StartsWith("trans") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(153, 153, 153)).Italic()
                        ElseIf str1.StartsWith("ref") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(9).Color(Color.FromArgb(190, 90, 20))
                        ElseIf str1.StartsWith("tittle") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(9).Color(Color.FromArgb(190, 90, 20))
                        ElseIf str1.StartsWith("info") Then
                            If _breakline = True Then
                                arr(1) = arr(1) & vbCrLf
                            End If
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(9).Color(Color.FromArgb(190, 90, 20))
                        End If
                    End If
                Next

                p = document.InsertParagraph()
                ' Save this document to disk.
            End While


            document.Save()

        End Using

        SQLcommand.Dispose()
        Process.Start(_saveto)
        'MsgBox("Finished!", MsgBoxStyle.Information)
    End Sub

    Public Sub ExportToDOCXBreakLine(_saveto As String, _option As Integer, _language As Integer)

        SQLcommand = SQLconnect.CreateCommand
        If _language = 0 Then 'ENGLISH
            If _option = -1 Then
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " ORDER BY word ASC"
            Else
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "' ORDER BY word ASC"
            End If
        ElseIf _language = 1 Then 'PALI
            If _option = -1 Then
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & "  ORDER BY CASE WHEN substr(word,1,1) = 'a' THEN 1 WHEN substr(word,1,1) = 'ā' THEN 2 WHEN substr(word,1,1) = 'b' THEN 3 WHEN substr(word,1,1) = 'c' THEN 4 WHEN substr(word,1,1) = 'd' THEN 5 WHEN substr(word,1,1) = 'ḍ' THEN 6 WHEN substr(word,1,1) = 'e' THEN 7 WHEN substr(word,1,1) = 'f' THEN 8 WHEN substr(word,1,1) = 'g' THEN 9 WHEN substr(word,1,1) = 'h' THEN 10 WHEN substr(word,1,1) = 'i' THEN 11 WHEN substr(word,1,1) = 'ī' THEN 12 WHEN substr(word,1,1) = 'j' THEN 13 WHEN substr(word,1,1) = 'k' THEN 14 WHEN substr(word,1,1) = 'l' THEN 15 WHEN substr(word,1,1) = 'm' THEN 16 WHEN substr(word,1,1) = 'n' THEN 17 WHEN substr(word,1,1) = 'ṅ' THEN 18 WHEN substr(word,1,1) = 'ñ' THEN 19 WHEN substr(word,1,1) = 'ṇ' THEN 20 WHEN substr(word,1,1) = 'o' THEN 21 WHEN substr(word,1,1) = 'p' THEN 22 WHEN substr(word,1,1) = 'q' THEN 23 WHEN substr(word,1,1) = 'r' THEN 24 WHEN substr(word,1,1) = 's' THEN 25 WHEN substr(word,1,1) = 't' THEN 26 WHEN substr(word,1,1) = 'ṭ' THEN 27 WHEN substr(word,1,1) = 'u' THEN 28 WHEN substr(word,1,1) = 'ū' THEN 29 WHEN substr(word,1,1) = 'v' THEN 30 WHEN substr(word,1,1) = 'w' THEN 31 WHEN substr(word,1,1) = 'x' THEN 32 WHEN substr(word,1,1) = 'y' THEN 33 WHEN substr(word,1,1) = 'z' THEN 34 END;"
            Else
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "'  ORDER BY CASE WHEN substr(word,1,1) = 'a' THEN 1 WHEN substr(word,1,1) = 'ā' THEN 2 WHEN substr(word,1,1) = 'b' THEN 3 WHEN substr(word,1,1) = 'c' THEN 4 WHEN substr(word,1,1) = 'd' THEN 5 WHEN substr(word,1,1) = 'ḍ' THEN 6 WHEN substr(word,1,1) = 'e' THEN 7 WHEN substr(word,1,1) = 'f' THEN 8 WHEN substr(word,1,1) = 'g' THEN 9 WHEN substr(word,1,1) = 'h' THEN 10 WHEN substr(word,1,1) = 'i' THEN 11 WHEN substr(word,1,1) = 'ī' THEN 12 WHEN substr(word,1,1) = 'j' THEN 13 WHEN substr(word,1,1) = 'k' THEN 14 WHEN substr(word,1,1) = 'l' THEN 15 WHEN substr(word,1,1) = 'm' THEN 16 WHEN substr(word,1,1) = 'n' THEN 17 WHEN substr(word,1,1) = 'ṅ' THEN 18 WHEN substr(word,1,1) = 'ñ' THEN 19 WHEN substr(word,1,1) = 'ṇ' THEN 20 WHEN substr(word,1,1) = 'o' THEN 21 WHEN substr(word,1,1) = 'p' THEN 22 WHEN substr(word,1,1) = 'q' THEN 23 WHEN substr(word,1,1) = 'r' THEN 24 WHEN substr(word,1,1) = 's' THEN 25 WHEN substr(word,1,1) = 't' THEN 26 WHEN substr(word,1,1) = 'ṭ' THEN 27 WHEN substr(word,1,1) = 'u' THEN 28 WHEN substr(word,1,1) = 'ū' THEN 29 WHEN substr(word,1,1) = 'v' THEN 30 WHEN substr(word,1,1) = 'w' THEN 31 WHEN substr(word,1,1) = 'x' THEN 32 WHEN substr(word,1,1) = 'y' THEN 33 WHEN substr(word,1,1) = 'z' THEN 34 END;"
            End If
        End If

        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        Dim indexChar As New Dictionary(Of Char, Char)

        Dim listtag As New Dictionary(Of String, String)

        listtag.Add("<b>", "§{b}")
        listtag.Add("</b>", "§")
        listtag.Add("<i>", "§{i}")
        listtag.Add("</i>", "§")
        listtag.Add("<u>", "§{u}")
        listtag.Add("</u>", "§")

        Using document As DocX = DocX.Create(_saveto)

            While SQLreader.Read()
                Dim _line As String
                Dim id As Object = SQLreader(0)
                Dim status As String = SQLreader(1)
                Dim word As String = SQLreader(2)

                Dim _textbox As New FastColoredTextBox
                Dim _line1 As String
                Dim _line2 As String
                _textbox.Text = SQLreader(3)

                _line1 = ""
                _line2 = ""
                Dim p As Paragraph

                Dim char1 As Char = word.Substring(0, 1).ToUpper
                If indexChar.ContainsKey(char1) = False Then
                    indexChar.Add(char1, "")
                    p = document.InsertParagraph()
                    p.Append(char1).Font(New FontFamily("Arial")).FontSize(18).Color(Color.Black).Bold()
                End If

                p = document.InsertParagraph()
                For i = 0 To _textbox.LinesCount - 1
                    Dim str1 As String = _textbox.GetLineText(i)
                    For Each w1 In listtag
                        str1 = Replace(str1, w1.Key, w1.Value)
                    Next
                    If str1 <> "" Then
                        Dim arr() = str1.Split("~")
                        arr(1) = arr(1) & " "
                        Dim str2 As String = arr(1)
                        If str1.StartsWith("word") Then
                            _line1 = arr(1)
                            p.AppendLine(arr(1)).Font(New FontFamily("Arial")).FontSize(12).Color(Color.FromArgb(181, 29, 44)).Bold()
                        ElseIf str1.StartsWith("pron") Then
                            p.AppendLine(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(98, 153, 93)).Italic()
                        ElseIf str1.StartsWith("hyph") Then
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(12).Color(Color.FromArgb(181, 29, 44)).Bold()
                        ElseIf str1.StartsWith("der") Then
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(220, 71, 102))
                        ElseIf str1.StartsWith("etym") Then
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(220, 71, 102))
                        ElseIf str1.StartsWith("subc") Then
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(238, 170, 71)).Bold()
                        ElseIf str1.StartsWith("category") Then
                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(220, 71, 102))
                        ElseIf str1.StartsWith("def") Then
                            Dim ptArr() = arr(1).Split("§")

                            If ptArr.Count - 1 >= 0 Then
                                For Each w1 In ptArr
                                    w1 = RemoveTag(w1)
                                    If w1.StartsWith("{i}") Then
                                        w1 = Replace(w1, "{i}", "")

                                        p.AppendLine(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.Black).Italic()
                                    ElseIf w1.StartsWith("{b}") Then
                                        w1 = Replace(w1, "{b}", "")
                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.Black).Bold()
                                    ElseIf w1.StartsWith("{u}") Then
                                        w1 = Replace(w1, "{u}", "")

                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.Black).Bold()
                                    Else

                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.Black)
                                    End If
                                Next
                            Else

                                p.AppendLine(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(0, 176, 240))


                            End If

                        ElseIf str1.StartsWith("eg") Then
                            Dim ptArr() = arr(1).Split("§")
                            If ptArr.Count - 1 >= 0 Then
                                For Each w1 In ptArr
                                    w1 = RemoveTag(w1)
                                    If w1.StartsWith("{i}") Then
                                        w1 = Replace(w1, "{i}", "")

                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100)).Italic()
                                    ElseIf w1.StartsWith("{b}") Then
                                        w1 = Replace(w1, "{b}", "")

                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100)).Bold()
                                    ElseIf w1.StartsWith("{u}") Then
                                        w1 = Replace(w1, "{u}", "")

                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100)).Bold()
                                    Else

                                        p.Append(w1).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100))
                                    End If
                                Next
                            Else
                                p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(100, 100, 100))
                            End If
                        ElseIf str1.StartsWith("trans") Then

                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(10).Color(Color.FromArgb(153, 153, 153)).Italic()
                        ElseIf str1.StartsWith("ref") Then

                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(9).Color(Color.FromArgb(190, 90, 20))
                        ElseIf str1.StartsWith("tittle") Then

                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(9).Color(Color.FromArgb(190, 90, 20))
                        ElseIf str1.StartsWith("info") Then

                            p.Append(arr(1)).Font(New FontFamily("Arial")).FontSize(9).Color(Color.FromArgb(190, 90, 20))
                        End If
                    End If
                Next


                p = document.InsertParagraph()
                ' Save this document to disk.
            End While


            document.Save()

        End Using

        SQLcommand.Dispose()
        'MsgBox("Finished!", MsgBoxStyle.Information)
    End Sub
    Public Sub ExportToHTML(cssCode As String, _saveto As String, _option As Integer, _language As Integer, _start As String)
        Dim sw As New StreamWriter(_saveto)
        Dim indexChar As New Dictionary(Of Char, Char)
        Dim strHTML(5) As String
        strHTML(0) = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>"
        strHTML(1) = "<html xmlns='http://www.w3.org/1999/xhtml'>"
        strHTML(2) = "<head><title>Tummo Dictionary</title><meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>"
        strHTML(4) = "</head><body>"

        sw.WriteLine(strHTML(0))
        sw.WriteLine(strHTML(1))
        sw.WriteLine(strHTML(2))
        sw.WriteLine(cssCode)
        sw.WriteLine(strHTML(4))

        Dim header() = FindCurrentProject()
        sw.WriteLine("<center><h3>" & header(1).ToUpper & "</h3></center>")
        sw.WriteLine("<center><h4>" & header(6) & "</h4></center>")
        sw.WriteLine("<center><h5>" & header(4) & " - " & header(5) & " - " & header(6) & "</h5></center>")
        sw.WriteLine("<hr>")

        SQLcommand = SQLconnect.CreateCommand
        If _language = 0 Then 'ENGLISH
            If _start = "-1" Then
                If _option = -1 Then
                    SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " ORDER BY word ASC"
                Else
                    SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "' ORDER BY word ASC"
                End If
            Else
                If _option = -1 Then
                    SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE substr(word,1,1) = '" & _start & "' ORDER BY word ASC"
                Else
                    SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE substr(word,1,1) = '" & _start & "' AND status = '" & _option & "' ORDER BY word ASC"
                End If
            End If

        ElseIf _language = 1 Then 'PALI
            If _option = -1 Then
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " ORDER BY CASE WHEN substr(word,1,1) = 'a' THEN 1 WHEN substr(word,1,1) = 'ā' THEN 2 WHEN substr(word,1,1) = 'b' THEN 3 WHEN substr(word,1,1) = 'c' THEN 4 WHEN substr(word,1,1) = 'd' THEN 5 WHEN substr(word,1,1) = 'ḍ' THEN 6 WHEN substr(word,1,1) = 'e' THEN 7 WHEN substr(word,1,1) = 'f' THEN 8 WHEN substr(word,1,1) = 'g' THEN 9 WHEN substr(word,1,1) = 'h' THEN 10 WHEN substr(word,1,1) = 'i' THEN 11 WHEN substr(word,1,1) = 'ī' THEN 12 WHEN substr(word,1,1) = 'j' THEN 13 WHEN substr(word,1,1) = 'k' THEN 14 WHEN substr(word,1,1) = 'l' THEN 15 WHEN substr(word,1,1) = 'm' THEN 16 WHEN substr(word,1,1) = 'n' THEN 17 WHEN substr(word,1,1) = 'ṅ' THEN 18 WHEN substr(word,1,1) = 'ñ' THEN 19 WHEN substr(word,1,1) = 'ṇ' THEN 20 WHEN substr(word,1,1) = 'o' THEN 21 WHEN substr(word,1,1) = 'p' THEN 22 WHEN substr(word,1,1) = 'q' THEN 23 WHEN substr(word,1,1) = 'r' THEN 24 WHEN substr(word,1,1) = 's' THEN 25 WHEN substr(word,1,1) = 't' THEN 26 WHEN substr(word,1,1) = 'ṭ' THEN 27 WHEN substr(word,1,1) = 'u' THEN 28 WHEN substr(word,1,1) = 'ū' THEN 29 WHEN substr(word,1,1) = 'v' THEN 30 WHEN substr(word,1,1) = 'w' THEN 31 WHEN substr(word,1,1) = 'x' THEN 32 WHEN substr(word,1,1) = 'y' THEN 33 WHEN substr(word,1,1) = 'z' THEN 34 END;"
            Else
                SQLcommand.CommandText = "SELECT * FROM " & mUniform.ProjectTable & " WHERE status = '" & _option & "'  ORDER BY CASE WHEN substr(word,1,1) = 'a' THEN 1 WHEN substr(word,1,1) = 'ā' THEN 2 WHEN substr(word,1,1) = 'b' THEN 3 WHEN substr(word,1,1) = 'c' THEN 4 WHEN substr(word,1,1) = 'd' THEN 5 WHEN substr(word,1,1) = 'ḍ' THEN 6 WHEN substr(word,1,1) = 'e' THEN 7 WHEN substr(word,1,1) = 'f' THEN 8 WHEN substr(word,1,1) = 'g' THEN 9 WHEN substr(word,1,1) = 'h' THEN 10 WHEN substr(word,1,1) = 'i' THEN 11 WHEN substr(word,1,1) = 'ī' THEN 12 WHEN substr(word,1,1) = 'j' THEN 13 WHEN substr(word,1,1) = 'k' THEN 14 WHEN substr(word,1,1) = 'l' THEN 15 WHEN substr(word,1,1) = 'm' THEN 16 WHEN substr(word,1,1) = 'n' THEN 17 WHEN substr(word,1,1) = 'ṅ' THEN 18 WHEN substr(word,1,1) = 'ñ' THEN 19 WHEN substr(word,1,1) = 'ṇ' THEN 20 WHEN substr(word,1,1) = 'o' THEN 21 WHEN substr(word,1,1) = 'p' THEN 22 WHEN substr(word,1,1) = 'q' THEN 23 WHEN substr(word,1,1) = 'r' THEN 24 WHEN substr(word,1,1) = 's' THEN 25 WHEN substr(word,1,1) = 't' THEN 26 WHEN substr(word,1,1) = 'ṭ' THEN 27 WHEN substr(word,1,1) = 'u' THEN 28 WHEN substr(word,1,1) = 'ū' THEN 29 WHEN substr(word,1,1) = 'v' THEN 30 WHEN substr(word,1,1) = 'w' THEN 31 WHEN substr(word,1,1) = 'x' THEN 32 WHEN substr(word,1,1) = 'y' THEN 33 WHEN substr(word,1,1) = 'z' THEN 34 END;"
            End If
        End If
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()

        Dim i As Integer = 0
        listProject = New List(Of String)
        '  Dim csscode = LoadStyle(cssStyle)
        'Dim StyleColor = ConvertStyleToHTML(csscode)
        Dim _result As String
        Dim _header As String
        While SQLreader.Read()
            Dim _line As String
            Dim id As Object = SQLreader(0)
            Dim status As String = SQLreader(1)
            Dim word As String = SQLreader(2)

            Dim _textbox As New FastColoredTextBox

            _textbox.Text = SQLreader(3)

            _line = ""
            Dim char1 As Char = word.Substring(0, 1).ToUpper
            If indexChar.ContainsKey(char1) = False Then
                indexChar.Add(char1, "")
                _line = _line & "<h3><a id='" & char1 & "'>" & char1 & "</a></h3><hr>"
                _header = _header & "<a href='#" & char1 & "'>" & char1 & "</a> &nbsp;&nbsp;"
            End If

            For i = 0 To _textbox.LinesCount - 1
                Dim str1 As String = _textbox.GetLineText(i)
                If str1 <> "" Then
                    Dim arr() = str1.Split("~")
                    If arr(0) = "table" Then
                        Dim _table As String = ExtractTable(arr(1))
                        _line = _line & _table & "<br>"
                    Else
                        If arr.Length - 1 >= 0 Then
                            Dim arr2() As String = arr(1).Split("¶")
                            If arr2.Count - 1 > 0 Then
                                For Each w1 In arr2
                                    Dim _tag11 As String = "<p id=" & Chr(34) & arr(0) & Chr(34) & ">" & w1 & "</p>"
                                    If i = 0 Then
                                        _line = _line & _tag11
                                    Else
                                        _line = _line & _tag11 & "<br>"
                                    End If

                                Next
                            Else
                                Dim _tag11 As String
                                If arr(0) = "word" Then
                                    Dim _tag12 As String
                                    _tag12 = "<a id=" & Chr(34) & arr(1) & Chr(34) & ">" & arr(1) & "</a>"
                                    _tag11 = "<p id=" & Chr(34) & arr(0) & Chr(34) & ">" & _tag12 & "</p>"
                                Else
                                    _tag11 = "<p id=" & Chr(34) & arr(0) & Chr(34) & ">" & arr(1) & "</p>"
                                End If

                                If i = 0 Then
                                    _line = _line & _tag11
                                Else
                                    _line = _line & _tag11 & "<br>"
                                End If
                            End If
                        End If
                    End If

                End If

                '  Dim _tag1 As String = "<p id=" & Chr(34) & arr(0) & Chr(34) & ">" & arr(1) & "</p>"
                '_line = _line & _tag1 & vbNewLine


            Next
            _result = _result & _line '& "</br>"

        End While

        sw.WriteLine(_header)
        sw.WriteLine("<hr>")
        sw.WriteLine(_result)
        sw.WriteLine("</body></html>")
        sw.Dispose()
        sw.Close()
        SQLcommand.Dispose()
        'MsgBox("Finished!", MsgBoxStyle.Information)
        Process.Start(_saveto)
    End Sub

    Public Function GetTextFromHTMLTag(_input As String, _tag As String) As String

        Dim match As Match = Regex.Match(_input, "<" & _tag & "\b[^>]*>(.*?)</" & _tag & ">")
        'Dim match As Match = Regex.Match(_input, "<.*?>(.*?)<.*?>")
        Dim _text As String = ""
        If match.Groups.Count = 2 Then
            ' For Each w1 In match.Groups(0).Captures
            ' For i = 0 To match.Groups.Count
            _text = match.Groups(0).Value
            'MsgBox(_text)
            ' Next

            'Next

            '<.*?>
        End If

        Return _text
    End Function

    Public Function ExtractTable(_code1 As String) As String
        'Dim _code1 As String = "{tittle}Table 1|3¶{header}Column 1|Column 2|Column 3¶{row}row1|row2|row3¶{row}row1|row2|row3¶{row}row1|row2|row3¶{row}row1|row2|row3"
        Dim result As String

        Dim arr() As String = _code1.Split("¶")
        result = "<center><table class='hovertable'>"
        For Each w1 In arr
            If w1.StartsWith("{tittle}") Then
                w1 = w1.Replace("{tittle}", String.Empty)
                Dim arr2() As String = w1.Split("|")
                result = result & "<tr><th colspan='" & arr2(1) & "'>" & arr2(0) & "</th></tr>" & vbNewLine
            ElseIf w1.StartsWith("{header}") Then
                w1 = w1.Replace("{header}", String.Empty)
                Dim arr2() As String = w1.Split("|")
                result = result & "<tr>"
                For Each w2 In arr2
                    result = result & "<th>" & w2 & "</th>"
                Next
                result = result & "</tr>"
            ElseIf w1.StartsWith("{row}") Then
                w1 = w1.Replace("{row}", String.Empty)
                Dim arr2() As String = w1.Split("|")
                result = result & "<tr>"
                For Each w2 In arr2
                    result = result & "<td>" & w2 & "</td>"
                Next
                result = result & "</tr>"
            End If
        Next
        result = result & "</table></center>"

        Return result
    End Function
End Class
Public Class DataAttributes
    Public _word As String
    Public _line As String
    Public _sub As String
    Public _category As String
    Public _ul As String
    Public _li As String
    Public _ol As String
    Public _text As String
    Public _note As String
End Class

Public Class EntryAtributes
    Public _status As String
    Public _word As String
    Public _content As String
End Class

Public Class StyleAttributes
    Public _type As String
    Public _text As String
End Class
