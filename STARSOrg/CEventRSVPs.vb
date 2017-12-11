Imports System.Data.SqlClient
Public Class CEventRSVPs
    'Represents the EVENT_RSVP table and its associated business rules
    Private _EventRSVP As CEventRSVP
    'constructor
    Public Sub New()
        'instantiate the CEventRSVP object
        _EventRSVP = New CEventRSVP
    End Sub

    Public ReadOnly Property CurrentObject() As CEventRSVP
        Get
            Return _EventRSVP
        End Get
    End Property

    Public Sub Clear()
        _EventRSVP = New CEventRSVP
    End Sub

    Public Sub CreateNewEventRSVP()
        'call this routine when clearing the edit portion of the screen to add a new eventRSVP
        Clear()
        _EventRSVP.isNewUkid = True
    End Sub
    Public Function Save() As Integer
        Return _EventRSVP.Save
    End Function

    Public Function GetAllEventRSVPs() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.GetAllEventRSVPs", Nothing)
    End Function

    Public Function GetEventTypeByID(strID As String) As CEventRSVP
        Dim params As New ArrayList
        params.Add(New SqlParameter("ukid", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getEventRSVPByID", params))
        Return _EventRSVP
    End Function

    Private Function FillObject(sqldr As SqlDataReader) As CEventRSVP
        Using sqldr
            If sqldr.Read() Then 'found the EventRSVP record
                With _EventRSVP
                    .ukid = sqldr.Item("ukid") & ""
                    .EventID = sqldr.Item("EventID") & ""
                    .FName = sqldr.Item("FName") & ""
                    .LName = sqldr.Item("LName") & ""
                    .Email = sqldr.Item("Email") & ""
                End With
            Else
                'did not get a matching EventRSVP record
            End If
        End Using
        sqldr.Close()
        Return _EventRSVP
    End Function
End Class
