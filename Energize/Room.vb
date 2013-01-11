
Public Class Room
    Private hvc As Boolean
    Private tele As Boolean
    Private alrt As Boolean
    Private minBar As Boolean
    Private id As String
    Private remote As Boolean
    Private errCode As New List(Of String)

   

    Public Property IDNum As String
        Get
            Return Me.id
        End Get
        Set(ByVal value As String)
            Me.id = value
        End Set
    End Property

    Public Property HVAC As Boolean
        Get
            Return hvc
        End Get
        Set(ByVal value As Boolean)
            Me.hvc = value
        End Set
    End Property

    Public Property TV As Boolean
        Get
            Return Me.tele
        End Get
        Set(ByVal value As Boolean)
            Me.tele = value
        End Set
    End Property

    Public Property MiniBar As Boolean
        Get
            Return Me.minBar
        End Get
        Set(ByVal value As Boolean)
            Me.minBar = value
        End Set
    End Property

    Public Property Alert As Boolean
        Get
            Return Me.alrt
        End Get
        Set(ByVal value As Boolean)
            Me.alrt = value
        End Set
    End Property
    
    

    Public Function ErrorCode() As List(Of String)
        Return errCode
    End Function

    
    


End Class
