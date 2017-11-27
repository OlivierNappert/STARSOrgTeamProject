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
End Class
