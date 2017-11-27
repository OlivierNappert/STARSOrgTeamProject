Imports System.Data.SqlClient


Public Class cRoles
    'Represents the ROLE Table and its associated business roles
    'we need to be able to manage a single record
    'retrieves data to and from the database
    'deals with crole
    Private _Role As cRole

    Public Sub New()
        'instantiate the CRoel object
        'constructor
        _Role = New cRole

    End Sub

    Public ReadOnly Property CurrentObject() As cRole
        Get
            Return _Role
        End Get

    End Property

    Public Sub Clear()
        _Role = New cRole

    End Sub

    Public Sub CreateNewRole()
        'call this routine when clearing the edit portion of the screen to add a new role
        Clear()
        _Role.IsNewRole = True
    End Sub

    Public Function Save() As Integer
        Return _Role.Save

    End Function
    Public Function GetAllRoles() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllRoles", Nothing)
    End Function

    Public Function GetRoleByID(strID As String) As cRole
        Dim params As New ArrayList
        params.Add(New SqlParameter("roleID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetRoleByID", params))
        Return _Role
    End Function

    Private Function FillObject(sqldr As SqlDataReader) As cRole
        Using sqldr
            If sqldr.Read() Then 'found the role record
                With _Role
                    .RoleID = sqldr.Item("RoleID") & ""
                    .RoleDescription = sqldr.Item("RoleDescription") & ""
                End With
            Else
                'did not get a matching role record
            End If
        End Using
        sqldr.Close()
        Return _Role
    End Function
End Class
