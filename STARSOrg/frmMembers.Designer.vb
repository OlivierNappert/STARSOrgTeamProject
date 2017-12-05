<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMembers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvents = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpEdit = New System.Windows.Forms.GroupBox()
        Me.ptbPhoto = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpMemberList = New System.Windows.Forms.GroupBox()
        Me.dgrMembers = New System.Windows.Forms.DataGridView()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ofdOpenPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.cboMembers = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpEdit.SuspendLayout()
        CType(Me.ptbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMemberList.SuspendLayout()
        CType(Me.dgrMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelect.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbHome, Me.ToolStripSeparator6, Me.tsbMember, Me.ToolStripSeparator5, Me.tsbRole, Me.ToolStripSeparator2, Me.tsbEvents, Me.ToolStripSeparator3, Me.tsbRSVP, Me.ToolStripSeparator1, Me.ToolStripButton8, Me.ToolStripSeparator4, Me.tsbSemester, Me.tsbHelp, Me.ToolStripSeparator8, Me.ToolStripSeparator7, Me.tsbLogOut, Me.tsbTutor})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1031, 63)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSOrg.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSOrg.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.STARSOrg.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLES"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvents
        '
        Me.tsbEvents.AutoSize = False
        Me.tsbEvents.BackgroundImage = Global.STARSOrg.My.Resources.Resources.events
        Me.tsbEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvents.Name = "tsbEvents"
        Me.tsbEvents.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvents.Text = "EVENTS"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.BackgroundImage = Global.STARSOrg.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(23, 60)
        Me.tsbRSVP.Text = "RSVP"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.AutoSize = False
        Me.ToolStripButton8.BackgroundImage = Global.STARSOrg.My.Resources.Resources.courses
        Me.ToolStripButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButton8.Text = "COURSE"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSOrg.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSOrg.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "Help"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbLogOut
        '
        Me.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogOut.AutoSize = False
        Me.tsbLogOut.BackgroundImage = Global.STARSOrg.My.Resources.Resources.logout
        Me.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogOut.Name = "tsbLogOut"
        Me.tsbLogOut.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogOut.Text = "LOGOUT"
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSOrg.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtVal)
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Location = New System.Drawing.Point(13, 68)
        Me.grpSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSearch.Size = New System.Drawing.Size(629, 90)
        Me.grpSearch.TabIndex = 2
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(469, 41)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(152, 35)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(112, 45)
        Me.txtVal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(349, 26)
        Me.txtVal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Last name:"
        '
        'grpEdit
        '
        Me.grpEdit.Controls.Add(Me.ptbPhoto)
        Me.grpEdit.Controls.Add(Me.btnCancel)
        Me.grpEdit.Controls.Add(Me.txtMemberID)
        Me.grpEdit.Controls.Add(Me.mskPhone)
        Me.grpEdit.Controls.Add(Me.txtEmail)
        Me.grpEdit.Controls.Add(Me.txtLastName)
        Me.grpEdit.Controls.Add(Me.txtFirstName)
        Me.grpEdit.Controls.Add(Me.txtMiddleName)
        Me.grpEdit.Controls.Add(Me.Label9)
        Me.grpEdit.Controls.Add(Me.btnOpen)
        Me.grpEdit.Controls.Add(Me.Label8)
        Me.grpEdit.Controls.Add(Me.Label7)
        Me.grpEdit.Controls.Add(Me.Label6)
        Me.grpEdit.Controls.Add(Me.Label5)
        Me.grpEdit.Controls.Add(Me.Label4)
        Me.grpEdit.Controls.Add(Me.Label3)
        Me.grpEdit.Controls.Add(Me.btnSave)
        Me.grpEdit.Location = New System.Drawing.Point(650, 68)
        Me.grpEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpEdit.Size = New System.Drawing.Size(368, 657)
        Me.grpEdit.TabIndex = 3
        Me.grpEdit.TabStop = False
        Me.grpEdit.Text = "Edit Members"
        '
        'ptbPhoto
        '
        Me.ptbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbPhoto.InitialImage = Nothing
        Me.ptbPhoto.Location = New System.Drawing.Point(209, 361)
        Me.ptbPhoto.Name = "ptbPhoto"
        Me.ptbPhoto.Size = New System.Drawing.Size(149, 170)
        Me.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbPhoto.TabIndex = 25
        Me.ptbPhoto.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(209, 604)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(152, 43)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(141, 34)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(220, 26)
        Me.txtMemberID.TabIndex = 23
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(141, 304)
        Me.mskPhone.Mask = "(000)000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(220, 26)
        Me.mskPhone.TabIndex = 22
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(141, 250)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(220, 26)
        Me.txtEmail.TabIndex = 21
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(141, 196)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(220, 26)
        Me.txtLastName.TabIndex = 20
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(141, 88)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(220, 26)
        Me.txtFirstName.TabIndex = 18
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(141, 142)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(220, 26)
        Me.txtMiddleName.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 361)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Photo:"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(16, 498)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(140, 33)
        Me.btnOpen.TabIndex = 7
        Me.btnOpen.Text = "Open..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Phone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Middle Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Member ID:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(13, 604)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 43)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpMemberList
        '
        Me.grpMemberList.Controls.Add(Me.dgrMembers)
        Me.grpMemberList.Location = New System.Drawing.Point(13, 245)
        Me.grpMemberList.Name = "grpMemberList"
        Me.grpMemberList.Size = New System.Drawing.Size(629, 480)
        Me.grpMemberList.TabIndex = 4
        Me.grpMemberList.TabStop = False
        Me.grpMemberList.Text = "Member list"
        '
        'dgrMembers
        '
        Me.dgrMembers.AllowUserToAddRows = False
        Me.dgrMembers.AllowUserToDeleteRows = False
        Me.dgrMembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgrMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrMembers.Location = New System.Drawing.Point(7, 26)
        Me.dgrMembers.Name = "dgrMembers"
        Me.dgrMembers.ReadOnly = True
        Me.dgrMembers.RowTemplate.Height = 28
        Me.dgrMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrMembers.Size = New System.Drawing.Size(614, 444)
        Me.dgrMembers.TabIndex = 0
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(859, 734)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 43)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ofdOpenPhoto
        '
        Me.ofdOpenPhoto.FileName = "OpenFileDialog1"
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.cboMembers)
        Me.grpSelect.Controls.Add(Me.Label1)
        Me.grpSelect.Location = New System.Drawing.Point(13, 168)
        Me.grpSelect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSelect.Size = New System.Drawing.Size(440, 64)
        Me.grpSelect.TabIndex = 7
        Me.grpSelect.TabStop = False
        Me.grpSelect.Text = "Select member by ID"
        '
        'cboMembers
        '
        Me.cboMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMembers.FormattingEnabled = True
        Me.cboMembers.Location = New System.Drawing.Point(225, 24)
        Me.cboMembers.Name = "cboMembers"
        Me.cboMembers.Size = New System.Drawing.Size(205, 28)
        Me.cboMembers.Sorted = True
        Me.cboMembers.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose member to update:"
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.chkNew)
        Me.grpNew.Location = New System.Drawing.Point(461, 168)
        Me.grpNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpNew.Size = New System.Drawing.Size(181, 64)
        Me.grpNew.TabIndex = 8
        Me.grpNew.TabStop = False
        Me.grpNew.Text = "Add member"
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(7, 27)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(159, 24)
        Me.chkNew.TabIndex = 1
        Me.chkNew.Text = "Add new member"
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 782)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1031, 30)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(180, 25)
        Me.sslStatus.Text = "ToolStripStatusLabel1"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(662, 735)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 43)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(13, 735)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(152, 43)
        Me.btnReport.TabIndex = 19
        Me.btnReport.Text = "Make report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 812)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.grpSelect)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpMemberList)
        Me.Controls.Add(Me.grpEdit)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership Management"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        CType(Me.ptbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMemberList.ResumeLayout(False)
        CType(Me.dgrMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelect.ResumeLayout(False)
        Me.grpSelect.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbEvents As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtVal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpEdit As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents grpMemberList As GroupBox
    Friend WithEvents dgrMembers As DataGridView
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents btnClose As Button
    Friend WithEvents ofdOpenPhoto As OpenFileDialog
    Friend WithEvents grpSelect As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMembers As ComboBox
    Friend WithEvents grpNew As GroupBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslStatus As ToolStripStatusLabel
    Friend WithEvents btnClear As Button
    Friend WithEvents ptbPhoto As PictureBox
    Friend WithEvents btnReport As Button
End Class
