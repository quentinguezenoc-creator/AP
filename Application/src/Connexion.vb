Imports System.Data.Common

Public Class Connexion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Connexion_Click(sender As Object, e As EventArgs) Handles Button_Connexion.Click
        connString = "DSN=SRVORAGSB;Uid=gestion;Pwd=Iroise29;" ' Chaine de connexion à la base de données
        myConnection.ConnectionString = connString
        Try
            ' Connexion à la base de données
            myConnection.Open()
            ' Requête qui récupère tous les matricules
            Dim queryMat As String = "SELECT matricule FROM Utilisateur;"
            myCommand.Connection = myConnection
            myCommand.CommandText = queryMat
            myReader = myCommand.ExecuteReader
            ' Boucle de lecture, si le matricule de l'utilisateur existe, on teste son mot de passe
            While myReader.Read
                If myReader.GetString(0) = TextBox_Login.Text Then
                    ' Requête qui récupère le mot de passe de l'utilisateur
                    Dim queryMdp As String = "SELECT motDePasse FROM Utilisateur WHERE matricule=@matricule;" ' @matricule pour éviter les injections SQL
                    myCommand.Connection = myConnection
                    myCommand.CommandText = queryMdp
                    myCommand.Parameters.Clear()
                    myCommand.Parameters.AddWithValue("@matricule", TextBox_Login.Text) ' Définition de @matricule ici
                    myReader = myCommand.ExecuteReader
                    If myReader.Read() Then ' Positionne le curseur sur la ligne
                        ' Si le mot de passe correspond, on cherche le rôle de l'utilisateur
                        If myReader.GetString(0) = TextBox_MDP.Text Then
                            ' Requête qui récupère les visiteurs
                            Dim queryV As String = "SELECT matriculeVisiteur FROM Visiteur;"
                            myCommand.Connection = myConnection
                            myCommand.CommandText = queryV
                            myReader = myCommand.ExecuteReader
                            If myReader.Read() Then ' Positionne le curseur sur la ligne
                                If myReader.GetString(0) = TextBox_Login.Text Then
                                    ' OUVERTURE DE LA FENETRE VISITEUR
                                    Dim f As New GestionCompte
                                    f.Show()
                                Else
                                    ' Requête qui récupère les délégués
                                    Dim queryD As String = "SELECT matriculeDelegue FROM Delegue;"
                                    myCommand.Connection = myConnection
                                    myCommand.CommandText = queryD
                                    myReader = myCommand.ExecuteReader
                                    If myReader.Read() Then
                                        If myReader.GetString(0) = TextBox_Login.Text Then
                                            ' OUVERTURE DE LA FENETRE DELEGUE
                                            Dim f As New ConsulterActiviteEquipe
                                            f.Show()
                                        Else
                                            ' OUVERTURE DE LA FENETRE RESPONSABLE
                                            Dim f As New ListeEquipe
                                            f.Show()
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            ' MESSAGE D'ERREUR MOT DE PASSE INCORRECT
                        End If
                    End If
                    ' MESSAGE D'ERREUR PAS DE MATRICULE CORRESPONDANT
                End If
            End While

        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class