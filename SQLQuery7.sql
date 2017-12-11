USE [StarsOrg]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_getSecurityByPID]
		@pID = N'4097906'

SELECT	@return_value as 'Return Value'

GO
