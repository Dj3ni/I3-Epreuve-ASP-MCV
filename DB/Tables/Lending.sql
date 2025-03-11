CREATE TABLE [dbo].[Lending]
(
	[Lending_Id] INT NOT NULL Identity(1,1),
	[Lending_Date] DateTime Not Null,
	[Return_Date] DateTime null,
	[Owner_Note] Int null,
	[Borrower_Note] Int null,
	[Owner_Id] UniqueIdentifier Not Null,
	[Borrower_Id] UniqueIdentifier not null,
	[Game_Copy_Id] Int not null,
	[Game_State] nvarchar(50) not null,

	Constraint PK_Lending Primary Key ([Lending_Id]),
	Constraint FK_Game_State Foreign Key ([Game_State]) References [Library]([State]),
	Constraint FK_Borrower_Id Foreign Key([Borrower_Id]) References [User]([User_Id]),
	Constraint FK_Owner_Id Foreign Key([Owner_Id]) References [User]([User_Id]),
	Constraint FK_Game_Copy Foreign Key([Game_Copy_Id]) References [Library]([Game_Copy_Id]),
	Constraint Ck_Owner_Different_Borrower Check ([Owner_Id] != [Borrower_Id]),
	Constraint Ck_Game_Not_Incomplete Check([Game_State] not in ('Incomplete'))
)
