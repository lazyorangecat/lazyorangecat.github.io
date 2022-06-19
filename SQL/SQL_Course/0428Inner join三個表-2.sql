Select
	o.OrderID,
	o.OrderDate,
	o.ShipAddress,
	c.CompanyName As Customer ,
	e.FirstName+N' '+e.LastName As EmployeeName
From Orders o
Inner join Employees e On e.EmployeeID=o.EmployeeID
Inner join Customers c On c.CustomerID=o.CustomerID