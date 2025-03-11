/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--- Déclaration des tables d'insertion
Declare @insertedUserIds Table(user_id uniqueidentifier);
Declare @insertedGameIds Table(game_id int);
Declare @insertedLibrary Table(library_id int);



/* Insert 5 users*/

---- User 1
Insert into @insertedUserIds(user_id)
Exec SP_User_Insert
@email = 't.riv@games.be',
@pseudo = 'Théo',
@password = 'Test1234=',
@subscription_date = null
declare @UserId1 uniqueidentifier;
select @UserId1 = user_id from @insertedUserIds
DELETE FROM @InsertedUserIds;

---- User 2
Insert into @insertedUserIds(user_id)
Exec SP_User_Insert
@email = 'a.boccara@games.be',
@pseudo = 'Anth0',
@password = 'Test1234=',
@subscription_date = null
declare @UserId2 uniqueidentifier;
select @UserId2 = user_id from @insertedUserIds
DELETE FROM @InsertedUserIds;

---- User 3
Insert into @insertedUserIds(user_id)
Exec SP_User_Insert
@email = 'b.cathala@games.be',
@pseudo = 'NoNo',
@password = 'Test1234=',
@subscription_date = null
declare @UserId3 uniqueidentifier;
select @UserId3 = user_id from @insertedUserIds
DELETE FROM @InsertedUserIds;

---- User 4
Insert into @insertedUserIds(user_id)
Exec SP_User_Insert
@email = 'c.lebrat@games.be',
@pseudo = 'CoCO',
@password = 'Test1234=',
@subscription_date = null
declare @UserId4 uniqueidentifier;
select @UserId4 = user_id from @insertedUserIds
DELETE FROM @InsertedUserIds;

---- User 5
Insert into @insertedUserIds(user_id)
Exec SP_User_Insert
@email = 'b.faidutti@games.be',
@pseudo = 'Master of Citadelles',
@password = 'Test1234=',
@subscription_date = null
declare @UserId5 uniqueidentifier;
select @UserId5 = user_id from @insertedUserIds
DELETE FROM @InsertedUserIds;

/* Insert Boardgames */

--- Game 1
Insert into @insertedGameIds(game_id)
Exec SP_Boardgame_Insert
@game_title = 'Citadelles',
@description ='Each player has to build is own city with the help of cards representing city districts. Each turn the players pick a character card and use it''s power. The winner will be the best ambitious and malignant',
@ageMin = 10,
@ageMax = 99,
@minPlayer = 2,
@maxPlayer = 8,
@duration = 60,
@register = @UserId5

declare @GameId1 int;
Select @GameId1 = game_id from @insertedGameIds
Delete From @insertedGameIds

--- Game 2
Insert into @insertedGameIds(game_id)
Exec SP_Boardgame_Insert
@game_title = 'Rauha',
@description = 'Build your own biotope, grow some shrooms and make a maximum combo to win spirits, crystals and victory points',
@ageMin = 10,
@ageMax = 99,
@minPlayer = 2,
@maxPlayer = 5,
@duration = 45,
@register = @UserId1

declare @GameId2 int;
Select @GameId2 = game_id from @insertedGameIds
Delete From @insertedGameIds

--- Game 3
Insert into @insertedGameIds(game_id)
Exec SP_Boardgame_Insert
@game_title = 'Yamatai',
@description = 'Try to recruit heroes and conquer islands to impress the emperess Himiko',
@ageMin = 10,
@ageMax = 99,
@minPlayer = 2,
@maxPlayer = 4,
@duration = 60,
@register = @UserId3

declare @GameId3 int;
Select @GameId3 = game_id from @insertedGameIds
Delete From @insertedGameIds

--- Game 4
Insert into @insertedGameIds(game_id)
Exec SP_Boardgame_Insert
@game_title = 'Solstis',
@description = 'Build your path threw the mountain and light the fires before your opponent',
@ageMin = 8,
@ageMax = 99,
@minPlayer =2,
@maxPlayer = 2,
@duration = 15,
@register = @USerId4

declare @GameId4 int;
Select @GameId4 = game_id from @insertedGameIds
Delete From @insertedGameIds

/* Insert tags */

-- 1.
Exec SP_Tag_Insert @tag_id = 'Dice'
-- 2.
Exec SP_Tag_Insert @tag_id = 'Roll and Write'
-- 3.
Exec SP_Tag_Insert @tag_id = 'Cards'
-- 4.
Exec SP_Tag_Insert @tag_id = 'Disney'
-- 5.
Exec SP_Tag_Insert @tag_id = 'Board'
-- 6.
Exec SP_Tag_Insert @tag_id = 'Coop'
-- 7.
Exec SP_Tag_Insert @tag_id = 'Competitive'
-- 8.
Exec SP_Tag_Insert @tag_id = 'Initiate'
-- 9.
Exec SP_Tag_Insert @tag_id = 'Expert'
-- 10.
Exec SP_Tag_Insert @tag_id = 'Money'

/* Insert Library */

-- 1.
Insert into @insertedLibrary(library_id)
Exec SP_Library_Insert
@user_id = @UserId1,
@game_id = @GameId1,
@state = 'New'

declare @LibId1 int;
Select @LibId1 = library_id from @insertedLibrary
Delete From @insertedLibrary

-- 2.
Insert into @insertedLibrary(library_id)
Exec SP_Library_Insert
@user_id = @UserId1,
@game_id = @GameId2,
@state = 'Incomplete'

declare @LibId2 int;
Select @LibId2 = library_id from @insertedLibrary
Delete From @insertedLibrary

-- 3.
Insert into @insertedLibrary(library_id)
Exec SP_Library_Insert
@user_id = @UserId2,
@game_id = @GameId3,
@state = 'Damaged'

declare @LibId3 int;
Select @LibId3 = library_id from @insertedLibrary
Delete From @insertedLibrary

-- 4.
Insert into @insertedLibrary(library_id)
Exec SP_Library_Insert
@user_id = @UserId3,
@game_id = @GameId4,
@state = 'New'

declare @LibId4 int;
Select @LibId4 = library_id from @insertedLibrary
Delete From @insertedLibrary

-- 5.
Insert into @insertedLibrary(library_id)
Exec SP_Library_Insert
@user_id = @UserId4,
@game_id = @GameId4,
@state = 'New'

declare @LibId5 int;
Select @LibId5 = library_id from @insertedLibrary
Delete From @insertedLibrary