Imports System.Data.Sql
Imports System.Data.SqlClient
Imports VPTCOMSERVERLib
Imports Excel = Microsoft.Office.Interop.Excel


Public Class frmMain

#Region "Variables"

#Region "Crestron"

    Private crestron As New VptSession3()
    Private transactionIDs As New List(Of Long)
    Private errorNumber As Integer = 0
    Private successNumber As Integer = 0
    Private errorTransactions As New List(Of Long)
    Private successTransactions As New List(Of Long)
#End Region

#Region "SQL Variables"
    Public sqlCmd As New SqlCommand
    Public sqlReader As SqlDataReader
    Public SERVER_ADDRESS, USERNAME, PASSWORD As String
    Public SQLCONNECTED As Boolean = False
#End Region

#Region "Excel Variables"
    
#End Region

#Region "Room Type Editor Variables"
    Private RTE_roomTypeList As New List(Of String())

    Private RTE_currentDevices As New List(Of String)
    Private RTE_addedDevices As New List(Of String)
    Private RTE_allDevices As New List(Of String)
    Private RTE_currentLocalIDs As New List(Of String)
    Private RTE_addedLocalIDs As New List(Of String)

#End Region

#Region "Alarm Editor Variables"
    Private AE_deviceTypeList As New List(Of String())
    Private AE_warningEventsCodes As New List(Of String)
    Private AE_currentSelectedDevice As String() = {"", "", "", "", "", "", "", "", "", "", ""}
#End Region

#Region "Room Editor Variables"
    Dim RE_roomList As New List(Of String())
    Dim ctrlMultiSelect As Boolean = False
    Dim shiftMultiSelect As Boolean = False
    Dim RE_SelectedNodesByFloor As New List(Of TreeNode)
    Dim RE_SelectedNodesByType As New List(Of TreeNode)
    Dim RE_Ip As New List(Of String)
    Dim WithEvents sessions As New List(Of VptSession3)
    Dim RE_process As Boolean = False
    Dim RE_ProgramLoadingIndex As Integer = 0
    Dim programLoad As frmProgramLoad
    Dim RE_loadComplete As Boolean = False
#End Region

#Region "Event Editor Variables"
    Private EE_eventList As New List(Of String())
    Private EE_currentEvent As String() = {"", "", "", "", ""}
#End Region

#Region "State Manager Variables"
    Private SM_deviceTypeList As New List(Of String())
#End Region

#End Region

#Region "SQL Methods"
    Public Function connectToDatabase() As SqlConnection
        Dim SqlConnection As New SqlConnection
        Dim conString As String = "server=" & SERVER_ADDRESS & ";" _
                                  & "user id=" & USERNAME & ";" _
                                  & "password=" & PASSWORD & ";" _
                                  & "Initial Catalog = Hotel;"


        SqlConnection.ConnectionString = conString

        Try
            SqlConnection.Open()
            SQLCONNECTED = True
            MsgBox("Connected.")

        Catch ex As SqlException
            MsgBox("Error Connecting to Database: " & ex.Message)
            SQLCONNECTED = False
        End Try
        Return SqlConnection

    End Function
#End Region

#Region "Crestron Methods"
    
    Private Sub StrComplete(ByVal transactionID As Long, ByVal nAbilityCode As Long, ByVal bSuccess As Byte, ByVal pszOutputs As String, ByVal nUserPassBack As Long)
        Debug.Print("Transaction Complete: " + transactionID.ToString)
        If bSuccess = 0 Then
            errorNumber += 1
            errorTransactions.Add(transactionID)
        Else
            successNumber += 1
            successTransactions.Add(transactionID)

        End If

        If (successNumber + errorNumber) Mod 64 = 0 And (successNumber + errorNumber) <> 0 And (successNumber + errorNumber) <> RE_Ip.Count Then
            closeConnections()
            sessions.Clear()
            GC.Collect()
            RE_process = True
        ElseIf (successNumber + errorNumber) = RE_Ip.Count And Not RE_loadComplete Then
            RE_tmrProgramLoad.Stop()
            RE_loadComplete = True
            MessageBox.Show("Number Of Errors: " & errorNumber.ToString & "         Number of Successes: " & successNumber)
            tssLbl_Status.Text = "Loading Complete."
            closeConnections()
            sessions.Clear()
            GC.Collect()
        End If

    End Sub

    Private Sub closeConnections()
        If sessions.Count <> 0 Then
            For i = 0 To sessions.Count - 1 Step 1
                If sessions.Count <> 0 Then
                    sessions(i).CloseSession()
                End If

            Next
        End If

    End Sub
   

#End Region

#Region "Applications"

#Region "Room Type Editor"

    Private Sub updateRoomTypes()
        RTE_lbRoomTypes.Items.Clear()
        RTE_roomTypeList.Clear()
        sqlCmd.CommandText = "Select * From tbl_RoomType"
        If SQLCONNECTED Then
            Try
                sqlReader = sqlCmd.ExecuteReader()
                While sqlReader.Read()
                    RTE_roomTypeList.Add(New String() {sqlReader(0), sqlReader(1), sqlReader(2)})
                    RTE_lbRoomTypes.Items.Add(sqlReader(1))
                End While
            Catch ex As Exception
                MessageBox.Show("Error in inserting to db: " + ex.ToString)
            Finally

                sqlReader.Close()
            End Try
        End If
        

    End Sub
    Private Sub clearControls()
        RTE_currentDevices.Clear()
        RTE_addedDevices.Clear()
        RTE_allDevices.Clear()
        RTE_tvDevicesAdded.Nodes.Clear()
        RTE_lbDeviceTypesAvailable.Items.Clear()
        RTE_tbProgramName.Text = ""
    End Sub

    Private Sub getDevices(ByVal roomTypeID As Integer)
        RTE_currentDevices.Clear()
        RTE_addedDevices.Clear()
        RTE_allDevices.Clear()
        RTE_addedLocalIDs.Clear()
        RTE_currentLocalIDs.Clear()
        RTE_tvDevicesAdded.Nodes.Clear()
        RTE_lbDeviceTypesAvailable.Items.Clear()

        sqlCmd.CommandText = "select tbl_device_types.device_type_name from tbl_roomdevicestypes" _
                + " Join tbl_device_types" _
                + " on tbl_roomdevicestypes.deviceType_id = tbl_device_types.id where roomtype_id = " & roomTypeID & ";"
        Try
            sqlReader = sqlCmd.ExecuteReader()
            While sqlReader.Read()
                RTE_addedDevices.Add(sqlReader(0))
                RTE_currentDevices.Add(sqlReader(0))
                RTE_tvDevicesAdded.Nodes.Add(sqlReader(0))
            End While
            sqlReader.Close()

            sqlCmd.CommandText = "Select device_type_name from tbl_device_types"
            sqlReader = sqlCmd.ExecuteReader()
            While sqlReader.Read()
                RTE_allDevices.Add(sqlReader(0))
            End While
            sqlReader.Close()

            sqlCmd.CommandText = "select tbl_device_types.Device_Type_Name , local_id_number from tbl_local_ids" _
                                + " Join" _
                                + " tbl_Device_Types on device_type_id = id where room_type_id = " & roomTypeID & ";"
            sqlReader = sqlCmd.ExecuteReader()
            While sqlReader.Read()
                RTE_currentLocalIDs.Add(sqlReader(0) & "_" & sqlReader(1))
                RTE_addedLocalIDs.Add(sqlReader(0) & "_" & sqlReader(1))
            End While

            updateNodes(RTE_currentLocalIDs)
            sqlReader.Close()

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.ToString())
        Finally
            sqlReader.Close()
        End Try

        For Each a As String In RTE_addedDevices
            RTE_allDevices.Remove(a)
        Next
        For Each a As String In RTE_allDevices
            RTE_lbDeviceTypesAvailable.Items.Add(a)
        Next
    End Sub

    Private Sub updateNodes(ByVal localIds As List(Of String))
        For Each a As TreeNode In RTE_tvDevicesAdded.Nodes
            For Each s As String In localIds
                Dim split() As String = s.Split("_")
                If split(0) = a.Text Then
                    a.Nodes.Add(s)
                End If
            Next
        Next
    End Sub
    Private Sub lbRoomTypes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles RTE_lbRoomTypes.SelectedIndexChanged
        getDevices(RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(0))
        RTE_tbProgramName.Text = RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(2)
    End Sub

    Private Sub btnDeviceAdd_Click(sender As System.Object, e As System.EventArgs) Handles RTE_btnDeviceAdd.Click
        If RTE_lbDeviceTypesAvailable.SelectedIndex > -1 Then
            RTE_tvDevicesAdded.Nodes.Add(RTE_lbDeviceTypesAvailable.SelectedItem.ToString)
            RTE_addedDevices.Add(RTE_lbDeviceTypesAvailable.SelectedItem.ToString)
            RTE_allDevices.RemoveAt(RTE_lbDeviceTypesAvailable.SelectedIndex)

            RTE_lbDeviceTypesAvailable.Items.RemoveAt(RTE_lbDeviceTypesAvailable.SelectedIndex)
        End If
    End Sub

    Private Sub btnDeviceRemove_Click(sender As System.Object, e As System.EventArgs) Handles RTE_btnDeviceRemove.Click
        If RTE_tvDevicesAdded.SelectedNode.Index > -1 Then
            RTE_lbDeviceTypesAvailable.Items.Add(RTE_tvDevicesAdded.SelectedNode.Text)

            RTE_addedDevices.RemoveAt(RTE_tvDevicesAdded.SelectedNode.Index)
            RTE_allDevices.Add(RTE_tvDevicesAdded.SelectedNode.Text)

            RTE_tvDevicesAdded.Nodes.RemoveAt(RTE_tvDevicesAdded.SelectedNode.Index)
        End If
    End Sub

    Private Sub btnAllDeviceAdd_Click(sender As System.Object, e As System.EventArgs) Handles RTE_btnAllDeviceAdd.Click
        For Each a As String In RTE_allDevices
            RTE_tvDevicesAdded.Nodes.Add(a)
            RTE_addedDevices.Add(a)
            RTE_lbDeviceTypesAvailable.Items.Remove(a)
        Next
        RTE_allDevices.Clear()
    End Sub

    Private Sub btnAllDeviceRemove_Click(sender As System.Object, e As System.EventArgs) Handles RTE_btnAllDeviceRemove.Click
        For Each a As String In RTE_addedDevices
            RTE_lbDeviceTypesAvailable.Items.Add(a)
            RTE_allDevices.Add(a)
        Next
        RTE_addedDevices.Clear()
        RTE_tvDevicesAdded.Nodes.Clear()
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles RTE_btnBrowseProgram.Click
        Dim filepath As String

        openProgram.ShowDialog()
        filepath = openProgram.FileName
        RTE_tbProgramName.Text = filepath
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles RTE_btnSave.Click
        Dim cmds As New List(Of String)
        For Each dev As String In RTE_currentDevices
            If Not RTE_addedDevices.Contains(dev) Then
                cmds.Add("Delete from tbl_roomdevicestypes where roomtype_id = " + RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(0) + " and deviceType_ID = " _
                         + "(Select id from tbl_device_types where device_type_name = '" + dev + "');")
            End If
        Next
        For Each dev As String In RTE_addedDevices
            If Not RTE_currentDevices.Contains(dev) Then
                cmds.Add("Insert into tbl_roomdevicestypes values( " + RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(0) + "," _
                         + "(Select id from tbl_device_types where device_type_name = '" + dev + "'));")
            End If
        Next
        For Each locDev As String In RTE_currentLocalIDs
            If Not RTE_addedLocalIDs.Contains(locDev) Then
                Dim split() As String = locDev.Split("_")
                cmds.Add("delete from tbl_local_ids where room_type_id = " + RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(0) + " and device_type_id = " _
                                         + "(Select id from tbl_device_types where device_type_name = '" + split(0) + "') and local_id_number = " + split(1))
            End If
        Next
        For Each locDev As String In RTE_addedLocalIDs
            If Not RTE_currentLocalIDs.Contains(locDev) Then
                Dim split() As String = locDev.Split("_")
                cmds.Add("Insert into tbl_local_ids values((Select id from tbl_device_types where device_type_name = '" + split(0) + "')," _
                         + split(1) + "," + RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(0) + ");")
            End If
        Next
        Dim save As Boolean = False
        If cmds.Count > 0 Then save = True
        For Each c As String In cmds
            sqlCmd.CommandText = c
            Try
                sqlCmd.ExecuteNonQuery()
            Catch ex As NullReferenceException
            Catch ex As SqlException
                MessageBox.Show("SQL Exception: " + ex.ToString)
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.ToString)

            End Try
        Next
        If save Then
            getDevices(RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(0))
            tssLbl_Status.Text = "Room Type Saved."
        End If

    End Sub

    Private Sub RTE_btnNew_Click(sender As System.Object, e As System.EventArgs) Handles RTE_btnNew.Click
        Dim typeName As String = Nothing
        typeName = InputBox("Enter the name of the room type:", "Enter Type Name")
        If typeName <> Nothing Then
            sqlCmd.CommandText = "Insert into tbl_roomtype values('" & typeName & "','Nothing');"
            Try
                sqlCmd.ExecuteNonQuery()
            Catch ex As SqlException
                MessageBox.Show("SQL Exception: " + ex.ToString)
            Catch ex As Exception
                MessageBox.Show("Exception: " + ex.ToString)
            End Try
        End If
        updateRoomTypes()
        RTE_lbRoomTypes.SelectedIndex = RTE_lbRoomTypes.Items.Count - 1
    End Sub

    Private Sub RTE_btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles RTE_btnDelete.Click
        If RTE_lbRoomTypes.SelectedIndex <> -1 Then
            sqlCmd.CommandText = "Delete From tbl_roomdevicestypes where roomtype_id = " + RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(0) + " ;"
            Try
                sqlCmd.ExecuteNonQuery()
            Catch ex As SqlException
                MessageBox.Show("SQL exception: " + ex.ToString)
            Catch ex As Exception
                MessageBox.Show("Exception: " + ex.ToString)
            End Try
            Try
                sqlCmd.CommandText = "Delete from tbl_roomtype where id = " + RTE_roomTypeList(RTE_lbRoomTypes.SelectedIndex)(0) + " ;"
                sqlCmd.ExecuteNonQuery()
            Catch ex As SqlException
                MessageBox.Show("SQL exception: " + ex.ToString)
            Catch ex As Exception
                MessageBox.Show("Exception: " + ex.ToString)
            End Try

            updateRoomTypes()
            clearControls()
        End If
    End Sub

    Private Sub RTE_lbDeviceTypesAvailable_DoubleClick(sender As Object, e As System.EventArgs) Handles RTE_lbDeviceTypesAvailable.DoubleClick
        RTE_btnDeviceAdd.PerformClick()
    End Sub

    Private Sub tsmiAddItem_Click(sender As System.Object, e As System.EventArgs) Handles tsmiAddItem.Click
        Try
            If Not RTE_tvDevicesAdded.SelectedNode.Text.Contains("_") Then  'This is done to prevent the adding of nodes to local ids
                Dim name As String = Nothing
                name = InputBox("Enter Local ID: ", "Local ID")
                If name <> Nothing Then
                    RTE_tvDevicesAdded.Nodes(RTE_tvDevicesAdded.SelectedNode.Index).Nodes.Add(RTE_tvDevicesAdded.SelectedNode.Text + "_" + name)
                    RTE_addedLocalIDs.Add(RTE_tvDevicesAdded.SelectedNode.Text + "_" + name)
                    tssLbl_Status.Text = "Local ID added. Save to commit changes."
                End If
            Else
                tssLbl_Status.Text = "Can not add item to a Local ID. Items can only be added to Devices."
            End If
        Catch ex As NullReferenceException
            tssLbl_Status.Text = "Please select device to add a Local ID to."
        End Try
    End Sub
    Private Sub tsmiDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles tsmiDeleteItem.Click

        If RTE_tvDevicesAdded.SelectedNode.Index > -1 Then
            If RTE_tvDevicesAdded.SelectedNode.Nodes.Count > 0 Then
                tssLbl_Status.Text = RTE_tvDevicesAdded.SelectedNode.Text + " device removed. Save to commit changes."
                For Each a As TreeNode In RTE_tvDevicesAdded.SelectedNode.Nodes
                    RTE_addedLocalIDs.Remove(a.Text)
                Next
                RTE_btnDeviceRemove.PerformClick()
            Else
                tssLbl_Status.Text = "Local ID removed. Save to commit changes."
                RTE_addedLocalIDs.Remove(RTE_tvDevicesAdded.SelectedNode.Text)

                RTE_tvDevicesAdded.Nodes.Remove(RTE_tvDevicesAdded.SelectedNode)
            End If

        End If
    End Sub
    Private Sub tvDevicesAdded_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles RTE_tvDevicesAdded.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            RTE_tvDevicesAdded.SelectedNode = RTE_tvDevicesAdded.GetNodeAt(e.X, e.Y)
        End If
    End Sub
#End Region

#Region "Alarm editor"
    Private Sub updateDeviceTypes()
        AE_lbDevices.Items.Clear()
        AE_deviceTypeList.Clear()
        sqlCmd.CommandText = "select tbl_device_types.id,device_type_name,tbl_alarms.id,alarm_type,signal_type,enabled,threshold,time_factor,warning_threshold,warning_time_factor,warning_event_id" _
                                & " from tbl_Device_Types " _
                                + " left Join" _
                                + " tbl_alarms on tbl_device_types.id=tbl_alarms.Device_type_id"
        If SQLCONNECTED Then
            Try
                sqlReader = sqlCmd.ExecuteReader()
                While sqlReader.Read()
                    Dim tmp As String = "0"
                    Dim tmp1 As String = "null"
                    Dim wrnThresh, wrnTimF, wrnCode As String
                    If sqlReader(8).ToString = "" Then wrnThresh = "null" Else wrnThresh = sqlReader(8).ToString
                    If sqlReader(9).ToString = "" Then wrnTimF = "null" Else wrnTimF = sqlReader(9).ToString
                    If sqlReader(10).ToString = "" Then wrnCode = "null" Else wrnCode = sqlReader(10).ToString
                    If sqlReader(5).ToString = "True" Then tmp = "1"
                    If Not sqlReader(6).ToString = "" Then tmp1 = sqlReader(6)
                    AE_deviceTypeList.Add(New String() {sqlReader(0).ToString, sqlReader(1).ToString, sqlReader(2).ToString, sqlReader(3).ToString, sqlReader(4).ToString, tmp, tmp1, sqlReader(7).ToString, _
                                                        wrnThresh, wrnTimF, wrnCode})
                    AE_lbDevices.Items.Add(sqlReader(1))
                End While
            Catch ex As SqlException
                MessageBox.Show("SQL Error: " + ex.ToString)
            Catch ex As Exception
                MessageBox.Show("Error:" + ex.ToString)
            Finally
                sqlReader.Close()
            End Try
        End If
        

    End Sub
    Private Sub AE_getWarnings()
        AE_warningEventsCodes.Clear()
        AE_combWarningAlarms.Items.Clear()
        sqlCmd.CommandText = "Select id,description,Alarm_Code from tbl_events"
        If SQLCONNECTED Then
            Try
                sqlReader = sqlCmd.ExecuteReader()
                While sqlReader.Read()

                    AE_warningEventsCodes.Add(sqlReader(0).ToString)
                    AE_combWarningAlarms.Items.Add(sqlReader(1).ToString)
                    AE_cbErrorAlarmCode.Items.Add(sqlReader(1).ToString)
                    'If the Error code is a warning, add it to the warning list, if it is a alarm, add it to the alarm list, filtering the errors
                    'TODO: This doesn't work at the moment, it causes some out of bounds exceptions else where. For the moment, just going to use the non filtered method

                    'If sqlReader(2).ToString.StartsWith("W") Then AE_combWarningAlarms.Items.Add(sqlReader(1).ToString)
                    'If sqlReader(2).ToString.StartsWith("A") Then AE_cbErrorAlarmCode.Items.Add(sqlReader(1).ToString)

                End While

            Catch ex As SqlException
                MessageBox.Show("SQL exception: " + ex.ToString)
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.ToString)
            Finally
                sqlReader.Close()
            End Try
        Else
            tssLbl_Status.Text = "Not Connected to Database. Please check Connection settings and/or make sure SQL Server is running."
        End If

    End Sub
    Private Sub AE_clearWarning(ByVal index As Integer)
        AE_tbWarningTimeFrame.Text = ""
        AE_tbWarningThreshold.Text = ""
        AE_tbWarningThreshold.Visible = False
        AE_tbWarningTimeFrame.Visible = False
        AE_lblWarningCode.Visible = False
        AE_lblWarningTimeFrame.Visible = False
        AE_lblWarningThreshold.Visible = False
        AE_combWarningAlarms.Visible = False
        AE_combWarningAlarms.SelectedItem = ""
        AE_combWarningAlarms.SelectedText = ""
        AE_combWarningAlarms.SelectedIndex = -1
        AE_combWarningAlarms.Items.Clear()
        AE_warningEventsCodes.Clear()
        AE_currentSelectedDevice(8) = "null"
        AE_currentSelectedDevice(9) = "null"
        AE_currentSelectedDevice(10) = "null"
    End Sub
    Private Sub rbBasic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AE_rbBasic.CheckedChanged
        If AE_rbBasic.Checked = True Then
            AE_cbEnabled.Enabled = False
            AE_cbEnabled.Checked = True
            AE_currentSelectedDevice(3) = "Basic"
        End If


    End Sub

    Private Sub rbEnhanced_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AE_rbEnhanced.CheckedChanged
        If AE_rbEnhanced.Checked = True Then
            AE_cbEnabled.Enabled = True
            AE_currentSelectedDevice(3) = "Enhanced"
        End If
    End Sub
    Private Sub AE_cbWarning_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AE_cbWarning.CheckedChanged
        If AE_cbWarning.Checked = True Then
            AE_tbWarningThreshold.Visible = True
            AE_tbWarningTimeFrame.Visible = True
            AE_lblWarningCode.Visible = True
            AE_lblWarningTimeFrame.Visible = True
            AE_lblWarningThreshold.Visible = True
            AE_combWarningAlarms.Visible = True
            AE_cbErrorAlarmCode.Items.Clear()
            AE_getWarnings()
            AE_combWarningAlarms.SelectedIndex = -1
        Else
            If AE_lbDevices.SelectedIndex > -1 Then
                AE_clearWarning(AE_lbDevices.SelectedIndex)
            Else
                AE_combWarningAlarms.Visible = False
                AE_tbWarningThreshold.Visible = False
                AE_tbWarningTimeFrame.Visible = False
                AE_lblWarningCode.Visible = False
                AE_lblWarningTimeFrame.Visible = False
                AE_lblWarningThreshold.Visible = False
                AE_combWarningAlarms.Visible = False
                AE_combWarningAlarms.Items.Clear()
                AE_cbErrorAlarmCode.Items.Clear()
            End If

        End If
    End Sub
    Private Sub lbDevices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AE_lbDevices.SelectedIndexChanged
        If AE_lbDevices.SelectedItems.Count > 0 Then
            AE_currentSelectedDevice = AE_deviceTypeList(AE_lbDevices.SelectedIndex).Clone()
            AE_lbDeviceName.Text = AE_deviceTypeList(AE_lbDevices.SelectedIndex)(1)
            AE_cbEnabled.Checked = AE_deviceTypeList(AE_lbDevices.SelectedIndex)(5)


            Select Case AE_deviceTypeList(AE_lbDevices.SelectedIndex)(4).ToLower
                Case "Analog".ToLower
                    AE_rbAnalog.Checked = True

                Case "String".ToLower

                    AE_rbString.Checked = True
                Case "Binary".ToLower

                    AE_rbBinary.Checked = True
                Case ""
                    AE_rbAnalog.Checked = False
                    AE_rbBinary.Checked = False
                    AE_rbString.Checked = False
            End Select
            Select Case AE_deviceTypeList(AE_lbDevices.SelectedIndex)(3).ToLower
                Case "Enhanced".ToLower
                    AE_rbBasic.Checked = False
                    AE_rbEnhanced.Checked = True
                Case "Basic".ToLower
                    AE_rbBasic.Checked = True
                    AE_rbEnhanced.Checked = False
                Case ""
                    AE_rbBasic.Checked = False
                    AE_rbEnhanced.Checked = False
            End Select
            If AE_deviceTypeList(AE_lbDevices.SelectedIndex)(7) = "" Then AE_tbTimeFrame.Text = "0" Else AE_tbTimeFrame.Text = AE_deviceTypeList(AE_lbDevices.SelectedIndex)(7)
            If AE_deviceTypeList(AE_lbDevices.SelectedIndex)(6) = "null" Then : AE_tbThreshold.Text = "0"
            Else : AE_tbThreshold.Text = AE_deviceTypeList(AE_lbDevices.SelectedIndex)(6)
            End If

            If AE_currentSelectedDevice(8) <> "null" And AE_currentSelectedDevice(9) <> "null" And AE_currentSelectedDevice(10) <> "null" Then
                AE_cbWarning.Visible = True
                AE_cbWarning.Checked = True
                AE_tbWarningThreshold.Text = AE_deviceTypeList(AE_lbDevices.SelectedIndex)(8)
                AE_tbWarningTimeFrame.Text = AE_deviceTypeList(AE_lbDevices.SelectedIndex)(9)
                AE_combWarningAlarms.SelectedItem = AE_combWarningAlarms.Items(AE_warningEventsCodes.IndexOf(AE_deviceTypeList(AE_lbDevices.SelectedIndex)(10)))
            Else
                If AE_rbAnalog.Checked = True Then
                    If AE_currentSelectedDevice(8) <> "null" Or AE_currentSelectedDevice(9) <> "null" Or AE_currentSelectedDevice(10) <> "null" Then
                        AE_cbWarning.Visible = True
                        AE_cbWarning.Checked = True
                        AE_tbWarningThreshold.Text = AE_deviceTypeList(AE_lbDevices.SelectedIndex)(8)
                        AE_tbWarningTimeFrame.Text = AE_deviceTypeList(AE_lbDevices.SelectedIndex)(9)
                        AE_combWarningAlarms.SelectedItem = AE_combWarningAlarms.Items(AE_warningEventsCodes.IndexOf(AE_deviceTypeList(AE_lbDevices.SelectedIndex)(10)))
                    Else
                        AE_cbWarning.Visible = True
                        AE_cbWarning.Checked = False
                        AE_tbWarningThreshold.Text = ""
                        AE_tbWarningTimeFrame.Text = ""
                        AE_combWarningAlarms.SelectedIndex = -1
                        AE_combWarningAlarms.Items.Clear()

                    End If
                Else
                    AE_cbWarning.Visible = False
                    AE_cbWarning.Checked = False
                End If

            End If

        End If
    End Sub

    Private Sub clearFields()
        AE_rbBasic.Checked = False
        AE_rbEnhanced.Checked = False
        AE_cbEnabled.Checked = True
        AE_cbEnabled.Enabled = False
        AE_tbTimeFrame.Text = ""
    End Sub

    Private Sub AE_rbBinary_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AE_rbBinary.CheckedChanged
        If AE_rbBinary.Checked = True Then
            AE_currentSelectedDevice(4) = "Binary"
            AE_tbThreshold.Text = "0"
            AE_tbThreshold.Enabled = False

            If AE_lbDevices.SelectedIndex > -1 Then
                AE_clearWarning(AE_lbDevices.SelectedIndex)
                AE_cbWarning.Checked = False
                AE_cbWarning.Visible = False
            Else
                AE_cbWarning.Enabled = False
                AE_cbWarning.Visible = False
            End If
        End If
    End Sub

    Private Sub AE_rbAnalog_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AE_rbAnalog.CheckedChanged
        If AE_rbAnalog.Checked = True Then
            AE_currentSelectedDevice(4) = "Analog"
            AE_tbThreshold.Text = AE_currentSelectedDevice(6)
            AE_tbThreshold.Enabled = True
            AE_cbWarning.Visible = True
        End If
    End Sub

    Private Sub AE_rbString_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AE_rbString.CheckedChanged
        If AE_rbString.Checked = True Then
            AE_currentSelectedDevice(4) = "String"
            AE_tbThreshold.Text = "0"
            AE_tbThreshold.Enabled = False
            If AE_lbDevices.SelectedIndex > -1 Then
                AE_clearWarning(AE_lbDevices.SelectedIndex)
                AE_cbWarning.Checked = False
                AE_cbWarning.Visible = False
            Else
                AE_cbWarning.Enabled = False
                AE_cbWarning.Visible = False
            End If
        End If
    End Sub
    Private Sub AE_tbTimeFrame_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AE_tbTimeFrame.TextChanged
        AE_currentSelectedDevice(7) = AE_tbTimeFrame.Text
    End Sub
    Private Sub AE_tbThreshold_TextChanged(sender As System.Object, e As System.EventArgs) Handles AE_tbThreshold.TextChanged
        If AE_tbThreshold.Text = "0" Or AE_tbThreshold.Text = "" Then
            AE_currentSelectedDevice(6) = "null"
        Else
            AE_currentSelectedDevice(6) = AE_tbThreshold.Text
        End If

    End Sub
    Private Sub AE_tbWarningThreshold_TextChanged(sender As System.Object, e As System.EventArgs) Handles AE_tbWarningThreshold.TextChanged
        If AE_tbWarningThreshold.Text = "0" Or AE_tbWarningThreshold.Text = "" Then
            AE_currentSelectedDevice(8) = "null"
        Else
            AE_currentSelectedDevice(8) = AE_tbWarningThreshold.Text
        End If
    End Sub

    Private Sub AE_tbWarningTimeFrame_TextChanged(sender As System.Object, e As System.EventArgs) Handles AE_tbWarningTimeFrame.TextChanged
        If AE_tbWarningTimeFrame.Text = "0" Or AE_tbWarningTimeFrame.Text = "" Then
            AE_currentSelectedDevice(9) = "null"
        Else
            AE_currentSelectedDevice(9) = AE_tbWarningTimeFrame.Text
        End If
    End Sub

    Private Sub AE_tbDeviceName_TextChanged(sender As System.Object, e As System.EventArgs)
        AE_currentSelectedDevice(1) = AE_lbDeviceName.Text
    End Sub
    Private Sub AE_combWarningAlarms_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AE_combWarningAlarms.SelectedIndexChanged
        If AE_combWarningAlarms.SelectedIndex > -1 Then
            AE_currentSelectedDevice(10) = AE_warningEventsCodes(AE_combWarningAlarms.SelectedIndex)
        Else
            AE_currentSelectedDevice(10) = "null"
        End If

    End Sub
    Private Sub AE_btnSave_Click(sender As System.Object, e As System.EventArgs) Handles AE_btnSave.Click

        Try
            If AE_compareToSave(AE_deviceTypeList(AE_lbDevices.SelectedIndex), AE_currentSelectedDevice) Then

                If AE_currentSelectedDevice(2) = "" Then
                    sqlCmd.CommandText = "insert into tbl_alarms values((Select id from tbl_device_types where device_type_name = '" & AE_currentSelectedDevice(1) & "'),'" _
                                    & AE_currentSelectedDevice(4) & "' ,'" & AE_currentSelectedDevice(3) _
                                        & "', " & AE_currentSelectedDevice(5) & " , " & AE_currentSelectedDevice(6) & "," & AE_currentSelectedDevice(7) _
                                         & "," & AE_currentSelectedDevice(8) & "," & AE_currentSelectedDevice(9) & "," & AE_currentSelectedDevice(10) & ");"
                Else
                    sqlCmd.CommandText = "update tbl_alarms set Signal_Type = '" + AE_currentSelectedDevice(4) + "', Enabled = " + AE_currentSelectedDevice(5) _
                                        + " , Alarm_Type = '" + AE_currentSelectedDevice(3) + "' , Threshold =" + AE_currentSelectedDevice(6) + ",Time_Factor = " + AE_currentSelectedDevice(7) _
                                        + ", Warning_threshold = " + AE_currentSelectedDevice(8) + ", Warning_Time_Factor=" + AE_currentSelectedDevice(9) + ", Warning_Event_ID=" + AE_currentSelectedDevice(10) _
                                        + " where id = " + AE_currentSelectedDevice(2) + " ;"
                End If

                Try
                    sqlCmd.ExecuteNonQuery()
                    updateDeviceTypes()
                Catch ex As SqlException
                    MessageBox.Show("SQL Exception: " + ex.ToString)
                Catch ex As Exception
                    MessageBox.Show("Exception: " + ex.ToString)
                End Try
                tssLbl_Status.Text = "Alarm Saved."
            Else
                tssLbl_Status.Text = "Nothing was changed, no save required."
            End If

        Catch ex As ArgumentException
            tssLbl_Status.Text = "Error-Please select a device before clicking save."
        End Try

    End Sub
    Private Sub AE_btnNew_Click(sender As System.Object, e As System.EventArgs) Handles AE_btnNew.Click
        Dim typeName As String = Nothing
        typeName = InputBox("Enter the name of the device type:", "Enter Device Type Name")
        If typeName <> Nothing Then
            sqlCmd.CommandText = "Insert into tbl_device_types(device_type_name) values('" & typeName & "');"
            Try
                sqlCmd.ExecuteNonQuery()
            Catch ex As SqlException
                MessageBox.Show("SQL Exception: " + ex.ToString)
            Catch ex As Exception
                MessageBox.Show("Exception: " + ex.ToString)
            End Try
        End If
        updateDeviceTypes()
        AE_lbDevices.SelectedIndex = AE_lbDevices.Items.Count - 1
    End Sub
    Private Sub AE_btnDel_Click(sender As System.Object, e As System.EventArgs) Handles AE_btnDel.Click
        If AE_lbDevices.SelectedIndex > -1 Then
            sqlCmd.CommandText = "Delete from tbl_alarms where device_type_id = (Select id from tbl_device_types where device_type_name = '" & AE_currentSelectedDevice(1) & "')"
            Try
                sqlCmd.ExecuteNonQuery()
                sqlCmd.CommandText = "delete from tbl_device_types where device_type_name = '" & AE_currentSelectedDevice(1) & "';"
                sqlCmd.ExecuteNonQuery()
            Catch ex As SqlException
                If ex.ErrorCode = -2146232060 Then
                    If MsgBox("This will delete ALL references to this item type. Are you SURE you want to delete?", vbYesNo) = vbNo Then

                    Else
                        MsgBox("Deleting all references..(Not implemented yet)")
                    End If
                Else
                    MessageBox.Show("SQL Exception: " + ex.ToString)
                End If


            End Try
            If AE_lbDevices.SelectedIndex > 0 Then
                AE_lbDevices.SelectedIndex = AE_lbDevices.SelectedIndex - 1
            End If
            updateDeviceTypes()

        End If
    End Sub
    Private Sub AE_cbEnabled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AE_cbEnabled.CheckedChanged
        If AE_cbEnabled.Checked = True Then
            AE_currentSelectedDevice(5) = "1"
        Else
            AE_currentSelectedDevice(5) = "0"
        End If
    End Sub
    Private Function AE_compareToSave(ByVal original As String(), ByVal modified As String()) As Boolean
        If original(0) = modified(0) And original(1) = modified(1) And original(2) = modified(2) And _
            original(3) = modified(3) And original(4) = modified(4) And original(5) = modified(5) And _
            original(6) = modified(6) And original(7) = modified(7) And original(8) = modified(8) And _
            original(9) = modified(9) And original(10) = modified(10) Then
            Return False
        Else : Return True

        End If
    End Function
#End Region

#Region "Room Editor"

    Private Sub RE_tcRoomViewer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles RE_tcRoomViewer.SelectedIndexChanged
        Select Case RE_tcRoomViewer.SelectedIndex
            Case 0
                updateTVRoomListByFloor()
            Case 1
                updateTVRoomListByType()
        End Select
    End Sub

    Private Sub updateTVRoomListByType()
        RE_tvRoomsByFloor.Nodes.Clear()
        For i = 0 To RE_roomList.Count - 1 Step 1
            If RE_tvRoomsByType.Nodes.Count <> 0 Then
                Dim buildingIndex As Integer = RE_buildingExists(RE_roomList(i)(1).ToString, RE_tvRoomsByType)
                If buildingIndex <> -1 Then
                    Dim floorIndex As Integer = RE_typeExists(buildingIndex, RE_roomList(i)(4))
                    If floorIndex <> -1 Then
                        RE_tvRoomsByType.Nodes(buildingIndex).Nodes(floorIndex).Nodes.Add(RE_roomList(i)(3))
                    Else
                        RE_tvRoomsByType.Nodes(buildingIndex).Nodes.Add(RE_roomList(i)(4))
                        RE_tvRoomsByType.Nodes(buildingIndex).Nodes(RE_tvRoomsByType.Nodes(buildingIndex).Nodes.Count - 1).Nodes.Add(RE_roomList(i)(3))
                    End If
                Else
                    RE_tvRoomsByType.Nodes.Add(RE_roomList(i)(1).ToString)
                    RE_tvRoomsByType.Nodes(RE_tvRoomsByType.Nodes.Count - 1).Nodes.Add(RE_roomList(i)(4))
                    RE_tvRoomsByType.Nodes(RE_tvRoomsByType.Nodes.Count - 1).Nodes(RE_tvRoomsByType.Nodes(RE_tvRoomsByType.Nodes.Count - 1).Nodes.Count - 1).Nodes.Add(RE_roomList(i)(3))
                End If
            Else
                RE_tvRoomsByType.Nodes.Add(RE_roomList(i)(1))
                RE_tvRoomsByType.Nodes(0).Nodes.Add(RE_roomList(i)(4))
                RE_tvRoomsByType.Nodes(0).Nodes(0).Nodes.Add(RE_roomList(i)(3))
            End If
        Next
    End Sub
    Private Sub updateTVRoomListByFloor()
        RE_tvRoomsByType.Nodes.Clear()
        For i = 0 To RE_roomList.Count - 1 Step 1
            If RE_tvRoomsByFloor.Nodes.Count <> 0 Then
                Dim buildingIndex As Integer = RE_buildingExists(RE_roomList(i)(1).ToString, RE_tvRoomsByFloor)
                If buildingIndex <> -1 Then
                    Dim floorIndex As Integer = RE_floorExists(buildingIndex, RE_roomList(i)(2))
                    If floorIndex <> -1 Then
                        RE_tvRoomsByFloor.Nodes(buildingIndex).Nodes(floorIndex).Nodes.Add(RE_roomList(i)(3))
                    Else
                        RE_tvRoomsByFloor.Nodes(buildingIndex).Nodes.Add("Floor " + RE_roomList(i)(2))
                        RE_tvRoomsByFloor.Nodes(buildingIndex).Nodes(RE_tvRoomsByFloor.Nodes(buildingIndex).Nodes.Count - 1).Nodes.Add(RE_roomList(i)(3))
                    End If
                Else
                    RE_tvRoomsByFloor.Nodes.Add(RE_roomList(i)(1).ToString)
                    RE_tvRoomsByFloor.Nodes(RE_tvRoomsByFloor.Nodes.Count - 1).Nodes.Add("Floor " + RE_roomList(i)(2))
                    RE_tvRoomsByFloor.Nodes(RE_tvRoomsByFloor.Nodes.Count - 1).Nodes(RE_tvRoomsByFloor.Nodes(RE_tvRoomsByFloor.Nodes.Count - 1).Nodes.Count - 1).Nodes.Add(RE_roomList(i)(3))
                End If
            Else
                RE_tvRoomsByFloor.Nodes.Add(RE_roomList(i)(1))
                RE_tvRoomsByFloor.Nodes(0).Nodes.Add(RE_roomList(i)(2))
                RE_tvRoomsByFloor.Nodes(0).Nodes(0).Nodes.Add(RE_roomList(i)(3))
            End If
        Next

    End Sub

#Region "Multi Select Methods"

    Private Sub RE_tvRoomsByFloor_NodeMouseClick(sender As System.Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles RE_tvRoomsByFloor.NodeMouseClick
        RE_tvRoomsByFloor.SelectedNode = RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y)
        If ctrlMultiSelect And e.Button = Windows.Forms.MouseButtons.Left And RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y).Nodes.Count = 0 Then
            If Not RE_SelectedNodesByFloor.Contains((RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y))) Then
                RE_SelectedNodesByFloor.Add(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y))
                RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.Count - 1).BackColor = Color.FromArgb(51, 153, 255)
                RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.Count - 1).ForeColor = Color.White
            Else
                RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.IndexOf(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y))).BackColor = Color.White
                RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.IndexOf(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y))).ForeColor = Color.Black
                RE_SelectedNodesByFloor.Remove(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y))
            End If

        End If
        If shiftMultiSelect And e.Button = Windows.Forms.MouseButtons.Left And RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y).Nodes.Count = 0 Then
            Dim index As Integer = RE_tvRoomsByFloor.Nodes(0).Nodes.IndexOf(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y).Parent)
            If RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes.IndexOf(RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.Count - 1)) < _
                    RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes.IndexOf(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y)) Then
                For i = RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes.IndexOf(RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.Count - 1)) To _
                        RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes.IndexOf(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y)) Step 1
                    If Not RE_SelectedNodesByFloor.Contains(RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes(i)) Then
                        RE_SelectedNodesByFloor.Add(RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes(i))
                        RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes(i).BackColor = Color.FromArgb(51, 153, 255)
                        RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes(i).ForeColor = Color.White
                    End If
                Next
            Else
                For i = RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes.IndexOf(RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.Count - 1)) To _
                         RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes.IndexOf(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y)) Step -1
                    If Not RE_SelectedNodesByFloor.Contains(RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes(i)) Then
                        RE_SelectedNodesByFloor.Add(RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes(i))
                        RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes(i).BackColor = Color.FromArgb(51, 153, 255)
                        RE_tvRoomsByFloor.Nodes(0).Nodes(index).Nodes(i).ForeColor = Color.White
                    End If
                Next
            End If

        End If
        If e.Button = Windows.Forms.MouseButtons.Left And Not shiftMultiSelect And Not ctrlMultiSelect Then
            For i = 0 To RE_SelectedNodesByFloor.Count - 1 Step 1
                RE_SelectedNodesByFloor(i).BackColor = Color.White
                RE_SelectedNodesByFloor(i).ForeColor = Color.Black
            Next
            RE_SelectedNodesByFloor.Clear()
            If RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y).Nodes.Count = 0 Then
                RE_SelectedNodesByFloor.Add(RE_tvRoomsByFloor.GetNodeAt(e.X, e.Y))
                RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.Count - 1).BackColor = Color.FromArgb(51, 153, 255)
                RE_SelectedNodesByFloor(RE_SelectedNodesByFloor.Count - 1).ForeColor = Color.White
            End If
        End If

    End Sub
    Private Sub RE_tvRoomsByType_NodeMouseClick(sender As System.Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles RE_tvRoomsByType.NodeMouseClick
        RE_tvRoomsByType.SelectedNode = RE_tvRoomsByType.GetNodeAt(e.X, e.Y)
        If ctrlMultiSelect And e.Button = Windows.Forms.MouseButtons.Left And RE_tvRoomsByType.GetNodeAt(e.X, e.Y).Nodes.Count = 0 Then
            If Not RE_SelectedNodesByType.Contains((RE_tvRoomsByType.GetNodeAt(e.X, e.Y))) Then
                RE_SelectedNodesByType.Add(RE_tvRoomsByType.GetNodeAt(e.X, e.Y))
                RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1).BackColor = Color.FromArgb(51, 153, 255)
                RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1).ForeColor = Color.White
            Else
                RE_SelectedNodesByType(RE_SelectedNodesByType.IndexOf(RE_tvRoomsByType.GetNodeAt(e.X, e.Y))).BackColor = Color.White
                RE_SelectedNodesByType(RE_SelectedNodesByType.IndexOf(RE_tvRoomsByType.GetNodeAt(e.X, e.Y))).ForeColor = Color.Black
                RE_SelectedNodesByType.Remove(RE_tvRoomsByType.GetNodeAt(e.X, e.Y))
            End If

        End If
        If shiftMultiSelect And e.Button = Windows.Forms.MouseButtons.Left And RE_tvRoomsByType.GetNodeAt(e.X, e.Y).Nodes.Count = 0 Then
            Dim index As Integer = RE_tvRoomsByType.Nodes(0).Nodes.IndexOf(RE_tvRoomsByType.GetNodeAt(e.X, e.Y).Parent)
            If RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes.IndexOf(RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1)) <
                    RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes.IndexOf(RE_tvRoomsByType.GetNodeAt(e.X, e.Y)) Then
                For i = RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes.IndexOf(RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1)) To _
                RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes.IndexOf(RE_tvRoomsByType.GetNodeAt(e.X, e.Y)) Step 1
                    If Not RE_SelectedNodesByType.Contains(RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes(i)) Then
                        RE_SelectedNodesByType.Add(RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes(i))
                        RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes(i).BackColor = Color.FromArgb(51, 153, 255)
                        RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1).ForeColor = Color.White
                    End If
                Next
            Else
                For i = RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes.IndexOf(RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1)) To _
                RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes.IndexOf(RE_tvRoomsByType.GetNodeAt(e.X, e.Y)) Step -1
                    If Not RE_SelectedNodesByType.Contains(RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes(i)) Then
                        RE_SelectedNodesByType.Add(RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes(i))
                        RE_tvRoomsByType.Nodes(0).Nodes(index).Nodes(i).BackColor = Color.FromArgb(51, 153, 255)
                        RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1).ForeColor = Color.White
                    End If
                Next
            End If

        End If
        If e.Button = Windows.Forms.MouseButtons.Left And Not shiftMultiSelect And Not ctrlMultiSelect Then
            For i = 0 To RE_SelectedNodesByType.Count - 1 Step 1
                RE_SelectedNodesByType(i).BackColor = Color.White
                RE_SelectedNodesByType(i).ForeColor = Color.Black
            Next
            RE_SelectedNodesByType.Clear()
            If RE_tvRoomsByType.GetNodeAt(e.X, e.Y).Nodes.Count = 0 Then
                RE_SelectedNodesByType.Add(RE_tvRoomsByType.GetNodeAt(e.X, e.Y))
                RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1).BackColor = Color.FromArgb(51, 153, 255)
                RE_SelectedNodesByType(RE_SelectedNodesByType.Count - 1).ForeColor = Color.White

            End If
        End If

    End Sub
    Private Sub RE_tvRooms_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RE_tvRoomsByFloor.KeyDown, RE_tvRoomsByType.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            ctrlMultiSelect = True
        ElseIf e.KeyCode = Keys.ShiftKey Then
            shiftMultiSelect = True
        End If
    End Sub
    Private Sub RE_tvRoomsBy_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RE_tvRoomsByFloor.KeyUp, RE_tvRoomsByType.KeyUp
        ctrlMultiSelect = False
        shiftMultiSelect = False
    End Sub
#End Region
    'Create a new room and add it to the database
    Private Sub RE_btnNew_Click(sender As System.Object, e As System.EventArgs) Handles RE_btnNew.Click
        MessageBox.Show("Enter the room name.")
    End Sub
    'Delete a room from the database
    Private Sub RE_btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles RE_btnDelete.Click

    End Sub
    Private Sub updateRoomList()
        RE_roomList.Clear()
        RE_tvRoomsByFloor.Nodes.Clear() 'Need to make a join statement to get the room type name not the ID
        sqlCmd.CommandText = "Select tbl_rooms.id,Building,Floor,Room_Name,tbl_roomtype.RoomType,MAC,IP_Address,Firmware_Processor,Software_Loaded from tbl_rooms join " _
                                + "tbl_RoomType on tbl_roomtype.id = tbl_rooms.room_type_id"
        If SQLCONNECTED Then
            Try
                sqlReader = sqlCmd.ExecuteReader()
                While sqlReader.Read()
                    RE_roomList.Add(New String() {sqlReader(0).ToString, sqlReader(1).ToString, sqlReader(2).ToString, sqlReader(3).ToString, sqlReader(4).ToString, sqlReader(5).ToString, sqlReader(6).ToString, sqlReader(7).ToString, sqlReader(8).ToString})

                End While
                sqlReader.Close()
            Catch ex As SqlException
                MessageBox.Show("Sql Exception: " & ex.ToString)
            Catch ex As Exception
                MessageBox.Show("General Exception : " & ex.ToString)
            End Try
        End If
        
    End Sub
    Private Function RE_buildingExists(ByVal buildingName As String, ByVal TV As TreeView) As Integer
        Dim index As Integer = -1
        For i = 0 To TV.Nodes.Count - 1 Step 1
            If TV.Nodes(i).Text = buildingName Then
                index = i
            End If
        Next
        Return index
    End Function
    Private Function RE_floorExists(ByVal buildingIndex As Integer, ByVal floor As String) As Integer
        Dim index As Integer = -1
        For i = 0 To RE_tvRoomsByFloor.Nodes(buildingIndex).Nodes.Count - 1 Step 1
            If RE_tvRoomsByFloor.Nodes(buildingIndex).Nodes(i).Text = "Floor " + floor Then
                index = i
            End If
        Next
        Return index
    End Function
    Private Function RE_typeExists(ByVal buildingIndex As Integer, ByVal type As String) As Integer
        Dim index As Integer = -1
        For i = 0 To RE_tvRoomsByType.Nodes(buildingIndex).Nodes.Count - 1 Step 1
            If RE_tvRoomsByType.Nodes(buildingIndex).Nodes(i).Text = type Then
                index = i
            End If
        Next
        Return index
    End Function

    
    Private Sub RE_tmrProgramLoad_Tick(sender As System.Object, e As System.EventArgs) Handles RE_tmrProgramLoad.Tick
        
        If RE_process And Not RE_loadComplete Then
            For i = RE_ProgramLoadingIndex To RE_ProgramLoadingIndex + 63 Step 1
                If i < RE_Ip.Count Then
                    Dim temp As New VptSession3
                    temp.OpenSession("tcp " + RE_Ip(i), RE_Ip(i))
                    AddHandler temp.OnActivateStrComplete, AddressOf StrComplete
                    programLoad.lsvRoomsLoading.Items(RE_ProgramLoadingIndex).SubItems(1).Text = "Started..."
                    sessions.Add(temp)
                    RE_ProgramLoadingIndex += 1
                Else
                    Exit For
                End If
            Next
            For s = 0 To 63 Step 1
                If (RE_ProgramLoadingIndex) <> RE_Ip.Count Then
                    Dim tempID As Long = 0
                    sessions(s).AsyncActivateStr(0, "ProgramSend C:\Energize\ADG-Revel-A-King-120331-TL.lpz", 10000, tempID, 0, 0)
                    Debug.Print("Transaction ID: " + tempID.ToString)
                    transactionIDs.Add(tempID)
                Else
                    For a = 0 To (RE_ProgramLoadingIndex Mod 64) - 1 Step 1
                        Dim tempID As Long = 0
                        sessions(a).AsyncActivateStr(0, "ProgramSend C:\Energize\ADG-Revel-A-King-120331-TL.lpz", 10000, tempID, 0, 0)
                        Debug.Print("Transaction ID: " + tempID.ToString)
                        transactionIDs.Add(tempID)
                    Next
                    Exit For
                End If
            Next
            RE_process = False
        End If
        Dim tmpS As Integer = successTransactions.Count
        Dim tmpF As Integer = errorTransactions.Count
        For i = 0 To tmpS - 1 Step 1
            programLoad.lsvRoomsLoading.Items(transactionIDs.IndexOf(successTransactions(i))).SubItems(1).Text = "Completed."
            programLoad.lsvRoomsLoading.Items(transactionIDs.IndexOf(successTransactions(i))).BackColor = Color.LimeGreen
            'add an if statement to see if its already been changed to prevent constant refreshing
        Next
        For i = 0 To tmpF - 1 Step 1
            programLoad.lsvRoomsLoading.Items(transactionIDs.IndexOf(errorTransactions(i))).SubItems(1).Text = "Failed."
            programLoad.lsvRoomsLoading.Items(transactionIDs.IndexOf(errorTransactions(i))).BackColor = Color.Red
        Next
        
    End Sub
    Private Sub LoadDefaultProgramByRoomTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadDefaultProgramByRoomTypeToolStripMenuItem.Click
        RE_tmrProgramLoad.Start()
        programLoad = New frmProgramLoad
        RE_loadComplete = False
        'Method to add default programs based upon the type of room.
        'Get file path from SQL for the default program. Maybe the file can be stored on the SQL server? Not sure how to do that still
        'Create a Crestron Session object for each room
        
        RE_Ip.Clear()
        errorNumber = 0
        successNumber = 0
        If RE_tcRoomViewer.SelectedIndex = 0 Then
            For Each n As TreeNode In RE_SelectedNodesByFloor
                For Each s As String() In RE_roomList
                    If n.Text = s(3) Then
                        RE_Ip.Add(s(6))
                    End If
                Next
            Next
        Else
            For Each n As TreeNode In RE_SelectedNodesByType
                For Each s As String() In RE_roomList
                    If n.Text = s(3) Then
                        RE_Ip.Add(s(6))
                    End If
                Next
            Next
        End If

        programLoad.loadInfo(RE_Ip)
        programLoad.Show()
        

        RE_process = True



        'Make a special Event listener method and can change the address of the event above
        'If it fails add it to some counter for each different reason and then display what worked/failed at the end
    End Sub
    Private Sub RE_tvRooms_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles RE_tvRoomsByFloor.AfterSelect, RE_tvRoomsByType.AfterSelect
        If RE_tcRoomViewer.SelectedIndex = 0 Then
            For a = 0 To RE_roomList.Count - 1 Step 1
                If RE_tvRoomsByFloor.SelectedNode.Text = RE_roomList(a)(3) Then
                    RE_tbRoomName.Text = RE_roomList(a)(3)
                    RE_tbRoomType.Text = RE_roomList(a)(4)
                    RE_tbBuilding.Text = RE_roomList(a)(1)
                    RE_tbFloor.Text = RE_roomList(a)(2)
                    RE_tbIpAddress.Text = RE_roomList(a)(6)
                    RE_tbMAC.Text = RE_roomList(a)(5)
                End If
            Next
        Else
            For a = 0 To RE_roomList.Count - 1 Step 1
                If RE_tvRoomsByType.SelectedNode.Text = RE_roomList(a)(3) Then
                    RE_tbRoomName.Text = RE_roomList(a)(3)
                    RE_tbRoomType.Text = RE_roomList(a)(4)
                    RE_tbBuilding.Text = RE_roomList(a)(1)
                    RE_tbFloor.Text = RE_roomList(a)(2)
                    RE_tbIpAddress.Text = RE_roomList(a)(6)
                    RE_tbMAC.Text = RE_roomList(a)(5)
                End If
            Next
        End If
        


    End Sub
#End Region

#Region "Event Editor"
    Private Sub updateEventList()
        EE_eventList.Clear()
        EE_lbEvents.Items.Clear()

        sqlCmd.CommandText = "Select * from tbl_events"
        If SQLCONNECTED Then
            Try
                sqlReader = sqlCmd.ExecuteReader()
                While sqlReader.Read()
                    EE_eventList.Add(New String() {sqlReader(0).ToString, sqlReader(1).ToString, sqlReader(2).ToString, sqlReader(3).ToString, sqlReader(4).ToString})
                    EE_lbEvents.Items.Add(sqlReader(1))
                End While
                sqlReader.Close()
            Catch ex As SqlException
                MessageBox.Show("SQL Exception: " + ex.ToString)
            End Try
        End If
        
    End Sub
    Private Sub EE_getDetails(ByVal index As Integer)
        EE_currentEvent = EE_eventList(index).Clone()
        EE_tbAlarmCode.Text = EE_eventList(index)(4)
        EE_tbPriority.Text = EE_eventList(index)(3)
        EE_rtbDescription.Text = EE_eventList(index)(1)
        EE_rtbSolution.Text = EE_eventList(index)(2)
    End Sub
    Private Sub EE_lbEvents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles EE_lbEvents.SelectedIndexChanged
        EE_getDetails(EE_lbEvents.SelectedIndex)
    End Sub
    Private Sub EE_tbPriority_TextChanged(sender As System.Object, e As System.EventArgs) Handles EE_tbPriority.TextChanged
        EE_currentEvent(3) = EE_tbPriority.Text
    End Sub

    Private Sub EE_tbAlarmCode_TextChanged(sender As System.Object, e As System.EventArgs) Handles EE_tbAlarmCode.TextChanged
        EE_currentEvent(4) = EE_tbAlarmCode.Text
    End Sub

    Private Sub EE_rtbDescription_TextChanged(sender As System.Object, e As System.EventArgs) Handles EE_rtbDescription.TextChanged
        EE_currentEvent(1) = EE_rtbDescription.Text
    End Sub

    Private Sub EE_rtbSolution_TextChanged(sender As System.Object, e As System.EventArgs) Handles EE_rtbSolution.TextChanged
        EE_currentEvent(2) = EE_rtbSolution.Text
    End Sub
    Private Sub EE_btnSave_Click(sender As System.Object, e As System.EventArgs) Handles EE_btnSave.Click
        If EE_currentEvent(0) <> "" And EE_currentEvent(1) <> "" And EE_currentEvent(2) <> "" And EE_currentEvent(3) <> "" And EE_currentEvent(4) <> "" Then
            Try
                If EE_compareToSave(EE_eventList(EE_lbEvents.SelectedIndex), EE_currentEvent) Then
                    sqlCmd.CommandText = "Update tbl_events set Description = '" & EE_rtbDescription.Text & "', Solution = '" & EE_rtbSolution.Text & "', Priority = " & EE_tbPriority.Text _
                        & ",Alarm_Code = '" & EE_tbAlarmCode.Text & "'  where id = " & EE_currentEvent(0) & ";"
                    Try
                        sqlCmd.ExecuteNonQuery()
                        updateEventList()
                        tssLbl_Status.Text = "Event Saved."
                    Catch ex As SqlException
                        tssLbl_Status.Text = "SQL Exception thrown: " + ex.Message
                    End Try

                Else
                    tssLbl_Status.Text = "Not saved. No changes were made."
                End If
            Catch ex As ArgumentException

            End Try
        Else
            tssLbl_Status.Text = "Error. All fields must have values. No field is allowed to be left blank."
        End If

    End Sub
    Private Function EE_compareToSave(ByVal original As String(), ByVal modified As String()) As Boolean
        If original(0) = modified(0) And original(1) = modified(1) And original(2) = modified(2) And _
        original(3) = modified(3) And original(4) = modified(4) Then
            Return False
        Else : Return True
        End If

    End Function

    Private Sub EE_btnNew_Click(sender As System.Object, e As System.EventArgs) Handles EE_btnNew.Click
        Dim name As String = Nothing

        name = InputBox("Enter the description of the event :", "Enter Event Description")
        If name <> Nothing Then
            sqlCmd.CommandText = "Insert into tbl_events(Description) values('" & name & "');"
            Try
                sqlCmd.ExecuteNonQuery()
            Catch ex As SqlException
                MessageBox.Show("SQL Exception: " + ex.ToString)
            Catch ex As Exception
                MessageBox.Show("Exception: " + ex.ToString)
            End Try
        End If
        updateEventList()
        EE_lbEvents.SelectedIndex = EE_lbEvents.Items.Count - 1
    End Sub
    Private Sub EE_btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles EE_btnDelete.Click
        'Add a delete funciton to remove events from the database
        If EE_lbEvents.SelectedIndex > -1 Then
            sqlCmd.CommandText = "DELETE FROM tbl_Events WHERE Alarm_Code='" + EE_tbAlarmCode.Text + "';"
            Try
                sqlCmd.ExecuteNonQuery()
                tssLbl_Status.Text = "Deleted."
            Catch ex As Exception
                MessageBox.Show("SQL Exception: " + ex.ToString)
            End Try
        End If
        updateEventList()
    End Sub
#End Region

#Region "State Manager"
    'Update all the fields in the State Manager ie The states list, the device types list etc..
    Private Sub updateStateManager()
        'Clear all the existing items in the check box
        SM_cbDevices.Items.Clear()
        'Add all the devices to the Devices check box
        For Each item In AE_lbDevices.Items
            SM_cbDevices.Items.Add(item)
        Next
        'Set the State manager list of devices to the alarm editor list of devices
        SM_deviceTypeList = AE_deviceTypeList
    End Sub
    Private Sub SM_cbDevices_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SM_cbDevices.SelectedIndexChanged
        'Every time a device is selected check to see if its a Analog or binary device then show the appropriate  controls for said signal type
        If SM_deviceTypeList.Item(SM_cbDevices.SelectedIndex)(4) = "Analog" Then
            SM_gbLights.Visible = False
            SM_gbTVControls.Visible = False
            If SM_deviceTypeList.Item(SM_cbDevices.SelectedIndex)(1) = "SHADES" Then
                SM_tcShades.Visible = True
                SM_gbTstatControls.Visible = False
            Else
                SM_tcShades.Visible = False
                SM_gbTstatControls.Visible = True
            End If

        ElseIf SM_deviceTypeList.Item(SM_cbDevices.SelectedIndex)(4) = "Binary" Then
            SM_tcShades.Visible = False
            SM_gbTstatControls.Visible = False
            If SM_deviceTypeList.Item(SM_cbDevices.SelectedIndex)(1) = "TV" Then
                SM_gbTVControls.Visible = True
                SM_gbLights.Visible = False
            Else
                SM_gbLights.Visible = True
                SM_gbTVControls.Visible = False
            End If

        End If
    End Sub
    'When the thermostat slider is changed update the up down box and visa versa
    Private Sub SM_tbTstatSlider_Scroll(sender As System.Object, e As System.EventArgs) Handles SM_tbTstatSlider.Scroll
        SM_nudSetPoint.Value = SM_tbTstatSlider.Value
    End Sub
    Private Sub SM_nudSetPoint_ValueChanged(sender As System.Object, e As System.EventArgs) Handles SM_nudSetPoint.ValueChanged
        SM_tbTstatSlider.Value = SM_nudSetPoint.Value
    End Sub

    'Create a new State and add it to the database
    Private Sub SM_btnNew_Click(sender As System.Object, e As System.EventArgs) Handles SM_btnNew.Click
        SM_lbStates.Items.Add(InputBox("Enter the name of the new state."))
    End Sub

    'Update the controls based upon the selected state
    Private Sub SM_lbStates_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SM_lbStates.SelectedIndexChanged
        SM_tbStateName.Text = SM_lbStates.Items.Item(SM_lbStates.SelectedIndex)
    End Sub
#End Region

#End Region

#Region "Tools"

    'Open the Database setup excel room loader 
    Private Sub DatabaseSetupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatabaseSetupToolStripMenuItem.Click
        frmExcel_Room_Loader.Show()
        frmExcel_Room_Loader.loadExcelLoader(sqlCmd, sqlReader)
    End Sub

    'Open the SQL Server configuration window and pass the server address username and password to be updated
    Private Sub SQLServerConfigurationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SQLServerConfigurationToolStripMenuItem.Click
        frmServerConfig.Show()
        frmServerConfig.loadForm(SERVER_ADDRESS, USERNAME, PASSWORD)
    End Sub

    'Open the Loyalty Program Form
    Private Sub LoyaltyProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoyaltyProgramToolStripMenuItem.Click
        frmLoyaltyProgram.SM_devicetypelist = Me.SM_deviceTypeList
        frmLoyaltyProgram.Show()
        frmLoyaltyProgram.BringToFront()

        frmLoyaltyProgram.SM_cbDevices.Items.Clear()
        'Add all the devices to the Devices check box
        For Each item In AE_lbDevices.Items
            frmLoyaltyProgram.SM_cbDevices.Items.Add(item)
        Next

    End Sub
#End Region

#Region "Modes"
    Private Sub BasicMode()
        tpvConfigurator.TabPages(0).Enabled = False
        RTE_gbDefaultState.Enabled = False
        RTE_gbDevices.Enabled = False
        RTE_gbProgramInfo.Enabled = False
        RE_gbDevices.Enabled = False
        RE_gbRoomStatus.Enabled = False
        RE_gbRoomSettings.Enabled = False
        tpvConfigurator.TabPages(3).Enabled = False
        tpvConfigurator.TabPages(4).Enabled = False
    End Sub

    Private Sub EnhancedMode()
        tpvConfigurator.TabPages(0).Enabled = True
        RTE_gbDefaultState.Enabled = True
        RTE_gbDevices.Enabled = True
        RTE_gbProgramInfo.Enabled = True
        RE_gbDevices.Enabled = True
        RE_gbRoomStatus.Enabled = True
        RE_gbRoomSettings.Enabled = True
        tpvConfigurator.TabPages(3).Enabled = True
        tpvConfigurator.TabPages(4).Enabled = True
    End Sub

#End Region

#Region "Main Form Event Methods"
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub tpvConfigurator_TabIndexChanged(sender As System.Object, e As System.EventArgs) Handles tpvConfigurator.SelectedIndexChanged
        If SQLCONNECTED Then
            Select Case tpvConfigurator.SelectedIndex
                Case 0
                    updateDeviceTypes()
                Case 1
                    updateRoomTypes()
                Case 2
                    updateRoomList()
                    updateTVRoomListByFloor()
                Case 3
                    updateEventList()
                Case 4
                    updateStateManager()
            End Select
        End If

    End Sub

    'When connecting to a database, refresh all information 
    Public Sub updateAll()
        If SQLCONNECTED Then
            updateDeviceTypes()
            updateRoomList()
            updateRoomList()
            updateTVRoomListByFloor()
            updateTVRoomListByType()
            updateStateManager()
            AE_getWarnings()
        End If
    End Sub
    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        SERVER_ADDRESS = "ADGATL-PC"
        USERNAME = "Test"
        PASSWORD = "adg10990"


        'sqlCmd.Connection = connectToDatabase()

        'Not sure if this is a good idea. Couldn't find another way to avoid.
        'I think if i use two lists or arrays and add the successful/failed transactions then use the alarm tick to update the program load form
        'i can avoid getting a illegal cross thread call and remove this statement
        'System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        'updateDeviceTypes()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'ONLY DOING THIS BECAUSE THERE IS A LEAK SOMEWHERE. 
            '           Somewhere excel is not being closed. Not sure how because i've closed the xcel application and workbook multiple times
            '           so for the moment i'm just killing all excel processes. Which is bad in the long run. Very bad.
            '       Actually, this is ok for the moment. Will need to remove eventually. The only reason the excel process are staying open
            '       is because when you force stop in visual studio the program doesn't run the form closing event and therefore does not close the open excel applications


            'Dim p() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
            'For Each a In p
            '    a.Kill()
            'Next
            sqlCmd.Connection.Close()
            sqlCmd.Connection.Dispose()
            sqlReader.Close()

        Catch ex As NullReferenceException

        Catch ex As Exception
            MessageBox.Show("Error closing form:" + ex.ToString)
        End Try

    End Sub
    Private Sub tvDevicesAdded_NodeMouseClick(sender As Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles RTE_tvDevicesAdded.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then

            tvMenuStrip.Show()
        End If
    End Sub

#End Region

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Dim eor As String = ""
        For Each s As VptSession In sessions
            s.GetLastError(eor)
            Debug.Print(eor)
        Next
    End Sub

    
   
    Private Sub ReplaceDeviceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReplaceDeviceToolStripMenuItem.Click
        MessageBox.Show("Processor is in aquire mode. Press Ok when finished to asign ID")
    End Sub

    Private Sub BasicModeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BasicModeToolStripMenuItem.Click
        BasicMode()
    End Sub
End Class