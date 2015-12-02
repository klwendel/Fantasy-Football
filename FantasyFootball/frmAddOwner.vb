Imports BLL
Imports DataObjects

Public Class frmAddOwner
    Private _roles As RoleManager
    Private _owners As OwnerManager
    Public _added As Boolean
    '***CORRECT***
    Public Sub New(ByRef owner As OwnerManager)
        ' This call is required by the designer.
        InitializeComponent()
        _owners = owner
    End Sub
    '***CORRECT***
    Private Sub frmAddOwner_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _roles = New RoleManager
        populateComboRole()
        populateComboActive()
    End Sub
    '***CORRECT***
    Private Sub populateComboRole()
        _roles.getLeagueRowList()
        Me.comboRole.Items.Add("Select a role")
        Dim currentRole As Role
        For i As Integer = 0 To _roles._roleRowList.Count - 1
            currentRole = _roles._roleRowList(i)
            Me.comboRole.Items.Add(currentRole.description)
        Next
        Me.comboRole.SelectedIndex = 0
    End Sub
    '***CORRECT***
    Private Sub populateComboActive()
        Dim active As Active
        For i As Integer = 1 To 0 Step -1
            active = i
            Me.comboActive.Items.Add(active)
        Next
        Me.comboActive.SelectedIndex = 0
    End Sub
    '***CORRECT***
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtFirstName.Text = "" Then
            MsgBox("Please enter a first name.")
            txtFirstName.Focus()
        ElseIf txtFirstName.TextLength > 35 Then
            MsgBox("The first name can not exceed 35 characters.")
            txtFirstName.Focus()
            txtFirstName.SelectAll()
        ElseIf txtLastName.Text = "" Then
            MsgBox("Please enter a last name.")
            txtLastName.Focus()
        ElseIf txtLastName.TextLength > 35 Then
            MsgBox("The last name can not exceed 35 characters.")
            txtLastName.Focus()
            txtLastName.SelectAll()
        ElseIf comboRole.SelectedIndex = 0 Then
            MsgBox("You must select a role")
            comboRole.Focus()
        Else
            Dim owner As New Owner
            owner.firstName = txtFirstName.Text
            owner.lastName = txtLastName.Text
            owner.roleID = _roles._roleRowList(comboRole.SelectedIndex - 1).roleID
            owner.roleDescription = _roles._roleRowList(comboRole.SelectedIndex - 1).description
            owner.active = comboActive.SelectedItem
            _owners.addOwner(owner)
            If _owners._success = True Then
                Me.DialogResult = DialogResult.OK
                MsgBox("The owner was created. The information pertaining to this owner is listed below: " & vbCrLf & vbCrLf & "First Name: " & owner.firstName & vbCrLf & "Last Name: " & owner.lastName & vbCrLf & "Role Description: " & owner.roleDescription & vbCrLf & "Active: " & owner.active)
                _added = True
            Else
                MsgBox("The owner was not created.")
            End If
        End If
    End Sub
End Class