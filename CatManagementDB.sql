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
VALUES(1, 'customer1', '123', 'minh1', 2),
	  (2, 'customer2', '123', 'minh2', 2),
	  (3, 'customer3', '123', 'minh3', 2),
	  (4, 'customer4', '123', 'minh4', 2)

INSERT INTO Services(ServiceID, ServiceName, ServicePrice)
VALUES	(1, 'Grooming', 100),
		(2, 'Nursing', 50),
		(3, 'Disease Check', 200),
		(4, 'Feeding', 75),
		(5, 'Identification', 20),
		(6, 'Spaying and Neutering', 60),
		(7, 'Vaccination', 300),
		(8, 'Hygiene Care Pack', 200),
		(9, 'Medical Examination Pack', 500),
		(10, 'All in One Pack', 700)

INSERT INTO Cats(CatID, AccountID, Breed, Color, Sex)
VALUES	(1, 1, 'British Shorthair', 'Grey', 'MEOW'),
		(2, 2, 'Lynx', 'Brown', 'FEMEOW'),
		(3, 3, 'Idiot', 'Black', 'MEOW'),
		(4, 3, 'Ragdoll', 'Grey', 'FEMEOW')

INSERT INTO RegisteredServices(RegisteredID, AccountID, CatID, ServiceID, Date, Status)
VALUES	(1, 1, 1, 1, GETDATE(), 1),
		(2, 2, 2, 4, GETDATE(), 0),
		(3, 3, 3, 10, GETDATE(), 0),
		(4, 3, 4, 9, GETDATE(), 0)