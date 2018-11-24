create proc ThemLuong(@bac nchar (10),@luongcb float, @luongtangca float )
as 
	begin
	
		if exists (select BacLuong from HeSoLuong where BacLuong = @bac)
			begin
				print N'Mã GV đã tồn tại'
			end
	else 
	begin
		
 insert into HeSoLuong(BacLuong,LuongCB,LuongTangCa) values (@bac,@luongcb,@luongtangca)
 end
 end
 go
 create proc SuaLuong (@bac nchar (10),@luongcb float, @luongtangca float)
 as
 begin
 update HeSoLuong set LuongCB=@luongcb,LuongTangCa=@luongtangca where BacLuong =@bac
 end
 go 
  create proc XoaLuong (@bac nchar(10))
 as
 begin
 Delete HeSoLuong where BacLuong=@bac
 end
 go




 create proc ThemHopDong(@ma char (10),@ten nvarchar(50), @loai nvarchar(50),@ngaybatdau date,@ngayketthuc date, @bac nchar (10) )
as 
	begin
	
		if exists (select MaHD from HopDong where MaHD = @ma)
			begin
				print N'Mã GV đã tồn tại'
			end
	else 
	begin
		
 insert into HopDong values (@ma,@ten,@loai,@ngaybatdau,@ngayketthuc,@bac)
 end
 end
 go
 create proc SuaHopDong (@ma char (10),@ten nvarchar(50), @loai nvarchar(50),@ngaybatdau date,@ngayketthuc date, @bac nchar (10))
 as
 begin
 update HopDong set TenHD=@ten,LoaiHD=@loai,NgayBatDau=@ngaybatdau,NgayKetThuc=@ngayketthuc,BacLuong=@bac where MaHD =@ma
 end
 go 
  create proc XoaHopDong (@ma char(10))
 as
 begin
 Delete HopDong where MaHD=@ma
 end




