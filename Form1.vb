Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormTableauScores.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NomJoueur.SelectedIndexChanged
        NomJoueur.DropDownStyle = ComboBoxStyle.DropDown
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim estOK As Boolean = True
        If TextNbBombe.Text = "" Then

        ElseIf CInt(TextNbBombe.Text) > DIMENSIONS * DIMENSIONS - 1 Then
            MsgBox("Il y a de trop de mine placée, vous devez en avoir maximum 63 ")
            estOK = False

        ElseIf CInt(TextNbBombe.Text) < 1 Then
        MsgBox("Il faut au minimum une bombe")
        estOK = False
        End If

        If Len(NomJoueur.Text) < 3 Then
            MsgBox("Le nom du joueur doit contenir au minimum 3 caracteres")
            estOK = False
        End If

        If TextNbTmps.Text = "" Then
        ElseIf CInt(TextNbTmps.Text) < 5 Or CInt(TextNbTmps.Text) > 1000 Then
            MsgBox("Le temps de la partie doit être compris entre 5 secondes et 1000 secondes")
            estOK = False
        End If

        If estOK Then

            enregistrerNom(NomJoueur.Text)
            NomJoueur.Items.Add(NomJoueur.Text)
            If Not TextNbBombe.Text = "" Then
                enregistrerNbBombe(CInt(TextNbBombe.Text))
            End If
            If Not TextNbTmps.Text = "" Then
                enregistrerNbTemps(CInt(TextNbTmps.Text))
            End If
            FormPartie.Show()

            NomJoueur.Text = ""
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim resultat As Integer
        resultat = MsgBox("Etes vous sur de quitter ?", MsgBoxStyle.YesNo)
        If (resultat = MsgBoxResult.Yes) Then
            End

        End If
    End Sub

    Private Sub TextNbBombe_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextNbBombe.KeyPress

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextNbTemps_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextNbTmps.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub
End Class
