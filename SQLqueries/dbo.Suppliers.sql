CREATE TABLE [dbo].[Suppliers] (
    [Supplier_ID]      INT           NOT NULL,
    [Supplier_Name]    VARCHAR (50)  NULL,
    [Supplier_Mobile]  VARCHAR (20)  NULL,
    [Supplier_Email]   VARCHAR (50)  NULL,
    [Supplier_Address] VARCHAR (100) NULL,
   
    PRIMARY KEY CLUSTERED ([Supplier_ID] ASC),
    
);

