Imports System.IO

Module Module1

    Sub Main()
        Dim filename As String = "top3list.csv"
        Console.WriteLine(String.Format("Filename: {0}", filename))
        Dim dt As DateTime = IO.File.GetLastWriteTime(filename)
        Console.WriteLine("Modified At: {0}", dt)

        Console.WriteLine()
        For Each line As String In File.ReadLines(filename)
            Dim pieces As String() = Split(line, ",")
            Dim t As New Team(pieces(0), pieces(1))
            Dim label As String = "| Team: " + t.Name + " |"
            Console.WriteLine("+" + StrDup(Len(label) - 2, "-") + "+")
            Console.WriteLine(label)
            Dim ws As Integer = Len(label) - Len(String.Format("| Super Bowl Wins: {0}", t.SuperBowlWins)) - 1
            Console.WriteLine(String.Format("| Super Bowl Wins: {0}", t.SuperBowlWins) + StrDup(ws, " ") + "|")
            Console.WriteLine("+" + StrDup(Len(label) - 2, "-") + "+")
            Console.WriteLine()
        Next

        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()

    End Sub

End Module
