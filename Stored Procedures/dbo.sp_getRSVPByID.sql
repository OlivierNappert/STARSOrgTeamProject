CREATE PROCEDURE [dbo].sp_getRSVPByID
	@ukid nvarchar(4)

AS
	SELECT * FROM EVENT_RSVP
	WHERE ukid=@ukid
RETURN 0
