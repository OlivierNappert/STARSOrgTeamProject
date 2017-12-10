Imports System.Data.SqlClient
Public Class cSecurity
    'This class represents a single record in the Security Table
    Private _mstrPID As String 'matches exactly the name of the field in the database, and data type
    Private _mstrUserID As String 'compare names to tables
    Private _mstrPassword As String
    Private _mstrSecRole As String
    Private _isNewSecurity As Boolean
    'constructor
    Public Sub New()
        'initializing
        _mstrPID = ""
        _mstrUserID = ""
        _mstrPassword = ""
        _mstrSecRole = ""
    End Sub

#Region "exposed properties"
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property

    Public Property UserID As String
        Get
            Return _mstrUserID
        End Get
        Set(strVal As String)
            _mstrUserID = strVal
        End Set
    End Property
    Public Property Password As String
        Get
            Return _mstrPassword
        End Get
        Set(strVal As String)
            _mstrPassword = strVal
        End Set
    End Property
    Public Property SecRole As String
        Get
            Return _mstrSecRole
        End Get
        Set(strVal As String)
            _mstrSecRole = strVal
        End Set
    End Property
    Public Property IsNewSecurity As Boolean
        Get
            Return _isNewSecurity
        End Get
        Set(blnVal As Boolean)
            _isNewSecurity = blnVal
        End Set
    End Property
#End Region
    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("pID", _mstrPID)) 'These are the parameter names that are gonna match our stored procedures
            params.Add(New SqlParameter("userID", _mstrUserID))
            params.Add(New SqlParameter("password", _mstrPassword))
            params.Add(New SqlParameter("secRole", _mstrSecRole))
            Return params
        End Get
    End Property
    Public Function Save() As Integer 'This is a stored procedure
        'return -1 if the ID already exists (and we can't create a new record with duplicate ID)
        If IsNewSecurity Then
            Dim params As New ArrayList
			params.Add(New SqlParameter("pID", _mstrPID))
			params.Add(New SqlParameter("userID", _mstrUserID))
			Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckPIDExists", params)
			Dim strRes2 As String = myDB.GetSingleValueFromSP("sp_CheckUserIDExists", params)
			If Not strRes = 0 And strRes2 = 0 Then
				Return -1 'This record already exists
			End If
		End If
        'If not a new role, or it is new and has a unique ID, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveSecurity", GetSaveParameters()) 'Result of 0 means success
    End Function
End Class
