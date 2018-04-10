CREATE TABLE [dbo].[Employee] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (25) NOT NULL,
    [LastName]   VARCHAR (25) NOT NULL,
    [MiddleName] VARCHAR (25) NOT NULL,
    [FullName]   VARCHAR (75) NOT NULL,
    [Salaray]    VARCHAR (5)  CONSTRAINT [DF_Employee_Salaray] DEFAULT ((10000)) NOT NULL,
    [AddressId]  INT          CONSTRAINT [DF_Employee_AddressId] DEFAULT ((1)) NOT NULL,
    [Gender]     VARCHAR (10) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([Id] ASC)
);

