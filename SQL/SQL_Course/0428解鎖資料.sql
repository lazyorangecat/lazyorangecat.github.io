Select	*From Shippers

Set Identity_insert Shippers On
Insert Into Shippers(ShipperID,CompanyName,Phone)
Values
	(4,'Fedex1','11111')

Set Identity_insert Shippers OFF