Public Class Pause

    Private Sub Pause_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.MiiChannelMusic,
              AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        My.Computer.Audio.Stop()
        Dim menu = New frmMain()
        menu.Show()
        Me.Close()
        Dim game = New frmFirstLevel()
        game.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        My.Computer.Audio.Stop()
    End Sub
End Class