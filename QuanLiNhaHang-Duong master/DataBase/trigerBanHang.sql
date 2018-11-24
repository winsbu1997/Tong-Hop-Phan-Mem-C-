CREATE TRIGGER XoaHoaDonBan ON dbo.HoaDonBan INSTEAD OF 
DELETE
AS
	DECLARE @MaHDB CHAR(10)
BEGIN
	SELECT @MaHDB = MaHDB from Deleted
	DELETE dbo.ChiTietHDB WHERE MaHDB = @MaHDB 
	DELETE dbo.HoaDonBan WHERE MaHDB = @MaHDB
END