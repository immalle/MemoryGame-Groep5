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
        Me.SuspendLayout()
        '
        'lblTweeAfbeeldingen
        '
        Me.lblTweeAfbeeldingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTweeAfbeeldingen.Location = New System.Drawing.Point(89, 554)
        Me.lblTweeAfbeeldingen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTweeAfbeeldingen.Name = "lblTweeAfbeeldingen"
        Me.lblTweeAfbeeldingen.Size = New System.Drawing.Size(119, 36)
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
        Me.btnMenu.Location = New System.Drawing.Point(316, 549)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(76, 41)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'frmSpel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 695)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblTweeAfbeeldingen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSpel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Game"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTweeAfbeeldingen As System.Windows.Forms.Label
    Friend WithEvents TijdAfbTonenNietGelijk As System.Windows.Forms.Timer
    Friend WithEvents TijdAfbTonenGelijk As System.Windows.Forms.Timer
    Friend WithEvents btnMenu As System.Windows.Forms.Button

End Class
