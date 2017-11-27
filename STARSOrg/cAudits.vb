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

    Public Function GetAllAudit() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllAudit", Nothing)
    End Function

    Public Function GetAuditByukid(strID As String) As cAudit
        Dim params As New ArrayList
        params.Add(New SqlParameter("ukid", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getAuditByukid", params))
        Return _Audit
    End Function

    Private Function FillObject(sqldr As SqlDataReader) As cAudit
        Using sqldr
            If sqldr.Read() Then 'found the Audit record
                With _Audit
                    .ukid = sqldr.Item("ukid") & ""
                    .PID = sqldr.Item("PID") & ""
                    .ACCESSTIMESTAMP = sqldr.Item("ACCESSTIMESTAMP") & ""
                    .SUCCESS = sqldr.Item("SUCCESS") & ""
                End With
            Else
                'did not get a matching role record
            End If
        End Using
        sqldr.Close()
        Return _Audit
    End Function
End Class
