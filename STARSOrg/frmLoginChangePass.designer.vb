<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginChangePass
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
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnConfirm = New System.Windows.Forms.Button()
		Me.tbxOldPass = New System.Windows.Forms.TextBox()
		Me.tbxUser = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tbxNewPass = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.tbxConfirmNewPass = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(117, 317)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 14
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(36, 317)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
		Me.btnConfirm.TabIndex = 13
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseVisualStyleBackColor = True
		'
		'tbxOldPass
		'
		Me.tbxOldPass.Location = New System.Drawing.Point(11, 192)
		Me.tbxOldPass.Name = "tbxOldPass"
		Me.tbxOldPass.Size = New System.Drawing.Size(181, 20)
		Me.tbxOldPass.TabIndex = 12
		Me.tbxOldPass.UseSystemPasswordChar = True
		'
		'tbxUser
		'
		Me.tbxUser.Location = New System.Drawing.Point(11, 149)
		Me.tbxUser.Name = "tbxUser"
		Me.tbxUser.Size = New System.Drawing.Size(181, 20)
		Me.tbxUser.TabIndex = 11
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 176)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(75, 13)
		Me.Label2.TabIndex = 10
		Me.Label2.Text = "Old Password:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 133)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(58, 13)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "Username:"
		'
		'tbxNewPass
		'
		Me.tbxNewPass.Location = New System.Drawing.Point(11, 235)
		Me.tbxNewPass.Name = "tbxNewPass"
		Me.tbxNewPass.Size = New System.Drawing.Size(181, 20)
		Me.tbxNewPass.TabIndex = 17
		Me.tbxNewPass.UseSystemPasswordChar = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(8, 219)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(81, 13)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "New Password:"
		'
		'tbxConfirmNewPass
		'
		Me.tbxConfirmNewPass.Location = New System.Drawing.Point(11, 275)
		Me.tbxConfirmNewPass.Name = "tbxConfirmNewPass"
		Me.tbxConfirmNewPass.Size = New System.Drawing.Size(181, 20)
		Me.tbxConfirmNewPass.TabIndex = 19
		Me.tbxConfirmNewPass.UseSystemPasswordChar = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(8, 259)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(94, 13)
		Me.Label4.TabIndex = 18
		Me.Label4.Text = "Confirm Password:"
		'
		'PictureBox1
		'
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.Image = Global.STARSOrg.My.Resources.Resources.STARS_National_LOGO
		Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(129, 109)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 15
		Me.PictureBox1.TabStop = False
		'
		'frmLoginChangePass
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(207, 352)
		Me.Controls.Add(Me.tbxConfirmNewPass)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.tbxNewPass)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.tbxOldPass)
		Me.Controls.Add(Me.tbxUser)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmLoginChangePass"
		Me.Text = "Change Password"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnConfirm As Button
	Friend WithEvents tbxOldPass As TextBox
	Friend WithEvents tbxUser As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents tbxNewPass As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents tbxConfirmNewPass As TextBox
	Friend WithEvents Label4 As Label
End Class
