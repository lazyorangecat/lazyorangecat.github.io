Select
	OrderDate,Year(OrderDate),
	Convert(nvarchar(50),OrderDate,101),
	Convert(nvarchar(50),OrderDate,111)
From Orders