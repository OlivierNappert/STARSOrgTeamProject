CREATE PROCEDURE [dbo].GetAllEventRSVPs
	@eventID nvarchar(4)
AS
	SELECT Event.EventID, Eventdescription, StartDate, location, FName, Lname, Email
	FROM EVENT_RSVP inner join Event on EVENT_RSVP.EventID=event.EventID
	WHERE event.eventid=@eventID
RETURN 0
