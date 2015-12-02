Imports System.Data.SqlClient

Public Class DatabaseConnections
    Public Shared Function GetFantasyFootballConn() As SqlConnection
        'Holds a String with our connection to the local DB.
        Dim connString As String = "Data Source=localhost\sqlexpress;Initial Catalog=FantasyFootballDB;Integrated Security=True"
        'Creates/passes new SqlConnection with the String specified above.
        Return New SqlConnection(connString)
    End Function
End Class
