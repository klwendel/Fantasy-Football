/*Check to see if the database exists, and if so, drop the table and re-create*/
IF EXISTS(SELECT 1 FROM master.dbo.sysdatabases WHERE name='FantasyFootballDB')
BEGIN
DROP DATABASE FantasyFootballDB
END
GO

CREATE DATABASE FantasyFootballDB
GO

USE [FantasyFootballDB]
GO

/* OBJECT: TABLE [dbo].[SecurityRoles] */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SecurityRoles](
	[RoleID] 		[int] IDENTITY(1,1)		NOT NULL,
	[Description] 	[varchar](35)			NULL,
	CONSTRAINT [PK_RoleID] PRIMARY KEY CLUSTERED ([RoleID] ASC)
	WITH (PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF,IGNORE_DUP_KEY=OFF,ALLOW_ROW_LOCKS=ON, ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]
) 	ON [PRIMARY]
GO

/*Inserts for [dbo].[SecurityRoles]*/
SET ANSI_PADDING OFF
GO
INSERT INTO [dbo].[SecurityRoles] ([Description])
	VALUES ('League Administrator')
INSERT INTO [dbo].[SecurityRoles] ([Description])
	VALUES ('Team Owner')	
GO

/* OBJECT: TABLE [dbo].[Owners]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Owners](
	[OwnerID] 		[int] IDENTITY(1,1)  	NOT NULL,
	[FirstName] 	[varchar](35) 			NOT NULL,
	[LastName] 		[varchar](35) 			NOT NULL,
	[RoleID]		[int]					NOT NULL, /*FK Constraint to the SecurityRoles table.*/
	[Active] 		[bit] 					NOT NULL			DEFAULT'1',
	CONSTRAINT [PK_OwnerID] PRIMARY KEY CLUSTERED ([OwnerID] ASC)
	WITH (PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF,IGNORE_DUP_KEY=OFF,ALLOW_ROW_LOCKS=ON, ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]
) 	ON [PRIMARY]
GO

/*Creates [FK_Owner_RoleID] constraint*/	
ALTER TABLE [dbo].[Owners] WITH NOCHECK ADD CONSTRAINT [FK_Owner_RoleID] FOREIGN KEY([RoleID])
	REFERENCES [dbo].[SecurityRoles] ([RoleID])
GO

/*Inserts for [dbo].[Owners]*/
SET ANSI_PADDING OFF
GO
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('Kaleb', 'Wendel', 1)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('Black', 'Panther', 2)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('Iron', 'Man', 2)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('Captain', 'America', 2)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('Spider', 'Man', 1)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('Winter', 'Soldier', 2)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('The', 'Hulk', 2)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('Doctor', 'Strange', 2)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID], [Active])
	VALUES ('Luke', 'Cage', 2, 0)
INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID])
	VALUES ('Iron', 'Patriot', 1)
GO
	
/* Object: Table [dbo].[Users]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Users](
	[Username]		[varchar](35)			NOT NULL,
	[Password]		[varchar](235)			NOT NULL,
	[OwnerID]		[int]					NOT NULL, /*FK Constraint to the Owners table.*/
	[Active]		[bit] 					NOT NULL		DEFAULT'1', 		
	CONSTRAINT [PK_Username] PRIMARY KEY CLUSTERED ([Username]ASC)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) 	ON [PRIMARY]
GO

/*Creates [FK_User_OwnerID] constraint*/	
ALTER TABLE [dbo].[Users] WITH NOCHECK ADD CONSTRAINT [FK_User_OwnerID] FOREIGN KEY([OwnerID])
	REFERENCES [dbo].[Owners] ([OwnerID])
GO

/*Inserts for [dbo].[Users]*/
SET ANSI_PADDING OFF
GO
INSERT INTO [dbo].[Users] ([Username], [Password], [OwnerID])
	VALUES ('kwendel', 'password', 1)
INSERT INTO [dbo].[Users] ([Username], [Password], [OwnerID])
	VALUES ('testuser2', 'password', 2)
INSERT INTO [dbo].[Users] ([Username], [Password], [OwnerID] , [Active])
	VALUES ('testuser3', 'password', 3, 0)
	
	
/* OBJECT: TABLE [dbo].[Leagues]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Leagues](
	[LeagueID]		[int] IDENTITY(1,1)		NOT NULL,
	[Name]			[varchar](35) 			NOT NULL,
	[OwnerID] 		[int] 					NOT NULL, /*FK Constraint to the Owners table.*/
	[TeamLimit] 	[int] 					NOT NULL,
	[CreationDate] 	[datetime] 				NOT NULL		DEFAULT GETDATE(),
	[Active] 		[bit] 					NOT NULL		DEFAULT '1',
	CONSTRAINT [PK_LeagueID] PRIMARY KEY CLUSTERED ([LeagueID] ASC)
	WITH (PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF,IGNORE_DUP_KEY=OFF,ALLOW_ROW_LOCKS=ON, ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]
)	ON [PRIMARY]
GO

/*Creates [FK_League_OwnerID] constraint*/	
ALTER TABLE [dbo].[Leagues] WITH NOCHECK ADD CONSTRAINT [FK_League_OwnerID] FOREIGN KEY([OwnerID])
	REFERENCES [dbo].[Owners] ([OwnerID])
GO

/*Inserts for [dbo].[Leagues]*/
SET ANSI_PADDING OFF
GO
INSERT INTO [dbo].[Leagues] ([Name], [OwnerID], [TeamLimit], [CreationDate])
	VALUES ('League One', 1, 4, '8/1/2013')
INSERT INTO [dbo].[Leagues] ([Name], [OwnerID], [TeamLimit], [CreationDate])
	VALUES ('League Two', 5, 6, '8/15/2013')
INSERT INTO [dbo].[Leagues] ([Name], [OwnerID], [TeamLimit], [Active])
	VALUES ('League Three', 10, 12, 0)
GO

/* OBJECT: TABLE [dbo].[Teams]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Teams](
	[TeamID] 		[int] IDENTITY(1,1)		NOT NULL,
	[Name] 			[varchar](35) 			NOT NULL,
	[OwnerID] 		[int] 					NOT NULL, /*FK Constraint to the Owners table.*/
	[LeagueID] 		[int]					NOT NULL, /*FK Constraint to the Leagues table*/
	[Active] 		[bit] 					NOT NULL			DEFAULT'1',
	CONSTRAINT [PK_TeamID] PRIMARY KEY CLUSTERED ([TeamID] ASC)
	WITH (PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF,IGNORE_DUP_KEY=OFF,ALLOW_ROW_LOCKS=ON, ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]
) 	ON [PRIMARY]
GO

/*Creates [FK_Team_LeagueID] constraint*/
ALTER TABLE [dbo].[Teams] WITH NOCHECK ADD CONSTRAINT [FK_Team_LeagueID] FOREIGN KEY([LeagueID])
	REFERENCES [dbo].[Leagues] ([LeagueID])
GO

/*Creates [FK_Team_OwnerID] constraint*/
ALTER TABLE [dbo].[Teams] WITH NOCHECK ADD CONSTRAINT [FK_Team_OwnerID] FOREIGN KEY([OwnerID])
	REFERENCES [dbo].[Owners] ([OwnerID])
GO

/*Inserts for [dbo].[Teams]*/
SET ANSI_PADDING OFF
GO
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID])
	VALUES ('Team Wendel1', 1, 1)
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID])
	VALUES ('Team2', 2, 1)
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID])
	VALUES ('Team3', 3, 1)
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID])
	VALUES ('Team4', 4, 1)
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID])
	VALUES ('Team5', 5, 2)
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID])
	VALUES ('Team6', 6, 2)
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID])
	VALUES ('Team7', 7, 2)
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID])
	VALUES ('Team8', 9, 2)
INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID], [Active])
	VALUES ('Team Wendel2', 1, 2, 0)
GO

/* OBJECT: TABLE [dbo].[Positions]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Positions](
	[PositionID] 	[int] IDENTITY(1,1) 	NOT NULL,
	[Description]	[varchar](35)			NOT NULL,
	CONSTRAINT [PK_PositionID] PRIMARY KEY CLUSTERED ([PositionID] ASC)
	WITH (PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF,IGNORE_DUP_KEY=OFF,ALLOW_ROW_LOCKS=ON, ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]
) 	ON [PRIMARY]
GO

/*Inserts for [dbo].[Positions]*/
SET ANSI_PADDING OFF
GO
INSERT INTO [dbo].[Positions]([Description])
	VALUES ('Quarterback')
INSERT INTO [dbo].[Positions]([Description])
	VALUES ('Running Back')
INSERT INTO [dbo].[Positions]([Description])
	VALUES ('Wide Receiver')
INSERT INTO [dbo].[Positions]([Description])
	VALUES ('Tight End')
INSERT INTO [dbo].[Positions]([Description])
	VALUES ('Defensive Line')
INSERT INTO [dbo].[Positions]([Description])
	VALUES ('Linebacker')
INSERT INTO [dbo].[Positions]([Description])
	VALUES ('Defensive Back')
INSERT INTO [dbo].[Positions]([Description])
	VALUES ('Defense')

/* OBJECT: TABLE [dbo].[Rosters]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rosters](
	[PlayerID] 		[int] IDENTITY(1,1) 	NOT NULL,
	[FirstName]		[varchar](35)			NOT NULL,
	[LastName]		[varchar](35)			NOT NULL,
	[Position]		[int]					NOT NULL, /*FK Constraint to the Positions table.*/
	[TeamID] 		[int]					NOT NULL, /*FK Constraint to the Teams table.*/
	[Active] 		[bit] 					NOT NULL			DEFAULT'1',
	CONSTRAINT [PK_PlayerID] PRIMARY KEY CLUSTERED ([PlayerID] ASC)
	WITH (PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF,IGNORE_DUP_KEY=OFF,ALLOW_ROW_LOCKS=ON, ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]
) 	ON [PRIMARY]
GO

/*Creates [FK_Rosters_TeamID] constraint*/
ALTER TABLE [dbo].[Rosters] WITH NOCHECK ADD CONSTRAINT [FK_Roster_TeamID] FOREIGN KEY([TeamID])
	REFERENCES [dbo].[Teams] ([TeamID])
GO

/*Creates [FK_Positions_PositionID] constraint*/
ALTER TABLE [dbo].[Rosters] WITH NOCHECK ADD CONSTRAINT [FK_Positions_PositionID] FOREIGN KEY([Position])
	REFERENCES [dbo].[Positions] ([PositionID])
GO

/*Inserts for [dbo].[Rosters]*/
SET ANSI_PADDING OFF
GO
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Drew', 'Brees', 1, 1)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Marshawn', 'Lynch', 2, 1)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Peyton', 'Manning', 1, 2)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Andre', 'Johnson', 3,2)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Andrew', 'Luck', 1, 3)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Jamal', 'Charles', 2, 4)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Adrian', 'Peterson', 2, 5)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Matt', 'Forte', 2, 6)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Aaron', 'Rodgers', 1, 7)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('A.J.', 'Green', 3, 8)
INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID])
	VALUES ('Calvin', 'Johnson', 3, 9)
GO

/*Object:  StoredProcedure [dbo].[spGetLeagueList]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetLeagueList]
AS
	SELECT [Leagues].[LeagueID], [Leagues].[Name], [Leagues].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Leagues].[TeamLimit], [Leagues].[CreationDate], [Leagues].[Active]
	FROM [Leagues] INNER JOIN [Owners]
	ON [Leagues].[OwnerID] = [Owners].[OwnerID]
	ORDER BY [Leagues].[Active] DESC, [Leagues].[OwnerID], [Leagues].[Name]
	Return
GO

/*Object:  StoredProcedure [dbo].[spGetLeagueListByActive]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetLeagueListByActive]
	(@Active	[bit])
AS
	SELECT [Leagues].[LeagueID], [Leagues].[Name], [Leagues].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Leagues].[TeamLimit], [Leagues].[CreationDate], [Leagues].[Active]
	FROM [Leagues] INNER JOIN [Owners]
	ON [Leagues].[OwnerID] = [Owners].[OwnerID]
	WHERE [Leagues].[Active] = @Active
	ORDER BY [Leagues].[OwnerID], [Leagues].[Name]
	Return
GO

/*Object:  StoredProcedure [dbo].[spDeactivateLeague]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spDeactivateLeague]
	(@LeagueID [int])
AS
	UPDATE [dbo].[Leagues]
	SET [Active] = 0
	WHERE [LeagueID] = @LeagueID
	Return @@Rowcount
GO

/*Object:  StoredProcedure [dbo].[spActivateLeague]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spActivateLeague]
	(@LeagueID [int])
AS
	UPDATE [dbo].[Leagues]
	SET [Active] = 1
	WHERE [LeagueID] = @LeagueID
	Return @@Rowcount
GO

/*Object:  StoredProcedure [dbo].[spAddLeague]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spAddLeague]
	(@Name		[varchar](35),
	@OwnerID	[int],
	@TeamLimit	[int],
	@Active		[bit])
AS
	INSERT INTO [dbo].[Leagues] ([Name], [OwnerID], [TeamLimit], [Active])
		VALUES (@Name, @OwnerID, @TeamLimit, @Active)
	RETURN @@ROWCOUNT
GO

/*Object:  StoredProcedure [dbo].[spEditLeague]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spEditLeague]
	(@LeagueID		[int],
	@Name			[varchar](35),
	@OldName		[varchar](35),
	@OwnerID		[int],
	@OldOwnerID		[int],
	@TeamLimit		[int],
	@OldTeamLimit	[int],
	@Active			[bit],
	@OldActive		[bit])
AS
	UPDATE [dbo].[Leagues] 
	SET [Name] = @Name, [OwnerID] = @OwnerID, [TeamLimit] = @TeamLimit, [Active] = @Active
	WHERE [LeagueID] = @LeagueID
	AND [Name] = @OldName
	AND [OwnerID] = @OldOwnerID
	AND [TeamLimit] = @OldTeamLimit
	AND [Active] = @OldActive
	RETURN @@ROWCOUNT
GO

/*Object:  StoredProcedure [dbo].[spGetOwnerList]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetOwnerList]
AS
	SELECT [Owners].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Owners].[RoleID], [SecurityRoles].[Description], [Owners].[Active]
	FROM [Owners] INNER JOIN [SecurityRoles]
	ON [Owners].[RoleID] = [SecurityRoles].[RoleID]
	ORDER BY [Owners].[Active] DESC, [Owners].[RoleID], [Owners].[LastName], [Owners].[FirstName]
	Return
GO

/*Object:  StoredProcedure [dbo].[spGetOwnerListByActive]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetOwnerListByActive]
	(@Active	[int])
AS
	SELECT [Owners].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Owners].[RoleID], [SecurityRoles].[Description], [Owners].[Active]
	FROM [Owners] INNER JOIN [SecurityRoles]
	ON [Owners].[RoleID] = [SecurityRoles].[RoleID]
	WHERE [Owners].[Active] = @Active
	ORDER BY [Owners].[Active] DESC, [Owners].[RoleID], [Owners].[LastName], [Owners].[FirstName]
	Return
GO

/*Object:  StoredProcedure [dbo].[spGetAdminOwnerList]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetAdminOwnerList]
AS
	SELECT [Owners].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Owners].[RoleID], [SecurityRoles].[Description], [Owners].[Active]
	FROM [Owners] INNER JOIN [SecurityRoles]
	ON [Owners].[RoleID] = [SecurityRoles].[RoleID]
	WHERE [Owners].[RoleID] = '1'
	AND [Owners].[Active] = '1'
	ORDER BY [Owners].[LastName], [Owners].[FirstName]
	Return
GO

/*Object:  StoredProcedure [dbo].[spDeactivateOwner]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spDeactivateOwner]
	(@OwnerID 	[int])
AS
	UPDATE [dbo].[Owners]
	SET [Active] = 0
	WHERE [OwnerID] = @OwnerID
	Return @@Rowcount
GO

/*Object:  StoredProcedure [dbo].[spActivateOwner]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spActivateOwner]
	(@OwnerID 	[int])
AS
	UPDATE [dbo].[Owners]
	SET [Active] = 1
	WHERE [OwnerID] = @OwnerID
	Return @@Rowcount
GO

/*Object:  StoredProcedure [dbo].[spAddOwner]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spAddOwner]
	(@FirstName		[varchar](35),
	@LastName		[varchar](35),
	@RoleID			[int],
	@Active			[bit])
AS
	INSERT INTO [dbo].[Owners] ([FirstName], [LastName], [RoleID], [Active])
		VALUES (@FirstName, @LastName, @RoleID, @Active)
	RETURN @@ROWCOUNT
GO
	
/*Object:  StoredProcedure [dbo].[spEditOwner]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spEditOwner]
	(@OwnerID		[int],
	@FirstName		[varchar](35),
	@OldFirstName	[varchar](35),
	@LastName		[varchar](35),
	@OldLastName	[varchar](35),
	@RoleID			[int],
	@OldRoleID		[int],
	@Active			[bit],
	@OldActive		[bit])
AS
	UPDATE [dbo].[Owners] 
	SET [FirstName] = @FirstName, [LastName] = @LastName, [RoleID] = @RoleID, [Active] = @Active
	WHERE [OwnerID] = @OwnerID
	AND [FirstName] = @OldFirstName
	AND [LastName] = @OldLastName
	AND [RoleID] = @OldRoleID
	AND [Active] = @OldActive
	RETURN @@ROWCOUNT
GO

/*Object:  StoredProcedure [dbo].[spGetRoleList]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetRoleList]
AS
	SELECT [RoleID], [Description]
	FROM [SecurityRoles]
	ORDER BY [Description]
	Return
GO

/*Object:  StoredProcedure [dbo].[spGetTeamListByLeague]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetTeamListByLeague]
	(@LeagueID		[int])
AS
	SELECT [Teams].[TeamID], [Teams].[Name], [Teams].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Teams].[LeagueID], [Leagues].[Name], [Teams].[Active]
	FROM [Teams] INNER JOIN [Owners]
	ON [Teams].[OwnerID] = [Owners].[OwnerID]
	INNER JOIN [Leagues]
	ON[Teams].[LeagueID] = [Leagues].[LeagueID]
	WHERE [Teams].[LeagueID] = @LeagueID
	ORDER BY [Teams].[Active] DESC, [Teams].[LeagueID], [Teams].[Name]	Return
GO

/*Object:  StoredProcedure [dbo].[spGetTeamListByActive]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetTeamListByActive]
	(@Active		[bit])
AS
	SELECT [Teams].[TeamID], [Teams].[Name], [Teams].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Teams].[LeagueID], [Leagues].[Name], [Teams].[Active]
	FROM [Teams] INNER JOIN [Owners]
	ON [Teams].[OwnerID] = [Owners].[OwnerID]
	INNER JOIN [Leagues]
	ON[Teams].[LeagueID] = [Leagues].[LeagueID]
	WHERE [Teams].[Active] = @Active
	ORDER BY [Teams].[Active] DESC, [Teams].[LeagueID], [Teams].[Name]	Return
GO

/*Object:  StoredProcedure [dbo].[spGetTeamListByLeagueActive]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetTeamListByLeagueActive]
	(@LeagueID		[int],
	@Active 		[bit])
AS
	SELECT [Teams].[TeamID], [Teams].[Name], [Teams].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Teams].[LeagueID], [Leagues].[Name], [Teams].[Active]
	FROM [Teams] INNER JOIN [Owners]
	ON [Teams].[OwnerID] = [Owners].[OwnerID]
	INNER JOIN [Leagues]
	ON[Teams].[LeagueID] = [Leagues].[LeagueID]
	WHERE [Teams].[LeagueID] = @LeagueID
	AND [Teams].[Active] = @Active
	ORDER BY [Teams].[LeagueID], [Teams].[Name]
	Return
GO

/*Object:  StoredProcedure [dbo].[spDeactivateTeam]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spDeactivateTeam]
	(@TeamID 	[int])
AS
	UPDATE [dbo].[Teams]
	SET [Active] = 0
	WHERE [TeamID] = @TeamID
	Return @@Rowcount
GO

/*Object:  StoredProcedure [dbo].[spActivateTeam]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spActivateTeam]
	(@TeamID 	[int])
AS
	UPDATE [dbo].[Teams]
	SET [Active] = 1
	WHERE [TeamID] = @TeamID
	Return @@Rowcount
GO

/*Object:  StoredProcedure [dbo].[spAddTeam]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spAddTeam]
	(@Name			[varchar](35),
	@OwnerID		[int],
	@LeagueID		[int],
	@Active			[bit])
AS
	INSERT INTO [dbo].[Teams] ([Name], [OwnerID], [LeagueID], [Active])
		VALUES (@Name, @OwnerID, @LeagueID, @Active)
	RETURN @@ROWCOUNT
GO

/*Object:  StoredProcedure [dbo].[spEditTeam]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spEditTeam]
	(@Name			[varchar](35),
	@OldName		[varchar](35),
	@OwnerID		[int],
	@OldOwnerID		[int],
	@LeagueID		[int],
	@OldLeagueID	[int],
	@Active			[bit], 
	@OldActive		[bit],
	@TeamID			[int])
AS
	UPDATE [dbo].[Teams] 
	SET [Name] = @Name, [OwnerID] = @OwnerID, [LeagueID] = @LeagueID, [Active] = @Active
	WHERE [Name] = @OldName
	AND [OwnerID] = @OldOwnerID
	AND [LeagueID] = @OldLeagueID
	AND [Active] = @OldActive
	RETURN @@ROWCOUNT
GO

/*Object:  StoredProcedure [dbo].[spGetTeamList]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetTeamList]
AS
	SELECT [Teams].[TeamID], [Teams].[Name], [Teams].[OwnerID], [Owners].[FirstName], [Owners].[LastName], [Teams].[LeagueID], [Leagues].[Name], [Teams].[Active]
	FROM [Teams] INNER JOIN [Owners]
	ON [Teams].[OwnerID] = [Owners].[OwnerID]
	INNER JOIN [Leagues]
	ON[Teams].[LeagueID] = [Leagues].[LeagueID]
	Return
GO

/*Object:  StoredProcedure [dbo].[spGetRosterListByTeam]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetRosterListByTeam]
	(@TeamID	[int])
AS
	SELECT [Rosters].[PlayerID], [Rosters].[FirstName], [Rosters].[LastName], [Rosters].[Position], [Positions].[Description], [Rosters].[TeamID], [Teams].[Name], [Rosters].[Active]
	FROM [Rosters] INNER JOIN [Positions]
	ON [Rosters].[Position] = [Positions].[PositionID]
	INNER JOIN [Teams]
	ON [Rosters].[TeamID] = [Teams].[TeamID]
	WHERE [Rosters].[TeamID] = @TeamID
	ORDER BY [Rosters].[Active] DESC, [Rosters].[Position], [Rosters].[LastName], [Rosters].[FirstName]
	Return
GO

/*Object:  StoredProcedure [dbo].[spGetRosterListByTeamActive]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetRosterListByTeamActive]
	(@TeamID	[int],
	@Active		[bit])
AS
	SELECT [Rosters].[PlayerID], [Rosters].[FirstName], [Rosters].[LastName], [Rosters].[Position], [Positions].[Description], [Rosters].[TeamID], [Teams].[Name], [Rosters].[Active]
	FROM [Rosters] INNER JOIN [Positions]
	ON [Rosters].[Position] = [Positions].[PositionID]
	INNER JOIN [Teams]
	ON [Rosters].[TeamID] = [Teams].[TeamID]
	WHERE [Rosters].[TeamID] = @TeamID
	AND [Rosters].[Active] = @Active
	ORDER BY [Rosters].[Active] DESC, [Rosters].[Position], [Rosters].[LastName], [Rosters].[FirstName]
	Return
GO

/*Object:  StoredProcedure [dbo].[spDeactivatePlayer]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spDeactivatePlayer]
	(@PlayerID 		[int])
AS
	UPDATE [dbo].[Rosters]
	SET [Active] = 0
	WHERE [PlayerID] = @PlayerID
	Return @@Rowcount
GO

/*Object:  StoredProcedure [dbo].[spActivatePlayer]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spActivatePlayer]
	(@PlayerID 		[int])
AS
	UPDATE [dbo].[Rosters]
	SET [Active] = 1
	WHERE [PlayerID] = @PlayerID
	Return @@Rowcount
GO

/*Object:  StoredProcedure [dbo].[spAddPlayer]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spAddPlayer]
	(@FirstName		[varchar](35),
	@LastName		[varchar](35),
	@Position		[int],
	@TeamID			[int],
	@Active			[bit])
AS
	INSERT INTO [dbo].[Rosters] ([FirstName], [LastName], [Position], [TeamID], [Active])
		VALUES (@FirstName, @LastName, @Position, @TeamID, @Active)
	RETURN @@ROWCOUNT
GO

/*Object:  StoredProcedure [dbo].[spEditTeam]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spEditPlayer]
	(@FirstName		[varchar](35),
	@OldFirstName	[varchar](35),
	@LastName		[varchar](35),
	@OldLastName	[varchar](35),
	@Position		[int],
	@OldPosition	[int],
	@TeamID			[int],
	@OldTeamID		[int],
	@Active			[bit],
	@OldActive		[bit],
	@PlayerID		[int])
AS
	UPDATE [dbo].[Rosters] 
	SET [FirstName] = @FirstName, [LastName] = @LastName, [Position] = @Position, [TeamID] = @TeamID, [Active] = @Active
	WHERE [FirstName] = @OldFirstName
	AND [LastName] = @OldLastName
	AND [Position] = @OldPosition
	AND [TeamID] = @OldTeamID
	AND [Active] = @OldActive
	AND [PlayerID] = @PlayerID
	RETURN @@ROWCOUNT
GO

/*Object:  StoredProcedure [dbo].[spGetPositionList]*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE PROCEDURE [dbo].[spGetPositionList]
AS
	SELECT [PositionID], [Description]
	FROM [Positions]
	ORDER BY [Description]
	Return
GO
