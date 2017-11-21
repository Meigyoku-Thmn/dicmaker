Public Class frmTable
    Private Sub frmTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _code1 As String = mUniform.TableCode

        If _code1 <> "" Then
            Dim result As String
            Dim columnCount As Object = Nothing
            Dim arr() As String = _code1.Split("¶")
            Dim _row As Integer = 0
            For Each w1 In arr
                If w1.StartsWith("{tittle}") Then
                    w1 = w1.Replace("{tittle}", String.Empty)
                    Dim arr2() As String = w1.Split("|")
                    columnCount = arr2(1)
                    listHeader.ColumnCount = columnCount
                    listRow.ColumnCount = columnCount
                    txtTittle.Text = arr2(0)
                ElseIf w1.StartsWith("{header}") Then
                    w1 = w1.Replace("{header}", String.Empty)
                    Dim arr2() As String = w1.Split("|")
                    Dim nWidth As Integer = (Me.Width / columnCount) - 20
                    For i = 0 To arr2.Length - 1
                        listHeader.Columns(i).Name = arr2(i)
                        listHeader.Columns(i).Width = nWidth
                        listRow.Columns(i).Name = arr2(i)
                        listRow.Columns(i).Width = nWidth
                    Next

                    listHeader.Rows.Add()

                    For i = 0 To arr2.Length - 1
                        listHeader.Item(i, 0).Value = arr2(i)
                    Next
                ElseIf w1.StartsWith("{row}") Then
                    w1 = w1.Replace("{row}", String.Empty)
                    Dim arr2() As String = w1.Split("|")
                    listRow.Rows.Add()
                    For i = 0 To arr2.Length - 1

                        listRow.Item(i, _row).Value = arr2(i)
                    Next
                    _row = _row + 1
                End If

            Next
        End If

    End Sub

    Private Function BuildCode() As String
        Dim columnCount As Integer = listHeader.ColumnCount
        ' Dim _code1 As String = "{tittle}Table 1|3¶{header}Column 1|Column 2|Column 3¶{row}row1|row2|row3¶{row}row1|row2|row3¶{row}row1|row2|row3¶{row}row1|row2|row3"
        Dim _line As String

        _line = "{tittle}" & txtTittle.Text & "|" & columnCount & "¶"
        Dim header As String = ""
        Dim isHeader As Boolean = False
        For i = 0 To columnCount - 1

            If listHeader.Item(i, 0).Value <> "" Then
                header = header & listHeader.Item(i, 0).Value & "|"
                isHeader = True
            End If

        Next

        If isHeader = True Then
            header = header.Substring(0, header.Length - 1)
            _line = _line & "{header}" & header & "¶"
        End If

        For i = 0 To listRow.RowCount - 1
            If listRow.Item(0, i).Value <> "" Then
                Dim row1 As String = ""
                For j = 0 To columnCount - 1
                    row1 = row1 & listRow.Item(j, i).Value & "|"
                Next
                row1 = "{row}" & row1.Substring(0, row1.Length - 1) & "¶"
                _line = _line & row1
            End If
        Next
        _line = _line.Substring(0, _line.Length - 1)
        Return _line
    End Function

    Private Sub btColumn_Click(sender As Object, e As EventArgs) Handles btColumn.Click
        Dim columnCount As Integer = listHeader.ColumnCount
        listHeader.ColumnCount = columnCount + 1
        listRow.ColumnCount = columnCount + 1
        If listHeader.ColumnCount = 1 Then
            listHeader.Rows.Add()
            listHeader.Item(0, 0).Value = "Header 1"
        End If
        Dim nWidth As Integer = (Me.Width / (columnCount + 1)) - 10
        For i = 0 To listHeader.ColumnCount - 1
            listHeader.Columns(i).Width = nWidth
            listRow.Columns(i).Width = nWidth
        Next

        'listHeader.Columns(columnCount + 1).Name = "Column " & columnCount + 1
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        listHeader.ColumnCount = 1
        listHeader.Rows.Add()
        listHeader.Item(0, 0).Value = "Header 1"
        listRow.ColumnCount = 1
        listRow.Rows.Clear()

    End Sub

    Private Sub btMulti_Click(sender As Object, e As EventArgs) Handles btMulti.Click
        Dim columnCount As Integer = listHeader.ColumnCount
        Dim newNums As Object = cboNum.Text
        listHeader.ColumnCount = columnCount + newNums
        listRow.ColumnCount = columnCount + newNums
        Dim nWidth As Integer = (Me.Width / (columnCount + newNums)) - 10
        For i = 0 To listHeader.ColumnCount - 1
            listHeader.Columns(i).Width = nWidth
            listRow.Columns(i).Width = nWidth
        Next
        listHeader.Rows.Add()
    End Sub

    Private Sub btApcept_Click(sender As Object, e As EventArgs) Handles btApcept.Click
        'MsgBox(BuildCode)
        frmMDI.frmInput.txtCode.Text = BuildCode()
    End Sub
End Class