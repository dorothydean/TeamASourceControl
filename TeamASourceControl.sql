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
	TeamID				tinyint				primary key identity (1000,1)
	,TeamName			varchar(30)			not null
	,Coach				varchar(150)		null
)

insert into Teams(TeamID, TeamName, Coach)
	values(1, 'Sounders', null)

go

create table Players
(-- Table Name			Data Type			Constraints
	PlayerID			smallint			primary key identity (1000,1) -- (1,1) is the seed and the increment, in that order
	,TeamID				tinyint				references Teams(TeamID) -- data types have to match
	,PlayerFirstName	varchar(30)			not null
	,PlayerLastName		varchar(40)			not null
	,PlayerPhone		varchar(20)	
	,PlayerEmail		varchar(50)			not null
)
insert into Players(PlayerID, TeamID, PlayerFirstName, PlayerLastName, PlayerPhone, PlayerEmail)
	values(1, 1, 'Clint', 'Dempsey', null, 'dempsey@sounders.com')

go


