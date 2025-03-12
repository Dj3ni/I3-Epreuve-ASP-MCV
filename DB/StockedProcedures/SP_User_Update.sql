CREATE PROCEDURE [dbo].[SP_User_Update]
	@user_id uniqueidentifier,
	@pseudo nvarchar(150),
	@deactivativation_date datetime null
AS
Begin
Update [dbo].[User]
	Set 
		[Pseudo] = @pseudo,
		[Deactivation_Date] = @deactivativation_date

	Where [User_Id] = @user_id
END
