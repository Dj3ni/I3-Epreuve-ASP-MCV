CREATE PROCEDURE [dbo].[SP_User_Insert]
	@email NVARCHAR(320),
	@pseudo NVarchar,
	@subscription_date dateTime null,
	@password Varbinary(150)
AS
BEGIN
	DECLARE @salt UNIQUEIDENTIFIER
	SET @salt = NEWID()
	INSERT INTO [User] ([Email],[Pseudo],[Subscription_Date],[Password],[Salt])
	OUTPUT [inserted].[User_Id]
	VALUES (@email,@pseudo,@subscription_date,[dbo].[SF_SaltAndHash](@password, @salt), @salt)
END
