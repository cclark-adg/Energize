Public Class frmProgramLoad

    Public Sub loadInfo(ByVal alarms As List(Of String))
        lsvRoomsLoading.Items.Clear()

        For Each a As String In alarms
            Dim itm As New ListViewItem(a)
            itm.SubItems.Add("Pending...")
            lsvRoomsLoading.Items.Add(itm)
        Next
        'lsvRoomsLoading.SetBounds(0, 0, lsvRoomsLoading.Width, ((lsvRoomsLoading.Items.Count * 20) + 25))
        'btnPrint.Location = New Point(116, lsvRoomsLoading.Location.Y + lsvRoomsLoading.Height + 15)
        'btnOk.Location = New Point(197, lsvRoomsLoading.Location.Y + lsvRoomsLoading.Height + 15)
        'Me.Height = btnOk.Location.Y + btnOk.Height + 45
        Me.CenterToParent()
    End Sub
    Public Sub loadInfo(ByVal alarms As List(Of String()), ByVal p2 As String, ByVal p3 As String)
        lsvRoomsLoading.Items.Clear()
        Me.Text = p3
        For Each a As String() In alarms
            If a(4) = p2 And a(6) <> "1" Then
                Dim itm As New ListViewItem(a(2))
                itm.SubItems.Add(a(3))
                itm.SubItems.Add(a(6))
                lsvRoomsLoading.Items.Add(itm)
            End If
        Next

        lsvRoomsLoading.SetBounds(0, 0, lsvRoomsLoading.Width, ((lsvRoomsLoading.Items.Count * 20) + 25))
        btnPrint.Location = New Point(116, lsvRoomsLoading.Location.Y + lsvRoomsLoading.Height + 15)
        btnOk.Location = New Point(197, lsvRoomsLoading.Location.Y + lsvRoomsLoading.Height + 15)
        Me.Height = btnOk.Location.Y + btnOk.Height + 45
        Me.CenterToParent()
    End Sub

    Public Sub changeStatus(ByVal index As Integer, ByVal status As String)
        If status = "Failed." Then
            lsvRoomsLoading.Items(index).SubItems(1).Text = status
        Else
            lsvRoomsLoading.Items(index).SubItems(1).Text = status
        End If


    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub



End Class