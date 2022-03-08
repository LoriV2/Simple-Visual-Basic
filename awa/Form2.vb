Imports System.Net
Imports System.Net.Sockets
Imports System.IO


Public Class Form2
    Private client As TcpClient
    Public STR As StreamReader
    Public STW As StreamWriter
    Public receive As String
    Public textToSend As String

    Public ServerIP As String
    Public ServerPORT As String
    Public username As String
    Public ClientIP As String
    Public ClientPORT As String
    Public Start As Boolean

    Public Sub New()

        ' To wywołanie jest wymagane przez projektanta.
        InitializeComponent()

        ' Dodaj inicjowanie po wywołaniu funkcji InitializeComponent().
        Dim localIP As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName)

        For Each address As IPAddress In localIP
            If address.AddressFamily = AddressFamily.InterNetwork Then
                ClientIP = address.ToString()
            End If
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Start = True) Then
            Dim listener As New TcpListener(IPAddress.Any, Integer.Parse(ServerPORT))
            listener.Start()
            client = listener.AcceptTcpClient()
            STR = New StreamReader(client.GetStream())
            STW = New StreamWriter(client.GetStream())
            STW.AutoFlush = True

            BackgroundWorker1.RunWorkerAsync()
            BackgroundWorker2.WorkerSupportsCancellation = True
        ElseIf (Start = False) Then
            client = New TcpClient()
            Dim IpEnd As New IPEndPoint(IPAddress.Parse(ClientIP), Integer.Parse(ClientPORT))
            Try
                client.Connect(IpEnd)

                If (client.Connected) Then
                    ChatView.AppendText("Succesfully connected to server!" + Environment.NewLine)
                    STW = New StreamWriter(client.GetStream())
                    STR = New StreamReader(client.GetStream())
                    STW.AutoFlush = True
                    BackgroundWorker1.RunWorkerAsync()
                    BackgroundWorker2.WorkerSupportsCancellation = True

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While (client.Connected)
            Try
                receive = STR.ReadLine
                Me.ChatView.Invoke(New MethodInvoker(Function()
                                                         ChatView.AppendText("YOU:" + receive + Environment.NewLine)
                                                     End Function))
                receive = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End While
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If (client.Connected) Then
            STW.WriteLine(textToSend)
            Me.ChatView.Invoke(New MethodInvoker(Function()
                                                     ChatView.AppendText("ME:" + textToSend + Environment.NewLine)
                                                 End Function))
        Else
            MessageBox.Show("Sending Failed")
        End If
        BackgroundWorker2.CancelAsync()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MSG.Text <> "") Then
            textToSend = MSG.Text
            BackgroundWorker2.RunWorkerAsync()
        End If

        MSG.Text = ""
    End Sub
End Class
