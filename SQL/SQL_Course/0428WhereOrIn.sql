Select 
	CustomerID,City
From Customers
Where City=N'London'OR City=N'Paris'

Select 
	CustomerID,City
From Customers
Where City IN(N'London',N'Paris')