CREATE TABLE [dbo].[Library]
(
	[Game_Copy_Id] int Not Null Identity(1,1),
	[State] nvarchar(50) not null ,
	[User_Id] UniqueIdentifier,
	[Game_Id] int not null,
	Constraint PK_Game_Copy Primary Key([Game_Copy_ID]),
	Constraint Ck_State Check ([State] in ('New','Damaged','Incomplete')),
	Constraint FK_User_ID Foreign Key([User_Id]) references [User]([User_Id]) on delete set null,
	Constraint FK_Game_ID Foreign Key([Game_Id]) references [Boardgame]([Game_Id]) on delete cascade
)
