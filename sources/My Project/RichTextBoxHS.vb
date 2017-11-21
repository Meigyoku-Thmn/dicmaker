Imports System.Drawing
Imports System.Text
Public Class RichTextBoxHS
    Inherits Windows.Forms.RichTextBox

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Public WriteOnly Property SelectionBackColor() As Color
        Set(ByVal Value As Color)
            'First, test SelectedText property NOT SelectedRTF property because
            '...SelectedRTF will never be nothing, it will always have at least
            '...the current default Font table
            If Me.SelectedText Is Nothing Then Exit Property
            Dim sb As New StringBuilder()           'use StringBuilder for speed and cleanliness
            Dim SelText As String = Me.SelectedRtf  'move to local string for speed
            Dim strTemp As String                   'used twice for ease of calculating internal coordinates
            Dim FontTableEnds As Integer            'end character of the rtf font table
            Dim ColorTableBegins As Integer         'beginning of the rtf color table
            Dim ColorTableEnds As Integer           'end of the rtf color table
            Dim StartLooking As Integer             'used to walk a string appending chunks
            Dim HighlightBlockStart As Integer      'used to find "\highlight#" block for stripping
            Dim HighlightBlockEnd As Integer        'used to find "\highlight#" block for stripping
            Dim cycl As Integer                     'used in For/Next loops
            Dim NewColorIndex As Integer = 0        'new color table index for incoming color
            'find the end of the font table
            FontTableEnds = InStr(1, SelText, "}}")
            'add the header and font table to the string accumulator
            sb.Append(Mid(SelText, 1, FontTableEnds + 1))
            'find the color table start
            ColorTableBegins = InStr(FontTableEnds, SelText, "{\colortbl")
            If ColorTableBegins = 0 Then 'no color table exists 
                'add a color table header
                sb.Append("{\colortbl ;")
                'no color table so for later use make the ColorTableEnd the same as FontTableEnds
                ColorTableEnds = FontTableEnds
                'default our new color table index to 1 since it will be the only one
                'remember Color table index 0 is reserved 
                NewColorIndex = 1
            Else 'a color table already exists
                'find the end of the color table
                ColorTableEnds = InStr(ColorTableBegins, SelText, "}")
                'backup one character so as to exclude the brace
                ColorTableEnds -= 1
                'need to count the quantity of semi;colons which will
                '... determine what color table index number our new color will be
                strTemp = Mid(SelText, FontTableEnds + 2, (ColorTableEnds - FontTableEnds) - 1)
                For cycl = 1 To strTemp.Length
                    If Mid(strTemp, cycl, 1) = ";" Then NewColorIndex += 1
                Next
                'append the color table without end brace
                sb.Append(strTemp)
            End If
            'append the color table entry for the highlight color
            sb.Append("\red" & Trim(Value.R.ToString))
            sb.Append("\green" & Trim(Value.G.ToString))
            sb.Append("\blue" & Trim(Value.B.ToString))
            'append the table entry terminator semi;colon
            sb.Append(";")
            'append the color table terminating brace
            sb.Append("}")
            'append the new highlight tag
            sb.Append("\highlight" & Trim(NewColorIndex.ToString))
            'Drop into a single string for easier manipulation
            strTemp = Mid(SelText, ColorTableEnds + 2, (SelText.Length - ColorTableEnds) - 1)
            'begin at first character
            StartLooking = 1
            'append everything remaining, but strip all remaing highlight tags
            Do
                'find a "\highlight" block
                HighlightBlockStart = InStr(StartLooking, strTemp, "\highlight")
                'if no "\highlight" block found
                If HighlightBlockStart = 0 Then
                    'append everything remaining
                    sb.Append(Mid(strTemp, StartLooking, strTemp.Length - StartLooking))
                    'we done appending
                    Exit Do
                End If
                'calculate the end of the word "highlight"
                HighlightBlockEnd = HighlightBlockStart + 9
                'accomodate color tables with over 9 colors and thus multi-digit color indexes
                'Plus, watch for (and discard) ONE space if it immediately follows the last digit
                Do
                    'keep stepping past end
                    HighlightBlockEnd += 1
                    'watch for (and discard) ONE space if it immediately follows the last digit
                    If Mid(strTemp, HighlightBlockEnd + 1, 1) = " " Then
                        HighlightBlockEnd += 1
                        Exit Do
                    End If
                    'looking for the first non-numeric character
                Loop While InStr(1, "0123456789", Mid(strTemp, HighlightBlockEnd + 1, 1))
                'append this block
                sb.Append(Mid(strTemp, StartLooking, (HighlightBlockStart - StartLooking)))
                'move the start forward past the last "\highlight#" block
                StartLooking = HighlightBlockEnd + 1
            Loop
            Me.SelectedRtf = sb.ToString
        End Set
    End Property
    Public Sub FindHighlight(ByVal SearchText As String, ByVal HighlightColor As Color, ByVal MatchCase As Boolean, ByVal WholeWords As Boolean)
        Me.SuspendLayout()
        Dim StartLooking As Integer = 0
        Dim FoundAt As Integer
        Dim SearchLength As Integer
        Dim RTBfinds As RichTextBoxFinds
        If SearchText Is Nothing Then Exit Sub
        Select Case True
            Case MatchCase And WholeWords
                RTBfinds = RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord
            Case MatchCase
                RTBfinds = RichTextBoxFinds.MatchCase
            Case WholeWords
                RTBfinds = RichTextBoxFinds.WholeWord
            Case Else
                RTBfinds = RichTextBoxFinds.None
        End Select
        SearchLength = SearchText.Length
        Do
            FoundAt = Me.Find(SearchText, StartLooking, RTBfinds)
            If FoundAt > -1 Then Me.SelectionBackColor = HighlightColor
            StartLooking = StartLooking + SearchLength
        Loop While FoundAt > -1
        Me.ResumeLayout()
    End Sub
    Public Sub BackColorSetWhole(ByVal BackColorDefault As Color)
        Me.SelectAll()
        Me.SelectionBackColor = BackColorDefault
    End Sub
End Class
