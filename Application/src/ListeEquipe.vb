Public Class ListeEquipe
    Private Sub ListeEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ajout de données fictives (Délégué de l'équipe et action)
        DataGridView1.Rows.Add("Jérôme", "Consulter")
        DataGridView1.Rows.Add("Sophie", "Consulter")
    End Sub

    ' Gère le clic sur la grille, en particulier le bouton "Consulter"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Assurez-vous qu'on a cliqué sur une ligne existante
        If e.RowIndex >= 0 Then
            ' Vérifie si la colonne cliquée est bien la colonne "Action" (Column_Action est le nom de la colonne bouton)
            If e.ColumnIndex = DataGridView1.Columns("Column_Action").Index Then

                ' Récupérer le nom du Délégué cliqué
                Dim delegueNom As String = DataGridView1.Rows(e.RowIndex).Cells("Column_Delegue").Value.ToString()

                ' Ouvrir la fenêtre de consultation d'activité d'équipe
                Dim formActiviteEquipe As New ConsulterActiviteEquipe()

                ' Optionnel: Si vous souhaitez personnaliser le titre (ex: "Activité de l'équipe de Jérôme")
                formActiviteEquipe.Text = "Activité de l'équipe de " & delegueNom

                formActiviteEquipe.Show()
            End If
        End If
    End Sub
End Class