CREATE PROCEDURE [dbo].sp_addNewMember
	@pid nvarchar(7),
	@firstName nvarchar(50),
    @lastName nvarchar (75),
    @middleName nvarchar (1),
    @email nvarchar (50),
    @phone nvarchar (13),
    @photoPath nvarchar (300),
	@currentSemester nvarchar(4)
AS
	DECLARE @roleID nvarchar(15)

	SET @roleID = 'Member'
	INSERT INTO MEMBER(PID, FName, LName, MI, Email, Phone, PhotoPath)
	VALUES(@pid, @firstName, @lastName, @middleName, @email, @phone, @photoPath);

	INSERT INTO MEMBER_ROLE(PID, RoleID, SemesterID)
	VALUES(@pid, @roleID, @currentSemester);