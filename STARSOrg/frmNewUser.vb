Public Class frmNewUser
	Private strMemberID As String
	Private strUsername As String
	Private strFrmPassword As String
	Private strDataPassword As String
	Private strSecurityPrivilege As String
	Private databaseSecurityTable As cSecurities
	Private databaseUserData As cSecurity


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
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		LoadNewUserInfo()
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