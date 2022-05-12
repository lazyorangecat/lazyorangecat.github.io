Select
	*
From Orders
Where OrderDate>'19970101'AND OrderDate<'19980101'

Select OrderDate
From Orders
Where OrderDate Between '19961231'AND '19980101'
--時間不適合用Between!!!!不是多資料就是少資料

