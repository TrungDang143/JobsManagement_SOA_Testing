use master
go
drop database JobsManagement
go

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
	cauhoi nvarchar(30) foreign key references CauHoiBaoMat(cauhoi) on delete cascade on update cascade,
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
	id int identity(1,1) primary key,
	idLap int default 0,
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

--next ID lap
create function getNextIdLap(@userName varchar(20)) returns int
as
begin
	declare @id int
	set @id = (select top(1) idLap from CongViec where tenDangNhap = @userName order by idLap desc) 
	set @id = @id+1
	if (@id is null) set @id = 0
	return @id
end
go

--lay tong so cong viec theo ngay
create proc GetSoCVbyTimeRange(@username varchar(20), @startDate datetime, @endDate datetime) as
begin
	select COUNT(*) from CongViec 
	WHERE CONVERT(DATE, tgBD) >= @startDate 
    AND CONVERT(DATE, tgKT) <= @endDate
end
go

--lấy tổng số công việc theo trạng thái
create proc GetSoCVbyTTandTimeRange(@tt nvarchar(20), @username varchar(20), @startDate datetime, @endDate datetime) as
begin
	select COUNT(*) from CongViec 
	where trangThai = @tt and tenDangNhap = @username
	and CONVERT(DATE, tgBD) >= @startDate 
    AND CONVERT(DATE, tgKT) <= @endDate
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
create proc AddJob (@idLap int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	insert into CongViec values(@idLap, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap)
end
go

-- Dang NHAP
create proc DangNhap_1 (@userName varchar(20), @passWord varchar(20))
as
begin	
	select * from TaiKhoan where tenDangNhap = @userName AND matKhau = @passWord
end
go

create proc DangNhap_2 (@userName varchar(20))
as
begin
	select * from TaiKhoan where tenDangNhap = @userName
end
go

-- DANG KY
create proc DangKy_1 (@userName varchar(20), @passWord varchar(20), @tenHT nvarchar(30), @cauHoi nvarchar(30), @traLoi nvarchar(30))
as
begin
	insert into TaiKhoan(tenDangNhap, matKhau, tenHienThi, cauhoi, traLoi) values(@userName, @passWord, @tenHT, @cauHoi, @traLoi)
end
go

--sua cong viec
create proc ChangeJob (@id int, @idLap int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	if(@idLap = 0)
		update CongViec set noiDungCV = @noiDungCV, tgBD = @tgBD, tgKT = @tgKT, trangThai = @trangThai, lapLaiT2 =  @t2, lapLaiT3 =  @t3, lapLaiT4 =  @t4, lapLaiT5 =  @t5, lapLaiT6 =  @t6, lapLaiT7 =  @t7, lapLaiCN =  @cn where tenDangNhap = @tenDangNhap and id = @id
	else update CongViec set noiDungCV = @noiDungCV, tgBD = @tgBD, tgKT = @tgKT, trangThai = @trangThai, lapLaiT2 =  @t2, lapLaiT3 =  @t3, lapLaiT4 =  @t4, lapLaiT5 =  @t5, lapLaiT6 =  @t6, lapLaiT7 =  @t7, lapLaiCN =  @cn where tenDangNhap = @tenDangNhap and idlap = @idLap
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

--xoa cong viec
create proc XoaCongViec (@id int, @idLap int, @username varchar(20)) as
begin
	if(@idLap = 0)
		delete from CongViec where tenDangNhap = @username and id = @id
	else delete from CongViec where tenDangNhap = @username and idLap = @idLap
end
go

--lay idLap
create function GetIdLapLai (@id int, @username varchar(20)) returns int as
begin
	declare @isLap int
	set @isLap = (select idLap from CongViec where id = @id and tenDangNhap = @username)
	return @isLap
end
go

--thay doi cong viec
create proc ChangeJob (@truongHop int, @id int, @idLap int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	if(@truongHop = 1)
		exec ChangeJob_KLap_KLap @id, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap
	else if(@truongHop = 2)
		exec ChangeJob_Lap_Lap @idLap, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap
	else if(@truongHop = 3)
		exec ChangeJob_KLap_Lap @idLap, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap
	else if(@truongHop = 4)
		exec ChangeJob_Lap_KLap @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap
	else
		exec ChangeJob_Lap_newLap @idLap, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap
end
drop proc ChangeJob
go

--giữ nguyên trạng thái lặp: k lăp - k lap
create proc ChangeJob_KLap_KLap (@id int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	update CongViec set 
		noiDungCV = @noiDungCV, 
		tgBD = @tgBD,
		tgkt = @tgKT,
		trangThai = @trangThai
		where tenDangNhap = @tenDangNhap and id = @id
end
go
--giữ nguyên trạng thái lặp: lặp lại tư tượng
create proc ChangeJob_Lap_Lap (@idLap int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	update CongViec set 
		noiDungCV = @noiDungCV, 
		tgBD =  DATEADD(HOUR, DATEPART(HOUR, @tgBD) - DATEPART(HOUR, tgBD), DATEADD(MINUTE, DATEPART(MINUTE, @tgBD) - DATEPART(MINUTE, tgBD), tgBD)),
		tgkt = DATEADD(HOUR, DATEPART(HOUR, @tgKT) - DATEPART(HOUR, tgKT), DATEADD(MINUTE, DATEPART(MINUTE, @tgKT) - DATEPART(MINUTE, tgKT), tgKT)),
		trangThai = @trangThai
		where tenDangNhap = @tenDangNhap and idLap = @idLap
end
go

--thay đổi trạng thái lặp: k lặp - lặp
create proc ChangeJob_KLap_Lap (@idLap int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	insert into CongViec values(@idLap, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap)
end
go

-- thay đổi trạng thái: lặp - k lặp
create proc ChangeJob_Lap_KLap (@noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	insert into CongViec values(0, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap)
end
go

-- thay đổi trạng thái: lặp - lặp khác
create proc ChangeJob_Lap_newLap (@idLap int, @noiDungCV nvarchar(50), @tgBD datetime, @tgKT datetime, @trangThai nvarchar(20), @t2 bit, @t3 bit, @t4 bit, @t5 bit, @t6 bit, @t7 bit, @cn bit, @tenDangNhap varchar(20)) as
begin
	insert into CongViec values(@idLap, @noiDungCV, @tgBD, @tgKT, @trangThai, @t2, @t3, @t4, @t5, @t6, @t7, @cn, @tenDangNhap)
end
go

--lấy thống kê công việc chưa hoàn thành
create proc chuaHT(
	@userName varchar(20)
)
as
begin 
	select noiDungCV from CongViec	
	where trangThai = N'Chưa hoàn thành'
	and tenDangNhap = @userName
end

--đếm số lượng công việc chưa hoàn thành
create proc countChuaHT(
	@userName varchar(20)
)
as
begin 
	select COUNT(*) from CongViec	
	where trangThai = N'Chưa hoàn thành'
	and tenDangNhap = @userName
end

--lấy thống kê công việc đã hoàn thành 
create proc daHT(
	@userName varchar(20)
)
as
begin 
	select noiDungCV from CongViec	
	where trangThai = N'Đã hoàn thành'
	and tenDangNhap = @userName
end

--đếm số lương công việc đã hoàn thành
create proc countDaHT(
	@userName varchar(20)
)
as
begin 
	select COUNT(*) from CongViec	
	where trangThai = N'Đã hoàn thành'
	and tenDangNhap = @userName
end

--thay đổi tên người dùng
create proc changeUserName(
	@loginName varchar(20),
	@userName nvarchar(20)
)
as 
begin 
	update TaiKhoan
	set tenHienThi = @userName
	where tenDangNhap = @loginName
end

--thay đổi mật khẩu
create proc changePassWord(
	@loginName varchar(20),
	@passWord nvarchar(20)
)
as 
begin 
	update TaiKhoan
	set matKhau = @passWord
	where tenDangNhap = @loginName
end

--lấy nội dung thống kê công việc theo ngày
CREATE PROCEDURE GetNoiDungByDateRange
    @startDate DATE,
    @endDate DATE,
	@username varchar(20)
AS
BEGIN

    SELECT noiDungCV 
    FROM congviec
    WHERE CONVERT(DATE, tgBD) >= @startDate 
    AND CONVERT(DATE, tgKT) <= @endDate
	and tenDangNhap = @username
END
go
