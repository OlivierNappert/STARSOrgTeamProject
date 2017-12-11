CREATE PROCEDURE [dbo].sp_getMemberByID
	@pid varchar(7)
AS
	SELECT PID AS ID, PhotoPath AS Photo, FNAME AS FirstName, MI AS MiddleName, LNAME AS LastName, Email, Phone
	FROM MEMBER
	WHERE PID = @pid