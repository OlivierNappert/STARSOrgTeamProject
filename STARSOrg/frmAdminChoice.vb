Public Class frmAdminChoice
	Private NewUserMenu As frmNewUser
	Private AdminResetPassMenu As frmAdminResetPass

	Private Sub frmAdminChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		NewUserMenu = New frmNewUser
		AdminResetPassMenu = New frmAdminResetPass
	End Sub

	Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
		NewUserMenu.ShowDialog()
	End Sub

	Private Sub btnResetPass_Click(sender As Object, e As EventArgs) Handles btnResetPass.Click
		AdminResetPassMenu.ShowDialog()
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Hide()
	End Sub
End Class