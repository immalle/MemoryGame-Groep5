Public Class frmMenu
    Public PATH As String
    Public MOEILIJKHEIDSGRAAD As frmSpel.Graad

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub rbGemakkelijk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbGemakkelijk.CheckedChanged
        If rbGemakkelijk.Checked = True Then
            MOEILIJKHEIDSGRAAD = frmSpel.Graad.Gemakkelijk
        End If
    End Sub

    Private Sub rbNormaal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNormaal.CheckedChanged
        If rbNormaal.Checked = True Then
            MOEILIJKHEIDSGRAAD = frmSpel.Graad.Normaal
        End If
    End Sub

    Private Sub rbMoeilijk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbMoeilijk.CheckedChanged
        If rbMoeilijk.Checked = True Then
            MOEILIJKHEIDSGRAAD = frmSpel.Graad.Moeilijk
        End If
    End Sub

    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.AchtergrondMenu
        PATH = Application.StartupPath.Remove(Application.StartupPath.Length - 10) & "\Afbeeldingen"
        picBoxPlay.Image = My.Resources.PlayStandaard
        PicBoxQuit.Image = My.Resources.QuitStandaard
        picBoxHighscore.Image = My.Resources.HighscoreStandaard
    End Sub

    Private Sub btnHighscore_Click(sender As System.Object, e As System.EventArgs)
        frmHighscore.Show()

    End Sub

    Private Sub picBoxPlay_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxPlay.MouseEnter
        sender.Image = My.Resources.PlayHover
    End Sub

    Private Sub picBoxPlay_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxPlay.MouseLeave
        sender.Image = My.Resources.PlayStandaard
    End Sub

    Private Sub picBoxPlay_Click(sender As System.Object, e As System.EventArgs) Handles picBoxPlay.Click
        frmSpel.Show()
        Me.Hide()
    End Sub

    Private Sub PicBoxQuit_Click(sender As System.Object, e As System.EventArgs) Handles PicBoxQuit.Click
        Me.Close()
    End Sub

    Private Sub PicBoxQuit_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles PicBoxQuit.MouseEnter
        sender.Image = My.Resources.QuitHover
    End Sub

    Private Sub PicBoxQuit_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles PicBoxQuit.MouseLeave
        sender.Image = My.Resources.QuitStandaard
    End Sub

    Private Sub picBoxHighscore_Click(sender As System.Object, e As System.EventArgs) Handles picBoxHighscore.Click
        frmHighscore.Show()
    End Sub

    Private Sub picBoxHighscore_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxHighscore.MouseEnter
        sender.Image = My.Resources.HighscoreHover
    End Sub

    Private Sub picBoxHighscore_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxHighscore.MouseLeave
        sender.Image = My.Resources.HighscoreStandaard
    End Sub
End Class