Imports System.Data.SqlClient

Public Class frmEventRSVP

    Private objRSVPs As CEventRSVPs
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private blnLoading As Boolean
    Private Sub frmEventRSVP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objRSVPs = New CEventRSVPs
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


    Private Sub LoadData()
        Dim objReader As SqlDataReader
        blnLoading = True



        If ModDB.objSQLCommand Is Nothing Then
            ModDB.objSQLCommand = New SqlCommand
        Else
            ModDB.objSQLCommand.Parameters.Clear()
        End If

        ModDB.objSQLCommand.CommandType = CommandType.StoredProcedure

        sqlDA = myDB.GetDataAdapterBySp("dbo.GetAllEventRSVPs", Nothing)

        dt = New DataTable
        sqlDA.Fill(dt)

        dgrEventRSVP.DataSource = dt
        dgrEventRSVP.AutoGenerateColumns = True
        dgrEventRSVP.Rows(0).Cells(0).Selected = False

        objReader = objRSVPs.GetAllEventRSVPs()


        objReader.Close()
        blnLoading = False
    End Sub

    Private Sub frmEventRSVP_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        txtEmail.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
		'txtMiddleName.Clear()


		Me.Hide()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        sslStatus.Text = ""
        errP.Clear()

        If Not modErrHandler.ValidateTextBoxLength(txtEventID, errP) Then
            blnErrors = True

        ElseIf txtEventID.TextLength <> 15 Then
            errP.SetError(txtEventID, "Error, this field must be exactly 4 digits long.")
        ElseIf Not IsNumeric(txtEventID.Text) Then
            errP.SetError(txtEventID, "Error, the value you inputed is not numeric.")


        End If

        If Not modErrHandler.ValidateTextBoxLength(txtEmail, errP) Then
            blnErrors = True
        End If



        'if we get this far, all of the input data is acceptable
        With objRSVPs.CurrentObject
            '.EventID = txtEventID.Text
            .Email = txtEmail.Text
            .FName = txtFirstName.Text
            .LName = txtLastName.Text
            .EventID = txtEventID.Text



        End With

        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objRSVPs.Save()
            If intResult = 1 Then
                sslStatus.Text = "Member record saved"
            End If
            If intResult = -1 Then 'Member ID was not unique
                'MessageBox Event ID must be unique unable to save this record, warning
                MessageBox.Show("Error Event ID already exists in the database, must be a unique identifier", "Warning")
                sslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Error unable to save member in frmEventManager:btnAdd_Click" & ex.ToString(), "Error")
        End Try
        Me.Cursor = Cursors.Default
        LoadData()
        grpAddRSVP.Enabled = True
    End Sub
End Class