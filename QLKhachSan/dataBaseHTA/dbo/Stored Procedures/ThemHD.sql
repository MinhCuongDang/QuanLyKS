create proc ThemHD
	@mh nchar(8)
	,@mk nchar(4)
	,@nx datetime
	,@tt int
	,@mv nchar(8)
as
	insert into HoaDon(MaHD, MaKH, NgayXuat,ThanhTien, MaNV)
		values (@mh, @mk, @nx, @tt, @mv)
