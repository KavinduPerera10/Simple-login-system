CREATE TABLE [dbo].[tbllog1] (
    [Id]     INT    NOT NULL       IDENTITY  ,
    [Username] NVARCHAR (50) NULL,
    [Password] NVARCHAR (50) NULL,
    [Role] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(150) NULL, 
    [Mobile_Number] NVARCHAR(15) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

