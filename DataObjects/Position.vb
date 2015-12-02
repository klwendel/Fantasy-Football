Public Class Position
    Private _positionID As Integer
    Private _description As String

    Public Property positionID As Integer
        Set(ByVal value As Integer)
            _positionID = value
        End Set
        Get
            Return _positionID
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
