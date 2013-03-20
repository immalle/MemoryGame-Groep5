Public Class frmMenu
    Public PATH As String = Application.CommonAppDataPath & "\afb"
    Public MOEILIJKHEIDSGRAAD As frmSpel.Graad

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        frmSpel.Show()
        Me.Hide()
        frmSpel.Location = New Point(50, 50)
    End Sub

    Private Sub rbGemakkelijk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbGemakkelijk.CheckedChanged
        If rbGemakkelijk.Checked = True Then
            frmSpel.GraadMakkelijk()
        End If
    End Sub

    Private Sub rbNormaal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNormaal.CheckedChanged
        If rbNormaal.Checked = True Then
            frmSpel.GraadNormaal()
        End If
    End Sub

    

    Private Sub rbMoeilijk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbMoeilijk.CheckedChanged
        If rbMoeilijk.Checked = True Then
            frmSpel.GraadMoeilijk()
        End If

    End Sub

    

    
    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show(PATH)
    End Sub
End Class