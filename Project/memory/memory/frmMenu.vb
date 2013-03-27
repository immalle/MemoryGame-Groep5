Public Class frmMenu
    Public PATH As String
    Public MOEILIJKHEIDSGRAAD As frmSpel.Graad
    Dim EasyChecked As Boolean = False
    Dim NormalChecked As Boolean = False
    Dim HardChecked As Boolean = False

    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackgroundImage = My.Resources.Achtergrond

        Me.BackgroundImage = My.Resources.Achtergrond
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
        frmLoadLevel.Show()
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

    ' PictureBox  HIGHSCORE ------------------------------
    Private Sub picBoxHighscore_Click(sender As System.Object, e As System.EventArgs) Handles picBoxHighscore.Click
        frmHighscore.Show()
        Me.Hide()
    End Sub

    Private Sub picBoxHighscore_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxHighscore.MouseEnter
        sender.Image = My.Resources.HighscoreHover
    End Sub

    Private Sub picBoxHighscore_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxHighscore.MouseLeave
        sender.Image = My.Resources.HighscoreStandaard
    End Sub
    ' --------------------------------------------------

    ' PictureBox EASY ----------------------------------
    Private Sub picBoxEasyCheck_Click(sender As PictureBox, e As System.EventArgs) Handles picBoxEasyCheck.Click
        sender.Image = My.Resources.Checked
        picBoxNormalCheck.Image = My.Resources.Unchecked
        picBoxHardCheck.Image = My.Resources.Unchecked
        EasyChecked = True
        NormalChecked = False
        HardChecked = False
        MOEILIJKHEIDSGRAAD = frmSpel.Graad.Easy
    End Sub

    Private Sub picBoxEasyCheck_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxEasyCheck.MouseEnter
        If EasyChecked Then
            sender.Image = My.Resources.Checked
        Else
            sender.Image = My.Resources.CheckHover
        End If
    End Sub

    Private Sub picBoxEasyCheck_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxEasyCheck.MouseLeave
        If EasyChecked And NormalChecked = False And HardChecked = False Then
            sender.Image = My.Resources.Checked
        Else
            sender.Image = My.Resources.Unchecked
        End If
    End Sub
    ' --------------------------------------------------

    ' PictureBox NORMAL -----------------------------------
    Private Sub picBoxNormalCheck_Click(sender As PictureBox, e As System.EventArgs) Handles picBoxNormalCheck.Click
        sender.Image = My.Resources.Checked
        picBoxEasyCheck.Image = My.Resources.Unchecked
        picBoxHardCheck.Image = My.Resources.Unchecked
        NormalChecked = True
        EasyChecked = False
        HardChecked = False
        MOEILIJKHEIDSGRAAD = frmSpel.Graad.Normal
    End Sub

    Private Sub picBoxNormalCheck_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxNormalCheck.MouseEnter
        If NormalChecked Then
            sender.Image = My.Resources.Checked
        Else
            sender.Image = My.Resources.CheckHover
        End If
    End Sub

    Private Sub picBoxNormalCheck_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxNormalCheck.MouseLeave
        If NormalChecked And EasyChecked = False And HardChecked = False Then
            sender.Image = My.Resources.Checked
        Else
            sender.Image = My.Resources.Unchecked
        End If
    End Sub
    ' ------------------------------------------------------

    ' PictureBox HARD -------------------------------------
    Private Sub picBoxHardCheck_Click(sender As PictureBox, e As System.EventArgs) Handles picBoxHardCheck.Click
        sender.Image = My.Resources.Checked
        picBoxNormalCheck.Image = My.Resources.Unchecked
        picBoxEasyCheck.Image = My.Resources.Unchecked
        HardChecked = True
        EasyChecked = False
        NormalChecked = False
        MOEILIJKHEIDSGRAAD = frmSpel.Graad.Hard
    End Sub

    Private Sub picBoxHardCheck_MouseEnter(sender As PictureBox, e As System.EventArgs) Handles picBoxHardCheck.MouseEnter
        If HardChecked Then
            sender.Image = My.Resources.Checked
        Else
            sender.Image = My.Resources.CheckHover
        End If
    End Sub

    Private Sub picBoxHardCheck_MouseLeave(sender As PictureBox, e As System.EventArgs) Handles picBoxHardCheck.MouseLeave
        If HardChecked And EasyChecked = False And NormalChecked = False Then
            sender.Image = My.Resources.Checked
        Else
            sender.Image = My.Resources.Unchecked
        End If

    End Sub
    ' --------------------------------------------------------

    Private Sub picBoxPlay_MouseLeave(sender As System.Object, e As System.EventArgs) Handles picBoxPlay.MouseLeave

    End Sub
    Private Sub picBoxPlay_MouseEnter(sender As System.Object, e As System.EventArgs) Handles picBoxPlay.MouseEnter

    End Sub
    Private Sub PicBoxQuit_MouseLeave(sender As System.Object, e As System.EventArgs) Handles PicBoxQuit.MouseLeave

    End Sub
    Private Sub PicBoxQuit_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PicBoxQuit.MouseEnter

    End Sub
    Private Sub picBoxHighscore_MouseLeave(sender As System.Object, e As System.EventArgs) Handles picBoxHighscore.MouseLeave

    End Sub
    Private Sub picBoxHighscore_MouseEnter(sender As System.Object, e As System.EventArgs) Handles picBoxHighscore.MouseEnter

    End Sub
    Private Sub picBoxEasyCheck_MouseLeave(sender As System.Object, e As System.EventArgs) Handles picBoxEasyCheck.MouseLeave

    End Sub
    Private Sub picBoxEasyCheck_MouseEnter(sender As System.Object, e As System.EventArgs) Handles picBoxEasyCheck.MouseEnter

    End Sub
    Private Sub picBoxEasyCheck_Click(sender As System.Object, e As System.EventArgs) Handles picBoxEasyCheck.Click

    End Sub
    Private Sub picBoxHardCheck_MouseLeave(sender As System.Object, e As System.EventArgs) Handles picBoxHardCheck.MouseLeave

    End Sub
    Private Sub picBoxHardCheck_MouseEnter(sender As System.Object, e As System.EventArgs) Handles picBoxHardCheck.MouseEnter

    End Sub
    Private Sub picBoxHardCheck_Click(sender As System.Object, e As System.EventArgs) Handles picBoxHardCheck.Click

    End Sub
    Private Sub picBoxNormalCheck_MouseLeave(sender As System.Object, e As System.EventArgs) Handles picBoxNormalCheck.MouseLeave

    End Sub
    Private Sub picBoxNormalCheck_MouseEnter(sender As System.Object, e As System.EventArgs) Handles picBoxNormalCheck.MouseEnter

    End Sub
    Private Sub picBoxNormalCheck_Click(sender As System.Object, e As System.EventArgs) Handles picBoxNormalCheck.Click

    End Sub
End Class