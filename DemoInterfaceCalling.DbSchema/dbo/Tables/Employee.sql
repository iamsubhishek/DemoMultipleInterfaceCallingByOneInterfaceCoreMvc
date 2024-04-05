CREATE TABLE [dbo].[Employee] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (250) NULL,
    [MobileNo] NVARCHAR (MAX) NULL,
    [EmailId]  NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

