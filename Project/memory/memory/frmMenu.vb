Public Class frmMenu
    Public PATH As String
    Public MOEILIJKHEIDSGRAAD As frmSpel.Graad

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        frmSpel.Show()
        Me.Hide()
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
        PATH = Application.StartupPath.Remove(Application.StartupPath.Length - 10) & "\Afbeeldingen"
    End Sub

    Private Sub btnHighscore_Click(sender As System.Object, e As System.EventArgs) Handles btnHighscore.Click
        frmHighscore.Show()

    End Sub
End Class