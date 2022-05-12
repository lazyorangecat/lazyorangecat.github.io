Select Distinct
	c.CustomerID,c.CompanyName
From Customers c
Left Outer join Orders o On o.CustomerID=c.CustomerID
Where o.CustomerID Is Not Null