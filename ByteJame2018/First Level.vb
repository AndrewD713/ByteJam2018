Imports System.ComponentModel

Public Class frmFirstLevel
    Private faceLeft = False
    Private faceRight = True
    Private blnJump As Boolean = True
    Private movement As Integer = 5
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = False

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Enabled = False
            Case Keys.Left
                tmrLeft.Enabled = False
        End Select
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        tmrGameTime.Enabled = True

        Select Case e.KeyCode
            Case Keys.Escape
                Dim pause As New Pause()
                pause.Show()
                If pause.Enabled Then
                    tmrGameTime.Enabled = False
                    tmrDown.Enabled = False
                    tmrUp.Enabled = False
                    tmrLeft.Enabled = False
                    tmrRight.Enabled = False
                End If

            Case Keys.R
                Application.Restart()
                Me.Refresh()

            Case Keys.Right
                tmrRight.Enabled = True
                tmrLeft.Enabled = False

                Dim Objects() As PictureBox = {picOb1, picOb2, picOb3, picOb4, picOb5, picOb6, picOb7, picOb8, picOb9, picOb10, picOb11, picOb12}
                For x = 0 To Objects.Length - 1
                    If picPlayer.Bounds.IntersectsWith(Objects(x).Bounds) And Not (picPlayer.Top + picPlayer.Height) < (Objects(x).Top + 20) AndAlso faceRight = True Then
                        tmrRight.Enabled = False
                    End If
                Next
            Case Keys.Left
                tmrRight.Enabled = False
                tmrLeft.Enabled = True

                Dim Objects() As PictureBox = {picOb1, picOb2, picOb3, picOb4, picOb5, picOb6, picOb7, picOb8, picOb9, picOb10, picOb11, picOb12}
                For x = 0 To Objects.Length - 1
                    If picPlayer.Bounds.IntersectsWith(Objects(x).Bounds) And Not (picPlayer.Top + picPlayer.Height) < (Objects(x).Top + 20) AndAlso faceLeft = True Then
                        tmrLeft.Enabled = False
                    End If
                Next
            Case Keys.Up
                If blnJump = True Then
                    tmrUp.Enabled = True
                    blnJump = False
                End If
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Dim Objects() As PictureBox = {picCorg, picBed, picOb1, picOb2, picOb3, picOb4, picOb5, picOb6, picOb7, picOb8, picOb9, picOb10, picOb11, picOb12, picNoOb1, picNoOb2, picNoOb3, picNoOb4, picNoOb5, picNoOb6, picBurger, picCuc1, picCuc2, picpud1, picPud2}
        For x = 0 To Objects.Length - 1
            Objects(x).Left -= movement
        Next
        'Faces the player right when moving right -AD
        If faceRight = False Then
            picPlayer.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            faceRight = True
            faceLeft = False
            picPlayer.Refresh()
        End If
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        Dim Objects() As PictureBox = {picCorg, picBed, picOb1, picOb2, picOb3, picOb4, picOb5, picOb6, picOb7, picOb8, picOb9, picOb10, picOb11, picOb12, picNoOb1, picNoOb2, picNoOb3, picNoOb4, picNoOb5, picNoOb6, picBurger, picCuc1, picCuc2, picpud1, picPud2}
        For x = 0 To Objects.Length - 1
            Objects(x).Left += movement
        Next
        'Faces the player left when moving left -AD
        If faceLeft = False Then
            picPlayer.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            faceLeft = True
            faceRight = False
            picPlayer.Refresh()
        End If
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        Static x As Integer = 0
        If x < 30 Then
            picPlayer.Top -= 6
        Else
            tmrUp.Enabled = False
            tmrDown.Enabled = True
            x = 0
        End If
        x += 1
    End Sub

    Private Sub tmrDown_Tick(sender As Object, e As EventArgs) Handles tmrDown.Tick
        picPlayer.Top += 6
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) AndAlso (picPlayer.Top + picPlayer.Height) < (picGround.Top + 10) Then
            tmrDown.Enabled = False
            blnJump = True
        End If


    End Sub
    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        If Not picPlayer.Bounds.IntersectsWith(picGround.Bounds) And tmrUp.Enabled = False Then
            tmrDown.Enabled = True
        End If



        'Array for objects that let's players jump on top of them - AD
        Dim Objects() As PictureBox = {picOb1, picOb2, picOb1, picOb2, picOb3, picOb4, picOb5, picOb6, picOb7, picOb8, picOb9, picOb10, picOb11, picOb12}
        For x = 0 To Objects.Length - 1
            If picPlayer.Bounds.IntersectsWith(Objects(x).Bounds) And tmrUp.Enabled = False Then
                tmrDown.Enabled = False
                blnJump = True
            End If


            If picPlayer.Bounds.IntersectsWith(Objects(x).Bounds) And Not (picPlayer.Top + picPlayer.Height) < (Objects(x).Top + 20) Then
                If faceLeft = True Then
                    tmrLeft.Enabled = False
                End If
                If faceRight = True Then
                    tmrRight.Enabled = False
                End If


            End If


        Next
        'Cucumber speed up
        Dim Cucumbers() As PictureBox = {picCuc1, picCuc2}
        For y = 0 To Cucumbers.Length - 1
            If picPlayer.Bounds.IntersectsWith(Cucumbers(y).Bounds) AndAlso Cucumbers(y).Visible = True Then
                movement = 10
                Cucumbers(y).Visible = False
                tmrSpeed.Start()
            End If
        Next
        'Puddles Speed Down
        Dim Puddles() As PictureBox = {picpud1, picPud2}
        For z = 0 To Puddles.Length - 1
            If picPlayer.Bounds.IntersectsWith(Puddles(z).Bounds) AndAlso Puddles(z).Visible = True Then
                movement = 2
                Puddles(z).Visible = False
                tmrSpeed.Start()
            End If
        Next
        'Getting Cheesburger
        If picPlayer.Bounds.IntersectsWith(picBurger.Bounds) AndAlso picBurger.Visible = True Then
            picBurger.Visible = False
            lblGotBurger.Visible = True
            picPlayer.Image = My.Resources.cato_with_burger
        End If
        'Corg hit
        If picPlayer.Bounds.IntersectsWith(picCorg.Bounds) AndAlso picCorg.Visible = True Then
            tmrDown.Enabled = False
            tmrUp.Enabled = True
        End If
        'Win
        If picPlayer.Bounds.IntersectsWith(picNoOb2.Bounds) AndAlso picBurger.Visible = False Then
            picBurger.Visible = True
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrGameTime.Enabled = False
            lblGotBurger.Text = "You Win! Completed in " & lblTimer.Text & " Seconds"
            MessageBox.Show("You Win! Press 'R' to Restart", "Win Box")

        End If

    End Sub

    Private Sub tmrSpeed_Tick(sender As Object, e As EventArgs) Handles tmrSpeed.Tick
        movement = 5
    End Sub

    Private Sub tmrGameTime_Tick(sender As Object, e As EventArgs) Handles tmrGameTime.Tick

        lblTimer.Text = lblTimer.Text + 0.1

    End Sub

End Class