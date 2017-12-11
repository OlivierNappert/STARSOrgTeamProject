Imports System.Data.SqlClient
Public Class frmMemberRoles
    Private strCurrentPID As String
    Private strCurrentSemester As String

    Private objMemberRoles As cMemberRoles
    Private objMembers As cMembers
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private objMemberRAL As ArrayList
    Private strSecRole As String


    Private Sub frmMemberRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadMembers()
        If strSecRole IsNot "Admin" Or strSecRole IsNot "Officer" Then

        End If

        objMemberRoles = New cMemberRoles
    End Sub

    Private Sub CurrentSemester() Handles cmb_Semester.SelectedIndexChanged, cmb_Year.SelectedIndexChanged
        strCurrentSemester = ""
        If cmb_Semester.SelectedIndex = 0 Then
            strCurrentSemester = "Fa"
        End If
        If cmb_Semester.SelectedIndex = 1 Then
            strCurrentSemester = "Sp"
        End If
        If cmb_Year.SelectedIndex = 0 Then
            strCurrentSemester += "17"
        End If
        If cmb_Year.SelectedIndex = 1 Then
            strCurrentSemester += "18"
        End If
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
        lstMembers.Items.Clear()
    End Sub
    Private Sub LoadMembers()
        Dim objReader As SqlDataReader
        clearCheckListBox()
        '        ModDB.objSQLCommand.CommandType = CommandType.StoredProcedure
        Try
            objReader = objMembers.GetAllMembers
            Do While objReader.Read
                lstMembers.Items.Add(objReader.Item("PID"))
            Loop
            objReader.Close()
        Catch ex As Exception

        End Try

        '    objReader.Close()

    End Sub
    Public Function GetRoles() As SqlDataReader Handles lstMembers.SelectedIndexChanged
        Dim objReader As SqlDataReader
        Dim strPIDCurrent As String
        strPIDCurrent = lstMembers.SelectedItem
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
            '      MessageBox.Show("Error in frmRoles:LoadMemberRoles",)
        End Try

    End Function




    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim objReader As SqlDataReader
        Dim strPIDCurrent As String
        strPIDCurrent = lstMembers.SelectedItem
        Try


            For index As Integer = 0 To lstMembers.Items.Count - 1
                If lstMembers.SelectedItem("RoleID") = "Admin" Then
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
                index += 1
            Next

        Catch ex As Exception
            '      MessageBox.Show("Error in frmRoles:LoadMemberRoles",)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)


        clearCheckListBox()

        blnClearing = True
        sslStatus.Text = ""
        chkNew.Checked = False
        'errp.clear
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '    clb_MemberRoles.CheckedIndexCollection

    End Sub
End Class