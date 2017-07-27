use Master
go 

if db_id('TeamA') is not null
begin
	drop database TeamA 
end 
go

create database TeamA
go

use TeamA
go


/******************************************
create tables
******************************************/

create table Teams
(-- Table Name			Data Type			Constraints
	TeamID				tinyint				primary key identity (100,1)
	,TeamName			varchar(30)			not null
	,Coach				varchar(150)		null
)

SET IDENTITY_INSERT Teams ON
insert into Teams(TeamID, TeamName, Coach)
	values(100, 'Sounders', null)
SET IDENTITY_INSERT Teams OFF
go

create table Players
(-- Table Name			Data Type			Constraints
	PlayerID			smallint			primary key identity (1000,1) -- (1,1) is the seed and the increment, in that order
	,TeamID				tinyint				not null
	,PlayerFirstName	varchar(30)			not null
	,PlayerLastName		varchar(40)			not null
	,PlayerPhone		varchar(20)	
	,PlayerEmail		varchar(50)			not null
)
SET IDENTITY_INSERT Players ON
insert into Players(PlayerID, TeamID, PlayerFirstName, PlayerLastName, PlayerPhone, PlayerEmail)
	values(1, 1, 'Clint', 'Dempsey', null, 'dempsey@sounders.com')
SET IDENTITY_INSERT Players OFF
go


