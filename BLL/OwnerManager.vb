Imports DataObjects
Imports DAL
Imports System.Data.SqlClient

Public Class OwnerManager
    Public _ownerRowList As List(Of Owner)
    Public _success As Boolean
    '***CORRECT***
    Public Sub getOwnerRowList(ByRef active As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        If active > 1 Then
            _ownerRowList = OwnerList.getOwnerList(conn)
        Else
            _ownerRowList = OwnerList.getOwnerListByActive(active, conn)
        End If
    End Sub
    '***CORRECT***
    Public Sub getAdminOwnerRowList()
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _ownerRowList = OwnerList.getAdminOwnerList(conn)
    End Sub
    '***CORRECT***
    Public Sub deactivateOwner(ByRef ownerID As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = OwnerList.deactivateOwnerRecord(ownerID, conn)
    End Sub
    '***CORRECT***
    Public Sub activateOwner(ByRef ownerID As Integer)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = OwnerList.activateOwnerRecord(ownerID, conn)
    End Sub
    '***CORRECT***
    Public Sub addOwner(ByRef owner As Owner)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = OwnerList.addOwnerRecord(owner, conn)
    End Sub
    '***CORRECT***
    Public Sub editOwner(ByRef oldOwner As Owner, ByRef newOwner As Owner)
        Dim conn As SqlConnection = DatabaseConnections.GetFantasyFootballConn()
        _success = OwnerList.editOwnerRecord(oldOwner, newOwner, conn)
    End Sub
End Class