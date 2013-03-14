Public Class frmMain
    Dim Afbeeldingen As New List(Of Image)
    Dim Kaarten As New List(Of KeyValuePair(Of Integer, Image))
    Dim AantalTeZien As Byte = 0


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
        If AantalTeZien >= 2 Then
            'If afbTeZien(0).Equals(afbTeZien(1) 
            Exit Sub        ' TIJDELIJKE OPLOSSING
        End If


        sender.Image = Kaarten(sender.Name).Value
        afbTeZien.Add(sender.Image)
        AantalTeZien += 1
        'If AantalTeZien = 2 Then
        '    afbTeZien.Clear()
        '    AantalTeZien = 0
        'End If
    End Sub

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
