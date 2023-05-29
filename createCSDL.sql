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
	ghiNho bit default 1,
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

create table LapLai
(
	lapLai nvarchar(10) primary key
)
go

create table CongViec
(
	
	id int primary key,
	noiDungCV nvarchar(50) not null,
	gioBD int not null,
	phutBD int not null,
	ngayBD date not null,
	gioKT int not null,
	phutKT int not null,
	ngayKT date not null,
	trangThai nvarchar(20) foreign key references TrangThai(trangThai),
	lapLai nvarchar(10) foreign key references LapLai(lapLai),
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

--lap lai
insert into LapLai values(N'T2')
insert into LapLai values(N'T3')
insert into LapLai values(N'T4')
insert into LapLai values(N'T5')
insert into LapLai values(N'T6')
insert into LapLai values(N'T7')
insert into LapLai values(N'CN')
insert into LapLai values(N'Hàng ngày')

insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi, isAD) values('Admin','1111','ADMIN',N'Kỉ niệm đáng nhớ?','abc', 1)
insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi, isAD) values('trungdang','1403','TrungDang',N'Kỉ niệm đáng nhớ?','abcd', 0)

--select tenHienThi from taikhoan where tendangnhap ='trungdang'
select * from TaiKhoan
--drop database JobsManagement
delete from TaiKhoan
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

