<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpel))
        Me.lblTweeAfbeeldingen = New System.Windows.Forms.Label()
        Me.TijdAfbTonenNietGelijk = New System.Windows.Forms.Timer(Me.components)
        Me.TijdAfbTonenGelijk = New System.Windows.Forms.Timer(Me.components)
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblAantalParen = New System.Windows.Forms.Label()
        Me.lblNodigeParen = New System.Windows.Forms.Label()
        Me.lblTijdbezig = New System.Windows.Forms.Label()
        Me.TijdBezig = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.TijdAllesZien = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTweeAfbeeldingen
        '
        Me.lblTweeAfbeeldingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTweeAfbeeldingen.ForeColor = System.Drawing.Color.White
        Me.lblTweeAfbeeldingen.Location = New System.Drawing.Point(25, 389)
        Me.lblTweeAfbeeldingen.Name = "lblTweeAfbeeldingen"
        Me.lblTweeAfbeeldingen.Size = New System.Drawing.Size(159, 44)
        Me.lblTweeAfbeeldingen.TabIndex = 1
        Me.lblTweeAfbeeldingen.Text = "Label twee paren"
        '
        'TijdAfbTonenNietGelijk
        '
        Me.TijdAfbTonenNietGelijk.Interval = 500
        '
        'TijdAfbTonenGelijk
        '
        Me.TijdAfbTonenGelijk.Interval = 500
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(12, 156)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(101, 50)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'lblAantalParen
        '
        Me.lblAantalParen.AutoSize = True
        Me.lblAantalParen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAantalParen.ForeColor = System.Drawing.Color.White
        Me.lblAantalParen.Location = New System.Drawing.Point(8, 231)
        Me.lblAantalParen.Name = "lblAantalParen"
        Me.lblAantalParen.Size = New System.Drawing.Size(101, 20)
        Me.lblAantalParen.TabIndex = 3
        Me.lblAantalParen.Text = "aantal paren"
        '
        'lblNodigeParen
        '
        Me.lblNodigeParen.AutoSize = True
        Me.lblNodigeParen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNodigeParen.ForeColor = System.Drawing.Color.White
        Me.lblNodigeParen.Location = New System.Drawing.Point(155, 246)
        Me.lblNodigeParen.Name = "lblNodigeParen"
        Me.lblNodigeParen.Size = New System.Drawing.Size(105, 20)
        Me.lblNodigeParen.TabIndex = 4
        Me.lblNodigeParen.Text = "nodige paren"
        '
        'lblTijdbezig
        '
        Me.lblTijdbezig.AutoSize = True
        Me.lblTijdbezig.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTijdbezig.ForeColor = System.Drawing.Color.White
        Me.lblTijdbezig.Location = New System.Drawing.Point(119, 288)
        Me.lblTijdbezig.Name = "lblTijdbezig"
        Me.lblTijdbezig.Size = New System.Drawing.Size(77, 20)
        Me.lblTijdbezig.TabIndex = 5
        Me.lblTijdbezig.Text = "Label tijd"
        '
        'TijdBezig
        '
        Me.TijdBezig.Interval = 1000
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(15, 322)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(97, 20)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "Label score"
        '
        'TijdAllesZien
        '
        '
        'frmSpel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 882)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTijdbezig)
        Me.Controls.Add(Me.lblNodigeParen)
        Me.Controls.Add(Me.lblAantalParen)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblTweeAfbeeldingen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSpel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTweeAfbeeldingen As System.Windows.Forms.Label
    Friend WithEvents TijdAfbTonenNietGelijk As System.Windows.Forms.Timer
    Friend WithEvents TijdAfbTonenGelijk As System.Windows.Forms.Timer
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents lblAantalParen As System.Windows.Forms.Label
    Friend WithEvents lblNodigeParen As System.Windows.Forms.Label
    Friend WithEvents lblTijdbezig As System.Windows.Forms.Label
    Friend WithEvents TijdBezig As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents TijdAllesZien As System.Windows.Forms.Timer

End Class
