Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class frmReport
    Public SERVER_ADDRESS, USERNAME, PASSWORD As String
    Private sqlCmd As New SqlCommand
    Private sqlReader As SqlDataReader


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

    Private Sub frmReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SERVER_ADDRESS = "ADGATL-PC"
        USERNAME = "Test"
        PASSWORD = "adg10990"

    End Sub
  

    

    Private Sub btnRun_Click(sender As System.Object, e As System.EventArgs) Handles btnRun.Click
        ReportViewer.Show()
    End Sub
End Class