CREATE PROCEDURE [dbo].sp_SaveAudit
@pID nvarchar(7),
@aCCESSTIMESTAMP smalldatetime,
@sUCCESS bit
AS

	BEGIN
		INSERT INTO AUDIT 
			(PID
			,ACCESSTIMESTAMP
			,SUCCESS
			)
			VALUES
				(@pID
				,@aCCESSTIMESTAMP
				,@sUCCESS
				)
	END
				
RETURN @@error