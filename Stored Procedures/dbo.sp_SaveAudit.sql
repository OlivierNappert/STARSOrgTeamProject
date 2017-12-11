CREATE PROCEDURE [dbo].sp_SaveAudit
@ukid int,
@pID nvarchar(7),
@aCCESSTIMESTAMP smalldatetime,
@sUCCESS bit
AS
    

	BEGIN
	   SET IDENTITY_INSERT [dbo].[AUDIT] ON
		INSERT INTO AUDIT 
			(PID
			,ACCESSTIMESTAMP
			,SUCCESS
			)
			VALUES
				(pID
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