Imports System.Data.Odbc

Public Class ConsulterActiviteVisiteur
    Public MatriculeVisiteur As String
    Private Sub ConsulterActiviteVisiteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nb_Visite.Visible = False
        Nb_Visite.Visible = False
        DataGridView_Praticien.Visible = False
        DataGridView_Motif.Visible = False
    End Sub

    Private Sub Button_Consulter_Click(sender As Object, e As EventArgs) Handles Button_Consulter.Click
        Label_Nb_Visite.Visible = True
        Nb_Visite.Visible = True
        DataGridView_Praticien.Visible = True
        DataGridView_Motif.Visible = True

        Dim query = "SELECT praticien.nom, COUNT(*)
                     FROM praticien, visite
                     WHERE praticien.id = visite.idpraticien
                     AND visite.idutilisateur = :matricule
                     AND visite.datevisite BETWEEN :dateDebut AND :dateFin
                     GROUP BY praticien.id, praticien.nom;"

        Dim myConnection As New Odbc.OdbcConnection(GlobalData.ConnexionString)
        Dim myCommand As New Odbc.OdbcCommand

        Try
            myConnection.Open()
            myCommand.Connection = myConnection
            myCommand.CommandText = query
            myCommand.Parameters.Clear()
            myCommand.Parameters.AddWithValue(":matricule", MatriculeVisiteur)
            myCommand.Parameters.AddWithValue(":dateDebut", DateTimePicker_Debut)
            myCommand.Parameters.AddWithValue(":dateFin", DateTimePicker_Fin)

            Dim myReader As OdbcDataReader = myCommand.ExecuteReader()
            DataGridView_Praticien.Rows.Clear()

            While myReader.Read()
                DataGridView_Praticien.Rows.Add(myReader.GetString(0), myReader.GetString(1))
            End While

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView_CR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_CR.CellContentClick
        Dim f As New ConsulterCompteRendu
        f.Show()
    End Sub
End Class