CREATE TABLE [dbo].[Address] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Street]       NVARCHAR (50) NOT NULL,
    [BuildingName] NVARCHAR (50) NULL,
    [Area]         NVARCHAR (50) NOT NULL,
    [City]         NVARCHAR (50) NOT NULL,
    [State]        NVARCHAR (50) NOT NULL,
    [Pincode]      NCHAR (10)    NOT NULL,
    [Country]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([Id] ASC)
);

