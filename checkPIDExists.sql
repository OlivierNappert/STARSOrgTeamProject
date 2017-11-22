CREATE PROCEDURE [dbo].sp_CheckPIDExists
	@pID nvarchar(7),
	@recCount int = 0 Output
AS
BEGIN
Set @recCount=(Select count(0) FROM SECURITY WHERE PID=@pID)
	SELECT @recCount as RecordCount
	END
RETURN 0
