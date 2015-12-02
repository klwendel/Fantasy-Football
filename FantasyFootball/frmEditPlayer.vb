Imports BLL
Imports DataObjects

Public Class frmEditPlayer
    Private _teams As TeamManager
    Private _rosters As RosterManager
    Private _positions As PositionManager
    Private _currentIndex As Integer
    Public _changed As Boolean
    '***CORRECT***
    Public Sub New(ByRef teamManager As TeamManager, ByRef rosterManager As RosterManager, ByRef index As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        _teams = teamManager
        _rosters = rosterManager
        _currentIndex = index
    End Sub
    '***CORRECT***
    Private Sub frmEditPlayer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _positions = New PositionManager
        populateLblPlayerID()
        populateTxtFirst()
        populateTxtLast()
        populateComboTeam()
        populateComboPosition()
        populateComboActive()
    End Sub
    '***CORRECT***
    Private Sub populateLblPlayerID()
        Me.lblPlayerIDVal.Text = _rosters._rosterRowList(_currentIndex).playerID
    End Sub
    '***CORRECT***
    Private Sub populateTxtFirst()
        Me.txtFirstName.Text = _rosters._rosterRowList(_currentIndex).firstName
    End Sub
    '***CORRECT***
    Private Sub populateTxtLast()
        Me.txtLastName.Text = _rosters._rosterRowList(_currentIndex).lastName
    End Sub
    '***CORRECT***
    Private Sub populateComboTeam()
        _teams.getTeamRowListByActive(1)
        Dim index As Integer
        Dim currentTeam As Team
        For i As Integer = 0 To _teams._teamRowList.Count - 1
            currentTeam = _teams._teamRowList(i)
            Me.comboTeam.Items.Add(currentTeam.name)
            If currentTeam.teamID = _rosters._rosterRowList(_currentIndex).teamID Then
                index = i
            End If
        Next
        Me.comboTeam.SelectedIndex = index
    End Sub
    '***CORRECT***
    Private Sub populateComboPosition()
        _positions.getLeagueRowList()
        Dim index As Integer
        Dim currentPos As Position
        For i As Integer = 0 To _positions._positionRowList.Count - 1
            currentPos = _positions._positionRowList(i)
            Me.comboPosition.Items.Add(_positions._positionRowList(i).description)
            If currentPos.positionID = _rosters._rosterRowList(_currentIndex).positionID Then
                index = i
            End If
        Next
        Me.comboPosition.SelectedIndex = index
    End Sub
    '***CORRECT***
    Private Sub populateComboActive()
        Dim active As Active
        Dim index As Integer
        For i As Integer = 1 To 0 Step -1
            active = i
            Me.comboActive.Items.Add(active)
            If _teams._teamRowList(_currentIndex).active = True Then
                index = 0
            Else
                index = 1
            End If
        Next
        Me.comboActive.SelectedIndex = index
    End Sub
    '***CORRECT***
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
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
        Else
            Dim oldRoster As Roster = _rosters._rosterRowList(_currentIndex)
            Dim newRoster As New Roster
            newRoster.firstName = txtFirstName.Text
            newRoster.lastName = txtLastName.Text
            newRoster.teamID = _teams._teamRowList(comboTeam.SelectedIndex).teamID
            newRoster.team = _teams._teamRowList(comboTeam.SelectedIndex).name
            newRoster.positionID = _positions._positionRowList(comboPosition.SelectedIndex).positionID
            newRoster.position = _positions._positionRowList(comboPosition.SelectedIndex).description
            newRoster.active = comboActive.SelectedItem
            _rosters.editRoster(oldRoster, newRoster)
            If _rosters._success = True Then
                Me.DialogResult = DialogResult.OK
                MsgBox("The player has been updated.")
                _changed = True
            Else
                MsgBox("The player was not updated. Please try again.")
            End If
        End If
    End Sub
End Class