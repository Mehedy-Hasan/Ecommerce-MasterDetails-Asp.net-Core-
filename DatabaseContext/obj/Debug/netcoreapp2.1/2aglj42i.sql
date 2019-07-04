ALTER TABLE [Customers] ADD [ContactNo] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190426054436_Customer_ContactNo_Add', N'2.1.8-servicing-32085');

GO

