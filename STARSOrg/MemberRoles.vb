Imports System.Data.SqlClient

Public Class MemberRoles
    Private currentMemberRole As cMemberRole
    Private currentMember As cMember
    Private currentRole As cRole

    Private Sub btnProduceReport_Click(sender As Object, e As EventArgs) Handles btnProduceReport.Click

    End Sub

    Private Sub MemberRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        report As frmMemberRoleReport
    End Sub

    Private Sub cmbMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        LoadMembers()
    End Sub

    Private Sub LoadMembers()
        Dim objReader As SqlDataReader
        lstMembers.Items.Clear()

        Try
            objReader = currentRole.GetAllRoles
            Do While objReader.Read
                lstRoles.Items.Add(objReader.Item("RoleID"))
            Loop

        Catch ex As Exception
            '      MessageBox.Show("Error in frmRoles:LoadAllRoles",)
        End Try
        End
        objReader.Close()


    End Sub
End Class