Public Class frmHighscore


   
    Private Sub frmHighscore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HighscoreDataSet.Highscore' table. You can move, or remove it, as needed.
        Me.HighscoreTableAdapter.Fill(Me.HighscoreDataSet.Highscore)

    End Sub
End Class