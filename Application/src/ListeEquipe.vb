Public Class ListeEquipe
    Private Sub ListeEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("Jérôme", "Consulter")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim fenetre As New ConsulterActiviteEquipe
        fenetre.Show()
    End Sub
End Class