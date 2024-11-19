CREATE FUNCTION LoaiBoDauTiengViet (@chuoiCoDau NVARCHAR(500))
RETURNS NVARCHAR(500)
AS
BEGIN
    -- Khai báo biến lưu chuỗi không dấu
    DECLARE @chuoiKhongDau NVARCHAR(500) = LOWER(@chuoiCoDau);

    -- Khai báo biến lặp (i) và độ dài chuỗi có dấu (doDai)
    DECLARE @i INT = 1;
    DECLARE @doDai INT;

    -- Khai báo biến chứa bảng chữ cái có dấu và không dấu tương ứng
    DECLARE @kyTuCoDau NVARCHAR(50) = N'àáảãạăắằẳẵặâấầẩẫậèéẻẽẹêếềểễệìíỉĩịòóỏõọôồốổỗộơờớởỡợùúủũụưừứửữựỳýỷỹỵđ';
    DECLARE @kyTuKhongDau NVARCHAR(50) = N'aaaaaaaaaaaaaaaaaeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuyyyyyd';

    -- Lấy độ dài chuỗi có dấu
    SET @doDai = LEN(@kyTuCoDau);

    -- Lặp qua từng ký tự trong chuỗi có dấu
    WHILE @i <= @doDai
    BEGIN
        -- Thay thế ký tự có dấu bằng ký tự không dấu tương ứng
        SET @chuoiKhongDau = REPLACE(
                                @chuoiKhongDau,                  -- Chuỗi cần thay thế
                                SUBSTRING(@kyTuCoDau, @i, 1),    -- Ký tự cần thay thế (có dấu)
                                SUBSTRING(@kyTuKhongDau, @i, 1)  -- Ký tự thay thế (không dấu)
                            );

        -- Tăng biến lặp
        SET @i = @i + 1;
    END

    -- Trả về chuỗi không dấu
    RETURN @chuoiKhongDau;
END;
