Public Class frmKPIView

    Public Sub loadInfo(ByVal alarms As List(Of String()), ByVal p2 As List(Of String), ByVal p3 As String)
        lsvKPI.Items.Clear()
        Me.Text = p3
        For Each a As String() In alarms
            For Each b As String In p2
                If a(6) = b And a(6) <> "1" Then
                    Dim itm As New ListViewItem(a(2))
                    itm.SubItems.Add(a(3))
                    itm.SubItems.Add(a(6))
                    lsvKPI.Items.Add(itm)
                End If
            Next
        Next
        lsvKPI.SetBounds(0, 0, lsvKPI.Width, ((lsvKPI.Items.Count * 20) + 25))
        btnPrint.Location = New Point(116, lsvKPI.Location.Y + lsvKPI.Height + 15)
        btnOk.Location = New Point(197, lsvKPI.Location.Y + lsvKPI.Height + 15)
        Me.Height = btnOk.Location.Y + btnOk.Height + 45
        Me.CenterToParent()
    End Sub
    Public Sub loadInfo(ByVal alarms As List(Of String()), ByVal p2 As String, ByVal p3 As String)
        lsvKPI.Items.Clear()
        Me.Text = p3
        For Each a As String() In alarms
            If a(4) = p2 And a(6) <> "1" Then
                Dim itm As New ListViewItem(a(2))
                itm.SubItems.Add(a(3))
                itm.SubItems.Add(a(6))
                lsvKPI.Items.Add(itm)
            End If
        Next

        lsvKPI.SetBounds(0, 0, lsvKPI.Width, ((lsvKPI.Items.Count * 20) + 25))
        btnPrint.Location = New Point(116, lsvKPI.Location.Y + lsvKPI.Height + 15)
        btnOk.Location = New Point(197, lsvKPI.Location.Y + lsvKPI.Height + 15)
        Me.Height = btnOk.Location.Y + btnOk.Height + 45
        Me.CenterToParent()
    End Sub
    
    

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    
End Class