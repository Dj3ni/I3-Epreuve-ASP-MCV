﻿CREATE TABLE [dbo].[Boardgame]
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
	[Registerer] UniqueIdentifier not null
	Constraint PK_Game_Id Primary Key([Game_Id]),
	Constraint Uk_Title Unique([Game_title]),
	Constraint Ck_Age_Values Check([AgeMin] <= [AgeMax]),
	Constraint Ck_Nbr_Players Check([Min_Players] <= [Max_Players]),
	Constraint FK_User_Register Foreign Key([Registerer]) references [User]([User_Id])
)
