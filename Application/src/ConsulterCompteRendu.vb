Public Class ConsulterCompteRendu

    ' Propriétés pour recevoir les données du compte-rendu
    Public Property PraticienSelectionne As String
    Public Property DateVisiteSelectionnee As String
    Public Property MotifSelectionne As String
    Public Property MotifDetailSelectionne As String
    Public Property BilanVisiteSelectionne As String
    Public Property ProduitsEchantillonsSerialises As String ' Chaîne de produits|quantité;...

    ' Helper function to deserialize string back into DataGridView1 (copie pour la lecture seule)
    Private Sub DeserializeProductsSamples(ByVal data As String)
        DataGridView1.Rows.Clear()
        If Not String.IsNullOrWhiteSpace(data) Then
            Dim items() As String = data.Split(";"c)
            For Each item As String In items
                Dim parts() As String = item.Split("|"c)
                If parts.Length = 2 Then
                    ' Ajoute le produit et l'échantillon à la grille de consultation
                    DataGridView1.Rows.Add(parts(0), parts(1))
                End If
            Next
        End If
    End Sub

    Private Sub ConsulterCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Afficher les données générales
        Label3.Text = PraticienSelectionne       ' Praticien
        Label5.Text = DateVisiteSelectionnee     ' Date

        ' Affichage du Motif (avec détail si "Autre")
        Dim motifText As String = MotifSelectionne
        If MotifSelectionne = "Autre" AndAlso Not String.IsNullOrWhiteSpace(MotifDetailSelectionne) Then
            motifText &= " (" & MotifDetailSelectionne & ")"
        End If
        Label7.Text = motifText                 ' Motif

        TextBox1.Text = BilanVisiteSelectionne  ' Bilan
        TextBox1.Enabled = False                ' Fenêtre en lecture seule

        ' Affichage des Produits et Échantillons
        DeserializeProductsSamples(ProduitsEchantillonsSerialises)
    End Sub
End Class