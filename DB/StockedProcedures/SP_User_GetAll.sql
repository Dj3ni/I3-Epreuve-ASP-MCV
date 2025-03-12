CREATE PROCEDURE [dbo].[SP_User_GetAllActive]

AS
BEGIN
	Select 
		[User_Id],
		[Pseudo],
		[Email],
		[Password],
		[Deactivation_date]

	FROM [User]

	Where [Deactivation_Date] is null
END
