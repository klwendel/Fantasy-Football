<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditLeague
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.comboOwner = New System.Windows.Forms.ComboBox()
        Me.comboActive = New System.Windows.Forms.ComboBox()
        Me.comboTeamLimit = New System.Windows.Forms.ComboBox()
        Me.txtLeagueName = New System.Windows.Forms.TextBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblTeamLimit = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLeagueID = New System.Windows.Forms.Label()
        Me.lblDateCreated = New System.Windows.Forms.Label()
        Me.lblDateCreatedVal = New System.Windows.Forms.Label()
        Me.lblLeagueIDVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(199, 219)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(97, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'comboOwner
        '
        Me.comboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOwner.FormattingEnabled = True
        Me.comboOwner.Location = New System.Drawing.Point(96, 109)
        Me.comboOwner.Name = "comboOwner"
        Me.comboOwner.Size = New System.Drawing.Size(178, 21)
        Me.comboOwner.TabIndex = 2
        '
        'comboActive
        '
        Me.comboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboActive.FormattingEnabled = True
        Me.comboActive.Location = New System.Drawing.Point(97, 179)
        Me.comboActive.Name = "comboActive"
        Me.comboActive.Size = New System.Drawing.Size(74, 21)
        Me.comboActive.TabIndex = 4
        '
        'comboTeamLimit
        '
        Me.comboTeamLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTeamLimit.FormattingEnabled = True
        Me.comboTeamLimit.Location = New System.Drawing.Point(97, 144)
        Me.comboTeamLimit.Name = "comboTeamLimit"
        Me.comboTeamLimit.Size = New System.Drawing.Size(74, 21)
        Me.comboTeamLimit.TabIndex = 3
        '
        'txtLeagueName
        '
        Me.txtLeagueName.Location = New System.Drawing.Point(96, 76)
        Me.txtLeagueName.Name = "txtLeagueName"
        Me.txtLeagueName.Size = New System.Drawing.Size(178, 20)
        Me.txtLeagueName.TabIndex = 1
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(50, 182)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 13)
        Me.lblActive.TabIndex = 0
        Me.lblActive.Text = "Active:"
        '
        'lblTeamLimit
        '
        Me.lblTeamLimit.AutoSize = True
        Me.lblTeamLimit.Location = New System.Drawing.Point(29, 147)
        Me.lblTeamLimit.Name = "lblTeamLimit"
        Me.lblTeamLimit.Size = New System.Drawing.Size(61, 13)
        Me.lblTeamLimit.TabIndex = 0
        Me.lblTeamLimit.Text = "Team Limit:"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(49, 112)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(41, 13)
        Me.lblOwner.TabIndex = 0
        Me.lblOwner.Text = "Owner:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 79)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "League Name:"
        '
        'lblLeagueID
        '
        Me.lblLeagueID.AutoSize = True
        Me.lblLeagueID.Location = New System.Drawing.Point(29, 9)
        Me.lblLeagueID.Name = "lblLeagueID"
        Me.lblLeagueID.Size = New System.Drawing.Size(60, 13)
        Me.lblLeagueID.TabIndex = 0
        Me.lblLeagueID.Text = "League ID:"
        '
        'lblDateCreated
        '
        Me.lblDateCreated.AutoSize = True
        Me.lblDateCreated.Location = New System.Drawing.Point(17, 43)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(73, 13)
        Me.lblDateCreated.TabIndex = 0
        Me.lblDateCreated.Text = "Date Created:"
        '
        'lblDateCreatedVal
        '
        Me.lblDateCreatedVal.AutoSize = True
        Me.lblDateCreatedVal.Location = New System.Drawing.Point(96, 43)
        Me.lblDateCreatedVal.Name = "lblDateCreatedVal"
        Me.lblDateCreatedVal.Size = New System.Drawing.Size(0, 13)
        Me.lblDateCreatedVal.TabIndex = 20
        '
        'lblLeagueIDVal
        '
        Me.lblLeagueIDVal.AutoSize = True
        Me.lblLeagueIDVal.Location = New System.Drawing.Point(96, 9)
        Me.lblLeagueIDVal.Name = "lblLeagueIDVal"
        Me.lblLeagueIDVal.Size = New System.Drawing.Size(0, 13)
        Me.lblLeagueIDVal.TabIndex = 21
        '
        'frmEditLeague
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 261)
        Me.Controls.Add(Me.lblLeagueIDVal)
        Me.Controls.Add(Me.lblDateCreatedVal)
        Me.Controls.Add(Me.lblDateCreated)
        Me.Controls.Add(Me.lblLeagueID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.comboOwner)
        Me.Controls.Add(Me.comboActive)
        Me.Controls.Add(Me.comboTeamLimit)
        Me.Controls.Add(Me.txtLeagueName)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.lblTeamLimit)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmEditLeague"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents comboOwner As System.Windows.Forms.ComboBox
    Friend WithEvents comboActive As System.Windows.Forms.ComboBox
    Friend WithEvents comboTeamLimit As System.Windows.Forms.ComboBox
    Friend WithEvents txtLeagueName As System.Windows.Forms.TextBox
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents lblTeamLimit As System.Windows.Forms.Label
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblLeagueID As System.Windows.Forms.Label
    Friend WithEvents lblDateCreated As System.Windows.Forms.Label
    Friend WithEvents lblDateCreatedVal As System.Windows.Forms.Label
    Friend WithEvents lblLeagueIDVal As System.Windows.Forms.Label
End Class
