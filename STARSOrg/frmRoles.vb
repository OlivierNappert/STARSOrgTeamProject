Imports System.Data.SqlClient
Public Class frmRoles
    Private objRoles As cRoles
    Private blnClearing As Boolean
    Private blnReloading As Boolean

    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objRoles = New cRoles
    End Sub

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbEvents.MouseEnter, tsbEvents.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbTutor.MouseEnter
        'we need to do this only because we are not putting our images in the image proporty, but instead we are using 
        'the backgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub
    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbEvents.MouseLeave, tsbEvents.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbTutor.MouseLeave
        'we need to do this only because we are not putting our images in the image proporty, but instead we are using 
        'the backgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()

    End Sub
    Private Sub LoadRoles()
        Dim objReader As SqlDataReader
        lstRoles.Items.Clear()

        Try
            objReader = objRoles.GetAllRoles
            Do While objReader.Read
                lstRoles.Items.Add(objReader.Item("RoleID"))
            Loop

        Catch ex As Exception
            '      MessageBox.Show("Error in frmRoles:LoadAllRoles",)
        End Try
        End
        objReader.Close()

    End Sub

    Private Sub frmRoles_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '    ClearScreenControls(Me)
        LoadRoles()
        grpEdit.Enabled = False
    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub

        End If
        If chkNew.Checked Then
            sslStatus.Text = ""
            txtRoleID.Clear()
            txtDesc.Clear()
            lstRoles.SelectedIndex = -1
            grpRoles.Enabled = False
            grpEdit.Enabled = True
            objRoles.CreateNewRole()
            txtRoleID.Focus()
        Else
            grpRoles.Enabled = True
            grpEdit.Enabled = False
            objRoles.CurrentObject.IsNewRole = False

        End If
    End Sub

    Private Sub lstRoles_SelectedIndexChanged(sender As Object, e As EventArgs)
        If blnClearing Then
            Exit Sub
        End If
        If Not blnReloading Then
            sslStatus.Text = ""
        End If
        If lstRoles.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNew.Checked = False
        '    LoadSelectedRecord()
        grpEdit.Enabled = True

    End Sub


    Private Sub LoadSelectedRecord()
        Throw New NotImplementedException()
        Try
            objRoles.GetRoleByID(lstRoles.SelectedItems.ToString)
            With objRoles.CurrentObject
                txtRoleID.text = .RoleID
                txtDesc.Text = .RoleDescription
            End With
        Catch ex As Exception
            'Error loading Role Values: LoadSelectedRecord
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        sslStatus.Text = ""
        'add your valdation from modErrhandler here
        If blnErrors Then
            Exit Sub
        End If
        'if we get this far, all of the input data is acceptable
        With objRoles.CurrentObject
            .RoleID = txtRoleID.Text
            .RoleDescription = txtDesc.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objRoles.Save
            If intResult = 1 Then
                sslStatus.Text = "Role record saved"
            End If
            If intResult = -1 Then 'ID was not unique
                'messagebox role ID must be unique unable to save this record, warning
                sslStatus.Text = "Error"
            End If
        Catch ex As Exception
            'messagebox unable to save role record & ex.toString
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadRoles()
        chkNew.Checked = False
        grpRoles.Enabled = True 'in case it was disabled for a new record
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        sslStatus.Text = ""
        chkNew.Checked = False
        errp.clear
        If lstRoles.SelectedIndex <> -1 Then
            '   LoadSelectedRecord()
        Else grpEdit.Enabled = False

        End If
        blnClearing = False
        objRoles.CurrentObject.IsNewRole = False
        grpRoles.Enabled = True

    End Sub

    Private Sub LoadSelectedRecord()
        Throw New NotImplementedException()
    End Sub

    Private Sub lstRoles_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstRoles.SelectedIndexChanged
        LoadAllMemberRoles()

    End Sub

    Private Sub LoadAllMemberRoles()
        Throw New NotImplementedException()
    End Sub
End Class