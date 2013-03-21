Public Class frmSpel
<<<<<<< HEAD
    Dim highscore As Integer
=======
    Dim Score As Integer
>>>>>>> Tijd + score verbeterd
    Dim Juiste As Integer
    ' Variabelen voor tijd
    Dim TijdBezigMin As Integer = 0
    Dim TijdBezigSec As Integer = 0
    ' ------
    Dim AantalNodigeJuiste As Integer
    Dim Afbeeldingen As New List(Of Image)
    Dim Kaarten As New List(Of KeyValuePair(Of Integer, Image))
    Dim AfbTeZien As New List(Of Image)
    Dim GekliktePicBox As New List(Of PictureBox)
    Dim AlleAfbeeldingen As New List(Of Image)
    Dim Paren As New List(Of Image) ' Alle paren opslagen en later tonen bij juiste paar zie sub Overzicht

    Enum Graad  ' Enum voor de moeilijdsgraden
        Gemakkelijk
        Normaal
        Moeilijk
    End Enum

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Afhankelijk van de moeilijkheidsgraad, de code anders uitvoeren
        Select Case frmMenu.MOEILIJKHEIDSGRAAD
            Case Graad.Gemakkelijk
                GraadMakkelijk()
            Case Graad.Normaal
                GraadNormaal()
            Case Graad.Moeilijk
                GraadMoeilijk()
        End Select
        TijdBezig.Start()
    End Sub

    Sub GraadMakkelijk()
        ' De nodige juiste afbeeldingen instellen
        AantalNodigeJuiste = 8
        Juiste = 0
        ' Stel formulier in op juiste verhoudingen
        StelFormulierIn()
        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(AantalNodigeJuiste)
        ' Veld van 4x4
        MaakVeld(4, 4)
    End Sub

    Sub GraadNormaal()
        ' De nodige juiste afbeeldingen instellen
        AantalNodigeJuiste = 12
        Juiste = 0
        ' Stel formulier in op juiste verhoudingen
        StelFormulierIn()

        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(AantalNodigeJuiste)
        ' Veld van 4x6
        MaakVeld(4, 6)
    End Sub

    Sub GraadMoeilijk()
        ' De nodige juiste afbeeldingen instellen
        AantalNodigeJuiste = 15
        Juiste = 0
        ' Stel formulier in op juiste verhoudingen
        StelFormulierIn()

        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(AantalNodigeJuiste)
        ' Veld van 5x6
        MaakVeld(5, 6)
    End Sub

    Sub StelFormulierIn()
        ' Locatie van alle labels + btns op het formulier
        Const tussenPlaats As Byte = 35
        Me.AutoSize = False
        Select Case frmMenu.MOEILIJKHEIDSGRAAD
            Case Graad.Gemakkelijk
                Me.Width = 1000
                Me.Height = 750
            Case Graad.Normaal
                Me.Width = 1250
                Me.Height = 750
            Case Graad.Moeilijk
                Me.Width = 1250
                Me.Height = 900
        End Select
        Me.Location = New Point(10, 10)
        btnMenu.Location = New Point(tussenPlaats, tussenPlaats)

        lblTweeAfbeeldingen.Location = New Point(btnMenu.Location.X, btnMenu.Width + (tussenPlaats * 2))
        lblTweeAfbeeldingen.AutoSize = False
        lblTweeAfbeeldingen.Width = btnMenu.Width

        lblAantalParen.Location = New Point(btnMenu.Location.X, (btnMenu.Width * 2) + (tussenPlaats * 3))
        lblAantalParen.AutoSize = False
        lblAantalParen.Width = btnMenu.Width / 2
        lblAantalParen.Text = Juiste

        lblNodigeParen.Location = New Point(btnMenu.Location.X + tussenPlaats, (btnMenu.Width * 2) + (tussenPlaats * 3))
        lblNodigeParen.AutoSize = False
        lblNodigeParen.Width = btnMenu.Width / 2
        lblNodigeParen.Text = "/ " & AantalNodigeJuiste

        lblTijdbezig.Location = New Point(btnMenu.Location.X, (btnMenu.Width * 3) + (tussenPlaats * 4))
        lblTijdbezig.AutoSize = False
        lblTijdbezig.Width = btnMenu.Width
        lblTijdbezig.Text = "Tijd: 0 : 0"

        lblScore.Location = New Point(btnMenu.Location.X, (btnMenu.Width * 4) + (tussenPlaats * 5))
        lblScore.AutoSize = False
        lblScore.Width = btnMenu.Width
        lblScore.Text = "Score: " & Score
    End Sub

    Sub testresolutie()
        MessageBox.Show(My.Computer.Screen.Bounds.Height.ToString()) ' Thuis ook eens testen

    End Sub

    Public Sub MaakVeld(ByVal aantalRij As Integer, ByVal aantalKolom As Integer)
        ' De PictureBoxen maken en toevoegen aan de controls van het formulier
        Dim random As New Random()
        Dim nr As Byte = 0
        For i = 0 To aantalRij - 1
            For j = 1 To aantalKolom
                Dim randomGetal As Integer = random.Next(Afbeeldingen.Count)
                ' Basis instellingen voor elke picbox
                Dim picBox As New PictureBox
                picBox.Size = New Size(128, 128)
                picBox.Name = nr
                picBox.AutoSize = False
                picBox.Location = New Point(170 * j, 170 * i)
                picBox.SizeMode = PictureBoxSizeMode.StretchImage
                ' De afbeelding meegeven + opslaan en daarna de achterkant tonen v/d kaart
                picBox.BackColor = Color.Transparent
                Kaarten.Add(New KeyValuePair(Of Integer, Image)(picBox.Name, AfbeeldingInstellen(randomGetal)))
                picBox.Image = My.Resources.achterkant
                picBox.BorderStyle = BorderStyle.FixedSingle
                picBox.Visible = True

                ' Handler meegeven
                AddHandler picBox.MouseClick, AddressOf PictureBoxOnMouseClick
                Me.Controls.Add(picBox)
                nr += 1
            Next
        Next
    End Sub

    Sub VoegAfbeeldingenToe(aantalAfbeeldingen As Byte)
        ' Alle afbeeldingen toevoegen aan een lijst
        For i = 1 To 46
            Dim afb As Image
            If i > 9 Then
                afb = Image.FromFile(frmMenu.PATH & "\Afb" & i & ".png")
                AlleAfbeeldingen.Add(afb)
            Else
                afb = Image.FromFile(frmMenu.PATH & "\Afb0" & i & ".png")
                AlleAfbeeldingen.Add(afb)
            End If
        Next
        Dim randomClass As New Random()

        ' Random afbeeldingen uit alle afbeeldingen halen
        For i = 0 To aantalAfbeeldingen - 1
            Dim randomAfbNr As Integer
            randomAfbNr = randomClass.Next(0, AlleAfbeeldingen.Count)
            Afbeeldingen.Add(AlleAfbeeldingen(randomAfbNr))
            Afbeeldingen.Add(AlleAfbeeldingen(randomAfbNr))
            AlleAfbeeldingen.RemoveAt(randomAfbNr)
        Next

        ' De gekozen afbeeldingen een bepaalde tag meegeven
        For i = 0 To Afbeeldingen.Count - 1 Step 2
            Afbeeldingen(i).Tag = "Afb" & i
            Afbeeldingen(i + 1).Tag = "Afb" & i
        Next
    End Sub

    Function AfbeeldingInstellen(ByVal randomGetal As Integer) As Image
        ' Een willekeurige afbeelding uit de lijst afbeeldingen toewijzen aan een picturebox
        Dim afb As Image
        afb = Afbeeldingen(randomGetal)
        Afbeeldingen.RemoveAt(randomGetal)
        Return afb
    End Function

    Private Sub PictureBoxOnMouseClick(ByVal sender As PictureBox, ByVal e As System.EventArgs)
        ' Als op een picturebox geklikt word, 
        If AfbTeZien.Count = 1 Then
            sender.Image = Kaarten(sender.Name).Value
            GekliktePicBox.Add(sender)
            AfbTeZien.Add(sender.Image)
            If AfbeeldingenVergelijken(AfbTeZien(0), AfbTeZien(1)) Then
                ' De afbeeldingen zijn gelijk
                TijdAfbTonenGelijk.Start()

                Dim maxPunten As Byte = 50


                If TijdBezigMin >= 1 Then
                    Select Case TijdBezigMin
                        Case 1
                            maxPunten -= 10
                        Case 2
                            maxPunten -= 10
                        Case 3
                            maxPunten -= 10
                        Case 4
                            maxPunten -= 10
                        Case 5
                            maxPunten -= 10
                    End Select
                End If
                Score = "Score: " & Score + maxPunten & "+ " & maxPunten
            Else
                ' De afbeeldingen zijn niet gelijk
                TijdAfbTonenNietGelijk.Start()
            End If
            AfbTeZien.Clear()
        Else
            sender.Image = Kaarten(sender.Name).Value
            GekliktePicBox.Add(sender)
            AfbTeZien.Add(sender.Image)
        End If
    End Sub

    Function AfbeeldingenVergelijken(ByVal image1 As Image, ByVal image2 As Image) As Boolean
        ' Controleren of de 2 aangeklikte afbeeldingen hetzelfde zijn
        If image1.Tag = image2.Tag Then
            lblTweeAfbeeldingen.Text = "Een paar"
            Return True
        Else
            lblTweeAfbeeldingen.Text = "Geen paar"
            Return False
        End If
    End Function

    Private Sub TijdAfbTonenNietGelijk_Tick(sender As System.Object, e As System.EventArgs) Handles TijdAfbTonenNietGelijk.Tick
        ' De afbeeldingen voor x seconden tonen en dan weer de achterkant laten zien   Als de afbeeldingen niet gelijk zijn
        TijdAfbTonenNietGelijk.Stop()
        GekliktePicBox(0).Image = My.Resources.achterkant
        GekliktePicBox(1).Image = My.Resources.achterkant
        GekliktePicBox.Clear()
    End Sub

    Private Sub TijdAfbTonenGelijk_Tick(sender As System.Object, e As System.EventArgs) Handles TijdAfbTonenGelijk.Tick
        ' De afbeeldingen een achtergrondkleur geven ter bevestiging dat de 2 afbeeldingen gelijk zijn      Als de afbeeldingen gelijk zijn
        TijdAfbTonenGelijk.Stop()
        GekliktePicBox(0).BackColor = Color.Aquamarine
        GekliktePicBox(1).BackColor = Color.Aquamarine
        Juiste += 1
        lblAantalParen.Text = Juiste

        ' Als alle paren gevonden zijn, vragen of ze naar het menu willen terugkeren of gewoon stoppen
        If Juiste = AantalNodigeJuiste Then
            MessageBox.Show("U heeft gewonnen.", "Proficiat!", MessageBoxButtons.OK)
            If MessageBox.Show("Wilt u terug naar het hoofdmenu", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                frmMenu.Show()
                Me.Close()
            Else
                Me.Close()
                frmMenu.Close()
            End If
        End If
        GekliktePicBox.Clear()
    End Sub

    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click
        ' Het spel stoppen en naar het menu gaan
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub TijdBezig_Tick(sender As System.Object, e As System.EventArgs) Handles TijdBezig.Tick
        TijdBezigSec += 1
        If TijdBezigSec = 60 Then
            TijdBezigMin += 1
            TijdBezigSec = 0
        End If
        lblTijdbezig.Text = "Tijd: " & TijdBezigMin & " : " & TijdBezigSec
    End Sub
End Class
