-- Customers Table ========================
CREATE TABLE Customers (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    CompanyName nvarchar(200)  NULL,
    ContractStartDate nvarchar(200)  NULL,
    Logo_FileName nvarchar(1500)  NULL,
    Contract_FileName nvarchar(1500)  NULL,
    Country uniqueidentifier  NULL
);

