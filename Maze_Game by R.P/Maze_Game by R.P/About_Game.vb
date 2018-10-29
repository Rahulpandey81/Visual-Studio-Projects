Public Class About_Game

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = "In This Game we need to Find a way to" & vbCrLf & "Reach in the Final position" & vbCrLf & "If you succeessfully Reach into Finish position" & vbCrLf & "You are winner"
    End Sub
End Class