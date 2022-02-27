alter function fnTongBP
(
--tinh tong tu 2 => n
	@n int 
)
returns int
as
begin
	declare @t int, @i int
	set @t = 0
	set @i=1
	while(@i<@n)
	begin
		set @i += 1
		if(@i % 2 = 1)set @t += POWER(@i,2)
	end
	return @t
end
print(dbo.fnTongBP(5))

