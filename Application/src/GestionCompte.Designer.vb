<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionCompte
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionCompte))
        Me.Praticien = New System.Windows.Forms.Label()
        Me.Date_de_Visite = New System.Windows.Forms.Label()
        Me.Motif_visite = New System.Windows.Forms.Label()
        Me.Bilan = New System.Windows.Forms.Label()
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.DateTimeVisite = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxMotif = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPraticien = New System.Windows.Forms.ComboBox()
        Me.Bilan_visite = New System.Windows.Forms.TextBox()
        Me.TextBoxAutreMotif = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewComptesRendus = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AjouterCompteRendu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column_Produit = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column_Echantillon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Praticien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_DateVisite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Modifier = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column_Voir = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewComptesRendus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Praticien
        '
        Me.Praticien.AutoSize = True
        Me.Praticien.Location = New System.Drawing.Point(29, 97)
        Me.Praticien.Name = "Praticien"
        Me.Praticien.Size = New System.Drawing.Size(48, 13)
        Me.Praticien.TabIndex = 0
        Me.Praticien.Text = "Praticien"
        '
        'Date_de_Visite
        '
        Me.Date_de_Visite.AutoSize = True
        Me.Date_de_Visite.Location = New System.Drawing.Point(222, 113)
        Me.Date_de_Visite.Name = "Date_de_Visite"
        Me.Date_de_Visite.Size = New System.Drawing.Size(89, 13)
        Me.Date_de_Visite.TabIndex = 1
        Me.Date_de_Visite.Text = "Date de la visite :"
        '
        'Motif_visite
        '
        Me.Motif_visite.AutoSize = True
        Me.Motif_visite.Location = New System.Drawing.Point(30, 271)
        Me.Motif_visite.Name = "Motif_visite"
        Me.Motif_visite.Size = New System.Drawing.Size(89, 13)
        Me.Motif_visite.TabIndex = 2
        Me.Motif_visite.Text = "Motif de la visite :"
        '
        'Bilan
        '
        Me.Bilan.AutoSize = True
        Me.Bilan.Location = New System.Drawing.Point(30, 332)
        Me.Bilan.Name = "Bilan"
        Me.Bilan.Size = New System.Drawing.Size(89, 13)
        Me.Bilan.TabIndex = 6
        Me.Bilan.Text = "Bilan de la visite :"
        '
        'ButtonValider
        '
        Me.ButtonValider.Location = New System.Drawing.Point(236, 487)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(75, 23)
        Me.ButtonValider.TabIndex = 8
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = True
        '
        'DateTimeVisite
        '
        Me.DateTimeVisite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimeVisite.Location = New System.Drawing.Point(326, 111)
        Me.DateTimeVisite.Name = "DateTimeVisite"
        Me.DateTimeVisite.Size = New System.Drawing.Size(178, 20)
        Me.DateTimeVisite.TabIndex = 9
        '
        'ComboBoxMotif
        '
        Me.ComboBoxMotif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxMotif.FormattingEnabled = True
        Me.ComboBoxMotif.Location = New System.Drawing.Point(33, 287)
        Me.ComboBoxMotif.Name = "ComboBoxMotif"
        Me.ComboBoxMotif.Size = New System.Drawing.Size(134, 21)
        Me.ComboBoxMotif.TabIndex = 10
        '
        'ComboBoxPraticien
        '
        Me.ComboBoxPraticien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxPraticien.FormattingEnabled = True
        Me.ComboBoxPraticien.Location = New System.Drawing.Point(33, 113)
        Me.ComboBoxPraticien.Name = "ComboBoxPraticien"
        Me.ComboBoxPraticien.Size = New System.Drawing.Size(134, 21)
        Me.ComboBoxPraticien.TabIndex = 11
        '
        'Bilan_visite
        '
        Me.Bilan_visite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bilan_visite.Location = New System.Drawing.Point(33, 358)
        Me.Bilan_visite.Multiline = True
        Me.Bilan_visite.Name = "Bilan_visite"
        Me.Bilan_visite.Size = New System.Drawing.Size(472, 109)
        Me.Bilan_visite.TabIndex = 12
        Me.Bilan_visite.Text = "Saisir le Bilan . . ."
        '
        'TextBoxAutreMotif
        '
        Me.TextBoxAutreMotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAutreMotif.Location = New System.Drawing.Point(182, 287)
        Me.TextBoxAutreMotif.Name = "TextBoxAutreMotif"
        Me.TextBoxAutreMotif.Size = New System.Drawing.Size(178, 20)
        Me.TextBoxAutreMotif.TabIndex = 15
        Me.TextBoxAutreMotif.Text = "Précisez le motif"
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 41)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Gérer ses compte-rendus"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(906, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(323, 41)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Modifer / Créer"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewComptesRendus
        '
        Me.DataGridViewComptesRendus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewComptesRendus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewComptesRendus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Id, Me.Column_Praticien, Me.Column_DateVisite, Me.Column_Modifier, Me.Column_Voir})
        Me.DataGridViewComptesRendus.Location = New System.Drawing.Point(14, 112)
        Me.DataGridViewComptesRendus.Name = "DataGridViewComptesRendus"
        Me.DataGridViewComptesRendus.Size = New System.Drawing.Size(479, 336)
        Me.DataGridViewComptesRendus.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 41)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Liste des comptes rendus"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AjouterCompteRendu
        '
        Me.AjouterCompteRendu.Location = New System.Drawing.Point(161, 563)
        Me.AjouterCompteRendu.Name = "AjouterCompteRendu"
        Me.AjouterCompteRendu.Size = New System.Drawing.Size(152, 23)
        Me.AjouterCompteRendu.TabIndex = 21
        Me.AjouterCompteRendu.Text = "Ajouter"
        Me.AjouterCompteRendu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AjouterCompteRendu)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DataGridViewComptesRendus)
        Me.Panel1.Location = New System.Drawing.Point(10, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 535)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBoxAutreMotif)
        Me.Panel2.Controls.Add(Me.Bilan_visite)
        Me.Panel2.Controls.Add(Me.ComboBoxPraticien)
        Me.Panel2.Controls.Add(Me.ComboBoxMotif)
        Me.Panel2.Controls.Add(Me.DateTimeVisite)
        Me.Panel2.Controls.Add(Me.ButtonValider)
        Me.Panel2.Controls.Add(Me.Bilan)
        Me.Panel2.Controls.Add(Me.Motif_visite)
        Me.Panel2.Controls.Add(Me.Date_de_Visite)
        Me.Panel2.Controls.Add(Me.Praticien)
        Me.Panel2.Location = New System.Drawing.Point(519, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 534)
        Me.Panel2.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Produit, Me.Column_Echantillon})
        Me.DataGridView1.Location = New System.Drawing.Point(32, 157)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(472, 100)
        Me.DataGridView1.TabIndex = 19
        '
        'Column_Produit
        '
        Me.Column_Produit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Produit.HeaderText = "Produit"
        Me.Column_Produit.Name = "Column_Produit"
        Me.Column_Produit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_Produit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column_Echantillon
        '
        Me.Column_Echantillon.HeaderText = "Échantillon"
        Me.Column_Echantillon.Name = "Column_Echantillon"
        '
        'Column_Id
        '
        Me.Column_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Id.FillWeight = 50.76142!
        Me.Column_Id.HeaderText = "Id"
        Me.Column_Id.Name = "Column_Id"
        Me.Column_Id.Visible = False
        '
        'Column_Praticien
        '
        Me.Column_Praticien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Praticien.FillWeight = 112.3096!
        Me.Column_Praticien.HeaderText = "Praticien"
        Me.Column_Praticien.Name = "Column_Praticien"
        '
        'Column_DateVisite
        '
        Me.Column_DateVisite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_DateVisite.FillWeight = 112.3096!
        Me.Column_DateVisite.HeaderText = "Date de la visite"
        Me.Column_DateVisite.Name = "Column_DateVisite"
        '
        'Column_Modifier
        '
        Me.Column_Modifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Modifier.FillWeight = 112.3096!
        Me.Column_Modifier.HeaderText = "Modifier"
        Me.Column_Modifier.Name = "Column_Modifier"
        Me.Column_Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_Modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column_Voir
        '
        Me.Column_Voir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Voir.FillWeight = 112.3096!
        Me.Column_Voir.HeaderText = "Voir"
        Me.Column_Voir.Name = "Column_Voir"
        Me.Column_Voir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_Voir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GestionCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 652)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GestionCompte"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewComptesRendus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Praticien As Label
    Friend WithEvents Date_de_Visite As Label
    Friend WithEvents Motif_visite As Label
    Friend WithEvents Bilan As Label
    Friend WithEvents ButtonValider As Button
    Friend WithEvents DateTimeVisite As DateTimePicker
    Friend WithEvents ComboBoxMotif As ComboBox
    Friend WithEvents ComboBoxPraticien As ComboBox
    Friend WithEvents Bilan_visite As TextBox
    Friend WithEvents TextBoxAutreMotif As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewComptesRendus As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents AjouterCompteRendu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column_Produit As DataGridViewComboBoxColumn
    Friend WithEvents Column_Echantillon As DataGridViewTextBoxColumn
    Friend WithEvents Column_Id As DataGridViewTextBoxColumn
    Friend WithEvents Column_Praticien As DataGridViewTextBoxColumn
    Friend WithEvents Column_DateVisite As DataGridViewTextBoxColumn
    Friend WithEvents Column_Modifier As DataGridViewButtonColumn
    Friend WithEvents Column_Voir As DataGridViewButtonColumn
End Class
