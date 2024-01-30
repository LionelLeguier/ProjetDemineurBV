Module Module1
    Private Noms As New ArrayList
    Private JoueurActuel As String
    Public Nbmine As Integer = 10
    Public Const CASESREVELES As String = "X"
    Public Const BOMBE As String = "i"
    Public Const NONREVELES As String = ""
    Public Const MARQUEUR As String = "  "
    Private ScoreCase As New ArrayList
    Private ScoreTemps As New ArrayList
    Public Const DIMENSIONS As Integer = 8
    Private TempsPartie As Integer = 60
    Private NbPartieJoue As New ArrayList
    Public estAbandon As Boolean = True


    Public Sub TrierTableauScoreParTemps()
        Dim Stockage As Integer
        Dim stockageStr As String
        Dim compteur As Integer = 0
        Dim borneGlissante As Integer = ScoreTemps.Count
        Dim indice As Integer = 0
        Dim rb As Integer

        For i As Integer = 0 To ScoreTemps.Count - 1

            Dim max As Integer = ScoreTemps.Item(0)
            indice = 0
            While compteur < borneGlissante
                rb = ScoreTemps.Item(compteur)

                If rb > max Then
                    max = ScoreTemps.Item(compteur)
                    indice = compteur
                End If



                compteur = compteur + 1
            End While

            Stockage = ScoreCase.Item(indice)
            ScoreCase.Add(Stockage)
            ScoreCase.RemoveAt(indice)


            Stockage = ScoreTemps.Item(indice)
            ScoreTemps.Add(Stockage)
            ScoreTemps.RemoveAt(indice)


            stockageStr = Noms.Item(indice)
            Noms.Add(stockageStr)
            Noms.RemoveAt(indice)


            Stockage = NbPartieJoue.Item(indice)
            NbPartieJoue.Add(Stockage)
            NbPartieJoue.RemoveAt(indice)


            compteur = 0
            borneGlissante = borneGlissante - 1

        Next

    End Sub

    Public Sub TrierTableauScoreParCase()
        Dim Stockage As Integer
        Dim stockageStr As String
        Dim compteur As Integer = 0
        Dim borneGlissante As Integer = ScoreCase.Count
        Dim indice As Integer = 0
        Dim rb As Integer

        For i As Integer = 0 To ScoreCase.Count - 1

            Dim max As Integer = ScoreCase.Item(0)
            indice = 0
            While compteur < borneGlissante
                rb = ScoreCase.Item(compteur)

                If rb > max Then
                    max = ScoreTemps.Item(compteur)
                    indice = compteur
                End If


                compteur = compteur + 1
            End While

            Stockage = ScoreCase.Item(indice)
            ScoreCase.Add(Stockage)
            ScoreCase.RemoveAt(indice)


            Stockage = ScoreTemps.Item(indice)
            ScoreTemps.Add(Stockage)
            ScoreTemps.RemoveAt(indice)


            stockageStr = Noms.Item(indice)
            Noms.Add(stockageStr)
            Noms.RemoveAt(indice)


            Stockage = NbPartieJoue.Item(indice)
            NbPartieJoue.Add(Stockage)
            NbPartieJoue.RemoveAt(indice)


            compteur = 0
            borneGlissante = borneGlissante - 1

        Next


    End Sub




    Public Sub TrierTableauScoreParTempsDecroissant()
        Dim Stockage As Integer
        Dim stockageStr As String
        Dim compteur As Integer = 0
        Dim borneGlissante As Integer = ScoreTemps.Count
        Dim indice As Integer = 0
        Dim rb As Integer

        For i As Integer = 0 To ScoreTemps.Count - 1

            Dim max As Integer = ScoreTemps.Item(0)
            indice = 0
            While compteur < borneGlissante
                rb = ScoreTemps.Item(compteur)

                If rb < max Then
                    max = ScoreTemps.Item(compteur)
                    indice = compteur
                End If



                compteur = compteur + 1
            End While

            Stockage = ScoreCase.Item(indice)
            ScoreCase.Add(Stockage)
            ScoreCase.RemoveAt(indice)


            Stockage = ScoreTemps.Item(indice)
            ScoreTemps.Add(Stockage)
            ScoreTemps.RemoveAt(indice)


            stockageStr = Noms.Item(indice)
            Noms.Add(stockageStr)
            Noms.RemoveAt(indice)


            Stockage = NbPartieJoue.Item(indice)
            NbPartieJoue.Add(Stockage)
            NbPartieJoue.RemoveAt(indice)


            compteur = 0
            borneGlissante = borneGlissante - 1

        Next

    End Sub

    Public Sub TrierTableauScoreParCaseDecroissant()
        Dim Stockage As Integer
        Dim stockageStr As String
        Dim compteur As Integer = 0
        Dim borneGlissante As Integer = ScoreCase.Count
        Dim indice As Integer = 0
        Dim rb As Integer

        For i As Integer = 0 To ScoreCase.Count - 1

            Dim max As Integer = ScoreCase.Item(0)
            indice = 0
            While compteur < borneGlissante
                rb = ScoreCase.Item(compteur)

                If rb < max Then
                    max = ScoreTemps.Item(compteur)
                    indice = compteur
                End If


                compteur = compteur + 1
            End While

            Stockage = ScoreCase.Item(indice)
            ScoreCase.Add(Stockage)
            ScoreCase.RemoveAt(indice)


            Stockage = ScoreTemps.Item(indice)
            ScoreTemps.Add(Stockage)
            ScoreTemps.RemoveAt(indice)


            stockageStr = Noms.Item(indice)
            Noms.Add(stockageStr)
            Noms.RemoveAt(indice)


            Stockage = NbPartieJoue.Item(indice)
            NbPartieJoue.Add(Stockage)
            NbPartieJoue.RemoveAt(indice)


            compteur = 0
            borneGlissante = borneGlissante - 1

        Next


    End Sub
    Public Function GetNbPartieJoue(index As Integer)
        Return NbPartieJoue.Item(index)
    End Function
    Public Function ReconnaitreJoueur(Nom As String) As Boolean
        For i As Integer = 0 To Noms.Count - 1
            If Nom = Noms.Item(i) Then
                Return True
            End If
        Next
    End Function

    Public Function GetIndiceJoueur(Nom As String) As Integer
        For i As Integer = 0 To Noms.Count - 1
            If Nom = Noms.Item(i) Then
                Return i
            End If
        Next
    End Function

    Public Sub enregistrerNbBombe(NbBombe As Integer)
        Nbmine = NbBombe
    End Sub

    Public Sub enregistrerNbTemps(NbTemps As Integer)
        TempsPartie = NbTemps
    End Sub


    Public Sub enregistrerNom(Nom As String)
        JoueurActuel = Nom
    End Sub

    Public Function GetTempsPartie() As Integer
        Return TempsPartie
    End Function
    Public Function GetJoueurActuel() As String
        Return JoueurActuel
    End Function
    Public Function GetNoms(index As Integer) As String
        Return Noms.Item(index)
    End Function
    Public Function GetNbCase(index As Integer) As String
        Return ScoreCase.Item(index)
    End Function
    Public Function GetTemps(index As Integer) As String
        Return ScoreTemps.Item(index)
    End Function

    Public Function GetNbJoueur() As Integer
        Return Noms.Count
    End Function

    Public Sub enregistrerScore(Time As Integer, Casereveles As Integer, ExisteDeja As Boolean)
        If ExisteDeja Then
            Dim Indice As Integer = GetIndiceJoueur(JoueurActuel)
            If Casereveles > ScoreCase.Item(Indice) Then
                ScoreCase.Item(Indice) = Casereveles
                ScoreTemps.Item(Indice) = Time

            End If
            NbPartieJoue.Item(Indice) = NbPartieJoue.Item(Indice) + 1
        Else

            ScoreCase.Add(Casereveles)
                ScoreTemps.Add(Time)
                Noms.Add(JoueurActuel)
            NbPartieJoue.Add(1)
        End If

    End Sub




End Module
