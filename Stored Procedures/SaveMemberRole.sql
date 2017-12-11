CREATE PROCEDURE [dbo].sp_DeleteMemberRole
@PID nvarchar(7), @roleID nvarchar(15), @SemesterID nvarchar(4)

AS
	Declare @countExists int
	DELETE From ROLE WHERE PID = @PID AND RoleID=@roleID AND SemesterID = @SemesterID

RETURN @@error ;
