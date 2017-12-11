USE [StarsOrg]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_SaveAudit]
		@ukid = NULL,
		@pID = N'',
		@aCCESSTIMESTAMP = NULL,
		@sUCCESS = NULL

SELECT	@return_value as 'Return Value'

GO
