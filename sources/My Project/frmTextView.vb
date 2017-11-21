Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite
Imports WeifenLuo.WinFormsUI.Docking
Partial Public Class frmTextView
    Inherits DockContent
    Private Sub mnOpen_Click(sender As Object, e As EventArgs) Handles mnOpen.Click
        OpenFileDialog1.Filter = "CSV Documents *.csv|*.csv|*.txt|*.txt"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fullpath As String = OpenFileDialog1.FileName

            txtCode.Text = File.ReadAllText(fullpath)
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtCode.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtCode.Copy()
    End Sub

    Private Sub PastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastToolStripMenuItem.Click
        txtCode.Paste()
    End Sub

    Private Sub FindAndReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindAndReplaceToolStripMenuItem.Click
        txtCode.ShowFindDialog()
    End Sub
End Class