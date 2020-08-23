CREATE TABLE [dbo].[OrderINFODetail_new] (
    [order_id] NVARCHAR (20) NOT NULL,
    [st_id]    VARCHAR (30)  NOT NULL,
    [foodid]   INT           IDENTITY (10, 2) NOT NULL,
    [amount]   NVARCHAR (4)  DEFAULT ('無') NULL,
    PRIMARY KEY CLUSTERED ([order_id] ASC),
    UNIQUE NONCLUSTERED ([order_id] ASC),
    UNIQUE NONCLUSTERED ([st_id] ASC),
    UNIQUE NONCLUSTERED ([foodid] ASC),
    FOREIGN KEY ([st_id]) REFERENCES [dbo].[StudentINFO] ([st_id]),
    FOREIGN KEY ([order_id]) REFERENCES [dbo].[OrderINFOMaster] ([order_id]),
    FOREIGN KEY ([foodid]) REFERENCES [dbo].[foodlist_new] ([foodid])
	on delete cascade
);

