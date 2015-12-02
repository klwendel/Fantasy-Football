<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTeam
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.comboOwner = New System.Windows.Forms.ComboBox()
        Me.comboActive = New System.Windows.Forms.ComboBox()
        Me.comboLeague = New System.Windows.Forms.ComboBox()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblLeague = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(198, 163)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(96, 163)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'comboOwner
        '
        Me.comboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOwner.FormattingEnabled = True
        Me.comboOwner.Location = New System.Drawing.Point(95, 53)
        Me.comboOwner.Name = "comboOwner"
        Me.comboOwner.Size = New System.Drawing.Size(178, 21)
        Me.comboOwner.TabIndex = 11
        '
        'comboActive
        '
        Me.comboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboActive.FormattingEnabled = True
        Me.comboActive.Location = New System.Drawing.Point(96, 123)
        Me.comboActive.Name = "comboActive"
        Me.comboActive.Size = New System.Drawing.Size(74, 21)
        Me.comboActive.TabIndex = 13
        '
        'comboLeague
        '
        Me.comboLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLeague.FormattingEnabled = True
        Me.comboLeague.Location = New System.Drawing.Point(96, 88)
        Me.comboLeague.Name = "comboLeague"
        Me.comboLeague.Size = New System.Drawing.Size(177, 21)
        Me.comboLeague.TabIndex = 12
        '
        'txtTeamName
        '
        Me.txtTeamName.Location = New System.Drawing.Point(95, 17)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(178, 20)
        Me.txtTeamName.TabIndex = 8
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(49, 126)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 13)
        Me.lblActive.TabIndex = 7
        Me.lblActive.Text = "Active:"
        '
        'lblLeague
        '
        Me.lblLeague.AutoSize = True
        Me.lblLeague.Location = New System.Drawing.Point(43, 91)
        Me.lblLeague.Name = "lblLeague"
        Me.lblLeague.Size = New System.Drawing.Size(46, 13)
        Me.lblLeague.TabIndex = 6
        Me.lblLeague.Text = "League:"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(48, 56)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(41, 13)
        Me.lblOwner.TabIndex = 10
        Me.lblOwner.Text = "Owner:"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Location = New System.Drawing.Point(21, 20)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(68, 13)
        Me.lblTeamName.TabIndex = 9
        Me.lblTeamName.Text = "Team Name:"
        '
        'frmAddTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 203)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.comboOwner)
        Me.Controls.Add(Me.comboActive)
        Me.Controls.Add(Me.comboLeague)
        Me.Controls.Add(Me.txtTeamName)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.lblLeague)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.lblTeamName)
        Me.Name = "frmAddTeam"
        Me.Text = "Create New Team"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents comboOwner As System.Windows.Forms.ComboBox
    Friend WithEvents comboActive As System.Windows.Forms.ComboBox
    Friend WithEvents comboLeague As System.Windows.Forms.ComboBox
    Friend WithEvents txtTeamName As System.Windows.Forms.TextBox
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents lblLeague As System.Windows.Forms.Label
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblTeamName As System.Windows.Forms.Label
End Class
