Public Class frmSpel
    Dim Juiste As Integer
    Dim AantalNodigeJuiste As Integer
    Dim Afbeeldingen As New List(Of Image)
    Dim Kaarten As New List(Of KeyValuePair(Of Integer, Image))
    Dim AfbTeZien As New List(Of Image)
    Dim GekliktePicBox As New List(Of PictureBox)
    Dim AlleAfbeeldingen As New List(Of Image)

    Enum Graad
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
        StelFormulierIn(755, 660, 20, 650)
        ' Veld van 4x4
        MaakVeld(4, 4)
        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(8)
        ' Start het spel
        Play()
    End Sub

    Sub GraadNormaal()
        ' De nodige juiste afbeeldingen instellen
        AantalNodigeJuiste = 12
        Juiste = 0
        ' Stel formulier in op juiste verhoudingen
        StelFormulierIn(755, 1000, 20, 650)
        ' Veld van 6x6
        MaakVeld(6, 6)
        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(18)
        ' Start het spel
        Play()
    End Sub

    Sub GraadMoeilijk()
        ' De nodige juiste afbeeldingen instellen
        AantalNodigeJuiste = 16
        Juiste = 0
        ' Stel formulier in op juiste verhoudingen
        StelFormulierIn(755, 1200, 20, 650)
        ' Veld van 8x8
        MaakVeld(8, 8)
        ' Voeg de afbeeldingen toe
        VoegAfbeeldingenToe(32)
        ' Start het spel
        Play()

    End Sub

    Sub StelFormulierIn(Formheight As Integer, Formwidth As Integer, knopMenuX As Integer, knopMenuY As Integer)
        Me.AutoSize = False
        Me.WindowState = FormWindowState.Maximized
        btnMenu.Location = New Point(knopMenuX, knopMenuY)
        lblTweeAfbeeldingen.Location = New Point(150, 650)
        lblTweeAfbeeldingen.AutoSize = False
        lblTweeAfbeeldingen.Width = 200

        lblAantalParen.Location = New Point(400, 650)
        lblAantalParen.AutoSize = False
        lblAantalParen.Width = 200
        lblAantalParen.Text = Juiste

        lblNodigeParen.Location = New Point(450, 650)
        lblNodigeParen.AutoSize = False
        lblNodigeParen.Width = 200
        lblNodigeParen.Text = AantalNodigeJuiste
    End Sub

    Public Sub MaakVeld(ByVal aantalRij As Integer, ByVal aantalKolom As Integer)
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
        Dim afb As Image
        afb = Afbeeldingen(randomGetal)
        Afbeeldingen.RemoveAt(randomGetal)
        Return afb
    End Function

    Private Sub PictureBoxOnMouseClick(ByVal sender As PictureBox, ByVal e As System.EventArgs)
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
        If image1.Tag = image2.Tag Then
            lblTweeAfbeeldingen.Text = "De afbeeldingen zijn gelijk"
            Return True
        Else
            lblTweeAfbeeldingen.Text = "De afbeeldingen zijn niet gelijk"
            Return False
        End If
    End Function

    Sub Play()
        Dim random As New Random()
        Dim aantal As Byte = 0
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

    Private Sub TijdAfbTonen_Tick(sender As System.Object, e As System.EventArgs) Handles TijdAfbTonenNietGelijk.Tick
        TijdAfbTonenNietGelijk.Stop()
        GekliktePicBox(0).Image = My.Resources.achterkant
        GekliktePicBox(1).Image = My.Resources.achterkant
        GekliktePicBox.Clear()
    End Sub

    Private Sub TijdAfbTonenGelijk_Tick(sender As System.Object, e As System.EventArgs) Handles TijdAfbTonenGelijk.Tick
        TijdAfbTonenGelijk.Stop()
        GekliktePicBox(0).BackColor = Color.Aquamarine
        GekliktePicBox(1).BackColor = Color.Aquamarine
        Juiste += 1
        lblAantalParen.Text = Juiste
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
        Me.Close()
        frmMenu.Show()
    End Sub
End Class
