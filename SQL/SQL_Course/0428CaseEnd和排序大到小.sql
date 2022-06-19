SELECT
	ProductID,
	ProductName,
	UnitPrice,
	Case 
		When UnitPrice>= 20 Then 'Expensive'
		When UnitPrice>= 10 Then 'Normal'
		Else 'Cheep'
	End AS Level,								--類似if
	
	Case 
		When UnitPrice>= 20 Then 0.8
		When UnitPrice>= 10 Then 0.9
		Else 1
	End AS Discount,
	
	UnitPrice * 
	Case 
		When UnitPrice>= 20 Then 0.8
		When UnitPrice>= 10 Then 0.9
		Else 1
	End  AS Newprice
From Products
Order by UnitPrice DESC							---大到小