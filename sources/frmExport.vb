Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization

Public Class frmExport
    Dim _projectManager As New ProjectManager
    Dim _filename As String
    Dim _option As Integer
    Dim _fileType As Integer
    Dim _css As String
    Dim _breakline As Boolean = False
    Dim _language As Integer = 0
    Dim _start As String = "-1"

    Private Sub btPath_Click(sender As Object, e As EventArgs) Handles btPath.Click
        ' mUniform.ProjectTable = "new_table"
        If _fileType = 0 Then
            SaveFileDialog1.DefaultExt = "*.CSV"
            SaveFileDialog1.Filter = "CSV Files|*.csv"
        ElseIf _fileType = 1 Then
            SaveFileDialog1.DefaultExt = "*.LDF"
            SaveFileDialog1.Filter = "LDF Lingoes Dictionary|*.ldf"
        ElseIf _fileType = 2 Then
            SaveFileDialog1.DefaultExt = "*.TUM"
            SaveFileDialog1.Filter = "Tummo Dictionary|*.tum"
        ElseIf _fileType = 3 Then
            SaveFileDialog1.DefaultExt = "*.HTML"
            SaveFileDialog1.Filter = "HTML Web pages|*.html"
        ElseIf _fileType = 4 Then
            SaveFileDialog1.DefaultExt = "*.DOCX"
            SaveFileDialog1.Filter = "DOCX Files|*.docx"
        End If

        SaveFileDialog1.CreatePrompt = True
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            _filename = SaveFileDialog1.FileName
            txtPath.Text = _filename
            btOK.Enabled = True
        End If
    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        If cboLine.Text = "Break" Then
            _breakline = True
        End If

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub frmExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mUniform.ProjectTable = "new_table"
        _projectManager.ToCombobox("Style", "Tittle", cboSyle)
        cboSyle.SelectedIndex = 0
        _option = -1
        btOK.Enabled = False
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    Private Sub checkOptionAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkOptionAll.CheckedChanged
        If checkOptionAll.Checked = True Then
            _option = -1
        End If
    End Sub

    Private Sub checkOptionComplete_CheckedChanged(sender As Object, e As EventArgs) Handles checkOptionComplete.CheckedChanged
        If checkOptionComplete.Checked = True Then
            _option = 1
        End If
    End Sub

    Private Sub checkOptionIncomplete_CheckedChanged(sender As Object, e As EventArgs) Handles checkOptionIncomplete.CheckedChanged
        If checkOptionIncomplete.Checked = True Then
            _option = 0
        End If
    End Sub

    Private Sub checkCSV_CheckedChanged(sender As Object, e As EventArgs) Handles checkCSV.CheckedChanged
        If checkCSV.Checked = True Then
            _fileType = 0
            btOK.Enabled = False
        End If
    End Sub

    Private Sub checkLDF_CheckedChanged(sender As Object, e As EventArgs) Handles checkLDF.CheckedChanged
        If checkLDF.Checked = True Then
            _fileType = 1
            btOK.Enabled = False
        End If
    End Sub

    Private Sub checkWeb_CheckedChanged(sender As Object, e As EventArgs) Handles checkWeb.CheckedChanged
        If checkWeb.Checked = True Then
            _fileType = 3
            btOK.Enabled = False
        End If
    End Sub

    Private Sub checkDOCX_CheckedChanged(sender As Object, e As EventArgs) Handles checkDOCX.CheckedChanged
        If checkDOCX.Checked = True Then
            _fileType = 4
            btOK.Enabled = False
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If _fileType = 0 Then
            _projectManager.ExportToCSV(_filename, _option)
        ElseIf _fileType = 1 Then
            _projectManager.ExportToLDF(_filename, _option)
            ' MsgBox("Finished!", MsgBoxStyle.Information)
        ElseIf _fileType = 2 Then
            _projectManager.ExportToTummo(_filename, _option)
        ElseIf _fileType = 3 Then
            _projectManager.ExportToHTML(_css, _filename, _option, _language, _start)
            'MsgBox("Finished!", MsgBoxStyle.Information)
        ElseIf _fileType = 4 Then
            _projectManager.ExportToDOCX(_filename, _option, _breakline, _language, _start)
            ' MsgBox("Finished!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cboSyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSyle.SelectedIndexChanged
        _css = _projectManager.LoadStyle(cboSyle.Text)
    End Sub

    Private Sub checkTUMMO_CheckedChanged(sender As Object, e As EventArgs) Handles checkTUMMO.CheckedChanged
        If checkTUMMO.Checked = True Then
            _fileType = 2
            btOK.Enabled = False
        End If
    End Sub

    Private Sub cboLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLanguage.SelectedIndexChanged
        _language = cboLanguage.SelectedIndex
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtFirstChar_TextChanged(sender As Object, e As EventArgs) Handles txtFirstChar.TextChanged
        If txtFirstChar.Text <> "" Then
            _start = txtFirstChar.Text
        Else
            _start = -1
        End If
    End Sub

    Private Sub txtFirstChar_Leave(sender As Object, e As EventArgs) Handles txtFirstChar.Leave
        If txtFirstChar.Text.Length > 1 Then
            txtFirstChar.Text = Mid(txtFirstChar.Text, 1, 1)
        End If
    End Sub
End Class