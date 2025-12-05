<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsulterActiviteEquipe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsulterActiviteEquipe))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label_Debut = New System.Windows.Forms.Label()
        Me.Label_Fin = New System.Windows.Forms.Label()
        Me.DataGridView_Praticien = New System.Windows.Forms.DataGridView()
        Me.Column_Praticien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Nb_Visite = New System.Windows.Forms.Label()
        Me.Nb_Visite = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView_Motif = New System.Windows.Forms.DataGridView()
        Me.Column_Motif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_Visiteur = New System.Windows.Forms.DataGridView()
        Me.Column_Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Actions = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Praticien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Motif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Visiteur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(551, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Activité de l'équipe"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1202, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(375, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(177, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(112, 55)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(177, 20)
        Me.DateTimePicker2.TabIndex = 21
        '
        'Label_Debut
        '
        Me.Label_Debut.AutoSize = True
        Me.Label_Debut.Location = New System.Drawing.Point(25, 58)
        Me.Label_Debut.Name = "Label_Debut"
        Me.Label_Debut.Size = New System.Drawing.Size(81, 13)
        Me.Label_Debut.TabIndex = 22
        Me.Label_Debut.Text = "Date de début :"
        '
        'Label_Fin
        '
        Me.Label_Fin.AutoSize = True
        Me.Label_Fin.Location = New System.Drawing.Point(304, 58)
        Me.Label_Fin.Name = "Label_Fin"
        Me.Label_Fin.Size = New System.Drawing.Size(65, 13)
        Me.Label_Fin.TabIndex = 23
        Me.Label_Fin.Text = "Date de fin :"
        '
        'DataGridView_Praticien
        '
        Me.DataGridView_Praticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Praticien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Praticien, Me.Column_Nombre})
        Me.DataGridView_Praticien.Location = New System.Drawing.Point(25, 132)
        Me.DataGridView_Praticien.Name = "DataGridView_Praticien"
        Me.DataGridView_Praticien.Size = New System.Drawing.Size(310, 200)
        Me.DataGridView_Praticien.TabIndex = 24
        '
        'Column_Praticien
        '
        Me.Column_Praticien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Praticien.HeaderText = "Praticien"
        Me.Column_Praticien.Name = "Column_Praticien"
        '
        'Column_Nombre
        '
        Me.Column_Nombre.HeaderText = "Nombre de visites"
        Me.Column_Nombre.Name = "Column_Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Statistiques"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_Nb_Visite)
        Me.Panel1.Controls.Add(Me.Nb_Visite)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DataGridView_Praticien)
        Me.Panel1.Controls.Add(Me.DataGridView_Motif)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label_Debut)
        Me.Panel1.Controls.Add(Me.Label_Fin)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Location = New System.Drawing.Point(12, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 350)
        Me.Panel1.TabIndex = 27
        '
        'Label_Nb_Visite
        '
        Me.Label_Nb_Visite.AutoSize = True
        Me.Label_Nb_Visite.Location = New System.Drawing.Point(610, 114)
        Me.Label_Nb_Visite.Name = "Label_Nb_Visite"
        Me.Label_Nb_Visite.Size = New System.Drawing.Size(0, 13)
        Me.Label_Nb_Visite.TabIndex = 32
        '
        'Nb_Visite
        '
        Me.Nb_Visite.AutoSize = True
        Me.Nb_Visite.Location = New System.Drawing.Point(488, 114)
        Me.Nb_Visite.Name = "Nb_Visite"
        Me.Nb_Visite.Size = New System.Drawing.Size(115, 13)
        Me.Nb_Visite.TabIndex = 31
        Me.Nb_Visite.Text = "Nombre total de visite :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(590, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Consulter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView_Motif
        '
        Me.DataGridView_Motif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Motif.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Motif, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView_Motif.Location = New System.Drawing.Point(355, 132)
        Me.DataGridView_Motif.Name = "DataGridView_Motif"
        Me.DataGridView_Motif.Size = New System.Drawing.Size(310, 200)
        Me.DataGridView_Motif.TabIndex = 29
        '
        'Column_Motif
        '
        Me.Column_Motif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Motif.HeaderText = "Motif"
        Me.Column_Motif.Name = "Column_Motif"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre de visites"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridView_Visiteur
        '
        Me.DataGridView_Visiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Visiteur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Nom, Me.Column_Prenom, Me.Column_Actions})
        Me.DataGridView_Visiteur.Location = New System.Drawing.Point(8, 77)
        Me.DataGridView_Visiteur.Name = "DataGridView_Visiteur"
        Me.DataGridView_Visiteur.Size = New System.Drawing.Size(577, 255)
        Me.DataGridView_Visiteur.TabIndex = 25
        '
        'Column_Nom
        '
        Me.Column_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Nom.HeaderText = "Nom"
        Me.Column_Nom.Name = "Column_Nom"
        '
        'Column_Prenom
        '
        Me.Column_Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Prenom.HeaderText = "Prénom"
        Me.Column_Prenom.Name = "Column_Prenom"
        '
        'Column_Actions
        '
        Me.Column_Actions.HeaderText = "Action"
        Me.Column_Actions.Name = "Column_Actions"
        Me.Column_Actions.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_Actions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DataGridView_Visiteur)
        Me.Panel2.Location = New System.Drawing.Point(731, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 350)
        Me.Panel2.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(231, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Liste des visiteurs"
        '
        'ConsulterActiviteEquipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 521)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ConsulterActiviteEquipe"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Praticien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_Motif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Visiteur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label_Debut As Label
    Friend WithEvents Label_Fin As Label
    Friend WithEvents DataGridView_Praticien As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView_Visiteur As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView_Motif As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label_Nb_Visite As Label
    Friend WithEvents Nb_Visite As Label
    Friend WithEvents Column_Praticien As DataGridViewTextBoxColumn
    Friend WithEvents Column_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Column_Motif As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column_Nom As DataGridViewTextBoxColumn
    Friend WithEvents Column_Prenom As DataGridViewTextBoxColumn
    Friend WithEvents Column_Actions As DataGridViewButtonColumn
End Class
