Imports System.Data.SqlClient
Public Class cMemberRoles

    Private _MemberRole As cMemberRole

    Public Sub New()
        _MemberRole = New cMemberRole
    End Sub

    Public ReadOnly Property CurrentOject() As cMemberRole
        Get
            Return _MemberRole
        End Get
    End Property

    Public Sub Clear()
        _MemberRole = New cMemberRole
    End Sub

    Public Sub CreateNewMemberRole()
        Clear()
        _MemberRole.IsNewRole = True
    End Sub


    Public Function Save() As Integer
        Return _MemberRole.Save
    End Function



    Public Function GetMemberRoles(PID As String, SemesterID As String) As SqlDataReader
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", PID))
        params.Add(New SqlParameter("SemesterID", SemesterID))
        Return (myDB.GetDataReaderBySP("dbo.sp_GetMemberRolesPIDSEMESTER", params))

    End Function
    Public Function GetMembersAndRoles(PID As String, SemesterID As String) As SqlDataReader
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", PID))
        'params.Add(New SqlParameter("SemesterID", SemesterID))
        Return (myDB.GetDataReaderBySP("dbo.sp_GetMemberRolesAndRoles", params))
    End Function

    Private Function FillObject(sqldr As SqlDataReader) As cMemberRole
        Using sqldr
            If sqldr.Read() Then 'found the role record
                With _MemberRole
                    .PID = sqldr.Item("PID") & ""
                    .RoleID = sqldr.Item("RoleID") & ""
                    .SemesterID = sqldr.Item("SemesterID") & ""
                End With
            Else
                'did not get a matching role record
            End If
        End Using
        sqldr.Close()
        Return _MemberRole
    End Function
End Class
