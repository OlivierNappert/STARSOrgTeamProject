Imports System.Data.SqlClient

Public Class frmMembersReport

    Private objRoles As cMemberRoles
    Private Sub frmMembersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As SqlDataReader
        Try
            objReader = objMemberRoles.GetAllMemberRoles
            Do While objReader.Read
                lstReport.Items.Add(objReader.Item("PID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error in frmRoles:LoadAllRoles" & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'we could have CDB just throw the error and handle it here
        End Try


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub drgReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class