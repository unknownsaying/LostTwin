Imports System

Public Class WildMan
    ' Properties
    Public Property Name As String
    Public Property Age As Integer
    Public Property DaysInWild As Integer
    Public Property HealthStatus As String
    Public Property Inventory As New List(Of String)

    ' Constructor
    Public Sub New(name As String, age As Integer)
        Me.Name = name
        Me.Age = age
        Me.DaysInWild = 0
        Me.HealthStatus = "Good"
        Me.Inventory.AddRange({"Knife", "Water bottle", "Matches"})
    End Sub

    ' Methods
    Public Sub Forage()
        Console.WriteLine($"{Name} is foraging for food.")
        Dim random As New Random()
        If random.Next(1, 5) = 1 Then
            Inventory.Add("Berries")
            Console.WriteLine($"{Name} found some berries!")
        Else
            Console.WriteLine($"{Name} couldn't find any food this time.")
        End If
    End Sub

    Public Sub BuildShelter()
        Console.WriteLine($"{Name} is building a shelter.")
        DaysInWild += 1
        Console.WriteLine($"Days survived in the wild: {DaysInWild}")
    End Sub

    Public Sub CheckHealth()
        If DaysInWild > 10 AndAlso Not Inventory.Contains("Food") Then
            HealthStatus = "Weakening"
        End If
        Console.WriteLine($"{Name}'s health status: {HealthStatus}")
    End Sub

    Public Sub DisplayInventory()
        Console.WriteLine($"{Name}'s inventory:")
        For Each item In Inventory
            Console.WriteLine($"- {item}")
        Next
    End Sub
End Class

' Example usage
Module Program
    Sub Main()
        Dim survivalist As New WildMan("John", 35)
        
        survivalist.BuildShelter()
        survivalist.Forage()
        survivalist.CheckHealth()
        survivalist.DisplayInventory()
    End Sub
End Module