Imports DataObjects
Imports System.Data.SqlClient

Public Class RosterList
    '***CORRECT***
    Public Shared Function getRosterList(ByRef conn As SqlConnection)
        Dim _RosterList As New List(Of Roster)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetRosterList"
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim roster As Roster
            If reader.HasRows Then
                Do While reader.Read
                    roster = New Roster
                    roster.playerID = CInt(reader("PlayerID"))
                    roster.firstName = reader("FirstName").ToString
                    roster.lastName = reader("LastName").ToString
                    roster.positionID = CInt(reader("Position"))
                    roster.position = reader("Description").ToString
                    roster.teamID = CInt(reader("TeamID"))
                    roster.team = reader("Name").ToString
                    roster.active = reader("Active").ToString
                    _RosterList.Add(roster)
                    roster = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _RosterList
    End Function
    '***CORRECT***
    Public Shared Function getRosterListByTeam(ByRef teamID As Integer, ByRef conn As SqlConnection)
        Dim _RosterList As New List(Of Roster)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetRosterListByTeam"
            command.Parameters.AddWithValue("@TeamID", teamID)
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim roster As Roster
            If reader.HasRows Then
                Do While reader.Read
                    roster = New Roster
                    roster.playerID = CInt(reader("PlayerID"))
                    roster.firstName = reader("FirstName").ToString
                    roster.lastName = reader("LastName").ToString
                    roster.positionID = CInt(reader("Position"))
                    roster.position = reader("Description").ToString
                    roster.teamID = CInt(reader("TeamID"))
                    roster.team = reader("Name").ToString
                    roster.active = reader("Active").ToString
                    _RosterList.Add(roster)
                    roster = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _RosterList
    End Function
    '***CORRECT***
    Public Shared Function getRosterListByTeamActive(ByRef teamID As Integer, ByRef active As Integer, ByRef conn As SqlConnection)
        Dim _RosterList As New List(Of Roster)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetRosterListByTeamActive"
            command.Parameters.AddWithValue("@TeamID", teamID)
            command.Parameters.AddWithValue("@Active", active)
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim roster As Roster
            If reader.HasRows Then
                Do While reader.Read
                    roster = New Roster
                    roster.playerID = CInt(reader("PlayerID"))
                    roster.firstName = reader("FirstName").ToString
                    roster.lastName = reader("LastName").ToString
                    roster.positionID = CInt(reader("Position"))
                    roster.position = reader("Description").ToString
                    roster.teamID = CInt(reader("TeamID"))
                    roster.team = reader("Name").ToString
                    roster.active = reader("Active").ToString
                    _RosterList.Add(roster)
                    roster = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _RosterList
    End Function
    '***CORRECT***
    Public Shared Function deactivateRosterRecord(ByRef playerID As Integer, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spDeactivatePlayer"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@playerID", playerID)
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
    Public Shared Function activateRosterRecord(ByRef playerID As Integer, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spActivatePlayer"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@playerID", playerID)
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
    Public Shared Function addRosterRecord(ByRef roster As Roster, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spAddPlayer"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@FirstName", roster.firstName)
            command.Parameters.AddWithValue("@lastName", roster.lastName)
            command.Parameters.AddWithValue("@Position", roster.positionID)
            command.Parameters.AddWithValue("@TeamID", roster.teamID)
            command.Parameters.AddWithValue("@Active", roster.active)
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
    Public Shared Function editRosterRecord(ByRef oldRoster As Roster, ByRef newRoster As Roster, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spEditPlayer"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@FirstName", newRoster.firstName)
            command.Parameters.AddWithValue("@lastName", newRoster.lastName)
            command.Parameters.AddWithValue("@Position", newRoster.positionID)
            command.Parameters.AddWithValue("@TeamID", newRoster.teamID)
            command.Parameters.AddWithValue("@Active", newRoster.active)
            command.Parameters.AddWithValue("@OldFirstName", oldRoster.firstName)
            command.Parameters.AddWithValue("@OldlastName", oldRoster.lastName)
            command.Parameters.AddWithValue("@OldPosition", oldRoster.positionID)
            command.Parameters.AddWithValue("@OldTeamID", oldRoster.teamID)
            command.Parameters.AddWithValue("@OldActive", oldRoster.active)
            command.Parameters.AddWithValue("@PlayerID", oldRoster.playerID)
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
