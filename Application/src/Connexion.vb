Imports System.Data.Common

Public Class Connexion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommandUtil As New Odbc.OdbcCommand
    Dim myCommandV As New Odbc.OdbcCommand
    Dim myCommandD As New Odbc.OdbcCommand
    Dim myReaderUtil As Odbc.OdbcDataReader
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

            ' Test si la combinaison matricule/mot de passe est trouvée, si oui, on cherche le rôle de l'utilisateur
            If myReaderUtil.Read() Then
                GlobalData.MatriculeUtilisateurConnecte = TextBox_Login.Text

                ' Requête qui cherche si l'utilisateur est un visiteur
                Dim queryV As String = "SELECT matriculevisiteur
                                        FROM visiteur
                                        WHERE matriculevisiteur = '" & GlobalData.MatriculeUtilisateurConnecte & "';"
                myCommandV.Connection = myConnection
                myCommandV.CommandText = queryV
                myReaderV = myCommandV.ExecuteReader

                If myReaderV.Read() Then ' Positionne le curseur sur la ligne
                    ' OUVERTURE DE LA FENETRE VISITEUR
                    Dim f As New GestionCompte
                    f.Text = "Gestion des comptes-rendus de " & myReaderUtil.GetString(1) & " " & myReaderUtil.GetString(0)
                    f.Show()
                Else
                    ' Requête qui cherche si l'utilisateur est un délégué
                    Dim queryD As String = "SELECT matriculedelegue 
                                            FROM delegue
                                            WHERE delegue.matriculedelegue = '" & GlobalData.MatriculeUtilisateurConnecte & "';"
                    myCommandD.Connection = myConnection
                    myCommandD.CommandText = queryD
                    myReaderD = myCommandD.ExecuteReader

                    If myReaderD.Read() Then ' Positionne le curseur sur la ligne
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
                    myReaderD.Close() ' Fermeture du reader Délégué
                End If
                myReaderV.Close() ' Fermeture du reader Visiteur
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