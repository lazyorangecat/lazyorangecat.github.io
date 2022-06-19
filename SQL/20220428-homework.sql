---- HomeWork 20220428 ---------------------------
-- 01 找出和最貴的產品同類別的所有產品
 /* Ans:
	SELECT 
		ProductName, 
		UnitPrice, 
		CategoryID
	FROM Products
	/* 方式一 */
	WHERE CategoryID = (
		SELECT TOP 1
		CategoryID
	FROM Products
	GROUP BY CategoryID
	ORDER BY Max(UnitPrice) DESC 
	)
	/* 方式二 */
	WHERE CategoryID = (
		SELECT 
			CategoryID 
		FROM Products 
	WHERE UnitPrice = (
		SELECT 
			MAX(UnitPrice ) 
		FROM Products
		));
*/
-- 02 找出和最貴的產品同類別最便宜的產品
 /* Ans:

	SELECT TOP 1 
		*
	FROM Products 
		WHERE CategoryID = (
			SELECT CategoryID 
		FROM Products 
		WHERE UnitPrice = (
			SELECT MAX(UnitPrice) 
		FROM Products))
	ORDER BY UnitPrice;

*/
-- 03 計算出上面類別最貴和最便宜的兩個產品的價差
 /* Ans:
	SELECT 
		MAX(UnitPrice)-MIN(UnitPrice) 
	FROM Products 
	WHERE CategoryID = (
		SELECT CategoryID 
	FROM Products 
	WHERE UnitPrice = (
		SELECT MAX(UnitPrice) 
	FROM Products));
*/
-- 04 找出沒有訂過任何商品的客戶所在的城市的所有客戶
 /* Ans:
	SELECT 
		CustomerID, 
		CompanyName, 
		City 
	FROM Customers 
	WHERE City IN (SELECT City FROM Customers 
	WHERE CustomerID IN	(SELECT CustomerID FROM Customers
		EXCEPT
		SELECT CustomerID FROM Orders));
*/
-- 05 找出第 5 貴跟第 8 便宜的產品的產品類別
 /* Ans:
	SELECT 
		ProductID,
		CategoryID 
	FROM (SELECT *, RANK () OVER (ORDER BY UnitPrice DESC) AS Rank_no FROM Products) AS P1
	WHERE Rank_no = 5 OR Rank_no = (SELECT MAX(Rank_no)-7 FROM (SELECT *, RANK () OVER (ORDER BY UnitPrice DESC) AS Rank_no FROM Products) AS P2);
*/
-- 06 找出誰買過第 5 貴跟第 8 便宜的產品
 /* Ans:
	SELECT DISTINCT 
		CompanyName, 
		P.ProductID,
		p.CategoryID
	FROM Customers C
	INNER JOIN Orders O ON O.CustomerID=C.CustomerID
	INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
	INNER JOIN Products P ON OD.ProductID=P.ProductID
	WHERE P.ProductID IN 
	(SELECT ProductID FROM 
	(SELECT *, RANK () OVER (ORDER BY UnitPrice DESC) AS Rank_no FROM Products) AS P1
	WHERE Rank_no = 5 OR Rank_no = 
	(SELECT MAX(Rank_no)-7 FROM (SELECT *, RANK () OVER (ORDER BY UnitPrice DESC) AS Rank_no FROM Products) AS P2));
*/
-- 07 找出誰賣過第 5 貴跟第 8 便宜的產品
 /* Ans:
	SELECT DISTINCT 
	E.EmployeeID,
	E.FirstName + '.' + E.LastName AS EmployeeName
	FROM Products P
	INNER JOIN [Order Details] OD ON OD.ProductID=P.ProductID
	INNER JOIN Orders O ON O.OrderID=OD.OrderID
	INNER JOIN Employees E ON E.EmployeeID=O.EmployeeID
	WHERE P.ProductID IN 
	(SELECT ProductID FROM
	(SELECT *, RANK () OVER (ORDER BY UnitPrice DESC) AS Rank_no FROM Products) AS P1
	WHERE Rank_no = 5 OR Rank_no = 
	(SELECT MAX(Rank_no)-7 FROM (SELECT *, RANK () OVER (ORDER BY UnitPrice DESC) AS Rank_no FROM Products) AS P2));
*/
-- 08 找出 13 號星期五的訂單 (惡魔的訂單)
 /* Ans: 
	SELECT 
		OrderID,
		OrderDate
	FROM Orders 
	WHERE DAY(OrderDate)=13 AND DATEPART(dw,OrderDate) = 6;
*/
-- 09 找出誰訂了惡魔的訂單
 /* Ans:
	SELECT DISTINCT 
		C.CustomerID, 
		C.CompanyName,
		O.OrderDate
	FROM Customers C
	LEFT JOIN Orders O ON O.CustomerID=C.CustomerID
	WHERE DAY(OrderDate)=13 AND DATEPART(dw,OrderDate) = 6;
*/
-- 10 找出惡魔的訂單裡有什麼產品
 /* Ans:
	SELECT DISTINCT 
		O.OrderID,
		O.OrderDate,
		P.ProductID, 
		P.ProductName 
	FROM Products P
	INNER JOIN [Order Details] OD ON OD.ProductID=P.ProductID
	INNER JOIN Orders O ON O.OrderID=OD.OrderID
	WHERE DAY(OrderDate)=13 AND DATEPART(dw,OrderDate) = 6;
*/
-- 11 列出從來沒有打折 (Discount) 出售的產品
 /* Ans: 
	/* 方式一 
	SELECT DISTINCT
		p.*
	FROM [Order Details] od
	INNER JOIN Products p ON od.ProductID = p.ProductID
	WHERE od.Discount <> 0
	*/
	/* 方式二 */
	Select Distinct
		ProductID,
		Discount
	From [Order Details]
	where Discount = 0

*/
-- 12 列出購買非本國的產品的客戶
 /* Ans: 
	SELECT DISTINCT 
		S.City,
		C.CustomerID, 
		C.CompanyName 
	FROM Customers C
	INNER JOIN Orders O ON C.CustomerID=O.CustomerID
	INNER JOIN [Order Details] OD ON OD.OrderID=O.OrderID
	INNER JOIN Products P ON P.ProductID=OD.ProductID
	INNER JOIN Suppliers S ON S.SupplierID=P.SupplierID
	WHERE S.Country <> 'Taiwan';
*/
-- 13 列出所有在每個月月底的訂單
 /* Ans:
	SELECT 
		OrderID,
		OrderDate,
		CustomerID 
	FROM Orders
	WHERE OrderDate = EOMONTH(OrderDate);
*/
-- 14 列出每個月月底售出的產品
 /* Ans:
	SELECT DISTINCT 
		o.OrderID,
		o.OrderDate,
		P.ProductID, 
		p.ProductName 
	FROM Orders O
	INNER JOIN [Order Details] OD ON OD.OrderID=O.OrderID
	INNER JOIN Products P ON OD.ProductID=P.ProductID
	WHERE OrderDate = EOMONTH(OrderDate);
*/
-- 15 列出在同個城市中有公司員工可以服務的客戶

---- HomeWork 20220502 ---------------------------
-- 16 找出銷售金額最高的前三個產品

-- 17 找出銷售金額最高的前三個產品類別

-- 18 找出最敗家的前三個客戶

-- 19 找出有敗過最貴的三個產品中的任何一個的前三個大客戶

-- 20 找出有敗過銷售金額前三高個產品的前三個大客戶

-- 21 找出有敗過銷售金額前三高個產品所屬類別的前三個大客戶

-- 22 列出消費總金額高於所有客戶平均消費總金額的客戶的名字，以及客戶的消費總金額

-- 23 列出最熱銷的產品，以及被購買的總金額

-- 24 列出最少人買的產品

-- 25 列出最沒人要買的產品類別 (Categories)

-- 26 列出跟銷售最好的供應商買最多金額的客戶與購買金額 (含購買其它供應商的產品)

-- 27 列出跟銷售最好的供應商買最多金額的客戶與購買金額 (不含購買其它供應商的產品)

-- 28 列出那些產品沒有人買過

-- 29 列出沒有傳真 (Fax) 的客戶和它的消費總金額

-- 30 列出每一個城市消費的產品種類數量

-- 31 列出目前沒有庫存的產品在過去總共被訂購的數量

-- 32 列出目前沒有庫存的產品在過去曾經被那些客戶訂購過

-- 33 列出每位員工的下屬的業績總金額

-- 34 列出每家貨運公司運送最多的那一種產品類別與總數量

-- 35 列出每一個客戶買最多的產品類別與金額

-- 36 列出每一個客戶買最多的那一個產品與購買數量

-- 37 按照城市分類，找出每一個城市最近一筆訂單的送貨時間

-- 41 列出購買金額第五名與第十名的客戶，以及兩個客戶的金額差距

----------------------------------------------------------------
-- 38 建立 PIVOT 表，統計銷售金額如下：
-- City, [Beverages], [Condiments], [Seafood]

-- 39 寫一個 TVF 可以帶入上一題所要過濾的價格差 @diff_price，
-- 40 傳回與前一筆價格相差 @diff_price 的產品

-- 41 列出購買金額第五名與第十名的客戶，以及兩個客戶的金額差距


