CREATE PROCEDURE [dbo].[SP_Boardgame_GetById]
	@game_id int
AS
Begin
	Select
		[Game_Id],
		[Game_Title],
		[Description],
		[AgeMin],
		[AgeMax],
		[Min_Players],
		[Max_Players],
		[Duration],
		[Registerer],
		[Registration_date]

	FROM [Boardgame]

	Where [Game_Id] = @game_id

End
