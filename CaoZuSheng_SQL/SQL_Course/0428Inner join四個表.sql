Select 
	c.CompanyName AS CustomerName,
	o.OrderDate,
	p.ProductName
From Customers c
Inner join Orders o On o.CustomerID=c.CustomerID
Inner join [Order Details] OD On OD.OrderID=o.OrderID
Inner join Products p On p.ProductID=OD.ProductID
