Imports DataObjects
Imports System.Data.SqlClient

Public Class OwnerList
    '***CORRECT***
    Public Shared Function getOwnerList(ByRef conn As SqlConnection)
        Dim _ownerList As New List(Of Owner)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetOwnerList"
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim owner As Owner
            If reader.HasRows Then
                Do While reader.Read
                    owner = New Owner
                    owner.ownerID = CInt(reader("OwnerID"))
                    owner.firstName = reader("FirstName").ToString
                    owner.lastName = reader("LastName").ToString
                    owner.roleID = CInt(reader("RoleID"))
                    owner.roleDescription = reader("Description").ToString
                    owner.active = CBool(reader("Active"))
                    _ownerList.Add(owner)
                    owner = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _ownerList
    End Function
    '***CORRECT***
    Public Shared Function getOwnerListByActive(ByRef active As Integer, ByRef conn As SqlConnection)
        Dim _ownerList As New List(Of Owner)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetOwnerListByActive"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Active", active)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim owner As Owner
            If reader.HasRows Then
                Do While reader.Read
                    owner = New Owner
                    owner.ownerID = CInt(reader("OwnerID"))
                    owner.firstName = reader("FirstName").ToString
                    owner.lastName = reader("LastName").ToString
                    owner.roleID = CInt(reader("RoleID"))
                    owner.roleDescription = reader("Description").ToString
                    owner.active = CBool(reader("Active"))
                    _ownerList.Add(owner)
                    owner = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _ownerList
    End Function
    '***CORRECT***
    Public Shared Function getAdminOwnerList(ByRef conn As SqlConnection)
        Dim _ownerList As New List(Of Owner)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetAdminOwnerList"
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim owner As Owner
            If reader.HasRows Then
                Do While reader.Read
                    owner = New Owner
                    owner.ownerID = CInt(reader("OwnerID"))
                    owner.firstName = reader("FirstName").ToString
                    owner.lastName = reader("LastName").ToString
                    owner.roleID = CInt(reader("RoleID"))
                    owner.roleDescription = reader("Description").ToString
                    owner.active = CBool(reader("Active"))
                    _ownerList.Add(owner)
                    owner = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _ownerList
    End Function
    '***CORRECT***
    Public Shared Function deactivateOwnerRecord(ByRef ownerID As Integer, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spDeactivateOwner"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@OwnerID", ownerID)
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
    Public Shared Function activateOwnerRecord(ByRef ownerID As Integer, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spActivateOwner"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@OwnerID", ownerID)
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
    Public Shared Function addOwnerRecord(ByRef owner As Owner, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spAddOwner"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@FirstName", owner.firstName)
            command.Parameters.AddWithValue("@LastName", owner.lastName)
            command.Parameters.AddWithValue("@RoleID", owner.roleID)
            command.Parameters.AddWithValue("@Active", owner.active)
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
    Public Shared Function editOwnerRecord(ByRef oldOwner As Owner, ByRef newOwner As Owner, ByRef conn As SqlConnection) As Boolean
        Dim success As Boolean = False
        Dim rowcount As Integer
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spEditOwner"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@FirstName", newOwner.firstName)
            command.Parameters.AddWithValue("@LastName", newOwner.lastName)
            command.Parameters.AddWithValue("@RoleID", newOwner.roleID)
            command.Parameters.AddWithValue("@Active", newOwner.active)
            command.Parameters.AddWithValue("@OldFirstName", oldOwner.firstName)
            command.Parameters.AddWithValue("@OldLastName", oldOwner.lastName)
            command.Parameters.AddWithValue("@OldRoleID", oldOwner.roleID)
            command.Parameters.AddWithValue("@OldActive", oldOwner.active)
            command.Parameters.AddWithValue("@OwnerID", oldOwner.ownerID)
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