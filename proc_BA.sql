alter PROC addThings 
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
ALTER PROCEDURE addHoaDon 
    @mahoadon NVARCHAR(25) = NULL,  -- Có thể nhận giá trị NULL
    @manhanvien NVARCHAR(10), 
    @maphutung NVARCHAR(10), 
    @masuachua NVARCHAR(10), 
    @ngayin DATETIME, 
    @giaiphap NVARCHAR(100), 
    @soluong INT, 
    @tongtien MONEY,
    @makhachhang NVARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;  -- Bắt đầu transaction

    DECLARE @lasthoadon NVARCHAR(25), 
            @numberPart INT, 
            @maHD NVARCHAR(25),
            @maxe NVARCHAR(10),
			@sodienthoai nvarchar(10)

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
	set @sodienthoai = (select SoDienThoai from KHACHHANG where MaKhachHang = @makhachhang)
    INSERT INTO HOADON(MaHoaDon, MaNhanVien, MaPhuTung, MaKhachHang, NgayIn, GiaiPhap, SoLuong, TongTien)
    VALUES (@maHD, @manhanvien, @maphutung, @sodienthoai, @ngayin, @giaiphap, @soluong, @tongtien);

    -- Xóa bản ghi trong bảng YEUCAUSUACHUA
    SET @maxe = (SELECT MaXe FROM YEUCAUSUACHUA WHERE MaSuaChua = @masuachua);
    DELETE FROM YEUCAUSUACHUA WHERE MaSuaChua = @masuachua;
    DELETE FROM XEMAY WHERE MaXe = @maxe;

    -- Kiểm tra xem khách hàng có còn yêu cầu sửa chữa nào không
    IF NOT EXISTS (SELECT 1 FROM YEUCAUSUACHUA WHERE MaKhachHang = @makhachhang)
    BEGIN
        -- Nếu khách hàng không còn yêu cầu sửa chữa nào, xóa khách hàng
        DELETE FROM KHACHHANG WHERE MaKhachHang = @makhachhang;
    END

    -- Kiểm tra lỗi và thực hiện commit hoặc rollback
    IF @@ERROR = 0
    BEGIN
        COMMIT TRANSACTION;  -- Nếu không có lỗi, commit transaction
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;  -- Nếu có lỗi, rollback transaction
    END
END;
