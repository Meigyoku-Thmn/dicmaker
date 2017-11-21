Imports System
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections.Generic
Imports ComponentFactory.Krypton.Toolkit

Public Class frmMain
    Private _next As Integer = 1
    Private _rand As New Random()

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To 20
            listWord.Items.Add(CreateNewItem())
        Next


        ' Select the first entry
        listWord.SelectedIndex = 0

        gridAttributes.Rows.Add()
        gridAttributes.Item(1, 0).Value = "noun"
        gridAttributes.Rows.Add()
        gridAttributes.Item(1, 1).Value = "pl noun"
    End Sub

    Private Function CreateNewItem() As Object
        Dim item As New KryptonListItem()
        item.ShortText = "Word " '& (System.Math.Max(System.Threading.Interlocked.Increment(_next), _next - 1)).ToString()
        item.LongText = "transcription"
        item.Image = img16.Images(6)
        Return item
    End Function
End Class
