CREATE PROCEDURE [dbo].sp_getMembersAndRoles

AS
	SELECT * FROM Member
	INNER JOIN Member_Role WHERE Member.PID = Member_Role.PID


RETURN 0 ;


