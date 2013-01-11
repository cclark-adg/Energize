
Public Class Alert
    Private id As String
    Private timestamp As Date
    Private errCode As String
    Private pr As Integer
    Private sol As String
    Private des As String
    Private ack As Boolean
    Private rtn As Boolean
    Private _p1 As Object

    Sub New(ByRef room As Room, ByRef errorCode As String)

        
    End Sub

    Private Sub setAttributes()
        Select Case errCode.Substring(0, 1)
            Case Is = "A"
                Select Case errCode.Substring(1)
                    Case Is = "00"
                        pr = 1
                        sol = "Check Cables in Room"
                        des = "Room is Offline"
                    Case Is = "1"
                        pr = 5
                        sol = "Check HVAC system "
                        des = "HVAC is not working operating correctly"
                End Select
            Case Is = "B"
                Select Case errCode.Substring(1)
                    Case Is = "1"
                        pr = 20
                        sol = "Replace Batteries in Remote"
                        des = "Low Remote Battery"
                    Case Is = "2"
                        pr = 15
                        sol = "Go to room to check physical state of TV. Check to make sure it is plugged in correctly and all cables are attatched firmly"
                        des = "TV is not working"
                End Select
        End Select

        
    End Sub
    Public Function getItem() As ListViewItem
        Dim temp As New ListViewItem(timestamp)
        temp.SubItems.Add(id)
        temp.SubItems.Add(des)
        temp.SubItems.Add(errCode)
        temp.SubItems.Add(pr)
        Return temp
    End Function
    Public ReadOnly Property Description As String
        Get
            Return Me.des
        End Get
    End Property
    Public ReadOnly Property ReturnToNormal As Boolean
        Get
            Return Me.rtn
        End Get
    End Property
    Public Property Acknowledged As Boolean
        Get
            Return Me.ack
        End Get
        Set(ByVal value As Boolean)
            ack = value
        End Set
    End Property
    Public Property ErrorCode As String
        Get
            Return Me.errCode
        End Get
        Set(ByVal value As String)
            Me.errCode = value
        End Set
    End Property

    Public ReadOnly Property Solution As String
        Get
            Return Me.sol
        End Get
    End Property

    Public ReadOnly Property Priority As Integer
        Get
            Return Me.pr
        End Get
    End Property

    Public Property Time As Date
        Get
            Return Me.timestamp
        End Get
        Set(ByVal value As Date)
            Me.timestamp = value
        End Set
    End Property

    Public ReadOnly Property IDNum As String
        Get
            Return Me.id
        End Get
    End Property

    Public Sub checkReturnToNormal(ByRef rm As Room)
        Dim tmp As Boolean = True
        For Each i As String In rm.ErrorCode
            If i = errCode Then
                tmp = False
            End If
        Next
        If tmp Then
            rm.ErrorCode.Remove(errCode)
            rtn = True
        Else
            rtn = False
        End If
    End Sub
End Class
