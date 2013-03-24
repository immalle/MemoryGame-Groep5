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
        Me.dgvScores = New System.Windows.Forms.DataGridView()
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 394)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(629, 43)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'dgvScores
        '
        Me.dgvScores.AllowUserToAddRows = False
        Me.dgvScores.AllowUserToDeleteRows = False
        Me.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScores.Location = New System.Drawing.Point(12, 12)
        Me.dgvScores.Name = "dgvScores"
        Me.dgvScores.ReadOnly = True
        Me.dgvScores.RowTemplate.Height = 24
        Me.dgvScores.Size = New System.Drawing.Size(629, 376)
        Me.dgvScores.TabIndex = 5
        '
        'frmHighscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 449)
        Me.Controls.Add(Me.dgvScores)
        Me.Controls.Add(Me.btnMenu)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHighscore"
        Me.Text = "Highscore!"
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents dgvScores As System.Windows.Forms.DataGridView
End Class
