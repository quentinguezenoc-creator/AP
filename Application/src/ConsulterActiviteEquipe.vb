Public Class ConsulterActiviteEquipe

    Private Sub ConsulterActiviteEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nb_Visite.Visible = False
        Nb_Visite.Visible = False
        DataGridView_Praticien.Visible = False
        DataGridView_Motif.Visible = False

        DataGridView_Praticien.Rows.Add("LeNoir", 12)
        DataGridView_Motif.Rows.Add("Renouvellement", 7)
        DataGridView_Visiteur.Rows.Add("Macron", "Manu", "Consulter Activité")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label_Nb_Visite.Visible = True
        Nb_Visite.Visible = True
        DataGridView_Praticien.Visible = True
        DataGridView_Motif.Visible = True
    End Sub
End Class