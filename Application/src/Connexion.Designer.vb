<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Me.Label_Login = New System.Windows.Forms.Label()
        Me.Label_MDP = New System.Windows.Forms.Label()
        Me.TextBox_Login = New System.Windows.Forms.TextBox()
        Me.TextBox_MDP = New System.Windows.Forms.TextBox()
        Me.Button_Connexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Login
        '
        Me.Label_Login.AutoSize = True
        Me.Label_Login.Location = New System.Drawing.Point(131, 105)
        Me.Label_Login.Name = "Label_Login"
        Me.Label_Login.Size = New System.Drawing.Size(39, 13)
        Me.Label_Login.TabIndex = 0
        Me.Label_Login.Text = "Login :"
        '
        'Label_MDP
        '
        Me.Label_MDP.AutoSize = True
        Me.Label_MDP.Location = New System.Drawing.Point(93, 149)
        Me.Label_MDP.Name = "Label_MDP"
        Me.Label_MDP.Size = New System.Drawing.Size(77, 13)
        Me.Label_MDP.TabIndex = 1
        Me.Label_MDP.Text = "Mot de passe :"
        '
        'TextBox_Login
        '
        Me.TextBox_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Login.Location = New System.Drawing.Point(176, 102)
        Me.TextBox_Login.Name = "TextBox_Login"
        Me.TextBox_Login.Size = New System.Drawing.Size(186, 20)
        Me.TextBox_Login.TabIndex = 2
        '
        'TextBox_MDP
        '
        Me.TextBox_MDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_MDP.Location = New System.Drawing.Point(176, 147)
        Me.TextBox_MDP.Name = "TextBox_MDP"
        Me.TextBox_MDP.Size = New System.Drawing.Size(186, 20)
        Me.TextBox_MDP.TabIndex = 3
        '
        'Button_Connexion
        '
        Me.Button_Connexion.Location = New System.Drawing.Point(190, 206)
        Me.Button_Connexion.Name = "Button_Connexion"
        Me.Button_Connexion.Size = New System.Drawing.Size(75, 23)
        Me.Button_Connexion.TabIndex = 4
        Me.Button_Connexion.Text = "Connexion"
        Me.Button_Connexion.UseVisualStyleBackColor = True
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 295)
        Me.Controls.Add(Me.Button_Connexion)
        Me.Controls.Add(Me.TextBox_MDP)
        Me.Controls.Add(Me.TextBox_Login)
        Me.Controls.Add(Me.Label_MDP)
        Me.Controls.Add(Me.Label_Login)
        Me.Name = "Connexion"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Login As Label
    Friend WithEvents Label_MDP As Label
    Friend WithEvents TextBox_Login As TextBox
    Friend WithEvents TextBox_MDP As TextBox
    Friend WithEvents Button_Connexion As Button
End Class
