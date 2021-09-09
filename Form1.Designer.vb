<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.lblRatio = New System.Windows.Forms.Label()
        Me.optEncrypt = New System.Windows.Forms.RadioButton()
        Me.optDecrypt = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(71, 14)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(485, 113)
        Me.txtInput.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(71, 139)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(237, 20)
        Me.txtPassword.TabIndex = 1
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(71, 169)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(485, 156)
        Me.txtOutput.TabIndex = 5
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(12, 172)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 26)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "Output" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0)"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 136)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 26)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0)"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(12, 17)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(31, 26)
        Me.lblInput.TabIndex = 7
        Me.lblInput.Text = "Input" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0)"
        '
        'btnSwap
        '
        Me.btnSwap.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSwap.Location = New System.Drawing.Point(481, 133)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(75, 30)
        Me.btnSwap.TabIndex = 4
        Me.btnSwap.Text = "&Swap"
        Me.btnSwap.UseVisualStyleBackColor = True
        '
        'lblRatio
        '
        Me.lblRatio.AutoSize = True
        Me.lblRatio.Location = New System.Drawing.Point(12, 299)
        Me.lblRatio.Name = "lblRatio"
        Me.lblRatio.Size = New System.Drawing.Size(32, 26)
        Me.lblRatio.TabIndex = 8
        Me.lblRatio.Text = "Ratio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1)"
        '
        'optEncrypt
        '
        Me.optEncrypt.AutoSize = True
        Me.optEncrypt.Checked = True
        Me.optEncrypt.Location = New System.Drawing.Point(328, 140)
        Me.optEncrypt.Name = "optEncrypt"
        Me.optEncrypt.Size = New System.Drawing.Size(61, 17)
        Me.optEncrypt.TabIndex = 2
        Me.optEncrypt.TabStop = True
        Me.optEncrypt.Text = "&Encrypt"
        Me.optEncrypt.UseVisualStyleBackColor = True
        '
        'optDecrypt
        '
        Me.optDecrypt.AutoSize = True
        Me.optDecrypt.Location = New System.Drawing.Point(405, 140)
        Me.optDecrypt.Name = "optDecrypt"
        Me.optDecrypt.Size = New System.Drawing.Size(62, 17)
        Me.optDecrypt.TabIndex = 3
        Me.optDecrypt.Text = "&Decrypt"
        Me.optDecrypt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 337)
        Me.Controls.Add(Me.optDecrypt)
        Me.Controls.Add(Me.optEncrypt)
        Me.Controls.Add(Me.lblRatio)
        Me.Controls.Add(Me.btnSwap)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "AES Encrypter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents btnSwap As System.Windows.Forms.Button
    Friend WithEvents lblRatio As System.Windows.Forms.Label
    Friend WithEvents optEncrypt As System.Windows.Forms.RadioButton
    Friend WithEvents optDecrypt As System.Windows.Forms.RadioButton

End Class
