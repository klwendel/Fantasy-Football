Imports DataObjects
Imports DAL
Imports System.Data.SqlClient

Public Class LeagueManager
    Public _leagueRowList As List(Of League)
    Public _success As Boolean
    '***CORRECT***
    Public Sub getLeagueRowList(ByRef active As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        If active > 1 Then
            _leagueRowList = LeagueList.getLeagueList(conn)
        Else
            _leagueRowList = LeagueList.getLeagueListByActive(active, conn)
        End If
    End Sub
    '***CORRECT***
    Public Sub addLeague(ByRef league As League)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = LeagueList.addLeagueRecord(league, conn)
    End Sub
    '***CORRECT***
    Public Sub editLeague(ByRef oldLeague As League, ByRef newLeague As League)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = LeagueList.editLeagueRecord(oldLeague, newLeague, conn)
    End Sub
    '***CORRECT***
    Public Sub deactivateLeague(ByRef leagueID As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = LeagueList.deactivateLeagueRecord(leagueID, conn)
    End Sub
    '***CORRECT***
    Public Sub activateLeague(ByRef leagueID As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = LeagueList.activateLeagueRecord(leagueID, conn)
    End Sub
End Class