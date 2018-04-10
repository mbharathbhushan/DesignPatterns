CREATE TABLE [dbo].[Users] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (40) NOT NULL,
    [Password] VARCHAR (40) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

