 create proc ThemCTT
	@map nchar(4)
	,@makh nchar(4)
	,@nt datetime
	,@ndk datetime
	,@ntr datetime
as
	INSERT INTO ChiTietThuePhong(MaP, MaKH, NgayThue, NgayTraDuKien,NgayTra)
		VALUES (@map ,@makh, @nt, @ndk ,@ntr)
