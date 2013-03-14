Public Class frmMain
    Dim Afbeeldingen As New List(Of Image)
    Dim Kaarten As New List(Of KeyValuePair(Of Integer, Image))
    Dim AfbTeZien As New List(Of Image)
    Dim GekliktePicBox As New List(Of PictureBox)

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MaakVeld()
    End Sub

    Sub MaakVeld()
        Dim nr As Byte = 0
        For i = 0 To 3
            For j = 0 To 3
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

    Sub VoegAfbeeldingenToe()
        Afbeeldingen.Add(My.Resources.Afb1) ' 0  Tag: 0
        Afbeeldingen.Add(My.Resources.Afb1) ' 1  Tag: 0

        Afbeeldingen.Add(My.Resources.Afb2) ' 2  Tag: 2
        Afbeeldingen.Add(My.Resources.Afb2) ' 3  Tag: 2

        Afbeeldingen.Add(My.Resources.Afb3) ' 4  Tag: 4
        Afbeeldingen.Add(My.Resources.Afb3) ' 5  Tag: 4

        Afbeeldingen.Add(My.Resources.Afb4) ' 6  Tag: 6
        Afbeeldingen.Add(My.Resources.Afb4) ' 7  Tag: 6

        Afbeeldingen.Add(My.Resources.Afb5) ' 8  Tag: 8
        Afbeeldingen.Add(My.Resources.Afb5) ' 9  Tag: 8

        Afbeeldingen.Add(My.Resources.Afb6) ' 10  Tag: 10
        Afbeeldingen.Add(My.Resources.Afb6) ' 11  Tag: 10

        Afbeeldingen.Add(My.Resources.Afb7) ' 12  Tag: 12
        Afbeeldingen.Add(My.Resources.Afb7) ' 13  Tag: 12

        Afbeeldingen.Add(My.Resources.Afb8) ' 14  Tag: 14
        Afbeeldingen.Add(My.Resources.Afb8) ' 15  Tag: 14

        For i = 0 To Afbeeldingen.Count - 1 Step 2
            Afbeeldingen(i).Tag = "Afb" & i
            Afbeeldingen(i + 1).Tag = "Afb" & i
        Next
    End Sub

    Function AfbeeldingInstellen() As Image
        Dim random As New Random()
        Dim randomGetal As Integer = random.Next(Afbeeldingen.Count)
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

    Private Sub btnPlay_Click(sender As Button, e As System.EventArgs) Handles btnPlay.Click
        VoegAfbeeldingenToe()
        Dim aantal As Byte = 0
        For Each cntrl As Control In Me.Controls
            If (TypeOf cntrl Is PictureBox) Then
                Dim picBox As PictureBox
                picBox = cntrl
                picBox.BackColor = Color.LightGray
                picBox.Image = AfbeeldingInstellen()
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

        GekliktePicBox.Clear()

    End Sub
End Class
