Select
	CustomerID,ContactTitle
From Customers
Where ContactTitle Like'%manager'

Select
	CustomerID,ContactTitle
From Customers
Where ContactTitle Like'Sales\%'Escape'\'

/*[a-dg-k]a到d或g-k
[ack]a或c或k
[a-cde-g]a到c或d或e到g*/
