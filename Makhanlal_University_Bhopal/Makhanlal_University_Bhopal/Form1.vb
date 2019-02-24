Imports System.Speech

Imports System.Net.Mail


Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyMailMessage As New MailMessage()
        Try
            MyMailMessage.From = New MailAddress("#Enter your mail here")
            MyMailMessage.To.Add(TextBoxTo.Text)
            MyMailMessage.Subject = TextBoxSubject.Text
            MyMailMessage.Body = RichTextBoxMessage.Text
            If Not OpenFileDialog1.FileName = vbNullString Then
                Dim attach As New Attachment(OpenFileDialog1.FileName)
                MyMailMessage.Attachments.Add(attach)

            End If


            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("#Your Mail", "#Password")
            SMTP.Send(MyMailMessage)
            MsgBox("Your Mail has been Successfully sent")
            TextBoxTo.Clear()
            TextBoxSubject.Clear()
            RichTextBoxMessage.Clear()
            TextBoxAttachment.Clear()

            TextBoxTo.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MaximizeBox = True

        TextBoxTo.Hide()
        TextBoxSubject.Hide()
        RichTextBoxMessage.Hide()
        Button1.Hide()
        Button2.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        Button3.Hide()
        Button4.Hide()
        PictureBox4.Hide()
        TextBoxAttachment.Hide()
        Label4.Hide()



        WebBrowser1.Navigate(New Uri("http://mcu.ac.in"))


    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()



    End Sub

 
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBoxAttachment.Text$ = OpenFileDialog1.FileName

    End Sub


    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click






        Me.Controls.Clear()

        InitializeComponent()



    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
