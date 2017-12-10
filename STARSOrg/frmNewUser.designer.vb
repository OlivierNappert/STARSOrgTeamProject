<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.tbxPass = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnConfirm = New System.Windows.Forms.Button()
		Me.tbxUser = New System.Windows.Forms.TextBox()
		Me.tbxMemberID = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.cboSecurityPriv = New System.Windows.Forms.ComboBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 259)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(91, 13)
		Me.Label4.TabIndex = 29
		Me.Label4.Text = "Security Privilege:"
		'
		'tbxPass
		'
		Me.tbxPass.Location = New System.Drawing.Point(15, 235)
		Me.tbxPass.Name = "tbxPass"
		Me.tbxPass.Size = New System.Drawing.Size(181, 20)
		Me.tbxPass.TabIndex = 28
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 219)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(56, 13)
		Me.Label3.TabIndex = 27
		Me.Label3.Text = "Password:"
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(121, 317)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 25
		Me.btnCancel.Text = "Exit"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(40, 317)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
		Me.btnConfirm.TabIndex = 24
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseVisualStyleBackColor = True
		'
		'tbxUser
		'
		Me.tbxUser.Location = New System.Drawing.Point(15, 192)
		Me.tbxUser.Name = "tbxUser"
		Me.tbxUser.Size = New System.Drawing.Size(181, 20)
		Me.tbxUser.TabIndex = 23
		'
		'tbxMemberID
		'
		Me.tbxMemberID.Location = New System.Drawing.Point(15, 149)
		Me.tbxMemberID.Name = "tbxMemberID"
		Me.tbxMemberID.Size = New System.Drawing.Size(181, 20)
		Me.tbxMemberID.TabIndex = 22
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 176)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(58, 13)
		Me.Label2.TabIndex = 21
		Me.Label2.Text = "Username:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 133)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(62, 13)
		Me.Label1.TabIndex = 20
		Me.Label1.Text = "Member ID:"
		'
		'PictureBox1
		'
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.Image = Global.STARSOrg.My.Resources.Resources.STARS_National_LOGO
		Me.PictureBox1.Location = New System.Drawing.Point(40, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(129, 109)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 26
		Me.PictureBox1.TabStop = False
		'
		'cboSecurityPriv
		'
		Me.cboSecurityPriv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSecurityPriv.FormattingEnabled = True
		Me.cboSecurityPriv.Items.AddRange(New Object() {"MEMBER", "OFFICER", "ADMIN"})
		Me.cboSecurityPriv.Location = New System.Drawing.Point(15, 276)
		Me.cboSecurityPriv.Name = "cboSecurityPriv"
		Me.cboSecurityPriv.Size = New System.Drawing.Size(181, 21)
		Me.cboSecurityPriv.TabIndex = 30
		'
		'frmNewUser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(209, 354)
		Me.Controls.Add(Me.cboSecurityPriv)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.tbxPass)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.tbxUser)
		Me.Controls.Add(Me.tbxMemberID)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmNewUser"
		Me.Text = "New User"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label4 As Label
    Friend WithEvents tbxPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents tbxMemberID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSecurityPriv As ComboBox
End Class
