<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabOwners = New System.Windows.Forms.TabPage()
        Me.comboOwnerActive = New System.Windows.Forms.ComboBox()
        Me.lblOwnerActive = New System.Windows.Forms.Label()
        Me.btnActivateOwner = New System.Windows.Forms.Button()
        Me.btnDeactivateOwner = New System.Windows.Forms.Button()
        Me.btnEditOwner = New System.Windows.Forms.Button()
        Me.btnAddOwner = New System.Windows.Forms.Button()
        Me.lvOwners = New System.Windows.Forms.ListView()
        Me.tabRosters = New System.Windows.Forms.TabPage()
        Me.checkRosterInactive = New System.Windows.Forms.CheckBox()
        Me.btnActivatePlayer = New System.Windows.Forms.Button()
        Me.btnDeactivatePlayer = New System.Windows.Forms.Button()
        Me.btnEditPlayer = New System.Windows.Forms.Button()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.lblTeamSelection = New System.Windows.Forms.Label()
        Me.comboTeamSelection = New System.Windows.Forms.ComboBox()
        Me.lvRosters = New System.Windows.Forms.ListView()
        Me.tabTeams = New System.Windows.Forms.TabPage()
        Me.checkTeamInactive = New System.Windows.Forms.CheckBox()
        Me.btnActivateTeam = New System.Windows.Forms.Button()
        Me.btnDeactivateTeam = New System.Windows.Forms.Button()
        Me.btnEditTeam = New System.Windows.Forms.Button()
        Me.btnAddTeam = New System.Windows.Forms.Button()
        Me.lblLeagueSelection = New System.Windows.Forms.Label()
        Me.comboLeagueSelection = New System.Windows.Forms.ComboBox()
        Me.lvTeams = New System.Windows.Forms.ListView()
        Me.tabLeagues = New System.Windows.Forms.TabPage()
        Me.comboLeagueActive = New System.Windows.Forms.ComboBox()
        Me.lblLeagueActive = New System.Windows.Forms.Label()
        Me.btnEditLeague = New System.Windows.Forms.Button()
        Me.btnActivateLeague = New System.Windows.Forms.Button()
        Me.btnDeactivateLeague = New System.Windows.Forms.Button()
        Me.btnAddLeague = New System.Windows.Forms.Button()
        Me.lvLeagues = New System.Windows.Forms.ListView()
        Me.tabsFFM = New System.Windows.Forms.TabControl()
        Me.tabOwners.SuspendLayout()
        Me.tabRosters.SuspendLayout()
        Me.tabTeams.SuspendLayout()
        Me.tabLeagues.SuspendLayout()
        Me.tabsFFM.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabOwners
        '
        Me.tabOwners.Controls.Add(Me.comboOwnerActive)
        Me.tabOwners.Controls.Add(Me.lblOwnerActive)
        Me.tabOwners.Controls.Add(Me.btnActivateOwner)
        Me.tabOwners.Controls.Add(Me.btnDeactivateOwner)
        Me.tabOwners.Controls.Add(Me.btnEditOwner)
        Me.tabOwners.Controls.Add(Me.btnAddOwner)
        Me.tabOwners.Controls.Add(Me.lvOwners)
        Me.tabOwners.Location = New System.Drawing.Point(4, 22)
        Me.tabOwners.Name = "tabOwners"
        Me.tabOwners.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOwners.Size = New System.Drawing.Size(723, 346)
        Me.tabOwners.TabIndex = 3
        Me.tabOwners.Text = "Owners"
        Me.tabOwners.UseVisualStyleBackColor = True
        '
        'comboOwnerActive
        '
        Me.comboOwnerActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOwnerActive.FormattingEnabled = True
        Me.comboOwnerActive.Location = New System.Drawing.Point(596, 6)
        Me.comboOwnerActive.Name = "comboOwnerActive"
        Me.comboOwnerActive.Size = New System.Drawing.Size(121, 21)
        Me.comboOwnerActive.TabIndex = 22
        '
        'lblOwnerActive
        '
        Me.lblOwnerActive.AutoSize = True
        Me.lblOwnerActive.Location = New System.Drawing.Point(550, 9)
        Me.lblOwnerActive.Name = "lblOwnerActive"
        Me.lblOwnerActive.Size = New System.Drawing.Size(40, 13)
        Me.lblOwnerActive.TabIndex = 0
        Me.lblOwnerActive.Text = "Active:"
        '
        'btnActivateOwner
        '
        Me.btnActivateOwner.Enabled = False
        Me.btnActivateOwner.Location = New System.Drawing.Point(6, 120)
        Me.btnActivateOwner.Name = "btnActivateOwner"
        Me.btnActivateOwner.Size = New System.Drawing.Size(122, 23)
        Me.btnActivateOwner.TabIndex = 26
        Me.btnActivateOwner.Text = "Activate Owner"
        Me.btnActivateOwner.UseVisualStyleBackColor = True
        '
        'btnDeactivateOwner
        '
        Me.btnDeactivateOwner.Enabled = False
        Me.btnDeactivateOwner.Location = New System.Drawing.Point(6, 91)
        Me.btnDeactivateOwner.Name = "btnDeactivateOwner"
        Me.btnDeactivateOwner.Size = New System.Drawing.Size(122, 23)
        Me.btnDeactivateOwner.TabIndex = 25
        Me.btnDeactivateOwner.Text = "Deactivate Owner"
        Me.btnDeactivateOwner.UseVisualStyleBackColor = True
        '
        'btnEditOwner
        '
        Me.btnEditOwner.Enabled = False
        Me.btnEditOwner.Location = New System.Drawing.Point(6, 62)
        Me.btnEditOwner.Name = "btnEditOwner"
        Me.btnEditOwner.Size = New System.Drawing.Size(122, 23)
        Me.btnEditOwner.TabIndex = 24
        Me.btnEditOwner.Text = "Edit Owner"
        Me.btnEditOwner.UseVisualStyleBackColor = True
        '
        'btnAddOwner
        '
        Me.btnAddOwner.Location = New System.Drawing.Point(6, 33)
        Me.btnAddOwner.Name = "btnAddOwner"
        Me.btnAddOwner.Size = New System.Drawing.Size(122, 23)
        Me.btnAddOwner.TabIndex = 23
        Me.btnAddOwner.Text = "Add New Owner"
        Me.btnAddOwner.UseVisualStyleBackColor = True
        '
        'lvOwners
        '
        Me.lvOwners.FullRowSelect = True
        Me.lvOwners.GridLines = True
        Me.lvOwners.Location = New System.Drawing.Point(134, 33)
        Me.lvOwners.MultiSelect = False
        Me.lvOwners.Name = "lvOwners"
        Me.lvOwners.Size = New System.Drawing.Size(583, 304)
        Me.lvOwners.TabIndex = 27
        Me.lvOwners.UseCompatibleStateImageBehavior = False
        Me.lvOwners.View = System.Windows.Forms.View.Details
        '
        'tabRosters
        '
        Me.tabRosters.Controls.Add(Me.checkRosterInactive)
        Me.tabRosters.Controls.Add(Me.btnActivatePlayer)
        Me.tabRosters.Controls.Add(Me.btnDeactivatePlayer)
        Me.tabRosters.Controls.Add(Me.btnEditPlayer)
        Me.tabRosters.Controls.Add(Me.btnAddPlayer)
        Me.tabRosters.Controls.Add(Me.lblTeamSelection)
        Me.tabRosters.Controls.Add(Me.comboTeamSelection)
        Me.tabRosters.Controls.Add(Me.lvRosters)
        Me.tabRosters.Location = New System.Drawing.Point(4, 22)
        Me.tabRosters.Name = "tabRosters"
        Me.tabRosters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRosters.Size = New System.Drawing.Size(723, 346)
        Me.tabRosters.TabIndex = 2
        Me.tabRosters.Text = "Rosters"
        Me.tabRosters.UseVisualStyleBackColor = True
        '
        'checkRosterInactive
        '
        Me.checkRosterInactive.AutoSize = True
        Me.checkRosterInactive.Location = New System.Drawing.Point(615, 8)
        Me.checkRosterInactive.Name = "checkRosterInactive"
        Me.checkRosterInactive.Size = New System.Drawing.Size(102, 17)
        Me.checkRosterInactive.TabIndex = 16
        Me.checkRosterInactive.Text = "Include Inactive"
        Me.checkRosterInactive.UseVisualStyleBackColor = True
        '
        'btnActivatePlayer
        '
        Me.btnActivatePlayer.Enabled = False
        Me.btnActivatePlayer.Location = New System.Drawing.Point(6, 120)
        Me.btnActivatePlayer.Name = "btnActivatePlayer"
        Me.btnActivatePlayer.Size = New System.Drawing.Size(122, 23)
        Me.btnActivatePlayer.TabIndex = 20
        Me.btnActivatePlayer.Text = "Activate Player"
        Me.btnActivatePlayer.UseVisualStyleBackColor = True
        '
        'btnDeactivatePlayer
        '
        Me.btnDeactivatePlayer.Enabled = False
        Me.btnDeactivatePlayer.Location = New System.Drawing.Point(6, 91)
        Me.btnDeactivatePlayer.Name = "btnDeactivatePlayer"
        Me.btnDeactivatePlayer.Size = New System.Drawing.Size(122, 23)
        Me.btnDeactivatePlayer.TabIndex = 19
        Me.btnDeactivatePlayer.Text = "Deactivate Player"
        Me.btnDeactivatePlayer.UseVisualStyleBackColor = True
        '
        'btnEditPlayer
        '
        Me.btnEditPlayer.Enabled = False
        Me.btnEditPlayer.Location = New System.Drawing.Point(6, 62)
        Me.btnEditPlayer.Name = "btnEditPlayer"
        Me.btnEditPlayer.Size = New System.Drawing.Size(122, 23)
        Me.btnEditPlayer.TabIndex = 18
        Me.btnEditPlayer.Text = "Edit Player"
        Me.btnEditPlayer.UseVisualStyleBackColor = True
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.Location = New System.Drawing.Point(6, 33)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(122, 23)
        Me.btnAddPlayer.TabIndex = 17
        Me.btnAddPlayer.Text = "Add New Player"
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'lblTeamSelection
        '
        Me.lblTeamSelection.AutoSize = True
        Me.lblTeamSelection.Location = New System.Drawing.Point(44, 9)
        Me.lblTeamSelection.Name = "lblTeamSelection"
        Me.lblTeamSelection.Size = New System.Drawing.Size(84, 13)
        Me.lblTeamSelection.TabIndex = 0
        Me.lblTeamSelection.Text = "Team Selection:"
        '
        'comboTeamSelection
        '
        Me.comboTeamSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTeamSelection.FormattingEnabled = True
        Me.comboTeamSelection.Location = New System.Drawing.Point(134, 6)
        Me.comboTeamSelection.Name = "comboTeamSelection"
        Me.comboTeamSelection.Size = New System.Drawing.Size(322, 21)
        Me.comboTeamSelection.TabIndex = 15
        '
        'lvRosters
        '
        Me.lvRosters.FullRowSelect = True
        Me.lvRosters.GridLines = True
        Me.lvRosters.Location = New System.Drawing.Point(134, 33)
        Me.lvRosters.MultiSelect = False
        Me.lvRosters.Name = "lvRosters"
        Me.lvRosters.Size = New System.Drawing.Size(583, 304)
        Me.lvRosters.TabIndex = 21
        Me.lvRosters.UseCompatibleStateImageBehavior = False
        Me.lvRosters.View = System.Windows.Forms.View.Details
        '
        'tabTeams
        '
        Me.tabTeams.Controls.Add(Me.checkTeamInactive)
        Me.tabTeams.Controls.Add(Me.btnActivateTeam)
        Me.tabTeams.Controls.Add(Me.btnDeactivateTeam)
        Me.tabTeams.Controls.Add(Me.btnEditTeam)
        Me.tabTeams.Controls.Add(Me.btnAddTeam)
        Me.tabTeams.Controls.Add(Me.lblLeagueSelection)
        Me.tabTeams.Controls.Add(Me.comboLeagueSelection)
        Me.tabTeams.Controls.Add(Me.lvTeams)
        Me.tabTeams.Location = New System.Drawing.Point(4, 22)
        Me.tabTeams.Name = "tabTeams"
        Me.tabTeams.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTeams.Size = New System.Drawing.Size(723, 346)
        Me.tabTeams.TabIndex = 1
        Me.tabTeams.Text = "Teams"
        Me.tabTeams.UseVisualStyleBackColor = True
        '
        'checkTeamInactive
        '
        Me.checkTeamInactive.AutoSize = True
        Me.checkTeamInactive.Location = New System.Drawing.Point(615, 8)
        Me.checkTeamInactive.Name = "checkTeamInactive"
        Me.checkTeamInactive.Size = New System.Drawing.Size(102, 17)
        Me.checkTeamInactive.TabIndex = 9
        Me.checkTeamInactive.Text = "Include Inactive"
        Me.checkTeamInactive.UseVisualStyleBackColor = True
        '
        'btnActivateTeam
        '
        Me.btnActivateTeam.Enabled = False
        Me.btnActivateTeam.Location = New System.Drawing.Point(6, 120)
        Me.btnActivateTeam.Name = "btnActivateTeam"
        Me.btnActivateTeam.Size = New System.Drawing.Size(122, 23)
        Me.btnActivateTeam.TabIndex = 13
        Me.btnActivateTeam.Text = "Activate Team"
        Me.btnActivateTeam.UseVisualStyleBackColor = True
        '
        'btnDeactivateTeam
        '
        Me.btnDeactivateTeam.Enabled = False
        Me.btnDeactivateTeam.Location = New System.Drawing.Point(6, 91)
        Me.btnDeactivateTeam.Name = "btnDeactivateTeam"
        Me.btnDeactivateTeam.Size = New System.Drawing.Size(122, 23)
        Me.btnDeactivateTeam.TabIndex = 12
        Me.btnDeactivateTeam.Text = "Deactivate Team"
        Me.btnDeactivateTeam.UseVisualStyleBackColor = True
        '
        'btnEditTeam
        '
        Me.btnEditTeam.Enabled = False
        Me.btnEditTeam.Location = New System.Drawing.Point(6, 62)
        Me.btnEditTeam.Name = "btnEditTeam"
        Me.btnEditTeam.Size = New System.Drawing.Size(122, 23)
        Me.btnEditTeam.TabIndex = 11
        Me.btnEditTeam.Text = "Edit Team"
        Me.btnEditTeam.UseVisualStyleBackColor = True
        '
        'btnAddTeam
        '
        Me.btnAddTeam.Location = New System.Drawing.Point(6, 33)
        Me.btnAddTeam.Name = "btnAddTeam"
        Me.btnAddTeam.Size = New System.Drawing.Size(122, 23)
        Me.btnAddTeam.TabIndex = 10
        Me.btnAddTeam.Text = "Add New Team"
        Me.btnAddTeam.UseVisualStyleBackColor = True
        '
        'lblLeagueSelection
        '
        Me.lblLeagueSelection.AutoSize = True
        Me.lblLeagueSelection.Location = New System.Drawing.Point(35, 9)
        Me.lblLeagueSelection.Name = "lblLeagueSelection"
        Me.lblLeagueSelection.Size = New System.Drawing.Size(93, 13)
        Me.lblLeagueSelection.TabIndex = 0
        Me.lblLeagueSelection.Text = "League Selection:"
        '
        'comboLeagueSelection
        '
        Me.comboLeagueSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLeagueSelection.FormattingEnabled = True
        Me.comboLeagueSelection.Location = New System.Drawing.Point(134, 6)
        Me.comboLeagueSelection.Name = "comboLeagueSelection"
        Me.comboLeagueSelection.Size = New System.Drawing.Size(322, 21)
        Me.comboLeagueSelection.TabIndex = 8
        '
        'lvTeams
        '
        Me.lvTeams.FullRowSelect = True
        Me.lvTeams.GridLines = True
        Me.lvTeams.Location = New System.Drawing.Point(134, 33)
        Me.lvTeams.MultiSelect = False
        Me.lvTeams.Name = "lvTeams"
        Me.lvTeams.Size = New System.Drawing.Size(583, 304)
        Me.lvTeams.TabIndex = 14
        Me.lvTeams.UseCompatibleStateImageBehavior = False
        Me.lvTeams.View = System.Windows.Forms.View.Details
        '
        'tabLeagues
        '
        Me.tabLeagues.Controls.Add(Me.comboLeagueActive)
        Me.tabLeagues.Controls.Add(Me.lblLeagueActive)
        Me.tabLeagues.Controls.Add(Me.btnEditLeague)
        Me.tabLeagues.Controls.Add(Me.btnActivateLeague)
        Me.tabLeagues.Controls.Add(Me.btnDeactivateLeague)
        Me.tabLeagues.Controls.Add(Me.btnAddLeague)
        Me.tabLeagues.Controls.Add(Me.lvLeagues)
        Me.tabLeagues.Location = New System.Drawing.Point(4, 22)
        Me.tabLeagues.Name = "tabLeagues"
        Me.tabLeagues.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLeagues.Size = New System.Drawing.Size(723, 346)
        Me.tabLeagues.TabIndex = 0
        Me.tabLeagues.Text = "Leagues"
        Me.tabLeagues.UseVisualStyleBackColor = True
        '
        'comboLeagueActive
        '
        Me.comboLeagueActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLeagueActive.FormattingEnabled = True
        Me.comboLeagueActive.ItemHeight = 13
        Me.comboLeagueActive.Location = New System.Drawing.Point(596, 6)
        Me.comboLeagueActive.Name = "comboLeagueActive"
        Me.comboLeagueActive.Size = New System.Drawing.Size(121, 21)
        Me.comboLeagueActive.TabIndex = 2
        '
        'lblLeagueActive
        '
        Me.lblLeagueActive.AutoSize = True
        Me.lblLeagueActive.Location = New System.Drawing.Point(550, 9)
        Me.lblLeagueActive.Name = "lblLeagueActive"
        Me.lblLeagueActive.Size = New System.Drawing.Size(40, 13)
        Me.lblLeagueActive.TabIndex = 0
        Me.lblLeagueActive.Text = "Active:"
        '
        'btnEditLeague
        '
        Me.btnEditLeague.Enabled = False
        Me.btnEditLeague.Location = New System.Drawing.Point(6, 62)
        Me.btnEditLeague.Name = "btnEditLeague"
        Me.btnEditLeague.Size = New System.Drawing.Size(122, 23)
        Me.btnEditLeague.TabIndex = 4
        Me.btnEditLeague.Text = "Edit League"
        Me.btnEditLeague.UseVisualStyleBackColor = True
        '
        'btnActivateLeague
        '
        Me.btnActivateLeague.Enabled = False
        Me.btnActivateLeague.Location = New System.Drawing.Point(6, 120)
        Me.btnActivateLeague.Name = "btnActivateLeague"
        Me.btnActivateLeague.Size = New System.Drawing.Size(122, 23)
        Me.btnActivateLeague.TabIndex = 6
        Me.btnActivateLeague.Text = "Activate League"
        Me.btnActivateLeague.UseVisualStyleBackColor = True
        '
        'btnDeactivateLeague
        '
        Me.btnDeactivateLeague.Enabled = False
        Me.btnDeactivateLeague.Location = New System.Drawing.Point(6, 91)
        Me.btnDeactivateLeague.Name = "btnDeactivateLeague"
        Me.btnDeactivateLeague.Size = New System.Drawing.Size(122, 23)
        Me.btnDeactivateLeague.TabIndex = 5
        Me.btnDeactivateLeague.Text = "Deactivate League"
        Me.btnDeactivateLeague.UseVisualStyleBackColor = True
        '
        'btnAddLeague
        '
        Me.btnAddLeague.Location = New System.Drawing.Point(6, 33)
        Me.btnAddLeague.Name = "btnAddLeague"
        Me.btnAddLeague.Size = New System.Drawing.Size(122, 23)
        Me.btnAddLeague.TabIndex = 3
        Me.btnAddLeague.Text = "Add New League"
        Me.btnAddLeague.UseVisualStyleBackColor = True
        '
        'lvLeagues
        '
        Me.lvLeagues.FullRowSelect = True
        Me.lvLeagues.GridLines = True
        Me.lvLeagues.Location = New System.Drawing.Point(134, 33)
        Me.lvLeagues.MultiSelect = False
        Me.lvLeagues.Name = "lvLeagues"
        Me.lvLeagues.Size = New System.Drawing.Size(583, 304)
        Me.lvLeagues.TabIndex = 7
        Me.lvLeagues.UseCompatibleStateImageBehavior = False
        Me.lvLeagues.View = System.Windows.Forms.View.Details
        '
        'tabsFFM
        '
        Me.tabsFFM.Controls.Add(Me.tabLeagues)
        Me.tabsFFM.Controls.Add(Me.tabTeams)
        Me.tabsFFM.Controls.Add(Me.tabRosters)
        Me.tabsFFM.Controls.Add(Me.tabOwners)
        Me.tabsFFM.Location = New System.Drawing.Point(12, 12)
        Me.tabsFFM.Name = "tabsFFM"
        Me.tabsFFM.SelectedIndex = 0
        Me.tabsFFM.Size = New System.Drawing.Size(731, 372)
        Me.tabsFFM.TabIndex = 1
        '
        'frmActions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 383)
        Me.Controls.Add(Me.tabsFFM)
        Me.Name = "frmActions"
        Me.Text = "Fantasy Football Management"
        Me.tabOwners.ResumeLayout(False)
        Me.tabOwners.PerformLayout()
        Me.tabRosters.ResumeLayout(False)
        Me.tabRosters.PerformLayout()
        Me.tabTeams.ResumeLayout(False)
        Me.tabTeams.PerformLayout()
        Me.tabLeagues.ResumeLayout(False)
        Me.tabLeagues.PerformLayout()
        Me.tabsFFM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabOwners As System.Windows.Forms.TabPage
    Friend WithEvents lvOwners As System.Windows.Forms.ListView
    Friend WithEvents tabRosters As System.Windows.Forms.TabPage
    Friend WithEvents tabTeams As System.Windows.Forms.TabPage
    Friend WithEvents tabLeagues As System.Windows.Forms.TabPage
    Friend WithEvents tabsFFM As System.Windows.Forms.TabControl
    Friend WithEvents lvRosters As System.Windows.Forms.ListView
    Friend WithEvents lvTeams As System.Windows.Forms.ListView
    Friend WithEvents lvLeagues As System.Windows.Forms.ListView
    Friend WithEvents lblLeagueSelection As System.Windows.Forms.Label
    Friend WithEvents comboLeagueSelection As System.Windows.Forms.ComboBox
    Friend WithEvents lblTeamSelection As System.Windows.Forms.Label
    Friend WithEvents comboTeamSelection As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddLeague As System.Windows.Forms.Button
    Friend WithEvents btnAddTeam As System.Windows.Forms.Button
    Friend WithEvents btnDeactivateLeague As System.Windows.Forms.Button
    Friend WithEvents btnActivateLeague As System.Windows.Forms.Button
    Friend WithEvents btnEditLeague As System.Windows.Forms.Button
    Friend WithEvents btnActivateOwner As System.Windows.Forms.Button
    Friend WithEvents btnDeactivateOwner As System.Windows.Forms.Button
    Friend WithEvents btnEditOwner As System.Windows.Forms.Button
    Friend WithEvents btnAddOwner As System.Windows.Forms.Button
    Friend WithEvents btnAddPlayer As System.Windows.Forms.Button
    Friend WithEvents comboLeagueActive As System.Windows.Forms.ComboBox
    Friend WithEvents lblLeagueActive As System.Windows.Forms.Label
    Friend WithEvents comboOwnerActive As System.Windows.Forms.ComboBox
    Friend WithEvents lblOwnerActive As System.Windows.Forms.Label
    Friend WithEvents btnActivatePlayer As System.Windows.Forms.Button
    Friend WithEvents btnDeactivatePlayer As System.Windows.Forms.Button
    Friend WithEvents btnEditPlayer As System.Windows.Forms.Button
    Friend WithEvents btnActivateTeam As System.Windows.Forms.Button
    Friend WithEvents btnDeactivateTeam As System.Windows.Forms.Button
    Friend WithEvents btnEditTeam As System.Windows.Forms.Button
    Friend WithEvents checkTeamInactive As System.Windows.Forms.CheckBox
    Friend WithEvents checkRosterInactive As System.Windows.Forms.CheckBox

End Class
