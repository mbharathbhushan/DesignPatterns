﻿CREATE TABLE [dbo].[Employee] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50) NOT NULL,
    [JobDescription] VARCHAR (50) NOT NULL,
    [Number]         VARCHAR (50) NOT NULL,
    [Department]     VARCHAR (50) NOT NULL,
    [HourlyPay]      DECIMAL (18) NOT NULL,
    [Bonus]          DECIMAL (18) NOT NULL,
    [EmployeeTypeID] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employee_EmployeeType] FOREIGN KEY ([EmployeeTypeID]) REFERENCES [dbo].[Employee_Type] ([Id])
);

