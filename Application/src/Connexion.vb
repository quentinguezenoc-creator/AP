Imports System.Data.Common

Public Class Connexion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommandUtil As New Odbc.OdbcCommand
    Dim myCommandRole As New Odbc.OdbcCommand
    Dim myCommandV As New Odbc.OdbcCommand
    Dim myCommandD As New Odbc.OdbcCommand
    Dim myReaderUtil As Odbc.OdbcDataReader
    Dim myReaderRole As Odbc.OdbcDataReader
    Dim myReaderV As Odbc.OdbcDataReader
    Dim myReaderD As Odbc.OdbcDataReader
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Text = "Connexion"
        Button_Connexion.Enabled = False
        myConnection.ConnectionString = GlobalData.ConnexionString ' Chaine de connexion à la base de données
        Try
            myConnection.Open() ' Connexion à la base de données
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la connexion à la base de données : " & ex.Message)
        End Try
    End Sub

    Private Sub Connexion_Click(sender As Object, e As EventArgs) Handles Button_Connexion.Click
        Try
            ' Requête qui récupère le nom et le prenom de l'utilisateur dans le base de données
            Dim queryMat As String = "SELECT nom, prenom FROM utilisateur WHERE matricule = :matricule AND motdepasse = :mdp;"
            myCommandUtil.Connection = myConnection
            myCommandUtil.CommandText = queryMat
            myCommandUtil.Parameters.Clear()
            myCommandUtil.Parameters.AddWithValue(":matricule", TextBox_Login.Text) ' Définition de :matricule ici (Text_Login.Text est utilisé en tant que chaîne de caractère)
            myCommandUtil.Parameters.AddWithValue(":mdp", TextBox_MDP.Text) ' Définition de :mdp ici (Text_MDP.Text est utilisé en tant que chaîne de caractère)
            myReaderUtil = myCommandUtil.ExecuteReader

            ' Test si la combinaison matricule/mot de passe est trouvée, si oui, on récupère le rôle de l'utilisateur grâce à la fonction stockée getRole()
            If myReaderUtil.Read() Then
                GlobalData.MatriculeUtilisateurConnecte = TextBox_Login.Text
                ' Requête qui récupère le rôle de l'utilisateur grâce à la fonction stockée getRole()
                Dim queryRole As String = "SELECT getRole(:matricule) AS role FROM dual;"
                myCommandRole.Connection = myConnection
                myCommandRole.CommandText = queryRole
                myCommandRole.Parameters.Clear()
                myCommandRole.Parameters.AddWithValue(":matricule", GlobalData.MatriculeUtilisateurConnecte)
                myReaderRole = myCommandRole.ExecuteReader()

                If myReaderRole.Read() Then
                    If myReaderRole.GetString(0) = "Visiteur" Then
                        ' OUVERTURE DE LA FENETRE VISITEUR
                        Dim f As New GestionCompte
                        f.Text = "Gestion des comptes-rendus de " & myReaderUtil.GetString(1) & " " & myReaderUtil.GetString(0)
                        f.Show()
                    ElseIf myReaderRole.GetString(0) = "Delegue" Then
                        ' OUVERTURE DE LA FENETRE DELEGUE
                        Dim f As New ConsulterActiviteEquipe
                        f.Text = "Activité de l'équipe de " & myReaderUtil.GetString(1) & " " & myReaderUtil.GetString(0)
                        f.MatriculeDelegue = GlobalData.MatriculeUtilisateurConnecte
                        f.Show()
                    Else
                        ' OUVERTURE DE LA FENETRE RESPONSABLE
                        Dim f As New ListeEquipe
                        f.Text = "Liste des équipes de " & myReaderUtil.GetString(1) & " " & myReaderUtil.GetString(0)
                        f.Show()
                    End If
                End If
                myReaderRole.Close() ' Fermeture du reader Rôle
            Else
                MsgBox("Nom d'utilisateur ou mot de passe incorrect.")
            End If
            myReaderUtil.Close() ' Fermeture du reader Utilisateur
        Catch ex As Odbc.OdbcException
            MessageBox.Show("Erreur dans les requêtes : " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Login.TextChanged, TextBox_MDP.TextChanged
        If Trim(TextBox_Login.Text) <> "" And Trim(TextBox_MDP.Text) <> "" Then
            Button_Connexion.Enabled = True
        End If
    End Sub
End Class