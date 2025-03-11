CREATE PROCEDURE [dbo].[SP_User_GetAll]

AS
BEGIN
	Select 
		[User_Id],
		[Pseudo],
		[Password],
		[Subscription_Date],
		[Deactivation_date]

	FROM [User]
END
