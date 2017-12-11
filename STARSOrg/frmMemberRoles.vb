Imports System.Data.SqlClient
Public Class frmMemberRoles
    Private strCurrentPID As String
    Private strCurrentSemester As String
    Private report As frmMembersReport
    Private objMemberRoles As cMemberRoles
    Private objMembers As cMembers
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private objMemberRAL As ArrayList
    Private strSecRole As String


    Private Sub frmMemberRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMembers.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.DataSetMembers.MEMBER)
        loadMembers()

        cbo_Semester.SelectedIndex = 0
        strCurrentSemester = "Fall"
        objMemberRoles = New cMemberRoles
    End Sub

    Private Sub loadMembers()

    End Sub

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbEvents.MouseEnter, tsbTutor.MouseEnter, tsbRSVP.MouseEnter, tsbRole.MouseEnter, tsbMember.MouseEnter, tsbLogOut.MouseEnter, tsbHome.MouseEnter, tsbHelp.MouseEnter
        'we need to do this only because we are not putting our images in the image proporty, but instead we are using 
        'the backgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub
    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbEvents.MouseLeave, tsbTutor.MouseLeave, tsbRSVP.MouseLeave, tsbRole.MouseLeave, tsbMember.MouseLeave, tsbLogOut.MouseLeave, tsbHome.MouseLeave, tsbHelp.MouseLeave
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
    Private Sub clearCheckListBox()

        For i As Integer = 0 To i < clb_MemberRoles.Items.Count
            clb_MemberRoles.Items.IndexOf(i)
            i = i + 1
        Next

    End Sub
    Private Sub LoadRoles()
        Dim objReader As SqlDataReader
        clearCheckListBox()

        Try
            objReader = objMemberRoles.GetMemberRoles(strCurrentPID, strCurrentSemester)

            Do While objReader.Read
                If objReader.Item("RoleID") = "Admin" Then
                    clb_MemberRoles.SetItemCheckState(0, True)
                End If
                If objReader.Item("RoleID") = "Officer" Then
                    clb_MemberRoles.SetItemCheckState(1, True)
                End If
                If objReader.Item("RoleID") = "Tutor" Then
                    clb_MemberRoles.SetItemCheckState(3, True)
                End If
                If objReader.Item("RoleID") = "Member" Then
                    clb_MemberRoles.SetItemCheckState(4, True)
                End If

            Loop

        Catch ex As Exception
            MessageBox.Show("Error in frmRoles:LoadMemberRoles", "Error")
        End Try

        objReader.Close()

    End Sub
    Public Function GetAllRoles() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllRoles", Nothing)
    End Function





    Private Sub frmRoles_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '    ClearScreenControls(Me)
        LoadRoles()
        grpEdit.Enabled = False
    End Sub



    Private Sub lstRoles_SelectedIndexChanged(sender As Object, e As EventArgs)

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
        With objMemberRoles
            .PID = txtMemberRoleID.Text
            . = txtDesc.Text
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
        txtMemberRoleID.Text = ""

        clearCheckListBox()

        blnClearing = True
        sslStatus.Text = ""
        chkNew.Checked = False
        'errp.clear
    End Sub


    Private Sub txtMemberRoleID_TextChanged(sender As Object, e As EventArgs) Handles txtMemberRoleID.TextChanged
        strCurrentPID = txtMemberRoleID.Text
    End Sub

    Private Sub cbo_Semester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Semester.SelectedIndexChanged
        strCurrentSemester = cbo_Semester.GetItemText(cbo_Semester.SelectedItem)
    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        'If admin or officer only

    End Sub
End Class