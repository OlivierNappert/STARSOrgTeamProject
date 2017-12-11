<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMemberRoles
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.grpRoles = New System.Windows.Forms.GroupBox()
        Me.cmb_Year = New System.Windows.Forms.ComboBox()
        Me.cmb_Semester = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clb_MemberRoles = New System.Windows.Forms.CheckedListBox()
        Me.MEMBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetMembers = New STARSOrg.dataSetMembers()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MEMBERTableAdapter = New STARSOrg.dataSetMembersTableAdapters.MEMBERTableAdapter()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNoAccess = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.grpRoles.SuspendLayout()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbHome, Me.ToolStripSeparator6, Me.tsbMember, Me.ToolStripSeparator5, Me.tsbRole, Me.ToolStripSeparator2, Me.tsbEvents, Me.ToolStripSeparator3, Me.tsbRSVP, Me.ToolStripSeparator1, Me.ToolStripButton8, Me.ToolStripSeparator4, Me.ToolStripButton1, Me.ToolStripSeparator8, Me.tsbTutor, Me.tsbHelp, Me.ToolStripSeparator7, Me.tsbLogOut})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(665, 50)
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
        Me.tsbMember.Text = "HOME"
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
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.STARSOrg.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackgroundImage = Global.STARSOrg.My.Resources.Resources.semesters
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButton1.Text = "SEMESTER"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(507, 566)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 48)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Produce Formatted Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 67)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "FIU STARS Organization Members"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(336, 566)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(139, 48)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove Role"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(169, 566)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(139, 48)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add Role..."
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.chkNew)
        Me.grpNew.Location = New System.Drawing.Point(12, 76)
        Me.grpNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpNew.Size = New System.Drawing.Size(133, 95)
        Me.grpNew.TabIndex = 13
        Me.grpNew.TabStop = False
        Me.grpNew.Text = "New Role"
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(5, 36)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(119, 21)
        Me.chkNew.TabIndex = 0
        Me.chkNew.Text = "Add New Role"
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'grpRoles
        '
        Me.grpRoles.Controls.Add(Me.btnNoAccess)
        Me.grpRoles.Controls.Add(Me.cmb_Year)
        Me.grpRoles.Controls.Add(Me.cmb_Semester)
        Me.grpRoles.Controls.Add(Me.Label3)
        Me.grpRoles.Controls.Add(Me.clb_MemberRoles)
        Me.grpRoles.Location = New System.Drawing.Point(12, 182)
        Me.grpRoles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRoles.Name = "grpRoles"
        Me.grpRoles.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRoles.Size = New System.Drawing.Size(277, 341)
        Me.grpRoles.TabIndex = 14
        Me.grpRoles.TabStop = False
        Me.grpRoles.Text = "Roles"
        '
        'cmb_Year
        '
        Me.cmb_Year.FormattingEnabled = True
        Me.cmb_Year.Items.AddRange(New Object() {"2017", "2018"})
        Me.cmb_Year.Location = New System.Drawing.Point(157, 130)
        Me.cmb_Year.Name = "cmb_Year"
        Me.cmb_Year.Size = New System.Drawing.Size(67, 24)
        Me.cmb_Year.TabIndex = 19
        '
        'cmb_Semester
        '
        Me.cmb_Semester.FormattingEnabled = True
        Me.cmb_Semester.Items.AddRange(New Object() {"Fall", "Spring"})
        Me.cmb_Semester.Location = New System.Drawing.Point(9, 130)
        Me.cmb_Semester.Name = "cmb_Semester"
        Me.cmb_Semester.Size = New System.Drawing.Size(121, 24)
        Me.cmb_Semester.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Semester"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'clb_MemberRoles
        '
        Me.clb_MemberRoles.FormattingEnabled = True
        Me.clb_MemberRoles.Items.AddRange(New Object() {"Admin", "Officer", "Tutor", "Member"})
        Me.clb_MemberRoles.Location = New System.Drawing.Point(6, 25)
        Me.clb_MemberRoles.Name = "clb_MemberRoles"
        Me.clb_MemberRoles.Size = New System.Drawing.Size(253, 72)
        Me.clb_MemberRoles.TabIndex = 0
        '
        'MEMBERBindingSource
        '
        Me.MEMBERBindingSource.DataMember = "MEMBER"
        Me.MEMBERBindingSource.DataSource = Me.DataSetMembers
        '
        'DataSetMembers
        '
        Me.DataSetMembers.DataSetName = "dataSetMembers"
        Me.DataSetMembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Members"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 636)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(665, 25)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(153, 20)
        Me.sslStatus.Text = "ToolStripStatusLabel1"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'MEMBERTableAdapter
        '
        Me.MEMBERTableAdapter.ClearBeforeFill = True
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 16
        Me.lstMembers.Location = New System.Drawing.Point(15, 42)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(313, 276)
        Me.lstMembers.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMembers)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(304, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 332)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnNoAccess
        '
        Me.btnNoAccess.Location = New System.Drawing.Point(3, 24)
        Me.btnNoAccess.Name = "btnNoAccess"
        Me.btnNoAccess.Size = New System.Drawing.Size(25, 72)
        Me.btnNoAccess.TabIndex = 20
        Me.btnNoAccess.UseVisualStyleBackColor = True
        '
        'frmMemberRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpRoles)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMemberRoles"
        Me.Text = "frmRoles"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.grpRoles.ResumeLayout(False)
        Me.grpRoles.PerformLayout()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpNew As GroupBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents grpRoles As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslStatus As ToolStripStatusLabel
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents clb_MemberRoles As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSetMembers As dataSetMembers
    Friend WithEvents MEMBERBindingSource As BindingSource
    Friend WithEvents MEMBERTableAdapter As dataSetMembersTableAdapters.MEMBERTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstMembers As ListBox
    Friend WithEvents cmb_Year As ComboBox
    Friend WithEvents cmb_Semester As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNoAccess As Button
End Class
