CREATE TABLE [dbo].[Complaints] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Subject]     NVARCHAR (250) NULL,
    [Description] NVARCHAR (250) NULL,
    CONSTRAINT [PK_Complaints] PRIMARY KEY CLUSTERED ([Id] ASC)
);

