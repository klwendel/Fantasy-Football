Public Class Team
    Private _teamID As Integer
    Private _name As String
    Private _ownerID As Integer
    Private _ownerFirst As String
    Private _ownerLast As String
    Private _leagueID As Integer
    Private _leagueName As String
    Private _active As Boolean

    Public Property teamID As Integer
        Set(ByVal value As Integer)
            _teamID = value
        End Set
        Get
            Return _teamID
        End Get
    End Property

    Public Property name As String
        Set(ByVal value As String)
            _name = value
        End Set
        Get
            Return _name
        End Get
    End Property

    Public Property ownerID As Integer
        Set(ByVal value As Integer)
            _ownerID = value
        End Set
        Get
            Return _ownerID
        End Get
    End Property

    Public Property ownerFirst As String
        Set(ByVal value As String)
            _ownerFirst = value
        End Set
        Get
            Return _ownerFirst
        End Get
    End Property

    Public Property ownerLast As String
        Set(ByVal value As String)
            _ownerLast = value
        End Set
        Get
            Return _ownerLast
        End Get
    End Property

    Public Property leagueID As Integer
        Set(ByVal value As Integer)
            _leagueID = value
        End Set
        Get
            Return _leagueID
        End Get
    End Property

    Public Property leagueName As String
        Set(ByVal value As String)
            _leagueName = value
        End Set
        Get
            Return _leagueName
        End Get
    End Property

    Public Property active As Boolean
        Set(ByVal value As Boolean)
            _active = value
        End Set
        Get
            Return _active
        End Get
    End Property
End Class
