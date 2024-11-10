Imports System

Module ASCIIMapGenerator
    Sub Main()
        Dim mapWidth As Integer = 40
        Dim mapHeight As Integer = 20
        Dim map(mapHeight - 1, mapWidth - 1) As Char

        ' Generate the map
        GenerateMap(map)

        ' Display the map
        DisplayMap(map)

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub

    Sub GenerateMap(ByRef map(,) As Char)
        Dim rnd As New Random()

        For y As Integer = 0 To map.GetLength(0) - 1
            For x As Integer = 0 To map.GetLength(1) - 1
                Dim terrainType As Integer = rnd.Next(100)
                Select Case terrainType
                    Case 0 To 20
                        map(y, x) = "." ' Grass
                    Case 21 To 40
                        map(y, x) = "^" ' Mountains
                    Case 41 To 60
                        map(y, x) = "T" ' Trees
                    Case 61 To 80
                        map(y, x) = "~" ' Water
                    Case Else
                        map(y, x) = "#" ' Rocks
                End Select
            Next
        Next
    End Sub

    Sub DisplayMap(map(,) As Char)
        Console.WriteLine("ASCII Map:")
        Console.WriteLine("'.': Grass, '^': Mountains, 'T': Trees, '~': Water, '#': Rocks")
        Console.WriteLine()

        For y As Integer = 0 To map.GetLength(0) - 1
            For x As Integer = 0 To map.GetLength(1) - 1
                Console.Write(map(y, x))
        Next
    End Sub
End Module