create database JobsManagement
go

use JobsManagement
go

create table CauHoiBaoMat
(
	cauhoi nvarchar(30) primary key
)
go

create table Acc
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
	mNhacNho int default 30
)
go
--drop database JobsManagement
--insert into Acc values('Admin','1111','ADMIN',N'Số điện thoai của bạn?','0123456789')

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
	tenDangNhap varchar(20) foreign key references Acc(tenDangNhap)
)
go

--cau hoi bao mat
insert into CauHoiBaoMat values(N'Tên giáo viên bạn quý nhất?')
insert into CauHoiBaoMat values(N'Tên idol của bạn?')
insert into CauHoiBaoMat values(N'Tên người yêu của bạn?')
insert into CauHoiBaoMat values(N'Quê hương bạn ở đâu?')
insert into CauHoiBaoMat values(N'Số điện thoai của bạn?')

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

