CREATE TABLE Problemm(
	ProblemId int not null identity (1,1),
	Customer nvarchar(50) not null,
	Title nvarchar (50) not null,
	[Status] nvarchar(50) not null,
	Created datetime2 not null,
	[Description] nvarchar(100) not null
)