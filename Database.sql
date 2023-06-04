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
	tenDangNhap varchar(20) foreign key references TaiKhoan(tenDangNhap) on delete cascade on update cascade
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
go

-----------------------Hàm và thủ tục--------------

--next ID cong viec
create function getNextID(@userName varchar(20)) returns int
as
begin
	declare @id int
	set @id = (select top(1) id from CongViec where tenDangNhap = @userName order by id desc) + 1
	return @id
end
go

--lay tong so cong viec
create proc GetSoCV(@username varchar(20)) as
begin
	select COUNT(*) from CongViec where tenDangNhap = @username
end
go

--lấy tổng số công việc theo trạng thái
create proc GetSoCVbyTT(@tt nvarchar(20), @username varchar(20)) as
begin
	select COUNT(*) from CongViec where trangThai = @tt and tenDangNhap = @username
end
go

--Doi trang thai cong viec
create proc DoiTrangThai (@id int, @username varchar(20), @tt nvarchar(20)) as
begin
	update CongViec set trangThai = @tt where tenDangNhap = @username and id = @id
end
go

--lấy câu hỏi bảo mât
create proc GetCHBM as
begin
	select * from cauhoibaomat
end
go

--lấy thông tin tài khoản
create proc GetTTTK(@username varchar(20)) as
begin
	select * from TaiKhoan where tenDangNhap = @username
end
go

--cai dat khoi dong cung he thong
create proc SetKD(@i bit, @username varchar(20))as
begin
	update TaiKhoan set khoiDong = @i where tenDangNhap = @username
end
go

--cai dat nhac nho tổng công việc
create proc SetNN(@i bit, @username varchar(20))as
begin
	update TaiKhoan set nhacNho = @i where tenDangNhap = @username
end
go

--cat dat thời gian lặp lại nhắc nhở
create proc SetTimeNN(@h int, @m int, @username varchar(20))as
begin
	update TaiKhoan set hNhacNho = @h, mNhacNho = @m where tenDangNhap = @username
end
go


--cai dat nhắc nhở công việc bắt đầu diễn ra
create proc SetNNCV(@i bit, @username varchar(20))as
begin
	update TaiKhoan set nhacNhoCV = @i where tenDangNhap = @username
end
go

--xoa tai khoan
create proc XoaTK(@password varchar(20))as
begin
	delete from TaiKhoan where matKhau =@password
end
go

--xoa tai khoan admin
create proc DeleteAcc(@userName varchar(20))as
begin
	delete from TaiKhoan where tenDangNhap =@userName
end
go

--them cong viec
create proc AddJob (@id int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	insert into CongViec values(@id, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap)
end
go

-- Dang NHAP
create proc DangNhap_1 (@userName varchar(20), @passWord varchar(20))
as
begin	
	select * from TaiKhoan where tenDangNhap = @userName AND matKhau = @passWord
end

create proc DangNhap_2 (@userName varchar(20))
as
begin
	select * from TaiKhoan where tenDangNhap = @userName
end

-- DANG KY
create proc DangKy_1 (@userName varchar(20), @passWord varchar(20), @tenHT nvarchar(30), @cauHoi nvarchar(30), @traLoi nvarchar(30))
as
begin
	insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi) values(@userName, @passWord, @tenHT, @cauHoi, @traLoi)
end

--sua cong viec
create proc ChangeJob (@id int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	update CongViec set noiDungCV = @noiDungCV, tgBD = @tgBD, tgKT = @tgKT, trangThai = @trangThai, lapLaiT2 =  @t2, lapLaiT3 =  @t3, lapLaiT4 =  @t4, lapLaiT5 =  @t5, lapLaiT6 =  @t6, lapLaiT7 =  @t7, lapLaiCN =  @cn where tenDangNhap = @tenDangNhap and id = @id
end
go

--lay cong viec theo khoảng
CREATE PROCEDURE GetCongViecByDateRange
    @startDate DATE,
    @endDate DATE,
	@username varchar(20)
AS
BEGIN

    SELECT id, noiDungCV as N'Nội dung công việc', tgBD as N'Bắt đầu', tgKT as N'Kết thúc', trangThai as N'Trạng thái'
    FROM congviec
    WHERE CONVERT(DATE, tgBD) >= @startDate 
    AND CONVERT(DATE, tgKT) <= @endDate
	and tenDangNhap = @username
END
go

--lay cong viec theo id username
create proc GetCongViecByID_Username (@id int, @username varchar(20)) as
begin
	select * from CongViec where id = @id and tenDangNhap = @username
end
go
