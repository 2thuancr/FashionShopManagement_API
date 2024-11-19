/*
    Tên hàm: RemoveDiacritics
    Mô tả: Hàm xóa dấu tiếng Việt, chuyển chuỗi có dấu thành chuỗi không dấu
    Tham số:
        - @input: Chuỗi cần xóa dấu (NVARCHAR(500))
    Kết quả: Chuỗi không dấu
*/

CREATE FUNCTION RemoveDiacritics (@input NVARCHAR(500))
RETURNS NVARCHAR(500)
AS
BEGIN
    -- Khai báo biến lưu chuỗi không dấu
    DECLARE @output NVARCHAR(500) = LOWER(@input);

    -- Khai báo biến lặp (i) và độ dài chuỗi dấu (len)
    DECLARE @i INT = 1;
    DECLARE @len INT;

    -- Khai báo biến chứa bảng chữ cái có dấu và không dấu tương ứng
    DECLARE @diacritics NVARCHAR(50) = N'àáảãạăắằẳẵặâấầẩẫậèéẻẽẹêếềểễệìíỉĩịòóỏõọôồốổỗộơờớởỡợùúủũụưừứửữựỳýỷỹỵđ';
    DECLARE @nonDiacritics NVARCHAR(50) = N'aaaaaaaaaaaaaaaaaeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuyyyyyd';

    -- Lấy độ dài chuỗi dấu
    SET @len = LEN(@diacritics);

    -- Lặp qua từng ký tự trong chuỗi dấu
    WHILE @i <= @len
    BEGIN
        -- Thay thế ký tự có dấu bằng ký tự không dấu tương ứng
        SET @output = REPLACE(
                        @output,                            -- Chuỗi cần thay thế
                        SUBSTRING(@diacritics, @i, 1),      -- Ký tự cần thay thế (có dấu)
                        SUBSTRING(@nonDiacritics, @i, 1)    -- Ký tự thay thế (không dấu)
                    );

        -- Tăng biến lặp
        SET @i = @i + 1;
    END

    -- Trả về chuỗi không dấu
    RETURN @output;
END;
