Public Class frmAdminResetPass
	Private strMemberID As String
	Private databaseSecurityTable As cSecurities
	Private databaseUserData As cSecurity
	Private AdminChoice As frmAdminChoice

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
		strMemberID = tbxUser.Text
		If (strMemberID.Length > 7) Then
			MessageBox.Show("The Member ID cannot be longer than 7 characters", "Error", MessageBoxButtons.OK)
			Exit Sub
		End If
		If String.Equals(databaseSecurityTable.GetSecurityByPID(strMemberID).PID, strMemberID) Then
			databaseUserData = databaseSecurityTable.CurrentObject
			databaseUserData.Password = databaseUserData.PID
			databaseUserData.Save()
			MessageBox.Show("User password has been successfully reset.", "Password Reset", MessageBoxButtons.OK)
		Else
			MessageBox.Show("MemberID does not exist in the database.", "Error", MessageBoxButtons.OK)
		End If

	End Sub

	Private Sub frmAdminResetPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		databaseSecurityTable = New cSecurities
		databaseUserData = New cSecurity
		strMemberID = ""
		AdminChoice = New frmAdminChoice
	End Sub
End Class