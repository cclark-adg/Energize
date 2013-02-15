Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmExcel_Room_Loader

#Region "Variables"

#Region "SQL Variables"
    Private sqlCmd As New SqlCommand
    Private sqlReader As SqlDataReader
#End Region

#End Region

#Region "Form Custom Constructor-ish"
    Public Sub loadExcelLoader(ByVal sqlCommand As SqlCommand, ByVal sqlDataReader As SqlDataReader)
        sqlCmd = sqlCommand
        sqlReader = sqlDataReader
    End Sub
#End Region

#Region "Excel Room Loader"

    Private Sub btnBrowseExcel_Click(sender As System.Object, e As System.EventArgs) Handles RL_btnBrowseExcel.Click
        Dim xcel As New Excel.Application
        Dim workbook As Excel.Workbook
        Dim sheet As Excel.Worksheet
        Dim filepath As String

        openProgram.ShowDialog()
        filepath = openProgram.FileName
        If filepath.Length <> 0 Then
            workbook = xcel.Workbooks.Open(filepath)
            sheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)
            Dim ecellA As Excel.Range = sheet.UsedRange
            Dim ecellB As Excel.Range
            Dim eCellC As Excel.Range
            Dim eCellD As Excel.Range
            Dim eCellE As Excel.Range


            frmProgressBar.Show()
            frmProgressBar.setMax(CInt(sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row) - 2)
            Try
                For i As Integer = 2 To CInt(sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row)
                    frmProgressBar.incrementBar(1)
                    ecellA = sheet.Range("a" & i)
                    ecellB = sheet.Range("b" & i)
                    eCellC = sheet.Range("c" & i)
                    eCellD = sheet.Range("d" & i)
                    eCellE = sheet.Range("e" & i)

                    Dim itm As New ListViewItem(ecellA.Value.ToString)
                    itm.SubItems.Add(ecellB.Value.ToString)
                    itm.SubItems.Add(eCellC.Value.ToString)
                    itm.SubItems.Add(eCellD.Value.ToString)
                    itm.SubItems.Add(eCellE.Value.ToString)
                    RL_lsvRooms.Items.Add(itm)
                Next
            Catch ex As Exception

            End Try
            workbook.Close()
            xcel.Workbooks.Close()
            xcel.Quit()
            xcel = Nothing
            workbook = Nothing
        End If
    End Sub


    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles RL_btnLoad.Click
        Dim rmAdd As Integer = 0
        Dim rmNotAdded As Integer = 0
        Dim rmAlreadyExists As Integer = 0
        frmProgressBar.Show()
        frmProgressBar.setMax(RL_lsvRooms.Items.Count)
        If RL_cbLoadDevicesPerRoom.Checked = True Then
            frmProgressBar.pbLoading.Maximum += RL_lsvRooms.Items.Count
        End If
        'Add each room into the database that has been read from the excel spreadsheet.
        For Each ls As ListViewItem In RL_lsvRooms.Items
            frmProgressBar.incrementBar(1)
            sqlCmd.CommandText = "Insert into tbl_Rooms(Building,floor,room_name,IP_Address,Room_Type_ID) Values( " _
                + "'" + ls.SubItems(0).Text _
                + "','" + ls.SubItems(1).Text _
                + "','" + ls.SubItems(2).Text _
                + "','" + ls.SubItems(4).Text _
                + "',(SELECT id From tbl_RoomType Where RoomType = '" + ls.SubItems(3).Text + "'));"
            If sqlCmd.Connection.State = ConnectionState.Open Then
                Try
                    sqlCmd.ExecuteNonQuery()
                    rmAdd += 1
                Catch ex As SqlException
                    'If there is a room that already exists in the database, we get this error code, add it for display uses
                    If ex.ErrorCode = -2146232060 Then
                        rmAlreadyExists += 1
                    End If
                    rmNotAdded += 1
                Catch ex As Exception
                    MessageBox.Show("Error inserting rooms into database: " + ex.ToString)
                End Try

            End If

        Next
        '***************        Definetly possible to move to a SPR
        'If the user checks the load devices per room type check box we proceed with the following code segment
        If RL_cbLoadDevicesPerRoom.Checked = True Then
            'Go through each room that is in the list view read from the excel sheet
            For Each ls As ListViewItem In RL_lsvRooms.Items
                frmProgressBar.incrementBar(1)
                If sqlCmd.Connection.State = ConnectionState.Open Then
                    Try
                        Dim itms As New List(Of Integer())
                        'Find each device type and local id based upon the room type and add it to a list 
                        sqlCmd.CommandText = "Select id,device_type_id,local_id_number from tbl_Rooms join tbl_local_ids on tbl_local_ids.room_type_id = tbl_rooms.Room_Type_ID  and Room_Name = '" & ls.SubItems(2).Text & "';"
                        sqlReader = sqlCmd.ExecuteReader()
                        While sqlReader.Read()
                            itms.Add(New Integer() {sqlReader(0), sqlReader(1), sqlReader(2)})
                        End While
                        sqlReader.Close()
                        'go through each of those items, and add them to the database in the devices table
                        For Each i As Integer() In itms
                            sqlCmd.CommandText = "Insert into tbl_devices values(" & i(0) & "," & i(1) & "," & i(2) & ");"
                            sqlCmd.ExecuteNonQuery()
                        Next
                    Catch ex As SqlException
                        MessageBox.Show("sql exception" & ex.ToString)
                    End Try
                End If
            Next
        End If
        MessageBox.Show(rmAdd.ToString + " Rooms were added." + vbCrLf + rmAlreadyExists.ToString + " Rooms already exists. Conflict of name." + vbCrLf + rmNotAdded.ToString + " Rooms were not added.")
    End Sub

#End Region


    Private Sub frmExcel_Room_Loader_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class