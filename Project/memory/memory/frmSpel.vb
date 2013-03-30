Public Class frmSpel
    Dim Score As Integer = 0 ' De score van de speler.
    Dim Juiste As Integer ' Het aantal juiste paar dat de speler al heeft gevonden.
    ' Variabelen voor tijd
    Dim TijdBezigMin As Integer = 0 ' Tijd in minuten.
    Dim TijdBezigSec As Integer = 0 ' Tijd in seconden.
    ' ------
    Dim AantalNodigeJuiste As Integer ' Het aantal nodige juiste paar om een spel te winnen.
    Dim Afbeeldingen As New List(Of Image) ' De gebruikte afbeeldingen in een spel.
    Dim Kaarten As New List(Of KeyValuePair(Of Integer, Image)) ' KeyValue om kaarten te 'binden' aan een picturebox.
    Dim AfbTeZien As New List(Of Image) ' Een lijst die de afbeeldingen die zichtbaar zijn bijhoudt.
    Dim GekliktePicBox As New List(Of PictureBox) ' Een lijst die de aangeklikte picbox bijhoudt.
    Dim AlleAfbeeldingen As New List(Of Image) ' Een lijst waar alle afbeeldingen in geladen worden. Hier worden dan afbeeldingen willekeurig uitgenomen.
    Dim Start As Boolean = False ' Als true is dan worden alle kaarten verborgen en begint het spel.
    Dim TijdelijkPics As New List(Of PictureBox) ' Hier worden de picboxen in opgeslagen om later nog even te gebruiken wanneer het spel start.

    Enum Graad  ' Enum voor de moeilijdsgraden
        Easy
        Normal
        Hard
    End Enum

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Afhankelijk van de moeilijkheidsgraad, de code anders uitvoeren
        Me.Visible = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackgroundImage = My.Resources.Achtergrond
        Select Case frmMenu.MOEILIJKHEIDSGRAAD
            Case Graad.Easy
                GraadMakkelijk()
            Case Graad.Normal
                GraadNormaal()
            Case Graad.Hard
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
        Select Case frmMenu.MOEILIJKHEIDSGRAAD ' Op basis van welke moeilheidsgraad, moet het formulier een andere grootte hebben
            Case Graad.Easy
                Me.Width = 1250
                Me.Height = 750
            Case Graad.Normal
                Me.Width = 1350
                Me.Height = 750
            Case Graad.Hard
                Me.Width = 1350
                Me.Height = 900
        End Select
        Me.Location = New Point(10, 10)

        ' Alle labels een locatie, breedte, tekst, achtergrond,... geven Alle labels worden uitgeleind op de knop Menu
        btnMenu.Location = New Point(tussenPlaats, tussenPlaats)

        lblTweeAfbeeldingen.Location = New Point(btnMenu.Location.X, btnMenu.Width + (tussenPlaats * 2))
        lblTweeAfbeeldingen.AutoSize = False
        lblTweeAfbeeldingen.Width = btnMenu.Width
        lblTweeAfbeeldingen.Image = My.Resources.Achtergrond

        lblAantalParen.Location = New Point(btnMenu.Location.X, (btnMenu.Width * 2) + (tussenPlaats * 3))
        lblAantalParen.AutoSize = False
        lblAantalParen.Width = btnMenu.Width / 2
        lblAantalParen.Text = Juiste
        lblAantalParen.Image = My.Resources.Achtergrond

        lblNodigeParen.Location = New Point(btnMenu.Location.X + tussenPlaats, (btnMenu.Width * 2) + (tussenPlaats * 3))
        lblNodigeParen.AutoSize = False
        lblNodigeParen.Width = btnMenu.Width / 2
        lblNodigeParen.Text = "/ " & AantalNodigeJuiste
        lblNodigeParen.Image = My.Resources.Achtergrond

        lblTijdbezig.Location = New Point(btnMenu.Location.X, (btnMenu.Width * 3) + (tussenPlaats * 4))
        lblTijdbezig.AutoSize = False
        lblTijdbezig.Width = btnMenu.Width
        lblTijdbezig.Text = "Tijd: 0 : 0"
        lblTijdbezig.Image = My.Resources.Achtergrond

        lblScore.Location = New Point(btnMenu.Location.X, (btnMenu.Width * 4) + (tussenPlaats * 5))
        lblScore.AutoSize = False
        lblScore.Width = btnMenu.Width + 100
        lblScore.Text = "Score: " & Score
        lblScore.Image = My.Resources.Achtergrond
    End Sub

    Public Sub MaakVeld(ByVal aantalRij As Integer, ByVal aantalKolom As Integer)
        ' De PictureBoxen maken en toevoegen aan de controls van het formulier
        Dim random As New Random()
        Dim nr As Byte = 0
        ' Het veld maken
        For i = 0 To aantalRij - 1
            For j = 2 To aantalKolom + 1
                Dim randomGetal As Integer = random.Next(Afbeeldingen.Count)
                ' Basis instellingen voor elke picbox
                Dim picBox As New PictureBox
                picBox.Size = New Size(128, 128)
                picBox.Name = nr
                picBox.AutoSize = False
                picBox.Location = New Point(170 * j, 170 * i)
                picBox.SizeMode = PictureBoxSizeMode.StretchImage
                picBox.Enabled = False
                ' De afbeelding meegeven + opslaan 
                picBox.BackgroundImage = My.Resources.AchterkantKaart
                picBox.Image = AfbeeldingInstellen(randomGetal)
                Kaarten.Add(New KeyValuePair(Of Integer, Image)(picBox.Name, picBox.Image))
                picBox.BorderStyle = BorderStyle.FixedSingle
                picBox.Visible = True

                ' Handler meegeven
                AddHandler picBox.MouseClick, AddressOf PictureBoxOnMouseClick
                TijdelijkPics.Add(picBox)
                Me.Controls.Add(picBox)
                nr += 1
            Next
        Next
    End Sub

    Public Sub AfbeeldingenWeergevenVerbergen()
        ' De afbeeldingen eerst laten zien en daarna verbergen
        TijdAllesZien.Interval = 4000       ' De tijd die je krijgt om de afbeeldingen te zien voor het spel start
        TijdAllesZien.Start()
        While Start = False
            lblTweeAfbeeldingen.Text = "Het gaat beginnen."
            Application.DoEvents()
        End While
        For Each picbox As PictureBox In TijdelijkPics
            picbox.Image = My.Resources.achterkant
            picbox.Enabled = True
        Next
        lblTweeAfbeeldingen.Text = "Start!"
    End Sub

    Sub VoegAfbeeldingenToe(aantalAfbeeldingen As Byte)
        ' Alle afbeeldingen toevoegen aan een lijst
        For i = 1 To 46                                                     ' Misschien omzetten naar For Each
            Dim afb As Image                                                ' Omdat je niet perse over de afbeeldingsnamen moet loopen
            If i > 9 Then                                                   ' bv. *.png zou ook moeten werken 
                afb = Image.FromFile(frmMenu.PATH & "\Afb" & i & ".png")    ' Je kan dan flexibeler zijn met de afbeeldingen die je wil gebruiken
                AlleAfbeeldingen.Add(afb)                                   ' Om eigen afbeeldingen te gebruiken bijvoorbeeld
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
        If AfbTeZien.Count = 1 Then ' Controleren of er al een afbeeldingen te zien zijn anders (lijn 227)
            sender.Image = Kaarten(sender.Name).Value ' als er al een te zien is, voegen we hier de andere toe
            AfbTeZien.Add(sender.Image)
            GekliktePicBox.Add(sender)
            If AfbeeldingenVergelijken(AfbTeZien(0), AfbTeZien(1), 50) Then ' De afbeeldingen vergelijken m.b.v. de .Tag property
                ' De afbeeldingen zijn gelijk
                TijdAfbTonenGelijk.Start()
                Score += 50
                lblScore.Text = "Score: " & Score
            Else
                ' De afbeeldingen zijn niet gelijk
                TijdAfbTonenNietGelijk.Start()
                Score -= 10
                lblScore.Text = "Score: " & Score
            End If
            AfbTeZien.Clear()
        Else ' een afbeelding toevoegen aan de lijst
            sender.Image = Kaarten(sender.Name).Value
            GekliktePicBox.Add(sender)
            AfbTeZien.Add(sender.Image)
        End If

    End Sub

    Function AfbeeldingenVergelijken(ByVal image1 As Image, ByVal image2 As Image, ByVal punten As Byte) As Boolean
        ' Controleren of de 2 aangeklikte afbeeldingen hetzelfde zijn
        If image1.Tag = image2.Tag Then
            lblTweeAfbeeldingen.Text = "Een paar " & vbCrLf & "+ " & punten & " punten."
            Return True
        Else
            lblTweeAfbeeldingen.Text = "Geen paar" & vbCrLf & "- " & 10 & " punten."
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
        ' De afbeeldingen verwijderen ter bevestiging dat de 2 afbeeldingen gelijk zijn      Als de afbeeldingen gelijk zijn
        TijdAfbTonenGelijk.Stop()
        GekliktePicBox(0).BackgroundImage = My.Resources.Achtergrond
        GekliktePicBox(0).Image = My.Resources.Achtergrond
        GekliktePicBox(0).BorderStyle = BorderStyle.None
        GekliktePicBox(1).BackgroundImage = My.Resources.Achtergrond
        GekliktePicBox(1).Image = My.Resources.Achtergrond
        GekliktePicBox(1).BorderStyle = BorderStyle.None
        Juiste += 1
        GekliktePicBox(0).Enabled = False
        GekliktePicBox(1).Enabled = False
        lblAantalParen.Text = Juiste

        ' Als alle paren gevonden zijn, vragen of ze naar het menu willen terugkeren of gewoon stoppen
        If Juiste = AantalNodigeJuiste Then
            TijdBezig.Stop()
            'My.Computer.Audio.Play(Application.StartupPath.Remove(Application.StartupPath.Length - 10) & "\applaus.wav")
            MessageBox.Show("U heeft gewonnen." & vbCrLf & "U scoorde " & Score & " punten in " & lblTijdbezig.Text.Remove(0, 5) & vbCrLf & "Moeilijkheidsgraad: " & frmMenu.MOEILIJKHEIDSGRAAD.ToString, "Proficiat!", MessageBoxButtons.OK)
            ScoreOpslaan()
            Me.Close()
        End If
        GekliktePicBox.Clear()
    End Sub

    Sub ScoreOpslaan()
        ' De behaalde score met tijd en nickname opslaan in een .txt bestand (score opslaan in database was wel gelukt maar zorgde voor problemen met versie verschillen)
        Dim nickname As String = InputBox("Geef een nickname in: ", "Nickname voor scorebord")
        Dim bestandpad As String = frmMenu.PATH & "\Highscores.txt"
        Dim bestaandeTekst As String
        Dim reader As New System.IO.StreamReader(bestandpad)
        ' De bestaande score eerst lezen om gegevensverlies te voorkomen
        bestaandeTekst = reader.ReadToEnd
        reader.Close()
        Dim writer As New System.IO.StreamWriter(bestandpad)
        ' De nieuwe score bovenaan in het bestandje toevoegen
        writer.Write(nickname & ": " & Score & " op " & frmMenu.MOEILIJKHEIDSGRAAD.ToString & " in " & TijdBezigMin & ":" & TijdBezigSec & " min." & vbCrLf & bestaandeTekst)
        writer.Close()
        MessageBox.Show("Uw score is succesvol opgeslagen!")
        ' Vragen om de highscore te bekijken of anders terug te gaan naar het menu
        If MessageBox.Show("Wilt u nu de highscores bekijken?", "Highscores", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmHighscore.Show()
        Else
            Me.Close()
            frmMenu.Show()
        End If

    End Sub

    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click
        ' Het spel stoppen en naar het menu gaan
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub TijdBezig_Tick(sender As System.Object, e As System.EventArgs) Handles TijdBezig.Tick
        ' De duur van een spelletje bijhouden
        TijdBezigSec += 1
        If TijdBezigSec = 60 Then
            TijdBezigMin += 1
            TijdBezigSec = 0
        End If
        lblTijdbezig.Text = "Tijd: " & TijdBezigMin & " : " & TijdBezigSec
    End Sub

    Private Sub TijdAllesZien_Tick(sender As System.Object, e As System.EventArgs) Handles TijdAllesZien.Tick
        ' Als de tijd verstreken is om de afbeeldingen te kunnen zien moet het spel starten
        Start = True
    End Sub
End Class
