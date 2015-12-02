Imports BLL
Imports DataObjects

Public Class frmAddLeague
    Private _owners As OwnerManager
    Private _leagues As LeagueManager
    Public _added As Boolean
    '***CORRECT***
    Public Sub New(ByRef leagueManager As LeagueManager, ByRef ownerManager As OwnerManager)
        ' This call is required by the designer.
        InitializeComponent()
        _leagues = leagueManager
        _owners = ownerManager
    End Sub
    '***CORRECT***
    Private Sub frmAddLeague_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        populateComboOwner()
        populateComboTeamLimit()
        populateComboActive()
    End Sub
    '***CORRECT***
    'Populates the owners combo box with owners with a role of league administrator.
    'Sets the default to "Please select an owner".
    Private Sub populateComboOwner()
        _owners.getAdminOwnerRowList()
        Me.comboOwner.Items.Add("Please select an owner")
        Dim currentOwner As Owner
        For i As Integer = 0 To _owners._ownerRowList.Count - 1
            currentOwner = _owners._ownerRowList(i)
            Me.comboOwner.Items.Add(currentOwner.firstName & " " & currentOwner.lastName)
        Next
        Me.comboOwner.SelectedIndex = 0
    End Sub
    '***CORRECT***
    'Populates the comboTeamLimit combo box with the maximum number of teams allowed for a league.
    'Sets the default value to 12.
    Private Sub populateComboTeamLimit()
        For i As Integer = 1 To 14
            Me.comboTeamLimit.Items.Add(i)
        Next
        Me.comboTeamLimit.SelectedIndex = 11
    End Sub
    '***CORRECT***
    'Populates the comboActive combo box.
    'Sets the default value to Yes.
    Private Sub populateComboActive()
        Dim active As Active
        For i As Integer = 1 To 0 Step -1
            active = i
            Me.comboActive.Items.Add(active)
        Next
        Me.comboActive.SelectedIndex = 0
    End Sub
    '***CORRECT***
    'Adds the League entry with the data entered by the user.
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtLeagueName.Text = "" Then
            MsgBox("You did not enter a valid league name.")
            txtLeagueName.Focus()
        ElseIf txtLeagueName.TextLength > 35 Then
            MsgBox("The league name can not exceed 35 characters.")
            txtLeagueName.Focus()
            txtLeagueName.SelectAll()
        ElseIf comboOwner.SelectedIndex = 0 Then
            MsgBox("You must select an owner.")
            comboOwner.Focus()
        Else
            Dim league As New League
            League.name = txtLeagueName.Text
            League.ownerID = _owners._ownerRowList(comboOwner.SelectedIndex - 1).ownerID
            League.ownerFirst = _owners._ownerRowList(comboOwner.SelectedIndex - 1).firstName
            League.ownerLast = _owners._ownerRowList(comboOwner.SelectedIndex - 1).lastName
            League.teamLimit = comboTeamLimit.SelectedItem
            League.active = comboActive.SelectedItem
            _leagues.addLeague(League)
            If _leagues._success = True Then
                Me.DialogResult = DialogResult.OK
                MsgBox("Your league has been created. The information pertaining to the league is listed below:" & vbCrLf & vbCrLf & "Name: " & League.name & vbCrLf & "Owner: " & League.ownerFirst & " " & League.ownerLast & vbCrLf & "Team Limit: " & League.teamLimit & vbCrLf & "Active: " & League.active)
                _added = True
            Else
                MsgBox("The league was not added.")
            End If
        End If
    End Sub
End Class