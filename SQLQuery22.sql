CREATE PROCEDURE [dbo].sp_checkUserIDExists
	@UserID nvarchar(15)
AS
	SELECT * FROM MEMBER
	WHERE PID = @pid