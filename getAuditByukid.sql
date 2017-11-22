CREATE PROCEDURE [dbo].sp_getAuditByukid
	@ukid int

AS
	SELECT * FROM AUDIT
	WHERE ukid=@ukid
RETURN 0