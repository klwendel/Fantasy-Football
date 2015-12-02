Imports BLL
Imports DataObjects

Public Class frmAddPlayer
    Private _teams As TeamManager
    Private _rosters As RosterManager
    Private _positions As PositionManager
    Public _added As Boolean
    '***CORRECT***
    Public Sub New(ByRef teamManager As TeamManager, ByRef rosterManager As RosterManager)
        ' This call is required by the designer.
        InitializeComponent()
        _teams = teamManager
        _rosters = rosterManager
    End Sub
    '***CORRECT***
    Private Sub frmAddPlayer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _positions = New PositionManager
        populateComboTeam()
        populateComboPosition()
        populateComboActive()
    End Sub
    '***CORRECT***
    Private Sub populateComboTeam()
        _teams.getTeamRowListByActive(1)
        Me.comboTeam.Items.Add("Select a team")
        Dim currentTeam As Team
        For i As Integer = 0 To _teams._teamRowList.Count - 1
            currentTeam = _teams._teamRowList(i)
            Me.comboTeam.Items.Add(currentTeam.name)
        Next
        Me.comboTeam.SelectedIndex = 0
    End Sub
    '***CORRECT***
    Private Sub populateComboPosition()
        _positions.getLeagueRowList()
        Me.comboPosition.Items.Add("Select a position")
        Dim currentPos As Position
        For i As Integer = 0 To _positions._positionRowList.Count - 1
            currentPos = _positions._positionRowList(i)
            Me.comboPosition.Items.Add(_positions._positionRowList(i).description)
        Next
        Me.comboPosition.SelectedIndex = 0
    End Sub
    '***CORRECT***
    Private Sub populateComboActive()
        Dim active As Active
        For i As Integer = 1 To 0 Step -1
            active = i
            Me.comboActive.Items.Add(active)
        Next
        Me.comboActive.SelectedIndex = 0
    End Sub
    '***CORRECT***
    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtFirstName.Text = "" Then
            MsgBox("You did not enter a valid first name.")
            txtFirstName.Focus()
        ElseIf txtFirstName.TextLength > 35 Then
            MsgBox("The first name can not exceed 35 characters.")
            txtFirstName.Focus()
            txtFirstName.SelectAll()
        ElseIf txtLastName.Text = "" Then
            MsgBox("You did not enter a valid last name.")
            txtLastName.Focus()
        ElseIf txtLastName.TextLength > 35 Then
            MsgBox("The last name can not exceed 35 characters.")
            txtLastName.Focus()
            txtLastName.SelectAll()
        ElseIf comboTeam.SelectedIndex = 0 Then
            MsgBox("You must select a team.")
            comboTeam.Focus()
        ElseIf comboPosition.SelectedIndex = 0 Then
            MsgBox("You must select a position.")
            comboPosition.Focus()
        Else
            Dim roster As New Roster
            roster.firstName = txtFirstName.Text
            roster.lastName = txtLastName.Text
            roster.teamID = _teams._teamRowList(comboTeam.SelectedIndex - 1).teamID
            roster.team = _teams._teamRowList(comboTeam.SelectedIndex - 1).name
            roster.positionID = _positions._positionRowList(comboPosition.SelectedIndex - 1).positionID
            roster.position = _positions._positionRowList(comboPosition.SelectedIndex - 1).description
            roster.active = comboActive.SelectedItem
            _rosters.addRoster(roster)
            If _rosters._success = True Then
                Me.DialogResult = DialogResult.OK
                MsgBox("The player has been added to the roster. The player's information is below. " & vbCrLf & vbCrLf & "Name: " & roster.firstName & " " & roster.lastName & vbCrLf & "Team: " & roster.team & vbCrLf & "Position: " & roster.position & vbCrLf & "Active: " & roster.active)
                _added = True
            Else
                MsgBox("The player was not created. Please try again.")
            End If
        End If
    End Sub
End Class