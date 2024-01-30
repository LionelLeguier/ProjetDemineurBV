Public Class FormTableauScores
    Private estdecroissant As Boolean = True
    Public Sub AfficherScore(JoueurActuel As String, Temps As Integer, Score As Integer, NbPartie As Integer)
        ListScore.Items.Add(JoueurActuel & "            " & Temps & "           " & Score & "           " & NbPartie)
    End Sub

    Private Sub FormTableauScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TrierTableauScoreParTempsDecroissant()
        TrierTableauScoreParCaseDecroissant()


        For i = 0 To GetNbJoueur() - 1
            AfficherScore(GetNoms(i), GetTemps(i), GetNbCase(i), GetNbPartieJoue(i))
        Next
    End Sub

    Private Sub ButtonInverser_Click(sender As Object, e As EventArgs) Handles ButtonInverser.Click
        ListScore.Items.Clear()
        If estdecroissant Then
            estdecroissant = False
            TrierTableauScoreParTemps()
            TrierTableauScoreParCase()

        Else
            estdecroissant = True
            TrierTableauScoreParTempsDecroissant()
            TrierTableauScoreParCaseDecroissant()
        End If



        For i = 0 To GetNbJoueur() - 1
            AfficherScore(GetNoms(i), GetTemps(i), GetNbCase(i), GetNbPartieJoue(i))
        Next

    End Sub
End Class