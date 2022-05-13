-- 找出和最貴的產品同類別的所有產品
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

-- 找出和最貴的產品同類別最便宜的產品
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

-- 計算出上面類別最貴和最便宜的兩個產品的價差
select (max(UnitPrice)-min(UnitPrice))AS pricerange
from Products p 
Inner join Categories c ON c.CategoryID=p.CategoryID
where CategoryName=N'Beverages'

-- 找出沒有訂過任何商品的客戶所在的城市的所有客戶
select CompanyName,City
from Customers
where City in (
	select City
	from Customers c
	left outer join Orders  o on c.CustomerID=o.CustomerID
	where OrderID is null)

-- 找出第 5 貴跟第 8 便宜的產品的產品類別
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

-- 找出誰買過第 5 貴跟第 8 便宜的產品
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

-- 找出誰賣過第 5 貴跟第 8 便宜的產品
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
-- 找出 13 號星期五的訂單 (惡魔的訂單)
select OrderID,OrderDate
from Orders
where DATEPART(dd, OrderDate)=13 and DATEPART(weekday, OrderDate)=5
-- 找出誰訂了惡魔的訂單
select CompanyName
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
where OrderID IN(
	select OrderID
	from Orders
	where DATEPART(dd, OrderDate)=13 and DATEPART(weekday, OrderDate)=5)

-- 找出惡魔的訂單裡有什麼產品
select ProductName
from Products p
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on o.OrderID=od.OrderID
where o.OrderID IN
(select OrderID
from Orders
where DATEPART(dd, OrderDate)=13 and DATEPART(weekday, OrderDate)=5)
-- 列出從來沒有打折 (Discount) 出售的產品
select ProductName
from Products
where ProductName not in(
select DISTINCT ProductName 
from Products p
inner join [Order Details] od on od.ProductID= p.ProductID
inner join Orders o on o.OrderID=od.OrderID
where od.Discount<>0
group by ProductName)

-- 列出購買非本國的產品的客戶
select DISTINCT c.CompanyName
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join [Order Details] od on o.OrderID=od.OrderID
inner join Products p on p.ProductID=od.ProductID
inner join Suppliers s on s.SupplierID=p.SupplierID
where c.Country <>s.Country

-- 列出所有在每個月月底的訂單
select OrderDate
from Orders
where DATEPART(dd,OrderDate)=DATEPART(dd,EOMONTH(OrderDate))

-- 列出每個月月底售出的產品
select ProductName,OrderDate
from Products p
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on o.OrderID=od.OrderID
where o.OrderDate IN (
	select OrderDate
	from Orders
	where DATEPART(dd,OrderDate)=DATEPART(dd,EOMONTH(OrderDate)))

-- 列出在同個城市中有公司員工可以服務的客戶      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
select *
from Customers c
left outer join Employees e on e.Country=c.Country
where e.EmployeeID is not null

-- 找出銷售金額最高的前三個產品
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

-- 找出銷售金額最高的前三個產品類別
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

-- 找出最敗家的前三個客戶
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

-- 找出有敗過最貴的三個產品中的任何一個的前三個大客戶
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
-- 找出有敗過銷售金額前三高個產品的前三個大客戶
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

-- 找出有敗過銷售金額前三高個產品所屬類別的前三個大客戶
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

-- 列出消費總金額高於所有客戶平均消費總金額的客戶的名字，以及客戶的消費總金額

-- 列出最熱銷的產品，以及被購買的總金額

-- 列出最少人買的產品

-- 列出最沒人要買的產品類別 (Categories)

-- 列出跟銷售最好的供應商買最多金額的客戶與購買金額 (含購買其它供應商的產品)

-- 列出跟銷售最好的供應商買最多金額的客戶與購買金額 (不含購買其它供應商的產品)

-- 列出那些產品沒有人買過

-- 列出沒有傳真 (Fax) 的客戶和它的消費總金額

-- 列出每一個城市消費的產品種類數量

-- 列出目前沒有庫存的產品在過去總共被訂購的數量

-- 列出目前沒有庫存的產品在過去曾經被那些客戶訂購過

-- 列出每位員工的下屬的業績總金額

-- 列出每家貨運公司運送最多的那一種產品類別與總數量

-- 列出每一個客戶買最多的產品類別與金額

-- 列出每一個客戶買最多的那一個產品與購買數量

-- 按照城市分類，找出每一個城市最近一筆訂單的送貨時間

-- 建立 PIVOT 表，統計銷售金額如下：
-- City, [Beverages], [Condiments], [Seafood]

-- 寫一個 TVF 可以帶入上一題所要過濾的價格差 @diff_price，
-- 傳回與前一筆價格相差 @diff_price 的產品

-- 列出購買金額第五名與第十名的客戶，以及兩個客戶的金額差距