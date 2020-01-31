Public Class Help
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim menu = New frmMain()
        menu.Show()
        Me.Hide()
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.MiiChannelMusic,
              AudioPlayMode.BackgroundLoop)
    End Sub
End Class