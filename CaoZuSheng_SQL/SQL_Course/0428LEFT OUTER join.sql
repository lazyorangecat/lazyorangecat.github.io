Select
	e.EmployeeID,
	e.FirstName,
	e.ReportsTo,
	boss.FirstName
From Employees e
LEFT OUTER join Employees boss On e.ReportsTo=boss.EmployeeID