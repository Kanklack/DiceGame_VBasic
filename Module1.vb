Module Module1

    Sub Main()

        Dim throw1, throw2, score, player1score, player2score As Integer

        throw1 = CInt(Math.Ceiling(Rnd() * 6)) + 1

        throw2 = CInt(Math.Ceiling(Rnd() * 6)) + 1

        score = throw1 + throw2

        If score = 12 Then

            score = 0

        Else

            If throw1 = throw2 Then

                score = score * 2

            End If

        End If

        player1score = score

        Console.WriteLine("Player1 score: " & player1score)

        throw1 = CInt(Math.Ceiling(Rnd() * 6)) + 1

        throw2 = CInt(Math.Ceiling(Rnd() * 6)) + 1

        score = throw1 + throw2

        If score = 12 Then

            score = 0

        Else

            If throw1 = throw2 Then

                score = score * 2

            End If

        End If

        player2score = score

        Console.WriteLine("Player2 score: " & player2score)

        If player1score > player2score Then

            Console.WriteLine("Player 1 wins!")

        ElseIf player1score < player2score Then

            Console.WriteLine("Player 2 wins!")

        Else

            Console.WriteLine("It's a draw")

        End If

        Console.Read()

    End Sub

End Module
