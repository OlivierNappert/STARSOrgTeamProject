Public Class frmLoginChangePass
	Private Login As frmLogin
	Private strUsername As String
	Private strFrmOldPassword As String
	Private strFrmNewPassword As String
	Private strFrmNewPasswordConfirm As String
	Private strDataPassword As String
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
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		LoadLoginChangePassInfo()
		If databaseSecurityTable.GetSecurityByUserID(strUsername) IsNot Nothing Then
			databaseUserData = databaseSecurityTable.GetSecurityByUserID(strUsername)
			If ((strUsername Is databaseUserData.UserID) And (strFrmOldPassword Is databaseUserData.Password)) Then
				If strFrmNewPassword Is strFrmNewPasswordConfirm Then
					databaseUserData.Password = strFrmNewPassword
					databaseUserData.Save()
					MessageBox.Show("Your password has been successfully changed.", "Password Changed", MessageBoxButtons.OK)
					Me.Close()
				End If
				MessageBox.Show("Your New Password does not match.", "Error", MessageBoxButtons.OK)
			End If
			MessageBox.Show("Incorrect Username and/or Password.", "Error", MessageBoxButtons.OK)
		End If
	End Sub
End Class