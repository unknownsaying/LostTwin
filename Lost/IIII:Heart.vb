Imports System

Module BrokenHeart
    Sub Main()
        ' Define the broken heart ASCII art
        Dim heart As String() = {
            "  /\  /\    /\  /\ ",
            " /  \/  \  /  \/  \",
            " \      /  \      /",
            "  \    /    \    / ",
            "   \  /      \  /  ",
            "    \/        \/   "
        }

        ' Define colors for the two halves of the heart
        Dim leftColor As ConsoleColor = ConsoleColor.Red
        Dim rightColor As ConsoleColor = ConsoleColor.DarkRed

        ' Draw the broken heart
        For i As Integer = 0 To heart.Length - 1
            Dim line As String = heart(i)
            Dim midPoint As Integer = line.Length \ 2

            ' Draw left half of the heart
            Console.ForegroundColor = leftColor
            Console.Write(line.Substring(0, midPoint))

            ' Draw right half of the heart
            Console.ForegroundColor = rightColor
            Console.WriteLine(line.Substring(midPoint))
        End Sub

        ' Reset console color
        Console.ResetColor()

        ' Add a message
        Console.WriteLine(vbNewLine & "A heart, broken in two...")

        ' Wait for user input before closing
        Console.WriteLine(vbNewLine & "Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module