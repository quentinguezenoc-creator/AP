Imports System.Data.Odbc

Public Class ConsulterActiviteEquipe
    Public MatriculeDelegue As String
    Private Sub ConsulterActiviteEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nb_Visite.Visible = False
        Nb_Visite.Visible = False
        DataGridView_Praticien.Visible = False
        DataGridView_Motif.Visible = False

    End Sub
    Private Sub ChargerVisiteur()
        Dim query As String = "SELECT utilisateur.nom, utilisateur.prenom, utilisateur.matricule
                               FROM utilisateur, visiteur
                               WHERE visiteur.matriculevisiteur = utilisateur.matricule
                               AND visiteur.matriculedelegue = :matricule ;"

        Dim myConnection As New Odbc.OdbcConnection(GlobalData.ConnexionString)
        Dim myCommand As New Odbc.OdbcCommand

        Try
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = query
            myCommand.Parameters.Clear()
            myCommand.Parameters.AddWithValue(":matricule", MatriculeDelegue)

            Dim myReader As OdbcDataReader = myCommand.ExecuteReader()
            DataGridView_Visiteur.Rows.Clear()

            While myReader.Read()
                DataGridView_Visiteur.Rows.Add(myReader.GetString(0), myReader.GetString(1), "Consulter")
            End While
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label_Nb_Visite.Visible = True
        Nb_Visite.Visible = True
        DataGridView_Praticien.Visible = True
        DataGridView_Motif.Visible = True
    End Sub

    Private Sub DataGridView_Visiteur_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Visiteur.CellContentClick
        Dim fenetre As New ConsulterActiviteVisiteur
        fenetre.Show()
    End Sub
End Class