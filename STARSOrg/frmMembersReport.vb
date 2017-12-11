Imports System.Data.SqlClient

Public Class frmMembersReport

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmMembersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MEMBERTableAdapter.Fill(Me.dataSetMembers.MEMBER)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class