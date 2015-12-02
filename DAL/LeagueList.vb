Imports DataObjects
Imports System.Data.SqlClient

Public Class LeagueList
    '***CORRECT***
    Public Shared Function getLeagueList(ByRef conn As SqlConnection) As List(Of League)
        Dim _leagueList As New List(Of League)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetLeagueList"
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim league As League
            If reader.HasRows Then
                Do While reader.Read
                    league = New League
                    league.leagueID = CInt(reader("LeagueID"))
                    league.name = reader("Name").ToString
                    league.ownerID = CInt(reader("OwnerID"))
                    league.ownerFirst = reader("FirstName").ToString
                    league.ownerLast = reader("LastName").ToString
                    league.teamLimit = CInt(reader("TeamLimit"))
                    league.creationDate = CDate(reader("CreationDate"))
                    league.active = CBool(reader("Active"))
                    _leagueList.Add(league)
                    league = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _leagueList
    End Function
    '***CORRECT***
    Public Shared Function getLeagueListByActive(ByRef active As Integer, ByRef conn As SqlConnection) As List(Of League)
        Dim _leagueList As New List(Of League)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetLeagueListByActive"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Active", active)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim league As League
            If reader.HasRows Then
                Do While reader.Read
                    league = New League
                    league.leagueID = CInt(reader("LeagueID"))
                    league.name = reader("Name").ToString
                    league.ownerID = CInt(reader("OwnerID"))
                    league.ownerFirst = reader("FirstName").ToString
                    league.ownerLast = reader("LastName").ToString
                    league.teamLimit = CInt(reader("TeamLimit"))
                    league.creationDate = CDate(reader("CreationDate"))
                    league.active = CBool(reader("Active"))
                    _leagueList.Add(league)
                    league = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _leagueList
    End Function
    '***CORRECT***
    Public Shared Function addLeagueRecord(ByRef league As League, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spAddLeague"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Name", league.name)
            command.Parameters.AddWithValue("@OwnerID", league.ownerID)
            command.Parameters.AddWithValue("@TeamLimit", league.teamLimit)
            command.Parameters.AddWithValue("@Active", league.active)
            rowcount = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If rowcount > 0 Then
                success = True
            End If
            conn.Close()
        End Try
        Return success
    End Function
    '***CORRECT***
    Public Shared Function editLeagueRecord(ByRef oldLeague As League, ByRef newLeague As League, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spEditLeague"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Name", newLeague.name)
            command.Parameters.AddWithValue("@OwnerID", newLeague.ownerID)
            command.Parameters.AddWithValue("@TeamLimit", newLeague.teamLimit)
            command.Parameters.AddWithValue("@Active", newLeague.active)
            command.Parameters.AddWithValue("@OldName", oldLeague.name)
            command.Parameters.AddWithValue("@OldOwnerID", oldLeague.ownerID)
            command.Parameters.AddWithValue("@OldTeamLimit", oldLeague.teamLimit)
            command.Parameters.AddWithValue("@OldActive", oldLeague.active)
            command.Parameters.AddWithValue("@LeagueID", oldLeague.leagueID)
            rowcount = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If rowcount > 0 Then
                success = True
            End If
            conn.Close()
        End Try
        Return success
    End Function
    '***CORRECT***
    Public Shared Function deactivateLeagueRecord(ByRef leagueID As Integer, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spDeactivateLeague"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@LeagueID", leagueID)
            rowcount = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If rowcount > 0 Then
                success = True
            End If
            conn.Close()
        End Try
        Return success
    End Function
    '***CORRECT***
    Public Shared Function activateLeagueRecord(ByRef leagueID As Integer, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spActivateLeague"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@LeagueID", leagueID)
            rowcount = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If rowcount > 0 Then
                success = True
            End If
            conn.Close()
        End Try
        Return success
    End Function
End Class