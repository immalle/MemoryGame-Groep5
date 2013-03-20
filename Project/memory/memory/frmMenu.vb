Public Class frmMenu
    Public PATH As String = Application.StartupPath & "\afb"
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

    'Sub PlayMogelijk(ByVal graad As frmSpel.Graad)
    '    Dim gekozenGraad As Boolean
    '    Dim pad As Boolean
    '    pad = txtPad.Text <> ""
    '    MOEILIJKHEIDSGRAAD = graad
    '    gekozenGraad = MOEILIJKHEIDSGRAAD = frmSpel.Graad.Gemakkelijk Or MOEILIJKHEIDSGRAAD = frmSpel.Graad.Normaal Or MOEILIJKHEIDSGRAAD = frmSpel.Graad.Moeilijk

    '    If pad And gekozenGraad Then
    '        btnPlay.Enabled = True
    '    End If

    'End Sub
    'Private Sub txtPad_TextChanged(sender As TextBox, e As System.EventArgs) Handles txtPad.TextChanged
    '    PATH = sender.Text
    '    gbGraden.Enabled = True
    'End Sub

    Private Sub rbMoeilijk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbMoeilijk.CheckedChanged
        If rbMoeilijk.Checked = True Then
            frmSpel.GraadMoeilijk()
        End If
    End Sub

    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    '    txtPad.Text = Application.StartupPath & "\afb"
    '    'txtPad.Text = "D:\5I\SO De Doncker Toon\GitHub\MemoryGame-Groep5\Project\memory\Afb"
    'End Sub
End Class