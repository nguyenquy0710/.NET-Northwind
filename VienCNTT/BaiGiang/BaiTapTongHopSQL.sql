use Northwind
--Câu 1: Hiển thị các thông tin trong table Region
select *
from Region 
--Câu 2: Hiển thị các cột: CategoryID, CategoryName và Description trong 
--table Categories theo chiều giảm dần cua CategoryName.
select 
	CategoryID
	,CategoryName
	,Description
from Categories
order by CategoryName desc --asc = tang dan (mac dinh)
--Câu 3: Hãy liệt kê các thành phố trong table Customers với thông tin không 
--trùng lặp(su dung DISTINCT)
select distinct City --distinct = phan biet nhau.
from Customers
--Câu 4: Trong table Products hãy hiển thị 2 cột UnitPrice và UnitsInStock 
--đồng thời sắp xếp 2 cột này theo chiều giảm dần. 
select 
	UnitPrice
	,UnitsInStock
from Products
order by UnitPrice,UnitsInStock desc
--Câu 5: Trong table Orders chỉ hiển thị nhưng record có cột Freight dưới 50
select *
from Orders
where Freight < 50
order by Freight desc
--Câu 6: Hãy hiển thị những Employee thuộc TP “London” trong table 
--Employees
select *
from Employees
where City like N'%London%'
--co 2 loai wildcard: _ = ki tu bat ky, % = chuoi ki tu bat ky.
--Câu 7: Hãy hiển thị những Employee có FirstName bắt đầu bằng ký tự “A” trong table 
--Employees
select *
from Employees
where FirstName like N'A%'
--Câu 8: Trong table Employees, hãy liệt kê những nhân viên
--có năm sinh trong khoảng từ 1950 -> 1960 
--cach 1:
select *
from Employees
where 
	year(BirthDate)>=1950
	and year(BirthDate) <= 1960
--cach 2:
select *
from Employees
where year(BirthDate) between 1950 and 1960
--Câu 9: Trong table Shippers hãy liệt kê các CompanyName
-- và số Phone với điều kiện Phone không hiển thị mã vùng 
select 
	CompanyName
	,right(Phone,8)
from Shippers
--Câu 10: Hãy tìm nhân viên có HomePhone mà 4 số cuối là 4444 
select *
from Employees
--where HomePhone like N'%4444'
where right(HomePhone,4) like '4444'
--Câu 11: Hãy tìm những nhân viên
 --ở thành phố ‘Tacoma’ hoặc ‘Seattle’ 
 select *
 from Employees
 where 
	--City like 'Tacoma' or City like 'Seattle'
	City in ('Tacoma','Seattle') --mang (array)
--Câu 12: Hãy hiển thị những nhân viên có TitleOfCourtesy
-- là ‘Mr.’ hoặc ‘Ms.’ 
select *
from Employees
where TitleOfCourtesy in ('Mr.','Ms.')
--Câu 13: Trong table Suppliers, hãy hiển thị những 
--record có số Fax(không null) và có SupplierID từ 5 tới 20 
select *
from Suppliers
where
	Fax is not null
	and SupplierID between 5 and 20
--Câu 15: Trong table Suppliers, hãy hiển thị các record 
--có SupplierID từ 5 -> 20 và không thuộc Country ‘Germany’ 
select *
from Suppliers
where
	SupplierID between 5 and 20
	and 
	--Country <> 'Germany'
	Country not like 'Germany'
--Câu 19: Liệt kê những Product thuộc CategoryName là ‘Seafood’ 
--cach 1: nhanh, it
select *
from Products
where CategoryID in (
	select CategoryID 
	from Categories 
	where CategoryName like 'Seafood'
)
--cach 2: cham, nhieu
select *
from Products,Categories
where Categories.CategoryName like 'Seafood'
--cach 3: pho bien
select 
	P.ProductID
	,P.ProductName
	,P.CategoryID
	,C.CategoryName
from Products as P -- su dung alias
inner join Categories as C
on P.CategoryID = C.CategoryID
where C.CategoryName like 'Seafood'
--Câu 23: Hãy đếm có bao nhiêu Territory thuộc từng Region 
select 
	RegionID
	,count(*) [tổng số Territory] --đếm trên từng nhóm
from Territories
group by RegionID
--Câu 24: Trong table Customers hãy cho biết có bao nhiêu customers không có số fax 
select count(*) as [số khách hàng không có fax] --đếm trên tất cả
from Customers
where Fax is null
--Câu 26: trong table Order Details, hãy thống kê UnitPrice lớn nhất và Quantity lớn nhất 
select 
	max(UnitPrice) as [đơn giá cao nhất]
	,max(Quantity) as [số lượng lớn nhất]
from [Order Details]
--Câu 27: trong table Order Details, hãy thống kê 
--UnitPrice lớn nhất và Quantity lớn nhất theo từng ProductID 
select 
	ProductID
	,max(UnitPrice) as [đơn giá cao nhất]
	,max(Quantity) as [số lượng lớn nhất]
from [Order Details]
group by ProductID
--Câu 28: Tính giá trị trung bình của cột UnitPrice trong table Order Details 
select 
	avg(UnitPrice) [gia trung binh]
from [Order Details]
--Câu 29: tìm những Quantity cao nhất trong table 
--Order Details trên ProductName
select
	P.ProductName
	,sum(O.Quantity) as [so luong]
from [Order Details] as O
inner join Products as P
on O.ProductID	 = P.ProductID
group by P.ProductName
having sum(O.Quantity) = (
	select top(1)
	sum(O.Quantity) as [so luong]
	from [Order Details] as O
	inner join Products as P
	on O.ProductID	 = P.ProductID
	group by P.ProductName
	order by [so luong] desc
)
--Câu 31: hãy hiển thị những giá trị trung bình của UnitPrice 
--theo CategoryID và chỉ hiển thị 
--những giá trị trung bình trong khoảng từ 20 đến 30 
select 
	ProductID
	,avg(UnitPrice) as [trung binh don gia]
from Products
group by ProductID
having avg(UnitPrice) between 20 and 30

