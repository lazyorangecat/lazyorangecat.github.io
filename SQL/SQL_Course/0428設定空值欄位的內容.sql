Select
	Region,
	Fax,
	IsNull(Fax,'No fax'),
	Coalesce(Region,Fax,'No fax')
	--Coalesce�Ϊk�PIsNull�����i�H�]��h
From Customers