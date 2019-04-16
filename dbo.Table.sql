CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FistName varchar(30),
	LastName varchar(30),
	Nationality varchar(30),
	FeedBack varchar(300)
)
