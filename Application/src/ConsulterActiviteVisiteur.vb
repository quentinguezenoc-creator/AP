Public Class ConsulterActiviteVisiteur

    Private Sub ConsulterActiviteVisiteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nb_Visite.Visible = False
        Nb_Visite.Visible = False
        DataGridView_Praticien.Visible = False
        DataGridView_Motif.Visible = False

        DataGridView_Praticien.Rows.Add("LeNoir", 12)
        DataGridView_Motif.Rows.Add("Renouvellement", 7)
        DataGridView_CR.Rows.Add("25012", "12/07/2025", "LeNoir", "Afficher")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label_Nb_Visite.Visible = True
        Nb_Visite.Visible = True
        DataGridView_Praticien.Visible = True
        DataGridView_Motif.Visible = True
    End Sub
End Class