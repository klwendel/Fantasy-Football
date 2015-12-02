<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditTeam
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
        Me.comboLeague = New System.Windows.Forms.ComboBox()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblLeague = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.lblTeamID = New System.Windows.Forms.Label()
        Me.lblTeamIDVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(193, 192)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(91, 192)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'comboOwner
        '
        Me.comboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOwner.FormattingEnabled = True
        Me.comboOwner.Location = New System.Drawing.Point(90, 82)
        Me.comboOwner.Name = "comboOwner"
        Me.comboOwner.Size = New System.Drawing.Size(178, 21)
        Me.comboOwner.TabIndex = 1
        '
        'comboActive
        '
        Me.comboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboActive.FormattingEnabled = True
        Me.comboActive.Location = New System.Drawing.Point(91, 152)
        Me.comboActive.Name = "comboActive"
        Me.comboActive.Size = New System.Drawing.Size(74, 21)
        Me.comboActive.TabIndex = 3
        '
        'comboLeague
        '
        Me.comboLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLeague.FormattingEnabled = True
        Me.comboLeague.Location = New System.Drawing.Point(91, 117)
        Me.comboLeague.Name = "comboLeague"
        Me.comboLeague.Size = New System.Drawing.Size(177, 21)
        Me.comboLeague.TabIndex = 2
        '
        'txtTeamName
        '
        Me.txtTeamName.Location = New System.Drawing.Point(90, 46)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(178, 20)
        Me.txtTeamName.TabIndex = 0
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(44, 155)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 13)
        Me.lblActive.TabIndex = 0
        Me.lblActive.Text = "Active:"
        '
        'lblLeague
        '
        Me.lblLeague.AutoSize = True
        Me.lblLeague.Location = New System.Drawing.Point(38, 120)
        Me.lblLeague.Name = "lblLeague"
        Me.lblLeague.Size = New System.Drawing.Size(46, 13)
        Me.lblLeague.TabIndex = 0
        Me.lblLeague.Text = "League:"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(43, 85)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(41, 13)
        Me.lblOwner.TabIndex = 0
        Me.lblOwner.Text = "Owner:"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Location = New System.Drawing.Point(16, 49)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(68, 13)
        Me.lblTeamName.TabIndex = 0
        Me.lblTeamName.Text = "Team Name:"
        '
        'lblTeamID
        '
        Me.lblTeamID.AutoSize = True
        Me.lblTeamID.Location = New System.Drawing.Point(33, 18)
        Me.lblTeamID.Name = "lblTeamID"
        Me.lblTeamID.Size = New System.Drawing.Size(51, 13)
        Me.lblTeamID.TabIndex = 0
        Me.lblTeamID.Text = "Team ID:"
        '
        'lblTeamIDVal
        '
        Me.lblTeamIDVal.AutoSize = True
        Me.lblTeamIDVal.Location = New System.Drawing.Point(87, 18)
        Me.lblTeamIDVal.Name = "lblTeamIDVal"
        Me.lblTeamIDVal.Size = New System.Drawing.Size(0, 13)
        Me.lblTeamIDVal.TabIndex = 27
        '
        'frmEditTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 235)
        Me.Controls.Add(Me.lblTeamIDVal)
        Me.Controls.Add(Me.lblTeamID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.comboOwner)
        Me.Controls.Add(Me.comboActive)
        Me.Controls.Add(Me.comboLeague)
        Me.Controls.Add(Me.txtTeamName)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.lblLeague)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.lblTeamName)
        Me.Name = "frmEditTeam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents comboOwner As System.Windows.Forms.ComboBox
    Friend WithEvents comboActive As System.Windows.Forms.ComboBox
    Friend WithEvents comboLeague As System.Windows.Forms.ComboBox
    Friend WithEvents txtTeamName As System.Windows.Forms.TextBox
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents lblLeague As System.Windows.Forms.Label
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblTeamName As System.Windows.Forms.Label
    Friend WithEvents lblTeamID As System.Windows.Forms.Label
    Friend WithEvents lblTeamIDVal As System.Windows.Forms.Label
End Class
