CREATE TABLE [dbo].[OrderINFOMaster] (
    [order_id]       NVARCHAR (20) NOT NULL,
    [res_id]         INT           IDENTITY (100, 1) NOT NULL,
    [ordertime]      DATE          DEFAULT ('無') NULL,
    [responsibleMan] VARCHAR (50)  DEFAULT ('無') NULL,
    PRIMARY KEY CLUSTERED ([order_id] ASC, [res_id] ASC),
    UNIQUE NONCLUSTERED ([order_id] ASC),
    FOREIGN KEY ([res_id]) REFERENCES [dbo].[restaurant] ([res_id])
	on delete cascade
);

