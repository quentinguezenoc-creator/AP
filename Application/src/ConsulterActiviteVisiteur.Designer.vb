<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsulterActiviteVisiteur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsulterActiviteVisiteur))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Nb_Visite = New System.Windows.Forms.Label()
        Me.Nb_Visite = New System.Windows.Forms.Label()
        Me.Button_Consulter = New System.Windows.Forms.Button()
        Me.DataGridView_Praticien = New System.Windows.Forms.DataGridView()
        Me.Column_Praticien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_Motif = New System.Windows.Forms.DataGridView()
        Me.Column_Motif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Debut = New System.Windows.Forms.DateTimePicker()
        Me.Label_Debut = New System.Windows.Forms.Label()
        Me.Label_Fin = New System.Windows.Forms.Label()
        Me.DateTimePicker_Fin = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView_CR = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Praticien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Motif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView_CR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1215, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(559, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Activité du visiteur"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_Nb_Visite)
        Me.Panel1.Controls.Add(Me.Nb_Visite)
        Me.Panel1.Controls.Add(Me.Button_Consulter)
        Me.Panel1.Controls.Add(Me.DataGridView_Praticien)
        Me.Panel1.Controls.Add(Me.DataGridView_Motif)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker_Debut)
        Me.Panel1.Controls.Add(Me.Label_Debut)
        Me.Panel1.Controls.Add(Me.Label_Fin)
        Me.Panel1.Controls.Add(Me.DateTimePicker_Fin)
        Me.Panel1.Location = New System.Drawing.Point(12, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 407)
        Me.Panel1.TabIndex = 29
        '
        'Label_Nb_Visite
        '
        Me.Label_Nb_Visite.AutoSize = True
        Me.Label_Nb_Visite.Location = New System.Drawing.Point(621, 128)
        Me.Label_Nb_Visite.Name = "Label_Nb_Visite"
        Me.Label_Nb_Visite.Size = New System.Drawing.Size(0, 13)
        Me.Label_Nb_Visite.TabIndex = 33
        '
        'Nb_Visite
        '
        Me.Nb_Visite.AutoSize = True
        Me.Nb_Visite.Location = New System.Drawing.Point(494, 128)
        Me.Nb_Visite.Name = "Nb_Visite"
        Me.Nb_Visite.Size = New System.Drawing.Size(120, 13)
        Me.Nb_Visite.TabIndex = 32
        Me.Nb_Visite.Text = "Nombre total de visites :"
        '
        'Button_Consulter
        '
        Me.Button_Consulter.Location = New System.Drawing.Point(588, 75)
        Me.Button_Consulter.Name = "Button_Consulter"
        Me.Button_Consulter.Size = New System.Drawing.Size(75, 23)
        Me.Button_Consulter.TabIndex = 31
        Me.Button_Consulter.Text = "Afficher"
        Me.Button_Consulter.UseVisualStyleBackColor = True
        '
        'DataGridView_Praticien
        '
        Me.DataGridView_Praticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Praticien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Praticien, Me.Column_Nombre})
        Me.DataGridView_Praticien.Location = New System.Drawing.Point(19, 167)
        Me.DataGridView_Praticien.Name = "DataGridView_Praticien"
        Me.DataGridView_Praticien.Size = New System.Drawing.Size(320, 200)
        Me.DataGridView_Praticien.TabIndex = 30
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
        'DataGridView_Motif
        '
        Me.DataGridView_Motif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Motif.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Motif, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView_Motif.Location = New System.Drawing.Point(362, 167)
        Me.DataGridView_Motif.Name = "DataGridView_Motif"
        Me.DataGridView_Motif.Size = New System.Drawing.Size(320, 200)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Statistiques"
        '
        'DateTimePicker_Debut
        '
        Me.DateTimePicker_Debut.Location = New System.Drawing.Point(124, 77)
        Me.DateTimePicker_Debut.Name = "DateTimePicker_Debut"
        Me.DateTimePicker_Debut.Size = New System.Drawing.Size(177, 20)
        Me.DateTimePicker_Debut.TabIndex = 21
        '
        'Label_Debut
        '
        Me.Label_Debut.AutoSize = True
        Me.Label_Debut.Location = New System.Drawing.Point(37, 80)
        Me.Label_Debut.Name = "Label_Debut"
        Me.Label_Debut.Size = New System.Drawing.Size(81, 13)
        Me.Label_Debut.TabIndex = 22
        Me.Label_Debut.Text = "Date de début :"
        '
        'Label_Fin
        '
        Me.Label_Fin.AutoSize = True
        Me.Label_Fin.Location = New System.Drawing.Point(313, 80)
        Me.Label_Fin.Name = "Label_Fin"
        Me.Label_Fin.Size = New System.Drawing.Size(65, 13)
        Me.Label_Fin.TabIndex = 23
        Me.Label_Fin.Text = "Date de fin :"
        '
        'DateTimePicker_Fin
        '
        Me.DateTimePicker_Fin.Location = New System.Drawing.Point(384, 77)
        Me.DateTimePicker_Fin.Name = "DateTimePicker_Fin"
        Me.DateTimePicker_Fin.Size = New System.Drawing.Size(177, 20)
        Me.DateTimePicker_Fin.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView_CR)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(759, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 356)
        Me.Panel2.TabIndex = 30
        '
        'DataGridView_CR
        '
        Me.DataGridView_CR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_CR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView_CR.Location = New System.Drawing.Point(26, 77)
        Me.DataGridView_CR.Name = "DataGridView_CR"
        Me.DataGridView_CR.Size = New System.Drawing.Size(538, 263)
        Me.DataGridView_CR.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Praticien"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Action"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(212, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Liste des Comptes-rendus"
        '
        'ConsulterActiviteVisiteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ConsulterActiviteVisiteur"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_Praticien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Motif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView_CR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Consulter As Button
    Friend WithEvents DataGridView_Praticien As DataGridView
    Friend WithEvents DataGridView_Motif As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker_Debut As DateTimePicker
    Friend WithEvents Label_Debut As Label
    Friend WithEvents Label_Fin As Label
    Friend WithEvents DateTimePicker_Fin As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView_CR As DataGridView
    Friend WithEvents Label_Nb_Visite As Label
    Friend WithEvents Nb_Visite As Label
    Friend WithEvents Column_Praticien As DataGridViewTextBoxColumn
    Friend WithEvents Column_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Column_Motif As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
End Class
