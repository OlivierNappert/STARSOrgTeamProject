Imports System.Data.SqlClient


Public Class cMemberRoles
    'Represents the ROLE Table and its associated business roles
    'we need to be able to manage a single record
    'retrieves data to and from the database
    'deals with crole
    Private _MemberRole As cMemberRole

    Public Sub New()
        'instantiate the `s object
        'constructor
        _MemberRole = New cMemberRole

    End Sub

    Public ReadOnly Property CurrentObject() As cMemberRole
        Get
            Return _MemberRole
        End Get

    End Property

    Public Sub Clear()
        _MemberRole = New cMemberRole

    End Sub

    Public Sub CreateNewRole()
        'call this routine when clearing the edit portion of the screen to add a new role
        Clear()
        _MemberRole.IsNewRole = True
    End Sub

    Public Function Save() As Integer
        Return _MemberRole.Save

    End Function
    Public Function GetAllRoles() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllMemberRoles", Nothing)
    End Function

    Public Function GetRoleByID(strID As String) As cMemberRole
        Dim params As New ArrayList
        params.Add(New SqlParameter("roleID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberRoleByID", params))
        Return _MemberRole
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

