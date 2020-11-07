CREATE TABLE Problems(
	Id int not null identity(1,1) primary key,
	Customer nvarchar(50) not null,
	Title nvarchar(50) not null,
	[Description] nvarchar(200),
	Created datetime2 not null,
	Finished bit not null
)