USE [StarsOrg]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_addNewMember]
		@pid = N'9999999',
		@firstName = N'USL',
		@lastName = N'USL',
		@middleName = N'USL',
		@email = N'USL',
		@phone = N'USL',
		@photoPath = N'',
		@currentSemester = N'USL'

SELECT	@return_value as 'Return Value'

GO
