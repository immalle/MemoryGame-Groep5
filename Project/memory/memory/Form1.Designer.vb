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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HighscoreDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HighscoreDataSet = New memory.HighscoreDataSet()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighscoreDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighscoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.HighscoreDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(43, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(307, 251)
        Me.DataGridView1.TabIndex = 0
        '
        'HighscoreDataSetBindingSource
        '
        Me.HighscoreDataSetBindingSource.DataSource = Me.HighscoreDataSet
        Me.HighscoreDataSetBindingSource.Position = 0
        '
        'HighscoreDataSet
        '
        Me.HighscoreDataSet.DataSetName = "HighscoreDataSet"
        Me.HighscoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmHighscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 322)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmHighscore"
        Me.Text = "Highscore!"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighscoreDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighscoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HighscoreDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HighscoreDataSet As memory.HighscoreDataSet
End Class
