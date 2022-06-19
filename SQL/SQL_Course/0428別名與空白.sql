USE Northwind										--切資料庫
GO

Select 
	*,
	UnitPrice * Quantity * (1-Discount) AS Total	--AS==別名
From [Order Details]								--表名有空白加中括號

Select
	EmployeeID AS ID,
	FirstName,
	LastName,
	FirstName + N' '+ LastName AS FullName			--
From Employees