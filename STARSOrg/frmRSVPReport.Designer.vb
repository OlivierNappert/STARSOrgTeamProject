<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRSVPReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MEMBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataSetMembers = New STARSOrg.dataSetMembers()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MEMBERTableAdapter = New STARSOrg.dataSetMembersTableAdapters.MEMBERTableAdapter()
        Me.rptEvents = New Microsoft.Reporting.WinForms.ReportViewer()
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
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(673, 390)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MEMBERTableAdapter
        '
        Me.MEMBERTableAdapter.ClearBeforeFill = True
        '
        'rptEvents
        '
        ReportDataSource1.Name = "dataSetMembers"
        ReportDataSource1.Value = Me.MEMBERBindingSource
        Me.rptEvents.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptEvents.Location = New System.Drawing.Point(12, 12)
        Me.rptEvents.Name = "rptEvents"
        Me.rptEvents.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rptEvents.ServerReport.BearerToken = Nothing
        Me.rptEvents.ServerReport.ReportPath = "DataSetEvents.xsd"
        Me.rptEvents.ServerReport.ReportServerUrl = New System.Uri("C:\Users\Shade\source\repos\STARSOrgTeamProject3\STARSOrg\DataSetEvents.xsd", System.UriKind.Absolute)
        Me.rptEvents.Size = New System.Drawing.Size(758, 373)
        Me.rptEvents.TabIndex = 4
        '
        'frmRSVPReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 426)
        Me.Controls.Add(Me.rptEvents)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmRSVPReport"
        Me.Text = "frmRSVPReport"
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSetMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents MEMBERBindingSource As BindingSource
    Friend WithEvents dataSetMembers As dataSetMembers
    Friend WithEvents MEMBERTableAdapter As dataSetMembersTableAdapters.MEMBERTableAdapter
    Friend WithEvents rptEvents As Microsoft.Reporting.WinForms.ReportViewer
End Class
