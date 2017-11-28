Imports System.Data.SqlClient
Public Class CEvents
    'Represents the EVENT table and its associated business rules
    Private _Event As CEvent
    'constructor
    Public Sub New()
        'instantiate the CEvent object
        _Event = New CEvent
    End Sub

    Public ReadOnly Property CurrentObject() As CEvent
        Get
            Return _Event
        End Get
    End Property

    Public Sub Clear()
        _Event = New CEvent
    End Sub

    Public Sub CreateNewEvent()
        'call this routine when clearing the edit portion of the screen to add a new event
        Clear()
        _Event.IsNewEvent = True
    End Sub
    Public Function Save() As Integer
        Return _Event.Save
    End Function

    Public Function GetAllEvents() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllEvents", Nothing)
    End Function

    Public Function GetEventByID(strID As String) As CEvent
        Dim params As New ArrayList
        params.Add(New SqlParameter("EventID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getEventByID", params))
        Return _Event
    End Function

    Private Function FillObject(sqldr As SqlDataReader) As CEvent
        Using sqldr
            If sqldr.Read() Then 'found the event record
                With _Event
                    .EventID = sqldr.Item("EventID") & ""
                    .EventDescription = sqldr.Item("EventDescription") & ""
                    .EventTypeID = sqldr.Item("EventTypeID") & ""
                    .SemesterID = sqldr.Item("SemesterID") & ""
                    .StartDate = sqldr.Item("StartDate") & ""
                    .EndDate = sqldr.Item("EndDate") & ""
                    .Location = sqldr.Item("Location") & ""
                End With
            Else
                'did not get a matching event record
            End If
        End Using
        sqldr.Close()
        Return _Event
    End Function
End Class
