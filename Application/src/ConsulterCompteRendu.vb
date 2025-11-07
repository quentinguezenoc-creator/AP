Public Class ConsulterCompteRendu

    Private Sub ConsulterCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Martin Solveig"
        Label5.Text = "Hier"
        Label7.Text = "Balade"
        TextBox1.Text = "On a fait de la musique"
        TextBox1.Enabled = False
        DataGridView1.Rows.Add("Alcool", "100")
    End Sub
End Class