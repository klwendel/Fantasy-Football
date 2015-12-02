<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPlayer
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.comboTeam = New System.Windows.Forms.ComboBox()
        Me.comboActive = New System.Windows.Forms.ComboBox()
        Me.comboPosition = New System.Windows.Forms.ComboBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(95, 12)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(178, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(28, 15)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(197, 192)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(95, 192)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'comboTeam
        '
        Me.comboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTeam.FormattingEnabled = True
        Me.comboTeam.Location = New System.Drawing.Point(94, 82)
        Me.comboTeam.Name = "comboTeam"
        Me.comboTeam.Size = New System.Drawing.Size(178, 21)
        Me.comboTeam.TabIndex = 2
        '
        'comboActive
        '
        Me.comboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboActive.FormattingEnabled = True
        Me.comboActive.Location = New System.Drawing.Point(95, 152)
        Me.comboActive.Name = "comboActive"
        Me.comboActive.Size = New System.Drawing.Size(74, 21)
        Me.comboActive.TabIndex = 4
        '
        'comboPosition
        '
        Me.comboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPosition.FormattingEnabled = True
        Me.comboPosition.Location = New System.Drawing.Point(95, 117)
        Me.comboPosition.Name = "comboPosition"
        Me.comboPosition.Size = New System.Drawing.Size(177, 21)
        Me.comboPosition.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(94, 46)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(178, 20)
        Me.txtLastName.TabIndex = 1
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(48, 155)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 13)
        Me.lblActive.TabIndex = 0
        Me.lblActive.Text = "Active:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(41, 120)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 0
        Me.lblPosition.Text = "Position:"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(51, 85)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(37, 13)
        Me.lblTeam.TabIndex = 0
        Me.lblTeam.Text = "Team:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(27, 49)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name:"
        '
        'frmAddPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 235)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.comboTeam)
        Me.Controls.Add(Me.comboActive)
        Me.Controls.Add(Me.comboPosition)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.lblLastName)
        Me.Name = "frmAddPlayer"
        Me.Text = "Create New Player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents comboTeam As System.Windows.Forms.ComboBox
    Friend WithEvents comboActive As System.Windows.Forms.ComboBox
    Friend WithEvents comboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblTeam As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
End Class
