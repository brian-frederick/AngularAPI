CREATE TABLE [dbo].[Product] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (1000) NULL,
    [price]       DECIMAL (18)    NULL,
    [description] NTEXT           NOT NULL,
    [soldOut]     BIT             NOT NULL,
    [canPurchase] BIT             NOT NULL,
    [Image]       NVARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

