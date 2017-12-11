CREATE PROCEDURE [dbo].sp_CheckEventTypeIDExists
	@EventTypeID nvarchar(15),
	@recCount int = 0 OUTPUT
AS
BEGIN
	SET @recCount=(Select count(0) FROM EVENT_TYPE WHERE EventTypeID=@EventTypeID)
	SELECT @recCount as RecordCount
END
RETURN 0
