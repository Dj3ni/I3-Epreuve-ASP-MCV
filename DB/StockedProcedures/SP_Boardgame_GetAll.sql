CREATE PROCEDURE [dbo].[SP_Boardgame_GetAll]
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
		[Registration_Date],
		[Register],
		[Registration_date]

	FROM [Boardgame]

End
