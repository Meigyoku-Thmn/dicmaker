Imports WeifenLuo.WinFormsUI.Docking
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Diagnostics
Imports DW.RtfWriter
Imports FastColoredTextBoxNS
Imports System.Text.RegularExpressions
Imports GDF
Imports Properties
Imports RTF
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Partial Public Class frmWebView
    Inherits DockContent

    Dim path1 As New TummoPath
    Dim filename As String
    Dim _tempTextbox As New FastColoredTextBox
    Public RTFText As String
    Dim _projectManager As New ProjectManager

    Public Function RemoveTag(_word As String) As String
        Return Regex.Replace(_word, "<.*?>", "")
    End Function
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        ' Dim sb As RTFBuilderbase = New RTFBuilder()

        '  BuilderCode(sb)

        'Me.rtbView.Rtf = sb.ToString()
    End Sub




    Private Function FindIndex(line As String, word As String) As Integer
        If line <> "" Then
            Return line.IndexOf(word)
        Else
            Return -1
        End If
    End Function
    Private Sub frmWebView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMode.SelectedIndexChanged
        mUniform.StyleCSS = cboMode.Text
    End Sub
End Class

