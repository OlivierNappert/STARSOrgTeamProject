Imports System.Data.SqlClient
Public Class cMembers
    'Represents the MEMBER table and its associated rules
    Private _Member As cMember
    'constructor

    Public Sub New()
        'insantiate the cMember object
        _Member = New cMember
    End Sub

    Public ReadOnly Property CurrentObject() As cMember
        Get
            Return _Member
        End Get
    End Property

    Public Sub Clear()
        _Member = New cMember
    End Sub

    Public Sub CreateNewMember()
        'call this routine when clearing the edit portion of the screen to add a new Member
        Clear()
        _Member.IsNewMember = True
    End Sub

    Public Function Save() As Integer
        Return _Member.Save()
    End Function

    Public Function GetAllMembers() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllMembers", Nothing)
    End Function

    Public Function GetMembersWithLastName(strVal As String)
        Dim params As New ArrayList
        params.Add(New SqlParameter("lastName", strVal))
        Return myDB.GetDataReaderBySP("dbo.sp_searchMember", params)
    End Function

    Public Function GetMemberById(strID As String)
        Dim params As New ArrayList
        params.Add(New SqlParameter("pid", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getMemberByID", params))
        Return _Member
    End Function

    Private Function FillObject(sqldr As SqlDataReader) As cMember
        Using sqldr
            If sqldr.Read() Then 'found the role record
                With _Member
                    .PID = sqldr.Item("ID") & ""
                    .FName = sqldr.Item("FirstName") & ""
                    .ML = sqldr.Item("MiddleName") & ""
                    .LNAME = sqldr.Item("LastName") & ""
                    .Email = sqldr.Item("Email") & ""
                    .Phone = sqldr.Item("Phone") & ""
                    .PhotoPath = sqldr.Item("Photo") & ""
                End With
            Else
                'did not get a matching role record
                MessageBox.Show("Error didn't find matching record in frmMembers:FillObject", "Error")
            End If
        End Using
        sqldr.Close()
        Return _Member
    End Function
End Class
