Public Class ListeEquipe
    Private Sub ListeEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ajout de données fictives (Délégué de l'équipe et action)
        DataGridView1.Rows.Add("Jérôme", "Consulter")
        DataGridView1.Rows.Add("Sophie", "Consulter")
    End Sub

End Class