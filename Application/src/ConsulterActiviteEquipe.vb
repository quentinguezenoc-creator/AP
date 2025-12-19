Imports System.Data.Common
Imports System.Data.Odbc


Public Class ConsulterActiviteEquipe
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As OdbcDataReader
    Public MatriculeDelegue As String
    Private Sub ConsulterActiviteEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nb_Visite.Visible = False
        Nb_Visite.Visible = False
        DataGridView_Praticien.Visible = False
        DataGridView_Motif.Visible = False
        myConnection.ConnectionString = GlobalData.ConnexionString ' Chaine de connexion à la base de données
        Try
            myConnection.Open() ' Connexion à la base de données
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la connexion à la base de données : " & ex.Message)
        End Try
        ChargerVisiteur()
    End Sub

    Private Sub Button_Consulter_Click(sender As Object, e As EventArgs) Handles Button_Consulter.Click
        ChargerNbVisite()
        ChargerNbVisiteParPraticien()
        ChargerNbVisiteParMotif()
        Label_Nb_Visite.Visible = True
        Nb_Visite.Visible = True
        DataGridView_Praticien.Visible = True
        DataGridView_Motif.Visible = True
    End Sub
    ' Ouvre la fenêtre de consultation d'activité du visiteur sélectionné lors du clic sur le bouton "Consulter"
    Private Sub DataGridView_Visiteur_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Visiteur.CellContentClick
        Dim f As New ConsulterActiviteVisiteur
        f.MatriculeVisiteur = DataGridView_Visiteur.Rows(e.RowIndex).Cells("Column_MatriculeVisiteur").Value.ToString() ' Enregistre le matricule du visiteur sélectionné dans le paramètre de la fenêtre
        f.Text = "Activité du visiteur " & DataGridView_Visiteur.Rows(e.RowIndex).Cells("Column_Prenom").Value.ToString() & " " & DataGridView_Visiteur.Rows(e.RowIndex).Cells("Column_Nom").Value.ToString()
        f.Show()
    End Sub
    ' Méthode qui charge les visiteurs de l'équipe du délégué
    Private Sub ChargerVisiteur()
        ' Requête SQL pour obtenir les visiteurs associés au délégué
        Dim query As String = "SELECT utilisateur.nom, utilisateur.prenom, utilisateur.matricule
                               FROM utilisateur, visiteur
                               WHERE visiteur.matriculevisiteur = utilisateur.matricule
                               AND visiteur.matriculedelegue = :matricule ;"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue(":matricule", MatriculeDelegue)
        myReader = myCommand.ExecuteReader()
        DataGridView_Visiteur.Rows.Clear()
        ' Boucle de lecture des résultats de la requête et ajout dans le DataGridView
        While myReader.Read()
            DataGridView_Visiteur.Rows.Add(myReader.GetString(0), myReader.GetString(1), "Consulter", myReader.GetString(2))
        End While
        myReader.Close()
    End Sub
    ' Méthode qui charge le nombre total de visites réalisées sur la période donnée
    Private Sub ChargerNbVisite()
        Dim dateDebutStr As String = DateTimePicker_Debut.Value.ToString("dd/MM/yy")
        Dim dateFinStr As String = DateTimePicker_Fin.Value.ToString("dd/MM/yy")

        ' Requête SQL pour obtenir le nombre total de visites
        Dim query As String = "SELECT COUNT(*)
                               FROM visite
                               WHERE datevisite BETWEEN TO_DATE('" & dateDebutStr & "', 'DD/MM/YY')
                                                    AND TO_DATE('" & dateFinStr & "', 'DD/MM/YY')
                               AND idutilisateur IN (SELECT matriculevisiteur
                                                     FROM visiteur
                                                     WHERE matriculedelegue = :matricule);"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue(":matricule", MatriculeDelegue)
        myReader = myCommand.ExecuteReader()
        If myReader.Read() Then
            Label_Nb_Visite.Text = myReader.GetString(0) ' Affichage du nombre de visites
        End If
        myReader.Close()
    End Sub
    ' Méthode pour charger le nombre de visites par praticien
    Public Sub ChargerNbVisiteParPraticien()
        Dim dateDebutStr As String = DateTimePicker_Debut.Value.ToString("dd/MM/yy")
        Dim dateFinStr As String = DateTimePicker_Fin.Value.ToString("dd/MM/yy")

        ' Requête SQL pour obtenir le nombre de visites par praticien
        Dim query As String = "SELECT praticien.nom, COUNT(*)
                               FROM praticien, visite
                               WHERE praticien.id = visite.idpraticien
                               AND datevisite BETWEEN TO_DATE('" & dateDebutStr & "', 'DD/MM/YY')
                                                  AND TO_DATE('" & dateFinStr & "', 'DD/MM/YY')
                               AND idutilisateur IN (SELECT matriculevisiteur
                                                     FROM visiteur
                                                     WHERE matriculedelegue = :matricule)
                               GROUP BY praticien.id, praticien.nom;"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue(":matricule", MatriculeDelegue)
        myReader = myCommand.ExecuteReader()
        DataGridView_Praticien.Rows.Clear()
        ' Boucle de lecture des résultats de la requête et ajout dans le DataGridView
        While myReader.Read()
            DataGridView_Praticien.Rows.Add(myReader.GetString(0), myReader.GetString(1)) ' Remplit le DataGridView avec le nom du praticien et le nombre de visites
        End While
        myReader.Close()
    End Sub
    ' Méthode pour charger le nombre de visites par motif
    Public Sub ChargerNbVisiteParMotif()
        Dim dateDebutStr As String = DateTimePicker_Debut.Value.ToString("dd/MM/yy")
        Dim dateFinStr As String = DateTimePicker_Fin.Value.ToString("dd/MM/yy")
        ' Requête SQL pour obtenir le nombre de visites par motif
        Dim query As String = "SELECT motif.libelle, COUNT(*)
                               FROM motif, visite
                               WHERE motif.id = visite.idmotif
                               AND datevisite BETWEEN TO_DATE('" & dateDebutStr & "', 'DD/MM/YY')
                                                  AND TO_DATE('" & dateFinStr & "', 'DD/MM/YY')
                               AND idutilisateur IN (SELECT matriculevisiteur
                                                     FROM visiteur
                                                     WHERE matriculedelegue = :matricule)
                               GROUP BY motif.id, motif.libelle;"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue(":matricule", MatriculeDelegue)
        myReader = myCommand.ExecuteReader()
        DataGridView_Motif.Rows.Clear()
        ' Boucle de lecture des résultats de la requête et ajout dans le DataGridView
        While myReader.Read()
            DataGridView_Motif.Rows.Add(myReader.GetString(0), myReader.GetString(1)) ' Remplit le DataGridView avec le libellé du motif et le nombre de visites
        End While
        myReader.Close()
    End Sub
End Class