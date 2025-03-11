CREATE PROCEDURE [dbo].[SP_User_GetById]
	@user_id uniqueidentifier
AS
BEGIN
	Select 
		[User_Id],
		[Pseudo],
		[Password],
		[Subscription_Date],
		[Deactivation_date]

	FROM [User]

	Where [User_Id] = @user_id
END
