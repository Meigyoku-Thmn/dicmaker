Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite
Imports System.Text.Encoding

Public Class frmNewProject
    Dim newproject As New ProjectManager
    Public Event Finished(ByVal isFinished As Boolean)
    Private Sub frmNewProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btOK.Enabled = False
    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click

        Dim arr(8) As String

        arr(0) = txtTitle.Text.Replace("'", "''")
        arr(1) = ChangeTittle(txtTitle.Text)
        arr(2) = txtDescription.Text.Replace("'", "''")
        arr(3) = txtEmail.Text
        arr(4) = txtWebsite.Text
        arr(5) = txtCopyright.Text
        arr(6) = txtVersion.Text
        arr(7) = "1"

        If newproject.tableExits(arr(1)) = True Then
            arr(1) = ChangeTittle(txtTitle.Text)
        End If

        newproject.InsertProject(arr)
        ProjectCenter.LoadInfo()
        Dim rs As Boolean = newproject.CreateTable(arr(1))
        If rs = True Then
            mUniform.ProjectTable = arr(1)
            frmMDI.frmWordList.ImportWordList("", 0)
            frmMDI.Text = "Tummo Dictionary Maker [" & txtTitle.Text & "]"
            RaiseEvent Finished(True)
            Me.Close()
        Else
            MsgBox("Please! create your project again!")
        End If


    End Sub

    Private Function GetRamdom(ByVal min As Integer, ByVal max As Integer) As Integer
        Static Generator As System.Random = New System.Random
        Return Generator.Next(min, max)
    End Function

    Private Function ChangeTittle(tittle As String) As String

        tittle = tittle.Replace("-", String.Empty)
        tittle = tittle.Replace("'", String.Empty)

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
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click


        ' asciiString = asciiString.Replace("?", Random(1,))
        'MsgBox(result)
        Me.Close()
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        If txtTitle.Text <> "" And txtDescription.Text <> "" And txtAuthor.Text <> "" Then
            btOK.Enabled = True
        End If
    End Sub

    Private Sub txtDescription_Leave(sender As Object, e As EventArgs) Handles txtDescription.Leave
        If txtTitle.Text <> "" And txtDescription.Text <> "" And txtAuthor.Text <> "" Then
            btOK.Enabled = True
        End If
    End Sub

    Private Sub txtAuthor_Leave(sender As Object, e As EventArgs) Handles txtAuthor.Leave
        If txtTitle.Text <> "" And txtDescription.Text <> "" And txtAuthor.Text <> "" Then
            btOK.Enabled = True
        End If
    End Sub

    Private Sub txtWebsite_Leave(sender As Object, e As EventArgs) Handles txtWebsite.Leave
        If txtWebsite.Text = "" Then
            txtWebsite.Text = "http://"
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text = "" Then
            txtEmail.Text = "email:"
        End If
    End Sub

    Private Sub txtCopyright_Leave(sender As Object, e As EventArgs) Handles txtCopyright.Leave
        If txtCopyright.Text = "" Then
            txtCopyright.Text = "@ 2016"
        End If
    End Sub

    Private Sub txtVersion_Leave(sender As Object, e As EventArgs) Handles txtVersion.Leave
        If txtVersion.Text = "" Then
            txtVersion.Text = "1.0.1"
        End If
    End Sub
End Class