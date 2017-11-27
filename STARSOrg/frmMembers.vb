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
        If ModDB.objSQLConn.State = ConnectionState.Open Then
            myDB.CloseDB()
        End If
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim blnErrors As Boolean = False
        Dim params As New ArrayList

        If txtVal.Text.Length = 0 Then
            errP.SetError(txtVal, "You must enter a search value here")
            blnErrors = True
        End If

        If blnErrors Then
            Exit Sub
        End If

        Dim strParam As String = "@lastName"
        Dim strSp As String = "dbo.sp_searchMember"

        params.Add(New SqlParameter(strParam, txtVal.Text))
        sqlDA = myDB.GetDataAdapterBySp(strSp, params)

        dt = New DataTable
        sqlDA.Fill(dt)
        dgrMembers.DataSource = dt
        dgrMembers.AutoGenerateColumns = True
    End Sub
End Class