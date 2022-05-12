Select
	p.ProductID,
	p.ProductName,
	p.CategoryID,
	c.CategoryID,
	c.CategoryName
From Products p
Inner join Categories AS c On p.CategoryID=c.CategoryID
--¤£­n¥Îwhere p.CategoryID=c.CategoryID