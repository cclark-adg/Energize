Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel


'Add a Legend for the colors and their meanings

Public Class Energize

    Private newMsg As Boolean = False
    Public alertList As New List(Of String)
    Private CONNECTED As Boolean
    Dim alarms As New List(Of String())

    Dim alarmCodeList As New List(Of String)
    Dim warningCodeList As New List(Of String)

    Public SERVER_ADDRESS, USERNAME, PASSWORD As String

    Public sqlCmd As New SqlCommand
    Public sqlReader As SqlDataReader

    Private Sub Energize_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NotifyIconEnergize.Visible = False
        NotifyIconEnergize.Dispose()
        sqlCmd.Dispose()
        sqlReader.Close()
    End Sub

    Private Sub Energize_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Me.BringToFront()

        SERVER_ADDRESS = "ADGATL-PC"
        USERNAME = "Test"
        PASSWORD = "adg10990"

        sqlCmd.Connection = connectToDatabase()
        If CONNECTED Then
            tssSQLStatus.Text = "Connected."
        End If
        If CONNECTED Then
            'some sql statements to get every warning code from sql server (use tbl_alarms) and a statement to get every event id from tbl_events
            'these will be used for KPI and for color coding.
            sqlCmd.CommandText = "Select alarm_code from tbl_alarms join tbl_events on tbl_alarms.warning_event_id = tbl_events.id"
            Try
                sqlReader = sqlCmd.ExecuteReader()
                While sqlReader.Read()
                    warningCodeList.Add(sqlReader(0).ToString)
                End While
                sqlReader.Close()

                sqlCmd.CommandText = "Select alarm_code from tbl_events where id <> 1"
                sqlReader = sqlCmd.ExecuteReader()
                While sqlReader.Read()
                    If warningCodeList.Count > 0 Then
                        For Each a As String In warningCodeList
                            If a <> sqlReader(0) Then
                                alarmCodeList.Add(sqlReader(0))
                            End If
                        Next
                    Else
                        alarmCodeList.Add(sqlReader(0))
                    End If

                End While
                sqlReader.Close()
            Catch ex As Exception

            End Try
            updateAlarm()
        End If


    End Sub
    Private Sub SessionComplete(ByVal nTransactionID As _
        Long, ByVal nAbilityCode As Long, ByVal bSuccess As Byte, ByVal _
        pszOutputs As String, ByVal nUserPassBack As Long)
        MessageBox.Show(bSuccess)

    End Sub
    Private Sub SessionProgress(ByVal nTransactionID As Integer, ByVal nPercentageDone As Integer, ByVal pszwProgressDescription As String, ByVal IParam As Integer)
        Debug.Print(nPercentageDone.ToString + pszwProgressDescription + IParam.ToString)
    End Sub

    'Main thread used to scan the database for alarms
    Private Sub tmrAlarm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAlarm.Tick
        If CONNECTED Then
            tssSQLStatus.Text = "Connected."
            updateAlarm()
        End If


    End Sub

    '*************************************************MESSAGE STRUCTURE****************
    '********                        alarm(0): Timestamp Recieved
    '********                        alarm(1): Timestamp Sent
    '********                        alarm(2): Room Name
    '********                        alarm(3): Device Name (DeviceType_LocalID)
    '********                        alarm(4): Attribute
    '********                        alarm(5): Description
    '********                        alarm(6): Alarm Code
    '********                        alarm(7): Priority
    '********                        alarm(8): Solution
    '***********************************************************************************
    Private Function contain(ByVal strContainer As List(Of String()), ByVal str() As String) As Boolean
        For Each a As String() In strContainer
            If a(0) = str(0) And a(1) = str(1) And a(2) = str(2) _
                And a(3) = str(3) And a(4) = str(4) And a(5) = str(5) _
                    And a(6) = str(6) And a(7) = str(7) _
                        And a(8) = str(8) Then
                Return True
            End If

        Next

        Return False

    End Function

    Private Sub addItems(ByVal items As List(Of String()))
        For Each a As String() In items
            Dim itm As New ListViewItem(a(0))
            itm.SubItems.Add(a(2))
            itm.SubItems.Add(a(5))
            itm.SubItems.Add(a(6))
            itm.SubItems.Add(a(7))

            'Select Color for alert
            If String.Equals(a(4), "ALRM_ACK") Then
                itm.BackColor = chooseColor("0")
            ElseIf String.Equals(a(4), "WRN_ACK") Then
                itm.BackColor = chooseColor("-1")
            Else
                itm.BackColor = chooseColor(a(6))
            End If
            lvAlarms.Items.Add(itm)
        Next
    End Sub
    Private Sub removeItems(ByVal items As List(Of String()))
        For a = items.Count - 1 To 0 Step -1
            lvAlarms.Items.RemoveAt(alarms.IndexOf(items(a)))
        Next
    End Sub
    Private Sub updateAlarm()

        Dim temp As New List(Of String())
        Dim toAdd As New List(Of String())
        Dim toRemove As New List(Of String())

        sqlCmd.CommandText = "exec spr_GetToView"

        Try
            sqlReader = sqlCmd.ExecuteReader()
            While sqlReader.Read()
                Dim tst() As String = _
                    {sqlReader(0).ToString, sqlReader(1).ToString, sqlReader(2).ToString, sqlReader(3).ToString, sqlReader(4).ToString, sqlReader(5).ToString, sqlReader(6).ToString, sqlReader(7).ToString, sqlReader(8).ToString}
                temp.Add(tst)

            End While
            If alarms.Count = 0 And temp.Count <> 0 Then
                If temp(0)(6) <> "WRN_RTN" Then
                    alarms.Add(temp(0))
                    addItems(alarms)
                End If
            End If
            If temp.Count = 0 Then
                removeItems(alarms)
                alarms.Clear()

            End If
            For Each a In temp
                If Not contain(alarms, a) Then
                    If a(6) <> "WRN_RTN" Then
                        toAdd.Add(a)
                    End If
                End If
            Next
            For Each a In alarms
                If Not contain(temp, a) Then
                    toRemove.Add(a)
                End If
            Next
            removeItems(toRemove)
            alarms.AddRange(toAdd)


            For Each a In toRemove
                alarms.Remove(a)
            Next
            addItems(toAdd)

        Catch ex As Exception
            MessageBox.Show("Database Error: " + ex.ToString())
        End Try
        Try
            sqlReader.Close()
        Catch ex As Exception
        End Try
        updateKPI()
    End Sub

    Private Sub updateKPI()
        Dim numAlarms As Integer = 0
        Dim numWarnings As Integer = 0
        Dim numAck As Integer = 0
        For Each a As String() In alarms
            For Each i As String In alarmCodeList
                If a(6) = i And a(6) <> "1" Then
                    numAlarms += 1
                End If
            Next
            If a(4) = "ALRM_ACK" Then
                numAck += 1
            End If
            For Each i As String In warningCodeList
                If a(6) = i Then
                    numWarnings += 1
                End If
            Next
        Next

        lblAlarms.Text = numAlarms
        lblAlarmsAckn.Text = numAck
        lblWarnings.Text = numWarnings

    End Sub

    Private Function chooseColor(ByVal code As String) As Color
        'Choose the back color of the alert message
        If alarmCodeList.Contains(code) Then
            Return Color.Red
        ElseIf warningCodeList.Contains(code) Then
            Return Color.Goldenrod
        ElseIf code = "0" Then
            Return Color.Bisque
        ElseIf code = "-1" Then
            Return Color.LightGoldenrodYellow
        Else
            Return Color.GreenYellow
        End If

    End Function

    Private Sub btnAcknowledge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcknowledge.Click
        'change any message that has been checked into the acknowledged state
        Dim needUpdate As Boolean = False
        Dim cmds(lvAlarms.CheckedItems.Count - 1) As String
        Dim i As Integer = 0
        For Each ls As ListViewItem In lvAlarms.CheckedItems
            Dim tmp() As String = alarms(ls.Index)(3).Split("_")
            If alarms(ls.Index)(6) = "RTN" Then
                cmds(i) = "INSERT INTO tbl_History (timereceived,timesent,room_id,device_id,attribute,value,event_id) VALUES('" _
                    + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") _
                    + "',(SELECT id FROM tbl_Rooms WHERE Room_Name = '" + alarms(ls.Index)(2).ToString + "')," _
                    + "(Select id from tbl_Devices where Device_Type_ID = (select id from tbl_Device_Types where device_type_name ='" _
                    + tmp(0) + "') and Room_ID = (select id from tbl_rooms where Room_Name = '" + alarms(ls.Index)(2).ToString _
                    + "') and Local_ID ='" + tmp(1) + "'),'RTN_ACK','cclark'," _
                    + "1" + ");"
                needUpdate = True
            ElseIf alarms(ls.Index)(4) <> "ALRM_ACK" And alarmCodeList.Contains(alarms(ls.Index)(6)) Then
                cmds(i) = "INSERT INTO tbl_History (timereceived,timesent,room_id,device_id,attribute,value,event_id) VALUES('" _
                    + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") _
                    + "',(SELECT id FROM tbl_Rooms WHERE Room_Name = '" + alarms(ls.Index)(2).ToString + "')," _
                    + "(Select id from tbl_Devices where Device_Type_ID = (select id from tbl_Device_Types where device_type_name ='" _
                    + tmp(0) + "') and Room_ID = (select id from tbl_rooms where Room_Name = '" _
                    + alarms(ls.Index)(2).ToString + "') and Local_ID ='" + tmp(1) + "'),'ALRM_ACK','cclark'," _
                    + "(Select id from tbl_events where Alarm_Code = '" + alarms(ls.Index)(6).ToString + "'));"
                needUpdate = True
            ElseIf warningCodeList.Contains(alarms(ls.Index)(6)) And alarms(ls.Index)(4) <> "WRN_ACK" Then
                cmds(i) = "INSERT INTO tbl_History (timereceived,timesent,room_id,device_id,attribute,value,event_id) VALUES('" _
                    + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") _
                    + "',(SELECT id FROM tbl_Rooms WHERE Room_Name = '" + alarms(ls.Index)(2).ToString + "')," _
                    + "(Select id from tbl_Devices where Device_Type_ID = (select id from tbl_Device_Types where device_type_name ='" _
                    + tmp(0) + "') and Room_ID = (select id from tbl_rooms where Room_Name = '" _
                    + alarms(ls.Index)(2).ToString + "') and Local_ID ='" + tmp(1) + "'),'WRN_ACK','cclark'," _
                    + "(Select id from tbl_events where Alarm_Code = '" + alarms(ls.Index)(6).ToString + "'));"
                needUpdate = True
            End If

            ls.Checked = False
            i += 1
        Next
        If needUpdate And CONNECTED Then
            Try
                For Each s As String In cmds
                    sqlCmd.CommandText = s
                    sqlCmd.ExecuteNonQuery()

                Next
                updateAlarm()
            Catch ex As Exception
                MessageBox.Show("Error inserting into database : " + ex.ToString)
            End Try
        End If
        
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
            CONNECTED = True
        Catch ex As SqlException
            MsgBox("Error Connecting to Database: " & ex.Message)
            CONNECTED = False
        End Try
        Return SqlConnection

    End Function

    Private Sub lvAlarms_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvAlarms.ItemSelectionChanged
        'Update the details window for the selected item
        If lvAlarms.SelectedItems.Count > 0 Then
            lblTimeStamp.Text = lvAlarms.SelectedItems(0).SubItems(0).Text
            lblID.Text = lvAlarms.SelectedItems(0).SubItems(1).Text
            lblDescription.Text = lvAlarms.SelectedItems(0).SubItems(2).Text
            lblAlarmCode.Text = lvAlarms.SelectedItems(0).SubItems(3).Text
            lblPriority.Text = lvAlarms.SelectedItems(0).SubItems(4).Text
            lblDeviceName.Text = alarms(lvAlarms.Items.IndexOf(lvAlarms.SelectedItems(0)))(3).ToString
            Try
                lblSolution.Text = alarms(lvAlarms.Items.IndexOf(lvAlarms.SelectedItems(0)))(8).ToString
            Catch ex As Exception
                lblSolution.Text = "No solution available."
            End Try
        Else
            lblTimeStamp.Text = ""
            lblID.Text = ""
            lblDescription.Text = ""
            lblAlarmCode.Text = ""
            lblPriority.Text = ""
            lblDeviceName.Text = ""
            lblSolution.Text = ""
            lblSolution.Text = ""

        End If

    End Sub


    Private Sub btnViewAlarms_Click(sender As System.Object, e As System.EventArgs) Handles btnViewAlarms.Click
        frmKPIView.loadInfo(alarms, alarmCodeList, "Alarms")
        frmKPIView.Show()
        frmKPIView.BringToFront()

    End Sub

    Private Sub btnViewAck_Click(sender As System.Object, e As System.EventArgs) Handles btnViewAck.Click
        frmKPIView.loadInfo(alarms, "ALRM_ACK", "Acknowledged Alarms")
        frmKPIView.Show()
        frmKPIView.BringToFront()

    End Sub
    Private Sub btnViewWarnings_Click(sender As System.Object, e As System.EventArgs) Handles btnViewWarnings.Click
        frmKPIView.loadInfo(alarms, warningCodeList, "Warning Alerts")
        frmKPIView.Show()
        frmKPIView.BringToFront()
    End Sub

    Private Sub lvAlarms_ColumnWidthChanging(sender As System.Object, e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lvAlarms.ColumnWidthChanging
        If e.ColumnIndex <> 2 Then
            e.NewWidth = Me.lvAlarms.Columns(e.ColumnIndex).Width
            e.Cancel = True
        End If
    End Sub

    Private Sub lvAlarms_Resize(sender As System.Object, e As System.EventArgs) Handles lvAlarms.Resize
        lvAlarms.Columns(2).Width = lvAlarms.Width - lvAlarms.Columns(0).Width - lvAlarms.Columns(1).Width - lvAlarms.Columns(3).Width - lvAlarms.Columns(4).Width
    End Sub

    Private Sub btnReports_Click(sender As System.Object, e As System.EventArgs) Handles btnReports.Click
        frmReport.BringToFront()
        frmReport.Show()
    End Sub

    Private Sub populateNotifyIconContextMenu()

        AlarmsToolStripMenuItem.DropDownItems.Clear()
        AcknowledgedAlarmsToolStripMenuItem.DropDownItems.Clear()
        For Each a As String() In alarms
            For Each i As String In alarmCodeList
                If a(6) = i And a(6) <> "1" Then
                    AlarmsToolStripMenuItem.DropDownItems.Add(a(2) & "  |  " & a(5))
                End If
            Next
            If a(4) = "ALRM_ACK" Then
                AcknowledgedAlarmsToolStripMenuItem.DropDownItems.Add(a(2) & "  |   " & a(5))
            End If
            For Each i As String In warningCodeList
                If a(6) = i Then
                    WarningsToolStripMenuItem.DropDownItems.Add(a(2) & "  |   " & a(5))
                End If
            Next
        Next
    End Sub

    Private Sub EnergizeNotifyIcon_click(sender As System.Object, e As System.EventArgs) Handles NotifyIconEnergize.Click

        populateNotifyIconContextMenu()
    End Sub
    
   
    Private Sub SQLServerConfigurationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SQLServerConfigurationToolStripMenuItem.Click
        frmServerConfig.BringToFront()
        frmServerConfig.loadForm(SERVER_ADDRESS, USERNAME, PASSWORD)

    End Sub

   
End Class
