CREATE PROCEDURE [dbo].[SP_Boardgame_Insert]
	@game_title nvarchar(200),
	@description nvarchar(MAX),
	@ageMin int,
	@ageMax int,
	@minPlayer int,
	@maxPlayer int,
	@duration int null,
	@registerer uniqueidentifier
AS
BEGIN
	Declare @registration_date datetime;
	Set @registration_date = getDate();

	Insert Into [Boardgame]
		([Game_Title],
		[Description],
		[AgeMin],
		[AgeMax],
		[Min_Players],
		[Max_Players],
		[Duration],
		[Registration_Date],
		[Registerer])

	Output [Inserted].[Game_Id]

	Values
		(@game_title,
		@description,
		@ageMin,
		@ageMax,
		@minPlayer,
		@maxPlayer,
		@duration,
		@registration_date,
		@registerer)
END
