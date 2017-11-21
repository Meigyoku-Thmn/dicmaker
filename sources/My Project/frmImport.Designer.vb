Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImport
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImport))
        Me.btOK = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkIncomplete = New System.Windows.Forms.CheckBox()
        Me.checkDup = New System.Windows.Forms.CheckBox()
        Me.btSendBack = New System.Windows.Forms.Button()
        Me.btSendTo = New System.Windows.Forms.Button()
        Me.listTarget = New System.Windows.Forms.ListBox()
        Me.listSources = New System.Windows.Forms.ListBox()
        Me.txtQuote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSeparator = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btPath = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(250, 404)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 35)
        Me.btOK.TabIndex = 10
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(335, 404)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 35)
        Me.btCancel.TabIndex = 11
        Me.btCancel.Text = "CANCEL"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkIncomplete)
        Me.GroupBox1.Controls.Add(Me.checkDup)
        Me.GroupBox1.Controls.Add(Me.btSendBack)
        Me.GroupBox1.Controls.Add(Me.btSendTo)
        Me.GroupBox1.Controls.Add(Me.listTarget)
        Me.GroupBox1.Controls.Add(Me.listSources)
        Me.GroupBox1.Controls.Add(Me.txtQuote)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSeparator)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(15, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 341)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Multi-field options"
        '
        'checkIncomplete
        '
        Me.checkIncomplete.AutoSize = True
        Me.checkIncomplete.ForeColor = System.Drawing.Color.Maroon
        Me.checkIncomplete.Location = New System.Drawing.Point(19, 313)
        Me.checkIncomplete.Name = "checkIncomplete"
        Me.checkIncomplete.Size = New System.Drawing.Size(243, 20)
        Me.checkIncomplete.TabIndex = 17
        Me.checkIncomplete.Text = "Mark imported entries as incomplete"
        Me.checkIncomplete.UseVisualStyleBackColor = True
        '
        'checkDup
        '
        Me.checkDup.AutoSize = True
        Me.checkDup.Enabled = False
        Me.checkDup.ForeColor = System.Drawing.Color.DimGray
        Me.checkDup.Location = New System.Drawing.Point(19, 289)
        Me.checkDup.Name = "checkDup"
        Me.checkDup.Size = New System.Drawing.Size(405, 20)
        Me.checkDup.TabIndex = 16
        Me.checkDup.Text = "Always create new entries (i.e do not check if entry already exits)"
        Me.checkDup.UseVisualStyleBackColor = True
        '
        'btSendBack
        '
        Me.btSendBack.Image = CType(resources.GetObject("btSendBack.Image"), System.Drawing.Image)
        Me.btSendBack.Location = New System.Drawing.Point(269, 165)
        Me.btSendBack.Name = "btSendBack"
        Me.btSendBack.Size = New System.Drawing.Size(75, 35)
        Me.btSendBack.TabIndex = 15
        Me.btSendBack.UseVisualStyleBackColor = True
        '
        'btSendTo
        '
        Me.btSendTo.Image = CType(resources.GetObject("btSendTo.Image"), System.Drawing.Image)
        Me.btSendTo.Location = New System.Drawing.Point(269, 127)
        Me.btSendTo.Name = "btSendTo"
        Me.btSendTo.Size = New System.Drawing.Size(75, 35)
        Me.btSendTo.TabIndex = 14
        Me.btSendTo.UseVisualStyleBackColor = True
        '
        'listTarget
        '
        Me.listTarget.ForeColor = System.Drawing.Color.DarkOrange
        Me.listTarget.FormattingEnabled = True
        Me.listTarget.ItemHeight = 16
        Me.listTarget.Items.AddRange(New Object() {"Word"})
        Me.listTarget.Location = New System.Drawing.Point(351, 66)
        Me.listTarget.Name = "listTarget"
        Me.listTarget.Size = New System.Drawing.Size(243, 212)
        Me.listTarget.TabIndex = 13
        '
        'listSources
        '
        Me.listSources.ForeColor = System.Drawing.Color.ForestGreen
        Me.listSources.FormattingEnabled = True
        Me.listSources.ItemHeight = 16
        Me.listSources.Location = New System.Drawing.Point(19, 66)
        Me.listSources.Name = "listSources"
        Me.listSources.Size = New System.Drawing.Size(243, 212)
        Me.listSources.TabIndex = 12
        '
        'txtQuote
        '
        Me.txtQuote.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtQuote.Location = New System.Drawing.Point(426, 31)
        Me.txtQuote.Name = "txtQuote"
        Me.txtQuote.Size = New System.Drawing.Size(167, 22)
        Me.txtQuote.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label2.Location = New System.Drawing.Point(316, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Quote character"
        '
        'txtSeparator
        '
        Me.txtSeparator.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtSeparator.Location = New System.Drawing.Point(162, 31)
        Me.txtSeparator.Name = "txtSeparator"
        Me.txtSeparator.Size = New System.Drawing.Size(148, 22)
        Me.txtSeparator.TabIndex = 9
        Me.txtSeparator.Text = "|"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label1.Location = New System.Drawing.Point(19, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Field separator option"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "File..."
        '
        'txtPath
        '
        Me.txtPath.ForeColor = System.Drawing.Color.Brown
        Me.txtPath.Location = New System.Drawing.Point(57, 15)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(483, 22)
        Me.txtPath.TabIndex = 14
        Me.txtPath.Text = "C:\"
        '
        'btPath
        '
        Me.btPath.Location = New System.Drawing.Point(546, 14)
        Me.btPath.Name = "btPath"
        Me.btPath.Size = New System.Drawing.Size(84, 25)
        Me.btPath.TabIndex = 15
        Me.btPath.Text = "OPEN"
        Me.btPath.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 450)
        Me.Controls.Add(Me.btPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btOK)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import wordlist or CSV options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btOK As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkIncomplete As CheckBox
    Friend WithEvents checkDup As CheckBox
    Friend WithEvents btSendBack As Button
    Friend WithEvents btSendTo As Button
    Friend WithEvents listTarget As ListBox
    Friend WithEvents listSources As ListBox
    Friend WithEvents txtQuote As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSeparator As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btPath As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
