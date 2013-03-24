Public Class frmLoadLevel

    Private Sub frmLoadLevel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackgroundImage = My.Resources.Achtergrond
        picBoxText.BackgroundImage = My.Resources.Achtergrond
        Select Case frmMenu.MOEILIJKHEIDSGRAAD
            Case frmSpel.Graad.Easy
                picBoxText.Image = My.Resources.EasyStandaard
            Case frmSpel.Graad.Normal
                picBoxText.Image = My.Resources.NormalStandaard
            Case frmSpel.Graad.Hard
                picBoxText.Image = My.Resources.HardStandaard
        End Select
    End Sub

    Private Sub frmLoadLevel_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

        Threading.Thread.Sleep(2000)
        frmSpel.Show()
    End Sub
End Class