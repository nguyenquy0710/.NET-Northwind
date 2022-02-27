--huong dan su dung T-SQL:
--mot so ham co san:
--print(N'xin chào');
----ham ve chuoi ki tu:
--declare @s nvarchar(50)
--set @s = N'đại học gtvt'
--print(left(@s,3))
--print(right(@s,4))
--print(substring(@s,5,3))
--print(len(@s))
--print(upper(@s))
--print(lower(@s))
--các hàm về datetime:
--print(getdate())
--declare @ngay date
--set @ngay = '2016/5/15'
--print(N'năm = '+cast(year(@ngay) as varchar))
--print(datepart(weekday,@ngay))
--print(datediff(day,getdate(),@ngay)) --day = interval = khoang thoi gian
--cac ham toan hoc:
--declare @a float
--set @a = 3.14
--print(sqrt(@a))
--print(power(@a,2))
--print(round(@a,1))
--print(ceiling(@a))
--print(floor(@a))
--cac phep toan:
print(5%2)
--tim max 3 so a, b, c:
--declare @a int, @b int, @c int, @m int
--set @a = 123
--set @b = 231
--set @c = 45666
--set @m = @a
--if @m<@b
--begin -- chinh la {
--	set @m = @b
--end -- chinh la }
--if (@m <@c)
--	set @m = @c
--print(N'số lớn nhất = '+cast(@m as varchar))
--giai phuong trinh bac nhat ax + b = 0:
--declare @a float, @b float, @x float
--set @a = 0
--set @b = 10
--if @a = 0 and @b = 0
--	print(N'vô số nghiệm')
--else
--	if @b <> 0
--		print(N'vô nghiệm')
--	else
--	begin
--		set @x = -@b/@a
--		print(N'nghiệm x = '+cast(@x as varchar))
--	end
--giai phuong trinh bac hai:
--declare @a float, @b float, @c float, @x1 float, @x2 float, @d float
--set @a = 1
--set @b = 5
--set @c = 6
--set @d = power(@b,2) - 4*@a*@c
--if @d< 0
--	print(N'PT vô nghiệm');
--else
--begin
--	set @x1 = (-@b-sqrt(@d))/(2*@a)
--	set @x2 = (-@b+sqrt(@d))/(2*@a)
--	print('x1 = '+cast(@x1 as varchar) + ', x2 = '+cast(@x2 as varchar) )
--end
--lenh while:
--tinh tong 1 -> 100:
--declare @tong int, @i int
--set @tong = 0
--set @i = 1
--while @i<=100
--begin
--	set @tong += @i;
--	set @i+=1
--end
--print(@tong)
--lenh case ... when (tuong tu switch C#):
--dau vao: la ngay thang nam
--dau ra: Thu Hai, ..., Chu Nhat
--declare @n date, @kq nvarchar(20)
--set @n = '1977/11/29'
--set @kq = case DATEPART(weekday,@n)
--	when 1 then N'Chủ Nhật'
--	when 2 then N'Thứ Hai'
--	when 3 then N'Thứ Ba'
--	when 4 then N'Thứ Tư'
--	when 5 then N'Thứ Năm'
--	when 6 then N'Thứ Sáu'
--	when 7 then N'Thứ Bảy'
--end
--print(@kq)
--HÀM:
--tinh tong 1 => n:
use master
go --phan tach cac lô code t-sql
alter function fnTinhTong
(
	@n int
)
returns int
as
begin
	declare @tong int, @i int
	set @tong = 0
	set @i = 1
	while @i<=@n
	begin
		set @tong += @i;
		set @i+=1
	end
	return @tong
end
print(dbo.fnTinhTong(20))
create function fnNgayThu
(
	@n date
)
returns nvarchar(20)
as
begin
	declare @kq nvarchar(20)
	set @kq = case DATEPART(weekday,@n)
		when 1 then N'Chủ Nhật'
		when 2 then N'Thứ Hai'
		when 3 then N'Thứ Ba'
		when 4 then N'Thứ Tư'
		when 5 then N'Thứ Năm'
		when 6 then N'Thứ Sáu'
		when 7 then N'Thứ Bảy'
	end
	return @kq
end
print(dbo.fnNgayThu(getdate()))
--ĐỊNH NGHĨA DỮ LIỆU
--thao tac voi database
create database ASP
go
use ASP
use master
go
drop database ASP
-- thao tac voi table
create table SinhVien
(
	MaSV char(2) not null,
	HoTen nvarchar(50) not null,
	NgaySinh date,
	GioiTinh bit,
	DiemTB float,
	DiaChi ntext,
	primary key(MaSV)
)

create table LopHoc
(
	Ma char(2) primary key,
	Ten nvarchar(50) not null,
)
alter table SinhVien
add	MaLop char(2)
--tao relationship:
alter table SinhVien
add 
	foreign key(MaLop)
	references LopHoc(Ma)

