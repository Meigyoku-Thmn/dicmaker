Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite

Public Class ctrDictionary
    Dim SQLconnect As SQLiteConnection = New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    Dim Path As New TummoPath

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress


    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            MsgBox("Finish")
        End If
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""

        End If
    End Sub

    Private Sub contextDictionaries_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles contextDictionaries.ItemClicked
        'contextDictionaries.
    End Sub

    Private Sub LoadMenu()
        SQLconnect.ConnectionString = "Data Source=" & Path.PathOfDict & "\tummodic.db;"
        SQLconnect.Open()

        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM info_dictionary"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        Dim tittle As String
        Dim used As Integer
        While SQLreader.Read()
            tittle = SQLreader(1).ToString
            used = SQLreader(6)
            'If used = 1 Then
            contextDictionaries.Items.Add(tittle)
            ' End If
        End While
    End Sub
End Class
