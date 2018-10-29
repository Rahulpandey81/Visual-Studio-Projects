Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.User = TextBox1.Text
        My.Settings.Password = TextBox2.Text
        My.Settings.Save()
        MsgBox("Account Created Successfully")
        Me.Hide()
        Form1.Show()


    End Sub
End Class