Imports System.Speech


Public Class Form1
    Dim WithEvents reg As New Recognition.SpeechRecognitionEngine
    Private Sub setcolor(ByVal color As System.Drawing.Color)
        Dim synth As New Synthesis.SpeechSynthesizer
        Me.BackColor = color

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reg.SetInputToDefaultAudioDevice()
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim colorRule As New Recognition.SrgsGrammar.SrgsRule("color")
        Dim colorList As New Recognition.SrgsGrammar.SrgsOneOf("red", "green", "yellow", "black", "gunfire", "my image", "notepad", "font")


        colorRule.Add(colorList)
        gram.Rules.Add(colorRule)
        gram.Root = colorRule

        reg.LoadGrammar(New Recognition.Grammar(gram))
        reg.RecognizeAsync()


    End Sub

    Private Sub reg_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reg.RecognizeCompleted
        reg.RecognizeAsync()

    End Sub

    Private Sub reg_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.SpeechRecognizedEventArgs) Handles reg.SpeechRecognized
        Select Case e.Result.Text
            Case "red"
                setcolor(Color.Red)
            Case "green"
                setcolor(Color.Green)
            Case "yellow"
                setcolor(Color.Yellow)
            Case "black"
                setcolor(Color.Black)
            Case "gunfire"
                My.Computer.Audio.Play(My.Resources.gun, AudioPlayMode.Background)
            Case "notepad"
                System.Diagnostics.Process.Start("notepad.exe")
            Case "font"
                System.Diagnostics.Process.Start("font")



        End Select
    End Sub

End Class
