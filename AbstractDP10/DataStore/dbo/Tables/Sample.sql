﻿CREATE TABLE [dbo].[Sample] (
    [ID]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Sample] PRIMARY KEY CLUSTERED ([ID] ASC)
);

