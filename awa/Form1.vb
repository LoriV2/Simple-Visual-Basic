Public Class Form1
    Dim type As String = "Type something!!"
    Dim form As Form2
    Dim Textt As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles send.Click

        If ServerboxPORT.Text Or serverboxIP.Text = "" Then
            label.Text = type
        Else
            form.Start = True
            form.ServerIP = serverboxIP.Text
            form.ServerPORT = ServerboxPORT.Text
            form.username = Text.Text
            form.Show()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If ClientBoxIP.Text Or ClientBoxPORT.Text = "" Then
            label.Text = type
        Else
            form.Start = False
            form.ClientIP = ClientBoxIP.Text
            form.ClientPORT = ClientBoxPORT.Text
            form.username = Text.Text
            form.Show()
        End If
    End Sub
End Class
