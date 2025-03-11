CREATE TABLE [dbo].[Boardgame]
(
	[Game_Id] INT NOT NULL Identity(1,1),
	[Game_Title] nvarchar(200) Not Null,
	[Description] nvarchar(Max) Not Null,
	[AgeMin] Int Not Null,
	[AgeMax] int Not null,
	[Min_Players] int NOT NULL,
	[Max_Players] int Not Null,
	[Duration] int null,
	[Registration_Date] datetime not null Default GetDate(),
	[Register] UniqueIdentifier not null
	Constraint PK_Game_Id Primary Key([Game_Id]),
	Constraint Check_Age_Values Check([AgeMin] <= [AgeMax]),
	Constraint Check_Nbr_Players Check([Min_Players] <= [Max_Players]),
	Constraint FK_User_Register Foreign Key([Register]) references [User]([User_Id])
)
