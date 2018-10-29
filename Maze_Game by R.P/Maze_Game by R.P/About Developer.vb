Public Class About_Developer

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = "Name:-Rahul Pandey" & vbCrLf & "DOB:-20/10/1996" & vbCrLf & "Address:-Nanduliya,Jasmai,Mainpuri" & vbCrLf & "Contact No:-8126123639" & vbCrLf & "Qualifiaction:-Master of computer Application"
    End Sub
End Class