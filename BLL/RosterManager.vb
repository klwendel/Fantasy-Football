Imports DataObjects
Imports DAL
Imports System.Data.SqlClient

Public Class RosterManager
    Public _rosterRowList As List(Of Roster)
    Public _success As Boolean
    '***CORRECT***
    Public Sub getRosterRowList()
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _rosterRowList = RosterList.getRosterList(conn)
    End Sub
    '***CORRECT***
    Public Sub getRosterRowListByTeam(ByRef teamID As Integer, ByRef active As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        If active = 1 Then
            _rosterRowList = RosterList.getRosterListByTeamActive(teamID, 1, conn)
        Else
            _rosterRowList = RosterList.getRosterListByTeam(teamID, conn)
        End If
    End Sub
    '***CORRECT***
    Public Sub addRoster(ByRef roster As Roster)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = RosterList.addRosterRecord(roster, conn)
    End Sub
    '***CORRECT***
    Public Sub editRoster(ByRef oldRoster As Roster, ByRef newRoster As Roster)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = RosterList.editRosterRecord(oldRoster, newRoster, conn)
    End Sub
    '***CORRECT***
    Public Sub deactivateRoster(ByRef playerID As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = RosterList.deactivateRosterRecord(playerID, conn)
    End Sub
    '***CORRECT***
    Public Sub activateRoster(ByRef playerID As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = RosterList.activateRosterRecord(playerID, conn)
    End Sub
End Class


