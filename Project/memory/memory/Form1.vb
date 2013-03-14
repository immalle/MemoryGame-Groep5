Public Class frmMain
    Dim Afbeeldingen As New List(Of Image)
    Dim Kaarten As New List(Of KeyValuePair(Of Integer, Image))


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(1000, 1000)

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

                picBox.BorderStyle = BorderStyle.Fixed3D
                AddHandler picBox.MouseClick, AddressOf PictureBoxOnMouseClick
                Me.Controls.Add(picBox)
                nr += 1
            Next
        Next
    End Sub

    Sub VoegAfbeeldingenToe()
        Afbeeldingen.Add(My.Resources.Afb1)
        Afbeeldingen.Add(My.Resources.Afb1)

        Afbeeldingen.Add(My.Resources.Afb2)
        Afbeeldingen.Add(My.Resources.Afb2)

        Afbeeldingen.Add(My.Resources.Afb3)
        Afbeeldingen.Add(My.Resources.Afb3)

        Afbeeldingen.Add(My.Resources.Afb4)
        Afbeeldingen.Add(My.Resources.Afb4)

        Afbeeldingen.Add(My.Resources.Afb5)
        Afbeeldingen.Add(My.Resources.Afb5)

        Afbeeldingen.Add(My.Resources.Afb6)
        Afbeeldingen.Add(My.Resources.Afb6)

        Afbeeldingen.Add(My.Resources.Afb7)
        Afbeeldingen.Add(My.Resources.Afb7)

        Afbeeldingen.Add(My.Resources.Afb8)
        Afbeeldingen.Add(My.Resources.Afb8)
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
        Dim afbTeZien As New List(Of Image)

        If afbTeZien.Count >= 1 Then
            If AfbeeldingenVergelijken(afbTeZien(0), afbTeZien(1)) Then
                MessageBox.Show("Afbeeldingen zijn gelijk?")
            Else
                MessageBox.Show("Afbeeldingen niet gelijk?")
            End If
        Else
            sender.Image = Kaarten(sender.Name).Value
            afbTeZien.Add(sender.Image)
        End If
    End Sub

    Function AfbeeldingenVergelijken(ByVal image1 As Image, ByVal image2 As Image) As Boolean
        ' Hier de afbeeldingen met elkaar vergelijken
        If image1.Equals(image2) Then
            Return True
        Else
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
                picBox.Image = AfbeeldingInstellen()
                Kaarten.Add(New KeyValuePair(Of Integer, Image)(aantal, picBox.Image))
                picBox.Image = My.Resources.achterkant
                aantal += 1
            End If
        Next
        


       
    End Sub
End Class
