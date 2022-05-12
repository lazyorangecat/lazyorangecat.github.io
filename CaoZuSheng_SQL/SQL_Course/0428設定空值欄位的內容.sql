Select
	Region,
	Fax,
	IsNull(Fax,'No fax'),
	Coalesce(Region,Fax,'No fax')
	--Coalesce用法同IsNull但欄位可以設更多
From Customers