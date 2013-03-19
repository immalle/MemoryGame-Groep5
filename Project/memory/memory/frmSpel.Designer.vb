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
        Me.SuspendLayout()
        '
        'lblTweeAfbeeldingen
        '
        Me.lblTweeAfbeeldingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTweeAfbeeldingen.Location = New System.Drawing.Point(119, 682)
        Me.lblTweeAfbeeldingen.Name = "lblTweeAfbeeldingen"
        Me.lblTweeAfbeeldingen.Size = New System.Drawing.Size(159, 44)
        Me.lblTweeAfbeeldingen.TabIndex = 1
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
        Me.btnMenu.Location = New System.Drawing.Point(421, 676)
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
        Me.lblAantalParen.Location = New System.Drawing.Point(158, 662)
        Me.lblAantalParen.Name = "lblAantalParen"
        Me.lblAantalParen.Size = New System.Drawing.Size(59, 20)
        Me.lblAantalParen.TabIndex = 3
        Me.lblAantalParen.Text = "Label1"
        '
        'lblNodigeParen
        '
        Me.lblNodigeParen.AutoSize = True
        Me.lblNodigeParen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNodigeParen.Location = New System.Drawing.Point(261, 529)
        Me.lblNodigeParen.Name = "lblNodigeParen"
        Me.lblNodigeParen.Size = New System.Drawing.Size(59, 20)
        Me.lblNodigeParen.TabIndex = 4
        Me.lblNodigeParen.Text = "Label2"
        '
        'frmSpel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 855)
        Me.ControlBox = False
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

End Class
