CREATE PROCEDURE [dbo].sp_CheckukidExists
	@ukid int,
	@recCount int = 0 Output
AS
BEGIN
Set @recCount=(Select count(0) FROM AUDIT WHERE ukid=@ukid)
	SELECT @recCount as RecordCount
	END
RETURN 0