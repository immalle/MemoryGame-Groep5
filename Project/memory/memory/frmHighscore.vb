Imports System.Data
Imports System.Data.SqlClient

Public Class frmHighscore
    Dim NaamTest As String = "ToonTest"
    Dim ScoreTest As Integer = 200
    Dim GraadTest As String = "Moeilijk"

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim conn As SqlConnection = Nothing
        Dim connString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=""D:\Program Files Alg\GitHub\MemoryGame-Groep5\Project\memory\memory\Resources\Scores.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=True"
        Dim da As SqlDataAdapter = Nothing
        Dim id As Integer
        Dim ds As DataSet = Nothing
        conn = New SqlConnection(connString)
        da = New SqlDataAdapter("SELECT * FROM tblScores", conn)
        conn.Open()
        ds = New DataSet()
        da.FillSchema(ds, SchemaType.Source, "tblScores")
        Dim table As DataTable = ds.Tables("tblScores")
        Dim newRecord As DataRow = table.NewRow()
        id = ds.Tables("tblScores").Rows.Count
        newRecord("id") = id + 1
        newRecord("Naam") = NaamTest
        newRecord("Score") = ScoreTest
        newRecord("Moeilijkheidsgraad") = GraadTest
        table.Rows.Add(newRecord)
        Dim command As New SqlCommandBuilder(da)
        da.Update(ds, "tblScores")

        ds.Dispose()
        conn.Close()
    End Sub
End Class