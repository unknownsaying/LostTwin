Imports System.Windows.Forms

Public Class Form1
    Private WithEvents btnStart As New Button
    Private WithEvents progressBar As New ProgressBar
    Private WithEvents timer As New Timer
    Private lblStatus As New Label

    Public Sub New()
        ' Set the form properties
        Me.Text = "Way to Heaven"
        Me.Size = New Size(300, 200)

        ' Configure the Start button
        btnStart.Text = "Start Journey"
        btnStart.Location = New Point(100, 50)
        btnStart.Size = New Size(100, 30)

        ' Configure the progress bar
        progressBar.Location = New Point(50, 100)
        progressBar.Size = New Size(200, 20)
        progressBar.Minimum = 0
        progressBar.Maximum = 100

        ' Configure the status label
        lblStatus.Location = New Point(50, 130)
        lblStatus.Size = New Size(200, 20)
        lblStatus.Text = "Click 'Start Journey' to begin"

        ' Configure the timer
        timer.Interval = 100 ' 100 milliseconds

        ' Add controls to the form
        Me.Controls.Add(btnStart)
        Me.Controls.Add(progressBar)
        Me.Controls.Add(lblStatus)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        progressBar.Value = 0
        timer.Start()
        btnStart.Enabled = False
        lblStatus.Text = "Ascending to heaven..."
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If progressBar.Value < progressBar.Maximum Then
            progressBar.Value += 1
        Else
            timer.Stop()
            lblStatus.Text = "You've reached heaven!"
            btnStart.Enabled = True
        End If
    End Sub
End Class