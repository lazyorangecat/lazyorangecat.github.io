Select
	ProductName,UnitPrice,
	ProductName+N'('+CAST(UnitPrice AS nvarchar(10))+N')'
From Products