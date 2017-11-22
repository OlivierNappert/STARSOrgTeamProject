Imports System.Data.SqlClient
Public Class cAudit
    'This class represents a single record in the Security Table
    Private _mstrukid As String 'matches exactly the name of the field in the database, and data type
    Private _mstrPID As String 'compare names to tables
    Private _mstrACCESSTIMESTAMP As String
    Private _mstrSUCCESS As String
    Private _isNewAudit As Boolean
    'constructor
    Public Sub New()
        'initializing
        _mstrukid = ""
        _mstrPID = ""
        _mstrACCESSTIMESTAMP = ""
        _mstrSUCCESS = ""
    End Sub

#Region "exposed properties"
    Public Property ukid As String
        Get
            Return _mstrukid
        End Get
        Set(strVal As String)
            _mstrukid = strVal
        End Set
    End Property
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property

    Public Property ACCESSTIMESTAMP As String
        Get
            Return _mstrACCESSTIMESTAMP
        End Get
        Set(strVal As String)
            _mstrACCESSTIMESTAMP = strVal
        End Set
    End Property
    Public Property SUCCESS As String
        Get
            Return _mstrSUCCESS
        End Get
        Set(strVal As String)
            _mstrSUCCESS = strVal
        End Set
    End Property
    Public Property IsNewAudit As Boolean
        Get
            Return _isNewAudit
        End Get
        Set(blnVal As Boolean)
            _isNewAudit = blnVal
        End Set
    End Property
#End Region
    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _mstrukid))
            params.Add(New SqlParameter("pID", _mstrPID)) 'These are the parameter names that are gonna match our stored procedures
            params.Add(New SqlParameter("aCCESSTIMESTAMP", _mstrACCESSTIMESTAMP))
            params.Add(New SqlParameter("sUCCESS", _mstrSUCCESS))
            Return params
        End Get
    End Property
    Public Function Save() As Integer 'This is a stored procedure
        'return -1 if the ID already exists (and we can't create a new record with duplicate ID)
        If IsNewAudit Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _mstrukid))
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckukidExists", params)
            If Not strRes = 0 Then
                Return -1 'This record already exists
            End If
        End If
        'If not a new role, or it is new and has a unique ID, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveAudit", GetSaveParameters()) 'Result of 0 means success
    End Function
End Class
