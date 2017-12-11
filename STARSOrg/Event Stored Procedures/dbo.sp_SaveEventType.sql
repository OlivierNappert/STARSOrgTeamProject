CREATE PROCEDURE [dbo].sp_SaveEventType
	@EventTypeID nvarchar(15),@EventTypeDescription nvarchar(100)
	
AS
	Declare @countExists int

	SELECT @countExists=count(0) FROM EVENT_TYPE WHERE EventTypeID=@EventTypeID
	if (@countExists=0)
	BEGIN
		INSERT INTO EVENT_TYPE
			(EventTypeID
			,EventTypeDescription
			)
		VALUES
			(@EventTypeID
			,@EventTypeDescription
			)
	END
	ELSE
	BEGIN
		UPDATE EVENT_TYPE
		SET
			[EventTypeDescription]=@EventTypeDescription
		WHERE EventTypeID=@EventTypeID
	END
RETURN @@error
