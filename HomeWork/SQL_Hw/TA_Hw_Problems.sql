use Northwind
--(一)[查詢]

--0.簡單暖身
--(1)列出各產品的供應商名稱
select ProductID , CompanyName
from Products p ,Suppliers s
where p.SupplierID = s.SupplierID

select ProductID , CompanyName
from Products p
left join Suppliers s on p.SupplierID = s.SupplierID

--(2)列出各產品的種類名稱

--(3)列出各訂單的顧客（公司）名字

--(4)列出各訂單的物流商（公司）名字


--1.列出1998年各訂單的產品名稱

--2.想知道 供應商們 分布在哪些國家

--3.各產品，UnitsInStock < UnitsOnOrder 顯示'供不應求'，否則顯示'正常'

--(二)[排序] + (前幾筆/跳過幾筆)  
--4.最新的前九筆訂單

--5.產品單價最便宜的第4~8名


--(三)[C U D]
--6.
--新增物流商：
--	公司名稱青杉人才，電話(02)66057606
--	公司名稱青群科技，電話(02)14055374

--方才新增的兩筆資料，電話都改成(02)66057606，公司名稱結尾加'有限公司'

--刪除剛才兩筆資料



--彙總函式
--7.找出最高單價產品 跟 產品平均單價 之間的差

--(四)[群組] (或 [子查詢]也解得了)
--例.各物流商 負責過的訂單數
--(a)群組寫法
	select 
		ShipVia , COUNT(*) as 累計訂單數
	from [Orders] 
	group by ShipVia

--(b)子查詢寫法
	select
		ShipperID , (
			select 
				Count(*)
			from Orders
			where ShipVia = ShipperID
		) as 累計訂單數
	from Shippers 


--8.被下訂次數小於9 的產品
--A.群組寫法
	select
		p.ProductID,count(OrderID)as 訂單數
	from Products p
	inner join [Order Details] od on od.ProductID=p.ProductID
	--統計完對統計做篩選
	group by p.ProductID
	having COUNT(od.OrderID)<9
--B.子查詢寫法
----父層
--	select ProductID,('子') as 訂單數
--	from Products
--	where ('子')<9
----子層
--	select Count(*)
--	from [Order Details]
--	where ProductID=1
--嵌入
	select 
		ProductID,(
			select Count(*)
			from [Order Details]
			where ProductID=p.ProductID
			) as 訂單數
	from Products p
	where (
		select Count(*)
		from [Order Details]
		where ProductID=p.ProductID
		)<9

--9.各產品，歷史總銷售額大於3萬的，其最大單次銷售量
--A
	select
		ProductID,
		sum(Quantity*UnitPrice*(1-Discount) )		
	From [Order Details]
	group by OrderID
	having sum(Quantity*UnitPrice*(1-Discount) )>3000
	order by ProductID


--(五)[子查詢]
--10.第二高單價產品 跟 第三高單價產品 之間的單價差

--例.每個員工所處理的 最新訂單
--排序，也是能［目測］出答案
	select *
	from Orders
	order by EmployeeID, OrderDate desc

--群組寫法
	SELECT 
		EmployeeID , MAX(OrderDate) --一般欄位Select不了，只能放彙總函式
	FROM Orders o
	GROUP BY EmployeeID

--子查詢寫法
	SELECT *
	FROM Orders o
	WHERE OrderDate = (
		SELECT
			MAX(OrderDate)
		FROM Orders 
		WHERE EmployeeID = o.EmployeeID 
	)
	--ORDER BY o.EmployeeID, o.OrderDate DESC

--11(a)每位顧客，最新的訂單日期 

--11(b)每位顧客，第三新的訂單日期 


--12.每個產品種類 列出 單價>那類產品的平均單價 的產品


--13.每個供應商所供的，當前庫存量最高的產品 


--14.客戶想改訂單：
--訂單編號11077，ProductID = 2 的訂購量 + 2
--產品表中的 UnitsInStock、UnitsOnOrder 也需調整
--用Transaction語法，同時commit ，否則rollback