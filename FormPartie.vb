Public Class FormPartie
    Private TimeString As String
    Private Time As Integer
    Private NbCasesreveles As Integer = 0
    Private TempsDuJoueur As Integer = 0
    Private Sub FormPartie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        FormTableauScores.Close()
        Me.BackColor = Color.White
        Timer1.Interval = 1000
        Timer1.Start()
        Time = GetTempsPartie()
        Chrono.Text = Time
        LabelNomJoueur.Text = GetJoueurActuel()
        For i = 0 To Panel1.Controls().Count - 1
            Dim rb As Button = Panel1.Controls(i)
            rb.Text = NONREVELES
        Next
        Dim nbmine2 As Integer = Nbmine
        Dim randomValue As Integer
        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = 63
        Dim compteur As Integer = 0
        While nbmine2 > compteur
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            Dim test As Boolean = True


            If Panel1.Controls(randomValue).Text = BOMBE Then
                nbmine2 = nbmine2 + 1
                test = False
            End If

            If test Then
                Dim rb As Button = Panel1.Controls(randomValue)
                rb.Text = BOMBE
            End If
            compteur = compteur + 1
        End While

    End Sub
    Private Sub FormPartie_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultat As Integer
        If estAbandon Then
            resultat = MsgBox("Etes vous sur de quitter ? La partie ne sera pas sauvegardé. ", MsgBoxStyle.YesNo)

            If (resultat = MsgBoxResult.Yes) Then
                Form1.Enabled = True
            ElseIf (resultat = MsgBoxResult.No) Then
                e.Cancel = True
            End If
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time = Time - 1
        Chrono.Text = Time
        If Time = 0 Then
            Timer1.Stop()
            estAbandon = False
            Dim Resultat2 As Integer = MsgBox("Le temps est écoulé, la partie est finie")
            If (Resultat2 = MsgBoxResult.Ok) Then
                enregistrerScore(TempsDuJoueur, NbCasesreveles, ReconnaitreJoueur(GetJoueurActuel()))
                Me.Close()
                estAbandon = True
                Form1.Enabled = True
            End If
        End If
    End Sub

    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles ButtonAbandon.Click


        Me.Close()
        Form1.Enabled = True



    End Sub
    Public Function ExisteBas(Indice As Integer) As Boolean
        Return Indice + DIMENSIONS <= 63

    End Function
    Public Function ExisteHaut(Indice As Integer) As Boolean
        Return Indice - DIMENSIONS >= 0
    End Function
    Public Function ExisteGauche(Indice As Integer) As Boolean
        Return Indice Mod 8 > 0
    End Function
    Public Function ExisteDroite(Indice As Integer) As Boolean
        Return Indice Mod 8 < 7
    End Function

    Private Function Avoisinant(Indice As Integer) As Integer
        Dim BombeAvoisinate As Integer = 0
        If ExisteGauche(Indice) Then
            If Panel1.Controls(Indice - 1).Text = BOMBE Then
                BombeAvoisinate = BombeAvoisinate + 1
            End If
        End If
        If ExisteDroite(Indice) Then
            If Panel1.Controls(Indice + 1).Text = BOMBE Then
                BombeAvoisinate = BombeAvoisinate + 1
            End If
        End If
        If ExisteHaut(Indice) Then
            If Panel1.Controls(Indice - 8).Text = BOMBE Then
                BombeAvoisinate = BombeAvoisinate + 1
            End If
        End If
        If ExisteBas(Indice) Then
            If Panel1.Controls(Indice + 8).Text = BOMBE Then
                BombeAvoisinate = BombeAvoisinate + 1
            End If
        End If
        If ExisteHaut(Indice) And ExisteDroite(Indice) Then
            If Panel1.Controls(Indice - 7).Text = BOMBE Then
                BombeAvoisinate = BombeAvoisinate + 1
            End If
        End If
        If ExisteHaut(Indice) And ExisteGauche(Indice) Then
            If Panel1.Controls(Indice - 9).Text = BOMBE Then
                BombeAvoisinate = BombeAvoisinate + 1
            End If
        End If
        If ExisteBas(Indice) And ExisteGauche(Indice) Then
            If Panel1.Controls(Indice + 7).Text = BOMBE Then
                BombeAvoisinate = BombeAvoisinate + 1
            End If
        End If
        If ExisteBas(Indice) And ExisteDroite(Indice) Then
            If Panel1.Controls(Indice + 9).Text = BOMBE Then
                BombeAvoisinate = BombeAvoisinate + 1
            End If
        End If

        Return BombeAvoisinate
    End Function
    Private Function RechercheIndice() As Integer
        For i As Integer = 0 To Panel1.Controls.Count - 1

            If Panel1.Controls(i).Text = MARQUEUR Then
                Return i
            End If
        Next


    End Function
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _
        Button1.Click,
        Button2.Click,
        Button3.Click,
        Button4.Click,
        Button5.Click,
        Button6.Click,
        Button7.Click,
        Button8.Click,
        Button9.Click,
        Button10.Click,
        Button11.Click,
        Button12.Click,
        Button13.Click,
        Button14.Click,
        Button15.Click,
        Button16.Click,
        Button17.Click,
        Button18.Click,
        Button19.Click,
        Button20.Click,
        Button21.Click,
        Button22.Click,
        Button23.Click,
        Button24.Click,
        Button25.Click,
        Button26.Click,
        Button27.Click,
        Button28.Click,
        Button29.Click,
        Button30.Click,
        Button31.Click,
        Button32.Click,
        Button33.Click,
        Button34.Click,
        Button35.Click,
        Button36.Click,
        Button37.Click,
        Button38.Click,
        Button39.Click,
        Button40.Click,
        Button41.Click,
        Button42.Click,
        Button43.Click,
        Button44.Click,
        Button45.Click,
        Button46.Click,
        Button47.Click,
        Button48.Click,
        Button49.Click,
        Button50.Click,
        Button51.Click,
        Button52.Click,
        Button53.Click,
        Button54.Click,
        Button55.Click,
        Button56.Click,
        Button57.Click,
        Button58.Click,
        Button59.Click,
        Button60.Click,
        Button61.Click,
        Button62.Click,
        Button63.Click,
        Button64.Click

        Dim Bouton As Button = sender
        TempsDuJoueur = Time
        If Bouton.Text = NONREVELES Then

            NbCasesreveles = NbCasesreveles + 1
            Bouton.Text = MARQUEUR
            Dim Indice As Integer = RechercheIndice()

            If Avoisinant(Indice) = 0 Then
                Bouton.Text = "D"
            Else
                Bouton.Text = Avoisinant(Indice)
            End If

        End If
        If Bouton.Text = BOMBE Then
            Timer1.Stop()
            estAbandon = False
            Dim Resultat3 As Integer = MsgBox("C'est une bombe, vous avez perdu " & "Vous avez révelés " & NbCasesreveles & " cases.")
            If (Resultat3 = MsgBoxResult.Ok) Then
                enregistrerScore(TempsDuJoueur, NbCasesreveles, ReconnaitreJoueur(GetJoueurActuel()))
                Me.Close()
                estAbandon = True
                Form1.Enabled = True
            End If
        End If



    End Sub

    Private Sub ButtonColor_Click(sender As Object, e As EventArgs) Handles ButtonColor.Click
        Dim lb As Label
        If Me.BackColor = Color.Black Then
            Me.BackColor = Color.White
            For i As Integer = 0 To PanelLabel.Controls.Count() - 1
                lb = PanelLabel.Controls(i)
                lb.ForeColor = Color.Black
            Next

        ElseIf Me.BackColor = Color.White Then
            Me.BackColor = Color.Black
            For i As Integer = 0 To PanelLabel.Controls.Count() - 1
                lb = PanelLabel.Controls(i)
                lb.ForeColor = Color.White
            Next
        End If

    End Sub


End Class