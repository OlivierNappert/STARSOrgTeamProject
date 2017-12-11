Public Class frmLoginChangePass
	Private Login As frmLogin
	Private strUsername As String
	Private strFrmOldPassword As String
	Private strFrmNewPassword As String
	Private strFrmNewPasswordConfirm As String
	Private databaseSecurityTable As cSecurities
	Private databaseUserData As cSecurity

	Private Sub LoadLoginChangePassInfo()
		strUsername = tbxUser.Text
		strFrmOldPassword = tbxOldPass.Text
		strFrmNewPassword = tbxNewPass.Text
		strFrmNewPasswordConfirm = tbxConfirmNewPass.Text
	End Sub

	Private Sub frmLoginChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Login = New frmLogin
		strUsername = ""
		strFrmOldPassword = ""
		strFrmNewPassword = ""
		strFrmNewPasswordConfirm = ""
		databaseSecurityTable = New cSecurities
		databaseUserData = New cSecurity
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
		Login.Show()
	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		LoadLoginChangePassInfo()
		If strUsername.Length > 15 Then
			MessageBox.Show("Incorrect Username and/or Password.", "Error", MessageBoxButtons.OK)
			Exit Sub
		End If
		If strFrmNewPassword.Length > 8 Then
			MessageBox.Show("Passwords can only have a maximum of 8 characters", "Error", MessageBoxButtons.OK)
			Exit Sub
		End If
		If String.Equals(databaseSecurityTable.GetSecurityByUserID(strUsername).UserID, strUsername) Then
			databaseUserData = databaseSecurityTable.GetSecurityByUserID(strUsername)
			If (String.Equals(strUsername, databaseUserData.UserID) And String.Equals(strFrmOldPassword, databaseUserData.Password)) Then
				If String.Equals(strFrmNewPassword, strFrmNewPasswordConfirm) Then
					databaseUserData.Password = strFrmNewPassword
					databaseUserData.Save()
					MessageBox.Show("Your password has been successfully changed.", "Password Changed", MessageBoxButtons.OK)
					Me.Close()
				Else
					MessageBox.Show("Your New Password does not match.", "Error", MessageBoxButtons.OK)
				End If
			End If
		Else
			MessageBox.Show("Incorrect Username and/or Password.", "Error", MessageBoxButtons.OK)
		End If
	End Sub
End Class