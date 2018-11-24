use quanlibanhang
Go
--  drop procedure spInsertDangNhap

					/*-- BANG DANG NHAP -- */
					
/*-------------- Insert DangNhap -------------------------*/
SELECT * FROM dbo.DangNhap
alter procedure InsertDangNhap
(
		@IdDangNhap varchar(100),
		@MatKhau varchar(200),
		@quequan nvarchar(50)
)
as
Begin
		insert into DangNhap(IdDangNhap, MatKhau, quequan)
		values(@IdDangNhap, @MatKhau, @quequan)
END
go

/*------------- Doi mat khau DangNhap ----------------*/

alter procedure UpdateDangNhap_MatKhau
(
		@IdDangNhap	varchar(100),
		@MatKhau varchar(250)				
)
as
Begin
		   update DangNhap set MatKhau=@MatKhau
		   where IdDangNhap = @IdDangNhap
End
go
/*---------------- Xoa DangNhap -------------------------*/

create procedure DeleteDangNhapByIdDangNhap
(
		 @IdDangNhap	varchar(100)							
)
as
Begin
		 delete from DangNhap 
		 where IdDangNhap =@IdDangNhap
End

go
/*------------------ Kiem tra DangNhap -----------------------*/
create procedure CheckDangNhap
(
		@IdDangNhap		varchar(100),
		@MatKhau		nvarchar(200)
)
as
Begin
		select	* from DangNhap dn
		where	dn.idDangNhap= @IdDangNhap and dn.MatKhau=@MatKhau				
End
Go
							/*-- BANG NHAN VIEN -- */
/*------------- Hien thi thong tin NhanVien -------------------*/

create procedure getNhanVien
as
begin
	select *from NhanVien
end
go

/*----------- Hien thi thong tin NhanVien bang MaNhanVien --------------*/
create procedure GetNhanVienByMaNV
(
	@MaNV char(10)
)
as 
begin 
	select *from NhanVien where MaNV = @MaNV
end
go

/*-------------- Insert Nhan Vien -----------------------------*/
	
create procedure InsertNhanVien
(
	@MaNV char(10),
	@TenNV Nvarchar(100),
	@NgaySinh Date,
	@GioiTinh char(3) ,
	@DiaChi Nvarchar(100),
	@Sdt char(10) ,
	@Luong int ,
	@ChucVu nvarchar(100) 
)
as
begin
	insert NhanVien
	values(@MaNV, @TenNV, @NgaySinh, @GioiTinh, @DiaChi, @Sdt, @Luong, @ChucVu)
end
GO


/*------------------- Update Nhan Vien -----------------------*/

create procedure UpdateNhanVien
(
	@MaNV char(10),
	@TenNV Nvarchar(100),
	@NgaySinh Date,
	@GioiTinh char(3) ,
	@DiaChi Nvarchar(100),
	@Sdt char(10) ,
	@Luong int ,
	@ChucVu nvarchar(100) 
)
as 
begin
	update NhanVien set 
		TenNV = @TenNV ,
		NgaySinh = @NgaySinh ,
		GioiTinh = @GioiTinh  ,
		DiaChi = @DiaChi,
		Sdt = @Sdt ,
		Luong = @Luong ,
		ChucVu = @ChucVu  
	where MaNV = @MaNV
end
go

/*--------------- Delete Nhan Vien ---------------------*/

create procedure deleteNhanVien
(
	@MaNV char(10)
)
as 
begin
	delete from NhanVien where MaNV = @MaNV
end
go

/*--------------TIM KIEM NHAN VIEN THEO MANHANVIEN -----------*/

create procedure SearchNhanVienByMaNV
(
	@MaNV char(10)
)
as 
begin 
	select *from NhanVien where MaNV like '%'+@MaNV+'%'
end
go


/*--------------TIM KIEM NHAN VIEN THEO TEN -----------*/

create procedure SearchNhanVienByTenNV
(
	@TenNV Nvarchar(100)
)
as 
begin 
	select *from NhanVien where TenNV like N'%'+@TenNV+'%'
end
GO


								/*-- BANG KHACH HANG -- */
/*--------- Hien thi thong tin Khach Hang ----------------*/

create procedure getKhachHang
as
begin
	select *from KhachHang
end
go
/*----------- Hien thi thong tin Khach Hang bang MaKhachHang --------------*/

create procedure getKhachHangbyMaKH
(
	@MaKH char(10)
)
as 
begin
	select *from KhachHang where MaKH = @MaKH
end
GO
/*------------------------Search Khach hang ----------------------------------*/
create procedure SearchKhachHangByTenKH
(
	@TenKH Nvarchar(100) 
)
as 
begin 
	select *from KhachHang where TenKH like N'%'+@TenKH+'%'
end
GO

------------------------------
create procedure SearchKhachHangByMaKH
(
	@MaKH char(10)
)
as 
begin 
	select *from KhachHang where MaKH like N'%'+@MaKH+'%'
end
GO
/*---------------- Insert Khach Hang -------------------*/
create procedure InsertKhachHang
(
	@MaKH char(10),
	@TenKH Nvarchar(100) ,
	@Sdt char(10) ,
	@DiaChi Nvarchar(100)
)
as
begin
	insert into KhachHang 
	values(@MaKH , @TenKh , @Sdt , @DiaChi )
end
go
/*---------------- Update Khach Hang -----------------*/
create procedure UpdateKhachHang
(
	@MaKH char(10),
	@TenKH Nvarchar(100) ,
	@Sdt char(10) ,
	@DiaChi Nvarchar(100)
)
as 
begin
	update KhachHang set 
						TenKH = @TenKH,
						Sdt = @Sdt,
						DiaChi = @DiaChi
		where MaKH = @MaKH
end
go
/*-------------------- Delete KhachHang -------------------*/
create procedure deleteKhachHang
(
	@MaKH char(10)
)
as
begin
	delete from KhachHang where MaKH = @MaKH 
end
go

								/*-- BANG NHOM MON -- */
/*--------- Hien thi thong tin KhachHang ----------------*/
create procedure getNhomMon
as
begin
	select *from NhomMon 
end
go
/*----------- Hien thi thong tin NhomMon bang MaNhomMon --------------*/
create procedure getNhomMonbyMaNM
(
	@MaNM CHAR(10)
)
as
begin
	select *from NhomMon where MaNM = @MaNM
end
GO

/*---------------- Insert Nhom Mon -------------------*/

create procedure insertNhomMon
(
	@MaNM CHAR(10),
	@TenNM nvarchar(30) 
)
as
begin
	insert into NhomMon
	values(@MaNM,@TenNM )
end
go
/*---------------- Update Nhom Mon  -----------------*/
create procedure updateNhomMon
(
	@MaNM CHAR(10),
	@TenNM nvarchar(30)
)
as
begin
	update NhomMon set TenNM = @TenNM
		where MaNM = @MaNM
end
go
/*-------------------- Delete Nhom Mon -------------------*/
create procedure deleteNhomMon
(
	@MaNM CHAR(10)
)
as
begin
	delete from NhomMon where MaNM = @MaNM
end
go

								/*-- BANG MON AN -- */
/*--------- Hien thi thong tin Mon An ----------------*/
create procedure getMonAn
as
begin
	select *from MonAn 
end
go
/*----------- Hien thi thong tin Mon An bang MaMonAn --------------*/
create procedure getMonAnbyMaNM
(
	@MaNM CHAR(10) 
)
as
begin
	select *from MonAn where MaNM = @MaNM
end
GO


/*---------------- Insert Mon An -------------------*/
create procedure insertMonAn
(
	@STTMA CHAR(10),
	@TenMA nvarchar(30) ,
	@DonGia int ,
	@MaNM CHAR(10),
	@DonViTinh varchar(10) ,
	@HinhAnh image
)
as
begin
	insert into MonAn
	values(@STTMA,@TENMA , @DonGia ,@MaNM, @DonViTinh,@HinhAnh)
end
GO

/*---------------- Update Mon An -----------------*/
create procedure updateMonAn
(
	@STTMA CHAR(10) ,
	@TenMA nvarchar(30) ,
	@DonGia int ,
	@MaNM CHAR(10),
	@DonViTinh varchar(10), 
	@HinhAnh image
)
as
begin
	update MonAn set 
					TenMA = @TenMA  ,
					DonGia  = @DonGia  ,
					MaNM = @MaNM,
					DonViTinh  = @DonViTinh  ,
					HinhAnh =@HinhAnh
		where STTMA = @STTMA
end
GO

/*-------------------- Delete Mon An -------------------*/
create procedure deleteMonAn
(
	@STTMA CHAR(10)
)
as
begin
	delete from MonAn where STTMA = @STTMA
end
go

								/*-- BANG BAN AN -- */
/*--------- Hien thi thong tin BAN AN ----------------*/
create procedure getBanAn
as
begin
	select *from BanAn
end
go
/*----------- Hien thi thong tin BAN AN bang MaBANAN --------------*/
create procedure getBanAnbyMaBA
(
	@MaBA char(10)
)
as
begin
	select *from BanAn where MaBA = @MaBA
end
go
/*---------------- Insert BAN AN -------------------*/
create procedure insertBanAn
(
	@MaBA char(10),
	@MaHDB char(10),
	@SoCho int,
	@TrangThai nvarchar(30) ,
	@ViTri nvarchar(30) 
)
as
begin
	insert into BanAn
	values(@MaBA,@MaHDB,@SoCho,@TrangThai,@ViTri)
end
go
/*---------------- Update BAN AN -----------------*/
create procedure updateBanAn
(
	@MaBA char(10),
	@MaHDB CHAR(10) NULL,
	@SoCho int,
	@TrangThai nvarchar(30) ,
	@ViTri nvarchar(30)
)
as
begin
	update BanAn set SoCho = @SoCho ,
					 MaHDB = @MaHDB,
					 TrangThai = @TrangThai,
					 ViTri = @ViTri
			where MaBA = @MaBA
end
GO

/*-------------------- Delete BAN AN -------------------*/
create procedure deleteBanAn
(
	@MaBA char(10)
)
as
begin
	delete from BanAn where MaBA = @MaBA
end
GO
------------ sua trang thai ban an
CREATE PROCEDURE UpdateBASaukhiBan @MaHDB CHAR(10)
AS
BEGIN
	UPDATE dbo.BanAn SET TrangThai = N'Trống',
						 MaHDB = NULL
                     WHERE MaHDB = @MaHDB
END
GO



CREATE PROCEDURE updateTrangThaiBA
(
	@MaBA CHAR(10),
	@TrangThai NVARCHAR(30),
	@MaHDB CHAR(10)
)
AS
BEGIN
    UPDATE dbo.BanAn SET TrangThai = @TrangThai,
						 MaHDB = @MaHDB
						 WHERE MaBA = @MaBA
END
GO

								/*-- BANG chi tiet nhap -- */
/*--------- Hien thi thong tin chi tiet nhap ----------------*/
CREATE PROCEDURE getChiTietNhap
AS 
BEGIN 
	SELECT *FROM dbo.ChiTietHDN
end
GO

/*---------------- Insert chi tiet nhap -------------------*/
create procedure insertChiTietNhap
(
	@MaHDN char(10) ,
	@MaNL char(10) ,
	@SoLuong int,
	@DonGia int
)
as
BEGIN
	INSERT INTO dbo.ChiTietHDN
	VALUES( @MaHDN,@MaNL,@SoLuong,@DonGia)

END
GO

/*---------------- Update chi tiet nhap -----------------*/
create procedure updateChiTietNhap
(
	@MaHDN char(10) ,
	@MaNL char(10) ,
	@SoLuong INT,
	@DonGia int 
)
as
begin
	UPDATE dbo.ChiTietHDN SET SoLuong = @SoLuong, DonGia = @DonGia 
	WHERE MaHDN = @MaHDN AND MaNL = @MaNL
END
GO

/*-------------------- Delete chi tiet nhap -------------------*/
create procedure deleteChiTietNhap
(
	@MaHDN char(10) ,
	@MaNL char(10) 
)
as
BEGIN
	DELETE FROM dbo.ChiTietHDN
	WHERE MaHDN = @MaHDN AND MaNL = @MaNL
end
GO

								/*-- BANG Hoa Don Nhap -- */
/*--------- Hien thi thong tin Hoa Don Nhap ----------------*/
CREATE PROCEDURE getHDN
AS 
BEGIN
    SELECT *FROM dbo.HoaDonNhap 
END
GO
/*-----------------------------*/
CREATE PROCEDURE getHDNbyMaHDN
(
	@MaHDN CHAR(10)
)
AS 
BEGIN
    SELECT *FROM dbo.HoaDonNhap WHERE MaHDN = @MaHDN 
END
GO

/*---------------- Insert Hoa Don Nhap  -------------------*/
create procedure insertHoaDonNhap
(
	@MaHDN CHAR(10),
	@NgayNhap DATETIME,
	@TongTien int,
	@GhiChu nvarchar(100),
	@MaNV CHAR(10)
)
as
begin
	INSERT INTO HoaDonNhap 
	VALUES(@MaHDN,@NgayNhap,@TongTien,@GhiChu,@MaNV)
END
GO

/*---------------- Update Hoa Don Nhap  -----------------*/
create procedure updateHoaDonNhap
(
	@MaHDN CHAR(10),
	@NgayNhap Datetime,
	@TongTien int,
	@GhiChu nvarchar(100),
	@MaNV CHAR(10)
)
as
BEGIN
	UPDATE HoaDonNhap SET NgayNhap = @NgayNhap,
					      TongTien = @TongTien,
						  GhiChu = @GhiChu,
						  MaNV = @MaNV
					WHERE MaHDN = @MaHDN
END
GO

/*-------------------- Delete Hoa Don Nhap  -------------------*/
create procedure deleteHoaDonNhap
(
	@MaHDN CHAR(10)
)
as
BEGIN
	DELETE FROM dbo.HoaDonNhap WHERE MaHDN = @MaHDN
end
GO
/*-----------------Search hoa don nhap----------------------*/
create procedure SearchHDNByMaHDN
(
	@MaHDN char(10)
)
as 
begin 
	select *from dbo.HoaDonNhap where MaHDN = @MaHDN
end
go


								/*-- BANG Hoa Don Ban -- */
/*--------- Hien thi thong tin Hoa Don Ban ----------------*/
CREATE PROCEDURE getHDB
AS 
BEGIN
    SELECT *FROM dbo.HoaDonBan
END
GO

/*-----------------------------*/
CREATE PROCEDURE getHDBbyMaHDB
(
	@MaHDB CHAR(10)
)
AS 
BEGIN
    SELECT *FROM dbo.HoaDonBan WHERE MaHDB = @MaHDB 
END
GO


/*---------------- Insert Hoa Don Ban  -------------------*/
create procedure insertHoaDonBan
(
	@MaHDB char(10),
	@NgayBan DATETIME ,
	@TongTien int ,
	@GiamGia INT,
	@MaNV char(10),
	@MaKH char(10)
)
as
begin
	INSERT INTO dbo.HoaDonBan
	VALUES(@MaHDB,@NgayBan,@TongTien,@MaNV,@MaKH,@GiamGia)
END
GO


/*---------------- Update Hoa Don Ban  -----------------*/
create procedure updateHoaDonBan
(
	@MaHDB char(10),
	@NgayBan DATETIME ,
	@TongTien int ,
	@GiamGia INT,
	@MaNV char(10),
	@MaKH char(10)
)
as
BEGIN
	UPDATE dbo.HoaDonBan SET NgayBan = @NgayBan,
					      TongTien = @Tongtien,
						  GiamGia = @GiamGia,
						  MaNV = @MaNV,
						  MaKH = @MaKH
					WHERE MaHDB = @MaHDB
END
GO

/*-------------------- Delete Hoa Don Ban  -------------------*/
create procedure deleteHoaDonBan
(
	@MaHDB CHAR(10)
)
as
BEGIN
	DELETE FROM dbo.HoaDonBan WHERE MaHDB = @MaHDB
end
GO
/*-----------------Search Hoa Don Ban----------------------*/
create procedure SearchHDNByMaHDB
(
	@MaHDB char(10)
)
as 
begin 
	select *from dbo.HoaDonBan where MaHDB = @MaHDB
end
go

								/*-- BANG chi tiet ban -- */
/*--------- Hien thi thong tin chi tiet ban----------------*/
CREATE PROCEDURE getChiTietBan
AS BEGIN SELECT *FROM dbo.ChiTietHDB
end
GO

/*---------------- Insert chi tiet ban -------------------*/
create procedure insertChiTietBan
(
	 @MaHDB CHAR(10),
	 @STTMA CHAR(10) ,
	 @SoLuong int,
	 @ThanhTien int
)
as
BEGIN
	INSERT INTO dbo.ChiTietHDB
	VALUES( @MaHDB,@STTMA,@SoLuong,@ThanhTien)
END
GO

/*---------------- Update chi tiet ban -----------------*/
create procedure updateChiTietBan
(
	@MaHDB char(10) ,
	@STTMA char(10) ,
	@SoLuong int  ,
	@ThanhTien int
)
as
begin
	UPDATE dbo.ChiTietHDB SET SoLuong = @SoLuong , ThanhTien = @ThanhTien
	WHERE MaHDB = @MaHDB AND STTMA = @STTMA
END
GO

/*-------------------- Delete chi tiet ban -------------------*/
create procedure deleteChiTietBan
(
	@MaHDB char(10) ,
	@STTMA char(10) 
)
as
BEGIN
	DELETE FROM dbo.ChiTietHDB
	WHERE MaHDB = @MaHDB AND STTMA = @STTMA
end
GO

CREATE PROCEDURE searchChiTietBanByMaHDB
(
	@MaHDB CHAR(10)
)
AS 
BEGIN 
	SELECT *FROM dbo.ChiTietHDB WHERE MaHDB = @MaHDB
END
go

										/*------------------- Nguyen Lieu ----------------*/
										/*--------- Hien thi thong tin chi tiet ban----------------*/
CREATE PROCEDURE getNguyenLieu
AS BEGIN SELECT *FROM dbo.NguyenLieu
end
GO

/*---------------- Insert nguyen lieu -------------------*/
create procedure insertNguyenLieu
(
	 @MaNL char(10) ,
	 @TenNL  NVARCHAR(100),
	 @DonViTinh CHAR(10),
	 @DonGia int	  
)
as
BEGIN
	INSERT INTO dbo.NguyenLieu
	VALUES( @MaNL,@TenNL,@DonViTinh,@DonGia)

END
GO
/*---------------- Update nguyen lieu -----------------*/
create procedure updateNguyenLieu
(
	@MaNL char(10) ,
	@TenNL NVARCHAR(100),
	@DonViTinh CHAR(10),
	@DonGia int  
)
as
begin
	UPDATE dbo.NguyenLieu SET TenNL = @TenNL,
							  DonViTinh = @DonViTinh,
							  DonGia = @DonGia
	WHERE MaNL = @MaNL
END
GO

/*-------------------- Delete nguyen lieu -------------------*/
create procedure deleteNguyenLieu
(
	@MaNL char(10)
)
as
BEGIN
	DELETE FROM dbo.NguyenLieu
	WHERE MaNL = @MaNL
end
GO


/*----------------- Thong ke Mon An -----------------------------*/



