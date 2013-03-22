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
        Me.dgvHighscore = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHighscore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHighscore
        '
        Me.dgvHighscore.AllowUserToAddRows = False
        Me.dgvHighscore.AllowUserToDeleteRows = False
        Me.dgvHighscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHighscore.Location = New System.Drawing.Point(13, 13)
        Me.dgvHighscore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvHighscore.Name = "dgvHighscore"
        Me.dgvHighscore.ReadOnly = True
        Me.dgvHighscore.RowTemplate.Height = 24
        Me.dgvHighscore.Size = New System.Drawing.Size(627, 317)
        Me.dgvHighscore.TabIndex = 0
        '
        'frmHighscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 449)
        Me.Controls.Add(Me.dgvHighscore)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHighscore"
        Me.Text = "Highscore!"
        CType(Me.dgvHighscore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvHighscore As System.Windows.Forms.DataGridView
End Class
