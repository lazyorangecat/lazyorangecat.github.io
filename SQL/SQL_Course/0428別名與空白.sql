USE Northwind										--����Ʈw
GO

Select 
	*,
	UnitPrice * Quantity * (1-Discount) AS Total	--AS==�O�W
From [Order Details]								--��W���ťե[���A��

Select
	EmployeeID AS ID,
	FirstName,
	LastName,
	FirstName + N' '+ LastName AS FullName			--
From Employees