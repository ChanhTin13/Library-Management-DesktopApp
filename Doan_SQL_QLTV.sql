USE MASTER
GO
IF EXISTS (SELECT NAME FROM SYS.DATABASES WHERE NAME= N'DoAn_CNPM_QLTV')
DROP DATABASE DoAn_CNPM_QLTV
GO

CREATE DATABASE DoAn_CNPM_QLTV
GO

USE DoAn_CNPM_QLTV
GO

SET DATEFORMAT dmy
GO
--txtMa_NV.Text , txtTenNV.Text , gt , dateTimePicker_NV.Value , txtSDT.Text , txtDiaChi.Text

--MA_NV NVARCHAR(20) , TEN_NVQL NVARCHAR(30) , GIOI_TINH BIT , NGAY_SINH DATETIME , SDT NVARCHAR(20) , DIA_CHI NVARCHAR(50)
CREATE TABLE NHAN_VIEN
(
	MA_NV NVARCHAR(20) NOT NULL PRIMARY KEY,
	
	TEN_NVQL NVARCHAR(30),

	GIOI_TINH BIT,
	NGAY_SINH DATETIME,

	SDT NVARCHAR(20),
	DIA_CHI NVARCHAR(50),

	IMG NVARCHAR(200),
	
	)
GO

CREATE TABLE ACCOUNT
( 
	TK_ACC NVARCHAR(100) NOT NULL PRIMARY KEY,
	PASS NVARCHAR(150) NOT NULL,

	TYPE_ACC BIT NOT NULL , 

	MA_NV NVARCHAR(20) NOT NULL
	FOREIGN KEY (MA_NV) REFERENCES NHAN_VIEN(MA_NV)
)
GO
 --@maDG , @TenDG , @gt ,  @NgaySinh , @SDT , @DiaChi , @GhiChu
 --MA_DOCGIA , TEN_DOCGIA  , GIOI_TINH , NGAY_SINH , SDT , DIA_CHI , GHI_CHU , SACH_CO_THE_MUON , IMG , TINH_TRANG
create table DOCGIA
(
	MA_DOCGIA NVARCHAR(20) NOT NULL PRIMARY KEY, 
	ID int identity,

	TEN_DOCGIA NVARCHAR(50),

	
	GIOI_TINH BIT,
	NGAY_SINH DATETIME,
	 
	SDT NVARCHAR(20),
	DIA_CHI NVARCHAR(50),
	GHI_CHU NVARCHAR(50),

	SACH_CO_THE_MUON INT CHECK(SACH_CO_THE_MUON<3),
	

	IMG NVARCHAR(200),

	TINH_TRANG BIT

)
GO

CREATE TABLE THE_THU_VIEN
(
	ID_THE INT IDENTITY PRIMARY KEY,
	MA_DOCGIA NVARCHAR(20) NOT NULL,
	NGAY_LAP_THE DATETIME,
	NGAY_HET_HAN DATETIME,

	FOREIGN KEY (MA_DOCGIA) REFERENCES DOCGIA(MA_DOCGIA)
	)
GO



CREATE TABLE NXB --MA_NXB NVARCHAR(20) , TEN_NXB NVARCHAR(20) , SDT NVARCHAR(20) , DIA_CHI NVARCHAR(50)
(
	MA_NXB NVARCHAR(20) NOT NULL PRIMARY KEY,
	TEN_NXB NVARCHAR(50),

	SDT NVARCHAR(20),
	DIA_CHI NVARCHAR(50),
	) 
GO 


CREATE TABLE SACH--MA_SACH NVARCHAR(20) , TEN_SACH NVARCHAR(30) , TEN_THE_LOAI NVARCHAR(20) , TEN_TAC_GIA NVARCHAR(20) , MA_NXB NVARCHAR(20) , NAM_XB NVARCHAR(20) , SO_LUONG INT , SO_LUONG_CON INT , GIA BIGINT , IMG NVARCHAR(50) 
(
	MA_SACH NVARCHAR(20) NOT NULL PRIMARY KEY,
	TEN_SACH NVARCHAR(50), 
	
	TEN_THE_LOAI NVARCHAR(20),
	TEN_TAC_GIA NVARCHAR(20),
	 
	MA_NXB NVARCHAR(20),
	NAM_XB NVARCHAR(20),

	SO_LUONG INT,
	SO_LUONG_CON INT,
	GIA BIGINT,

	IMG NVARCHAR(200),
	 
	FOREIGN KEY (MA_NXB) REFERENCES NXB(MA_NXB),

)
GO


--CHO_MUON_SACH @MA_DOCGIA , @MA_SACH , @MA_PHIEU_MUON
CREATE TABLE PHIEU_MUON
(
	MA_PHIEU_MUON NVARCHAR(20) NOT NULL PRIMARY KEY,
	ID int identity,

	MA_DOCGIA NVARCHAR(20),

	FOREIGN KEY (MA_DOCGIA) REFERENCES DOCGIA(MA_DOCGIA)
)
GO

CREATE TABLE CT_PHIEU_MUON
(
	MA_PHIEU_MUON NVARCHAR(20) ,
	MA_SACH NVARCHAR(20),

	NGAY_LAP_PHIEU DATEtime,

	NGAY_HEN_TRA DATEtime,
	NGAY_TRA DATEtime,

	SO_LUONG INT,

	TINH_TRANG BIT,

	FOREIGN KEY (MA_SACH) REFERENCES SACH(MA_SACH),
	FOREIGN KEY (MA_PHIEU_MUON) REFERENCES PHIEU_MUON(MA_PHIEU_MUON)
	)
GO

CREATE TABLE PHIEU_PHAT
(
	MA_PHIEU_PHAT NVARCHAR(20) NOT NULL PRIMARY KEY,
	ID int identity,

	MA_PHIEU_MUON NVARCHAR(20),

	NGAY_LAP_PHIEU_PHAT DATE,
	SO_TIEN BIGINT,
	NOI_DUNG NVARCHAR(50),
	

	FOREIGN KEY (MA_PHIEU_MUON) REFERENCES PHIEU_MUON(MA_PHIEU_MUON)
	)
go


--create proc CHO_MUON_SACH(@MA_DOCGIA NVARCHAR(20) , @MA_SACH NVARCHAR(20) ,@MA_PHIEU_MUON NVARCHAR(20))
--AS
--BEGIN 
--	update DOCGIA set SACH_CO_THE_MUON= SACH_CO_THE_MUON-1 where MA_DOCGIA = @MA_DOCGIA
--	update SACH set SO_LUONG_CON = SO_LUONG_CON-1 where MA_SACH like @MA_SACH
					
--	INSERT INTO PHIEU_MUON VALUES (@MA_PHIEU_MUON , @MA_DOCGIA)

--	INSERT INTO CT_PHIEU_MUON ( MA_PHIEU_MUON, MA_SACH, NGAY_LAP_PHIEU, NGAY_HEN_TRA, NGAY_TRA, SO_LUONG )
--	VALUES(@MA_PHIEU_MUON, @MA_SACH, GETDATE(), GETDATE()+14 , null,1)
--END


----------------------------------------------------------------------------------------------------------------------
---------------------------------------------------QL ĐĂNG KÝ --------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

--txtMa_NV.Text , txtTenNV.Text , gt , dateTimePicker_NV.Value , txtSDT.Text , txtDiaChi.Text
--TK_ACC NVARCHAR(20) , PASS NVARCHAR(30) , TYPE_ACC BIT ,  MA_NV NVARCHAR(20)
--MA_NV NVARCHAR(20) , TEN_NVQL NVARCHAR(20) , GIOI_TINH BIT , NGAY_SINH DATETIME , SDT NVARCHAR(20) , DIA_CHI NVARCHAR(20)

create proc TAO_ACC_CHO_BOSS( @MA_NV NVARCHAR(20) , @TK_ACC NVARCHAR(20), @PASS NVARCHAR(30) )
as
begin
	insert into NHAN_VIEN 
		values ( @MA_NV , N'Boss' , 0 , GETDATE() , N'113'  ,  N'KeKao library' ,'' )
	insert into ACCOUNT 
		VALUES ( @TK_ACC , @PASS , 0 , @MA_NV)


end
go

create proc TAO_ACC_CHO_NV( @MA_NV NVARCHAR(20) , @TK_ACC NVARCHAR(20), @PASS NVARCHAR(30) )
AS
BEGIN 
	
	insert into ACCOUNT 
		VALUES ( @TK_ACC , @PASS , 1 , @MA_NV )

END
GO



----------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------QL ĐỌC GIẢ---------------------------------------------
----------------------------------------------------------------------------------------------------------------------

 --@maDG , @TenDG , @gt ,  @NgaySinh , @SDT , @DiaChi , @GhiChu
 --MA_DOCGIA , TEN_DOCGIA  , GIOI_TINH , NGAY_SINH , SDT , DIA_CHI , GHI_CHU , SACH_CO_THE_MUON , IMG , TINH_TRANG
 --MA_DOCGIA NVARCHAR(20) , TEN_DOCGIA NVARCHAR(20) , GIOI_TINH BIT , NGAY_SINH DATETIME , SDT NVARCHAR(20) , DIA_CHI NVARCHAR(50) , GHI_CHU NVARCHAR(50) , SACH_CO_THE_MUON INT , IMG NVARCHAR(50) , TINH_TRANG BIT
 

create proc SHOW_INFO_DOC_GIA
AS
BEGIN
	select DOCGIA.MA_DOCGIA as N'Mã Đọc Giả' , TEN_DOCGIA as N'Tên Đọc Giả' , GIOI_TINH as N'Giới Tính'  , NGAY_SINH as N'Ngày Sinh'  , SDT as N'SĐT' , 
	DIA_CHI as N'Địa Chỉ' , GHI_CHU as N'Ghi Chú' , SACH_CO_THE_MUON as N'Số sách có thể mượn' , NGAY_LAP_THE AS N'Ngày Lập Thẻ' ,NGAY_HET_HAN AS N'Ngày Hết Hạn', IMG as N'IMG' 
	from DOCGIA ,THE_THU_VIEN
	where DOCGIA.MA_DOCGIA=THE_THU_VIEN.MA_DOCGIA AND
		TINH_TRANG = 0
END
GO
----------------thêm đọc giả-------------------
 --@maDG , @TenDG , @gt ,  @NgaySinh , @SDT , @DiaChi , @GhiChu
 --MA_DOCGIA , TEN_DOCGIA  , GIOI_TINH , NGAY_SINH , SDT , DIA_CHI , GHI_CHU , SACH_CO_THE_MUON , IMG , TINH_TRANG
create proc Them_Doc_Gia (  @TEN_DOCGIA NVARCHAR(50) , @GIOI_TINH BIT , @NGAY_SINH DATETIME , @SDT NVARCHAR(20) , @DIA_CHI NVARCHAR(50) , @GHI_CHU NVARCHAR(50) )
AS
BEGIN
	DECLARE @i INT
	declare @ma_next nvarchar(20)
	
	SELECT @i =  COUNT( * )+1 FROM DOCGIA  
	SET @ma_next = 'DG' + RIGHT('_'+ CAST( @i as nvarchar(20) ),20)
	INSERT INTO DOCGIA
	VALUES  (@ma_next, @TEN_DOCGIA , @GIOI_TINH , @NGAY_SINH , @SDT , @DIA_CHI , @GHI_CHU , 2 , '' , 0)

	 
	insert into THE_THU_VIEN
		values (@ma_next, getdate(), GETDATE()+ 12*30)

END
GO

-------sửa đọc giả
create proc Sua_Doc_Gia ( @MA_DOCGIA NVARCHAR(20) , @TEN_DOCGIA NVARCHAR(50) , @GIOI_TINH BIT , @NGAY_SINH DATETIME , @SDT NVARCHAR(20) , @DIA_CHI NVARCHAR(50) , @GHI_CHU NVARCHAR(50) )
AS
BEGIN
	update DOCGIA
	set TEN_DOCGIA= @TEN_DOCGIA , GIOI_TINH= @GIOI_TINH , NGAY_SINH= @NGAY_SINH , SDT= @SDT , DIA_CHI= @DIA_CHI , GHI_CHU= @GHI_CHU 
	where MA_DOCGIA= @MA_DOCGIA

END
GO

--------Thêm vào DS Đen 
create proc Them_Vao_Danh_Sach_Den ( @MA_DOCGIA NVARCHAR(20) )
AS
BEGIN
	update DOCGIA
	set TINH_TRANG = 1 
	where MA_DOCGIA= @MA_DOCGIA

END
GO

-----------tìm đọc giả--------------

create proc Tim_Doc_Gia_Theo_MaDG ( @Ma_DG NVARCHAR(20) )
AS
BEGIN
	select MA_DOCGIA as N'Mã Đọc Giả' , TEN_DOCGIA as N'Tên Đọc Giả' , GIOI_TINH as N'Giới Tính'  , NGAY_SINH as N'Ngày Sinh'  , SDT as N'SĐT' , 
	DIA_CHI as N'Địa Chỉ' , GHI_CHU as N'Ghi Chú' , SACH_CO_THE_MUON as N'Số sách có thể mượn' , IMG as N'IMG' 
	from DOCGIA
	where TINH_TRANG = 0 and MA_DOCGIA = @Ma_DG
END
GO


create proc Tim_Doc_Gia_Theo_Ten ( @Ten_DG NVARCHAR(50) )
AS
BEGIN
	select MA_DOCGIA as N'Mã Đọc Giả' , TEN_DOCGIA as N'Tên Đọc Giả' , GIOI_TINH as N'Giới Tính'  , NGAY_SINH as N'Ngày Sinh'  , SDT as N'SĐT' , 
	DIA_CHI as N'Địa Chỉ' , GHI_CHU as N'Ghi Chú' , SACH_CO_THE_MUON as N'Số sách có thể mượn' , IMG as N'IMG' 
	from DOCGIA
	where TINH_TRANG = 0 and TEN_DOCGIA = @Ten_DG
END
GO



----------------------------------------------------------------------------------------------------------------------
------------------------------------------------------QL Danh Sách Đen--------------------------------------------
----------------------------------------------------------------------------------------------------------------------
--- ma_Dg, ten_DG, ghi_chu, ngay_sinh, gt, img
create proc SHOW_DANH_SACH_DEN
AS
BEGIN
	select MA_DOCGIA as N'Mã Đọc Giả' , TEN_DOCGIA as N'Tên Đọc Giả' , GIOI_TINH as N'Giới Tính'  , NGAY_SINH as N'Ngày Sinh'  , GHI_CHU as N'Ghi Chú' , IMG as N'IMG' 
	from DOCGIA
	where TINH_TRANG = 1
END
GO

---loại khỏi ds đen
create proc LOAI_KHOI_DANH_SACH_DEN ( @MA_DOCGIA NVARCHAR(20) )
AS
BEGIN
	update DOCGIA
	set TINH_TRANG = 0
	where MA_DOCGIA= @MA_DOCGIA

END
GO
 

--------------XOA_DS_DEN
create proc XOA_DS_DEN
AS
BEGIN
	delete CT_PHIEU_MUON
	where MA_PHIEU_MUON like (select PHIEU_MUON.MA_PHIEU_MUON from PHIEU_MUON, DOCGIA where PHIEU_MUON.MA_DOCGIA=DOCGIA.MA_DOCGIA AND DOCGIA.TINH_TRANG=1)
	
	delete PHIEU_MUON
	where MA_DOCGIA like (select MA_DOCGIA from DOCGIA where TINH_TRANG=1)

	delete THE_THU_VIEN
	WHERE MA_DOCGIA LIKE (select MA_DOCGIA from DOCGIA where TINH_TRANG=1)
	
	delete DOCGIA
	where TINH_TRANG=1
END
GO



----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------QL SÁCH-----------------------------------------------------
----------------------------------------------------------------------------------------------------------------------
-------MA_SACH NVARCHAR(20) , TEN_SACH NVARCHAR(30) , TEN_THE_LOAI NVARCHAR(20) ,
-------TEN_TAC_GIA NVARCHAR(20) , MA_NXB NVARCHAR(20) , NAM_XB NVARCHAR(20) , SO_LUONG INT , SO_LUONG_CON INT , GIA BIGINT , IMG NVARCHAR(50) 
create proc LOAD_SACH
AS
BEGIN
	select MA_SACH as N'Mã Sách' , TEN_SACH as N'Tên Sách'  , TEN_THE_LOAI as N'Thể Loại' ,
			TEN_TAC_GIA as N'Tên Tác Giả' , NXB.TEN_NXB as N'Nhà Xuất Bản'  , NAM_XB as N'Năm Xuất Bản'  , SO_LUONG as N'Số Lượng' , SO_LUONG_CON as N'Số Lượng Còn' , GIA as N'Giá' , IMG as N'IMG' 
	from SACH,NXB
	where SACH.MA_NXB=NXB.MA_NXB 
END
GO

--------------------------TÌM SÁCH---------------
create proc TIM_SACH_THEO_MA (@MA_SACH NVARCHAR(20))
AS
BEGIN
	SELECT * FROM SACH WHERE MA_SACH=@MA_SACH
END
GO

create proc TIM_SACH_THEO_TEN (@TEN_SACH NVARCHAR(50) )
AS
BEGIN
	SELECT * FROM SACH WHERE TEN_SACH= @TEN_SACH
END
GO

create proc TIM_SACH_THEO_TEN_TG(@TEN_TAC_GIA NVARCHAR(20))
AS
BEGIN
	SELECT * FROM SACH WHERE TEN_TAC_GIA= @TEN_TAC_GIA
END
GO

create proc TIM_SACH_THEO_THE_LOAI( @TEN_THE_LOAI NVARCHAR(20) )
AS
BEGIN
	SELECT * FROM SACH WHERE TEN_THE_LOAI= @TEN_THE_LOAI
END
GO

---------------------SỬA SÁCH-----------------------------
----------@MA_SACH , @TEN_SACH , @THE_LOAI , @TAC_GIA , @NXB , @NAM_XB , @SO_LUONG , @GIA , @IMG
create proc SUA_SACH ( @MA_SACH NVARCHAR(20) , @TEN_SACH NVARCHAR(50) , @TEN_THE_LOAI NVARCHAR(20) , @TEN_TAC_GIA NVARCHAR(20) , @TEN_NXB NVARCHAR(20) , @NAM_XB NVARCHAR(20) , @SO_LUONG INT , @SO_LUONG_CON INT , @GIA BIGINT )
AS
BEGIN  

	UPDATE SACH  
	SET   TEN_SACH= @TEN_SACH , TEN_THE_LOAI= @TEN_THE_LOAI , TEN_TAC_GIA= @TEN_TAC_GIA , NAM_XB= @NAM_XB  , SO_LUONG_CON = @SO_LUONG_CON+ (@SO_LUONG-SO_LUONG) , SO_LUONG= @SO_LUONG , GIA = @GIA 
	where MA_SACH= @MA_SACH
	
	UPDATE NXB
	SET TEN_NXB = @TEN_NXB
	WHERE (SELECT COUNT(*) FROM NXB WHERE TEN_NXB= @TEN_NXB) >0
END
GO
 
------------------THÊM SÁCH---------------------------------
create proc THEM_SACH ( @MA_SACH NVARCHAR(20) , @TEN_SACH NVARCHAR(50) , @TEN_THE_LOAI NVARCHAR(20) , @TEN_TAC_GIA NVARCHAR(20) , @TEN_NXB NVARCHAR(20) , @NAM_XB NVARCHAR(20) , @SO_LUONG INT , @GIA BIGINT )
AS
BEGIN
	DECLARE @get_ma_nxb NVARCHAR(20)
	SET @get_ma_nxb = (SELECT MA_NXB FROM NXB WHERE TEN_NXB = @TEN_NXB )
	insert into SACH values
		(@MA_SACH , @TEN_SACH , @TEN_THE_LOAI, @TEN_TAC_GIA , @get_ma_nxb , @NAM_XB , @SO_LUONG ,@SO_LUONG , @GIA , NULL)
END
GO



----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------QL NXB-----------------------------------------------------
----------------------------------------------------------------------------------------------------------------------
--@MA_NXB , @TEN_NXB , @SDT , @Dia_Chi
--MA_NXB NVARCHAR(20) , TEN_NXB NVARCHAR(20) , SDT NVARCHAR(20) , DIA_CHI NVARCHAR(50)
--------------SỬA NXB

CREATE PROC SUA_NXB ( @MA_NXB NVARCHAR(20) , @TEN_NXB NVARCHAR(50) , @SDT NVARCHAR(20) , @DIA_CHI NVARCHAR(50) )
AS
BEGIN
	UPDATE NXB
	SET TEN_NXB = @TEN_NXB , SDT= @SDT , DIA_CHI= @DIA_CHI
	WHERE MA_NXB= @MA_NXB
END
GO

-------LOAD NXB
CREATE PROC LOAD_NXB
AS
BEGIN
	SELECT MA_NXB AS N'Mã Nhà Xuất Bản' , TEN_NXB AS N'Tên Nhà Xuất Bản' , SDT AS N'Số Điện Thoại' , DIA_CHI AS N'Địa Chỉ' FROM NXB
END
GO


----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------THỐNG KÊ----------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

CREATE PROC DEM_SO_LUONG_DAU_SACH
AS
BEGIN
	SELECT  DISTINCT COUNT( TEN_THE_LOAI ) FROM SACH
END
GO

CREATE PROC DEM_SO_LUONG_SACH
AS
BEGIN
	SELECT  COUNT(*) FROM SACH
END
GO


CREATE PROC DEM_SO_LUONG_SACH_DANG_CHO_MUON
AS
BEGIN
	SELECT  COUNT(*) FROM CT_PHIEU_MUON WHERE TINH_TRANG = 0
END
GO

CREATE PROC DEM_SO_LUONG_SACH_QUA_HAN
AS
BEGIN
	SELECT  COUNT(*) FROM CT_PHIEU_MUON WHERE NGAY_HEN_TRA>GETDATE()
END
GO

CREATE PROC DEM_SO_LUONG_DOC_GIA
AS
BEGIN
	SELECT  COUNT(*) FROM DOCGIA 
END
GO

CREATE PROC DEM_SO_LUONG_DOC_GIA_DANG_MUON_SACH
AS
BEGIN
	SELECT DISTINCT COUNT(MA_DOCGIA) FROM PHIEU_MUON, CT_PHIEU_MUON WHERE PHIEU_MUON.MA_PHIEU_MUON=CT_PHIEU_MUON.MA_PHIEU_MUON AND CT_PHIEU_MUON.TINH_TRANG =0 
END
GO

CREATE PROC DEM_SO_LUONG_DOC_GIA_MUON_SACH_QUA_HAN
AS
BEGIN
	SELECT DISTINCT COUNT(MA_DOCGIA) FROM PHIEU_MUON, CT_PHIEU_MUON WHERE PHIEU_MUON.MA_PHIEU_MUON=CT_PHIEU_MUON.MA_PHIEU_MUON AND NGAY_HEN_TRA>GETDATE()
END
GO

CREATE PROC DANH_SACH_DOC_GIA_MUON_SACH_QUA_HAN
AS
BEGIN
	select MA_DOCGIA as N'Mã Đọc Giả' , TEN_DOCGIA as N'Tên Đọc Giả' , GIOI_TINH as N'Giới Tính'  , NGAY_SINH as N'Ngày Sinh'  , SDT as N'SĐT' , 
		DIA_CHI as N'Địa Chỉ' , GHI_CHU as N'Ghi Chú' , SACH_CO_THE_MUON as N'Số sách có thể mượn'
		FROM DOCGIA
		WHERE MA_DOCGIA = (SELECT DISTINCT MA_DOCGIA FROM PHIEU_MUON, CT_PHIEU_MUON WHERE PHIEU_MUON.MA_PHIEU_MUON=CT_PHIEU_MUON.MA_PHIEU_MUON AND NGAY_HEN_TRA>GETDATE())
END
GO

CREATE PROC DANH_SACH_SACH_QUA_HAN
AS
BEGIN
	select MA_SACH as N'Mã Sách' , TEN_SACH as N'Tên Sách'  , TEN_THE_LOAI as N'Thể Loại' ,
			 SO_LUONG as N'Số Lượng' , SO_LUONG_CON as N'Số Lượng Còn'
	FROM SACH
	WHERE MA_SACH like
	(SELECT DISTINCT MA_SACH FROM CT_PHIEU_MUON WHERE NGAY_HEN_TRA>GETDATE())
END
GO





----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------QL MƯỢN SÁCH------------------------------------------------
----------------------------------------------------------------------------------------------------------------------
--txtMaDG.Text, txtMaSach.Text, txt_MaPhieu.Text
--@MA_DOCGIA , @MA_SACH , @MA_PHIEU_MUON

 --MA_DOCGIA NVARCHAR(20) , TEN_DOCGIA NVARCHAR(20) , GIOI_TINH BIT , NGAY_SINH DATETIME , SDT NVARCHAR(20) , DIA_CHI NVARCHAR(50) , GHI_CHU NVARCHAR(50) , SACH_CO_THE_MUON INT , IMG NVARCHAR(50) , TINH_TRANG BIT
 --MA_SACH NVARCHAR(20) , TEN_SACH NVARCHAR(30) , TEN_THE_LOAI NVARCHAR(20) , TEN_TAC_GIA NVARCHAR(20) , MA_NXB NVARCHAR(20) , NAM_XB NVARCHAR(20) , SO_LUONG INT , SO_LUONG_CON INT , GIA BIGINT , IMG NVARCHAR(50) 
CREATE PROC CHO_MUON_SACH ( @MA_DOCGIA NVARCHAR(20) , @MA_SACH NVARCHAR(20) , @MA_PHIEU NVARCHAR(20) )
AS
BEGIN 
	INSERT INTO PHIEU_MUON VALUES ( @MA_PHIEU , @MA_DOCGIA )
	INSERT INTO CT_PHIEU_MUON VALUES ( @MA_PHIEU , @MA_SACH , GETDATE() , GETDATE()+ 14 , NULL , 1 , 0 )
	UPDATE DOCGIA SET SACH_CO_THE_MUON = SACH_CO_THE_MUON-1 WHERE MA_DOCGIA = @MA_DOCGIA
	UPDATE SACH SET SO_LUONG_CON = SO_LUONG_CON-1 WHERE MA_SACH = @MA_SACH
END
GO




----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------QL TRẢ SÁCH------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

---------LOAD SÁCH
CREATE PROC LOAD_DS_TraSach
AS
BEGIN 
	SELECT PHIEU_MUON.MA_PHIEU_MUON AS N'Mã Phiếu', PHIEU_MUON.MA_DOCGIA AS N'Mã Đọc Giả' , DOCGIA.TEN_DOCGIA AS N'Tên Đọc Giả' , CT_PHIEU_MUON.MA_SACH AS N'Mã Sách' ,
			SACH.TEN_SACH AS N'Tên Sách' ,
			NGAY_LAP_PHIEU AS N'Ngày Lập Phiếu' , NGAY_HEN_TRA AS N'Hạn Trả' 
	FROM PHIEU_MUON , CT_PHIEU_MUON , DOCGIA , SACH
	WHERE PHIEU_MUON.MA_PHIEU_MUON = CT_PHIEU_MUON.MA_PHIEU_MUON AND 
	DOCGIA.MA_DOCGIA = PHIEU_MUON.MA_DOCGIA AND
	SACH.MA_SACH = CT_PHIEU_MUON.MA_SACH AND
	CT_PHIEU_MUON.TINH_TRANG = 0

END
GO

CREATE FUNCTION ShowFor_TraSach()
returns table return 
	SELECT PHIEU_MUON.MA_PHIEU_MUON AS N'Mã Phiếu', PHIEU_MUON.MA_DOCGIA AS N'Mã Đọc Giả' , DOCGIA.TEN_DOCGIA AS N'Tên Đọc Giả' , CT_PHIEU_MUON.MA_SACH AS N'Mã Sách' ,
			SACH.TEN_SACH AS N'Tên Sách' ,
			NGAY_LAP_PHIEU AS N'Ngày Lập Phiếu' , NGAY_HEN_TRA AS N'Hạn Trả' 
	FROM PHIEU_MUON , CT_PHIEU_MUON , DOCGIA , SACH
	WHERE PHIEU_MUON.MA_PHIEU_MUON = CT_PHIEU_MUON.MA_PHIEU_MUON AND 
	DOCGIA.MA_DOCGIA = PHIEU_MUON.MA_DOCGIA AND
	SACH.MA_SACH = CT_PHIEU_MUON.MA_SACH AND
	CT_PHIEU_MUON.TINH_TRANG = 0
GO 

--------------TRẢ SÁCH
CREATE PROC Tra_Sach ( @MA_PHIEU NVARCHAR(20) , @MA_DOCGIA NVARCHAR(20) , @MA_SACH NVARCHAR(20) )
AS
BEGIN 
	update CT_PHIEU_MUON set TINH_TRANG = 1 where MA_PHIEU_MUON = @MA_PHIEU
	 UPDATE DOCGIA SET SACH_CO_THE_MUON = SACH_CO_THE_MUON+1 WHERE MA_DOCGIA = @MA_DOCGIA
	UPDATE SACH SET SO_LUONG_CON = SO_LUONG_CON+1 WHERE MA_SACH = @MA_SACH
END
GO

---GIA HẠN
CREATE PROC GIA_HAN ( @MA_PHIEU NVARCHAR(20) )
AS
BEGIN 
	update CT_PHIEU_MUON set NGAY_HEN_TRA = NGAY_HEN_TRA + 14 where MA_PHIEU_MUON = @MA_PHIEU 
END
GO

---lập phiếu phạt
CREATE PROC LAP_PHIEU_PHAT ( @MA_PHIEU_MUON NVARCHAR(20) , @MA_SACH NVARCHAR(20) )
AS
BEGIN  
 
	DECLARE @ID_PHIEU_PHAT INT

	declare @MA_PHIEU_PHAT nvarchar(20)
	
	SELECT @ID_PHIEU_PHAT =  COUNT( * )+1 FROM DOCGIA  
	SET @MA_PHIEU_PHAT = 'PHIEU_PHAT' + RIGHT('_'+ CAST( @ID_PHIEU_PHAT as nvarchar(20) ),20)

	DECLARE @SO_TIEN_PHAT BIGINT
	SET @SO_TIEN_PHAT = CAST( (SELECT GIA FROM SACH WHERE MA_SACH = @MA_SACH ) AS BIGINT )

	INSERT INTO PHIEU_PHAT VALUES (@MA_PHIEU_PHAT , @MA_PHIEU_MUON , GETDATE() , @SO_TIEN_PHAT , N'TRẢ SÁCH MUỘN' )
END
GO




----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------QL NHÂN VIÊN------------------------------------------------
----------------------------------------------------------------------------------------------------------------------
--(@MA_NV NVARCHAR(20) , @TEN_NVQL NVARCHAR(30) , @GIOI_TINH BIT , @NGAY_SINH DATETIME , @SDT NVARCHAR(20) , @DIA_CHI NVARCHAR(50) )
CREATE PROC SHOW_NHAN_VIEN 
AS
BEGIN 
	(SELECT NHAN_VIEN.MA_NV AS N'Mã Nhân Viên' , TEN_NVQL AS N'Tên Nhân Viên' , GIOI_TINH AS N'Giới Tính' , NGAY_SINH AS N'Ngày Sinh' , SDT  AS N'SĐT' , DIA_CHI AS N'Địa Chỉ' , IMG AS N'IMG'
	FROM NHAN_VIEN
	 )
	except
	(SELECT NHAN_VIEN.MA_NV AS N'Mã Nhân Viên' , TEN_NVQL AS N'Tên Nhân Viên' , GIOI_TINH AS N'Giới Tính' , NGAY_SINH AS N'Ngày Sinh' , SDT  AS N'SĐT' , DIA_CHI AS N'Địa Chỉ' , IMG AS N'IMG'
	FROM NHAN_VIEN, ACCOUNT
	WHERE NHAN_VIEN.MA_NV=ACCOUNT.MA_NV AND
			ACCOUNT.TYPE_ACC=0)
END
GO

	
  
-----THÊM NHÂN VIÊN
--THEM_NHAN_VIEN @maNV , @TenNV , @gt ,  @NgaySinh , @SDT , @DiaChi
CREATE PROC THEM_NHAN_VIEN (@MA_NV NVARCHAR(20) , @TEN_NVQL NVARCHAR(30) , @GIOI_TINH BIT , @NGAY_SINH DATETIME , @SDT NVARCHAR(20) , @DIA_CHI NVARCHAR(50) )
AS
BEGIN  
	INSERT INTO NHAN_VIEN
		VALUES ( @MA_NV , @TEN_NVQL , @GIOI_TINH , @NGAY_SINH , @SDT , @DIA_CHI ,'') 
END
GO

-----SỬA NHÂN VIÊN
CREATE PROC SUA_NHAN_VIEN (@MA_NV NVARCHAR(20) , @TEN_NVQL NVARCHAR(30) , @GIOI_TINH BIT , @NGAY_SINH DATETIME , @SDT NVARCHAR(20) , @DIA_CHI NVARCHAR(50) )
AS
BEGIN  
	UPDATE NHAN_VIEN
		SET  TEN_NVQL= @TEN_NVQL , GIOI_TINH= @GIOI_TINH ,NGAY_SINH= @NGAY_SINH ,SDT= @SDT ,DIA_CHI= @DIA_CHI 
		WHERE MA_NV= @MA_NV 
END
GO

-----XÓA NHÂN VIÊN
CREATE PROC XOA_NHAN_VIEN (@MA_NV NVARCHAR(20)  )
AS
BEGIN  
	DELETE NHAN_VIEN 
		WHERE MA_NV= @MA_NV 
END
GO




--MA_DOCGIA , TEN_DOCGIA  , GIOI_TINH , NGAY_SINH , SDT , DIA_CHI , GHI_CHU , SACH_CO_THE_MUON , IMG , TINH_TRANG
INSERT INTO DOCGIA 
VALUES
    (N'DG_1', N'Chí Thiện', 1, '04-02-2001', N'0134584768', N'Khánh Hòa', N'ghi chú ', '2' , '', 0 ),
    (N'DG_2', N'Tuấn Khoa', 1, '14/09/2001', N'0134584386', N'Biên Hòa', N'ghi chú ', 2, '', 0),
    (N'DG_3', N'Anh Khôi', 1, '01/01/2001', N'0949587642', N'TP. Hồ Chí Minh', N'ghi chú ', 2, '', 0),
    (N'DG_4', N'Tiến Dũng', 1, '02/11/2001', N'0964584764', N'Bình Phước', N'ghi chú ', 2, '', 0),
    (N'DG_5', N'Hiền Thảo', 0, '22/10/2006', N'0924723764', N'Bình Phước', N'ghi chú ', 2, '', 0)

INSERT INTO THE_THU_VIEN 
VALUES
    (N'DG_1', getdate(), getdate()+12*30),
    (N'DG_2', getdate(), getdate()+12*30),
    (N'DG_3', getdate(), getdate()+12*30),
    (N'DG_4', getdate(), getdate()+12*30),
    (N'DG_5', getdate(), getdate()+12*30)

INSERT INTO NXB
    (MA_NXB,TEN_NXB, SDT, DIA_CHI)
VALUES
    (N'NXB_1', N'NXB Trẻ', N'(028)39316289', N'161B Lý Chính Thắng Quận 3, TPHCM'),
    (N'NXB_2', N'NXB Kim Đồng', N'02439434730', N'55 Quang Trung, Hai Bà Trưng, Hà Nội'),
    (N'NXB_3', N'NXB Tổng Hợp TP.HCM', N'(028) 38 225 340', N'62 Nguyễn Thị Minh Khai,Đa Kao, Q1, TP.HCM'),
    (N'NXB_4', N'Chính trị quốc gia', N'0280.49221', N'Số 6/86 Duy Tân, Cầu Giấy, Hà Nội'),
    (N'NXB_5', N'NXB Lao Động', N'0243.8515380', N'175 Giảng Võ, Đống Đa, Hà Nội')

INSERT INTO SACH
    (MA_SACH,TEN_SACH, TEN_THE_LOAI, TEN_TAC_GIA,MA_NXB,NAM_XB ,SO_LUONG,SO_LUONG_CON,GIA, IMG )
VALUES
    ('MS_01', N'Cánh bướm dối gian', N'Văn hóa  xã hội', N'GS. TS. Hoàng Bá', N'NXB_1', '04-05-1999', 5, 5, '35000', ''),
    ('MS_02', N'Dragon Ball - TẬP 23', N'truyện tranh', N'Koyoharu Gotouge', N'NXB_2', '04-05-1999', 10, 10, '22500', ''),
    ('MS_03', N'Quan hệ 1 giờ', N'Sinh 10', 'Nikoleta Novak', N'NXB_3', '04-05-1999', 20, 20, '75000', ''),
    ('MS_04', N'Ngủ ngon', N'Sức khỏe', N'Cheryl Strayed', N'NXB_4', '04-05-1999', 26, 26, '103200', ''),
    ('MS_05', N'Trần dần', N'Kênh Văn hóa', N'AJAHN CHAH', N'NXB_5', '04-05-1999', 20, 20, '115000', '')

--SELECT * FROM DOCGIA
--SELECT * FROM THE_THU_VIEN

--SELECT * FROM NXB
--SELECT * FROM SACH


--insert into NHAN_VIEN values (N'NV_1', N'SDFD',1,'04-02-2021',N'555',N'SDF','')

--SHOW_NHAN_VIEN