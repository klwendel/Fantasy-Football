Imports DataObjects
Imports DAL
Imports System.Data.SqlClient

Public Class RoleManager
    Public _roleRowList As List(Of Role)
    '***CORRECT***
    Public Sub getLeagueRowList()
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _roleRowList = RoleList.getRoleList(conn)
    End Sub
End Class
