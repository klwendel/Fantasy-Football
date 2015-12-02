Imports BLL
Imports DataObjects

Public Class frmAddTeam
    Private _owners As OwnerManager
    Private _leagues As LeagueManager
    Private _teams As TeamManager
    Public _added As Boolean
    '***CORRECT***
    Public Sub New(ByRef leagueManager As LeagueManager, ByRef ownerManager As OwnerManager, ByRef teamManager As TeamManager)
        ' This call is required by the designer.
        InitializeComponent()
        _leagues = leagueManager
        _owners = ownerManager
        _teams = teamManager
    End Sub
    '***CORRECT***
    Private Sub frmAddTeam_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        populateComboOwner()
        populateComboLeague()
        populateComboActive()
    End Sub
    '***CORRECT***
    Private Sub populateComboOwner()
        _owners.getOwnerRowList(1)
        Me.comboOwner.Items.Add("Select an owner")
        Dim currentOwner As Owner
        For i As Integer = 0 To _owners._ownerRowList.Count - 1
            currentOwner = _owners._ownerRowList(i)
            Me.comboOwner.Items.Add(currentOwner.firstName & " " & currentOwner.lastName)
        Next
        Me.comboOwner.SelectedIndex = 0
    End Sub
    '***CORRECT***
    Private Sub populateComboLeague()
        _leagues.getLeagueRowList(1)
        Me.comboLeague.Items.Add("Select a league")
        Dim currentLeague As League
        For i As Integer = 0 To _leagues._leagueRowList.Count - 1
            currentLeague = _leagues._leagueRowList(i)
            Me.comboLeague.Items.Add(currentLeague.name)
        Next
        Me.comboLeague.SelectedIndex = 0
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
        If txtTeamName.Text = "" Then
            MsgBox("You did not enter a valid league name.")
            txtTeamName.Focus()
        ElseIf txtTeamName.TextLength > 35 Then
            MsgBox("The league name can not exceed 35 characters.")
            txtTeamName.Focus()
            txtTeamName.SelectAll()
        ElseIf comboOwner.SelectedIndex = 0 Then
            MsgBox("You must select an owner.")
            comboOwner.Focus()
        ElseIf comboLeague.SelectedIndex = 0 Then
            MsgBox("You must select a league.")
            comboOwner.Focus()
        Else
            Dim team As New Team
            team.name = txtTeamName.Text
            team.ownerID = _owners._ownerRowList(comboOwner.SelectedIndex - 1).ownerID
            team.ownerFirst = _owners._ownerRowList(comboOwner.SelectedIndex - 1).firstName
            team.ownerLast = _owners._ownerRowList(comboOwner.SelectedIndex - 1).lastName
            team.leagueID = _leagues._leagueRowList(comboLeague.SelectedIndex - 1).leagueID
            team.leagueName = _leagues._leagueRowList(comboLeague.SelectedIndex - 1).name
            team.active = comboActive.SelectedItem
            _teams.addTeam(team)
            If _teams._success = True Then
                Me.DialogResult = DialogResult.OK
                MsgBox("Your team has been created. The information pertaining to the team is listed below:" & vbCrLf & vbCrLf & "Name: " & team.name & vbCrLf & "Owner: " & team.ownerFirst & " " & team.ownerLast & vbCrLf & "League: " & team.leagueName & vbCrLf & "Active: " & team.active)
                _added = True
            Else
                MsgBox("The team was not added.")
            End If
        End If
    End Sub
End Class