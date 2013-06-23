

USE [GenealogyDB]
GO

-- delete any existing records
delete from [GenealogyDB].[dbo].[People]
go
delete from [GenealogyDB].[dbo].[Fathers]
go
delete from [GenealogyDB].[dbo].[Mothers]
go
delete from [GenealogyDB].[dbo].[Lists]
go
delete from [GenealogyDB].[dbo].[Users]
go
delete from [GenealogyDB].[dbo].[Logins]
go

-- insert new records
set identity_insert [GenealogyDB].[dbo].[Fathers] on
INSERT INTO [GenealogyDB].[dbo].[Fathers] ([fatherId],[fatherKnown],[fFirstName],[fLastName],[fGivenName])
VALUES	(1, 1, 'John', 'Johnson', 'Johnson'),
		(2, 1, 'Travis', 'Traviseron', 'Traviseron'),
		(3, 1, 'Barry', 'Barryon', 'Barryon'),
		(4, 1, 'Pocket', 'Pocketson', 'Pockety'),
		(5, 1, 'Nerple', 'Derple', 'Schmo')
set identity_insert [GenealogyDB].[dbo].[Fathers] off

set identity_insert [GenealogyDB].[dbo].[Mothers] on
INSERT INTO [GenealogyDB].[dbo].[Mothers] ([motherId],[motherKnown], [mFirstName],[mLastName],[mGivenName])
VALUES	(1, 1, 'Kate', 'Kateness', 'Schmo'),
		(2, 1, 'Mary', 'Mandyson', 'Mandyson'),
		(3 ,1, 'Carol', 'Carter', 'Schmo'),
		(4, 1, 'Sandy', 'Sanderson', 'Sandman'),
		(5, 1, 'Kelty', 'Kelterson', 'Schmo')
set identity_insert [GenealogyDB].[dbo].[Mothers] off

set identity_insert [GenealogyDB].[dbo].[lists] on
INSERT INTO [GenealogyDB].[dbo].[Lists] ([listId],[knownPersonQuantity],[unknownPersonQuantity])
values (1, 1, 1), (2,2,1), (3,3,1), (4,4,1), (5,5,1);
set identity_insert [GenealogyDB].[dbo].[lists] off

set identity_insert [GenealogyDB].[dbo].[people] on
INSERT INTO [dbo].[People] ([personID],[firstName],[lastName],[givenName],[gender],[birthDate],[birthPlace],[deathDate],[deathPlace],[occupation],[Lists_listId],[Fathers_fatherId],[Mothers_motherId])
VALUES  (1, 'Crafty', 'Craftman', 'Craftman', 'male', 'March 21, 2000', 'Springfield', 'March 21, 2092', 'Springfield', 'craftsman', 1, 1, 1),
		(2, 'Barbie', 'Kenson', 'Schmo', 'female', 'January 21, 1980', 'Lafayette', 'January 21, 2062', 'Lafayette', 'model', 2, 2, 2),
		(3, 'Dough', 'Boy', 'Ginger', 'male', 'November 21, 1960', 'Greenville', 'November 21, 2032', 'Greenville', 'pastry', 3, 3, 3),
		(4, 'Nutty', 'Professor', 'Professor', 'male', 'September 21, 1940', 'Georgetown', 'September 21, 2002', 'Georgetown', 'professor', 4, 4, 4),
		(5,'Carol', 'Singerton', 'Craftman', 'female', 'July 21, 1920', 'Clayton', 'July 21, 1972', 'Clayton', 'Singer', 5, 5, 5)
set identity_insert [GenealogyDB].[dbo].[people] off



set identity_insert [GenealogyDB].[dbo].[Logins] on
INSERT INTO [GenealogyDB].[dbo].[Logins] ([loginId],[username],[password])
VALUES	(1,'ppiper', '1Pickle!'),
		(2,'mLamb', '2Fleece@'),
		(3,'jsprat', 'Eat3#'),
		(4,'mmuffet', '$4Spiders'),
		(5,'hdumpty', '5%Egg')
set identity_insert [GenealogyDB].[dbo].[Logins] off

set identity_insert [GenealogyDB].[dbo].[Users] on
INSERT INTO [GenealogyDB].[dbo].[Users] ([userid], [userFirstName],[userLastName],[userEmail],[Login_loginId])
values	(1, 'Peter', 'Piper', 'peter.piper@email.com', 1),
		(2, 'Mary', 'Lamb', 'mary.lamb@email.com', 2),
		(3, 'Jack', 'Sprat', 'jack.sprat@email.com', 3),
		(4, 'Miss', 'Muffet', 'miss.muffet@email.com', 4),
		(5, 'Humpty', 'Dumpty', 'humty.dumpty@email.com', 5)
set identity_insert [GenealogyDB].[dbo].[Users] off
