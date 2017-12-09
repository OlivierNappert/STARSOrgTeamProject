Imports System.Data.SqlClient
Public Class frmEventManager

    Private objEvents As CEvents
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private blnLoading As Boolean


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

    Private Sub frmEventManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        objEvents = New CEvents
    End Sub

    Private Sub frmEventManager_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadData()

    End Sub

    Private Sub LoadData()
        Dim objReader As SqlDataReader
        blnLoading = True



        If ModDB.objSQLCommand Is Nothing Then
            ModDB.objSQLCommand = New SqlCommand
        Else
            ModDB.objSQLCommand.Parameters.Clear()
        End If

        ModDB.objSQLCommand.CommandType = CommandType.StoredProcedure

        sqlDA = myDB.GetDataAdapterBySp("dbo.sp_getAllEvents", Nothing)

        dt = New DataTable
        sqlDA.Fill(dt)

        dgrEvent.DataSource = dt
        dgrEvent.AutoGenerateColumns = True
        dgrEvent.Rows(0).Cells(0).Selected = False

        objReader = objEvents.GetAllEvents()


        objReader.Close()
        blnLoading = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtEndDate.Clear()
        txtEventID.Clear()
        txtEventDescription.Clear()
        txtEventTypeID.Clear()
        txtLocation.Clear()
        txtSemesterID.Clear()
        txtStartDate.Clear()

        Me.Hide()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        sslStatus.Text = ""
        errP.Clear()

        If Not modErrHandler.ValidateTextBoxLength(txtEventID, errP) Then
            blnErrors = True
        ElseIf txtEventID.TextLength <> 4 Then
            errP.SetError(txtEventID, "Error, this field must be exactly 4 digits long.")
        ElseIf Not IsNumeric(txtEventID.Text) Then
            errP.SetError(txtEventID, "Error, the value you inputed is not numeric.")
        ElseIf txtEventTypeID.TextLength <> 15 Then
            errP.SetError(txtEventTypeID, "Error, this field must be exactly 15 digits long.")
        ElseIf Not IsNumeric(txtEventTypeID.Text) Then
            errP.SetError(txtEventTypeID, "Error, the value you inputed is not numeric.")
        ElseIf txtSemesterID.TextLength <> 4 Then
            errP.SetError(txtSemesterID, "Error, this field must be exactly 4 digits long.")
        ElseIf Not IsNumeric(txtSemesterID.Text) Then
            errP.SetError(txtSemesterID, "Error, the value you inputed is not numeric.")

        End If

        If Not modErrHandler.ValidateTextBoxLength(txtEventDescription, errP) Then
            blnErrors = True
        End If
        For Each character In txtLocation.Text
            If IsNumeric(character) Then
                errP.SetError(txtLocation, "Error, you cannot put digits here.")
                blnErrors = True
                Exit For
            End If
        Next



        'if we get this far, all of the input data is acceptable
        With objEvents.CurrentObject
            .EventID = txtEventID.Text
            .EventDescription = txtEventDescription.Text
            .EventTypeID = txtEventTypeID.Text
            .SemesterID = txtSemesterID.Text
            .StartDate = txtStartDate.Text
            .EndDate = txtEndDate.Text
            .Location = txtLocation.Text


        End With

        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    intResult = objEvents.Save()
        '    If intResult = 1 Then
        '        sslStatus.Text = "Member record saved"
        '    End If
        '    If intResult = -1 Then 'Member ID was not unique
        '        'messagebox role ID must be unique unable to save this record, warning
        '        MessageBox.Show("Error Event ID already exists in the database, must be a unique identifier", "Warning")
        '        sslStatus.Text = "Error"
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error unable to save member in frmEventManager:btnAdd_Click" & ex.ToString(), "Error")
        'End Try
        Me.Cursor = Cursors.Default
        LoadData()
        grpEdit.Enabled = True
    End Sub
End Class