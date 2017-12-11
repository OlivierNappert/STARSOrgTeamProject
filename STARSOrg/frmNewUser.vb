Public Class frmNewUser
	Private strMemberID As String
	Private strUsername As String
	Private strFrmPassword As String
	Private strDataPassword As String
	Private strSecurityPrivilege As String
	Private databaseSecurityTable As cSecurities
	Private databaseUserData As cSecurity
	Private AdminChoice As frmAdminChoice

	Private Sub LoadComboBoxChoices()
		cboSecurityPriv.Items.Add("MEMBER")
		cboSecurityPriv.Items.Add("OFFICER")
		cboSecurityPriv.Items.Add("ADMIN")
	End Sub
	Private Sub LoadNewUserInfo()
		strMemberID = tbxMemberID.Text
		strUsername = tbxUser.Text
		strFrmPassword = tbxPass.Text
		strSecurityPrivilege = cboSecurityPriv.SelectedItem.ToString
	End Sub

	Private Sub frmNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadComboBoxChoices()
		strMemberID = ""
		strUsername = ""
		strFrmPassword = ""
		strDataPassword = ""
		strSecurityPrivilege = ""
		databaseSecurityTable = New cSecurities
		databaseUserData = New cSecurity
		AdminChoice = New frmAdminChoice
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		LoadNewUserInfo()
		If (String.Equals(strMemberID, "") Or String.Equals(strUsername, "") Or String.Equals(strFrmPassword, "") Or String.Equals(strDataPassword, "") Or String.Equals(strSecurityPrivilege, "")) Then
			MessageBox.Show("Please Insert Data into each field", "Error", MessageBoxButtons.OK)
			Exit Sub
		End If
		If (strMemberID.Length > 7) Then
			MessageBox.Show("The Member ID cannot be longer than 7 characters", "Error", MessageBoxButtons.OK)
			Exit Sub
		End If
		If (strUsername.Length > 15) Then
			MessageBox.Show("The User ID cannot be longer than 15 characters", "Error", MessageBoxButtons.OK)
			Exit Sub
		End If
		If (strFrmPassword.Length > 8) Then
			MessageBox.Show("The Password cannot be longer than 8 characters", "Error", MessageBoxButtons.OK)
			Exit Sub
		End If
		databaseSecurityTable.CreateNewSecurity()
		databaseUserData = databaseSecurityTable.CurrentObject
		databaseUserData.PID = strMemberID
		databaseUserData.UserID = strUsername
		databaseUserData.Password = strFrmPassword
		databaseUserData.SecRole = strSecurityPrivilege
		If databaseUserData.Save() = 0 Then
			MessageBox.Show("A new user has been successfully created.", "New User Created", MessageBoxButtons.OK)
		ElseIf databaseUserData.Save() = -1 Then
			MessageBox.Show("A user with that MemberID and/or Username already exists.", "Error", MessageBoxButtons.OK)
		End If
	End Sub
End Class