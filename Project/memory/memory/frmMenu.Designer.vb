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
        Me.gbGraden = New System.Windows.Forms.GroupBox()
        Me.rbMoeilijk = New System.Windows.Forms.RadioButton()
        Me.rbNormaal = New System.Windows.Forms.RadioButton()
        Me.rbGemakkelijk = New System.Windows.Forms.RadioButton()
        Me.picBoxPlay = New System.Windows.Forms.PictureBox()
        Me.PicBoxQuit = New System.Windows.Forms.PictureBox()
        Me.picBoxHighscore = New System.Windows.Forms.PictureBox()
        Me.gbGraden.SuspendLayout()
        CType(Me.picBoxPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxHighscore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbGraden
        '
        Me.gbGraden.Controls.Add(Me.rbMoeilijk)
        Me.gbGraden.Controls.Add(Me.rbNormaal)
        Me.gbGraden.Controls.Add(Me.rbGemakkelijk)
        Me.gbGraden.Location = New System.Drawing.Point(12, 11)
        Me.gbGraden.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbGraden.Name = "gbGraden"
        Me.gbGraden.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbGraden.Size = New System.Drawing.Size(200, 224)
        Me.gbGraden.TabIndex = 2
        Me.gbGraden.TabStop = False
        Me.gbGraden.Text = "Moeilijkheidsgraad"
        '
        'rbMoeilijk
        '
        Me.rbMoeilijk.AutoSize = True
        Me.rbMoeilijk.Location = New System.Drawing.Point(5, 177)
        Me.rbMoeilijk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbMoeilijk.Name = "rbMoeilijk"
        Me.rbMoeilijk.Size = New System.Drawing.Size(75, 21)
        Me.rbMoeilijk.TabIndex = 2
        Me.rbMoeilijk.TabStop = True
        Me.rbMoeilijk.Text = "Moeilijk"
        Me.rbMoeilijk.UseVisualStyleBackColor = True
        '
        'rbNormaal
        '
        Me.rbNormaal.AutoSize = True
        Me.rbNormaal.Location = New System.Drawing.Point(5, 106)
        Me.rbNormaal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbNormaal.Name = "rbNormaal"
        Me.rbNormaal.Size = New System.Drawing.Size(82, 21)
        Me.rbNormaal.TabIndex = 1
        Me.rbNormaal.TabStop = True
        Me.rbNormaal.Text = "Normaal"
        Me.rbNormaal.UseVisualStyleBackColor = True
        '
        'rbGemakkelijk
        '
        Me.rbGemakkelijk.AutoSize = True
        Me.rbGemakkelijk.Location = New System.Drawing.Point(5, 42)
        Me.rbGemakkelijk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbGemakkelijk.Name = "rbGemakkelijk"
        Me.rbGemakkelijk.Size = New System.Drawing.Size(105, 21)
        Me.rbGemakkelijk.TabIndex = 0
        Me.rbGemakkelijk.TabStop = True
        Me.rbGemakkelijk.Text = "Gemakkelijk"
        Me.rbGemakkelijk.UseVisualStyleBackColor = True
        '
        'picBoxPlay
        '
        Me.picBoxPlay.Location = New System.Drawing.Point(330, 403)
        Me.picBoxPlay.Name = "picBoxPlay"
        Me.picBoxPlay.Size = New System.Drawing.Size(153, 58)
        Me.picBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxPlay.TabIndex = 4
        Me.picBoxPlay.TabStop = False
        '
        'PicBoxQuit
        '
        Me.PicBoxQuit.Location = New System.Drawing.Point(12, 403)
        Me.PicBoxQuit.Name = "PicBoxQuit"
        Me.PicBoxQuit.Size = New System.Drawing.Size(153, 58)
        Me.PicBoxQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxQuit.TabIndex = 5
        Me.PicBoxQuit.TabStop = False
        '
        'picBoxHighscore
        '
        Me.picBoxHighscore.Location = New System.Drawing.Point(171, 403)
        Me.picBoxHighscore.Name = "picBoxHighscore"
        Me.picBoxHighscore.Size = New System.Drawing.Size(153, 58)
        Me.picBoxHighscore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxHighscore.TabIndex = 6
        Me.picBoxHighscore.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 473)
        Me.Controls.Add(Me.picBoxHighscore)
        Me.Controls.Add(Me.PicBoxQuit)
        Me.Controls.Add(Me.picBoxPlay)
        Me.Controls.Add(Me.gbGraden)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.gbGraden.ResumeLayout(False)
        Me.gbGraden.PerformLayout()
        CType(Me.picBoxPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxQuit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxHighscore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbGraden As System.Windows.Forms.GroupBox
    Friend WithEvents rbMoeilijk As System.Windows.Forms.RadioButton
    Friend WithEvents rbNormaal As System.Windows.Forms.RadioButton
    Friend WithEvents rbGemakkelijk As System.Windows.Forms.RadioButton
    Friend WithEvents picBoxPlay As System.Windows.Forms.PictureBox
    Friend WithEvents PicBoxQuit As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxHighscore As System.Windows.Forms.PictureBox
End Class
