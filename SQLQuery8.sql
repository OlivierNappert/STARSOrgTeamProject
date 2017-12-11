USE [StarsOrg]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_getSecurityByUserID]
		@userID = N'rsala045'

SELECT	@return_value as 'Return Value'

GO
