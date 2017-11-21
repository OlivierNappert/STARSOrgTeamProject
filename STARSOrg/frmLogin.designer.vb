<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lklChngPass = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(10, 149)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(181, 20)
        Me.tbxUser.TabIndex = 2
        '
        'tbxPass
        '
        Me.tbxPass.Location = New System.Drawing.Point(10, 192)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.Size = New System.Drawing.Size(181, 20)
        Me.tbxPass.TabIndex = 3
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(35, 246)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 23)
        Me.btnLog.TabIndex = 4
        Me.btnLog.Text = "Login"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(116, 246)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lklChngPass
        '
        Me.lklChngPass.AutoSize = True
        Me.lklChngPass.Location = New System.Drawing.Point(7, 215)
        Me.lklChngPass.Name = "lklChngPass"
        Me.lklChngPass.Size = New System.Drawing.Size(93, 13)
        Me.lklChngPass.TabIndex = 8
        Me.lklChngPass.TabStop = True
        Me.lklChngPass.Text = "Change Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.STARSOrg.My.Resources.Resources.STARS_National_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(38, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 284)
        Me.Controls.Add(Me.lklChngPass)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.tbxPass)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents tbxPass As TextBox
    Friend WithEvents btnLog As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lklChngPass As LinkLabel
End Class
