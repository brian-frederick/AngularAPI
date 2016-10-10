CREATE TABLE [dbo].[review] (
    [ID]        INT             IDENTITY (1, 1) NOT NULL,
    [author]    NVARCHAR (1000) NULL,
    [stars]     INT             NOT NULL,
    [body]      NTEXT           NULL,
    [ProductId] INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [fk_ReviewProduct] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ID])
);

