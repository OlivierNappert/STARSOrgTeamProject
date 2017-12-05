Imports System.Data.SqlClient

Public Class cMember
    'This class represents a single record in the Member Table
    Private _rstrPID As String
    Private _rstrFName As String
    Private _rstrLName As String
    Private _rstrML As String
    Private _rstrEmail As String
    Private _rstrPhone As String
    Private _rstrPhotoPath As String
    Private _IsNewMember As Boolean

    'constructor
    Public Sub New()
        'initializing
        _rstrPID = ""
        _rstrFName = ""
        _rstrLName = ""
        _rstrML = Nothing
        _rstrEmail = ""
        _rstrPhone = Nothing
        _rstrPhotoPath = Nothing
    End Sub

#Region "Exposed properties"
    Public Property PID As String
        Get
            Return _rstrPID
        End Get
        Set(strVal As String)
            _rstrPID = strVal
        End Set
    End Property

    Public Property FName As String
        Get
            Return _rstrFName
        End Get
        Set(strVal As String)
            _rstrFName = strVal
        End Set
    End Property

    Public Property LNAME As String
        Get
            Return _rstrLName
        End Get
        Set(strVal As String)
            _rstrLName = strVal
        End Set
    End Property

    Public Property ML As String
        Get
            Return _rstrML
        End Get
        Set(strVal As String)
            _rstrML = strVal
        End Set
    End Property

    Public Property Email As String
        Get
            Return _rstrEmail
        End Get
        Set(strVal As String)
            _rstrEmail = strVal
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _rstrPhone
        End Get
        Set(strVal As String)
            _rstrPhone = strVal
        End Set
    End Property

    Public Property PhotoPath As String
        Get
            Return _rstrPhotoPath
        End Get
        Set(strVal As String)
            _rstrPhotoPath = strVal
        End Set
    End Property

    Public Property IsNewMember As Boolean
        Get
            Return _IsNewMember
        End Get
        Set(blnVal As Boolean)
            _IsNewMember = blnVal
        End Set
    End Property
#End Region

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("pid", _rstrPID)) 'These are the parameter names that are gonna match our stored procedures
            params.Add(New SqlParameter("firstName", _rstrFName))
            params.Add(New SqlParameter("lastName", _rstrLName))
            params.Add(New SqlParameter("middleName", _rstrML))
            params.Add(New SqlParameter("email", _rstrEmail))
            params.Add(New SqlParameter("phone", _rstrPhone))
            params.Add(New SqlParameter("photoPath", _rstrPhotoPath))
            params.Add(New SqlParameter("currentSemester", frmMain.CurrentSemesterID))
            Return params
        End Get
    End Property

    Public Function Save() As Integer 'This is a stored procedure
        'return -1 if the PID already exists
        If IsNewMember Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("pid", _rstrPID))
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_checkPIDExists", params)
            If Not strRes = -1 Then
                Return -1 'This record already exists
            End If
            Return myDB.ExecSP("sp_addNewMember", GetSaveParameters()) 'Result of 0 means success
        Else
            'If not a new member, or it is new and has a unique ID, then do the save (update or insert)
            Return myDB.ExecSP("sp_updateMember", GetSaveParameters()) 'Result of 0 means success
        End If
    End Function
End Class