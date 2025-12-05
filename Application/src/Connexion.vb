Imports System.Data.Common

Public Class Connexion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommandUtil As New Odbc.OdbcCommand
    Dim myCommandMdp As New Odbc.OdbcCommand
    Dim myCommandV As New Odbc.OdbcCommand
    Dim myCommandD As New Odbc.OdbcCommand
    Dim myReaderUtil As Odbc.OdbcDataReader
    Dim myReaderMdp As Odbc.OdbcDataReader
    Dim myReaderV As Odbc.OdbcDataReader
    Dim myReaderD As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_Connexion.Enabled = False
        connString = "DSN=SRVORAGSB;Uid=gestion;Pwd=Iroise29;" ' Chaine de connexion à la base de données
        myConnection.ConnectionString = connString
        Try
            myConnection.Open() ' Connexion à la base de données
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la connexion à la base de données : " & ex.Message)
        End Try
    End Sub

    Private Sub Connexion_Click(sender As Object, e As EventArgs) Handles Button_Connexion.Click
        Dim connString = "DSN=SRVORAGSB;Uid=gestion;Pwd=Iroise29;" ' Chaine de connexion à la base de données
        myConnection.ConnectionString = connString
        Try
            ' Connexion à la base de données
            myConnection.Open()
            ' Requête qui récupère tous les matricules
            Dim queryMat As String = "SELECT matricule FROM Utilisateur;"
            myCommandUtil.Connection = myConnection
            myCommandUtil.CommandText = queryMat
            myReaderUtil = myCommandUtil.ExecuteReader
            ' Boucle de lecture, si le matricule de l'utilisateur existe, on teste son mot de passe
            While myReaderUtil.Read
                If myReaderUtil.GetString(0) = TextBox_Login.Text Then
                    ' Requête qui récupère le mot de passe de l'utilisateur
                    Dim queryMdp As String = "SELECT motDePasse FROM Utilisateur WHERE matricule=@matricule;" ' @matricule pour éviter les injections SQL
                    myCommandMdp.Connection = myConnection
                    myCommandMdp.CommandText = queryMdp
                    myCommandMdp.Parameters.Clear()
                    myCommandMdp.Parameters.AddWithValue("@matricule", TextBox_Login.Text) ' Définition de @matricule ici
                    myReaderMdp = myCommandMdp.ExecuteReader
                    If myReaderMdp.Read() Then ' Positionne le curseur sur la ligne
                        ' Si le mot de passe correspond, on cherche le rôle de l'utilisateur
                        If myReaderMdp.GetString(0) = TextBox_MDP.Text Then
                            ' Requête qui récupère les visiteurs
                            Dim queryV As String = "SELECT matriculeVisiteur FROM Visiteur;"
                            myCommandV.Connection = myConnection
                            myCommandV.CommandText = queryV
                            myReaderV = myCommandV.ExecuteReader
                            If myReaderV.Read() Then ' Positionne le curseur sur la ligne
                                If myReaderV.GetString(0) = TextBox_Login.Text Then
                                    Dim f As New GestionCompte
                                    f.Show()
                                Else
                                    ' Try/Catch pour lever une exception sur la requête de sélection des délégués
                                    Try
                                        ' Requête qui récupère les délégués
                                        Dim queryD As String = "SELECT matriculeDelegue FROM Delegue;"
                                        myCommandD.Connection = myConnection
                                        myCommandD.CommandText = queryD
                                        myReaderD = myCommandD.ExecuteReader
                                    Catch ex As Exception
                                        MessageBox.Show("Erreur dans la requête Délégué : " & ex.Message)
                                    End Try

                                    If myReaderD.Read() Then ' Positionne le curseur sur la ligne
                                        If myReaderD.GetString(0) = TextBox_Login.Text Then ' Si l'utilisateur est un délégué, on ouvre la fenêtre d'accueil des délégués, sinon, on ouvre la fenêtre d'accueil des responsables
                                            ' OUVERTURE DE LA FENETRE DELEGUE
                                            Dim f As New ConsulterActiviteEquipe
                                            f.Show()
                                        Else
                                            ' OUVERTURE DE LA FENETRE RESPONSABLE
                                            Dim f As New ListeEquipe
                                            f.Show()
                                        End If
                                    End If
                                    myReaderD.Close() ' Fermeture du reader Délégué
                                End If
                                myReaderV.Close() ' Fermeture du reader Visiteur
                            End If
                        Else
                            MsgBox("Nom d'utilisateur ou mot de passe incorrect.")
                        End If
                    End If
                    myReaderMdp.Close() ' Fermeture du reader MDP
                End If
            End While
            myReaderUtil.Close() ' Fermeture du reader Utilisateur
        Catch ex As Odbc.OdbcException
            MessageBox.Show("Erreur dans la requête Matricule : " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Login.TextChanged, TextBox_MDP.TextChanged
        If Trim(TextBox_Login.Text) <> "" And Trim(TextBox_MDP.Text) <> "" Then
            Button_Connexion.Enabled = True
        End If
    End Sub
End Class