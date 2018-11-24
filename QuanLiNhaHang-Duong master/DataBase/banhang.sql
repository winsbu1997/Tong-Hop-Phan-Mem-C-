CREATE database quanlibanhang
go
use quanlibanhang
go
create table NhanVien
(
	MaNV char(10),
	TenNV Nvarchar(100),
	NgaySinh Date,
	GioiTinh char(3) ,
	DiaChi Nvarchar(100),
	Sdt char(10) check(Sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Luong int not null,
	ChucVu nvarchar(100) not null,
	primary key(Manv)
)
go

create table KhachHang
(
	MaKH char(10),
	TenKH Nvarchar(100) not null,
	Sdt char(10) check(Sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	DiaChi Nvarchar(100),
	primary key(MaKH)
)
GO 

create table NguyenLieu
(
	MaNL char(10),
	TenNL nvarchar(100) not null,
	DonviTinh varchar(10),
	DonGia int not null,	
	primary key(MaNL)
)
go

create table HoaDonNhap
(
	MaHDN char(10),
	NgayNhap DATETIME,
	TongTien int,
	GhiChu nvarchar(100),
	MaNV char(10) ,
	primary key(MaHDN)
)
go

create table HoaDonBan
(
	MaHDB char(10),
	NgayBan DATETIME ,
	TongTien int ,	
	MaNV char(10),
	MaKH char(10),
	GiamGia INT,
	primary key(MaHDB)
)
go

create table BanAn
(
	MaBA char(10),
	MaHDB char(10),
	SoCho int not null,
	TrangThai nvarchar(30) ,
	ViTri nvarchar(30) not null,
	
	primary key(MaBA)
)
go

Create table NhomMon
(
	MaNM CHAR(10),
	TenNM nvarchar(30) not null,
	primary key(MaNM)
)
GO

create table MonAn
(
	STTMA CHAR(10) ,
	TenMA nvarchar(30) not null,
	DonGia int not null,
	MaNM CHAR(10),
	DonViTinh varchar(10) ,
	HinhAnh IMAGE 
	primary key(STTMA)
)
GO

create table ChiTietHDB
(
	MaHDB char(10)  references dbo.HoaDonBan(MaHDB),
	STTMA CHAR(10) references dbo.MonAn(STTMA),
	SoLuong int not null,
	ThanhTien INT ,
	primary key(MaHDB,STTMA)
	
)
go

create table ChiTietHDN
(
	MaHDN char(10) references dbo.HoaDonNhap(MaHDN),
	MaNL char(10) references dbo.NguyenLieu(MaNL),
	SoLuong int not null,
	DonGia INT NOT NULL,
	primary key(MaHDN,MaNL)
	
)
go
DROP TABLE dbo.DangNhap
create table DangNhap
(
	IdDangNhap	varchar(100) primary key,
	MatKhau			nvarchar(200),
	TrangThai		BIT DEFAULT 0
)

SELECT * FROM dbo.DangNhap
ALTER TABLE dbo.DangNhap DROP COLUMN TrangThai

insert into DangNhap values('admin','123',1)

insert into DangNhap values('duong2','123',0)

ALTER TABLE dbo.DangNhap DROP PK__DangNhap__D818CE178B8B1AF5

--alter table HoaDonBan add MaKH int

alter table dbo.BanAn
add constraint frBA
foreign key(MaHDB)
references dbo.HoaDonBan;

alter table dbo.HoaDonNhap
add constraint fr_hdn
foreign key(MaNV)
references dbo.NhanVien;

alter table dbo.HoaDonBan
add constraint fr_hdb1
foreign key(MaNV)
references dbo.NhanVien;

alter table dbo.HoaDonBan
add constraint fr_hdb2
foreign key(MaKH)
references dbo.KhachHang;

alter table dbo.MonAn
add constraint fr_ma
foreign key(MaNM)
references dbo.NhomMon;

Insert KhachHang 
Values('KH001',N'Lê Văn Đạt','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH002',N'Tăng Đại Dương','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH003',N'Hoàng Quốc Trọng','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH004',N'Nguyễn Quý Thắng','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH005',N'Đậu Thị Kim Dung','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH006',N'Vũ Ngoc Sơn','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH007',N'Trần Đình Oánh','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH008',N'Nguyễn Thị Hồng Nhung','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH009',N'Đinh Thị Phương','0912367832',N'Ninh Bình')
Insert KhachHang 
Values('KH010',N'Nguyễn Anh Việt','0912367832',N'Ninh Bình')


Insert NhanVien
Values('NV001',N'Nguyễn Thị Hà','1996-5-3','Nam',N'','0912365418','3000000',N'Phục Vụ')
Insert NhanVien
Values('NV002',N'Trần Minh Quang','1996-7-1','Nu',N'','0912365418','3000000',N'Ông chủ')
Insert NhanVien
Values('NV003',N'Nguyễn Phú Lập','1996-9-2','Nam',N'','0912365418','3000000',N'Phục Vụ')
Insert NhanVien
Values('NV004',N'Trần Văn Thắng','1996-4-8','Nu',N'','0912365418','3000000',N'Thu Ngân')
Insert NhanVien
Values('NV005',N'Trần Văn Đạt','1996-9-3','Nam',N'','0912365418','3000000',N'Phục Vụ')

Insert NhomMon
Values('NM001','Món Khai Vị')
Insert NhomMon
Values('NM002','Món Chính')
Insert NhomMon
Values('NM003','Món Tráng Miệng')

Insert NguyenLieu
Values('NL001',N'Gạo','Kg',20000)
Insert NguyenLieu
Values('NL002',N'Thịt gà','Kg',10000)
Insert NguyenLieu
Values('NL003',N'Tôm','kg',30000)

Insert HoaDonNhap
Values('HDN001',GetDate(),null,null,'NV002')
Insert HoaDonNhap
Values('HDN002',GetDate(),null,null,'NV003')
Insert HoaDonNhap
Values('HDN003',GetDate(),null,null,'NV001')

Insert into ChiTietHDN
values('HDN001','NL003',20,30000),
('HDN003','NL002',30,10000)

Insert HoaDonBan
Values('HDB001',GetDate(),null,'NV002','KH001',null)
Insert HoaDonBan
Values('HDB002',GetDate(),null,'NV001','KH002',null)
Insert HoaDonBan
Values('HDB003',GetDate(),null,'NV001','KH003',null)

Insert MonAn
Values('MA001',N'Sườn xào chua ngọt',30000,'NM002','VND',null)
Insert MonAn
Values('MA002',N'Trứng + Salad',10000,'NM001','VND',null)
Insert MonAn
Values('MA003',N'Kem',3000,'NM003','VND',null)

Insert BanAn
values('BA001','HDB003',6,N'Có',N'Tầng 1')
Insert BanAn
values('BA002','HDB002',6,N'Trống',N'Tầng 2')
Insert BanAn
values('BA003','HDB001',6,N'Có',N'Tầng 1')




Insert ChiTietHDB
values('HDB002','MA001',3,null)
Insert ChiTietHDB
values('HDB001','MA002',1,null)
Insert ChiTietHDB
values('HDB003','MA002',3,null)



