<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsulterCompteRendu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsulterCompteRendu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nom_Praticien = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Date_Visite = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Motif = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Bilan = New System.Windows.Forms.TextBox()
        Me.DataGridView_Produits = New System.Windows.Forms.DataGridView()
        Me.Column_Produit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Echantillon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Produits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(493, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(207, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Compte-rendu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Praticien :"
        '
        'Nom_Praticien
        '
        Me.Nom_Praticien.AutoSize = True
        Me.Nom_Praticien.Location = New System.Drawing.Point(101, 184)
        Me.Nom_Praticien.Name = "Nom_Praticien"
        Me.Nom_Praticien.Size = New System.Drawing.Size(39, 13)
        Me.Nom_Praticien.TabIndex = 22
        Me.Nom_Praticien.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Date de la visite :"
        '
        'Date_Visite
        '
        Me.Date_Visite.AutoSize = True
        Me.Date_Visite.Location = New System.Drawing.Point(416, 184)
        Me.Date_Visite.Name = "Date_Visite"
        Me.Date_Visite.Size = New System.Drawing.Size(39, 13)
        Me.Date_Visite.TabIndex = 24
        Me.Date_Visite.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Motif de la visite :"
        '
        'Motif
        '
        Me.Motif.AutoSize = True
        Me.Motif.Location = New System.Drawing.Point(137, 370)
        Me.Motif.Name = "Motif"
        Me.Motif.Size = New System.Drawing.Size(39, 13)
        Me.Motif.TabIndex = 26
        Me.Motif.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Bilan de la visite :"
        '
        'TextBox_Bilan
        '
        Me.TextBox_Bilan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Bilan.Location = New System.Drawing.Point(47, 449)
        Me.TextBox_Bilan.Multiline = True
        Me.TextBox_Bilan.Name = "TextBox_Bilan"
        Me.TextBox_Bilan.Size = New System.Drawing.Size(500, 60)
        Me.TextBox_Bilan.TabIndex = 28
        '
        'DataGridView_Produits
        '
        Me.DataGridView_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Produits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Produit, Me.Column_Echantillon})
        Me.DataGridView_Produits.Location = New System.Drawing.Point(44, 240)
        Me.DataGridView_Produits.Name = "DataGridView_Produits"
        Me.DataGridView_Produits.Size = New System.Drawing.Size(503, 100)
        Me.DataGridView_Produits.TabIndex = 29
        '
        'Column_Produit
        '
        Me.Column_Produit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Produit.HeaderText = "Produit"
        Me.Column_Produit.Name = "Column_Produit"
        Me.Column_Produit.ReadOnly = True
        '
        'Column_Echantillon
        '
        Me.Column_Echantillon.HeaderText = "Échantillon"
        Me.Column_Echantillon.Name = "Column_Echantillon"
        Me.Column_Echantillon.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Produits présentés :"
        '
        'ConsulterCompteRendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 626)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView_Produits)
        Me.Controls.Add(Me.TextBox_Bilan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Motif)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Date_Visite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nom_Praticien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ConsulterCompteRendu"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Produits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Nom_Praticien As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Date_Visite As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Motif As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_Bilan As TextBox
    Friend WithEvents DataGridView_Produits As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Column_Produit As DataGridViewTextBoxColumn
    Friend WithEvents Column_Echantillon As DataGridViewTextBoxColumn
End Class
