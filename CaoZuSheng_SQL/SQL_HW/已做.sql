-- ��X�M�̶Q�����~�P���O���Ҧ����~
select ProductName,CategoryName,UnitPrice
	from Products p
	Inner join Categories c ON c.CategoryID=p.CategoryID
	where CategoryName=(
		select Top 1		
			c.CategoryName		
		from Products p 
		Inner join Categories c ON c.CategoryID=p.CategoryID
		order by p.UnitPrice DESC 
	)

-- ��X�M�̶Q�����~�P���O�̫K�y�����~
select TOP 1
	ProductName,CategoryName,UnitPrice
	from Products p
	Inner join Categories c ON c.CategoryID=p.CategoryID
	where CategoryName=(
		select Top 1		
			c.CategoryName		
		from Products p 
		Inner join Categories c ON c.CategoryID=p.CategoryID
		order by p.UnitPrice DESC 
	)
	order by UnitPrice

-- �p��X�W�����O�̶Q�M�̫K�y����Ӳ��~�����t
select (max(UnitPrice)-min(UnitPrice))AS pricerange
from Products p 
Inner join Categories c ON c.CategoryID=p.CategoryID
where CategoryName=N'Beverages'

-- ��X�S���q�L����ӫ~���Ȥ�Ҧb���������Ҧ��Ȥ�
select CompanyName,City
from Customers
where City in (
	select City
	from Customers c
	left outer join Orders  o on c.CustomerID=o.CustomerID
	where OrderID is null)

-- ��X�� 5 �Q��� 8 �K�y�����~�����~���O
select  UnitPrice,CategoryName,ProductName
from Products p 
inner join Categories c on p.CategoryID=c.CategoryID
order by UnitPrice
offset 4 rows
FETCH NEXT 1 ROWS ONLY

select  UnitPrice,CategoryName
from Products p 
inner join Categories c on p.CategoryID=c.CategoryID
order by UnitPrice DESC
offset 7 rows
FETCH NEXT 1 ROWS ONLY

-- ��X�ֶR�L�� 5 �Q��� 8 �K�y�����~
select CompanyName,ProductName
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where p.ProductName=
	(select  ProductName
	from Products p 
	inner join Categories c on p.CategoryID=c.CategoryID
	order by UnitPrice
	offset 4 rows
	FETCH NEXT 1 ROWS ONLY)

select CompanyName,ProductName
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where p.ProductName=(
	select  UnitPrice,CategoryName
	from Products p 
	inner join Categories c on p.CategoryID=c.CategoryID
	order by UnitPrice DESC
	offset 7 rows
	FETCH NEXT 1 ROWS ONLY)

-- ��X�ֽ�L�� 5 �Q��� 8 �K�y�����~
select DISTINCT(FirstName+N' '+LastName) Fullname ,ProductName 
from Employees e
inner join Orders o on o.EmployeeID=e.EmployeeID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where p.ProductName=
	(select  ProductName
	from Products p 
	inner join Categories c on p.CategoryID=c.CategoryID
	order by UnitPrice
	offset 4 rows
	FETCH NEXT 1 ROWS ONLY)

select DISTINCT(FirstName+N' '+LastName) Fullname ,ProductName 
from Employees e
inner join Orders o on o.EmployeeID=e.EmployeeID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where p.ProductName=(
	select  ProductName
	from Products p 
	inner join Categories c on p.CategoryID=c.CategoryID
	order by UnitPrice DESC
	offset 7 rows
	FETCH NEXT 1 ROWS ONLY)
-- ��X 13 ���P�������q�� (�c�]���q��)
select OrderID,OrderDate
from Orders
where DATEPART(dd, OrderDate)=13 and DATEPART(weekday, OrderDate)=5
-- ��X�֭q�F�c�]���q��
select CompanyName
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
where OrderID IN(
	select OrderID
	from Orders
	where DATEPART(dd, OrderDate)=13 and DATEPART(weekday, OrderDate)=5)

-- ��X�c�]���q��̦����򲣫~
select ProductName
from Products p
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on o.OrderID=od.OrderID
where o.OrderID IN
(select OrderID
from Orders
where DATEPART(dd, OrderDate)=13 and DATEPART(weekday, OrderDate)=5)
-- �C�X�q�ӨS������ (Discount) �X�⪺���~
select ProductName
from Products
where ProductName not in(
select DISTINCT ProductName 
from Products p
inner join [Order Details] od on od.ProductID= p.ProductID
inner join Orders o on o.OrderID=od.OrderID
where od.Discount<>0
group by ProductName)

-- �C�X�ʶR�D���ꪺ���~���Ȥ�
select DISTINCT c.CompanyName
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join [Order Details] od on o.OrderID=od.OrderID
inner join Products p on p.ProductID=od.ProductID
inner join Suppliers s on s.SupplierID=p.SupplierID
where c.Country <>s.Country

-- �C�X�Ҧ��b�C�Ӥ�멳���q��
select OrderDate
from Orders
where DATEPART(dd,OrderDate)=DATEPART(dd,EOMONTH(OrderDate))

-- �C�X�C�Ӥ�멳��X�����~
select ProductName,OrderDate
from Products p
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on o.OrderID=od.OrderID
where o.OrderDate IN (
	select OrderDate
	from Orders
	where DATEPART(dd,OrderDate)=DATEPART(dd,EOMONTH(OrderDate)))

-- �C�X�b�P�ӫ����������q���u�i�H�A�Ȫ��Ȥ�      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
select *
from Customers c
left outer join Employees e on e.Country=c.Country
where e.EmployeeID is not null

-- ��X�P����B�̰����e�T�Ӳ��~
select TOP 3 
	ProductName,
	SUM(od.UnitPrice*od.Quantity*
	CASE
		WHEN od.Discount = 0 THEN 1
		ELSE od.Discount
	END ) AllOrderPrice	
from Products p
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on o.OrderID =od.OrderID
group by ProductName
order by AllOrderPrice DESC

-- ��X�P����B�̰����e�T�Ӳ��~���O
select TOP 3 
	ProductName,
	SUM(od.UnitPrice*od.Quantity*
	CASE
		WHEN od.Discount = 0 THEN 1
		ELSE od.Discount
	END ) AllOrderPrice,
	CategoryName
from Categories c
inner join Products p on p.CategoryID=c.CategoryID
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on o.OrderID =od.OrderID
group by ProductName, CategoryName
order by AllOrderPrice DESC

-- ��X�̱Ѯa���e�T�ӫȤ�
select  
	c.CompanyName,SUM(od.UnitPrice*od.Quantity*
	CASE
		WHEN od.Discount = 0 THEN 1
		ELSE od.Discount
	END ) AllOrderPrice
from Customers c
left outer join Orders o on o.CustomerID=c.CustomerID
left outer join [Order Details] od on od.OrderID =o.OrderID
group by c.CompanyName
order by AllOrderPrice DESC

-- ��X���ѹL�̶Q���T�Ӳ��~��������@�Ӫ��e�T�Ӥj�Ȥ�
select top 3 CompanyName,
	o.OrderDate
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p  on p.ProductID=od.ProductID
where p.ProductName IN(select Top 3 ProductName
from Products
order by UnitPrice DESC)
order by OrderDate
-- ��X���ѹL�P����B�e�T���Ӳ��~���e�T�Ӥj�Ȥ�
select top 3 CompanyName,
	o.OrderDate
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p  on p.ProductID=od.ProductID
where p.ProductName IN(
	select TOP 3 
		ProductName		
	from Products p
	inner join [Order Details] od on od.ProductID=p.ProductID
	inner join Orders o on o.OrderID =od.OrderID
	group by ProductName
	order by SUM(od.UnitPrice*od.Quantity*
		CASE
			WHEN od.Discount = 0 THEN 1
			ELSE od.Discount
		END ) DESC)
order by OrderDate

-- ��X���ѹL�P����B�e�T���Ӳ��~�������O���e�T�Ӥj�Ȥ�
select top 3 CompanyName,
	o.OrderDate,
	p.ProductName
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p  on p.ProductID=od.ProductID
inner join Categories cg on cg.CategoryID=p.CategoryID
where cg.CategoryName IN(
	select TOP 3 
		CategoryName
	from Categories c
	inner join Products p on p.CategoryID=c.CategoryID
	inner join [Order Details] od on od.ProductID=p.ProductID
	inner join Orders o on o.OrderID =od.OrderID
	group by ProductName, CategoryName
	order by SUM(od.UnitPrice*od.Quantity*
		CASE
			WHEN od.Discount = 0 THEN 1
			ELSE od.Discount
		END ) DESC)
order by OrderDate

-- �C�X���O�`���B����Ҧ��Ȥᥭ�����O�`���B���Ȥ᪺�W�r�A�H�ΫȤ᪺���O�`���B

-- �C�X�̼��P�����~�A�H�γQ�ʶR���`���B

-- �C�X�̤֤H�R�����~

-- �C�X�̨S�H�n�R�����~���O (Categories)

-- �C�X��P��̦n�������ӶR�̦h���B���Ȥ�P�ʶR���B (�t�ʶR�䥦�����Ӫ����~)

-- �C�X��P��̦n�������ӶR�̦h���B���Ȥ�P�ʶR���B (���t�ʶR�䥦�����Ӫ����~)

-- �C�X���ǲ��~�S���H�R�L

-- �C�X�S���ǯu (Fax) ���Ȥ�M�������O�`���B

-- �C�X�C�@�ӫ������O�����~�����ƶq

-- �C�X�ثe�S���w�s�����~�b�L�h�`�@�Q�q�ʪ��ƶq

-- �C�X�ثe�S���w�s�����~�b�L�h���g�Q���ǫȤ�q�ʹL

-- �C�X�C����u���U�ݪ��~�Z�`���B

-- �C�X�C�a�f�B���q�B�e�̦h�����@�ز��~���O�P�`�ƶq

-- �C�X�C�@�ӫȤ�R�̦h�����~���O�P���B

-- �C�X�C�@�ӫȤ�R�̦h�����@�Ӳ��~�P�ʶR�ƶq

-- ���ӫ��������A��X�C�@�ӫ����̪�@���q�檺�e�f�ɶ�

-- �إ� PIVOT ��A�έp�P����B�p�U�G
-- City, [Beverages], [Condiments], [Seafood]

-- �g�@�� TVF �i�H�a�J�W�@�D�ҭn�L�o������t @diff_price�A
-- �Ǧ^�P�e�@������ۮt @diff_price �����~

-- �C�X�ʶR���B�Ĥ��W�P�ĤQ�W���Ȥ�A�H�Ψ�ӫȤ᪺���B�t�Z