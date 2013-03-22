Imports System.Data
Imports System.Data.SqlClient

Public Class frmHighscore
    'Dim NaamTest As String = "ToonTest"
    'Dim ScoreTest As Integer = 200
    'Dim GraadTest As String = "Moeilijk"

    Private Sub frmHighscore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim conn As New SqlConnection
        'conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=""D:\Visual Studio 2010\Database\SQL\LoginClient\LoginClient.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=True"
        'Dim da As New SqlDataAdapter
        'Dim ds As New DataSet
        'conn.Open()

        'da.Fill(ds, "tblUsers")
        'Dim table As DataTable = ds.Tables("tblUsers")
        'Dim row As DataRow
        'row(0) = NaamTest
        'row(1) = GraadTest
        'table.Rows.Add(row)
        'da.Update(ds, "tblUsers")
        'conn.Close()
    End Sub




    'Dim connectionString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=""D:\Program Files Alg\GitHub\MemoryGame-Groep5\Project\memory\memory\Scores.mdf"";Integrated Security=True;User Instance=True"
    'Dim connection As SqlConnection = Nothing
    'Dim adapter As SqlDataAdapter = Nothing
    'Dim ds As New DataSet()

    '    connection = New SqlConnection(connectionString)

    '    connection.Open()
    '    adapter.FillSchema(ds, SchemaType.Source, "tblScores")
    'Dim table As DataTable = ds.Tables("tblScores")
    'Dim newRecord As DataRow = table.NewRow()
    '    newRecord(0) = 1
    '    newRecord(1) = NaamTest
    '    newRecord(2) = GraadTest
    '    newRecord(3) = ScoreTest
    '    table.Rows.Add(newRecord)

    'Dim command As New SqlCommandBuilder(adapter)
    '    adapter.Update(ds, "tblScores")
    '    ds.Dispose()
    '    connection.Close()
End Class