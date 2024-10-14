CREATE PROC addThings 
    @tenkhachhang NVARCHAR(25), 
    @bienso NVARCHAR(10),
    @tennguyennhan NVARCHAR(25), 
    @ngaysua DATE, 
    @diachi NVARCHAR(25), 
    @sodienthoai NVARCHAR(25)
AS
BEGIN
    DECLARE @maKH NVARCHAR(25), @masuachua NVARCHAR(25), @maxe NVARCHAR(25),@lastkhachhang nvarchar(25),@lastmaxe nvarchar(25),@lastyeucau nvarchar(25),@numberPart INT;

    IF EXISTS (SELECT 1 FROM XEMAY WHERE BienSo = @bienso)
    BEGIN
        RETURN;
    END
    ELSE
    BEGIN
		SELECT @lastmaxe = (select top 1 MaXe
		FROM XEMAY
		ORDER BY MaXe DESC)

		SELECT @numberPart = CAST(SUBSTRING(@lastmaxe, 3, LEN(@lastmaxe) - 2) AS INT);

		SET @numberPart = @numberPart + 1;

        SET @maxe = 'MX' + RIGHT('000' + CAST(@numberPart AS NVARCHAR), 3);
        INSERT INTO XEMAY(MaXe, BienSo) 
        VALUES (@maxe, @bienso);

        IF EXISTS (SELECT 1 FROM KHACHHANG WHERE SoDienThoai = @sodienthoai)
        BEGIN
            SELECT @maKH = MaKhachHang FROM KHACHHANG WHERE SoDienThoai = @sodienthoai;
        END
        ELSE
        BEGIN
			SELECT @lastkhachhang = (select top 1 MaKhachHang 
			FROM KHACHHANG
			ORDER BY MaKhachHang DESC)

			SELECT @numberPart = CAST(SUBSTRING(@lastkhachhang, 3, LEN(@lastkhachhang) - 2) AS INT);

			SET @numberPart = @numberPart + 1;

           SET @maKH = 'MK' + RIGHT('000' + CAST(@numberPart AS NVARCHAR), 3);
            INSERT INTO KHACHHANG(MaKhachHang, TenKhachHang, DiaChi, SoDienThoai) 
            VALUES (@maKH, @tenkhachhang, @diachi, @sodienthoai);
        END;

		SELECT @lastyeucau = (select top 1 MaSuaChua
		FROM YEUCAUSUACHUA
		ORDER BY MaSuaChua DESC)
		SELECT @numberPart = CAST(SUBSTRING(@lastyeucau, 4, LEN(@lastyeucau) - 3) AS INT);

		SET @numberPart = @numberPart + 1;
		


       SET @masuachua = 'MSC' + RIGHT('000' + CAST(@numberPart AS NVARCHAR), 3)

        INSERT INTO YEUCAUSUACHUA(MaSuaChua, MaXe, MaKhachHang, NgaySua, NguyenNhan)
        VALUES (@masuachua, @maxe, @maKH, @ngaysua, @tennguyennhan);
    END;
END;



-- HOA DON

create PROC addHoaDon 
    @mahoadon NVARCHAR(25) = NULL,  -- Có thể nhận giá trị NULL
    @manhanvien NVARCHAR(10), 
    @maphutung NVARCHAR(10), 
    @masuachua NVARCHAR(10), 
    @ngayin DATETIME, 
    @giaiphap NVARCHAR(100), 
    @soluong INT, 
    @tongtien MONEY
AS
BEGIN
    DECLARE @lasthoadon NVARCHAR(25), 
            @numberPart INT, 
            @maHD NVARCHAR(25);

    -- Nếu @mahoadon là NULL, tạo mã mới
    IF @mahoadon IS NULL
    BEGIN
        -- Kiểm tra mã hóa đơn cuối cùng trong bảng
        SELECT @lasthoadon = (SELECT TOP 1 MaHoaDon 
                              FROM HOADON
                              ORDER BY MaHoaDon DESC);

        -- Nếu chưa có hóa đơn nào, tạo mã 'HD001'
        IF @lasthoadon IS NULL
        BEGIN
            SET @maHD = 'HD001';
        END
        ELSE
        BEGIN
            -- Lấy phần số từ mã hóa đơn cuối cùng
            SELECT @numberPart = CAST(SUBSTRING(@lasthoadon, 3, LEN(@lasthoadon) - 2) AS INT);

            -- Tăng giá trị của phần số
            SET @numberPart = @numberPart + 1;

            -- Tạo mã hóa đơn mới
            SET @maHD = 'HD' + RIGHT('000' + CAST(@numberPart AS NVARCHAR), 3);
        END
    END
    ELSE
    BEGIN
        -- Nếu @mahoadon không NULL, sử dụng giá trị được truyền vào
        SET @maHD = @mahoadon;
    END

    -- Thêm dữ liệu vào bảng HOADON
    INSERT INTO HOADON(MaHoaDon, MaNhanVien, MaPhuTung, MaSuaChua, NgayIn, GiaiPhap, SoLuong, TongTien)
    VALUES (@maHD, @manhanvien, @maphutung, @masuachua, @ngayin, @giaiphap, @soluong, @tongtien);
END