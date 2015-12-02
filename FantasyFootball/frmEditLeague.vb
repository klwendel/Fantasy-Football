Imports BLL
Imports DataObjects

Public Class frmEditLeague
    Private _owners As OwnerManager
    Private _leagues As LeagueManager
    Private _currentIndex As Integer
    Public _changed As Boolean
    '***CORRECT***
    Public Sub New(ByRef leagueManager As LeagueManager, ByRef ownerManager As OwnerManager, ByRef index As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        _leagues = leagueManager
        _owners = ownerManager
        _currentIndex = index
    End Sub
    '***CORRECT***
    'Populates the controls with the current values of the selected league in addition to populating the remainder of the values for the combo boxes.
    Private Sub frmEditLeague_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        populateLblID()
        populateLblDate()
        populateLblName()
        populateComboOwner()
        populateComboTeamLimit()
        populateComboActive()
        Me.Text = "League: " & _leagues._leagueRowList(_currentIndex).name
    End Sub
    '***CORRECT***
    'Sets the league ID text box with the current leagues value.
    Private Sub populateLblID()
        Me.lblLeagueIDVal.Text = _leagues._leagueRowList(_currentIndex).leagueID
    End Sub
    '***CORRECT***
    'Sets the date created text box with the current leagues value.
    Private Sub populateLblDate()
        Me.lblDateCreatedVal.Text = _leagues._leagueRowList(_currentIndex).creationDate
    End Sub
    '***CORRECT***
    'Sets the league name text box with the current leagues value.
    Private Sub populateLblName()
        Me.txtLeagueName.Text = _leagues._leagueRowList(_currentIndex).name
    End Sub
    '***CORRECT***
    'Populates the owners combo box with owners with a role of league administrator.
    'Sets the current value to the selected leagues current owner value.
    Private Sub populateComboOwner()
        _owners.getAdminOwnerRowList()
        Dim currentOwner As Owner
        Dim index As Integer
        For i As Integer = 0 To _owners._ownerRowList.Count - 1
            currentOwner = _owners._ownerRowList(i)
            Me.comboOwner.Items.Add(currentOwner.firstName & " " & currentOwner.lastName)
            If currentOwner.ownerID = _leagues._leagueRowList(_currentIndex).ownerID Then
                index = i
            End If
        Next
        Me.comboOwner.SelectedIndex = index
    End Sub
    '***CORRECT***
    'Populates the comboTeamLimit combo box with the maximum number of teams allowed.
    'Sets the current value to the selected leagues current team limit value.
    Private Sub populateComboTeamLimit()
        Dim index As Integer
        For i As Integer = 1 To 14
            Me.comboTeamLimit.Items.Add(i)
            If i = _leagues._leagueRowList(_currentIndex).teamLimit Then
                index = i - 1
            End If
        Next
        Me.comboTeamLimit.SelectedIndex = index
    End Sub
    '***CORRECT***
    'Populates the comboActive combo box.
    'Sets the current value to the selected leagues current active value.
    Private Sub populateComboActive()
        Dim active As Active
        Dim index As Integer
        For i As Integer = 1 To 0 Step -1
            active = i
            Me.comboActive.Items.Add(active)
            If _leagues._leagueRowList(_currentIndex).active = True Then
                index = 0
            Else
                index = 1
            End If
        Next
        Me.comboActive.SelectedIndex = index
    End Sub
    '***CORRECT***
    'Accepts changes made by the user for the current league.
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtLeagueName.Text = "" Then
            MsgBox("You did not enter a valid league name.")
            txtLeagueName.Focus()
        ElseIf txtLeagueName.TextLength > 35 Then
            MsgBox("The league name can not exceed 35 characters.")
            txtLeagueName.Focus()
            txtLeagueName.SelectAll()
        Else
            Dim oldLeague As League = _leagues._leagueRowList(_currentIndex)
            Dim newLeague As New League
            newLeague.name = txtLeagueName.Text
            newLeague.ownerID = _owners._ownerRowList(comboOwner.SelectedIndex).ownerID
            newLeague.ownerFirst = _owners._ownerRowList(comboOwner.SelectedIndex).firstName
            newLeague.ownerLast = _owners._ownerRowList(comboOwner.SelectedIndex).lastName
            newLeague.teamLimit = comboTeamLimit.SelectedItem
            newLeague.active = comboActive.SelectedItem
            _leagues.editLeague(oldLeague, newLeague)
            If _leagues._success = True Then
                Me.DialogResult = DialogResult.OK
                MsgBox("The league has been updated.")
                _changed = True
            Else
                MsgBox("The league was not updated. Please try again.")
            End If
        End If
    End Sub
End Class