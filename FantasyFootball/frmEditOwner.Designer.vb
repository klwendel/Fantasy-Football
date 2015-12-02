<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditOwner
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
        Me.comboActive = New System.Windows.Forms.ComboBox()
        Me.comboRole = New System.Windows.Forms.ComboBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblOwnerID = New System.Windows.Forms.Label()
        Me.lblOwnerIDVal = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(197, 186)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(95, 186)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'comboActive
        '
        Me.comboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboActive.FormattingEnabled = True
        Me.comboActive.Location = New System.Drawing.Point(95, 146)
        Me.comboActive.Name = "comboActive"
        Me.comboActive.Size = New System.Drawing.Size(74, 21)
        Me.comboActive.TabIndex = 3
        '
        'comboRole
        '
        Me.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboRole.FormattingEnabled = True
        Me.comboRole.Location = New System.Drawing.Point(95, 111)
        Me.comboRole.Name = "comboRole"
        Me.comboRole.Size = New System.Drawing.Size(177, 21)
        Me.comboRole.TabIndex = 2
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(48, 149)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 13)
        Me.lblActive.TabIndex = 0
        Me.lblActive.Text = "Active:"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(56, 114)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(32, 13)
        Me.lblRole.TabIndex = 0
        Me.lblRole.Text = "Role:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(27, 79)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(28, 43)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'lblOwnerID
        '
        Me.lblOwnerID.AutoSize = True
        Me.lblOwnerID.Location = New System.Drawing.Point(33, 9)
        Me.lblOwnerID.Name = "lblOwnerID"
        Me.lblOwnerID.Size = New System.Drawing.Size(55, 13)
        Me.lblOwnerID.TabIndex = 0
        Me.lblOwnerID.Text = "Owner ID:"
        '
        'lblOwnerIDVal
        '
        Me.lblOwnerIDVal.AutoSize = True
        Me.lblOwnerIDVal.Location = New System.Drawing.Point(91, 9)
        Me.lblOwnerIDVal.Name = "lblOwnerIDVal"
        Me.lblOwnerIDVal.Size = New System.Drawing.Size(0, 13)
        Me.lblOwnerIDVal.TabIndex = 28
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(94, 40)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(178, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(94, 76)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(178, 20)
        Me.txtLastName.TabIndex = 1
        '
        'frmEditOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 235)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblOwnerIDVal)
        Me.Controls.Add(Me.lblOwnerID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.comboActive)
        Me.Controls.Add(Me.comboRole)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "frmEditOwner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents comboActive As System.Windows.Forms.ComboBox
    Friend WithEvents comboRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblOwnerID As System.Windows.Forms.Label
    Friend WithEvents lblOwnerIDVal As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
End Class
