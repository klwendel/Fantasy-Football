Imports BLL
Imports DataObjects

Public Enum Active
    No = 0
    Yes = 1
End Enum
Public Class frmActions
    Private _owners As OwnerManager
    Private _leagues As LeagueManager
    Private _teams As TeamManager
    Private _rosters As RosterManager
    '***CORRECT***
    Private Sub frmActions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _leagues = New LeagueManager
        _teams = New TeamManager
        _owners = New OwnerManager
        _rosters = New RosterManager
        populateComboLeagueActive()
        populateLeagueListView(lvLeagues)
    End Sub
    '***CORRECT***
    'Clears the list views once the user selects a different tab. Also populates the appropriate drop down lists with the current values from the database.
    Private Sub tabsFFM_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabsFFM.SelectedIndexChanged
        lvLeagues.Clear()
        disableLeagueControls()
        comboLeagueActive.Items.Clear()
        lvOwners.Clear()
        disableOwnerControls()
        comboOwnerActive.Items.Clear()
        lvTeams.Clear()
        lvRosters.Clear()
        comboLeagueSelection.Items.Clear()
        comboTeamSelection.Items.Clear()
        Dim currentTab As Integer = tabsFFM.SelectedIndex
        Select Case currentTab
            Case 0
                populateComboLeagueActive()
            Case 1
                populateComboLeagueSelection()
            Case 2
                populateComboTeamSelection()
            Case 3
                populateComboOwnerActive()
        End Select
    End Sub
    '***CORRECT***
    Private Sub comboLeagueActive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboLeagueActive.Click
        disableLeagueControls()
    End Sub
    '***CORRECT***
    'Enables/disables the activate/deactivate/edit buttons based off of the active status of the currently selected league.
    Private Sub lvLeagues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLeagues.Click
        Dim currentIndex As Integer = lvLeagues.SelectedItems(0).Index
        If _leagues._leagueRowList(currentIndex).active = True Then
            btnDeactivateLeague.Enabled = True
            btnActivateLeague.Enabled = False
        Else
            btnActivateLeague.Enabled = True
            btnDeactivateLeague.Enabled = False
        End If
        btnEditLeague.Enabled = True
    End Sub
    '***CORRECT***
    'Disables the appropriate controls on the leagues tab to prevent them from being enabled when they should not be.
    Private Sub disableLeagueControls()
        btnActivateLeague.Enabled = False
        btnDeactivateLeague.Enabled = False
        btnEditLeague.Enabled = False
    End Sub
    '***CORRECT***
    'Event to populate the league list view.
    Private Sub comboLeagueActive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboLeagueActive.SelectedIndexChanged
        populateLeagueListView(lvLeagues)
    End Sub
    '***CORRECT***
    'Populates the combo leage active drop down.
    Private Sub populateComboLeagueActive()
        Dim active As Active
        For i As Integer = 1 To 0 Step -1
            active = i
            Me.comboLeagueActive.Items.Add(active)
        Next
        Me.comboLeagueActive.Items.Add("Both")
        Me.comboLeagueActive.SelectedIndex = 0
    End Sub
    '***CORRECT***
    'Populates the league list view with data from the database.
    Private Sub populateLeagueListView(ByRef lv As ListView)
        Dim active As Integer
        Select Case comboLeagueActive.SelectedIndex
            Case 0
                active = 1
            Case 1
                active = 0
            Case 2
                active = 2
        End Select
        lv.Clear()
        _leagues.getLeagueRowList(active)
        Dim currentLeague As League
        For i As Integer = 0 To _leagues._leagueRowList.Count - 1
            currentLeague = _leagues._leagueRowList(i)
            lv.Items.Add(currentLeague.leagueID)
            lv.Items(i).SubItems.Add(currentLeague.name)
            lv.Items(i).SubItems.Add(currentLeague.ownerFirst & " " & currentLeague.ownerLast)
            lv.Items(i).SubItems.Add(currentLeague.teamLimit)
            lv.Items(i).SubItems.Add(currentLeague.creationDate.ToString("MM/dd/yyyy"))
            lv.Items(i).SubItems.Add(IIf(currentLeague.active = True, "Yes", "No"))
            currentLeague = Nothing
        Next
        lv.Columns.Add("League ID")
        lv.Columns.Add("League Name")
        lv.Columns.Add("League Administrator")
        lv.Columns.Add("Team Limit")
        lv.Columns.Add("Creation Date")
        lv.Columns.Add("Active")
        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    '***CORRECT***
    'Creates the form to add a league entry.
    Private Sub btnAddLeague_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLeague.Click
        Dim addLeague As New frmAddLeague(_leagues, _owners)
        Dim add As DialogResult = addLeague.ShowDialog
        If addLeague._added = True Then
            populateLeagueListView(lvLeagues)
        End If
        disableLeagueControls()
    End Sub
    '***CORRECT***
    'Event to create the edit form for leagues.
    Private Sub btnEditLeague_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditLeague.Click
        Dim currentIndex As Integer = lvLeagues.SelectedItems(0).Index
        Dim editLeague As New frmEditLeague(_leagues, _owners, currentIndex)
        Dim edit As DialogResult = editLeague.ShowDialog
        If editLeague._changed = True Then
            populateLeagueListView(lvLeagues)
        End If
        disableLeagueControls()
    End Sub
    '***CORRECT***
    'Event to change the league status to inactive.
    Private Sub btnDeactivateLeague_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeactivateLeague.Click
        Dim currentIndex As Integer = lvLeagues.SelectedItems(0).Index
        _leagues.deactivateLeague(_leagues._leagueRowList(currentIndex).leagueID)
        If _leagues._success = True Then
            MsgBox("'" & _leagues._leagueRowList(currentIndex).name & "' is now an inactive league.")
            Me.DialogResult = DialogResult.OK
        End If
        disableLeagueControls()
        populateLeagueListView(lvLeagues)
    End Sub
    '***CORRECT***
    'Event to change the league status to active.
    Private Sub btnActivateLeague_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivateLeague.Click
        Dim currentIndex As Integer = lvLeagues.SelectedItems(0).Index
        _leagues.activateLeague(_leagues._leagueRowList(currentIndex).leagueID)
        If _leagues._success = True Then
            MsgBox("'" & _leagues._leagueRowList(currentIndex).name & "' is now an active league.")
            Me.DialogResult = DialogResult.OK
        End If
        disableLeagueControls()
        populateLeagueListView(lvLeagues)
    End Sub


    '***CORRECT***
    Private Sub comboOwnerActive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboOwnerActive.Click
        disableOwnerControls()
    End Sub
    '***CORRECT***
    'Disables the appropriate controls on the owners tab to prevent them from being enabled when they should not be.
    Private Sub disableOwnerControls()
        btnActivateOwner.Enabled = False
        btnDeactivateOwner.Enabled = False
        btnEditOwner.Enabled = False
    End Sub
    '***CORRECT***
    'Event to populate the owner list view.
    Private Sub comboOwnerActive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboOwnerActive.SelectedIndexChanged
        populateOwnerListView(lvOwners)
    End Sub
    '***CORRECT***
    'Populates the combo leage active drop down.
    Private Sub populateComboOwnerActive()
        Dim active As Active
        For i As Integer = 1 To 0 Step -1
            active = i
            Me.comboOwnerActive.Items.Add(active)
        Next
        Me.comboOwnerActive.Items.Add("Both")
        Me.comboOwnerActive.SelectedIndex = 0
    End Sub
    '***CORRECT***
    'Populates the owner list view with data from the database.
    Private Sub populateOwnerListView(ByRef lv As ListView)
        Dim active As Integer
        Select Case comboOwnerActive.SelectedIndex
            Case 0
                active = 1
            Case 1
                active = 0
            Case 2
                active = 2
        End Select
        lv.Clear()
        _owners.getOwnerRowList(active)
        Dim currentOwner As Owner
        For i As Integer = 0 To _owners._ownerRowList.Count - 1
            currentOwner = _owners._ownerRowList(i)
            lv.Items.Add(currentOwner.ownerID)
            lv.Items(i).SubItems.Add(currentOwner.firstName)
            lv.Items(i).SubItems.Add(currentOwner.lastName)
            lv.Items(i).SubItems.Add(currentOwner.roleDescription)
            lv.Items(i).SubItems.Add(IIf(currentOwner.active = True, "Yes", "No"))
            currentOwner = Nothing
        Next
        lv.Columns.Add("Owner ID")
        lv.Columns.Add("First Name")
        lv.Columns.Add("Last Name")
        lv.Columns.Add("Role Description")
        lv.Columns.Add("Active")
        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    '***CORRECT***
    'Event to change the owner status to inactive.
    Private Sub btnDeactivateOwner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeactivateOwner.Click
        Dim currentIndex As Integer = lvOwners.SelectedItems(0).Index
        _owners.deactivateOwner(_owners._ownerRowList(currentIndex).ownerID)
        If _owners._success = True Then
            MsgBox("'" & _owners._ownerRowList(currentIndex).firstName & " " & _owners._ownerRowList(currentIndex).lastName & "' is now an inactive owner.")
            Me.DialogResult = DialogResult.OK
        End If
        disableOwnerControls()
        populateOwnerListView(lvOwners)
    End Sub
    '***CORRECT***
    'Event to change the owner status to active.
    Private Sub btnActivateOwner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivateOwner.Click
        Dim currentIndex As Integer = lvOwners.SelectedItems(0).Index
        _owners.activateOwner(_owners._ownerRowList(currentIndex).ownerID)
        If _owners._success = True Then
            MsgBox("'" & _owners._ownerRowList(currentIndex).firstName & " " & _owners._ownerRowList(currentIndex).lastName & "' is now an active owner.")
            Me.DialogResult = DialogResult.OK
        End If
        disableOwnerControls()
        populateOwnerListView(lvOwners)
    End Sub
    '***CORRECT***
    'Enables/disables the activate/deactivate/edit buttons based off of the active status of the currently selected owner.
    Private Sub lvOwners_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvOwners.Click
        Dim currentIndex As Integer = lvOwners.SelectedItems(0).Index
        If _owners._ownerRowList(currentIndex).active = True Then
            btnDeactivateOwner.Enabled = True
            btnActivateOwner.Enabled = False
        Else
            btnActivateOwner.Enabled = True
            btnDeactivateOwner.Enabled = False
        End If
        btnEditOwner.Enabled = True
    End Sub
    '***CORRECT***
    Private Sub btnAddOwner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOwner.Click
        Dim addOwner As New frmAddOwner(_owners)
        Dim add As DialogResult = addOwner.ShowDialog
        If addOwner._added = True Then
            populateOwnerListView(lvOwners)
        End If
        disableOwnerControls()
    End Sub
    '***CORRECT***
    Private Sub btnEditOwner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditOwner.Click
        Dim currentIndex As Integer = lvOwners.SelectedItems(0).Index
        Dim editOwner As New frmEditOwner(_owners, currentIndex)
        Dim edit As DialogResult = editOwner.ShowDialog
        If editOwner._changed = True Then
            populateOwnerListView(lvOwners)
        End If
        disableOwnerControls()
    End Sub
    '***CORRECT***
    'Populates the combo leage selection drop down.
    Private Sub populateComboLeagueSelection()
        Me.comboLeagueSelection.Items.Clear()
        _leagues.getLeagueRowList(2)
        Me.comboLeagueSelection.Items.Add("Select a league")
        Dim currentLeague As League
        For i As Integer = 0 To _leagues._leagueRowList.Count - 1
            currentLeague = _leagues._leagueRowList(i)
            Me.comboLeagueSelection.Items.Add(currentLeague.name)
        Next
        Me.comboLeagueSelection.SelectedIndex = 0
    End Sub
    '***CORRECT***
    Private Sub comboLeagueSelection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboLeagueSelection.Click
        disableTeamControls()
    End Sub
    '***CORRECT***
    Private Sub checkTeamInactive_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkTeamInactive.CheckedChanged
        populateTeamListView(lvTeams)
        disableTeamControls()
    End Sub
    '***CORRECT***
    'Disables the appropriate controls on the teams tab to prevent them from being enabled when they should not be.
    Private Sub disableTeamControls()
        btnActivateTeam.Enabled = False
        btnDeactivateTeam.Enabled = False
        btnEditTeam.Enabled = False
    End Sub
    '***CORRECT***
    'Event to populate the team list view after the user selects a league from the league combo box.
    Private Sub comboLeagueSelection_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboLeagueSelection.SelectedIndexChanged
        populateTeamListView(lvTeams)
    End Sub
    '***CORRECT***
    'Populates the team list view with data from the database.
    Private Sub populateTeamListView(ByRef lv As ListView)
        lv.Clear()
        _leagues.getLeagueRowList(2)
        Dim currentIndex = comboLeagueSelection.SelectedIndex()
        If currentIndex > 0 Then
            If checkTeamInactive.Checked = True Then
                _teams.getTeamRowListByLeague(_leagues._leagueRowList(currentIndex - 1).leagueID, 0)
            Else
                _teams.getTeamRowListByLeague(_leagues._leagueRowList(currentIndex - 1).leagueID, 1)
            End If
            Dim currentTeam As Team
            For i As Integer = 0 To _teams._teamRowList.Count - 1
                currentTeam = _teams._teamRowList(i)
                lv.Items.Add(currentTeam.teamID)
                lv.Items(i).SubItems.Add(currentTeam.name)
                lv.Items(i).SubItems.Add(currentTeam.ownerFirst & " " & currentTeam.ownerLast)
                lv.Items(i).SubItems.Add(currentTeam.leagueName)
                lv.Items(i).SubItems.Add(IIf(currentTeam.active = True, "Yes", "No"))
                currentTeam = Nothing
            Next
            lv.Columns.Add("Team ID")
            lv.Columns.Add("Team Name")
            lv.Columns.Add("Owner Name")
            lv.Columns.Add("League Name")
            lv.Columns.Add("Active")
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End If
    End Sub
    '***CORRECT***
    Private Sub lvTeams_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTeams.Click
        Dim currentIndex As Integer = lvTeams.SelectedItems(0).Index
        If _teams._teamRowList(currentIndex).active = True Then
            btnDeactivateTeam.Enabled = True
            btnActivateTeam.Enabled = False
        Else
            btnActivateTeam.Enabled = True
            btnDeactivateTeam.Enabled = False
        End If
        btnEditTeam.Enabled = True
    End Sub
    '***CORRECT***
    Private Sub btnAddTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTeam.Click
        Dim addTeam As New frmAddTeam(_leagues, _owners, _teams)
        Dim add As DialogResult = addTeam.ShowDialog
        If addTeam._added = True Then
            populateTeamListView(lvTeams)
            comboLeagueSelection.SelectedIndex = 0
        End If
        disableTeamControls()
    End Sub
    '***CORRECT***
    Private Sub btnEditTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTeam.Click
        Dim currentIndex As Integer = lvTeams.SelectedItems(0).Index
        Dim editTeam As New frmEditTeam(_leagues, _owners, _teams, currentIndex)
        Dim edit As DialogResult = editTeam.ShowDialog
        If editTeam._changed = True Then
            populateTeamListView(lvTeams)
            comboLeagueSelection.SelectedIndex = 0
        End If
        disableTeamControls()
    End Sub
    '***CORRECT***
    Private Sub btnDeactivateTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeactivateTeam.Click
        Dim currentIndex As Integer = lvTeams.SelectedItems(0).Index
        _teams.deactivateTeam(_teams._teamRowList(currentIndex).teamID)
        If _teams._success = True Then
            MsgBox("'" & _teams._teamRowList(currentIndex).name & "' is now an inactive team.")
            Me.DialogResult = DialogResult.OK
        End If
        disableTeamControls()
        populateTeamListView(lvTeams)
    End Sub
    '***CORRECT***
    Private Sub btnActivateTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivateTeam.Click
        Dim currentIndex As Integer = lvTeams.SelectedItems(0).Index
        _teams.activateTeam(_teams._teamRowList(currentIndex).teamID)
        If _teams._success = True Then
            MsgBox("'" & _teams._teamRowList(currentIndex).name & "' is now an active team.")
            Me.DialogResult = DialogResult.OK
        End If
        disableTeamControls()
        populateTeamListView(lvTeams)
    End Sub


    '***CORRECT***
    'Populates the combo team selection drop down.
    Private Sub populateComboTeamSelection()
        _teams.getTeamRowList()
        Me.comboTeamSelection.Items.Add("Select a team")
        Dim currentTeam As Team
        For i As Integer = 0 To _teams._teamRowList.Count - 1
            currentTeam = _teams._teamRowList(i)
            Me.comboTeamSelection.Items.Add(currentTeam.name)
        Next
        Me.comboTeamSelection.SelectedIndex = 0
    End Sub
    '***CORRECT***
    Private Sub comboTeamSelection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboTeamSelection.Click
        disableRosterControls()
    End Sub
    '***CORRECT***
    Private Sub disableRosterControls()
        btnActivatePlayer.Enabled = False
        btnDeactivatePlayer.Enabled = False
        btnEditPlayer.Enabled = False
    End Sub
    '***CORRECT***
    Private Sub checkRosterInactive_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkRosterInactive.CheckStateChanged
        populateRosterListView(lvRosters)
        disableRosterControls()
    End Sub
    '***CORRECT***
    'Event to populate the roster list view after the user selects a team from the team combo box.
    Private Sub comboTeamSelection_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboTeamSelection.SelectedIndexChanged
        populateRosterListView(lvRosters)
    End Sub
    '***CORRECT***
    'Populates the roster list view with data from the database.
    Private Sub populateRosterListView(ByRef lv As ListView)
        lv.Clear()
        _teams.getTeamRowList()
        Dim currentIndex = comboTeamSelection.SelectedIndex
        If currentIndex > 0 Then
            If checkRosterInactive.Checked = True Then
                _rosters.getRosterRowListByTeam(_teams._teamRowList(currentIndex - 1).teamID, 0)
            Else
                _rosters.getRosterRowListByTeam(_teams._teamRowList(currentIndex - 1).teamID, 1)
            End If
            Dim currentRoster As Roster
            For i As Integer = 0 To _rosters._rosterRowList.Count - 1
                currentRoster = _rosters._rosterRowList(i)
                lv.Items.Add(currentRoster.playerID)
                lv.Items(i).SubItems.Add(currentRoster.firstName & " " & currentRoster.lastName)
                lv.Items(i).SubItems.Add(currentRoster.position)
                lv.Items(i).SubItems.Add(currentRoster.team)
                lv.Items(i).SubItems.Add(IIf(currentRoster.active = True, "Yes", "No"))
                currentRoster = Nothing
            Next
            lv.Columns.Add("Player ID")
            lv.Columns.Add("Name")
            lv.Columns.Add("Position")
            lv.Columns.Add("Team")
            lv.Columns.Add("Active")
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End If
    End Sub
    '***CORRECT***
    Private Sub lvRosters_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRosters.Click
        Dim currentIndex As Integer = lvRosters.SelectedItems(0).Index
        If _rosters._rosterRowList(currentIndex).active = True Then
            btnDeactivatePlayer.Enabled = True
            btnActivatePlayer.Enabled = False
        Else
            btnActivatePlayer.Enabled = True
            btnDeactivatePlayer.Enabled = False
        End If
        btnEditPlayer.Enabled = True
    End Sub
    '***CORRECT***
    Private Sub btnAddPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPlayer.Click
        Dim addPlayer As New frmAddPlayer(_teams, _rosters)
        Dim add As DialogResult = addPlayer.ShowDialog
        If addPlayer._added = True Then
            populateRosterListView(lvRosters)
            comboTeamSelection.SelectedIndex = 0
        End If
        disableRosterControls()
    End Sub
    '***CORRECT***
    Private Sub btnEditPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPlayer.Click
        Dim currentIndex As Integer = lvRosters.SelectedItems(0).Index
        Dim editPlayer As New frmEditPlayer(_teams, _rosters, currentIndex)
        Dim edit As DialogResult = editPlayer.ShowDialog
        If editPlayer._changed = True Then
            populateRosterListView(lvRosters)
            comboTeamSelection.SelectedIndex = 0
        End If
        disableRosterControls()
    End Sub
    '***CORRECT***
    Private Sub btnDeactivatePlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeactivatePlayer.Click
        Dim currentIndex As Integer = lvRosters.SelectedItems(0).Index
        _rosters.deactivateRoster(_rosters._rosterRowList(currentIndex).playerID)
        If _rosters._success = True Then
            MsgBox("'" & _rosters._rosterRowList(currentIndex).firstName & " " & _rosters._rosterRowList(currentIndex).lastName & "' is now an inactive player.")
            Me.DialogResult = DialogResult.OK
        End If
        disableRosterControls()
        populateRosterListView(lvRosters)
    End Sub
    '***CORRECT***
    Private Sub btnActivatePlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivatePlayer.Click
        Dim currentIndex As Integer = lvRosters.SelectedItems(0).Index
        _rosters.activateRoster(_rosters._rosterRowList(currentIndex).playerID)
        If _rosters._success = True Then
            MsgBox("'" & _rosters._rosterRowList(currentIndex).firstName & " " & _rosters._rosterRowList(currentIndex).lastName & "' is now an active player.")
            Me.DialogResult = DialogResult.OK
        End If
        disableRosterControls()
        populateRosterListView(lvRosters)
    End Sub
End Class