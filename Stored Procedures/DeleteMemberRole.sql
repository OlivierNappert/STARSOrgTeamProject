CREATE PROCEDURE [dbo].sp_dropMemberRoles
@PID nvarchar(7), @roleID nvarchar(15), @SemesterID nvarchar(4)
AS
	
	Drop FROM Member_Role WHERE PID = @PID AND roleID = @roleID AND SemesterID = @SemesterID


RETURN 0