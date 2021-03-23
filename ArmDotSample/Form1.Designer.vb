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
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonCheckPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(13, 13)
        Me.TextBoxPassword.Multiline = True
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(397, 148)
        Me.TextBoxPassword.TabIndex = 0
        '
        'ButtonCheckPassword
        '
        Me.ButtonCheckPassword.Location = New System.Drawing.Point(159, 167)
        Me.ButtonCheckPassword.Name = "ButtonCheckPassword"
        Me.ButtonCheckPassword.Size = New System.Drawing.Size(127, 23)
        Me.ButtonCheckPassword.TabIndex = 1
        Me.ButtonCheckPassword.Text = "Check password"
        Me.ButtonCheckPassword.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 201)
        Me.Controls.Add(Me.ButtonCheckPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonCheckPassword As Button
End Class
