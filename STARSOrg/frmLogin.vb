Imports System.Data.SqlClient
Public Class frmLogin
	Private strUsername As String
	Private strFrmPassword As String
	Private databaseSecurityTable As cSecurities
	Private databaseUserData As cSecurity
	Private blnLoginAttempt As Boolean
	Private databaseAuditTable As cAudits
	Private databaseAuditData As cAudit
	Private LoginChangePass As frmLoginChangePass
	Private StarsOrgMainMenu As frmMain

	Private Sub LoadLoginInfo()
		strUsername = tbxUser.Text
		strFrmPassword = tbxPass.Text
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Application.Exit()
	End Sub

	Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
		LoadLoginInfo()

		If String.Equals(databaseSecurityTable.GetSecurityByUserID(strUsername).UserID, strUsername) Then
			databaseUserData = databaseSecurityTable.GetSecurityByUserID(strUsername)
			MessageBox.Show("entry found")
			If (String.Equals(strUsername, databaseUserData.UserID) And String.Equals(strFrmPassword, databaseUserData.Password)) Then
				blnLoginAttempt = True
				MessageBox.Show("good shit")
			Else
				blnLoginAttempt = False
			End If
		Else
			blnLoginAttempt = False
		End If
		If blnLoginAttempt Then
			strCurrUserPID = databaseUserData.PID
			strCurrUserUserID = databaseUserData.UserID
			strCurrUserSecRole = databaseUserData.SecRole
			databaseAuditTable.CreateNewAudit()
			databaseAuditData = databaseAuditTable.CurrentObject
			databaseAuditData.PID = databaseUserData.PID
			databaseAuditData.SUCCESS = 1
			databaseAuditData.ACCESSTIMESTAMP = DateAndTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
			databaseAuditData.Save()
			StarsOrgMainMenu.Show()
			Me.Hide()
		Else
			databaseAuditTable.CreateNewAudit()
			databaseAuditData = databaseAuditTable.CurrentObject
			If String.Equals(databaseSecurityTable.GetSecurityByUserID(strUsername).UserID, strUsername) Then 'check if username exists. If it does then audit made saying false log for unique user. If not then false login with incorrect user entry
				databaseAuditData.PID = databaseUserData.PID
			Else
				databaseAuditData.PID = "9999999" 'designates an incorrect username entry
			End If
			databaseAuditData.SUCCESS = 0
			databaseAuditData.ACCESSTIMESTAMP = DateAndTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
			databaseAuditData.Save()
			MessageBox.Show("Incorrect Username and/or Password.", "Error", MessageBoxButtons.OK)
		End If
	End Sub

	Private Sub lklChngPass_Click(sender As Object, e As EventArgs) Handles lklChngPass.Click
		Me.Hide()
		LoginChangePass.ShowDialog()
	End Sub

	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
		LoginChangePass = New frmLoginChangePass
		StarsOrgMainMenu = New frmMain
		Try
			myDB.OpenDB()
		Catch ex As Exception
			MessageBox.Show("Unable to open database. Connection string=" & gstrConn & " Program will end", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			If Not objSQLConn Is Nothing Then
				objSQLConn.Close()
				objSQLConn.Dispose()
			End If
			Me.Cursor = Cursors.Default
			End
		End Try
		databaseSecurityTable = New cSecurities
		databaseUserData = New cSecurity
		databaseAuditTable = New cAudits
		databaseAuditData = New cAudit
		strUsername = ""
		strFrmPassword = ""
	End Sub
End Class