<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighscore
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
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.rtxtScores = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(9, 320)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(472, 35)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'rtxtScores
        '
        Me.rtxtScores.Enabled = False
        Me.rtxtScores.Location = New System.Drawing.Point(12, 12)
        Me.rtxtScores.Name = "rtxtScores"
        Me.rtxtScores.Size = New System.Drawing.Size(466, 303)
        Me.rtxtScores.TabIndex = 5
        Me.rtxtScores.Text = ""
        '
        'frmHighscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 365)
        Me.Controls.Add(Me.rtxtScores)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "frmHighscore"
        Me.Text = "Highscore!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents rtxtScores As System.Windows.Forms.RichTextBox
End Class
