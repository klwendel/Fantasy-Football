Imports DataObjects
Imports System.Data.SqlClient

Public Class TeamList
    '***CORRECT***
    Public Shared Function getTeamList(ByRef conn As SqlConnection)
        Dim _teamList As New List(Of Team)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetTeamList"
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim team As Team
            If reader.HasRows Then
                Do While reader.Read
                    team = New Team
                    team.teamID = CInt(reader("TeamID"))
                    team.name = reader("Name").ToString
                    team.ownerID = CInt(reader("OwnerID"))
                    team.ownerFirst = reader("FirstName").ToString
                    team.ownerLast = reader("LastName").ToString
                    team.leagueID = CInt(reader("LeagueID"))
                    team.leagueName = reader("Name").ToString
                    team.active = CBool(reader("Active"))
                    _teamList.Add(team)
                    team = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _teamList
    End Function
    '***CORRECT***
    Public Shared Function getTeamListByLeague(ByRef leagueID As Integer, ByRef conn As SqlConnection)
        Dim _teamList As New List(Of Team)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetTeamListByLeague"
            command.Parameters.AddWithValue("@LeagueID", leagueID)
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim team As Team
            If reader.HasRows Then
                Do While reader.Read
                    team = New Team
                    team.teamID = CInt(reader("TeamID"))
                    team.name = reader("Name").ToString
                    team.ownerID = CInt(reader("OwnerID"))
                    team.ownerFirst = reader("FirstName").ToString
                    team.ownerLast = reader("LastName").ToString
                    team.leagueID = CInt(reader("LeagueID"))
                    team.leagueName = reader("Name").ToString
                    team.active = CBool(reader("Active"))
                    _teamList.Add(team)
                    team = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _teamList
    End Function
    '***CORRECT***
    Public Shared Function getTeamListByActive(ByRef active As Integer, ByRef conn As SqlConnection)
        Dim _teamList As New List(Of Team)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetTeamListByActive"
            command.Parameters.AddWithValue("@Active", active)
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim team As Team
            If reader.HasRows Then
                Do While reader.Read
                    team = New Team
                    team.teamID = CInt(reader("TeamID"))
                    team.name = reader("Name").ToString
                    team.ownerID = CInt(reader("OwnerID"))
                    team.ownerFirst = reader("FirstName").ToString
                    team.ownerLast = reader("LastName").ToString
                    team.leagueID = CInt(reader("LeagueID"))
                    team.leagueName = reader("Name").ToString
                    team.active = CBool(reader("Active"))
                    _teamList.Add(team)
                    team = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _teamList
    End Function
    '***CORRECT***
    Public Shared Function getTeamListByLeagueActive(ByRef leagueID As Integer, ByRef active As Integer, ByRef conn As SqlConnection)
        Dim _teamList As New List(Of Team)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetTeamListByLeagueActive"
            command.Parameters.AddWithValue("@LeagueID", leagueID)
            command.Parameters.AddWithValue("@Active", active)
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim team As Team
            If reader.HasRows Then
                Do While reader.Read
                    team = New Team
                    team.teamID = CInt(reader("TeamID"))
                    team.name = reader("Name").ToString
                    team.ownerID = CInt(reader("OwnerID"))
                    team.ownerFirst = reader("FirstName").ToString
                    team.ownerLast = reader("LastName").ToString
                    team.leagueID = CInt(reader("LeagueID"))
                    team.leagueName = reader("Name").ToString
                    team.active = CBool(reader("Active"))
                    _teamList.Add(team)
                    team = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _teamList
    End Function
    '***CORRECT***
    Public Shared Function deactivateTeamRecord(ByRef teamID As Integer, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spDeactivateTeam"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TeamID", teamID)
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
    Public Shared Function activateTeamRecord(ByRef teamID As Integer, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spActivateTeam"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TeamID", teamID)
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
    Public Shared Function addTeamRecord(ByRef team As Team, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spAddTeam"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Name", team.name)
            command.Parameters.AddWithValue("@OwnerID", team.ownerID)
            command.Parameters.AddWithValue("@LeagueID", team.leagueID)
            command.Parameters.AddWithValue("@Active", team.active)
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
    Public Shared Function editTeamRecord(ByRef oldTeam As Team, ByRef newTeam As Team, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spEditTeam"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Name", newTeam.name)
            command.Parameters.AddWithValue("@OwnerID", newTeam.ownerID)
            command.Parameters.AddWithValue("@LeagueID", newTeam.leagueID)
            command.Parameters.AddWithValue("@Active", newTeam.active)
            command.Parameters.AddWithValue("@OldName", oldTeam.name)
            command.Parameters.AddWithValue("@OldOwnerID", oldTeam.ownerID)
            command.Parameters.AddWithValue("@OldLeagueID", oldTeam.leagueID)
            command.Parameters.AddWithValue("@OldActive", oldTeam.active)
            command.Parameters.AddWithValue("@TeamID", oldTeam.teamID)
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
