CREATE PROCEDURE [dbo].[SP_User_Update]
	@user_id uniqueidentifier,
	@pseudo nvarchar(150)
AS
Begin
Update [dbo].[User]
	Set [Pseudo] = @pseudo
	Where [User_Id] = @user_id
END
