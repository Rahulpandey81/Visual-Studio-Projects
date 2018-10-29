Public Class frm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.MLaunch, AudioPlayMode.Background)
        Dim x, y As Integer
        x = 285
        y = 371
        For y = 371 To 1000

            PictureBox1.Top = PictureBox1.Top - 10



        Next

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Controls.Clear()
        InitializeComponent()




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.MLaunch, AudioPlayMode.Background)

  




    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Top = PictureBox1.Top - 10

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Stop()
        My.Computer.Audio.Stop()

    End Sub
End Class

