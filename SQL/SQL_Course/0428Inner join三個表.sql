Select
	p.ProductID,
	p.ProductName,
	p.SupplierID
From Products p
Inner join Suppliers s On p.SupplierID=s.SupplierID
Inner join Categories c On p.CategoryID=c.CategoryID
--¤T­Óªí
