CREATE TABLE Problems(
	ProblemId int not null identity (1,1) primary key,
	Customer nvarchar(50) not null,
	Title nvarchar (50) not null,
	[Status] bit not null,
	Created datetime2 not null
)
