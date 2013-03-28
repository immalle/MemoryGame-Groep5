Imports System.Data
Imports System.Data.SqlClient

Public Class frmHighscore

    Private Sub frmHighscore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False

        LaadScores()


    End Sub

    Sub LaadScores()
        Dim bestandpad As String = frmMenu.PATH & "\Highscores.txt"
        Dim reader As New System.IO.StreamReader(bestandpad)
        rtxtScores.Text = reader.ReadToEnd
        reader.Close()
    End Sub

    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    'Sub DatabaseSchool()
    '    Dim conn As SqlConnection = Nothing
    '    Dim connString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=""D:\5I\SO De Doncker Toon\GitHub\MemoryGame-Groep5\Project\memory\memory\Resources\ScoresSchool.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=True"
    '    Dim da As SqlDataAdapter = Nothing
    '    Dim ds As DataSet = Nothing
    '    conn = New SqlConnection(connString)
    '    da = New SqlDataAdapter("SELECT * FROM tblScores", conn)
    '    conn.Open()
    '    ds = New DataSet()
    '    da.Fill(ds, "tblScores")
    '    dgvScores.DataSource = ds.Tables("tblScores")

    '    ds.Dispose()
    '    conn.Close()
    'End Sub

    'Sub DatabaseThuis()
    '    Dim conn As SqlConnection = Nothing
    '    Dim connString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=""D:\Program Files Alg\GitHub\MemoryGame-Groep5\Project\memory\memory\Resources\Scores.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=True"
    '    Dim da As SqlDataAdapter = Nothing
    '    Dim ds As DataSet = Nothing
    '    conn = New SqlConnection(connString)
    '    da = New SqlDataAdapter("SELECT * FROM tblScores", conn)
    '    conn.Open()
    '    ds = New DataSet()
    '    da.Fill(ds, "tblScores")
    '    dgvScores.DataSource = ds.Tables("tblScores")

    '    ds.Dispose()
    '    conn.Close()
    'End Sub
End Class