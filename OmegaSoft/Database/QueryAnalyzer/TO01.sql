CREATE TABLE TOFax(
	IDEmployee nvarchar(20) NOT NULL FOREIGN KEY REFERENCES HREmployee(IDEmployee) ON DELETE NO ACTION,
	IDProject nvarchar(8) FOREIGN KEY REFERENCES ULProject(IDProject) ON DELETE NO ACTION,
	IDFax	nvarchar(8) NOT NULL PRIMARY KEY,
	IssuedDate datetime,
	EName nvarchar(60) NOT NULL,
	Describle ntext,
	FName nvarchar(12),
	FaxType int
)