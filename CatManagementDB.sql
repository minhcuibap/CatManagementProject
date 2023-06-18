DROP DATABASE BirdTradingPlatform

CREATE DATABASE CatManagementDB

USE CatManagementDB

CREATE TABLE Accounts 
(
AccountID int primary key,
Username varchar(20) not null,
Password varchar(20) not null,
Fullname varchar(20),
RoleID int check(RoleID = 1 OR RoleID = 2), --(1 = Manager, 2 = Customer)
)

CREATE TABLE Services
(
ServiceID int primary key,
ServiceName nvarchar(50) not null,
ServicePrice int check(ServicePrice >= 0),
)

CREATE TABLE Cats
(
CatID int primary key,
AccountID int foreign key references Accounts(AccountID),
Breed varchar(30) not null,
Color varchar(10) not null,
Sex varchar(10) check (Sex like 'MEOW' OR Sex like 'FEMEOW'),
)

CREATE TABLE RegisteredServices
(
RegisteredID int primary key,
AccountID int foreign key references Accounts(AccountID),
CatID int foreign key references Cats(CatID),
ServiceID int foreign key references Services(ServiceID),
Date date,
Status int check(Status = 0 OR Status = 1), --(0 = Not Done, 1 = Done)
)


-- INSERT DATA
INSERT INTO Accounts(AccountID, Username, Password, Fullname, RoleID)
VALUES
	  (1, 'customer1', '123', 'minh1', 2),
	  (2, 'customer2', '123', 'minh2', 2),
	  (3, 'customer3', '123', 'minh3', 2),
	  (4, 'customer4', '123', 'minh4', 2),
	  (5, 'manager1', '345', 'hetcuu', 1)