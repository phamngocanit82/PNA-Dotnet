USE master
DROP DATABASE Omega_Soft
CREATE DATABASE Omega_Soft
USE Omega_Soft
SP_HELP HRCountry
CREATE TABLE HRCountry(
	IDCountry nvarchar(4) NOT NULL PRIMARY KEY,
	CName nvarchar(100) NOT NULL,
	Describle ntext,
	Picture image)
CREATE TABLE HRCompany(
	IDCountry nvarchar(4) NOT NULL FOREIGN KEY REFERENCES HRCountry(IDCountry) ON DELETE NO ACTION,
	IDCompany nvarchar(10) NOT NULL PRIMARY KEY,
	CName nvarchar(100) NOT NULL,
	Branch bit,
	Director nvarchar(50) NOT NULL,
	TaxCode nvarchar(20),
	Business nvarchar(150),
	Phone nvarchar(60),
	Fax nvarchar(60),
	Email nvarchar(100),
	WebSite nvarchar(100),
	Address nvarchar(250) NOT NULL,
	Picture image)
CREATE TABLE HRDepartment(
	IDCompany nvarchar(10) NOT NULL FOREIGN KEY REFERENCES HRCompany(IDCompany) ON DELETE NO ACTION,
	IDDepartment nvarchar(4) NOT NULL PRIMARY KEY,
	DName nvarchar(100) NOT NULL,
	Describle ntext)
CREATE TABLE HRLevel(
	IDLevel nvarchar(4) NOT NULL PRIMARY KEY,
	LName nvarchar(100) NOT NULL,	
	Describle ntext)
CREATE TABLE HRJobTitle(
	IDDepartment nvarchar(4) NOT NULL FOREIGN KEY REFERENCES HRDepartment(IDDepartment) ON DELETE NO ACTION,
	IDJobTitle nvarchar(4) NOT NULL PRIMARY KEY,
	JName nvarchar(100) NOT NULL,	
	Describle ntext)
CREATE TABLE HREmployee(
	IDJobTitle nvarchar(4) NOT NULL FOREIGN KEY REFERENCES HRJobTitle(IDJobTitle) ON DELETE NO ACTION,
	IDLevel nvarchar(4) NOT NULL	FOREIGN KEY REFERENCES HRLevel(IDLevel) ON DELETE NO ACTION,
	IDEmployee nvarchar(20) NOT NULL PRIMARY KEY,
	FirstName nvarchar(20) NOT NULL,
	LastName nvarchar(40) NOT NULL,
	Gender bit,
	BirthDate datetime,
	HireDate datetime,
	HomePhone nvarchar(60),
	MobilePhone nvarchar(60),
	Email nvarchar(100),
	Resident nvarchar(250) NOT NULL,
	TempResident nvarchar(250) NOT NULL,
	Picture image)
CREATE TABLE HRUser(
	IDEmployee nvarchar(20) NOT NULL FOREIGN KEY REFERENCES HREmployee(IDEmployee) ON DELETE NO ACTION,
	UName nvarchar(20) NOT NULL PRIMARY KEY,
	UPass nvarchar(20) NOT NULL,
	Admin bit)
CREATE TABLE HRFormList(
	IDForm nvarchar(10) NOT NULL PRIMARY KEY,
	FName nvarchar(20) NOT NULL,
	IDXML int,
	FileXML nvarchar(20) NOT NULL)
CREATE TABLE HRAccessRight(
	IDEmployee nvarchar(20) NOT NULL FOREIGN KEY REFERENCES HREmployee(IDEmployee) ON DELETE NO ACTION,
	IDForm nvarchar(10) NOT NULL FOREIGN KEY REFERENCES HRFormList(IDForm) ON DELETE NO ACTION,
	CRead bit,
	CAdd bit,
	CWrite bit,
	CDelete bit,
	CUpdate bit)