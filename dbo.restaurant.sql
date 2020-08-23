CREATE TABLE [dbo].[restaurant] (
    [res_id]      INT           IDENTITY (100, 1) NOT NULL,
    [res_name]    VARCHAR (100) DEFAULT ('無') NULL,
    [res_address] VARCHAR (300) DEFAULT ('無') NULL,
    [res_kind]    VARCHAR (40)  DEFAULT ('無') NULL,
    [res_comment] VARCHAR (500) DEFAULT ('無') NULL,
    [res_phone]   NVARCHAR (50) DEFAULT ('無') NULL,
    PRIMARY KEY CLUSTERED ([res_id] ASC)
);

