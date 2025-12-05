Imports System.Data.Common

Public Class Connexion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "DSN=SRVORAGSB;Uid=system;Pwd=Iroise29;"
        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class