Public Class GestionCompteRendu
    Private compteurId As Integer = 1
    Private modeEdition As Boolean = False
    Private ligneEnCours As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialiser le DataGridView
        InitialiserDataGridView()

        ' Remplir la ComboBox des praticiens
        ComboBoxPraticien.Items.AddRange(New String() {
            "Dr. John Docteur",
            "Dr. Claire Martin",
            "Dr. Julien Dupont",
            "Dr. Sophie Leroy",
            "Dr. Antoine Bernard"
        })

        ' Remplir la ComboBox des motifs
        ComboBoxMotif.Items.AddRange(New String() {
            "Suivi",
            "Présentation de nouveauté",
            "Autre"
        })

        ' Cacher le panel de modification/création au démarrage
        CacherPanelModification()

        ' Masquer le TextBox "Autre motif" par défaut
        TextBoxAutreMotif.Visible = False
    End Sub

    Private Sub InitialiserDataGridView()
        ' Configuration des colonnes
        DataGridViewComptesRendus.Columns.Clear()
        DataGridViewComptesRendus.Columns.Add("Id", "Id")
        DataGridViewComptesRendus.Columns.Add("Praticien", "Praticien")
        DataGridViewComptesRendus.Columns.Add("DateVisite", "Date de la visite")

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
        TextBoxAutreMotif.Text = String.Empty
        TextBoxAutreMotif.Visible = False
        Bilan_visite.Text = String.Empty
    End Sub

    Private Sub AjouterCompteRendu_Click(sender As Object, e As EventArgs) Handles AjouterCompteRendu.Click
        modeEdition = False
        ligneEnCours = -1
        ViderChamps()
        AfficherPanelModification()
    End Sub

    Private Sub DataGridViewComptesRendus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewComptesRendus.CellContentClick
        If e.RowIndex >= 0 Then
            ' Vérifier si on a cliqué sur le bouton Modifier
            If e.ColumnIndex = DataGridViewComptesRendus.Columns("Modifier").Index Then
                modeEdition = True
                ligneEnCours = e.RowIndex

                ' Remplir les champs avec les données de la ligne sélectionnée
                Dim row As DataGridViewRow = DataGridViewComptesRendus.Rows(e.RowIndex)
                ComboBoxPraticien.SelectedItem = row.Cells("Praticien").Value.ToString()
                DateTimeVisite.Value = Convert.ToDateTime(row.Cells("DateVisite").Value)

                ' Récupérer les autres données si elles sont stockées (vous devrez ajouter des colonnes cachées)
                ' Pour l'instant, on laisse les autres champs vides
                ComboBoxMotif.SelectedIndex = -1
                Bilan_visite.Text = String.Empty

                AfficherPanelModification()
            End If

            ' Le bouton Voir sera géré plus tard
            If e.ColumnIndex = DataGridViewComptesRendus.Columns("Voir").Index Then
                MessageBox.Show("Fonctionnalité 'Voir' à implémenter ultérieurement.")
            End If
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
                DateTimeVisite.Value.ToString("dd/MM/yyyy")
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
End Class