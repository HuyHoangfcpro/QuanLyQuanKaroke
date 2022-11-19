
 GO 
 CREATE TABLE PHONG

 (
	ID INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'CHUA DAT TEN',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống' -- TRONG || CO NGUOI
 )
 GO

 CREATE TABLE Account 
 
 (
	UseName NVARCHAR(100) NOT NULL PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'hoandz',
	PassWord NVARCHAR(1000)NOT NULL DEFAULT 0,
	type INT NOT NULL DEFAULT 0 
 )
 GO
 
 CREATE TABLE FoodCategory
 (
	id INT PRIMARY KEY,
	name NVARCHAR(100)NOT NULL DEFAULT N'chua dat ten',

 )
 GO
 
 CREATE TABLE Food
 (
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'chua dat ten',
	idCategory INT NOT NULL,
	price INT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
 )

 GO 
 CREATE TABLE Bill
 (
	id INT PRIMARY KEY, 
	TGvao DATE NOT NULL DEFAULT GETDATE(),
	TGra DATE NULL,
	idPhong INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: da thanh toan : 0 chua thanh toan
	FOREIGN KEY (idPhong) REFERENCES dbo.PHONG(id)
	
 )
 GO
 
 CREATE TABLE BillInFo
 (
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)

-- thêm tài khoản
 )
 INSERT dbo.Account
 (
     UseName,
     DisplayName,
     PassWord,
     type
 )
 VALUES
 (   N'vip', -- UseName - nvarchar(100)
     N'huy hoang', -- DisplayName - nvarchar(100)
     N'1', -- PassWord - nvarchar(1000)
       1  -- type - int
     )
INSERT dbo.Account
(
    UseName,
    DisplayName,
    PassWord,
    type
)
VALUES
(   N'nes', -- UseName - nvarchar(100)
    N'hoang', -- DisplayName - nvarchar(100)
    N'1', -- PassWord - nvarchar(1000)
     1  -- type - int
    )
GO



-- giúp nhập dữ liệu vào form đăng nhập

CREATE PROC USP_GetAccountByUserName
@UserName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UseName = @UserName
END

GO

EXEC dbo.USP_GetAccountByUserName @UserName = N'vip' -- nvarchar(100)

 GO
 


	 SELECT * FROM dbo.Food
	 GO

INSERT dbo.PHONG
(
    NAME,
    status
)
VALUES
(   N'', -- NAME - nvarchar(100)
    N''  -- status - nvarchar(100)
    )
 go
 -- hàm đưa dữ liệu nhập tên thức ăn vào form thức ăn
CREATE PROC USP_GetFoodByName
@name NVARCHAR(100)
AS
BEGIN
SELECT * FROM dbo.Food WHERE name = @name
END

GO

EXEC dbo.USP_GetFoodByName @name = N'Ten la' -- nvarchar(100)
GO
SELECT * FROM dbo.Account
SELECT *FROM dbo.Account WHERE UseName = N'' AND PassWord = N''
GO
 -- hàm đưa dữ liệu tên và mậ khẩu
CREATE PROC USP_Login
@userName nvarchar(100), @passWord NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UseName = @userName AND PassWord = @passWord
END
GO

-- thêm phòng
DECLARE @i INT = 0

WHILE @i <= 10 
BEGIN
		INSERT dbo.PHONG (NAME) VALUES (   N'Phòng ' + CAST(@i AS NVARCHAR(100)))
		SET @i  = @i + 1
END

SELECT * FROM dbo.PHONG
GO

UPDATE dbo.PHONG SET name = N'Phòng -1' WHERE ID = 1 
UPDATE DBO.PHONG SET status = N'có người' WHERE ID = 1
GO

CREATE PROC USP_GetRoomList
AS SELECT * FROM dbo.PHONG
GO

EXEC dbo.USP_GetRoomList


GO
--thêm category
INSERT dbo.FoodCategory
(
    id,
    name
)
VALUES
(   1,  -- id - int
    N'Đồ Uống' -- name - nvarchar(100)
    )
INSERT dbo.FoodCategory
(
    id,
    name
)
VALUES
(   2,  -- id - int
    N'Đồ Ăn Khô' -- name - nvarchar(100)
    )

INSERT dbo.FoodCategory
(
    id,
    name
)
VALUES
(   3,  -- id - int
    N'Hoa Quả' -- name - nvarchar(100)
    )
-- thêm móm ăn

INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'pessi',   2, 10000          )

INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'', -- name - nvarchar(100)
    0,   -- idCategory - int
    0    -- price - int
    )

--thêm bill

INSERT dbo.Bill
(
    id,
    TGvao,
    TGra,
    idPhong,
    status
)
VALUES
(   2,         -- id - int
    GETDATE(), -- TGvao - date
    GETDATE(), -- TGra - date
    3,         -- idPhong - int
    1          -- status - int
    )
-- thêm bill info

INSERT dbo.BillInFo
(
    idBill,
    idFood,
    count
)
VALUES
(   4, -- idBill - int
    5, -- idFood - int
    1  -- count - int
    )
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Combo Hoa Quả', -- name - nvarchar(100)
    3,   -- idCategory - int
    200000    -- price - int
    )
SELECT f.name, bi.count, f.price,f.price*bi.count AS totalPrice  FROM dbo.BillInFo AS bi, dbo.Bill as b, dbo.Food AS f
WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idPhong =  5
SELECT * FROM dbo.Bill

SELECT * FROM dbo.BillInFo
SELECT * FROM dbo.PHONG
SELECT*  FROM dbo.Food
SELECT * FROM dbo.FoodCategory
go
ALTER PROC USP_InsertBill
@idPhong int
AS 
BEGIN
INSERT dbo.Bill
(
    TGvao,
    TGra,
    idPhong,
    status
)
VALUES
(          
    GETDATE(), -- TGvao - date
    NULL, -- TGra - date
    @idPhong,         -- idPhong - int
    0          -- status - int
    )
END

go
ALTER PROC USP_InsertBillInfo
@idBill INT , @idFood INT, @count INT
AS
BEGIN
	
	DECLARE @isExitBillInfo INT

	DECLARE @foodCount INT = 1

	SELECT @isExitBillInfo = id,
	@foodCount = b.count
	FROM dbo.BillInFo AS b
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitBillInfo > 0)
	BEGIN
	DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInFo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE  
			DELETE dbo.BillInFo WHERE idBill = @idBill AND idFood =@idFood
	    
	END
	ELSE
    BEGIN
			INSERT dbo.BillInFo
			(idBill,idFood,count)
			VALUES(@idBill, @idFood, @count)

	end
    
END




GO

DELETE dbo.BillInFo
DELETE dbo.Bill

go

SELECT MAX(id) FROM dbo.Bill


UPDATE dbo.Bill SET status = 1 WHERE id =1

GO

ALTER TRIGGER UTG_UpdateBillInfo
ON dbo.BillInFo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM Inserted

	DECLARE @idPhong INT

	SELECT @idPhong = idPhong FROM dbo.Bill WHERE id = @idBill 
	
	UPDATE dbo.PHONG SET status = N'có người' WHERE id = @idPhong


END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
		DECLARE @idBill INT

		SELECT @idBill = id FROM Inserted

		DECLARE @idPhong INT

		SELECT @idPhong = idPhong FROM dbo.Bill WHERE id = @idBill 

		DECLARE @count INT = 0

		SELECT @count = COUNT(*) FROM dbo.Bill WHERE idPhong = @idPhong AND status = 0

		IF (@count = 0)
			UPDATE dbo.PHONG SET status = N'Trống' WHERE  id = @idPhong
END
GO






CREATE PROC USP_GetListBillDate
@checkIn date , @checkOut date
AS
BEGIN
	SELECT t.name AS [Tên Bàn] , b.TGvao AS [Thời Gian Vào], b.TGra AS [Thời Gian Về] , b.totalPrice AS [Tổng tiền(Nghìn đồng)]

	FROM  dbo.Bill AS b, dbo.PHONG AS t
	WHERE b.TGvao >= @checkIn AND b.TGra <= @checkOut AND b.status = 1
	AND t.id = b.idPhong

END
GO





CREATE PROC USP_UpdateAccount
@useName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USEName = @useName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UseName = @useName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE USEName = @useName
	end
END
GO
SELECT * FROM ACCOUNT
