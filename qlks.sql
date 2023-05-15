use master 
if exists (select * from sysdatabases where name = 'QLKS')
	drop database QLKS

create database QLKS
use QLKS

create table TaiKhoan
(
	tenTK varchar(50) not null,
	mk varchar(50),
	loai int, 
	constraint pk_TaiKhoan primary key(tenTK)
)


create table NhanVien
(
	maNV varchar(10) not null,
	hoTen nvarchar(30) not null,
	ngaySinh date not null,
	gioiTinh bit not null,
	cccd varchar(20) not null,
	sdt varchar(11) not null,
	constraint pk_NhanVien primary key(maNV)
)

create table Phong
(
	maPhong int identity(1,1),
	loaiPhong varchar(20), --single, double, triple, ...
	soNguoi int, --So nguoi toi da
	giaPhong int,
	trangThai bit,
	constraint pk_Phong primary key(maPhong),
)
create table KhachHang
(
	maKH varchar(10) not null,
	maPhong int,
	hoTen nvarchar(30) ,
	gioiTinh bit,
	diaChi nvarchar(100)  ,
	queQuan nvarchar(100) ,
	sdt varchar(11) ,
	cccd varchar(20) ,
	ngayDatPhong date not null,
	ngayTraPhong date not null,

	constraint pk_KhachHang primary key(maKH),
	constraint fk_KH_maPhong foreign key(maPhong) references Phong(maPhong)
)


create table DichVu
(
	maDichVu int identity(1,1) not null,
	tenDichVu nvarchar(30) not null,
	giaDichVu int not null,

	constraint pk_DichVU primary key(maDichVu),
)



--Phong n-n DichVu
create table ChiTietDichVu
(
	maDichVu int,
	maPhong int,
	thanhTien int,

	constraint pk_CTDV primary key(maDichVu, maPhong),
	constraint fk_CTDV_maDichVu foreign key(maDichVu) references DichVu(maDichVu),
	constraint fk_CTDV_maPhong foreign key(maPhong) references Phong(maPhong)

)

create table HoaDon
(
	maHoaDon int identity(1,1) not null,
	tongTien int not null,	
	ngayLap date default getdate() not null,
	constraint pk_HoaDon primary key(maHoaDon)

)

create table ChiTietHoaDon
(
	maHoaDon int not null,
	maPhong int not null, --lay tu chi tiet dich vu de co thanhTien
	

	constraint pk_CTHD primary key(maHoaDon, maPhong),
	constraint fk_CTHD_HD foreign key(maHoaDon) references HoaDon(maHoaDon),
	constraint fk_CTHD_Phong foreign key(maPhong) references Phong(maPhong)


)	



--Trigger add vao TaiKhoan sau khi add NhanVien (tenTK: maNV, mk: sdt)
go 
CREATE TRIGGER trg_InsertTaiKhoanForNewEmployee
ON NhanVien
AFTER INSERT
AS
BEGIN
	INSERT INTO TaiKhoan (tenTK, mk, loai)
	SELECT i.maNV, i.sdt, 2
	FROM inserted i
	LEFT JOIN TaiKhoan t ON i.maNV = t.tenTK
	WHERE t.tenTK IS NULL;
END
go

--Trigger update TaiKhoan sau khi update NhanVien
CREATE TRIGGER trg_UpdateTaiKhoanForUpdatedEmployee
ON NhanVien
AFTER UPDATE
AS
BEGIN
	UPDATE TaiKhoan
	SET mk = i.sdt
	FROM TaiKhoan t
	INNER JOIN inserted i ON t.tenTK = i.maNV
	INNER JOIN deleted d ON i.maNV = d.maNV;
END


go
--Trigger delete TaiKhoan sau khi delete NhanVien
CREATE TRIGGER trg_DeleteTaiKhoanForDeletedEmployee
ON NhanVien
AFTER DELETE
AS
BEGIN
	DELETE FROM TaiKhoan
	WHERE tenTK IN (SELECT maNV FROM deleted);
END
CREATE FUNCTION dbo.auto_mKH()
RETURNS VARCHAR(10)
AS
BEGIN
  DECLARE @ID VARCHAR(10)

  IF (SELECT COUNT(maKH) FROM KhachHang) = 0
    SET @ID = 'KH000'
  ELSE
    SELECT @ID = MAX(RIGHT(maKH, 3)) FROM KhachHang

  SELECT @ID = CASE
      WHEN @ID >= 0 AND @ID < 9 THEN 'KH00' + CONVERT(VARCHAR, CAST(@ID AS INT) + 1)
      WHEN @ID >= 9 AND @ID < 99 THEN 'KH0' + CONVERT(VARCHAR, CAST(@ID AS INT) + 1)
      WHEN @ID >= 99 AND @ID < 999 THEN 'KH' + CONVERT(VARCHAR, CAST(@ID AS INT) + 1)
    END

  RETURN @ID
END

select * from NhanVien

--Ham Tu Dong Tang: Khach Hang
go

go

--Ham Tu Dong Tang: Nhan Vien
go
CREATE FUNCTION dbo.auto_mNV()
RETURNS VARCHAR(10)
AS
BEGIN
  DECLARE @ID VARCHAR(10)

  IF (SELECT COUNT(maNV) FROM NhanVien) = 0
    SET @ID = 'NV000'
  ELSE
    SELECT @ID = MAX(RIGHT(maNV, 3)) FROM NhanVien

  SELECT @ID = CASE
      WHEN @ID >= 0 AND @ID < 9 THEN 'NV00' + CONVERT(VARCHAR, CAST(@ID AS INT) + 1)
      WHEN @ID >= 9 AND @ID < 99 THEN 'NV0' + CONVERT(VARCHAR, CAST(@ID AS INT) + 1)
      WHEN @ID >= 99 AND @ID < 999 THEN 'NV' + CONVERT(VARCHAR, CAST(@ID AS INT) + 1)
    END

  RETURN @ID
END

go


--Procedure CRUD NhanVien
go
CREATE PROCEDURE dbo.NhanVien_CRUD
	@StatementType VARCHAR(10),
	@Ma_NV VARCHAR(20) = NULL,
	@HoTen_NV NVARCHAR(50) = NULL,
	@Nam_sinh DATE = NULL,
	@Gioi_tinh BIT = NULL,
	@CCCD VARCHAR(20) = NULL,
	@sdt VARCHAR(11) = NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.NhanVien
		WHERE maNV = @Ma_NV
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.NhanVien (maNV, hoTen, ngaySinh, gioiTinh, cccd, sdt)
		VALUES (dbo.auto_mNV(), @HoTen_NV, @Nam_sinh, @Gioi_tinh, @CCCD, @sdt)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.NhanVien
		SET hoTen = @HoTen_NV,
			ngaySinh = @Nam_sinh,
			gioiTinh = @Gioi_tinh,
			cccd = @CCCD,
			sdt = @sdt
		WHERE maNV = @Ma_NV
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.NhanVien
		WHERE maNV = @Ma_NV
	END
END
go


--Procedure CRUD KhachHang
CREATE PROCEDURE dbo.KhachHang_CRUD
	@StatementType VARCHAR(10),
	@Ma_KH VARCHAR(20) = NULL,
	@Ma_phong INT = NULL,
	@HoTen_KH NVARCHAR(50) = NULL,
	@Gioi_tinh BIT = NULL,
	@Dia_chi NVARCHAR(50) = NULL,
	@Que_quan NVARCHAR(50) = NULL,
	@sdt VARCHAR(11) = NULL,
	@CCCD VARCHAR(20) = NULL,
	@Ngay_dat_phong DATE = NULL,
	@Ngay_tra_phong DATE = NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.KhachHang
		WHERE maKH = @Ma_KH
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.KhachHang (maPhong, maKH, hoTen, gioiTinh, diaChi, queQuan, sdt, cccd, ngayDatPhong, ngayTraPhong)
		VALUES (dbo.auto_mKH(), @Ma_phong, @HoTen_KH, @Gioi_tinh, @Dia_chi, @Que_quan, @sdt, @CCCD, @Ngay_dat_phong, @Ngay_tra_phong)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.KhachHang
		SET hoTen = @HoTen_KH,
			maPhong = @Ma_phong,
			gioiTinh = @Gioi_tinh,
			diaChi = @Dia_chi,
			queQuan = @Que_quan,
			sdt = @sdt,
			cccd = @CCCD,
			ngayDatPhong = @Ngay_dat_phong,
			ngayTraPhong = @Ngay_tra_phong
		WHERE maKH = @Ma_KH
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.KhachHang
		WHERE maKH = @Ma_KH
	END
END
go


--Procedure CRUD Phong
CREATE PROCEDURE dbo.Phong_CRUD
	@StatementType VARCHAR(10),
	@Ma_phong INT = NULL,
	@Loai_phong NVARCHAR(50) = NULL,
	@So_nguoi INT = NULL,
	@Gia_phong int = NULL,
	@Trang_thai BIT = NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Phong
		WHERE maPhong = @Ma_phong
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Phong (loaiPhong, soNguoi, giaPhong, trangThai)
		VALUES (@Loai_phong, @So_nguoi, @Gia_phong, @Trang_thai)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Phong
		SET loaiPhong = @Loai_phong,
			soNguoi = @So_nguoi,
			giaPhong = @Gia_phong,
			trangThai = @Trang_thai
		WHERE maPhong = @Ma_phong
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Phong
		WHERE maPhong = @Ma_phong
	END
END

--Procedure CRUD DichVu
go
CREATE PROCEDURE dbo.DichVu_CRUD
	@StatementType VARCHAR(10),
	@Ma_dich_vu INT = NULL,
	@Ten_dich_vu NVARCHAR(50) = NULL,
	@Gia_dich_vu INT = NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.DichVu
		WHERE maDichVu = @Ma_dich_vu
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.DichVu (tenDichVu, giaDichVu)
		VALUES (@Ten_dich_vu, @Gia_dich_vu)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.DichVu
		SET tenDichVu = @Ten_dich_vu,
			giaDichVu = @Gia_dich_vu
		WHERE maDichVu = @Ma_dich_vu
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.DichVu
		WHERE maDichVu = @Ma_dich_vu
	END
END
go


--Procedure CRUD ChiTietDichVu
CREATE PROCEDURE dbo.ChiTietDichVu_CRUD
	@StatementType VARCHAR(10),
	@Ma_dich_vu INT = NULL,
	@Ma_phong INT = NULL,
	@Thanh_tien INT = NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.ChiTietDichVu
		WHERE maDichVu = @Ma_dich_vu AND maPhong = @Ma_phong
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.ChiTietDichVu (maDichVu, maPhong, thanhTien)
		VALUES (@Ma_dich_vu, @Ma_phong, @Thanh_tien)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.ChiTietDichVu
		SET thanhTien = @Thanh_tien
		WHERE maDichVu = @Ma_dich_vu AND maPhong = @Ma_phong
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.ChiTietDichVu
		WHERE maDichVu = @Ma_dich_vu AND maPhong = @Ma_phong
	END
END
go

--Procedure CRUD HoaDon
CREATE PROCEDURE dbo.HoaDon_CRUD
	@StatementType VARCHAR(10),
	@Ma_hoa_don INT = NULL,
	@Tong_tien INT = NULL,
	@Ngay_lap DATE = NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.HoaDon
		WHERE maHoaDon = @Ma_hoa_don
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.HoaDon (tongTien, ngayLap)
		VALUES (@Tong_tien, ISNULL(@Ngay_lap, GETDATE()))
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.HoaDon
		SET tongTien = @Tong_tien,
			ngayLap = @Ngay_lap
		WHERE maHoaDon = @Ma_hoa_don
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.HoaDon
		WHERE maHoaDon = @Ma_hoa_don
	END
END
go


--Procedure CRUD ChiTietHoaDon
CREATE PROCEDURE dbo.ChiTietHoaDon_CRUD
	@StatementType VARCHAR(10),
	@Ma_hoa_don INT = NULL,
	@Ma_phong INT = NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.ChiTietHoaDon
		WHERE maHoaDon = @Ma_hoa_don AND maPhong = @Ma_phong
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.ChiTietHoaDon (maHoaDon, maPhong)
		VALUES (@Ma_hoa_don, @Ma_phong)
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.ChiTietHoaDon
		WHERE maHoaDon = @Ma_hoa_don AND maPhong = @Ma_phong
	END
END
insert into KhachHang values (null, 1, null, 1, null, null, null, null, GETDATE(), GETDATE());
select * from KhachHang
delete from KhachHang