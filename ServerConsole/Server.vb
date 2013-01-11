﻿Imports System.Net.Sockets, System.Threading, System.IO, System.Net
Imports System.Text

Imports System.windows.forms
Imports System.drawing

Imports System.Data, System.Data.SqlClient


Module Server

    Public SERVER_ADDRESS, USERNAME, PASSWORD As String
    Dim serverSocket As New TcpListener(System.Net.IPAddress.Any, 2012)
    Private listenThread As Thread
    Private clients As New List(Of hndlClient)

    Private Sub init()
        Dim Notifyicon As New NotifyIcon
        Notifyicon.Icon = New System.Drawing.Icon("..\..\logo.ico")
        Notifyicon.Visible = True
        'Add a context menu with some statistics for the program or something.

    End Sub

    Sub Main()
        SERVER_ADDRESS = "ADGATL-PC"
        USERNAME = "Test"
        PASSWORD = "adg10990"

        serverSocket.Start()
        listenThread = New Thread(AddressOf doListen)
        message("Now Listening on port 2012.")
        Console.Write(">>")
        listenThread.IsBackground = True
        listenThread.Start()

        init()

        Do
            Select Case Console.ReadLine().ToLower
                Case "exit"
                    Console.Write("Shutting Down........")
                    Exit Do
                Case "clearhistory"
                    clearHistory()
                Case "clr"
                    Console.Clear()
                    Console.Write(">>")
                Case "online"
                    For Each client As hndlClient In clients
                        Console.WriteLine(client.Username.ToString & ": " & client.Check_Client_connection())
                    Next
                    Console.Write(">>")
                Case "help"
                    'TODO: Add Help. Or get some.
                    Console.WriteLine("Help:")
                    Console.WriteLine()
                    Console.WriteLine("clr : Clears screen.")
                    Console.WriteLine("online : Shows all connected clients.")
                    Console.WriteLine("exit :  Shut Down Listener and Exit")
                    Console.WriteLine("serverconfig : Configure SQL server settings")
                    Console.Write(">>")
                Case "serverconfig"
                    configureSQLServer()
                Case Else
                    Console.WriteLine("Command not recognized")

                    Console.Write(">>")
            End Select
        Loop


    End Sub
    Private Sub configureSQLServer()
        Console.WriteLine("Current SQL server settings are as follows: ")
        Console.WriteLine("SERVER ADDRESS: " + SERVER_ADDRESS)
        Console.WriteLine("USERNAME: " + USERNAME)
        Console.WriteLine("PASSWORD: " + PASSWORD)
        Console.WriteLine("\n Which setting would you like to change? s for server address, u for username, p for password, e for exit")
        Select Case Console.ReadLine.ToLower
            Case "s"
                Console.WriteLine("Enter new server address: ")

            Case "u"
            Case "p"
            Case "e"
            Case Else
                Console.WriteLine("Not recognized, try again.")
        End Select



    End Sub
    Private Sub doListen()
        Dim incomingClient As TcpClient
        Do
            incomingClient = serverSocket.AcceptTcpClient()
            Dim connectedClient As New hndlClient(incomingClient)
            AddHandler connectedClient.dataReceived, AddressOf messageFromClient
            clients.Add(connectedClient)
            connectedClient.startClient(incomingClient, clients.IndexOf(connectedClient))
            message("Client " + incomingClient.Client.RemoteEndPoint.ToString + " Connected")
        Loop

    End Sub
    Private Sub clearHistory()
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = connectToDatabase()
        sqlCmd.CommandText = "truncate table tbl_history"
        Try
            sqlCmd.ExecuteNonQuery()
            message("Cleared")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub message(ByVal msg As String)
        msg.Trim()
        Console.WriteLine(" >> " + msg)
    End Sub

    Sub messageFromClient(ByVal sender As hndlClient, ByVal msg As String)
        msg.Trim()
        Console.WriteLine(sender.Username + ": " + msg)
    End Sub

    Private Sub delimtMessage(ByVal arry As String)
        Dim msg(0 To 5) As String
        msg = Split(arry, Chr(7).ToString)

        Dim rmv() As Char = {Chr(32), Chr(3), Chr(131), Chr(2)}
        msg(0) = msg(0).Substring(1)
        For Each a As String In msg
            a.Trim(rmv)
            message(a)
        Next
        addSQL(msg)
    End Sub

#Region "TCP Client Handler, Contains Thread for network stream to listen for messages"


    Public Class hndlClient
        Dim clientSocket As TcpClient
        Dim clNo As String
        Dim ctThread As Threading.Thread

        Private mUsr As String
        Sub New(ByVal client As TcpClient)
            clientSocket = client
        End Sub
        '*** Not implemented yet. However, should be able to test the status of a socket with this method. Just call it every so often in a thread
        Public Function Check_Client_connection() As Boolean
            Dim ClientStatus As Boolean
            If clientSocket.Connected Then
                If clientSocket.Client.Available = 0 And clientSocket.Client.Poll(1000, SelectMode.SelectRead) = True Then
                    ClientStatus = False
                Else
                    ClientStatus = True
                End If
            Else
                ClientStatus = False
            End If
            Return ClientStatus
        End Function

        Public Event dataReceived(ByVal sender As hndlClient, ByVal msg As String)

        Public Sub startClient(ByVal incomingClientSocket As TcpClient, ByVal incomingClientNumber As String)
            Me.clientSocket = incomingClientSocket
            Me.clNo = incomingClientNumber
            Me.mUsr = incomingClientSocket.Client.RemoteEndPoint.ToString

            ctThread = New Threading.Thread(AddressOf doSndRec)
            ctThread.IsBackground = True
            ctThread.Start()

        End Sub

        Public Property Username() As String
            Get
                Return mUsr
            End Get
            Set(ByVal value As String)
                mUsr = value
            End Set
        End Property
        Private Sub doSndRec()
            Dim run As Boolean = True
            Dim byteRec(10024) As Byte
            Dim byteRead As Integer
            Dim dataRec As String = ""


            While (run)
                Try
                    Dim networkStream As NetworkStream = clientSocket.GetStream()

                    byteRead = clientSocket.GetStream.Read(byteRec, 0, 1024)
                    If byteRead > 0 Then

                        dataRec = ASCIIEncoding.ASCII.GetString(byteRec)
                        Dim trims() As Char = {Chr(2), Chr(3)}
                        dataRec.Trim(trims)

                        Dim subMessages() As String = dataRec.Split(Chr(3))

                        RaiseEvent dataReceived(Me, subMessages(0))
                        delimtMessage(subMessages(0))
                    End If


                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End While

        End Sub
    End Class

#End Region

#Region "SQL"

    Private Sub addSQL(ByVal msg() As String)
        Dim sqlReader As SqlDataReader
        '***************
        '                   Right now, the Processor sends a default date. Need to find out if the timestamp is sent from the device or developed from the server as a message is received
        '                   the date should be in 24 hr format
        '               Current Assumption that Room,Device and Device type already exist in the Database
        '               msg(0) = Time Sent
        '               msg(1) = Room Name
        '               msg(2) = Device Type
        '               msg(3) = Device Local ID
        '               msg(4) = Attribute
        '               msg(5) = Value
        '***************
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = connectToDatabase()

        'More has been added for the SQL server to compute. Instead of computing Error codes and inserting into database in VB, call SRP in SQL to Determine if the message contains an error, if it does, find the error code
        ' and add to the history table or if it is return to normal and add to the history table

        sqlCmd.CommandText = "Declare @return_value varchar(20) Exec @return_value = [dbo].[spr_AddMessage] @TimeReceived = '" + Format(Now, "yyyy-MM-dd HH:mm:ss").ToString _
                                + "', @timeSent = '" + msg(0) _
                                + "', @RoomName = '" + msg(1) _
                                + "',@DeviceType = '" + msg(2) _
                                + "',@LocalID = " + msg(3) _
                                + ",@Attribute = '" + msg(4) _
                                + "', @Value = '" + msg(5) _
                                + "' Select 'Return Value' = @return_value"
        Try

            sqlReader = sqlCmd.ExecuteReader()
            While sqlReader.Read()
                message(sqlReader(0).ToString)
            End While
        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function connectToDatabase() As SqlConnection
        Dim SqlConnection As New SqlConnection
        Dim conString As String = "server=" & SERVER_ADDRESS & ";" _
                                  & "user id=" & USERNAME & ";" _
                                  & "password=" & PASSWORD & ";" _
                                  & "Initial Catalog = Hotel;"
        SqlConnection.ConnectionString = conString
        Try
            SqlConnection.Open()
        Catch ex As SqlException
            MsgBox("Error Connecting to Database: " & ex.Message)
        End Try
        Return SqlConnection
    End Function
#End Region

End Module
