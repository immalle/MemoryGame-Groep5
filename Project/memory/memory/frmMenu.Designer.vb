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
        Me.txtPad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbGraden.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(400, 402)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(153, 58)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play!"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(12, 402)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(153, 58)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit!"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'gbGraden
        '
        Me.gbGraden.Controls.Add(Me.rbMoeilijk)
        Me.gbGraden.Controls.Add(Me.rbNormaal)
        Me.gbGraden.Controls.Add(Me.rbGemakkelijk)
        Me.gbGraden.Enabled = False
        Me.gbGraden.Location = New System.Drawing.Point(353, 12)
        Me.gbGraden.Name = "gbGraden"
        Me.gbGraden.Size = New System.Drawing.Size(200, 224)
        Me.gbGraden.TabIndex = 2
        Me.gbGraden.TabStop = False
        Me.gbGraden.Text = "Moeilijkheidsgraad"
        '
        'rbMoeilijk
        '
        Me.rbMoeilijk.AutoSize = True
        Me.rbMoeilijk.Location = New System.Drawing.Point(6, 177)
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
        Me.rbNormaal.Location = New System.Drawing.Point(6, 106)
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
        Me.rbGemakkelijk.Location = New System.Drawing.Point(6, 42)
        Me.rbGemakkelijk.Name = "rbGemakkelijk"
        Me.rbGemakkelijk.Size = New System.Drawing.Size(105, 21)
        Me.rbGemakkelijk.TabIndex = 0
        Me.rbGemakkelijk.TabStop = True
        Me.rbGemakkelijk.Text = "Gemakkelijk"
        Me.rbGemakkelijk.UseVisualStyleBackColor = True
        '
        'txtPad
        '
        Me.txtPad.Location = New System.Drawing.Point(12, 214)
        Me.txtPad.Name = "txtPad"
        Me.txtPad.Size = New System.Drawing.Size(335, 22)
        Me.txtPad.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Vul hieronder het pad in naar de afbeeldingen:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "tempKnop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 472)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPad)
        Me.Controls.Add(Me.gbGraden)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.gbGraden.ResumeLayout(False)
        Me.gbGraden.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents gbGraden As System.Windows.Forms.GroupBox
    Friend WithEvents rbMoeilijk As System.Windows.Forms.RadioButton
    Friend WithEvents rbNormaal As System.Windows.Forms.RadioButton
    Friend WithEvents rbGemakkelijk As System.Windows.Forms.RadioButton
    Friend WithEvents txtPad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
