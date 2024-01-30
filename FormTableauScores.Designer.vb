<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTableauScores
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
        Me.ListScore = New System.Windows.Forms.ListBox()
        Me.ButtonInverser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListScore
        '
        Me.ListScore.FormattingEnabled = True
        Me.ListScore.ItemHeight = 15
        Me.ListScore.Location = New System.Drawing.Point(12, 25)
        Me.ListScore.Name = "ListScore"
        Me.ListScore.Size = New System.Drawing.Size(776, 169)
        Me.ListScore.TabIndex = 0
        '
        'ButtonInverser
        '
        Me.ButtonInverser.Location = New System.Drawing.Point(55, 258)
        Me.ButtonInverser.Name = "ButtonInverser"
        Me.ButtonInverser.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInverser.TabIndex = 1
        Me.ButtonInverser.Text = "Button1"
        Me.ButtonInverser.UseVisualStyleBackColor = True
        '
        'FormTableauScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonInverser)
        Me.Controls.Add(Me.ListScore)
        Me.Name = "FormTableauScores"
        Me.Text = "Tableau des scores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListScore As ListBox
    Friend WithEvents ButtonInverser As Button
End Class
