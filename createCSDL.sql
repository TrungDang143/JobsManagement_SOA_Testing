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
/*
create table LapLaiT2
(
	lapLai bit default 0 primary key
)
go
create table LapLaiT3
(
	lapLai bit default 0 primary key
)
go
create table LapLaiT4
(
	lapLai bit default 0 primary key
)
go
create table LapLaiT5
(
	lapLai bit default 0 primary key
)
go
create table LapLaiT6
(
	lapLai bit default 0 primary key
)
go
create table LapLaiT7
(
	lapLai bit default 0 primary key
)
go
create table LapLaiCN
(
	lapLai bit default 0 primary key 
)
go
*/
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
insert into CongViec values (0,N'Học OOP','5/31/2023 6:30:00','5/31/2023 9:30:00', N'Sắp diễn ra',0,0,0,0,0,0,0,'trungdang')
-----------------------------------------------------------------------------------------

insert into CongViec values (1, N'trungdangtets', '5/31/2023 6:19:00 PM', '6/2/2023 12:00:00 AM', N'Sắp diễn ra', 0, 0, 0, 0, 0, 0, 0, 'trungdang')
--select tenHienThi from taikhoan where tendangnhap ='trungdang'
select * from CongViec
select * from TaiKhoan
drop database JobsManagement
delete from TaiKhoan

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