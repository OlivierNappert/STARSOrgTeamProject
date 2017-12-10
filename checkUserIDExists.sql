CREATE PROCEDURE [dbo].sp_CheckUserIDExists
	@userID nvarchar(15),
	@recCount int = 0 Output
AS
BEGIN
Set @recCount=(Select count(0) FROM SECURITY WHERE UserID=@userID)
	SELECT @recCount as RecordCount
	END
RETURN 0