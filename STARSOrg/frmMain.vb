Public Class frmMain
    Private RoleInfo As frmMemberRoles
    Private MembersInfo As frmMembers
    Private EventInfo As frmEventManager
	Private EventRSVP As frmEventRSVP
	Private Login As frmLogin
	Private AdminChoice As frmAdminChoice

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'instantiate a form object for each form in the application
		If Not String.Equals(strCurrUserSecRole, "ADMIN") Then
			tsbAdmin.Visible = False
		End If

		RoleInfo = New frmMemberRoles
		MembersInfo = New frmMembers
		EventInfo = New frmEventManager
		EventRSVP = New frmEventRSVP
		Login = New frmLogin
		AdminChoice = New frmAdminChoice

		RoleInfo.Hide()
		MembersInfo.Hide()
		EventInfo.Hide()
		EventRSVP.Hide()
		Login.Hide()
	End Sub



    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbEvents.MouseEnter, tsbEvents.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'we need to do this only because we are not putting our images in the image proporty, but instead we are using 
        'the backgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub
    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbEvents.MouseLeave, tsbEvents.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'we need to do this only because we are not putting our images in the image proporty, but instead we are using 
        'the backgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

	Private Sub PerformNextAction()
		'get the next action speccified on the child form, and then simulate the click of the toolbutton here
		Select Case intNextAction
			Case ACTION_HOME
				'We're already on the home screen
				tsbHome.PerformClick()
			Case ACTION_MEMBER
				tsbMember.PerformClick()
			Case ACTION_ROLE
				tsbRole.PerformClick()
			Case ACTION_EVENT
				tsbEvents.PerformClick()
			Case ACTION_RSVP
				tsbRSVP.PerformClick()
			Case ACTION_COURSE
			   ' tsbCourse.PerformClick()
			Case ACTION_SEMESTER
				tsbSemester.PerformClick()
			Case ACTION_TUTOR
				tsbTutor.PerformClick()
			Case ACTION_HELP
				tsbHelp.PerformClick()
			Case ACTION_LOGOUT
				tsbLogOut.PerformClick()
			Case Else
				MessageBox.Show("Unexpected case value in frmMain: PerformNextAction", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End Select
	End Sub

	Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
		If Not strCurrUserSecRole = "ADMIN" Or strCurrUserSecRole = "OFFICER" Then
			MessageBox.Show("Error, you need to be logged in as an Officer or an Admin to access that screen.", "Role error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			MembersInfo.Show()
        End If
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        RoleInfo.ShowDialog()
        Me.Hide()
        RoleInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbEvents_Click(sender As Object, e As EventArgs) Handles tsbEvents.Click
        EventInfo.Show()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        EventRSVP.Show()
    End Sub

	Private Sub tsbAdmin_Click(sender As Object, e As EventArgs) Handles tsbAdmin.Click
		AdminChoice.ShowDialog()
	End Sub

	Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
		Dim f As Form
		For Each f In Application.OpenForms
			If Not (String.Equals(f.Name, Me.Name) Or String.Equals(f.Name, Login.Name)) Then
				If Not f Is Nothing Then
					f.Close()
				End If
			End If
		Next
		Me.Close()
		Login.Show()
	End Sub
End Class
