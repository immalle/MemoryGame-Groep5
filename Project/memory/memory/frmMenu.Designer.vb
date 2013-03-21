<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.gbGraden = New System.Windows.Forms.GroupBox()
        Me.rbMoeilijk = New System.Windows.Forms.RadioButton()
        Me.rbNormaal = New System.Windows.Forms.RadioButton()
        Me.rbGemakkelijk = New System.Windows.Forms.RadioButton()
        Me.btnHighscore = New System.Windows.Forms.Button()
        Me.gbGraden.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(300, 327)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(115, 47)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play!"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(9, 327)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(115, 47)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit!"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'gbGraden
        '
        Me.gbGraden.Controls.Add(Me.rbMoeilijk)
        Me.gbGraden.Controls.Add(Me.rbNormaal)
        Me.gbGraden.Controls.Add(Me.rbGemakkelijk)
        Me.gbGraden.Location = New System.Drawing.Point(265, 10)
        Me.gbGraden.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbGraden.Name = "gbGraden"
        Me.gbGraden.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbGraden.Size = New System.Drawing.Size(150, 182)
        Me.gbGraden.TabIndex = 2
        Me.gbGraden.TabStop = False
        Me.gbGraden.Text = "Moeilijkheidsgraad"
        '
        'rbMoeilijk
        '
        Me.rbMoeilijk.AutoSize = True
        Me.rbMoeilijk.Location = New System.Drawing.Point(4, 144)
        Me.rbMoeilijk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbMoeilijk.Name = "rbMoeilijk"
        Me.rbMoeilijk.Size = New System.Drawing.Size(45, 14)
        Me.rbMoeilijk.TabIndex = 2
        Me.rbMoeilijk.TabStop = True
        Me.rbMoeilijk.Text = "Moeilijk"
        Me.rbMoeilijk.UseVisualStyleBackColor = True
        '
        'rbNormaal
        '
        Me.rbNormaal.AutoSize = True
        Me.rbNormaal.Location = New System.Drawing.Point(4, 86)
        Me.rbNormaal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbNormaal.Name = "rbNormaal"
        Me.rbNormaal.Size = New System.Drawing.Size(48, 14)
        Me.rbNormaal.TabIndex = 1
        Me.rbNormaal.TabStop = True
        Me.rbNormaal.Text = "Normaal"
        Me.rbNormaal.UseVisualStyleBackColor = True
        '
        'rbGemakkelijk
        '
        Me.rbGemakkelijk.AutoSize = True
        Me.rbGemakkelijk.Location = New System.Drawing.Point(4, 34)
        Me.rbGemakkelijk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbGemakkelijk.Name = "rbGemakkelijk"
        Me.rbGemakkelijk.Size = New System.Drawing.Size(62, 14)
        Me.rbGemakkelijk.TabIndex = 0
        Me.rbGemakkelijk.TabStop = True
        Me.rbGemakkelijk.Text = "Gemakkelijk"
        Me.rbGemakkelijk.UseVisualStyleBackColor = True
        '
        'btnHighscore
        '
        Me.btnHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighscore.Location = New System.Drawing.Point(156, 327)
        Me.btnHighscore.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHighscore.Name = "btnHighscore"
        Me.btnHighscore.Size = New System.Drawing.Size(115, 47)
        Me.btnHighscore.TabIndex = 3
        Me.btnHighscore.Text = "Highscore!"
        Me.btnHighscore.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 384)
        Me.Controls.Add(Me.btnHighscore)
        Me.Controls.Add(Me.gbGraden)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPlay)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.gbGraden.ResumeLayout(False)
        Me.gbGraden.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents gbGraden As System.Windows.Forms.GroupBox
    Friend WithEvents rbMoeilijk As System.Windows.Forms.RadioButton
    Friend WithEvents rbNormaal As System.Windows.Forms.RadioButton
    Friend WithEvents rbGemakkelijk As System.Windows.Forms.RadioButton
    Friend WithEvents btnHighscore As System.Windows.Forms.Button
End Class
