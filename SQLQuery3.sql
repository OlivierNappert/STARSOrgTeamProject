USE [StarsOrg]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_addNewMember]
		@pid = N'0000001',
		@firstName = N'Guest',
		@lastName = N'Guest',
		@middleName = N'Guest',
		@email = N'Guest',
		@phone = N'',
		@photoPath = N'',
		@currentSemester = N'GST'

SELECT	@return_value as 'Return Value'

GO
