Public Class frmCredits

    Private Sub frmCredits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.MiiChannelMusic,
              AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Stop()
        Dim menu = New frmMain()
        menu.Show()
        Me.Close()
    End Sub

    Private Sub lblNames_Click(sender As Object, e As EventArgs) Handles lblNames.Click

    End Sub
End Class