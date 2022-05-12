-- 列出消費總金額高於所有客戶平均消費總金額的客戶的名字，以及客戶的消費總金額
select 
	CompanyName ,
	SUM(od.UnitPrice*od.Quantity*CASE
															WHEN od.Discount = 0 THEN 1
															ELSE od.Discount
														END ) AllOrderPrice,
	SUM(od.UnitPrice*od.Quantity*CASE
															WHEN od.Discount = 0 THEN 1
															ELSE od.Discount
														END )/count(c.CustomerID) avgCustomer
from Customers c
left outer join Orders o ON o.CustomerID=c.CustomerID
left outer join [Order Details] od ON od.OrderID=o.OrderID
left outer join Products p ON p.ProductID=od.ProductID
group by CompanyName
order by AllOrderPrice DESC


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