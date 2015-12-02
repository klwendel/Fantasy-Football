Imports BLL
Imports DataObjects

Public Class frmEditOwner
    Private _roles As RoleManager
    Private _owners As OwnerManager
    Private _currentIndex As Integer
    Public _changed As Boolean
    '***CORRECT***
    Public Sub New(ByRef ownerManager As OwnerManager, ByRef index As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        _owners = ownerManager
        _currentIndex = index
        Me.Text = "Owner: " & _owners._ownerRowList(_currentIndex).firstName & " " & _owners._ownerRowList(_currentIndex).lastName
    End Sub
    '***CORRECT***
    Private Sub frmEditOwner_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _roles = New RoleManager
        populateLblID()
        populateLblFirst()
        populateLblLast()
        populateComboRole()
        populateComboActive()
    End Sub
    '***CORRECT***
    Private Sub populateLblID()
        lblOwnerIDVal.Text = _owners._ownerRowList(_currentIndex).ownerID
    End Sub
    '***CORRECT***
    Private Sub populateLblFirst()
        txtFirstName.Text = _owners._ownerRowList(_currentIndex).firstName
    End Sub
    '***CORRECT***
    Private Sub populateLblLast()
        txtLastName.Text = _owners._ownerRowList(_currentIndex).lastName
    End Sub
    '***CORRECT***
    Private Sub populateComboRole()
        Dim index As Integer
        _roles.getLeagueRowList()
        Dim currentRole As Role
        For i As Integer = 0 To _roles._roleRowList.Count - 1
            currentRole = _roles._roleRowList(i)
            Me.comboRole.Items.Add(currentRole.description)
            If currentRole.roleID = _owners._ownerRowList(_currentIndex).roleID Then
                index = i
            End If
        Next
        Me.comboRole.SelectedIndex = index
    End Sub
    '***CORRECT***
    Private Sub populateComboActive()
        Dim active As Active
        Dim index As Integer
        For i As Integer = 1 To 0 Step -1
            active = i
            Me.comboActive.Items.Add(active)
            If _owners._ownerRowList(_currentIndex).active = True Then
                index = 0
            Else
                index = 1
            End If
        Next
        Me.comboActive.SelectedIndex = index
    End Sub
    '***CORRECT***
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
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
        Else
            Dim oldOwner As Owner = _owners._ownerRowList(_currentIndex)
            Dim newOwner As New Owner
            newOwner.firstName = txtFirstName.Text
            newOwner.lastName = txtLastName.Text
            newOwner.roleID = _roles._roleRowList(comboRole.SelectedIndex).roleID
            newOwner.roleDescription = _roles._roleRowList(comboRole.SelectedIndex).description
            newOwner.active = comboActive.SelectedItem
            _owners.editOwner(oldOwner, newOwner)
            _changed = True
            If _owners._success = True Then
                Me.DialogResult = DialogResult.OK
                MsgBox("The owner was updated.")
            Else
                MsgBox("The owner was not updated. Please tyr again")
            End If
        End If
    End Sub
End Class