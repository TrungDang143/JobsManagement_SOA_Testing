create database JobsManagement
go

use JobsManagement
go

create table CauHoiBaoMat
(
	cauhoi nvarchar(30) primary key
)
go

create table TaiKhoan
(
	tenDangNhap varchar(20) primary key,
	matKhau varchar(20) not null,
	tenHienThi nvarchar(30) not null,
	cauhoi nvarchar(30) foreign key references CauHoiBaoMat(cauhoi),
	traLoi nvarchar(30) not null,
	khoiDong bit default 1,
	nhacNhoCV bit default 1,
	nhacNho bit default 1,
	hNhacNho int default 0,
	mNhacNho int default 30,
	isAD bit default 0
)
go

create table TrangThai
(
	trangThai nvarchar(20) primary key
)
go

create table CongViec
(
	
	id int primary key,
	noiDungCV nvarchar(50) not null,
	tgBD datetime not null,
	tgKT datetime not null,
	trangThai nvarchar(20) default N'Sắp diễn ra' foreign key references TrangThai(trangThai),
	lapLaiT2 bit default 0,
	lapLaiT3 bit default 0,
	lapLaiT4 bit default 0,
	lapLaiT5 bit default 0,
	lapLaiT6 bit default 0,
	lapLaiT7 bit default 0,
	lapLaiCN bit default 0,
	tenDangNhap varchar(20) foreign key references TaiKhoan(tenDangNhap)
)
go

--cau hoi bao mat
insert into CauHoiBaoMat values(N'Giáo viên bạn quý nhất?')
insert into CauHoiBaoMat values(N'Nơi bạn và ny gặp lần đầu?')
insert into CauHoiBaoMat values(N'Nơi bạn thích đến nhất?')
insert into CauHoiBaoMat values(N'Kỉ niệm đáng nhớ?')
insert into CauHoiBaoMat values(N'Biệt danh lúc nhỏ?')
insert into CauHoiBaoMat values(N'Tên thú cưng đầu tiên?')

--trang thai
insert into TrangThai values(N'Sắp diễn ra')
insert into TrangThai values(N'Đang diễn ra')
insert into TrangThai values(N'Đã hoàn thành')
insert into TrangThai values(N'Chưa hoàn thành')



insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi, isAD) values('Admin','1111','ADMIN',N'Kỉ niệm đáng nhớ?','abc', 1)
insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi, isAD) values('trungdang','1403','TrungDang',N'Kỉ niệm đáng nhớ?','abcd', 0)
insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi, isAD) values('tridinh','0000','Tri',N'Kỉ niệm đáng nhớ?','xyzt', 0)
insert into CongViec values (0,N'Học OOP','5/31/2023 6:30:00','5/31/2023 9:30:00', N'Sắp diễn ra',0,0,0,0,0,0,0,'trungdang')
-----------------------------------------------------------------------------------------

insert into CongViec(id, noiDungCV, tgBD, tgKT, trangThai, tenDangNhap) values (1, N'trungdangtets', '5/31/2023', '6/2/2023', N'Sắp diễn ra', 'trungdang')
--select tenHienThi from taikhoan where tendangnhap ='trungdang'
select * from CongViec
select * from TaiKhoan
drop database JobsManagement
delete from TaiKhoan
select * from CauHoiBaoMat
print datepart(getdate())
select top(1) id from CongViec where tenDangNhap = 'trungdang' order by id desc
/*
insert into Acc (tenDangNhap,matKhau,tenHienThi,traLoi) values('Admin','1111','ADMIN','Tên giáo viên bạn quý nhất?','0123456789')
select * from Acc

create proc [dbo].[SP_AuthorizationLogin]
@UserName nvarchar(20),
@PassWord nvarchar(20)
as
begin
    if exists (select * from Acc where tenDangNhap = @UserName and matKhau = @PassWord)
        select 0 as code
	else  
        select 1 as code
end

create proc [dbo].[SP_Retrieve_User]
as
begin
    select * from Acc
end

create proc [dbo].[SP_ThemTaiKhoan]
@TaiKhoan varchar(20),
@TenHienThi nvarchar(30),
@MatKhau varchar(20),
@traLoi nvarchar(30)
as
begin
    Insert into Acc values(@TaiKhoan,@MatKhau,@TenHienThi,@traLoi)
end
*/

create proc DangNhap_1 (@userName varchar(20), @passWord varchar(20))
as
begin	
	select * from TaiKhoan where tenDangNhap = @userName AND matKhau = @passWord
end

exec DangNhap_1 'Admin', '1111'

create proc DangNhap_2 (@userName varchar(20))
as
begin
	select * from TaiKhoan where tenDangNhap = @userName
end
--drop proc DangNhap_2
exec DangNhap_2 'Admin'


create proc DangKy_1 (@userName varchar(20), @passWord varchar(20), @tenHT nvarchar(30), @cauHoi nvarchar(30), @traLoi nvarchar(30))
as
begin
	insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi) values(@userName, @passWord, @tenHT, @cauHoi, @traLoi)
end
--drop proc DangKy
go

exec DangKy_1 'dinhtri', '1111', 'tri', N'Kỉ niệm đáng nhớ?', 'xyz'
exec DangKy_1 'tridinh', '1111', 'tri', N'Tên thú cưng đầu tiên?', 'xyz'



select * from CongViec
select * from TaiKhoan
insert into CongViec values (0,N'Học OOP','6/1/2023 6:30:00','06/03/2023 9:30:00', N'Sắp diễn ra',0,0,0,0,0,0,0,'trungdang')
insert into CongViec values (1,N'Học CTDL','6/15/2023 6:30:00','6/30/2023 9:30:00', N'Sắp diễn ra',0,0,0,0,0,0,0,'Admin')
insert into CongViec values (2,N'Học SQL','5/30/2023 6:30:00','6/15/2023 22:30:00', N'Sắp diễn ra',0,0,0,0,0,0,0,'tridinh')
insert into CongViec values (3,N'Training','6/2/2023 6:30:00','6/2/2023 22:30:00', N'Sắp diễn ra',0,0,0,0,0,0,0,'tridinh')
insert into CongViec values (4,N'di lam','6/1/2023 6:30:00','06/03/2023 9:30:00', N'Sắp diễn ra',0,0,0,0,0,0,0,'trungdang')
insert into CongViec values (5,N'ABC','07/15/2023 6:30:00','07/30/2023 9:30:00', N'Sắp diễn ra',0,0,0,0,0,0,0,'Admin')

delete from CongViec
create view Today
as
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where (year(tgBD) = year(getdate()) AND month(tgBD) = month(getdate()) AND day(tgBD) = day(getdate())) 
	OR (year(tgKT) = year(getdate()) AND month(tgKT) = month(getdate()) AND day(tgKT) = day(getdate()))
	OR (tgBD < getdate() AND getdate() < tgKT)
drop view Today
select * from CongViec where year(tgBD) = year(getdate()) AND month(tgBD) = month(getdate()) AND day(tgBD) = day(getdate())


select * from Today

create view Tomorrow
as
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where (year(tgBD) = year(getdate()+1) AND month(tgBD) = month(getdate()+1) AND day(tgBD) = day(getdate()+1)) 
	OR (year(tgKT) = year(getdate()+1) AND month(tgKT) = month(getdate()+1) AND day(tgKT) = day(getdate()+1))
	OR (tgBD < getdate()+1 AND getdate()+1 < tgKT)
	drop view Tomorrow
select * from Tomorrow

create view thisWeek
as
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where year(tgBD) = year(getdate()) AND datepart(week, getdate()) = datepart(week, tgBD)
	OR year(tgKT) = year(getdate()) AND datepart(week, getdate()) = datepart(week, tgKT)


select * from thisWeek


create view thisMonth
as
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where year(tgBD) = year(getdate()) AND month(tgBD) = month(getdate())
	OR year(tgKT) = year(getdate()) AND month(tgKT) = month(getdate())

select * from thisMonth

create proc hienThiCV(@userName varchar(20))
as
begin
	select noiDungCV, tgBD, tgKT, trangThai from CongViec where tenDangNhap = @userName
end

exec hienThiCV 'tridinh'

--HOM NAY
create proc hienCV (@userName varchar(20), @time datetime)
as 
begin
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where ((year(tgBD) = year(@time) AND month(tgBD) = month(@time) AND day(tgBD) = day(@time)) 
	OR (year(tgKT) = year(@time) AND month(tgKT) = month(@time) AND day(tgKT) = day(@time))
	OR (tgBD < @time AND @time < tgKT)) AND tenDangNhap = @userName
end
exec hienCV 'trungdang', '6/3/2023'

create proc hienCV_1 (@userName varchar(20), @time datetime)
as 
begin
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where ((year(tgBD) = year(@time) AND month(tgBD) = month(@time) AND day(tgBD) = day(@time)) 
	OR (year(tgKT) = year(@time) AND month(tgKT) = month(@time) AND day(tgKT) = day(@time))) AND tenDangNhap = @userName
end

--- TUAN NAYY
create proc TuanNay (@userName varchar(20))
as 
begin
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where (year(tgBD) = year(getdate()) AND datepart(week, getdate()) = datepart(week, tgBD)
	OR year(tgKT) = year(getdate()) AND datepart(week, getdate()) = datepart(week, tgKT))
	AND tenDangNhap = @userName
end
--NGAY MAI
create proc NgayMai (@userName varchar(20))
as 
begin
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where (datepart(year,getdate()) = datepart(year, tgBD) AND datepart(month,getdate()) = datepart(month, tgBD) AND datepart(day,getdate()+1) = datepart(day, tgBD)
	OR datepart(year,getdate()) = datepart(year, tgBD) AND datepart(month,getdate() + 1) = datepart(month, tgBD) AND datepart(day,getdate()+1) = datepart(day, tgBD)
	OR datepart(year,getdate()) = datepart(year, tgKT) AND datepart(month,getdate()) = datepart(month, tgKT) AND datepart(day,getdate()+1) = datepart(day, tgKT)
	OR datepart(year,getdate()) = datepart(year, tgKT) AND datepart(month,getdate() + 1) = datepart(month, tgKT) AND datepart(day,getdate()+1) = datepart(day, tgKT)
	OR tgBD < getdate()+1 AND getdate()+1 < tgKT)
	AND tenDangNhap = @userName
end
drop proc NgayMai
--THANG NAYY
create proc ThangNay (@userName varchar(20))
as 
begin
	select noiDungCV, tgBD, tgKT, trangThai from CongViec
	where (year(tgBD) = year(getdate()) AND month(tgBD) = month(getdate())
	OR year(tgKT) = year(getdate()) AND month(tgKT) = month(getdate()))
	AND tenDangNhap = @userName
end
drop proc NgayMai
exec NgayMai 'tridinh'
exec HomNay 'tridinh'
exec TuanNay 'tridinh'
exec ThangNay 'trungdang'

select datepart(year, tgKT),
datepart(month, tgKT),
datepart(day, tgKT)
go
--from CongViec where tenDangNhap = 'trungdang'
----------------------------------


exec DoiTrangThai 6, trungdang, N'Chưa hoàn thành'
SELECT	 * FROM CongViec
