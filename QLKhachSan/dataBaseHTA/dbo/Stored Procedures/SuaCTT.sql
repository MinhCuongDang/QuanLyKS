CREATE proc SuaCTT	
		@makh nchar(4)
		--,@ndk datetime
		--,@ntr datetime
		,@nt datetime
as	
		update ChiTietThuePhong set NgayThue =@nt --, NgayTraDuKien =@ndk, NgayTra =@ntr
					where MaKH =@makh
