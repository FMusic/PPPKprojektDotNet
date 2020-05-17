USE [master]
GO

DECLARE @dbname nvarchar(128)
SET @dbname = N'pppk1db'
IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = @dbname OR name = @dbname)))
	begin
	PRINT 'db exists, deleting ...'
	drop database[pppk1db]
end
create database [pppk1db]
go
USE [pppk1db]
GO

CREATE LOGIN [pppk] WITH PASSWORD='pppk', 
	DEFAULT_DATABASE=[pppk1db], 
	DEFAULT_LANGUAGE=[us_english], 
	CHECK_EXPIRATION=OFF,
	CHECK_POLICY=OFF
GO

ALTER LOGIN [pppk] DISABLE
GO
ALTER SERVER ROLE [serveradmin] ADD MEMBER [pppk]
GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [pppk]
GO
CREATE USER [pppk] FOR LOGIN [pppk] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [pppk]
GO
ALTER ROLE [db_datareader] ADD MEMBER [pppk]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [pppk]
GO
ALTER LOGIN [pppk] ENABLE
GO

create table Drivers(
	IDDriver int primary key identity(1,1),
	[Name] nvarchar(20),
	[Surname] nvarchar(20),
	phoneNumber nvarchar(20),
	driversLicenseID nvarchar(30)
)
create table Vehicles(
	IDVehicle int primary key identity(1,1),
	[Type] nvarchar(10),
	[Maker] nvarchar(10),
	[YearOfMaking] int,
	[miles] int
)
create table WarrantStateEnum(
	IDWarrantState int primary key identity(1,1),
	[State] nvarchar(6)
)
insert into WarrantStateEnums([State]) values ('Open'), ('Closed'), ('Future')
create table travelWarrants(
	IDTwarrant int primary key identity(1,1),
	DriverID int foreign key references Drivers(IDDriver),
	VehicleID int foreign key references Vehicles(IDVehicle),
	WarrantStateEnumId int foreign key references WarrantStateEnum(IDWarrantState)
)
create table [CarServices] (
	IDService int primary key identity(1,1),
	VehicleID int foreign key references Vehicles(IDVehicle),
	[Date] date
)
create table [Routes](
	IDRoute int primary key identity(1,1),
	WarrantID int foreign key references travelWarrants(IDTwarrant),
	DateFrom datetime,
	DateTo datetime,
	CoordA nvarchar(20),
	CoordB nvarchar(20),
	DistanceInKm int,
	AvgV int,
	FuelSpent int
)
create table Fuels(
	IDFuel int primary key identity(1,1),
	DriverId int foreign key references Drivers(IDDriver),
	DateWhen date,
	TimeWhen time,
	[Location] nvarchar(20),
	Quantity int,
	Price int,
	VehicleID int foreign key references Vehicles(IDVehicle)
)
create table ServiceItems(
	IDItem int primary key identity(1,1),
	[Name] nvarchar(30),
	[TotalPrice]  money,
	CarServiceID int foreign key references CarServices(IDService)
)
go
create proc cleanDatabase
as
	delete from Drivers
	delete from Vehicles
	delete from travelWarrants
	delete from Routes
	delete from Fuels
	delete from CarServices
go
--create proc getDatabase
--as
--	select * from Drivers
--	select * from Vehicles
--	select * from travelWarrants
--	select * from Routes
--	select * from Fuels
--	select * from CarServices
go
create proc putTestData
as
	insert into Drivers([Name], Surname, phoneNumber, driversLicenseID) values
		('Ana', 'Anic', '099999999', 'necemireci'),
		('Pero', 'Peric', '58932752', 'nezna'),
		('Ante', 'Antic', '57238752', 'nema'),
		('Ivan', 'Horvat', '70432342', 'nece')
	insert into Vehicles([Type], Maker, miles, YearOfMaking) values
		('Fabia', 'Skoda', 25000, 1999),
		('Felicia', 'Skoda', 350000, 1980),
		('Yugo', 'Zastava', 0, 1975),
		('Uno', 'Fiat', 420000, 1995)
	insert into travelWarrants(DriverID, VehicleID, WarrantStateEnumId) values
		(1,2,3), 
		(2, 3, 1), 
		(3, 1, 1),
		(2, 2, 3)
	insert into Routes(DateFrom, DateTo, CoordA, CoordB, WarrantID, DistanceInKm, AvgV, FuelSpent) values
		('2019-12-09', '2019-12-10', 4032804, 4032806, 4, 300, 45, 9),
		('2019-12-20', '2019-12-31', 4032816, 4032820, 3, 2500, 90, 20)
	insert into Fuels(DateWhen, DriverId, [Location], Price, Quantity, TimeWhen, VehicleID) values
		('2019-09-09', 2, 'Split', 450, 45, '11:20:00', 3)
	insert into CarServices(VehicleID, Date) values
		(2, '2019-09-25'),
		(1, '1999-12-30'),
		(3, '2009-06-05'),
		(4, '2004-03-10')
go

exec cleanDatabase
exec putTestData
go
create proc GetAllTravelWarrants
as 
	select * from travelWarrants
go
create proc DeleteWarrant
	@warrantid int
as
	delete from travelWarrants where IDTwarrant = @warrantid
go
alter proc DeleteWarrant
	@warrantid int
as
	delete from Routes where WarrantID = @warrantid
	delete from travelWarrants where IDTwarrant = @warrantid
go
create proc SaveWarrant
	@driverid int,
	@vehicleid int,
	@warrantstateid int
as
	insert into travelWarrants(DriverID, VehicleID, WarrantStateEnumId) values
	(@driverid, @vehicleid, @warrantstateid)
	select scope_identity()
go
create proc GetRoutesForWarrant
	@warrantid int
as
	select * from Routes where WarrantID = @warrantid
go
create proc DeleteRoute
	@routeID int
as 
	delete from Routes where IDRoute = @routeID
go
create proc SaveRoute 
	@routeId int,
	@warrantId int,
	@datestart datetime,
	@dateend datetime,
	@coordA nvarchar(20),
	@coordB nvarchar(20),
	@distance int,
	@avgspeed int,
	@fuelspent int
as
	if exists ( select * from Routes where IDRoute = @routeId) 
	begin
	update Routes 
		set WarrantID = @warrantId,
		DateFrom = @datestart,
		DateTo = @dateend,
		CoordA = @coordA,
		CoordB = @coordB,
		DistanceInKm = @distance,
		AvgV = @avgspeed,
		FuelSpent = @fuelspent
	where IDRoute = @routeId
	end
	else 
		begin
			insert into Routes(DateFrom, DateTo, CoordA, CoordB, WarrantID, DistanceInKm, AvgV, FuelSpent) values
			(@datestart, @dateend, @coordA, @coordB, @warrantId, @distance, @avgspeed, @fuelspent)
		end
go
create proc UpdateWarrant
	@travelWarrantID int,
	@vehicleid int,
	@warrantstateid int,
	@driverid int
as
	update travelWarrants
	set DriverID = @driverid,
		VehicleID = @vehicleid,
		WarrantStateEnumId = @warrantstateid
		where IDTwarrant = @travelWarrantID
go
