Imports DataObjects
Imports DAL
Imports System.Data.SqlClient

Public Class TeamManager
    Public _teamRowList As List(Of Team)
    Public _success As Boolean
    '***CORRECT***
    Public Sub getTeamRowList()
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _teamRowList = TeamList.getTeamList(conn)
    End Sub
    '***CORRECT***
    Public Sub getTeamRowListByLeague(ByRef leagueID As Integer, ByRef active As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        If active = 1 Then
            _teamRowList = TeamList.getTeamListByLeagueActive(leagueID, 1, conn)
        Else
            _teamRowList = TeamList.getTeamListByLeague(leagueID, conn)
        End If
    End Sub
    '***CORRECT***
    Public Sub getTeamRowListByActive(ByRef active As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        If active = 1 Then
            _teamRowList = TeamList.getTeamListByActive(1, conn)
        Else
            _teamRowList = TeamList.getTeamListByActive(0, conn)
        End If
    End Sub
    '***CORRECT***
    Public Sub addTeam(ByRef team As Team)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = TeamList.addTeamRecord(team, conn)
    End Sub
    '***CORRECT***
    Public Sub editTeam(ByRef oldTeam As Team, ByRef newTeam As Team)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = TeamList.editTeamRecord(oldTeam, newTeam, conn)
    End Sub
    '***CORRECT***
    Public Sub deactivateTeam(ByRef teamID As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = TeamList.deactivateTeamRecord(teamID, conn)
    End Sub
    '***CORRECT***
    Public Sub activateTeam(ByRef teamID As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = TeamList.activateTeamRecord(teamID, conn)
    End Sub
End Class
