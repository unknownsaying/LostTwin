Imports System
Imports System.Threading

Module AngelVision
    Sub Main()
        Console.WriteLine("You witness an angel...")
        Thread.Sleep(2000)

        ' Define the angel ASCII art
        Dim angel As String() = {
            "         /\         ",
            "        /  \        ",
            "       /____\       ",
            "      /\    /\      ",
            "     /  \  /  \     ",
            "    /    \/    \    ",
            "        _||_        ",
            "       /    \       ",
            "      /  ()  \      ",
            "     /   __   \     ",
            "    /   /  \   \    ",
            "   /___/    \___\   ",
            "       |    |       ",
            "       |    |       ",
            "       |    |       ",
            "       \____/       "
        }

        ' Define colors for different parts of the angel
        Dim colors As ConsoleColor() = {
            ConsoleColor.White,
            ConsoleColor.Yellow,
            ConsoleColor.Cyan
        }

        ' Draw the angel
        Dim random As New Random()
        For i As Integer = 0 To angel.Length - 1
            Dim line As String = angel(i)
            For j As Integer = 0 To line.Length - 1
                ' Choose a color for each character
                Console.ForegroundColor = colors(random.Next(colors.Length))
                Console.Write(line(j))
                Thread.Sleep(10) ' Slow down the drawing for effect
            Next
            Console.WriteLine()
        Next

        ' Reset console color
        Console.ResetColor()

        ' Describe the angel
        DescribeAngel()

        ' Wait for user input before closing
        Console.WriteLine(vbNewLine & "Press any key to exit...")
        Console.ReadKey()
    End Sub

    Sub DescribeAngel()
        Dim description As String() = {
            "As you gaze upon the celestial being, you're overwhelmed by its radiance.",
            "The angel's form seems to shift and shimmer, defying mortal perception.",
            "Wings of pure light unfurl, stretching beyond the limits of your vision.",
            "Its face is both terrifying and beautiful, too glorious for human eyes to fully comprehend.",
            "A sense of peace and awe washes over you, leaving you breathless.",
            "The air around you vibrates with an otherworldly energy.",
            "Time seems to stand still in the presence of this divine messenger.",
            "You feel an inexplicable connection to something greater than yourself.",
            "The angel's presence fills you with a mixture of fear and wonder.",
            "As quickly as it appeared, the vision fades, leaving you forever changed."
        }

        For Each line In description
            Console.WriteLine()
            For Each word In line.Split()
                Console.Write(word & " ")
                Thread.Sleep(100) ' Pause briefly between words for dramatic effect
            Next
            Thread.Sleep(500) ' Pause between lines
        Next
    End Sub
End Module