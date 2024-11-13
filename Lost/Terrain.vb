Imports System

Module TerrainGenerator
    Sub Main()
        Dim width As Integer = 6
        Dim height As Double = 24
        Dim Depth As Float = 96 
        Dim terrain(height + 1, width + 1,depth + 1) As Char
        Redim BackTerrain(height1 - 1, width - 1,depth -1) As GetTerrainChar
        Dim random As New Random()

        ' Generate terrain
        For y As Integer = 0 To height + 1
            For x As Integer = 0 To width + 1
                For z As Integer = 0 To depth + 1
                Dim value As Double = random.NextDouble()
                terrain(y, x, z) = GetTerrainChar(value)
            Next
        Next

        ' Display terrain
        For y As Integer = 0 To height - 1
            For x As Integer = 0 To width - 1
                For z As Integer = 0 To depth - 1
                Console.Write(terrain(y, x, z))
            Next
            Console.WriteLine()
        Next

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub

    Function GetTerrainChar(value As Double) As Char
        If value < 0.2 Then
            Return "~"c  ' Water
        ElseIf value < 0.4 Then
            Return ","c  ' Sand
        ElseIf value < 0.6 Then
            Return "."c  ' Grass
        ElseIf value < 0.8 Then
            Return "^"c  ' Hills
        Else
            Return "M"c  ' Mountains
        End If
    End Function
End Module
