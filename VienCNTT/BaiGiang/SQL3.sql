--Câu 30: hiển thị cột CategoryID và UnitsInStock của những 
--UnitsInStock nhỏ nhất trong table Products 
use Northwind
select *
from Products
where UnitsInStock = (
	select min(UnitsInStock)
	from Products
)
--Câu 32: Hãy tính giá trị trung bình trong cột 
--UnitPrice của CategoryName là ‘Seafood’ 
select avg(P.UnitPrice) as [trung binh don gia]
from Products as P
inner join Categories as C
on P.CategoryID = C.CategoryID
where C.CategoryName like 'Seafood'
--cau 32': tinh trung binh don gia cua tung danh muc:
select 
	C.CategoryName
	,avg(P.UnitPrice) as [trung binh don gia]
from Products as P
inner join Categories as C
on P.CategoryID = C.CategoryID
group by C.CategoryName
--Câu 33: Trong bảng Orders hãy cho biết tổng giá trị cột 
--Freight của những EmployeeID  nào có ít hơn 50 OrderID. 
select 
	EmployeeID
	,sum(Freight) as [tong tien]
	,count(*) as [so hoa don]
from Orders
group by EmployeeID
having count(*)<50
--Câu 34: Hãy cho biết những nhan vien có hơn 50 hoa don
select 
	E.EmployeeID
	,E.FirstName
	,count(*) as [so hoa don]
from Orders as O
inner join Employees as E
on O.EmployeeID = E.EmployeeID
group by E.EmployeeID, E.FirstName
having count(*)>50
--Câu 35: Tính tổng cột UnitsInStock trong table Products 
--của những CategoryName bắt đầu với ký tự ‘C’ 
select avg(UnitsInStock) as [tong so luong]
from Products
where CategoryID in (
	select CategoryID
	from Categories
	where CategoryName like 'C%'
)
--Câu 37: Trong table Employees, hãy cho biết thành phố 
--nào có nhiều nhân viên nhất và số lượng là bao nhiêu 
select 
	City
	,count(*) as [so nhan vien]
from Employees
group by City
having count(*) = (
	select top(1)
		count(*) as kq
	from Employees
	group by City
	order by kq desc
)
select 
	City
	,count(*) as [so nhan vien]
from Employees
group by City
having count(*) = (
	select top(1)
		count(*) as kq
	from Employees
	group by City
	order by kq asc
)
--Câu 39: dùng table Customers và hiển thị các cột: CustomerID, 
--CompanyName, Phone với điều kiện chỉ hiển thị 8 ký tự cuối 
--của số phone, đối với cột Fax thì record nào có giá trị 
--NULL thì thay thế bằng từ ‘UnAvailable’, những record có 
--chứa mã vùng trong cặp dấu 
--ngoặc () thì phân thành ‘Type 1’, còn lại là ‘Type 2’ 
select
	UnitPrice
	,[xep loai] = case
		when UnitPrice < 20 then 'Re'
		when UnitPrice < 40 then 'Trung binh'
		else 'dat'
	end
from Products
--STORED PROCEDURE (thu tuc noi tai)
create proc spTest
as
 select *
 from Products
execute spTest
--Câu 1: Hãy tạo Stored để lấy danh sách nhân viên trong 
--table Employees gồm các thông tin: EmployeeID,LastName
--, FirstName, Title, Birthdate, Address, City 
create proc spCau1
as
begin
	select 
		EmployeeID
		,LastName
		,FirstName
		, Title
		, Birthdate
		, [Address]
		, City
	from Employees
end
execute spCau1
drop proc spCau1
--Câu 2: Tạo Stored để tìm nhân viên có FirstName là ‘Nancy’ 
create proc spCau2
as
begin
	select *
	from Employees
	where FirstName like 'Nancy'
end
execute spCau2
--Câu 5: Tạo Stored hiển thị danh sách nhân viên có năm sinh là số lẻ 
create proc spCau5
as
begin
	select *
	from Employees
	where year(BirthDate) % 2 = 1
end
execute spCau5
--Câu 3: Tạo Stored để tìm nhân viên theo đối số truyền vào 
--là FirstName, ví dụ: truyền vào nhân viên có FirstName là ‘Andrew’ 
create proc spCau3
(
	@ten nvarchar(10)
)
as
begin
	select *
	from Employees
	where FirstName like @ten
end
execute spCau3 'Andrew' --khong co ngoac don!
--Câu 6: Với đối số truyền vào là tháng sinh của nhân viên. 
--Hãy tạo stored và cho biết nhân 
--viên nào có ngày sinh nằm trong tháng đó. 
create proc spCau6
(
	@t int
)
as
begin
	select *
	from Employees
	where month(BirthDate) = @t
end
execute spCau6 5
--Câu 8: Truyền vào stored là một CategoryName, hãy cho biết 
--tổng giá trị cột UnitPrice của 
--những sản phẩm thuộc CategoryName đó. 
alter proc spCau8
(
	@dm nvarchar(15)
)
as
begin
	select sum(UnitPrice) as [tong don gia]
	from Products as P
	inner join Categories as C
	on P.CategoryID = C.CategoryID
	where C.CategoryName like N'%'+@dm+'%'
end
execute spCau8 'food'
--Câu 9: Truyền vào hai số cho store và hiển thị các dữ liệu 
--có UnitsInStock thỏa điều kiện 
--lớn hơn số thứ nhất và nhỏ hơn số thứ hai. 
alter proc spCau9
(
	@tu smallint, @den smallint
)
as
begin
	declare @tam smallint
	if @tu>@den
	begin
		set @tam = @tu
		set @tu = @den
		set @den = @tam
	end
	select *
	from Products
	where UnitsInStock between @tu and @den
end
execute spCau9 10,0
--Câu 10: viết stored để tìm ra tat ca CategoryName nào có 
--nhiều sản phẩm trong bảng product nhất.
create proc spCau10
as
begin
	select 
		C.CategoryName
		,count(*)
	from Products P
	inner join Categories C
	on P.CategoryID = C.CategoryID
	group by C.CategoryName
	having count(*) = (
	select top(1)
		count(*) as kq
	from Products P
	inner join Categories C
	on P.CategoryID = C.CategoryID
	group by C.CategoryName
	order by kq desc
	)
end
execute spCau10

--cac thao tac them/xoa/sua
--viet 1 sp lam nhiem vu them danh muc moi:
alter proc spThemDM
(
	@CategoryName	nvarchar(15)
	,@Description	ntext
)
as
begin
	insert into Categories
	(
		CategoryName	
		,Description	
	)
	values
	(
		@CategoryName	
		,@Description	
	)
end

execute spThemDM 'quat', 'quat trung quoc gia re beo'
alter proc spSuaDM
(
	@CategoryID	int	
	,@CategoryName	nvarchar(15)
	,@Description	ntext
)
as
begin
	update Categories
	set
		CategoryName = @CategoryName 
		,Description	 = @Description
	where
		CategoryID=@CategoryID
end
execute spSuaDM 90,'Quat','Hang Viet Nam chat luong cao'

alter proc spXoa
(
	@CategoryID	int	
)
as
begin
	--kiem tra dieu kien xoa:
	declare @dem int
	select @dem = count(*) 
	from Products 
	where CategoryID = @CategoryID
	if(@dem = 0)
	begin
		delete from Categories
		where
			CategoryID=@CategoryID
	end
end
execute spXoa 7
-- su dung view
-- trigger
-- transaction