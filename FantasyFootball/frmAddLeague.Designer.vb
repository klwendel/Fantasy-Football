<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddLeague
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lblTeamLimit = New System.Windows.Forms.Label()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.txtLeagueName = New System.Windows.Forms.TextBox()
        Me.comboTeamLimit = New System.Windows.Forms.ComboBox()
        Me.comboActive = New System.Windows.Forms.ComboBox()
        Me.comboOwner = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(11, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "League Name:"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(47, 51)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(41, 13)
        Me.lblOwner.TabIndex = 2
        Me.lblOwner.Text = "Owner:"
        '
        'lblTeamLimit
        '
        Me.lblTeamLimit.AutoSize = True
        Me.lblTeamLimit.Location = New System.Drawing.Point(27, 86)
        Me.lblTeamLimit.Name = "lblTeamLimit"
        Me.lblTeamLimit.Size = New System.Drawing.Size(61, 13)
        Me.lblTeamLimit.TabIndex = 3
        Me.lblTeamLimit.Text = "Team Limit:"
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(48, 121)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 13)
        Me.lblActive.TabIndex = 4
        Me.lblActive.Text = "Active:"
        '
        'txtLeagueName
        '
        Me.txtLeagueName.Location = New System.Drawing.Point(94, 12)
        Me.txtLeagueName.Name = "txtLeagueName"
        Me.txtLeagueName.Size = New System.Drawing.Size(178, 20)
        Me.txtLeagueName.TabIndex = 0
        '
        'comboTeamLimit
        '
        Me.comboTeamLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTeamLimit.FormattingEnabled = True
        Me.comboTeamLimit.Location = New System.Drawing.Point(95, 83)
        Me.comboTeamLimit.Name = "comboTeamLimit"
        Me.comboTeamLimit.Size = New System.Drawing.Size(74, 21)
        Me.comboTeamLimit.TabIndex = 2
        '
        'comboActive
        '
        Me.comboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboActive.FormattingEnabled = True
        Me.comboActive.Location = New System.Drawing.Point(95, 118)
        Me.comboActive.Name = "comboActive"
        Me.comboActive.Size = New System.Drawing.Size(74, 21)
        Me.comboActive.TabIndex = 3
        '
        'comboOwner
        '
        Me.comboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOwner.FormattingEnabled = True
        Me.comboOwner.Location = New System.Drawing.Point(94, 48)
        Me.comboOwner.Name = "comboOwner"
        Me.comboOwner.Size = New System.Drawing.Size(178, 21)
        Me.comboOwner.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(95, 158)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(197, 158)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmAddLeague
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 203)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.comboOwner)
        Me.Controls.Add(Me.comboActive)
        Me.Controls.Add(Me.comboTeamLimit)
        Me.Controls.Add(Me.txtLeagueName)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.lblTeamLimit)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmAddLeague"
        Me.Text = "Create New League"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblTeamLimit As System.Windows.Forms.Label
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents txtLeagueName As System.Windows.Forms.TextBox
    Friend WithEvents comboTeamLimit As System.Windows.Forms.ComboBox
    Friend WithEvents comboActive As System.Windows.Forms.ComboBox
    Friend WithEvents comboOwner As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
