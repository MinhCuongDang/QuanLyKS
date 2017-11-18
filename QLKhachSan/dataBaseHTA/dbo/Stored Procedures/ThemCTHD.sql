CREATE proc [dbo].[ThemCTHD]
	@m nchar(8)
	,@ms nchar(5)
	,@sl int
	,@dg int
	,@tt int
as	
		insert into CTHoaDon(MaHD, MaSP,SoLuong,DonGia, ThanhTien)
			values( @m, @ms, @sl, @dg, @tt)
