CREATE PROCEDURE [dbo].sp_getAllMembers

AS
	SELECT PID AS ID, FNAME AS FirstName, MI AS MiddleName, LNAME AS LastName, Email, Phone
	FROM MEMBER
RETURN 0