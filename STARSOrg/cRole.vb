Imports System.Data.SqlClient
Public Class cRole
    'This class represents a single record in the Role Table
    Private _mstrRoleID As String 'matches exactly the name of the field in the database, and data type
    Private _mstrRoleDescription As String 'compare names to tables
    Private _isNewRole As Boolean
    'constructor
    Public Sub New()
        'initializing
        _mstrRoleID = ""
        _mstrRoleDescription = ""

    End Sub

#Region "exposed properties"
    Public Property RoleID As String
        Get
            Return _mstrRoleID
        End Get
        Set(strVal As String)
            _mstrRoleID = strVal
        End Set
    End Property

    Public Property RoleDescription As String
        Get
            Return _mstrRoleDescription
        End Get
        Set(strVal As String)
            _mstrRoleDescription = strVal
        End Set
    End Property

    Public Property IsNewRole As Boolean
        Get
            Return _isNewRole
        End Get
        Set(blnVal As Boolean)
            _isNewRole = blnVal
        End Set
    End Property
#End Region
    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID)) 'These are the parameter names that are gonna match our stored procedures
            params.Add(New SqlParameter("roleDescription", _mstrRoleDescription))
            Return params
        End Get
    End Property
    Public Function Save() As Integer 'This is a stored procedure
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
