Imports System.Data.Odbc
Imports System.Data

Public Class ListeEquipe
    Private Sub ListeEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerDelegues()
    End Sub

    Private Sub ChargerDelegues()
        ' Utilisation du matricule du Responsable connecté
        Dim matriculeResponsable As String = GlobalData.MatriculeUtilisateurConnecte

        If String.IsNullOrWhiteSpace(matriculeResponsable) Then
            MessageBox.Show("Erreur : Matricule du Responsable non trouvé. Veuillez vous reconnecter.")
            Return
        End If

        Dim myConnection As New Odbc.OdbcConnection(GlobalData.ConnexionString)
        Dim myCommand As New Odbc.OdbcCommand

        ' Requête SQL pour obtenir la liste des délégués sous la responsabilité du Responsable
        ' ASSUMPTION: La table Delegue contient une colonne matriculeResponsable
        ' On joint Utilisateur pour obtenir Nom et Prénom
        Dim query As String = "SELECT T2.nom, T2.prenom, T1.matriculeDelegue " &
                              "FROM Delegue T1 " &
                              "JOIN Utilisateur T2 ON T1.matriculeDelegue = T2.matricule " &
                              "WHERE T1.matriculeResponsable = :matricule"

        Try
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = query
            myCommand.Parameters.Clear()
            myCommand.Parameters.AddWithValue(":matricule", matriculeResponsable)

            Dim myReader As OdbcDataReader = myCommand.ExecuteReader()
            DataGridView_Delegue.Rows.Clear()

            While myReader.Read()
                ' Colonne 0 (Nom et Prénom du délégué), Colonne 1 (Bouton Action), Colonne 2 (MatriculeDelegue)
                DataGridView_Delegue.Rows.Add(myReader.GetString(1) & " " & myReader.GetString(0), "Consulter", myReader.GetString(2))
            End While

            myReader.Close()
            myConnection.Close()

        Catch ex As OdbcException
            MessageBox.Show("Erreur Oracle lors du chargement des délégués : " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Delegue.CellContentClick
        If e.RowIndex >= 0 Then
            ' Vérifie si la colonne cliquée est la colonne "Action" (Column_Action)
            If e.ColumnIndex = DataGridView_Delegue.Columns("Column_Action").Index Then

                ' Récupère le matricule du délégué dans la colonne cachée (index 2)
                Dim delegueMatricule As String = DataGridView_Delegue.Rows(e.RowIndex).Cells(2).Value.ToString()
                Dim delegueNom As String = DataGridView_Delegue.Rows(e.RowIndex).Cells("Column_Delegue").Value.ToString()

                ' Ouvre la fenêtre de consultation d'activité d'équipe
                Dim formActiviteEquipe As New ConsulterActiviteEquipe()

                ' NOTE : Il faut ajouter une propriété publique 'MatriculeDelegue' à ConsulterActiviteEquipe.vb
                ' pour lui transmettre le matricule.
                formActiviteEquipe.MatriculeDelegue = delegueMatricule

                formActiviteEquipe.Text = "Activité de l'équipe de " & delegueNom

                formActiviteEquipe.Show()
            End If
        End If
    End Sub
End Class