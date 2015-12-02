Imports DataObjects
Imports System.Data.SqlClient

Public Class RoleList
    '***CORRECT***
    Public Shared Function getRoleList(ByRef conn As SqlConnection)
        Dim _roleList As New List(Of Role)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetRoleList"
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim role As Role
            If reader.HasRows Then
                Do While reader.Read
                    role = New Role
                    role.roleID = CInt(reader("RoleID"))
                    role.description = reader("Description").ToString
                    _roleList.Add(role)
                    role = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _roleList
    End Function
End Class
