Public Class Form2
    Private ScoreCase As New ArrayList
    Public Sub Remplir()



        ScoreCase.Add(3)
        ScoreCase.Add(3)
        ScoreCase.Add(4)
        ScoreCase.Add(8)
        ScoreCase.Add(7)

        ScoreCase.Add(18)
        ScoreCase.Add(2)

    End Sub
    Public Sub TrierTableauScore()
        Dim Stockage As Integer

        Dim compteur As Integer = 0
        Dim borneGlissante As Integer = 7
        Dim indice As Integer = 0
        Dim rb As Integer



        For i As Integer = 0 To 7 - 1

            Dim max As Integer = ScoreCase.Item(0)
            indice = 0
            While compteur < borneGlissante
                rb = ScoreCase.Item(compteur)

                If rb < max Then
                    max = ScoreCase.Item(compteur)
                    indice = compteur


                End If

                compteur = compteur + 1
            End While

            Stockage = ScoreCase.Item(indice)
            ScoreCase.Add(Stockage)
            ScoreCase.RemoveAt(indice)



            compteur = 0
            borneGlissante = borneGlissante - 1

        Next



    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir()
        Label2.Text = ScoreCase.Item(0) & "    " & ScoreCase.Item(1) & "    " & ScoreCase.Item(2) & "    " & ScoreCase.Item(3) & "    " & ScoreCase.Item(4) & "    " & ScoreCase.Item(5) & "    " & ScoreCase.Item(6) & "    "

        TrierTableauScore()

        Label1.Text = ScoreCase.Item(0) & "    " & ScoreCase.Item(1) & "    " & ScoreCase.Item(2) & "    " & ScoreCase.Item(3) & "    " & ScoreCase.Item(4) & "    " & ScoreCase.Item(5) & "    " & ScoreCase.Item(6) & "    "
    End Sub


End Class