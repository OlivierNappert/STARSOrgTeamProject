Imports System.Data.SqlClient
Public Class CEventTypes
    'Represents the EVENT_TYPE table and its associated business rules
    Private _EventType As CEventType
    'constructor
    Public Sub New()
        'instantiate the CEventType object
        _EventType = New CEventType
    End Sub

    Public ReadOnly Property CurrentObject() As CEventType
        Get
            Return _EventType
        End Get
    End Property

    Public Sub Clear()
        _EventType = New CEventType
    End Sub

    Public Sub CreateNewEventType()
        'call this routine when clearing the edit portion of the screen to add a new event type
        Clear()
        _EventType.IsNewEventType = True
    End Sub
    Public Function Save() As Integer
        Return _EventType.Save
    End Function

    Public Function GetAllEventTypes() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllEventTypes", Nothing)
    End Function

    Public Function GetEventTypeByID(strID As String) As CEventType
        Dim params As New ArrayList
        params.Add(New SqlParameter("EventTypeID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getEventTypeByID", params))
        Return _EventType
    End Function

    Private Function FillObject(sqldr As SqlDataReader) As CEventType
        Using sqldr
            If sqldr.Read() Then 'found the event type record
                With _EventType
                    .EventTypeID = sqldr.Item("EventTypeID") & ""
                    .EventTypeDescription = sqldr.Item("EventTypeDescription") & ""
                End With
            Else
                'did not get a matching event type record
            End If
        End Using
        sqldr.Close()
        Return _EventType
    End Function
End Class
