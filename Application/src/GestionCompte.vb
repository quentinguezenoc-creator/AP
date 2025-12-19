Public Class GestionCompte
    Private compteurId As Integer = 1
    Private modeEdition As Boolean = False
    Private ligneEnCours As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialiser le DataGridView
        InitialiserDataGridView()

        'Configuration des colonnes
        DataGridViewComptesRendus.Columns.Clear()
        DataGridViewComptesRendus.Columns.Add("Id", "Id")
        DataGridViewComptesRendus.Columns.Add("Praticien", "Praticien")
        DataGridViewComptesRendus.Columns.Add("DateVisite", "Date de la visite")

        'Colonnes cachées pour les détails du comptes-rendu
        DataGridViewComptesRendus.Columns.Add("Motif", "Motif")
        DataGridViewComptesRendus.Columns("Motif").Visible = False ' Cacher cette colonne")
        DataGridViewComptesRendus.Columns.Add("MotifDetail", "Détail du Motif")
        DataGridViewComptesRendus.Columns("MotifDetail").Visible = False ' Cacher cette colonne
        DataGridViewComptesRendus.Columns.Add("Bilan", "Bilan")
        DataGridViewComptesRendus.Columns("Bilan").Visible = False ' Cacher cette colonne
        DataGridViewComptesRendus.Columns.Add("Echantillons", "Échantillons/Produits")
        DataGridViewComptesRendus.Columns("Echantillons").Visible = False ' Cacher cette colonne

        'Ajouter la colonne Modifier (bouton)

        Dim btnModifier As New DataGridViewButtonColumn()
        btnModifier.HeaderText = "Modifier"
        btnModifier.Text = "Modifier"
        btnModifier.UseColumnTextForButtonValue = True
        btnModifier.Name = "Modifier"
        DataGridViewComptesRendus.Columns.Add(btnModifier)

        'Ajouter la colonne Voir (bouton)
        Dim btnVoir As New DataGridViewButtonColumn()
        btnVoir.HeaderText = "Voir"
        btnVoir.Text = "Voir"
        btnVoir.UseColumnTextForButtonValue = True
        btnVoir.Name = "Voir"
        DataGridViewComptesRendus.Columns.Add(btnVoir)

        ' Ajuster la largeur des colonnes
        DataGridViewComptesRendus.Columns("Id").Width = 50
        DataGridViewComptesRendus.Columns("Praticien").Width = 150
        DataGridViewComptesRendus.Columns("DateVisite").Width = 120

        ' Ajouter une ligne par défaut
        DataGridViewComptesRendus.Rows.Add(1, "Dr. John Docteur", "10/10/2025", "Suivi", "", "Bilan par défaut", "")

        ' Incrémenter le compteur pour la prochaine ligne
        compteurId = 2

    End Sub

    Private Sub InitialiserDataGridView()
        ' Configuration des colonnes
        DataGridViewComptesRendus.Columns.Clear()
        DataGridViewComptesRendus.Columns.Add("Id", "Id")
        DataGridViewComptesRendus.Columns.Add("Praticien", "Praticien")
        DataGridViewComptesRendus.Columns.Add("DateVisite", "Date de la visite")

        ' Colonne caché pour le Bilan (si nécessaire)
        DataGridViewComptesRendus.Columns.Add("Bilan", "Bilan")
        DataGridViewComptesRendus.Columns("Bilan").Visible = False ' Cacher cette colonne


        ' Ajouter la colonne Modifier (bouton)
        Dim btnModifier As New DataGridViewButtonColumn()
        btnModifier.HeaderText = "Modifier"
        btnModifier.Text = "Modifier"
        btnModifier.UseColumnTextForButtonValue = True
        btnModifier.Name = "Modifier"
        DataGridViewComptesRendus.Columns.Add(btnModifier)

        ' Ajouter la colonne Voir (bouton)
        Dim btnVoir As New DataGridViewButtonColumn()
        btnVoir.HeaderText = "Voir"
        btnVoir.Text = "Voir"
        btnVoir.UseColumnTextForButtonValue = True
        btnVoir.Name = "Voir"
        DataGridViewComptesRendus.Columns.Add(btnVoir)

        ' Ajuster la largeur des colonnes
        DataGridViewComptesRendus.Columns("Id").Width = 50
        DataGridViewComptesRendus.Columns("Praticien").Width = 150
        DataGridViewComptesRendus.Columns("DateVisite").Width = 120

        ' Ajouter une ligne par défaut
        DataGridViewComptesRendus.Rows.Add(1, "Dr. John Docteur", "10/10/2025")

        ' Incrémenter le compteur pour la prochaine ligne
        compteurId = 2
    End Sub

    Private Sub CacherPanelModification()
        ' Cacher tous les contrôles du panel de droite
        ComboBoxPraticien.Visible = False
        DateTimeVisite.Visible = False
        ComboBoxMotif.Visible = False
        TextBoxAutreMotif.Visible = False
        Bilan_visite.Visible = False
        ButtonValider.Visible = False

        ' Cacher les labels spécifiques
        Praticien.Visible = False
        Date_de_Visite.Visible = False
        Motif_visite.Visible = False
        Bilan.Visible = False
    End Sub

    Private Sub AfficherPanelModification()
        ' Afficher tous les contrôles du panel de droite
        ComboBoxPraticien.Visible = True
        DateTimeVisite.Visible = True
        ComboBoxMotif.Visible = True
        Bilan_visite.Visible = True
        ButtonValider.Visible = True

        ' Afficher les labels spécifiques
        Praticien.Visible = True
        Date_de_Visite.Visible = True
        Motif_visite.Visible = True
        Bilan.Visible = True
    End Sub

    Private Sub ViderChamps()
        ComboBoxPraticien.SelectedIndex = -1
        DateTimeVisite.Value = DateTime.Now
        ComboBoxMotif.SelectedIndex = -1
        TextBoxAutreMotif.Text = "Preciser le motif"
        TextBoxAutreMotif.Visible = False
        Bilan_visite.Text = "Saisir le bilan . . ."

        'Vider le DataGridView des échantillons/produits
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub AjouterCompteRendu_Click(sender As Object, e As EventArgs) Handles AjouterCompteRendu.Click
        modeEdition = False
        ligneEnCours = -1
        ViderChamps()
        AfficherPanelModification()
    End Sub

    Private Sub DataGridViewComptesRendus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewComptesRendus.CellContentClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = DataGridViewComptesRendus.Rows(e.RowIndex)
            ' Vérifier si on a cliqué sur le bouton Modifier
            If e.ColumnIndex = DataGridViewComptesRendus.Columns("Modifier").Index Then
                modeEdition = True
                ligneEnCours = e.RowIndex

                ' Remplir les champs avec les données de la ligne sélectionnée
                ComboBoxPraticien.SelectedItem = row.Cells("Praticien").Value.ToString()
                DateTimeVisite.Value = Convert.ToDateTime(row.Cells("DateVisite").Value)
                Bilan_visite.Text = row.Cells("Bilan").Value.ToString()

                'Charger le motif et son détail
                Dim motif As String = row.Cells("Motif").Value.ToString()
                ComboBoxMotif.SelectedItem = motif
                If motif = "Autre" Then
                    TextBoxAutreMotif.Text = row.Cells("MotifDetail").Value.ToString()
                    TextBoxAutreMotif.Visible = True
                Else
                    TextBoxAutreMotif.Visible = False
                End If


                'Charger les produits/échantillons

                DeserializeProductsSamples(row.Cells("ProduitEchantillons").Value.ToString())

                AfficherPanelModification()

            End If

            ' Bouton Voir
            If e.ColumnIndex = DataGridViewComptesRendus.Columns("Voir").Index Then
                Dim praticien As String = row.Cells("Praticien").Value.ToString()
                Dim dateVisite As String = row.Cells("DateVisite").Value.ToString()
                Dim motif As String = row.Cells("Motif").Value.ToString()
                Dim motifdetail As String = row.Cells("MotifDetail").Value.ToString()
                Dim bilan As String = row.Cells("Bilan").Value.ToString()
                Dim produitsEchantillons As String = row.Cells("ProduitsEchantillons").Value.ToString()

                Dim formConsulter As New ConsulterCompteRendu()

                formConsulter.numeroCR = Convert.ToInt32(row.Cells("Id").Value)

                formConsulter.Show()


            End If

        End If



        'Implémentation du bouton Voir
        If e.ColumnIndex = DataGridViewComptesRendus.Columns("Voir").Index Then
            'Création instance de la fenêtre de consultation
            Dim formConsulter As New ConsulterCompteRendu()

            'Transmission des données à la fenêtre de consultation
            formConsulter.numeroCR = Convert.ToInt32(DataGridViewComptesRendus.Rows(e.RowIndex).Cells("Column_Id").Value)

            'Afficher la fenêtre de consultation
            formConsulter.ShowDialog()
        End If

    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        ' Validation des champs
        If ComboBoxPraticien.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez sélectionner un praticien.")
            Return
        End If

        If ComboBoxMotif.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez sélectionner un motif.")
            Return
        End If

        If ComboBoxMotif.SelectedItem IsNot Nothing AndAlso ComboBoxMotif.SelectedItem.ToString() = "Autre" _
           AndAlso String.IsNullOrWhiteSpace(TextBoxAutreMotif.Text) Then
            MessageBox.Show("Veuillez préciser le motif de la visite.")
            Return
        End If

        'Recuperer toutes les données
        Dim selectedMotif As String = ComboBoxMotif.SelectedItem.ToString()
        Dim autreMotifDetail As String = If(selectedMotif = "Autre", TextBoxAutreMotif.Text, String.Empty)
        Dim serializedProducts As String = SerializeDataGridView()


        If modeEdition Then
            ' Modifier la ligne existante
            Dim row As DataGridViewRow = DataGridViewComptesRendus.Rows(ligneEnCours)
            row.Cells("Praticien").Value = ComboBoxPraticien.SelectedItem.ToString()
            row.Cells("DateVisite").Value = DateTimeVisite.Value.ToString("dd/MM/yyyy")

            MessageBox.Show("Compte-rendu modifié avec succès!")
        Else
            ' Ajouter une nouvelle ligne
            DataGridViewComptesRendus.Rows.Add(
                compteurId,
                ComboBoxPraticien.SelectedItem.ToString(),
                DateTimeVisite.Value.ToString("dd/MM/yyyy"),
                Bilan_visite.Text,
                selectedMotif,
                autreMotifDetail,
                Bilan_visite.Text,
                serializedProducts
            )

            compteurId += 1
            MessageBox.Show("Compte-rendu ajouté avec succès!")
        End If

        ' Cacher le panel et réinitialiser
        CacherPanelModification()
        ViderChamps()
        modeEdition = False
        ligneEnCours = -1
    End Sub

    Private Sub ComboBoxMotif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMotif.SelectedIndexChanged
        If ComboBoxMotif.SelectedItem IsNot Nothing AndAlso ComboBoxMotif.SelectedItem.ToString() = "Autre" Then
            TextBoxAutreMotif.Visible = True
        Else
            TextBoxAutreMotif.Visible = False
            TextBoxAutreMotif.Text = String.Empty
        End If
    End Sub

    'Fonction pour serialiser les données du datagridview
    Private Function SerializeDataGridView() As String
        Dim serializedData As New System.Text.StringBuilder()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow AndAlso row.Cells("Column_Produit").Value IsNot Nothing Then
                'on recupere les valeurs des cellules de la ligne
                Dim produit As String = row.Cells("Column_Produit").Value.ToString()
                Dim echantillion As String = row.Cells("Column_Qte").Value.ToString()
                'format simple : Produit:Quantité;
                serializedData.AppendFormat("{0}|{1};", produit, echantillion)
            End If
        Next
        If serializedData.Length > 0 Then
            'Supprimer le dernier point-virgule
            serializedData.Length -= 1
        End If
        Return serializedData.ToString()
    End Function

    'fonction pour deserialiser les données et remplir le datagridview
    Private Sub DeserializeProductsSamples(ByVal data As String)
        DataGridView1.Rows.Clear()
        If Not String.IsNullOrWhiteSpace(data) Then
            Dim items() As String = data.Split(";"c)
            For Each item As String In items
                Dim parts() As String = item.Split("|"c)
                If parts.Length = 2 Then
                    DataGridView1.Rows.Add(parts(0), parts(1))
                End If
            Next
        End If
    End Sub


    ' Gestionnaires d'événements vides (conservés pour compatibilité)
    Private Sub Date_de_Visite_Click(sender As Object, e As EventArgs) Handles Date_de_Visite.Click
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPraticien.SelectedIndexChanged
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeVisite.ValueChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBoxAutreMotif_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAutreMotif.TextChanged
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Bilan_visite.TextChanged
    End Sub

    Private Sub _ValueChanged(sender As Object, e As EventArgs)
    End Sub

    ' Gestionnaires d'événements pour les labels
    Private Sub Praticien_Click(sender As Object, e As EventArgs) Handles Praticien.Click
    End Sub

    Private Sub qte_echantillion_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Produit_presente_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Motif_visite_Click(sender As Object, e As EventArgs) Handles Motif_visite.Click
    End Sub

    Private Sub Bilan_Click(sender As Object, e As EventArgs) Handles Bilan.Click
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class