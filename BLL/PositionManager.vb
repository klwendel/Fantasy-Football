Imports DataObjects
Imports DAL
Imports System.Data.SqlClient

Public Class PositionManager
    Public _positionRowList As List(Of Position)
    '***CORRECT***
    Public Sub getLeagueRowList()
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _positionRowList = PositionList.getPositionList(conn)
    End Sub
End Class
