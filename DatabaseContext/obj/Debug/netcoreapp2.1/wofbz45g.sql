IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Customers] (
    [Id] int NOT NULL IDENTITY,
    [CustomerName] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [ShopId] int NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190420065106_initial', N'2.1.8-servicing-32085');

GO

ALTER TABLE [Customers] ADD [ContactNo] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190426054436_Customer_ContactNo_Add', N'2.1.8-servicing-32085');

GO

