-- �C�X���O�`���B����Ҧ��Ȥᥭ�����O�`���B���Ȥ᪺�W�r�A�H�ΫȤ᪺���O�`���B
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