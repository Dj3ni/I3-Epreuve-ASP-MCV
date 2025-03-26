CREATE PROCEDURE [dbo].[SP_Library_Delete]
	@game_copy_id int
AS
Begin
	Update [Library]
	Set [IsRemoved] = 1
	Where [Game_Copy_Id] = @game_copy_id
End
