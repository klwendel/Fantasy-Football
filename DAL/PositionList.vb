Imports DataObjects
Imports System.Data.SqlClient

Public Class PositionList
    '***CORRECT***
    Public Shared Function getPositionList(ByRef conn As SqlConnection)
        Dim _positionList As New List(Of Position)
        Try
            conn.Open()
            Dim command As New SqlCommand()
            command.Connection = conn
            command.CommandText = "spGetPositionList"
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim position As Position
            If reader.HasRows Then
                Do While reader.Read
                    position = New Position
                    position.positionID = CInt(reader("PositionID"))
                    position.description = reader("Description").ToString
                    _positionList.Add(position)
                    position = Nothing
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        Return _positionList
    End Function
End Class
