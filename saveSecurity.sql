CREATE PROCEDURE [dbo].sp_SaveSecurity
@pID nvarchar(7),
@userID nvarchar(15),
@password nvarchar(8),
@secRole nvarchar(10)
AS
	Declare @countExists int
	SELECT @countExists=count(0) FROM SECURITY WHERE PID=@pID
	if (@countExists=0)
	BEGIN
		INSERT INTO SECURITY 
			(PID
			,UserID
			,Password
			,SecRole
			)
			VALUES
				(@pID
				,@userID
				,@password
				,@secRole
				)

				END
				ELSE 
				BEGIN 
				UPDATE SECURITY
				SET 
				[UserID]=@userID
				,[Password]=@password
				,[SecRole]=@secRole
				WHERE PID= @pID

END
RETURN @@error
