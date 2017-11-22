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
End Class
