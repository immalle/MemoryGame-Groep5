<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadLevel
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
        Me.picBoxText = New System.Windows.Forms.PictureBox()
        CType(Me.picBoxText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxText
        '
        Me.picBoxText.Location = New System.Drawing.Point(348, 59)
        Me.picBoxText.Name = "picBoxText"
        Me.picBoxText.Size = New System.Drawing.Size(295, 125)
        Me.picBoxText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxText.TabIndex = 0
        Me.picBoxText.TabStop = False
        '
        'frmLoadLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 255)
        Me.Controls.Add(Me.picBoxText)
        Me.Name = "frmLoadLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laden..."
        CType(Me.picBoxText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBoxText As System.Windows.Forms.PictureBox
End Class
