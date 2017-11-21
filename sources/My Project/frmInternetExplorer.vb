Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports WeifenLuo.WinFormsUI.Docking
Partial Public Class frmInternetExplorer
    Inherits DockContent
    Dim listHistory As New List(Of String)
    Dim currentRow As Integer
    Private Sub frmInternetExplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.txtAddress.Width = Me.Width - 100
    End Sub

    Private Sub txtAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtAddress.Text <> "" Then

                If txtAddress.Text.StartsWith("http://") = False Then
                    txtAddress.Text = "http://" & txtAddress.Text
                End If
                WebBrowser1.Url = New System.Uri(txtAddress.Text, System.UriKind.Absolute)
                listHistory.Add(txtAddress.Text)
                currentRow = currentRow + 1
            End If
        End If
    End Sub

    Private Sub btBegining_Click(sender As Object, e As EventArgs)
        currentRow = 0
        Dim addr As String = listHistory.Item(0)
        txtAddress.Text = addr
        WebBrowser1.Url = New System.Uri(txtAddress.Text, System.UriKind.Absolute)


    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs)
        currentRow = listHistory.Count - 1
        Dim addr As String = listHistory.Item(currentRow)
        txtAddress.Text = addr
        WebBrowser1.Url = New System.Uri(txtAddress.Text, System.UriKind.Absolute)
    End Sub

    Private Sub btUpward_Click(sender As Object, e As EventArgs) Handles btUpward.Click
        If currentRow >= 1 Then
            currentRow = currentRow - 1
            Dim addr As String = listHistory.Item(currentRow)
            txtAddress.Text = addr
            WebBrowser1.Url = New System.Uri(txtAddress.Text, System.UriKind.Absolute)
        End If


    End Sub

    Private Sub btDownward_Click(sender As Object, e As EventArgs) Handles btDownward.Click
        If currentRow < listHistory.Count - 1 Then
            currentRow = currentRow + 1
            Dim addr As String = listHistory.Item(currentRow)
            txtAddress.Text = addr
            WebBrowser1.Url = New System.Uri(txtAddress.Text, System.UriKind.Absolute)
        End If
    End Sub

    Private Sub btGo_Click(sender As Object, e As EventArgs) Handles btGo.Click
        If txtAddress.Text <> "" Then

            If txtAddress.Text.StartsWith("http://") = False Then
                txtAddress.Text = "http://" & txtAddress.Text
            End If
            WebBrowser1.Url = New System.Uri(txtAddress.Text, System.UriKind.Absolute)
            listHistory.Add(txtAddress.Text)
            currentRow = currentRow + 1
        End If
    End Sub

    Private Sub btOpen_Click(sender As Object, e As EventArgs) Handles btOpen.Click
        OpenFileDialog1.Filter = "Html Documents *.html|*.html|*.htm|*.htm|*.mhtml|*.mhtml"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fullpath As String = OpenFileDialog1.FileName

            txtAddress.Text = fullpath
            WebBrowser1.Url = New System.Uri(txtAddress.Text, System.UriKind.Absolute)
            listHistory.Add(txtAddress.Text)
            currentRow = currentRow + 1

        End If
    End Sub
End Class