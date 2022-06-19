Select 
	e1.EmployeeID,e1.FirstName,
	e2.EmployeeID,e2.FirstName
From Employees e1
Cross Join Employees e2
Where e1.EmployeeID<>e2.EmployeeID
--!=不是ISO標準用法不要用
