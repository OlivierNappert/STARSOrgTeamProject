Imports System.Data.SqlClient

Public Class cAudits
    'Represents the SECURITY table and its associate business rules
    Private _Audit As cAudit
    'constructor

    Public Sub New()
        'insantiate the cSecurity object
        _Audit = New cAudit
    End Sub

    Public ReadOnly Property CurrentObject() As cAudit
        Get
            Return _Audit
        End Get
    End Property

    Public Sub Clear()
        _Audit = New cAudit
    End Sub
    Public Sub CreateNewAudit()
        'call this routine when clearing the edit portion of the screen to add a new security
        Clear()
        _Audit.IsNewAudit = True
    End Sub
    Public Function Save() As Integer
        Return _Audit.Save
    End Function
End Class
