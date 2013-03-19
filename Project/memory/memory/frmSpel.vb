Public Class frmSpel
    Dim Juiste As Integer
    Dim AantalNodigeJuiste As Integer
    Dim Afbeeldingen As New List(Of Image)
    Dim Kaarten As New List(Of KeyValuePair(Of Integer, Image))
    Dim AfbTeZien As New List(Of Image)
    Dim GekliktePicBox As New List(Of PictureBox)
    Dim AlleAfbeeldingen As New List(Of Image)

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
    End Sub

    Sub GraadMakkelijk()
        ' De nodige juiste afbeeldingen instellen
        AantalNodigeJuiste = 8
        Juiste = 0
        ' Stel formulier in op juiste verhoudingen
        StelFormulierIn()
        ' Veld van 4x4
        MaakVeld(4, 4)
        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(AantalNodigeJuiste)
        ' Start het spel
        Play()
    End Sub

    Sub GraadNormaal()
        ' De nodige juiste afbeeldingen instellen
        AantalNodigeJuiste = 15
        Juiste = 0
        ' Stel formulier in op juiste verhoudingen
        StelFormulierIn()
        ' Veld van 5x6
        MaakVeld(5, 6)
        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(AantalNodigeJuiste)
        ' Start het spel
        Play()
    End Sub

    Sub GraadMoeilijk()
        ' De nodige juiste afbeeldingen instellen
        AantalNodigeJuiste = 24
        Juiste = 0
        ' Stel formulier in op juiste verhoudingen
        StelFormulierIn()
        ' Veld van 8x8
        MaakVeld(6, 8)
        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(AantalNodigeJuiste)
        ' Start het spel
        Play()
        
    End Sub

    Sub StelFormulierIn()
        ' Locatie van alle labels + btns op het formulier
        Const tussenPlaats As Byte = 35

        Me.AutoSize = False
        Me.WindowState = FormWindowState.Maximized

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
    End Sub

    Public Sub MaakVeld(ByVal aantalRij As Integer, ByVal aantalKolom As Integer)
        ' De PictureBoxen maken en toevoegen aan de controls van het formulier
        Dim nr As Byte = 0
        For i = 0 To aantalRij - 1
            For j = 1 To aantalKolom
                Dim picBox As New PictureBox
                picBox.Size = New Size(100, 100)
                picBox.Name = nr
                picBox.AutoSize = False
                picBox.Location = New Point(170 * j, 170 * i)
                picBox.SizeMode = PictureBoxSizeMode.AutoSize
                picBox.Visible = False

                picBox.BorderStyle = BorderStyle.Fixed3D
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

    Sub Play()
        Dim random As New Random()
        Dim aantal As Byte = 0

        ' In alle controls op zoek gaan naar de pictureboxen en daar een afbeelding aan toewijzen (Dit kan misschien wel bij veld maken?)
        For Each cntrl As Control In Me.Controls
            If (TypeOf cntrl Is PictureBox) Then
                Dim randomGetal As Integer = random.Next(Afbeeldingen.Count)
                Dim picBox As PictureBox
                picBox = cntrl
                picBox.BackColor = Color.LightGray
                picBox.Image = AfbeeldingInstellen(randomGetal)
                Kaarten.Add(New KeyValuePair(Of Integer, Image)(aantal, picBox.Image))
                picBox.Image = My.Resources.achterkant
                picBox.Visible = True
                aantal += 1
            End If
        Next
    End Sub

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

    
End Class
