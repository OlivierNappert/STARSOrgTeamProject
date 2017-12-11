Imports System.Data.SqlClient
Public Class cSecurities
    'Represents the SECURITY table and its associate business rules
    Private _Security As cSecurity
    'constructor

    Public Sub New()
        'insantiate the cSecurity object
        _Security = New cSecurity
    End Sub

    Public ReadOnly Property CurrentObject() As cSecurity
        Get
            Return _Security
        End Get
    End Property

    Public Sub Clear()
        _Security = New cSecurity
    End Sub
    Public Sub CreateNewSecurity()
        'call this routine when clearing the edit portion of the screen to add a new security
        Clear()
        _Security.IsNewSecurity = True
    End Sub
    Public Function Save() As Integer
        Return _Security.Save
    End Function

    Public Function GetAllSecurity() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllSecurity", Nothing)
    End Function

	Public Function GetSecurityByPID(strID As String) As cSecurity
		Dim params As New ArrayList
		params.Add(New SqlParameter("pID", strID))
		FillObject(myDB.GetDataReaderBySP("dbo.sp_getSecurityByPID", params))
		Return _Security
	End Function

	Public Function GetSecurityByUserID(strID As String) As cSecurity
		Dim params As New ArrayList
		params.Add(New SqlParameter("userID", strID))
		FillObject(myDB.GetDataReaderBySP("dbo.sp_getSecurityByUserID", params))
		Return _Security
	End Function

	Private Function FillObject(sqldr As SqlDataReader) As cSecurity
        Using sqldr
            If sqldr.Read() Then 'found the security record
                With _Security
                    .PID = sqldr.Item("PID") & ""
                    .UserID = sqldr.Item("UserID") & ""
                    .Password = sqldr.Item("Password") & ""
                    .SecRole = sqldr.Item("SecRole") & ""
                End With
            Else
                'did not get a matching security record
            End If
        End Using
        sqldr.Close()
        Return _Security
    End Function
End Class
