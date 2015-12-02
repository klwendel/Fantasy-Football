Public Class Role
    Private _roleID As Integer
    Private _description As String

    Public Property roleID As Integer
        Set(ByVal value As Integer)
            _roleID = value
        End Set
        Get
            Return _roleID
        End Get
    End Property

    Public Property description As String
        Set(ByVal value As String)
            _description = value
        End Set
        Get
            Return _description
        End Get
    End Property
End Class
