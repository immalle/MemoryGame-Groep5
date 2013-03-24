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
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.txtGraad = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(94, 181)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(100, 22)
        Me.txtNaam.TabIndex = 0
        '
        'txtGraad
        '
        Me.txtGraad.Location = New System.Drawing.Point(434, 181)
        Me.txtGraad.Name = "txtGraad"
        Me.txtGraad.Size = New System.Drawing.Size(100, 22)
        Me.txtGraad.TabIndex = 1
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(251, 181)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 22)
        Me.txtScore.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 93)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmHighscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtGraad)
        Me.Controls.Add(Me.txtNaam)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHighscore"
        Me.Text = "Highscore!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNaam As System.Windows.Forms.TextBox
    Friend WithEvents txtGraad As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
