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
        Me.HighscoreDataSet = New memory.HighscoreDataSet()
        Me.HighscoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HighscoreTableAdapter = New memory.HighscoreDataSetTableAdapters.HighscoreTableAdapter()
        Me.HighscoreDataSetBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NaamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighscoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighscoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighscoreDataSetBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NaamDataGridViewTextBoxColumn, Me.ScoreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HighscoreBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(43, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(244, 251)
        Me.DataGridView1.TabIndex = 0
        '
        'HighscoreDataSet
        '
        Me.HighscoreDataSet.DataSetName = "HighscoreDataSet"
        Me.HighscoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HighscoreBindingSource
        '
        Me.HighscoreBindingSource.DataMember = "Highscore"
        Me.HighscoreBindingSource.DataSource = Me.HighscoreDataSetBindingSource3
        '
        'HighscoreTableAdapter
        '
        Me.HighscoreTableAdapter.ClearBeforeFill = True
        '
        'HighscoreDataSetBindingSource3
        '
        Me.HighscoreDataSetBindingSource3.DataSource = Me.HighscoreDataSet
        Me.HighscoreDataSetBindingSource3.Position = 0
        '
        'NaamDataGridViewTextBoxColumn
        '
        Me.NaamDataGridViewTextBoxColumn.DataPropertyName = "Naam"
        Me.NaamDataGridViewTextBoxColumn.HeaderText = "Naam"
        Me.NaamDataGridViewTextBoxColumn.Name = "NaamDataGridViewTextBoxColumn"
        Me.NaamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ScoreDataGridViewTextBoxColumn
        '
        Me.ScoreDataGridViewTextBoxColumn.DataPropertyName = "Score"
        Me.ScoreDataGridViewTextBoxColumn.HeaderText = "Score"
        Me.ScoreDataGridViewTextBoxColumn.Name = "ScoreDataGridViewTextBoxColumn"
        Me.ScoreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmHighscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 365)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmHighscore"
        Me.Text = "Highscore!"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighscoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighscoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighscoreDataSetBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HighscoreDataSet As memory.HighscoreDataSet
    Friend WithEvents HighscoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HighscoreTableAdapter As memory.HighscoreDataSetTableAdapters.HighscoreTableAdapter
    Friend WithEvents NaamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScoreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HighscoreDataSetBindingSource3 As System.Windows.Forms.BindingSource
End Class
