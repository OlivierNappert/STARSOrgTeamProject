Public Class frmLogin
	Private strUsername As String
	Private strFrmPassword As String
	Private strDataPassword As String
	Private databaseSecurityTable As cSecurities
	Private databaseUserData As cSecurity
	Private blnLoginAttempt As Boolean
	Private databaseAuditTable As cAudits
	Private databaseAuditData As cAudit
	Public strSecRole As String
	Private LoginChangePass As frmLoginChangePass


    Private Sub LoadLoginInfo()
        strUsername = tbxUser.Text
        strFrmPassword = tbxPass.Text
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        LoadLoginInfo()
        If databaseSecurityTable.GetSecurityByUserID(strUsername) IsNot Nothing Then
            databaseUserData = databaseSecurityTable.GetSecurityByUserID(strUsername)
            If ((strUsername Is databaseUserData.UserID) And (strFrmPassword Is databaseUserData.Password)) Then
                blnLoginAttempt = True
            Else
                blnLoginAttempt = False
            End If
        Else
            blnLoginAttempt = False
        End If
        If blnLoginAttempt Then
            strSecRole = databaseUserData.SecRole
            databaseAuditTable.CreateNewAudit()
            databaseAuditData = databaseAuditTable.CurrentObject
            databaseAuditData.PID = databaseUserData.PID
            databaseAuditData.SUCCESS = "TRUE"
            databaseAuditData.Save()

            Me.Close()
        Else
            databaseAuditTable.CreateNewAudit()
            databaseAuditData = databaseAuditTable.CurrentObject
            If databaseSecurityTable.GetSecurityByUserID(strUsername) IsNot Nothing Then 'check if username exists. If it does then audit made saying false log for unique user. If not then false login with incorrect user entry
                databaseAuditData.PID = databaseUserData.PID
            Else
                databaseAuditData.PID = "9999999" 'designates an incorrect username entry
            End If
            databaseAuditData.SUCCESS = "False"
            databaseAuditData.Save()
            MessageBox.Show("Incorrect Username and/or Password.", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub lklChngPass_Click(sender As Object, e As EventArgs) Handles lklChngPass.Click
        LoginChangePass.ShowDialog()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoginChangePass = New frmLoginChangePass

    End Sub
End Class