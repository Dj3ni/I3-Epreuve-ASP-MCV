CREATE PROCEDURE [dbo].[SP_Boardgame_Update]
	@game_id int,
	@game_title nvarchar(200),
	@description nvarchar(MAX),
	@ageMin int,
	@ageMax int,
	@minPlayer int,
	@maxPlayer int,
	@duration int null,
	@register uniqueidentifier
AS
BEGIN

	Update [Boardgame]
			SET 
			[Game_Title] = @game_title,
			[Description] = @description,
			[AgeMin] = @ageMin,
			[AgeMax] = @ageMax,
			[Min_Players] = @minPlayer,
			[Max_Players] = @maxPlayer,
			[Duration]= @duration,
			[Register]= @register
END