Imports System.Windows.Forms

Public Class HotWeatherForm
    Private WithEvents btnCheckTemperature As New Button
    Private lblTemperature As New Label
    Private random As New Random()

    Public Sub New()
        ' Set the form properties
        Me.Text = "Hot Weather Temperature"
        Me.Size = New Size(300, 200)

        ' Configure the Check Temperature button
        btnCheckTemperature.Text = "Check Temperature"
        btnCheckTemperature.Location = New Point(75, 50)
        btnCheckTemperature.Size = New Size(150, 30)

        ' Configure the temperature label
        lblTemperature.Location = New Point(50, 100)
        lblTemperature.Size = New Size(200, 30)
        lblTemperature.TextAlign = ContentAlignment.MiddleCenter
        lblTemperature.Font = New Font(lblTemperature.Font.FontFamily, 14, FontStyle.Bold)

        ' Add controls to the form
        Me.Controls.Add(btnCheckTemperature)
        Me.Controls.Add(lblTemperature)

        ' Set initial temperature
        UpdateTemperature()
    End Sub

    Private Sub btnCheckTemperature_Click(sender As Object, e As EventArgs) Handles btnCheckTemperature.Click
        UpdateTemperature()
    End Sub

    Private Sub UpdateTemperature()
        ' Generate a random hot temperature between 35°C and 50°C (95°F to 122°F)
        Dim temperature As Integer = random.Next(35, 51)
        
        ' Convert to Fahrenheit
        Dim temperatureF As Integer = CInt((temperature * 9 / 5) + 32)

        ' Update the label with the new temperature
        lblTemperature.Text = $"{temperature}°C ({temperatureF}°F)"

        ' Change label color based on temperature
        If temperature >= 45 Then
            lblTemperature.ForeColor = Color.Red
        ElseIf temperature >= 40 Then
            lblTemperature.ForeColor = Color.OrangeRed
        Else
            lblTemperature.ForeColor = Color.Orange
        End If
    End Sub
End Class