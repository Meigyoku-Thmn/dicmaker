Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite

Public Class frmIndex
    Dim _projectManager As New ProjectManager
    Dim _idGroup As String
    Dim _indexGroup As New Dictionary(Of Integer, String)
    Dim _value As String
    Dim _code1 As String
    Dim _idRow As String
    Dim _tittle As String
    Dim _newrowStart As Integer = 0
    Private Sub frmIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _indexGroup = _projectManager.ToAttributesGroup2("AttributesGroup", cboGroup, "group", "id")
        cboGroup.SelectedIndex = 0
        'cboGroup.Text = 
    End Sub

    Private Function GetIndexOfVale(_value As String) As Integer
        Dim _index2 As Integer = 0
        For Each w1 In _indexGroup

            If _value = w1.Value Then
                _index2 = w1.Key
            End If
        Next
        Return _index2
    End Function

    Private Sub cboGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroup.SelectedIndexChanged
        If cboGroup.Items.Count - 1 >= 0 Then
            _idGroup = GetIndexOfVale(cboGroup.Text)
            ' MsgBox(_idGroup)
            _projectManager.ToAttributes2(_idGroup, listGroup)
        End If

    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs)
        _projectManager.DeleteRow("Attributes", "tittle", _value)
        _projectManager.ToAttributes2(_idGroup, listGroup)
    End Sub

    Private Sub listGroup_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles listGroup.UserAddedRow
        '_newrowStart = e.Row.Index
    End Sub

    Private Sub btNewAttributes_Click(sender As Object, e As EventArgs) Handles btNewAttributes.Click
        Dim frmAddAtrributes As New frmAddNewAttributes
        mUniform.AndNewAtributesMode = 2
        frmAddAtrributes.Show()

    End Sub

    Private Sub btNewGroup_Click(sender As Object, e As EventArgs) Handles btNewGroup.Click
        Dim frmAddAtrributes As New frmAddNewAttributes
        mUniform.AndNewAtributesMode = 1
        frmAddAtrributes.Show()

    End Sub

    Private Sub btDeleteGroup_Click(sender As Object, e As EventArgs) Handles btDeleteGroup.Click
        Dim asked = MsgBox("Are you sure delete group '" & cboGroup.Text & "'", MsgBoxStyle.YesNo, "Delete")
        If asked = MsgBoxResult.Yes Then
            _projectManager.DeleteRow("AttributesGroup", "id", _idGroup.ToString)
            _projectManager.DeleteRow("Attributes", "idgroup", _idGroup.ToString)
            cboGroup.Items.Clear()
            _indexGroup = _projectManager.ToAttributesGroup2("AttributesGroup", cboGroup, "group", "id")
            cboGroup.SelectedIndex = 0
            _projectManager.ToAttributes2(_idGroup, listGroup)
        End If

    End Sub

    Private Sub btDeleteItems_Click(sender As Object, e As EventArgs) Handles btDeleteItems.Click
        If _tittle <> "" Then
            Dim asked = MsgBox("Are you sure delete item '" & _tittle & "'", MsgBoxStyle.YesNo, "Delete")
            If asked = MsgBoxResult.Yes Then
                _projectManager.DeleteRow("Attributes", "id", _idRow)
                _projectManager.ToAttributes2(_idGroup, listGroup)
                _tittle = ""
            End If
        End If

    End Sub

    Private Sub listGroup_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles listGroup.CellEnter
        _idRow = listGroup.Item(0, e.RowIndex).Value
        _tittle = listGroup.Item(1, e.RowIndex).Value
    End Sub

    Public Sub ShowGrid()
        _projectManager.ToAttributes2(_idGroup, listGroup)
    End Sub

    Public Sub ShowCombo()
        cboGroup.Items.Clear()
        _indexGroup = _projectManager.ToAttributesGroup2("AttributesGroup", cboGroup, "group", "id")
        cboGroup.SelectedIndex = 0
    End Sub
End Class