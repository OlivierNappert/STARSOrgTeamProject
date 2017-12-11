CREATE PROCEDURE [dbo].sp_checkPIDExists
	@pid nvarchar(7)
AS
	SELECT * FROM MEMBER
	WHERE PID = @pid