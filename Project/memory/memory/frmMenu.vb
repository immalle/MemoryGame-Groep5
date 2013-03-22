Public Class frmMenu
    Public PATH As String
    Public MOEILIJKHEIDSGRAAD As frmSpel.Graad

    Private Sub rbGemakkelijk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbGemakkelijk.CheckedChanged
        If rbGemakkelijk.Checked = True Then
            MOEILIJKHEIDSGRAAD = frmSpel.Graad.Easy
        End If
    End Sub

    Private Sub rbNormaal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNormaal.CheckedChanged
        If rbNormaal.Checked = True Then
            MOEILIJKHEIDSGRAAD = frmSpel.Graad.Normal
        End If
    End Sub

    Private Sub rbMoeilijk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbMoeilijk.CheckedChanged
        If rbMoeilijk.Checked = True Then
            MOEILIJKHEIDSGRAAD = frmSpel.Graad.Hard
        End If
    End Sub

    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.AchtergrondMenu
        PATH = Application.StartupPath.Remove(Application.StartupPath.Length - 10) & "\Afbeeldingen"

        picBoxPlay.Image = My.Resources.PlayStandaard
        PicBoxQuit.Image = My.Resources.QuitStandaard
        picBoxHighscore.Image = My.Resources.HighscoreStandaard

        picBoxEasy.Image = My.Resources.EasyStandaard
        picBoxNormal.Image = My.Resources.NormalStandaard
        picBoxHard.Image = My.Resources.HardStandaard

        picBoxEasyCheck.Image = My.Resources.Unchecked
        picBoxNormalCheck.Image = My.Resources.Unchecked
        picBoxHardCheck.Image = My.Resources.Unchecked
    End Sub


    ' PictureBox PLAY ----------------------------
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

    '------------------------------------------------

    ' PictureBox QUIT --------------------------------

    Private Sub PicBoxQuit_Click(sender As System.Object, e As System.EventArgs) Handles PicBoxQuit.Click
        Me.Close()
    End Sub

    Private Sub PicBoxQuit_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles PicBoxQuit.MouseEnter
        sender.Image = My.Resources.QuitHover
    End Sub

    Private Sub PicBoxQuit_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles PicBoxQuit.MouseLeave
        sender.Image = My.Resources.QuitStandaard
    End Sub

    ' ---------------------------------------------------

    'PictureBox  HIGHSCORE ------------------------------

    Private Sub picBoxHighscore_Click(sender As System.Object, e As System.EventArgs) Handles picBoxHighscore.Click
        frmHighscore.Show()
    End Sub

    Private Sub picBoxHighscore_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxHighscore.MouseEnter
        sender.Image = My.Resources.HighscoreHover
    End Sub

    Private Sub picBoxHighscore_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxHighscore.MouseLeave
        sender.Image = My.Resources.HighscoreStandaard
    End Sub

    ' --------------------------------------------------

    ' PictureBox EASY ----------------------------------
    Private Sub picBoxEasy_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxEasy.MouseLeave
        sender.Image = My.Resources.EasyStandaard
    End Sub

    Private Sub picBoxEasyCheck_Click(sender As PictureBox, e As System.EventArgs) Handles picBoxEasyCheck.Click
        sender.Image = My.Resources.Checked
    End Sub

    Private Sub picBoxEasyCheck_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxEasyCheck.MouseEnter
        sender.Image = My.Resources.CheckHover
    End Sub

    Private Sub picBoxEasyCheck_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxEasyCheck.MouseLeave
        sender.Image = My.Resources.Unchecked
    End Sub

    ' --------------------------------------------------

    ' PictureBox NORMAL -----------------------------------
    Private Sub picBoxNormalCheck_Click(sender As PictureBox, e As System.EventArgs) Handles picBoxNormalCheck.Click
        sender.Image = My.Resources.Checked
    End Sub

    Private Sub picBoxNormalCheck_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxNormalCheck.MouseEnter
        sender.Image = My.Resources.CheckHover
    End Sub


    Private Sub picBoxNormalCheck_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxNormalCheck.MouseLeave
        sender.Image = My.Resources.Unchecked
    End Sub
    ' ------------------------------------------------------

    ' PictureBox HARD -------------------------------------
    Private Sub picBoxHardCheck_Click(sender As PictureBox, e As System.EventArgs) Handles picBoxHardCheck.Click
        sender.Image = My.Resources.Checked
    End Sub

    Private Sub picBoxHardCheck_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxHardCheck.MouseEnter
        sender.Image = My.Resources.CheckHover
    End Sub

    Private Sub picBoxHardCheck_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxHardCheck.MouseLeave
        sender.Image = My.Resources.Unchecked
    End Sub
    ' --------------------------------------------------------

End Class