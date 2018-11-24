create proc ThemNhanVien(@manv char(10),@hoten nvarchar(50),@ngaysinh date, @gioitinh nvarchar(10),@socmnd int,@sdt char(15),@macv char(10),@mapb char(10),@mahd char(10))
as
begin

insert into NhanVien(MaNV,HoTen,NgaySinh,GioiTinh,SoCMND,SDT,MaCV,MaPB,MaHD) values (@manv,@hoten,@ngaysinh,@gioitinh,@socmnd,@sdt,@macv,@mapb,@mahd)
end

go

create proc SuaNhanVien(@manv char(10),@hoten nvarchar(50),@ngaysinh date, @gioitinh nvarchar(10),@socmnd int,@sdt char(15),@macv char(10),@mapb char(10),@mahd char(10))
as
begin
update NhanVien set HoTen=@hoten , NgaySinh=@ngaysinh,GioiTinh=@gioitinh,SoCMND=@socmnd,SDT=@sdt,MaCV=@macv,MaPB=@mapb,MaHD=@mahd
       where MaNV=@manv
	   end
go

create proc XoaNhanVien(@manv char(10))
 as
 begin
Delete NhanVien
where MaNV=@manv
 end 



 select HoTen,NgaySinh,GioiTinh,SoCMND,NhanVien.SDT,TenCV,TenPB,TenHD  from NhanVien,PhongBan,ChucVu,HopDong where NhanVien.MaCV=ChucVu.MaCV and  NhanVien.MaPB=PhongBan.MaPB and NhanVien.MaHD=HopDong.MaHD


 