<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NomJoueur = New System.Windows.Forms.ComboBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNbBombe = New System.Windows.Forms.Label()
        Me.TextNbBombe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextNbTmps = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NomJoueur
        '
        Me.NomJoueur.FormattingEnabled = True
        Me.NomJoueur.Location = New System.Drawing.Point(271, 179)
        Me.NomJoueur.Name = "NomJoueur"
        Me.NomJoueur.Size = New System.Drawing.Size(121, 23)
        Me.NomJoueur.TabIndex = 0
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(39, 394)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuitter.TabIndex = 1
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(186, 394)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Tableau des scores"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(366, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Nouvelle Partie"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom"
        '
        'LabelNbBombe
        '
        Me.LabelNbBombe.AutoSize = True
        Me.LabelNbBombe.Location = New System.Drawing.Point(489, 95)
        Me.LabelNbBombe.Name = "LabelNbBombe"
        Me.LabelNbBombe.Size = New System.Drawing.Size(108, 15)
        Me.LabelNbBombe.TabIndex = 5
        Me.LabelNbBombe.Text = "Nombre de Bombe"
        '
        'TextNbBombe
        '
        Me.TextNbBombe.Location = New System.Drawing.Point(603, 92)
        Me.TextNbBombe.MaxLength = 2
        Me.TextNbBombe.Name = "TextNbBombe"
        Me.TextNbBombe.Size = New System.Drawing.Size(100, 23)
        Me.TextNbBombe.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(433, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre de temps de la partie"
        '
        'TextNbTmps
        '
        Me.TextNbTmps.Location = New System.Drawing.Point(603, 128)
        Me.TextNbTmps.MaxLength = 4
        Me.TextNbTmps.Name = "TextNbTmps"
        Me.TextNbTmps.Size = New System.Drawing.Size(100, 23)
        Me.TextNbTmps.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextNbTmps)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextNbBombe)
        Me.Controls.Add(Me.LabelNbBombe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.NomJoueur)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NomJoueur As ComboBox
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNbBombe As Label
    Friend WithEvents TextNbBombe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextNbTmps As TextBox
End Class
