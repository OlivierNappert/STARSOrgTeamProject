CREATE PROCEDURE [dbo].sp_CheckEventRSVPExists
	@eventid nvarchar(4),
	@lname nvarchar(75),
	@fname nvarchar(50),
	@recCount int =0 OUTPUT
AS
BEGIN

	SET @recCount=(Select count(0) FROM EVENT_RSVP WHERE eventID=@eventid and lname=@lname and FName=@fname)
	SELECT @recCount as RecordCount
END
RETURN 0
