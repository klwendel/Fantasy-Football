Imports BLL
Imports DataObjects

Public Class frmEditTeam
    Private _owners As OwnerManager
    Private _leagues As LeagueManager
    Private _teams As TeamManager
    Public _changed As Boolean
    Private _currentIndex As Integer
    '***CORRECT***
    Public Sub New(ByRef leagueManager As LeagueManager, ByRef ownerManager As OwnerManager, ByRef teamManager As TeamManager, ByRef index As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        _leagues = leagueManager
        _owners = ownerManager
        _teams = teamManager
        _currentIndex = index
        Me.Text = "Team: " & _teams._teamRowList(_currentIndex).name
    End Sub
    '***CORRECT***
    Private Sub frmEditTeam_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        populateLblID()
        populateTxtName()
        populateComboOwner()
        populateComboLeague()
        populateComboActive()
    End Sub
    '***CORRECT***
    Private Sub populateLblID()
        Me.lblTeamIDVal.Text = _teams._teamRowList(_currentIndex).teamID
    End Sub
    '***CORRECT***
    Private Sub populateTxtName()
        Me.txtTeamName.Text = _teams._teamRowList(_currentIndex).name
    End Sub
    '***CORRECT***
    Private Sub populateComboOwner()
        _owners.getOwnerRowList(2)
        Dim currentOwner As Owner
        Dim index As Integer
        For i As Integer = 0 To _owners._ownerRowList.Count - 1
            currentOwner = _owners._ownerRowList(i)
            Me.comboOwner.Items.Add(currentOwner.firstName & " " & currentOwner.lastName)
            If currentOwner.ownerID = _teams._teamRowList(_currentIndex).ownerID Then
                index = i
            End If
        Next
        Me.comboOwner.SelectedIndex = index
    End Sub
    '***CORRECT***
    Private Sub populateComboLeague()
        _leagues.getLeagueRowList(2)
        Dim currentLeague As League
        Dim index As Integer
        For i As Integer = 0 To _leagues._leagueRowList.Count - 1
            currentLeague = _leagues._leagueRowList(i)
            Me.comboLeague.Items.Add(currentLeague.name)
            If currentLeague.leagueID = _teams._teamRowList(_currentIndex).leagueID Then
                index = i
            End If
        Next
        Me.comboLeague.SelectedIndex = index
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
        If txtTeamName.Text = "" Then
            MsgBox("You did not enter a valid league name.")
            txtTeamName.Focus()
        ElseIf txtTeamName.TextLength > 35 Then
            MsgBox("The league name can not exceed 35 characters.")
            txtTeamName.Focus()
            txtTeamName.SelectAll()
        Else
            Dim oldTeam As Team = _teams._teamRowList(_currentIndex)
            Dim newTeam As New Team
            newTeam.name = txtTeamName.Text
            newTeam.ownerID = _owners._ownerRowList(comboOwner.SelectedIndex).ownerID
            newTeam.ownerFirst = _owners._ownerRowList(comboOwner.SelectedIndex).firstName
            newTeam.ownerLast = _owners._ownerRowList(comboOwner.SelectedIndex).lastName
            newTeam.leagueID = _leagues._leagueRowList(comboLeague.SelectedIndex).leagueID
            newTeam.leagueName = _leagues._leagueRowList(comboLeague.SelectedIndex).name
            newTeam.active = comboActive.SelectedItem
            _teams.editTeam(oldTeam, newTeam)
            If _teams._success = True Then
                Me.DialogResult = DialogResult.OK
                MsgBox("The team has been updated.")
                _changed = True
            Else
                MsgBox("The team was not updated. Please try again.")
            End If
        End If
    End Sub
End Class