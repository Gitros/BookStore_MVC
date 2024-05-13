﻿CREATE TABLE [dbo].[Categories] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (30) NOT NULL,
    [DisplayOrder] INT           NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([Id] ASC)
);

