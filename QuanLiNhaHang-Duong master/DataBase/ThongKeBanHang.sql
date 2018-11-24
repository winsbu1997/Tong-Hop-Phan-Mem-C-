USE quanlibanhang
SELECT *FROM dbo.HoaDonBan WHERE NgayBan BETWEEN '2018-4-20' AND '2018-4-30'

CREATE FUNCTION TKSoMon(@fromDay Datetime,@toDay DateTime) RETURNS INT
AS 
BEGIN
	DECLARE @tong INT 
	SET @tong = (SELECT SUM(soluong) AS SoLuong FROM dbo.ChiTietHDB,dbo.HoaDonBan 
	WHERE ChiTietHDB.MaHDB = HoaDonBan.MaHDB AND NgayBan BETWEEN @fromDay AND @toDay)
	RETURN @tong
END
GO

SELECT s = dbo.TKSoMon('2018-4-20','2018-4-30')

CREATE PROCEDURE TKMonAn(@fromDay Datetime,@toDay DateTime)
AS
BEGIN  
	SELECT ma.STTMA,DonViTinh,SUM(ct.ThanhTien) AS ThanhTien,SUM(SoLuong) AS SoLuong FROM 
	(	
		SELECT SoLuong,STTMA,ThanhTien FROM dbo.HoaDonBan AS hd,dbo.ChiTietHDB AS ct 
		WHERE ct.MaHDB = hd.MaHDB AND NgayBan BETWEEN @fromDay AND @toDay  
	)	
	AS ct, dbo.MonAn AS ma
	WHERE ct.STTMA = ma.STTMA
    GROUP BY ma.STTMA,ma.DonViTinh
END 
Go

CREATE PROCEDURE TKChiTietBan(@MaHDB CHAR(10))
AS
BEGIN
    SELECT TenMA,SoLuong,ThanhTien,DonViTinh FROM dbo.ChiTietHDB AS ct,dbo.MonAn AS ma 
	WHERE MaHDB = @MaHDB AND ct.STTMA = ma.STTMA
END
Go

EXECUTE TKChiTietBan 'HDB002'

EXECUTE TKMonAn '2018-4-20','2018-4-30'
/*---------- Sum Tong Tien -----------------------*/
CREATE FUNCTION SumTongTien(@fromDay DateTime , @toDay DateTime)
RETURNS int
AS
	BEGIN
		DECLARE @sum INT
        
		SELECT @sum =  SUM(TongTien) FROM dbo.HoaDonBan WHERE NgayBan BETWEEN @fromDay AND @toDay 

	RETURN @sum
END
GO

/*-----------  Tong Giam Gia ---------------------*/
CREATE FUNCTION SumGiamGia(@fromDay DateTime , @toDay DateTime)
RETURNS INT
AS
	BEGIN
		DECLARE @sum INT
        
		SELECT @sum =  SUM(GiamGia*TongTien/100) FROM dbo.HoaDonBan WHERE NgayBan BETWEEN @fromDay AND @toDay 

	RETURN @sum
END
GO

/*---------- In hoa don -------------------*/

CREATE PROCEDURE InHoaDon(@MaHDB CHAR(10))
AS
BEGIN
	SELECT TenMA AS STTMA,SoLuong,ThanhTien FROM dbo.ChiTietHDB AS ct,dbo.MonAn ma 
	WHERE ct.MaHDB = @MaHDB AND ct.STTMA = ma.STTMA
END


