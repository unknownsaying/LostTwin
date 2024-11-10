Imports System

Module AbnormalBrain
    Sub Main()
        ' Define the abnormal brain ASCII art
        Dim brain As String() = {
            "      ____________________      ",
            "    /                      \    ",
            "   /     ____        ___    \   ",
            "  /     /    \     _/   \    \  ",
            " |     /  @@  \   /  @@  \    | ",
            " |    |   \/   | |   \/   |   | ",
            " |     \      /   \      /    | ",
            " |      \____/     \____/     | ",
            "  \         __     ____      /  ",
            "   \       /  \   /    \    /   ",
            "    \     /    \ /      \  /    ",
            "     \___/      V        \/     ",
            "          \            /        ",
            "           \__________/         "
        }

        ' Define colors for different parts of the brain
        Dim colors As ConsoleColor() = {
            ConsoleColor.Gray,
            ConsoleColor.DarkGray,
            ConsoleColor.Red,
            ConsoleColor.DarkRed,
            ConsoleColor.Magenta
        }

        ' Draw the abnormal brain
        Dim random As New Random()
        For i As Integer = 0 To brain.Length - 1
            Dim line As String = brain(i)
            For j As Integer = 0 To line.Length - 1
                ' Randomly choose a color for each character
                Console.ForegroundColor = colors(random.Next(colors.Length))
                Console.Write(line(j))
            Next
            Console.WriteLine()
        Next

        ' Reset console color
        Console.ResetColor()

        ' Add a message
        Console.WriteLine(vbNewLine & "An abnormal brain, full of mysteries...")

        ' Wait for user input before closing
        Console.WriteLine(vbNewLine & "Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module