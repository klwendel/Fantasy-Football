Public Class Roster
    'Could maybe do an Enumeration for the positions.
    Private _playerID As Integer
    Private _firstName As String
    Private _lastName As String
    Private _positionID As Integer
    Private _position As String
    Private _teamID As Integer
    Private _team As String
    Private _active As Boolean

    Public Property playerID As Integer
        Set(ByVal value As Integer)
            _playerID = value
        End Set
        Get
            Return _playerID
        End Get
    End Property

    Public Property firstName As String
        Set(ByVal value As String)
            _firstName = value
        End Set
        Get
            Return _firstName
        End Get
    End Property

    Public Property lastName As String
        Set(ByVal value As String)
            _lastName = value
        End Set
        Get
            Return _lastName
        End Get
    End Property

    Public Property positionID As Integer
        Set(ByVal value As Integer)
            _positionID = value
        End Set
        Get
            Return _positionID
        End Get
    End Property

    Public Property position As String
        Set(ByVal value As String)
            _position = value
        End Set
        Get
            Return _position
        End Get
    End Property

    Public Property teamID As Integer
        Set(ByVal value As Integer)
            _teamID = value
        End Set
        Get
            Return _teamID
        End Get
    End Property

    Public Property team As String
        Set(ByVal value As String)
            _team = value
        End Set
        Get
            Return _team
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
