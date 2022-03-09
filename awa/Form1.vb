Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles send.Click


        Form2.Start = True
        Form2.ServerIP = serverboxIP.Text
        Form2.ServerPORT = ServerboxPORT.Text
        Form2.username = Username.Text
        Form2.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        Form2.Start = False
        Form2.ClientIP = ClientBoxIP.Text
        Form2.ClientPORT = ClientBoxPORT.Text
        Form2.username = Username.Text
        Form2.Show()
    End Sub
End Class
