Imports System.Data.Common
Imports System.Data.Odbc

Public Class ConsulterCompteRendu
    Public numeroCR As Integer
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As OdbcDataReader
    Private Sub ConsulterCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Bilan.Enabled = False
        myConnection.ConnectionString = GlobalData.ConnexionString ' Chaine de connexion à la base de données
        Try
            myConnection.Open() ' Connexion à la base de données
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la connexion à la base de données : " & ex.Message)
        End Try
        ChargerDonnees()
        ChargerProduits()
    End Sub
    Private Sub ChargerDonnees()
        Dim query As String = " SELECT praticien.nom, visite.datevisite, motif.libelle, visite.bilan
                                FROM praticien, visite, produit, echantillon, motif
                                WHERE praticien.id = visite.idpraticien
                                AND visite.id = echantillon.idvisite
                                AND echantillon.codeproduit = produit.code
                                AND visite.idmotif = motif.id
                                AND visite.id = :idVisite;"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue(":idVisite", numeroCR)
        myReader = myCommand.ExecuteReader()
        If myReader.Read() Then
            Nom_Praticien.Text = myReader.GetString(0)
            Date_Visite.Text = myReader.GetDateTime(1).ToString("dd/MM/yyyy")
            Motif.Text = myReader.GetString(2)
            TextBox_Bilan.Text = myReader.GetString(3)
        End If
        myReader.Close()
    End Sub
    Private Sub ChargerProduits()
        Dim query As String = " SELECT produit.libelle, echantillon.quantite
                                FROM produit, echantillon
                                WHERE echantillon.codeproduit = produit.code
                                AND echantillon.idvisite = :idVisite;"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue(":idVisite", numeroCR)
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            DataGridView_Produits.Rows.Add(myReader.GetString(0), myReader.GetString(1))
        End While
        myReader.Close()
    End Sub
End Class