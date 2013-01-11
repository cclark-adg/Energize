
Public Class Status
    Private devID As Integer
    Private attr As String
    Private val As Integer
    Private devT As String

    Private tmStmp As String
    Private rmName As String

    Private alrt As Boolean

    Sub New(ByVal statement() As String)
        Me.tmStmp = statement(0)
        Me.rmName = statement(1)
        Me.devT = statement(2)
        Me.devID = statement(3)
        Me.attr = statement(4)
        Me.val = statement(5)
    End Sub

#Region "Properties "

    Public ReadOnly Property Value As Integer
        Get
            Return Me.val
        End Get
    End Property

    Public ReadOnly Property Attribute As String
        Get
            Return Me.attr
        End Get
    End Property

    Public ReadOnly Property DeviceID As String
        Get
            Return Me.devID
        End Get
    End Property

    Public ReadOnly Property DeviceType As String
        Get
            Return Me.devT
        End Get
    End Property
    Public ReadOnly Property Alert As Boolean
        Get
            Return Me.alrt
        End Get
    End Property
    Public ReadOnly Property RoomName As String
        Get
            Return Me.rmName
        End Get
    End Property
    Public Property TimeStamp As String
        Get
            Return Me.tmStmp
        End Get
        Set(ByVal value As String)
            Me.tmStmp = value
        End Set
    End Property
#End Region



End Class
