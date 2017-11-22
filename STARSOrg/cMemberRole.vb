Imports System.Data.SqlClient

Public Class cMemberRole
    Private _mstrPID As String
    Private _Ukid As Integer
    Private _mstrRoleID As String
    Private _mstrSemesterID As String

    Public Sub New()
        _mstrPID = ""
        _Ukid = 0
        _mstrRoleID = ""
        _mstrSemesterID = ""
    End Sub
    Public Property Ukid As String
        Get
            Return _Ukid
        End Get
        Set(value As String)
            _Ukid = Ukid
        End Set
    End Property
    Public Property RoleID As String
        Get
            Return _mstrRoleID
        End Get
        Set(value As String)
            _mstrRoleID = value
        End Set
    End Property
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(value As String)
            _mstrSemesterID = value
        End Set
    End Property
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(value As String)
            _mstrPID = value
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _Ukid))
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("RoleID", _mstrRoleID)) 'These are the parameter names that are gonna match our stored procedures
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))

            Return params
        End Get
    End Property

    Public Function Save() As Integer
        'return -1 if the ID already exists (and we can't create a new record with duplicate ID)
        If IsNewRole Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID))
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckRoleIDExists", params)
            If Not strRes = 0 Then
                Return -1 'This record already exists
            End If
        End If
        'If not a new role, or it is new and has a unique ID, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveRole", GetSaveParameters()) 'Result of 0 means success
    End Function

End Class
