Imports System.Data.SqlClient

Public Class frmMembers

    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private myDB As CDB

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDB = New CDB
        If Not myDB.OpenDB() Then
            Application.Exit()
        End If

        Dim strSp As String = "dbo.sp_getMember"
        ModDB.objSQLCommand.Parameters.Clear()
        ModDB.objSQLCommand.CommandType = CommandType.StoredProcedure

        sqlDA = myDB.GetDataAdapterBySp(strSp, Nothing)
        dt = New DataTable
        sqlDA.Fill(dt)
        dgrMembers.DataSource = dt
        dgrMembers.AutoGenerateColumns = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
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
End Class