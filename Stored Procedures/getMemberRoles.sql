CREATE PROCEDURE [dbo].sp_GetMemberRoles @PID nvarchar(30)

AS
	SELECT * FROM ROLES
	WHERE Roles.PID = @PID

GO
RETURN 0 ;


