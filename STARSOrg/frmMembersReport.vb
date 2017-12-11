Imports System.Data.SqlClient

Public Class frmMembersReport

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub frmMembersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dataSetMembers.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.dataSetMembers.MEMBER)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class