USE [StarsOrg]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_SaveSecurity]
		@pID = N'0000001',
		@userID = N'guest',
		@password = N'guest',
		@secRole = N'GUEST'

SELECT	@return_value as 'Return Value'

GO
