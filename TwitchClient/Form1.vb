Imports TechLifeForum
Imports System.Environment
Imports Newtonsoft

Public Class Form1
    Private WithEvents client As IrcClient
    Dim currentChannel As String
    Dim FILE_NAME As String = GetFolderPath(SpecialFolder.ApplicationData) & "\TLDTwitchClient\login.dat"

    Private Sub btnChangeStreams_Click(sender As Object, e As EventArgs) Handles btnChangeStreams.Click
        connect(txtChannel.Text)
        txtChannel.Text = ""
    End Sub
    Private Sub txtChannel_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtChannel.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            connect(txtChannel.Text)
            txtChannel.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists(GetFolderPath(SpecialFolder.ApplicationData) & "\TLDTwitchClient") Then
            System.IO.Directory.CreateDirectory(GetFolderPath(SpecialFolder.ApplicationData) & "\TLDTwitchClient")
        End If
        client = New IrcClient("irc.twitch.tv", 6667)
        If Not readLogin() Then
            client.Nick = InputBox("Please provide your twitch account name.")
            client.ServerPass = InputBox("Please provide your Oauth.")
        End If
        client.Connect()
        Threading.Thread.Sleep(1000)
        connect(client.Nick)


    End Sub

    Private Sub irc_ChannelMessage(Channel As String, User As String, Message As String) Handles client.ChannelMessage
        Dim message1 As String = User & ":" & " " & Message & vbNewLine
        Dim message2 As String
        txtChatOut.AppendText(message1)
    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        sendMessage()
    End Sub

    Private Sub txtChatIn_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtChatIn.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            sendMessage()
        End If
    End Sub

    Private Sub btnSaveLogin_Click(sender As Object, e As EventArgs) Handles btnSaveLogin.Click
        writeLogin()
    End Sub

    Private Sub sendMessage()
        If client.Connected = True Then
            client.SendMessage(currentChannel, txtChatIn.Text)
            txtChatOut.AppendText(client.Nick & ":" & " " & txtChatIn.Text & vbNewLine)
            txtChatIn.Text = ""
        Else
            MessageBox.Show("Error Sending message, you are not connected to the chat servers!")
        End If

    End Sub

    Private Sub writeLogin()
        If Not System.IO.File.Exists(FILE_NAME) Then
            System.IO.File.Create(FILE_NAME).Close()
        End If
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        Dim LoginInfo As String = client.Nick & vbNewLine & client.ServerPass
        objWriter.Write(LoginInfo)
        objWriter.Flush()
        objWriter.Close()
    End Sub

    Private Function readLogin() As Boolean
        Dim TextLine As String = ""

        If System.IO.File.Exists(FILE_NAME) Then
            Dim srFileReader As System.IO.StreamReader
            Dim count As Integer = 0

            srFileReader = System.IO.File.OpenText(FILE_NAME)
            Do Until count = 2
                If count = 0 Then
                    client.Nick = srFileReader.ReadLine()
                Else
                    client.ServerPass = srFileReader.ReadLine()
                End If
                count = count + 1
            Loop
            Console.WriteLine(client.Nick)
            Console.WriteLine(client.ServerPass)
            Return True
        Else

            Return False

        End If
        Return False
    End Function

    Private Sub connect(channel As String)
        Dim stream As String = "http://www.twitch.tv/" & channel.ToLower & "/embed"
        wbStream.Url = New Uri(stream)
        If Not currentChannel = Nothing Then
            client.PartChannel(currentChannel)
        End If
        client.JoinChannel("#" & channel.ToLower)
        currentChannel = "#" & channel.ToLower
        lblTitle.Text = "Current Channel: " & channel.ToLower
    End Sub
End Class
