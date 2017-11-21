Imports System.IO
Imports FastColoredTextBoxNS
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class TummoPath
    Public Function CurrentPath() As String
        Dim result As String

        result = Directory.GetCurrentDirectory()

        Return result
    End Function

    Public Function PathOfDict() As String
        Dim result As String
        result = CurrentPath() & "\dict"

        Return result
    End Function

    Public Function PathOfStyle() As String
        Dim result As String
        result = CurrentPath() & "\style"

        Return result
    End Function
    Public Function PackageSource() As String
        Dim result As String
        result = CurrentPath() & "\dict\package"

        Return result
    End Function

    Public Function PathOfProject() As String
        Dim result As String
        result = CurrentPath() & "\project"

        Return result
    End Function

    Public Function PathOfFont() As String
        Dim result As String
        result = CurrentPath() & "\font"

        Return result
    End Function

    Public Function PathOfLookup() As String
        Dim result As String
        result = PathOfMyDocuments() & "\Tummo Spell 2016\dic\search"

        Return result
    End Function

    Public Function PackageTargetVietnamese() As String
        Dim result As String
        result = PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\Vietnamese"

        Return result
    End Function

    Public Function PackageTargetEnglish() As String
        Dim result As String
        result = PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\English"

        Return result
    End Function

    Public Function ConvertChinese() As String
        Dim result As String
        result = CurrentPath() & "\dic\convert\chinese"

        Return result
    End Function


    Public Function PackageTargetPali() As String
        Dim result As String
        result = PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\Pali"

        Return result
    End Function

    Public Function PackageTargetUser() As String
        Dim result As String
        result = PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\User"

        Return result
    End Function

    Public Function PathOfRecentINI() As String
        'Dim GetPath As DirectoryInfo
        Dim result As String
        result = PathOfMyDocuments() & "\Tummo Spell 2016\themes\recent.ini"

        Return result
    End Function

    Public Function PathOfTemp() As String
        'Dim GetPath As DirectoryInfo
        Dim result As String

        result = PathOfMyDocuments() & "\Tummo Spell 2016\temp"

        Return result
    End Function

    Public Shared Function PathOfMyDocuments() As String
        'Dim GetPath As DirectoryInfo
        Dim result As String

        result = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Return result
    End Function

    Public Sub CheckFolder()
        Dim SourcePath1 As String = CurrentPath() & "\dic"
        Dim SourcePath2 As String = CurrentPath() & "\font"
        Dim SourcePath3 As String = CurrentPath() & "\themes"
        Dim SourcePath4 As String = CurrentPath() & "\project"
        Dim SourcePath5 As String = CurrentPath() & "\temp"
        Dim TargetPath1 As String = PathOfMyDocuments() & "\Tummo Spell 2016\dic"
        Dim TargetPath2 As String = PathOfMyDocuments() & "\Tummo Spell 2016\dic\package"
        Dim TargetPath3 As String = PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\English"
        Dim TargetPath4 As String = PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\Vietnamese"
        Dim TargetPath5 As String = PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\Pali"
        'PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\English"
        Dim TargetPath6 As String = PathOfMyDocuments() & "\Tummo Spell 2016\font"
        Dim TargetPath7 As String = PathOfMyDocuments() & "\Tummo Spell 2016\themes"
        Dim TargetPath8 As String = PathOfMyDocuments() & "\Tummo Spell 2016\project"
        Dim TargetPath9 As String = PathOfMyDocuments() & "\Tummo Spell 2016\dic\convert"
        Dim TargetPath10 As String = PathOfMyDocuments() & "\Tummo Spell 2016\dic\convert\chinese"
        Dim TargetPath11 As String = PathOfMyDocuments() & "\Tummo Spell 2016\dic\Spelling\User"

        If (Not System.IO.Directory.Exists(TargetPath1)) Then
            System.IO.Directory.CreateDirectory(TargetPath1)
            System.IO.Directory.CreateDirectory(TargetPath2)
            System.IO.Directory.CreateDirectory(TargetPath3)
            System.IO.Directory.CreateDirectory(TargetPath4)
            System.IO.Directory.CreateDirectory(TargetPath5)
            System.IO.Directory.CreateDirectory(TargetPath6)
            System.IO.Directory.CreateDirectory(TargetPath7)
            System.IO.Directory.CreateDirectory(TargetPath8)
            System.IO.Directory.CreateDirectory(SourcePath5)
            System.IO.Directory.CreateDirectory(TargetPath9)
            System.IO.Directory.CreateDirectory(TargetPath10)
            System.IO.Directory.CreateDirectory(TargetPath11)
            My.Computer.FileSystem.CopyDirectory(SourcePath1, TargetPath1, True)
            My.Computer.FileSystem.CopyDirectory(SourcePath2, TargetPath6, True)
            My.Computer.FileSystem.CopyDirectory(SourcePath3, TargetPath7, True)
            My.Computer.FileSystem.CopyDirectory(SourcePath4, TargetPath8, True)
        End If

        'result = PathOfMyDocuments & "\Tummo Spell 2016" 
    End Sub

    Public Shared Function PathOfThemes() As String
        'Dim GetPath As DirectoryInfo
        Dim result As String

        result = PathOfMyDocuments() & "\Tummo Spell 2016\themes"

        Return result
    End Function



    Public Function PathOfExport() As String
        'Dim GetPath As DirectoryInfo
        Dim result As String

        result = PathOfMyDocuments() & "\Tummo Spell 2016\export"

        Return result
    End Function
End Class

Friend Class EllipseStyle
    Inherits Style

    Public Overrides Sub Draw(gr As Graphics, position As Point, range As Range)
        Dim size As Size = Style.GetSizeOfRange(range)
        Dim rect As Rectangle = New Rectangle(position, size)
        rect.Inflate(2, 2)

        Dim path As GraphicsPath = Style.GetRoundedRectangle(rect, 7)

        gr.DrawPath(Pens.Red, path)
    End Sub
End Class
