Public Class Owner
    Private _ownerID As Integer
    Private _firstName As String
    Private _lastName As String
    Private _roleID As Integer
    Private _roleDescription As String
    Private _active As Boolean

    'Properties used to set/return values of the object.
    Public Property ownerID As Integer
        Set(ByVal value As Integer)
            _ownerID = value
        End Set
        Get
            Return _ownerID
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

    Public Property roleID As Integer
        Set(ByVal value As Integer)
            _roleID = value
        End Set
        Get
            Return _roleID
        End Get
    End Property

    Public Property roleDescription As String
        Set(ByVal value As String)
            _roleDescription = value
        End Set
        Get
            Return _roleDescription
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
