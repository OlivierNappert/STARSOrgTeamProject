CREATE PROCEDURE [dbo].sp_SaveAudit
@ukid int,
@pID nvarchar(7),
@aCCESSTIMESTAMP smalldatetime,
@sUCCESS bit
AS
	Declare @countExists int
	SELECT @countExists=count(0) FROM AUDIT WHERE ukid=@ukid
	if (@countExists=0)
	BEGIN
		INSERT INTO AUDIT 
			(ukid
			,PID
			,ACCESSTIMESTAMP
			,SUCCESS
			)
			VALUES
				(@ukid
				,@pID
				,@aCCESSTIMESTAMP
				,@sUCCESS
				)

				END
				ELSE 
				BEGIN 
				UPDATE AUDIT
				SET 
				[PID]=@pID
				,[ACCESSTIMESTAMP]=@aCCESSTIMESTAMP
				,[SUCCESS]=@sUCCESS
				WHERE ukid= @ukid

END
RETURN @@error
