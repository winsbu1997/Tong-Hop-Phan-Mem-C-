USE quanlibanhang
GO
		Create function fcgetIdNhanVien()
		returns char(10)

		As
		Begin
			Declare @MaNV char(10)
			Declare @MaxMaNV char(10)
			Declare @Max int
			
			
			Select @MaxMaNV = MAX(MaNV) from NhanVien
			
			if exists (select @MaNV from NhanVien)
						set @Max = CONVERT(int, SUBSTRING(@MaxMaNV,3,5)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaNV='NV' + '00' + Convert(char(1),@Max)
			else
			if (@Max < 100)
						set @MaNV='NV' + '0' + Convert(char(2),@Max)
			else
						set @MaNV ='NV' +  Convert(char(3),@Max)
			Return @MaNV
	End
	GO

		Create function fcgetIdKhachHang()
		returns char(10)

		As
		Begin
			Declare @MaKH char(10)
			Declare @MaxMaKH char(10)
			Declare @Max int

			Select @MaxMaKH = MAX(MaKH) from dbo.KhachHang
		
			if exists (select @MaKH from dbo.KhachHang)
						set @Max = CONVERT(int, SUBSTRING(@MaxMaKH,3,5)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaKH='KH'+'00'+Convert(char(1),@Max)
			else
			if (@Max < 100)
						set @MaKH='KH' +'0'+ Convert(char(2),@Max)
			else
						set @MaKH ='KH' +  Convert(char(3),@Max)
			Return @MaKH
	End
	GO

	Create function fcgetIdHoaDonBan()
		returns char(10)

		As
		Begin
			Declare @MaHDB char(10)
			Declare @MaxMaHDB char(10)
			Declare @Max int

			Select @MaxMaHDB = MAX(MaHDB) from dbo.HoaDonBan
		
			if exists (select @MaHDB from dbo.HoaDonBan)
						set @Max = CONVERT(int, SUBSTRING(@MaxMaHDB,4,6)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaHDB='HDB'+'00'+Convert(char(1),@Max)
			else
			if (@Max < 100)
						set @MaHDB='HDB' +'0'+ Convert(char(2),@Max)
			else
						set @MaHDB ='HDB' +  Convert(char(3),@Max)
			Return @MaHDB
	End
	GO

	Create function fcgetHoaDonNhap()
		returns char(10)

		As
		Begin
			Declare @MaHDN char(10)
			Declare @MaxMaHDN char(10)
			Declare @Max int

			Select @MaxMaHDN = MAX(MaHDN) from dbo.HoaDonNhap
		
			if exists (SELECT @MaHDN from dbo.HoaDonNhap)
						set @Max = CONVERT(int, SUBSTRING(@MaxMaHDN,4,6)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaHDN='HDN'+'00'+Convert(char(1),@Max)
			else
			if (@Max < 100)
						set @MaHDN='HDN' +'0'+ Convert(char(2),@Max)
			else
						set @MaHDN ='HDN' +  Convert(char(3),@Max)
			Return @MaHDN
	End
	GO

	Create function fcgetIdBanAn()
		returns char(10)

		As
		Begin
			Declare @MaBA char(10)
			Declare @MaxMaBA char(10)
			Declare @Max int

			Select @MaxMaBA = MAX(MaBA) from dbo.BanAn
		
			if exists (select @MaBA from dbo.BanAn)
						set @Max = CONVERT(int, SUBSTRING(@MaxMaBA,3,5)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaBA= 'BA' +'00'+Convert(char(1),@Max)
			else
			if (@Max < 100)
						set @MaBA= 'BA' +'0'+ Convert(char(2),@Max)
			else
						set @MaBA ='BA' + CONVERT(char(3),@Max)
			Return @MaBA
	End
	GO
	
	Create function fcgetIdNguyenLieu()
		returns char(10)

		As
		Begin
			Declare @MaNL char(10)
			Declare @MaxMaNL char(10)
			Declare @Max int

			Select @MaxMaNL = MAX(MaNL) from dbo.NguyenLieu
		
			if exists (select @MaNL from dbo.NguyenLieu)
						set @Max = CONVERT(int, SUBSTRING(@MaxMaNL,3,5)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaNL='NL'+'00'+Convert(char(1),@Max)
			else
			if (@Max < 100)
						set @MaNL='NL' +'0'+ Convert(char(2),@Max)
			else
						set @MaNL ='NL' +  Convert(char(3),@Max)
			Return @MaNL
	End
	GO

	Create function fcgetIdMonAn()
		returns char(10)

		As
		Begin
			Declare @STTMA char(10)
			Declare @MaxSTTMA char(10)
			Declare @Max int

			Select @MaxSTTMA = MAX(STTMA) from dbo.MonAn
		
			if exists (select @STTMA from dbo.MonAn)
						set @Max = CONVERT(int, SUBSTRING(@MaxSTTMA,3,5)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @STTMA='MA'+'00'+Convert(char(1),@Max)
			else
			if (@Max < 100)
						set @STTMA='MA' +'0'+ Convert(char(2),@Max)
			else
						set @STTMA ='MA' +  Convert(char(3),@Max)
			Return @STTMA
	End
	GO
	
	Create function fcgetIdNhomMon()
		returns char(10)

		As
		Begin
			Declare @MaNM char(10)
			Declare @MaxMaNM char(10)
			Declare @Max int

			Select @MaxMaNM = MAX(MaNM) from dbo.NhomMon
		
			if exists (select @MaNM from dbo.NhomMon)
						set @Max = CONVERT(int, SUBSTRING(@MaxMaNM,3,5)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaNM='NM'+'00'+Convert(char(1),@Max)
			else
			if (@Max < 100)
						set @MaNM='NM' +'0'+ Convert(char(2),@Max)
			else
						set @MaNM ='NM' +  Convert(char(3),@Max)
			Return @MaNM
	End
	GO

	CREATE FUNCTION checkHDBInBanAn(@MaHDB CHAR(10))
	RETURNS INT
	AS
    BEGIN
	Declare @flag INT

		IF EXISTS (SELECT MaHDB FROM dbo.BanAn WHERE MaHDB = @MaHDB) SET @flag = 1
		ELSE SET @flag = 0
		RETURN @flag
    END
		
 DROP FUNCTION dbo.checkIDBanAn
 PRINT dbo.checkHDBInBanAn('HDB003')
 SELECT DISTINCT MaHDB FROM dbo.BanAn
	
	
	
   
   