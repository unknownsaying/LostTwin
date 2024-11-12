Imports System

Module ColdWorld
    Sub Main()
        Console.WriteLine("Welcome to the Very Cold World")

        Dim playerName As String = GetPlayerName()
        Dim hasCoat As Boolean = False
        Dim hasShelter As Boolean = False

        Console.Clear()
        Console.WriteLine($"Hello, {playerName}. You find yourself in a world of eternal winter.")
        Console.WriteLine("The biting cold seeps through your clothes, chilling you to the bone.")

        While True
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("1. Look for a warm coat")
            Console.WriteLine("2. Search for shelter")
            Console.WriteLine("3. Explore the frozen landscape")
            Console.WriteLine("4. Give up and exit")

            Dim choice As String = Console.ReadLine()

            Select Case choice
                Case "1"
                    If Not hasCoat Then
                        Console.WriteLine("You trudge through the snow and find an abandoned cabin.")
                        Console.WriteLine("Inside, you discover a thick, fur-lined coat. You put it on, feeling warmer already.")
                        hasCoat = True
                    Else
                        Console.WriteLine("You already have a warm coat. The biting wind doesn't bother you as much now.")
                    End If

                Case "2"
                    If Not hasShelter Then
                        Console.WriteLine("You spot a cave in the distance and make your way towards it.")
                        Console.WriteLine("The cave provides shelter from the howling wind. You decide to make it your temporary home.")
                        hasShelter = True
                    Else
                        Console.WriteLine("You're already aware of the cave shelter. It's a comforting thought in this harsh world.")
                    End If

                Case "3"
                    If hasCoat AndAlso hasShelter Then
                        Console.WriteLine("Equipped with your warm coat and knowledge of a safe shelter,")
                        Console.WriteLine("you venture out into the frozen landscape. The world is harsh but beautiful.")
                        Console.WriteLine("In the distance, you spot a glimmer of hope - could it be signs of other survivors?")
                        Console.WriteLine()
                        Console.WriteLine("Congratulations! You've survived the Very Cold World and found a new purpose.")
                        Console.WriteLine("THE END")
                        Exit While
                    ElseIf hasCoat Then
                        Console.WriteLine("Your new coat keeps you warm, but without shelter, you can't venture too far.")
                        Console.WriteLine("You return, knowing you need to find a safe haven before exploring further.")
                    ElseIf hasShelter Then
                        Console.WriteLine("You have a safe place to return to, but without proper clothing,")
                        Console.WriteLine("the bitter cold forces you to turn back quickly.")
                    Else
                        Console.WriteLine("The cold is too intense. Without proper gear or shelter,")
                        Console.WriteLine("you're forced to turn back, your teeth chattering uncontrollably.")
                    End If

                Case "4"
                    Console.WriteLine("The cold becomes too much. You close your eyes, letting the frost take you.")
                    Console.WriteLine("GAME OVER")
                    Exit While

                Case Else
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 4.")
            End Select

            Console.WriteLine()
        End While

        Console.WriteLine()
        Console.WriteLine("Thank you for playing 'Very Cold World'!")
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub

    Function GetPlayerName() As String
        Console.Write("Enter your name, brave explorer: ")
        Dim name As String = Console.ReadLine().Trim()
        If String.IsNullOrEmpty(name) Then
            name = "Adventurer"
        End If
        Return name
    End Function
End Module
