Imports System.Data.SqlClient

Public Class frmMembers

    Private objMembers As cMembers
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private photoPath As String
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


    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objMembers = New cMembers
    End Sub

    Private Sub frmMembers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadData()
        photoPath = Nothing
        grpEdit.Enabled = False
        errP.Clear()
        sslStatus.Text = ""
    End Sub

    Private Sub LoadData()
        Dim objReader As SqlDataReader
        blnLoading = True

        cboMembers.Items.Clear()

        If ModDB.objSQLCommand Is Nothing Then
            ModDB.objSQLCommand = New SqlCommand
        Else
            ModDB.objSQLCommand.Parameters.Clear()
        End If

        ModDB.objSQLCommand.CommandType = CommandType.StoredProcedure

        sqlDA = myDB.GetDataAdapterBySp("dbo.sp_getAllMembers", Nothing)

        dt = New DataTable
        sqlDA.Fill(dt)

        dgrMembers.DataSource = dt
        dgrMembers.AutoGenerateColumns = True
        dgrMembers.Rows(0).Cells(0).Selected = False

        objReader = objMembers.GetAllMembers()

        Try
            Do While objReader.Read()
                cboMembers.Items.Add(objReader.Item("ID"))
            Loop

        Catch ex As Exception
            MessageBox.Show("Error in frmMembers:LoadData", "Error")
        End Try
        objReader.Close()
        blnLoading = False
    End Sub

    Private Sub LoadSelectedMember()
        Try
            objMembers.GetMemberById(cboMembers.SelectedItem.ToString)
            With objMembers.CurrentObject
                txtMemberID.Text = .PID
                txtFirstName.Text = .FName
                txtMiddleName.Text = .ML
                txtLastName.Text = .LNAME
                txtEmail.Text = .Email
                mskPhone.Text = .Phone
                photoPath = .PhotoPath
                If photoPath IsNot Nothing And photoPath <> "" Then
                    ptbPhoto.Image = Image.FromFile(photoPath)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading member in frmMembers:LoadSelectedMember", "Error")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim blnErrors As Boolean = False
        Dim params As New ArrayList
        Dim objReader As SqlDataReader
        Dim strParam As String = "@lastName"
        Dim strSp As String = "dbo.sp_searchMember"

        errP.Clear()

        If txtVal.Text.Length = 0 Then
            errP.SetError(txtVal, "You must enter a search value here")
            blnErrors = True
        End If

        For Each character In txtVal.Text
            If IsNumeric(character) Then
                errP.SetError(txtVal, "Error, you cannot put digits in this field, last names are letters only.")
                blnErrors = True
            End If
        Next

        If blnErrors Then
            Exit Sub
        End If


        params.Add(New SqlParameter(strParam, txtVal.Text))
        sqlDA = myDB.GetDataAdapterBySp(strSp, params)

        dt = New DataTable
        sqlDA.Fill(dt)
        dgrMembers.DataSource = dt
        dgrMembers.AutoGenerateColumns = True


        cboMembers.Items.Clear()
        objReader = objMembers.GetMembersWithLastName(txtVal.Text)

        Try
            Do While objReader.Read()
                cboMembers.Items.Add(objReader.Item("ID"))
            Loop

        Catch ex As Exception
            MessageBox.Show("Error in frmMembers:btnSearch_Click", "Error")
        End Try
        objReader.Close()
    End Sub

    Private Sub chkNew_CheckStateChanged(sender As Object, e As EventArgs) Handles chkNew.CheckStateChanged
        If chkNew.Checked Then
            txtMemberID.Clear()
            txtFirstName.Clear()
            txtMiddleName.Text = Nothing
            txtLastName.Clear()
            txtEmail.Clear()
            mskPhone.Text = Nothing
            photoPath = Nothing
            grpEdit.Enabled = True
            grpSelect.Enabled = False
            cboMembers.SelectedIndex = -1
            objMembers.CreateNewMember()
            sslStatus.Text = ""
        Else
            grpSelect.Enabled = True
            grpEdit.Enabled = False
            objMembers.CurrentObject.IsNewMember = False
        End If
    End Sub

    Private Sub cboMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMembers.SelectedIndexChanged
        If cboMembers.SelectedIndex = -1 Then
            Exit Sub
        End If
        ptbPhoto.Image = Nothing
        chkNew.Checked = False
        LoadSelectedMember()
        grpEdit.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        photoPath = Nothing
        grpEdit.Enabled = False
        chkNew.Checked = False
        txtMemberID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Text = Nothing
        txtLastName.Clear()
        txtEmail.Clear()
        mskPhone.Text = Nothing
        photoPath = Nothing
        grpEdit.Enabled = False
        cboMembers.Enabled = True
        cboMembers.SelectedIndex = -1
        sslStatus.Text = ""
        errP.Clear()
        Me.Hide()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        ofdOpenPhoto.FilterIndex = 1
        ofdOpenPhoto.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*"
        ofdOpenPhoto.InitialDirectory = Application.StartupPath '/bin/debug
        Dim intResult As Integer = ofdOpenPhoto.ShowDialog()

        If intResult = DialogResult.Cancel Then
            Exit Sub
        End If

        photoPath = ofdOpenPhoto.FileName
        ptbPhoto.Image = Image.FromFile(photoPath)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        chkNew.Checked = False
        txtMemberID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Text = Nothing
        txtLastName.Clear()
        txtEmail.Clear()
        mskPhone.Text = Nothing
        photoPath = Nothing
        grpEdit.Enabled = False
        cboMembers.Enabled = True
        cboMembers.SelectedIndex = -1
        sslStatus.Text = ""
        errP.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        sslStatus.Text = ""
        errP.Clear()

        If Not modErrHandler.ValidateTextBoxLength(txtMemberID, errP) Then
            blnErrors = True
        ElseIf txtMemberID.TextLength <> 7 Then
            errP.SetError(txtMemberID, "Error, this field must be exactly 7 digits long.")
        ElseIf Not IsNumeric(txtMemberID.Text) Then
            errP.SetError(txtMemberID, "Error, the value you inputed is not numeric.")
        End If

        If Not modErrHandler.ValidateTextBoxLength(txtFirstName, errP) Then
            blnErrors = True
        End If
        For Each character In txtFirstName.Text
            If IsNumeric(character) Then
                errP.SetError(txtMiddleName, "Error, you cannot put digits here.")
                blnErrors = True
                Exit For
            End If
        Next

        errP.SetIconAlignment(txtMiddleName, ErrorIconAlignment.MiddleLeft)
        If txtMiddleName.TextLength > 0 And txtMiddleName.TextLength <> 1 Then
            errP.SetError(txtMiddleName, "Error, you can only input a single character here.")
            blnErrors = True
        ElseIf IsNumeric(txtMiddleName.Text) Then
            errP.SetError(txtMiddleName, "Error, you cannot put a digit here.")
            blnErrors = True
        End If

        If Not modErrHandler.ValidateTextBoxLength(txtLastName, errP) Then
            blnErrors = True
        End If
        For Each character In txtLastName.Text
            If IsNumeric(character) Then
                errP.SetError(txtMiddleName, "Error, you cannot put digits here.")
                blnErrors = True
                Exit For
            End If
        Next
        If Not modErrHandler.ValidateTextBoxLength(txtEmail, errP) Then
            blnErrors = True
        End If

        If blnErrors Then
            Exit Sub
        End If
        'if we get this far, all of the input data is acceptable
        With objMembers.CurrentObject
            .PID = txtMemberID.Text
            .FName = txtFirstName.Text
            .ML = txtMiddleName.Text
            .LNAME = txtLastName.Text
            .Email = txtEmail.Text
            .Phone = mskPhone.Text
            If photoPath IsNot Nothing Then
                .PhotoPath = photoPath
            Else
                .PhotoPath = ""
            End If
        End With

        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objMembers.Save()
            If intResult = 1 Then
                sslStatus.Text = "Member record saved"
            End If
            If intResult = -1 Then 'Member ID was not unique
                'messagebox role ID must be unique unable to save this record, warning
                MessageBox.Show("Error Member ID already exists in the database, must be a unique identifier", "Warning")
                sslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Error unable to save member in frmMembers:btnSave_Click" & ex.ToString(), "Error")
        End Try
        Me.Cursor = Cursors.Default
        LoadData()
        chkNew.Checked = False
        grpSelect.Enabled = True 'in case it was disabled for a new record
        grpEdit.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        LoadData()
        txtVal.Text = ""
        chkNew.Checked = False
        txtMemberID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Text = Nothing
        txtLastName.Clear()
        txtEmail.Clear()
        mskPhone.Text = Nothing
        photoPath = Nothing
        grpEdit.Enabled = False
        cboMembers.Enabled = True
        cboMembers.SelectedIndex = -1
        sslStatus.Text = ""
        errP.Clear()
    End Sub

    Private Sub dgrMembers_SelectionChanged(sender As Object, e As EventArgs) Handles dgrMembers.SelectionChanged
        If blnLoading Then
            Exit Sub
        End If

        Dim dgv = CType(sender, DataGridView)
        If dgv Is Nothing Then
            Exit Sub
        End If

        ptbPhoto.Image = Nothing
        chkNew.Checked = False

        If dgv.CurrentRow.Selected Then
            Try
                objMembers.GetMemberById(dgv.CurrentRow.Cells("ID").Value.ToString())
                With objMembers.CurrentObject
                    txtMemberID.Text = .PID
                    txtFirstName.Text = .FName
                    txtMiddleName.Text = .ML
                    txtLastName.Text = .LNAME
                    txtEmail.Text = .Email
                    mskPhone.Text = .Phone
                    photoPath = .PhotoPath
                    If photoPath IsNot Nothing And photoPath <> "" Then
                        ptbPhoto.Image = Image.FromFile(photoPath)
                    End If
                End With
                grpEdit.Enabled = True
                grpNew.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Error loading member in frmMembers:LoadSelectedMember", "Error")
            End Try
        End If
    End Sub
End Class