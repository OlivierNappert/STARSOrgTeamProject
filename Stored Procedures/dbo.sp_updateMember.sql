CREATE PROCEDURE [dbo].sp_updateMember
	@pid nvarchar(7),
	@firstName nvarchar(50),
    @lastName nvarchar (75),
    @middleName nvarchar (1),
    @email nvarchar (50),
    @phone nvarchar (13),
    @photoPath nvarchar (300),
	@currentSemester nvarchar(4)
AS
	UPDATE MEMBER
	SET FName = @firstName, LName = @lastName, MI = @middleName, Email = @email, Phone = @phone, PhotoPath = @photoPath
	WHERE PID = @pid