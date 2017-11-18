create proc ThemNV
	@ma nchar(8)
	,@ho nvarchar(30)
	,@ten nvarchar(20)
	,@ngaysinh date
	,@gt nchar(4)
	,@cmnd nchar(12)
	,@sdt nchar(11)
	,@dc nvarchar(150)
	,@bc nvarchar(20)
	
as
	INSERT INTO NhanVien (MaNV, Ho, Ten, NgaySinh, GioiTinh, CMND, SDT, DiaChi, BangCap)
		values(@ma, @ho, @ten, @ngaysinh, @gt, @cmnd ,@sdt ,@dc ,@bc)
