<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembersReport
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
        Me.components = New System.ComponentModel.Container()
        Me.MEMBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataSetMembers = New STARSOrg.dataSetMembers()
        Me.MEMBERTableAdapter = New STARSOrg.dataSetMembersTableAdapters.MEMBERTableAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstReport = New System.Windows.Forms.ListView()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSetMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEMBERBindingSource
        '
        Me.MEMBERBindingSource.DataMember = "MEMBER"
        Me.MEMBERBindingSource.DataSource = Me.dataSetMembers
        '
        'dataSetMembers
        '
        Me.dataSetMembers.DataSetName = "dataSetMembers"
        Me.dataSetMembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEMBERTableAdapter
        '
        Me.MEMBERTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(841, 383)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 28)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstReport
        '
        Me.lstReport.Location = New System.Drawing.Point(10, 12)
        Me.lstReport.Name = "lstReport"
        Me.lstReport.Size = New System.Drawing.Size(942, 359)
        Me.lstReport.TabIndex = 2
        Me.lstReport.UseCompatibleStateImageBehavior = False
        '
        'frmMembersReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 420)
        Me.Controls.Add(Me.lstReport)
        Me.Controls.Add(Me.btnClose)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMembersReport"
        Me.Text = "frmMembersReport"
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSetMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MEMBERBindingSource As BindingSource
    Friend WithEvents dataSetMembers As dataSetMembers
    Friend WithEvents MEMBERTableAdapter As dataSetMembersTableAdapters.MEMBERTableAdapter
    Friend WithEvents btnClose As Button
    Friend WithEvents lstReport As ListView
End Class
