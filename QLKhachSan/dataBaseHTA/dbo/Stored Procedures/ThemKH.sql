CREATE proc ThemKH
			@ma nchar(4)
			,@ho nvarchar(30)
			,@ten nvarchar(20)
			,@ngaysinh nchar(30)
			,@cmnd nchar(12)
			,@dc nvarchar(150)
			,@sdt nchar(15)
			
as
	INSERT INTO DSKhachHang(MaKH ,Ho, Ten,NgaySinh,CMND ,DiaChi,SDT)	 
		values(@ma, @ho, @ten,@ngaysinh,@cmnd ,@dc,@sdt)
