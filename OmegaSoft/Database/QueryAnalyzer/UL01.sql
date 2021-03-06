USE Omega_Soft
CREATE TABLE ULCustomer(
	IDCustomer varchar(10) NOT NULL PRIMARY KEY,
	CName nvarchar(200) NOT NULL,
	Describle ntext,
	Phone varchar(60),
	Fax varchar(60),
	Email varchar(100),
	WebSite varchar(100),
	Address nvarchar(250) NOT NULL)
CREATE TABLE ULSupplier(
	IDSupplier varchar(10) NOT NULL PRIMARY KEY,
	SName nvarchar(200) NOT NULL,
	Describle ntext,
	Business nvarchar(150) NOT NULL,
	Phone varchar(60),
	Fax varchar(60),
	Email varchar(100),
	WebSite varchar(100),
	Address nvarchar(250) NOT NULL)
CREATE TABLE ULProject(
	IDCompany nvarchar(10) NOT NULL FOREIGN KEY REFERENCES HRCompany(IDCompany) ON DELETE NO ACTION,
	IDProject nvarchar(8) NOT NULL PRIMARY KEY,
	PName nvarchar(150) NOT NULL,
	Describle ntext,
	StartDate datetime,
	FinishDate datetime,
	Address	nvarchar(250),
	Investment nvarchar(100),
	Complete bit,
	Total float,
	Variation float)