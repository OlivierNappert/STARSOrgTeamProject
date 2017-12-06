CREATE PROCEDURE [dbo].sp_searchMember
	@lastName nvarchar(12)
AS
	SELECT PID AS ID, FNAME AS FirstName, MI AS MiddleName, LNAME AS LastName, Email, Phone
	FROM MEMBER
	WHERE LNAME LIKE @lastName + '%'