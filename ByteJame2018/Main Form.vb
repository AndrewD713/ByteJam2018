﻿Imports System.ComponentModel

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayLoopingBackgroundSound()


        lblTitle.Location = New Point(pnlTitle.ClientSize.Width, pnlTitle.ClientSize.Height / 2 - (lblTitle.Height / 2))
        tmrTitleAnimate.Start()


    End Sub

    Sub PlayLoopingBackgroundSound()
        My.Computer.Audio.Play(My.Resources.KeyboardCat,
              AudioPlayMode.BackgroundLoop)


    End Sub
    Private Sub tmrTitleAnimate_Tick(sender As Object, e As EventArgs) Handles tmrTitleAnimate.Tick
        If lblTitle.Right < 0 Then
            lblTitle.Left = pnlTitle.ClientSize.Width
        Else
            lblTitle.Left -= 10
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        My.Computer.Audio.Stop()
        Dim credits = New frmCredits()
        credits.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        My.Computer.Audio.Stop()
        Dim firstlevel = New frmFirstLevel()
        firstlevel.Show()
        Me.Hide()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim help = New Help()
        help.Show()
        Me.Hide()
    End Sub
End Class
