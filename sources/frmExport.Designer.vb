<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExport))
        Me.btPath = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkWeb = New System.Windows.Forms.RadioButton()
        Me.checkDOCX = New System.Windows.Forms.RadioButton()
        Me.checkTUMMO = New System.Windows.Forms.RadioButton()
        Me.checkLDF = New System.Windows.Forms.RadioButton()
        Me.checkCSV = New System.Windows.Forms.RadioButton()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btOK = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboLine = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSyle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkOptionIncomplete = New System.Windows.Forms.RadioButton()
        Me.checkOptionComplete = New System.Windows.Forms.RadioButton()
        Me.checkOptionAll = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstChar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btPath
        '
        Me.btPath.Location = New System.Drawing.Point(346, 347)
        Me.btPath.Name = "btPath"
        Me.btPath.Size = New System.Drawing.Size(84, 25)
        Me.btPath.TabIndex = 18
        Me.btPath.Text = "Save to..."
        Me.btPath.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.ForeColor = System.Drawing.Color.Brown
        Me.txtPath.Location = New System.Drawing.Point(47, 350)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(293, 20)
        Me.txtPath.TabIndex = 17
        Me.txtPath.Text = "C:\"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "File..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkWeb)
        Me.GroupBox1.Controls.Add(Me.checkDOCX)
        Me.GroupBox1.Controls.Add(Me.checkTUMMO)
        Me.GroupBox1.Controls.Add(Me.checkLDF)
        Me.GroupBox1.Controls.Add(Me.checkCSV)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 100)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File type"
        '
        'checkWeb
        '
        Me.checkWeb.AutoSize = True
        Me.checkWeb.Location = New System.Drawing.Point(157, 61)
        Me.checkWeb.Name = "checkWeb"
        Me.checkWeb.Size = New System.Drawing.Size(80, 17)
        Me.checkWeb.TabIndex = 4
        Me.checkWeb.TabStop = True
        Me.checkWeb.Text = "Web pages"
        Me.checkWeb.UseVisualStyleBackColor = True
        '
        'checkDOCX
        '
        Me.checkDOCX.AutoSize = True
        Me.checkDOCX.Location = New System.Drawing.Point(254, 61)
        Me.checkDOCX.Name = "checkDOCX"
        Me.checkDOCX.Size = New System.Drawing.Size(142, 17)
        Me.checkDOCX.TabIndex = 3
        Me.checkDOCX.TabStop = True
        Me.checkDOCX.Text = "Word Document (DOCX)"
        Me.checkDOCX.UseVisualStyleBackColor = True
        '
        'checkTUMMO
        '
        Me.checkTUMMO.AutoSize = True
        Me.checkTUMMO.Enabled = False
        Me.checkTUMMO.Location = New System.Drawing.Point(22, 61)
        Me.checkTUMMO.Name = "checkTUMMO"
        Me.checkTUMMO.Size = New System.Drawing.Size(116, 17)
        Me.checkTUMMO.TabIndex = 2
        Me.checkTUMMO.TabStop = True
        Me.checkTUMMO.Text = "TUMMO Dictionary"
        Me.checkTUMMO.UseVisualStyleBackColor = True
        '
        'checkLDF
        '
        Me.checkLDF.AutoSize = True
        Me.checkLDF.Location = New System.Drawing.Point(255, 26)
        Me.checkLDF.Name = "checkLDF"
        Me.checkLDF.Size = New System.Drawing.Size(141, 17)
        Me.checkLDF.TabIndex = 1
        Me.checkLDF.TabStop = True
        Me.checkLDF.Text = "Lingoes Dictionary (LDF)"
        Me.checkLDF.UseVisualStyleBackColor = True
        '
        'checkCSV
        '
        Me.checkCSV.AutoSize = True
        Me.checkCSV.Checked = True
        Me.checkCSV.Location = New System.Drawing.Point(22, 26)
        Me.checkCSV.Name = "checkCSV"
        Me.checkCSV.Size = New System.Drawing.Size(177, 17)
        Me.checkCSV.TabIndex = 0
        Me.checkCSV.TabStop = True
        Me.checkCSV.Text = "Comma Separated Values (CSV)"
        Me.checkCSV.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(355, 386)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 35)
        Me.btCancel.TabIndex = 21
        Me.btCancel.Text = "CANCEL"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(268, 386)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 35)
        Me.btOK.TabIndex = 20
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboLanguage)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboLine)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboSyle)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.checkOptionIncomplete)
        Me.GroupBox2.Controls.Add(Me.checkOptionComplete)
        Me.GroupBox2.Controls.Add(Me.checkOptionAll)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 158)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option"
        '
        'cboLanguage
        '
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Items.AddRange(New Object() {"English", "Pali"})
        Me.cboLanguage.Location = New System.Drawing.Point(80, 21)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(325, 21)
        Me.cboLanguage.TabIndex = 25
        Me.cboLanguage.Text = "English"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Language"
        '
        'cboLine
        '
        Me.cboLine.FormattingEnabled = True
        Me.cboLine.Items.AddRange(New Object() {"Inline", "Break"})
        Me.cboLine.Location = New System.Drawing.Point(80, 78)
        Me.cboLine.Name = "cboLine"
        Me.cboLine.Size = New System.Drawing.Size(324, 21)
        Me.cboLine.TabIndex = 6
        Me.cboLine.Text = "Inline"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lines"
        '
        'cboSyle
        '
        Me.cboSyle.FormattingEnabled = True
        Me.cboSyle.Location = New System.Drawing.Point(80, 49)
        Me.cboSyle.Name = "cboSyle"
        Me.cboSyle.Size = New System.Drawing.Size(325, 21)
        Me.cboSyle.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Style"
        '
        'checkOptionIncomplete
        '
        Me.checkOptionIncomplete.AutoSize = True
        Me.checkOptionIncomplete.Location = New System.Drawing.Point(256, 119)
        Me.checkOptionIncomplete.Name = "checkOptionIncomplete"
        Me.checkOptionIncomplete.Size = New System.Drawing.Size(107, 17)
        Me.checkOptionIncomplete.TabIndex = 2
        Me.checkOptionIncomplete.TabStop = True
        Me.checkOptionIncomplete.Text = "Incomplete signal"
        Me.checkOptionIncomplete.UseVisualStyleBackColor = True
        '
        'checkOptionComplete
        '
        Me.checkOptionComplete.AutoSize = True
        Me.checkOptionComplete.Location = New System.Drawing.Point(117, 119)
        Me.checkOptionComplete.Name = "checkOptionComplete"
        Me.checkOptionComplete.Size = New System.Drawing.Size(105, 17)
        Me.checkOptionComplete.TabIndex = 1
        Me.checkOptionComplete.TabStop = True
        Me.checkOptionComplete.Text = "Completed signal"
        Me.checkOptionComplete.UseVisualStyleBackColor = True
        '
        'checkOptionAll
        '
        Me.checkOptionAll.AutoSize = True
        Me.checkOptionAll.Checked = True
        Me.checkOptionAll.Location = New System.Drawing.Point(22, 119)
        Me.checkOptionAll.Name = "checkOptionAll"
        Me.checkOptionAll.Size = New System.Drawing.Size(70, 17)
        Me.checkOptionAll.TabIndex = 0
        Me.checkOptionAll.TabStop = True
        Me.checkOptionAll.Text = "All entries"
        Me.checkOptionAll.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFirstChar)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox3.Location = New System.Drawing.Point(8, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(422, 59)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sub string"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Start with char"
        '
        'txtFirstChar
        '
        Me.txtFirstChar.Location = New System.Drawing.Point(99, 23)
        Me.txtFirstChar.Name = "txtFirstChar"
        Me.txtFirstChar.Size = New System.Drawing.Size(302, 20)
        Me.txtFirstChar.TabIndex = 5
        '
        'frmExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 434)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btPath As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkLDF As RadioButton
    Friend WithEvents checkCSV As RadioButton
    Friend WithEvents checkDOCX As RadioButton
    Friend WithEvents checkTUMMO As RadioButton
    Friend WithEvents btCancel As Button
    Friend WithEvents btOK As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents checkOptionIncomplete As RadioButton
    Friend WithEvents checkOptionComplete As RadioButton
    Friend WithEvents checkOptionAll As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSyle As ComboBox
    Friend WithEvents checkWeb As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cboLine As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboLanguage As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstChar As TextBox
End Class
