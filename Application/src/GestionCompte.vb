Imports System.ComponentModel
Imports System.Data.Common
Imports System.Data.Odbc

Public Class GestionCompte
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As OdbcDataReader
    Dim myCommandProduits As New Odbc.OdbcCommand
    Dim myReaderProduits As OdbcDataReader
    Dim mode As String = "C" ' Variable pour différencier les modes de création et de modification
    Dim idCompteRendu As Integer ' Variable pour stocker l'id du compte-rendu en cours de modification
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompteRendu()
        LoadProduits()
        LoadPraticiens()
        LoadMotifs()
    End Sub

    ' Méthode qui charge la liste des comptes-rendus du visiteur
    Private Sub LoadCompteRendu()
        Dim query As String = "SELECT visite.id, praticien.nom, visite.datevisite
                               FROM visite, praticien
                               WHERE visite.idpraticien = praticien.id
                               AND visite.idutilisateur = :matricule ;"
        myCommand.Connection = GlobalData.myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue(":matricule", GlobalData.MatriculeUtilisateurConnecte)
        myReader = myCommand.ExecuteReader()
        ' Boucle de lecture des résultats de la requête et ajout dans le DataGridView
        While myReader.Read()
            DataGridView_CR.Rows.Add(myReader.GetString(0), myReader.GetString(1), myReader.GetDateTime(2).ToString("dd/MM/yyyy"), "Modifier", "Voir")
        End While
        myReader.Close()
        DataGridView_CR.ReadOnly = True
    End Sub

    'Méthode qui charge la liste des produits enregistrés
    Private Sub LoadProduits()
        Dim query As String = "SELECT produit.code, produit.libelle
                               FROM produit;"
        myCommand.Connection = GlobalData.myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myReader = myCommand.ExecuteReader()
        Dim produits As New DataTable()
        produits.Columns.Add("Id", GetType(Integer))
        produits.Columns.Add("Libelle", GetType(String))
        ' Boucle de lecture des résultats de la requête
        While myReader.Read()
            produits.Rows.Add(myReader.GetInt32(0), myReader.GetString(1))
        End While
        myReader.Close()
        ' Récupère la colonne des produits pour remplir la ComboBox
        Dim comboCol As DataGridViewComboBoxColumn = CType(DataGridView_Produits.Columns("Column_Produit"), DataGridViewComboBoxColumn)
        ' Remplissage de la ComboBox
        comboCol.DataSource = produits
        comboCol.DisplayMember = "Libelle"
        comboCol.ValueMember = "Id"
    End Sub

    ' Méthode qui charge la liste des praticiens enregistrés
    Private Sub LoadPraticiens()
        Dim query As String = "SELECT praticien.id, praticien.nom
                               FROM praticien;"
        myCommand.Connection = GlobalData.myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myReader = myCommand.ExecuteReader()
        Dim praticiens As New DataTable()
        praticiens.Columns.Add("Id", GetType(Integer))
        praticiens.Columns.Add("Nom", GetType(String))
        ' Boucle de lecture des résultats de la requête
        While myReader.Read()
            praticiens.Rows.Add(myReader.GetString(0), myReader.GetString(1))
        End While
        myReader.Close()
        ComboBox_Praticien.DataSource = praticiens
        ComboBox_Praticien.DisplayMember = "Nom"
        ComboBox_Praticien.ValueMember = "Id"
    End Sub

    ' Méthode qui charge les motifs
    Private Sub LoadMotifs()
        Dim query As String = "SELECT motif.id, motif.libelle
                               FROM motif;"
        myCommand.Connection = GlobalData.myConnection
        myCommand.CommandText = query
        myCommand.Parameters.Clear()
        myReader = myCommand.ExecuteReader()
        Dim motifs As New DataTable()
        motifs.Columns.Add("Id", GetType(Integer))
        motifs.Columns.Add("Nom", GetType(String))
        ' Boucle de lecture des résultats de la requête
        While myReader.Read()
            motifs.Rows.Add(myReader.GetString(0), myReader.GetString(1))
        End While
        myReader.Close()
        ComboBoxMotif.DataSource = motifs
        ComboBoxMotif.DisplayMember = "Nom"
        ComboBoxMotif.ValueMember = "Id"
    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        Dim transaction = GlobalData.myConnection.BeginTransaction()
        myCommand.Transaction = transaction
        Try
            If mode = "C" Then
                ' Insertion dans la table visite avec récupération de l'id généré
                Dim query As String = "INSERT INTO visite (idpraticien, idutilisateur, idmotif, datevisite, bilan)
                                   VALUES (:idPraticien, :matricule, :idMotif, :dateVisite, :bilan)"
                myCommand.Connection = GlobalData.myConnection
                myCommand.CommandText = query
                myCommand.Parameters.Clear()
                myCommand.Parameters.Add(":idPraticien", OdbcType.Int).Value = Convert.ToInt32(ComboBox_Praticien.SelectedValue)
                myCommand.Parameters.Add(":matricule", OdbcType.VarChar).Value = GlobalData.MatriculeUtilisateurConnecte.ToString()
                myCommand.Parameters.Add(":idMotif", OdbcType.Int).Value = Convert.ToInt32(ComboBoxMotif.SelectedValue)
                myCommand.Parameters.Add(":dateVisite", OdbcType.Date).Value = DateTimeVisite.Value
                myCommand.Parameters.Add(":bilan", OdbcType.VarChar).Value = TextBox_Bilan.Text
                myCommand.ExecuteNonQuery()

                myCommand.CommandText = "SELECT MAX(id) FROM visite"
                idCompteRendu = Convert.ToInt32(myCommand.ExecuteScalar())

                query = "INSERT INTO echantillon (idvisite, codeproduit, quantite)
                     VALUES (:idVisite, :codeProduit, :quantite)"
                myCommand.CommandText = query

                For Each row As DataGridViewRow In DataGridView_Produits.Rows
                    If Not row.IsNewRow Then
                        myCommand.Parameters.Clear()
                        myCommand.Parameters.Add(":idVisite", OdbcType.Int).Value = idCompteRendu
                        myCommand.Parameters.Add(":codeProduit", OdbcType.VarChar).Value = row.Cells("Column_Produit").Value.ToString()
                        myCommand.Parameters.Add(":quantite", OdbcType.Int).Value = Convert.ToInt32(row.Cells("Column_Echantillon").Value)
                        myCommand.ExecuteNonQuery()
                    End If
                Next

                MsgBox("Enregistrement terminé.")

                DataGridView_CR.Rows.Add(idCompteRendu, ComboBox_Praticien.Text, DateTimeVisite.Value.ToString("dd/MM/yyyy"), "Modifier", "Voir")
            ElseIf mode = "M" Then
                ' Modification de la table visite
                Dim query As String = "UPDATE visite
                                       SET idpraticien = :idPraticien,
                                           idutilisateur = :matricule,
                                           idmotif = :idMotif,
                                           datevisite = :dateVisite,
                                           bilan = :bilan
                                       WHERE id = :id"
                myCommand.Connection = GlobalData.myConnection
                myCommand.CommandText = query
                myCommand.Parameters.Clear()
                myCommand.Parameters.Add(":idPraticien", OdbcType.Int).Value = Convert.ToInt32(ComboBox_Praticien.SelectedValue)
                myCommand.Parameters.Add(":matricule", OdbcType.VarChar).Value = GlobalData.MatriculeUtilisateurConnecte.ToString()
                myCommand.Parameters.Add(":idMotif", OdbcType.Int).Value = Convert.ToInt32(ComboBoxMotif.SelectedValue)
                myCommand.Parameters.Add(":dateVisite", OdbcType.Date).Value = DateTimeVisite.Value
                myCommand.Parameters.Add(":bilan", OdbcType.VarChar).Value = TextBox_Bilan.Text
                myCommand.Parameters.Add(":id", OdbcType.Int).Value = idCompteRendu
                myCommand.ExecuteNonQuery()

                ' Suppresion de la table echantillon pour faire les nouvelles insertions
                query = "DELETE FROM echantillon
                         WHERE idvisite = :id"
                myCommand.CommandText = query
                myCommand.Parameters.Clear()
                myCommand.Parameters.Add(":id", OdbcType.Int).Value = idCompteRendu
                myCommand.ExecuteNonQuery()

                query = "INSERT INTO echantillon (idvisite, codeproduit, quantite)
                     VALUES (:idVisite, :codeProduit, :quantite)"
                myCommand.CommandText = query
                For Each row As DataGridViewRow In DataGridView_Produits.Rows
                    If Not row.IsNewRow Then
                        myCommand.Parameters.Clear()
                        myCommand.Parameters.Add(":idVisite", OdbcType.Int).Value = idCompteRendu
                        myCommand.Parameters.Add(":codeProduit", OdbcType.VarChar).Value = row.Cells("Column_Produit").Value.ToString()
                        myCommand.Parameters.Add(":quantite", OdbcType.Int).Value = Convert.ToInt32(row.Cells("Column_Echantillon").Value)
                        myCommand.ExecuteNonQuery()
                    End If
                Next

                MsgBox("Mise à jour terminée.")

                LoadCompteRendu() ' Recharge la liste des comptes-rendus pour refléter les modifications
            End If
            transaction.Commit()
            ResetForm()
            mode = "C"
            idCompteRendu = 0
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    ' Méthode qui permet de gérer la modification d'un compte-rendu lors du clic sur le bouton "Modifier" dans le DataGridView
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_CR.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView_CR.Columns("Column_Modifier").Index Then
            Dim row As DataGridViewRow = DataGridView_CR.Rows(e.RowIndex)

            idCompteRendu = Convert.ToInt32(row.Cells("Column_Id").Value)

            Dim query As String = "SELECT idpraticien, idmotif, datevisite, bilan
                                   FROM visite
                                   WHERE id = :idCompteRendu"
            myCommand.Connection = GlobalData.myConnection
            myCommand.CommandText = query
            myCommand.Parameters.Clear()
            myCommand.Parameters.Add(":idCompteRendu", OdbcType.Int).Value = idCompteRendu
            myReader = myCommand.ExecuteReader()

            If myReader.Read() Then
                ComboBox_Praticien.SelectedValue = myReader.GetInt32(0)
                ComboBoxMotif.SelectedValue = myReader.GetInt32(1)
                DateTimeVisite.Value = myReader.GetDateTime(2)
                TextBox_Bilan.Text = myReader.GetString(3)
            End If

            myReader.Close()

            Dim queryEchantillon As String = "SELECT codeproduit, quantite
                                              FROM echantillon
                                              WHERE idvisite = :idCompteRendu"
            myCommandProduits.Connection = GlobalData.myConnection
            myCommandProduits.CommandText = queryEchantillon
            myCommandProduits.Parameters.Clear()
            myCommandProduits.Parameters.Add(":idCompteRendu", OdbcType.Int).Value = idCompteRendu
            myReaderProduits = myCommandProduits.ExecuteReader()

            DataGridView_Produits.Rows.Clear()
            LoadProduits()

            While myReaderProduits.Read()
                Dim rowIndex As Integer = DataGridView_Produits.Rows.Add()
                ' Sélection de la valeur dans la ComboBox (IMPORTANT)
                DataGridView_Produits.Rows(rowIndex).Cells("Column_Produit").Value = myReaderProduits.GetInt32(0)
                ' Quantité
                DataGridView_Produits.Rows(rowIndex).Cells("Column_Echantillon").Value = myReaderProduits.GetInt32(1)
            End While

            myReaderProduits.Close()

            mode = "M"
        ElseIf e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView_CR.Columns("Column_Voir").Index Then
            Dim row As DataGridViewRow = DataGridView_CR.Rows(e.RowIndex)
            Dim idCR As Integer = Convert.ToInt32(row.Cells("Column_Id").Value)
            Dim f As New ConsulterCompteRendu()
            f.numeroCR = idCR
            f.Show()
        End If
    End Sub

    Private Sub ResetForm()
        ComboBox_Praticien.SelectedIndex = 0
        DateTimeVisite.Value = DateTime.Now
        ComboBoxMotif.SelectedIndex = 0
        TextBox_Bilan.Clear()
        DataGridView_Produits.Rows.Clear()
    End Sub

    Private Sub ButtonEffacer_Click(sender As Object, e As EventArgs) Handles ButtonEffacer.Click
        ResetForm()
    End Sub
End Class