/*use master
go
IF EXISTS (SELECT * FROM SYS.databases WHERE NAME = 'THUOC')
drop database THUOC
go
create database THUOC
go*/
create database QLBT
use QLBT
--Tạo bảng Nhomthuoc
drop table tblNhomthuoc
CREATE TABLE [dbo].[tblNhomthuoc]
(
	[MANHOM] NVARCHAR(10) NOT NULL PRIMARY KEY, 
    [TENNHOM] NVARCHAR(50) NOT NULL, 
    [GHICHU] NCHAR(10) NULL
)

--Tạo bảng Thuoc
drop table tblThuoc
CREATE TABLE [dbo].[tblThuoc]
(	
	[MATHUOC] NVARCHAR(20) NOT NULL PRIMARY KEY, 
	[MANHOM] NVARCHAR(10) not null,
    [TENTHUOC] NVARCHAR(100) NOT NULL, 
    [HOATCHATCHINH] NVARCHAR(100) NOT NULL, 
    [HAMLUONG] NVARCHAR(80) NULL, 
	[HANGSX] NVARCHAR(50) NOT NULL,
	[NUOCSX] NVARCHAR(50) NULL,
    [QUYCACHDONGGOI] NVARCHAR(80) NOT NULL,
	[DVT] NVARCHAR(50) NOT NULL, 
    
)

--Tạo bảng Nhanvien
drop table tblNhanvien
CREATE TABLE [dbo].[tblNhanvien]
(
	[MANHANVIEN] NVARCHAR(20) NOT NULL PRIMARY KEY, 
    [TENNHANVIEN] NVARCHAR(50) NOT NULL, 
    [DIACHI] NVARCHAR(100) NOT NULL,
    [SDT] NVARCHAR(50) NOT NULL,
	[TAIKHOAN] nvarchar(20) not null,
	[MATKHAU] nvarchar(20) NOT NULL,
	[QUYEN] nvarchar(10) NOT NULL,
)

--Tạo bảng Khachhang
drop table tblKhachhang
CREATE TABLE [dbo].[tblKhachhang]
(
	[MAKHACH] NVARCHAR(20) NOT NULL PRIMARY KEY, 
    [TENKHACH] NVARCHAR(50) NOT NULL, 
    [DIACHI] NVARCHAR(100) NOT NULL,
	[EMAIL] NVARCHAR(50) NOT NULL,
    [SDT] NVARCHAR(50)  NULL
)

--Tạo bảng Nhacungcap
drop table tblNhacungcap
CREATE TABLE [dbo].[tblNhacungcap]
(
	[MANCC] NVARCHAR(20) NOT NULL PRIMARY KEY, 
    [TENNCC] NVARCHAR(100) NOT NULL, 
    [SDT] NVARCHAR(20) NOT NULL, 
    [EMAIL] NVARCHAR(50) NOT NULL, 
    [MST]  NVARCHAR(50)  NULL
)

--Tạo bảng Phieunhap
drop table tblPhieunhap
CREATE TABLE [dbo].[tblPhieunhap]
(
	[MANHAP] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [NGAYNHAP] DATE NOT NULL, 
    [MANCC] NVARCHAR(20) NOT NULL,
    [TONGTIEN] INT NOT NULL, 
    [GHICHU] NVARCHAR(50) NULL
)

--Tạo bảng CTPhieunhap
drop table tblCTPhieunhap
CREATE TABLE [dbo].[tblCTPhieunhap]
(
	[MANHAP] NVARCHAR(50),
	[MATHUOC] NVARCHAR(20),
    [LOSX] int NOT NULL, 
	[HSD] date not null,
    [DVT] NVARCHAR(50) NOT NULL, 
    [DONGIA] float NOT NULL, 
    [SLUONG] int not NULL,
	[THANHTIEN] float not null,
	CONSTRAINT [PK_CT_Phieunhap] PRIMARY KEY CLUSTERED ([MANHAP] ASC, [MATHUOC] ASC),
)

--Tạo bảng Hoadonban
drop table tblHoadonban
CREATE TABLE [dbo].[tblHoadonban]
(
	[MABAN] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [NGAYNHAP] DATE NOT NULL, 
    [MAKHACH] NVARCHAR(20),
	[MANHANVIEN] NVARCHAR(20),
    [TONGTIEN] INT NOT NULL, 
    [GHICHU] NVARCHAR(50) NULL
)

--Tạo bảng CTHoadonban
drop table tblCTHoadonban
CREATE TABLE [dbo].[tblCTHoadonban]
(
	[MABAN] NVARCHAR(50) NOT NULL,
	[MATHUOC] NVARCHAR(20) NOT NULL,
    [LOSX] int NOT NULL, 
    [DVT] NVARCHAR(50) NOT NULL, 
    [DONGIA] float NOT NULL, 
    [SLUONG] int not NULL,
	[THANHTIEN] float not null,
	CONSTRAINT [PK_CT_Hoadonban] PRIMARY KEY CLUSTERED ([MABAN] ASC, [MATHUOC] ASC),
)

--Tạo các ràng buộc

ALTER TABLE [dbo].[tblCTHoadonban] ADD FOREIGN KEY([MABAN])
REFERENCES [dbo].[tblHoadonban] ([MABAN])

ALTER TABLE [dbo].[tblCTHoadonban] ADD FOREIGN KEY([MATHUOC])
REFERENCES [dbo].[tblThuoc] ([MATHUOC])

ALTER TABLE [dbo].[tblCTPhieunhap] ADD FOREIGN KEY([MANHAP])
REFERENCES [dbo].[tblPhieunhap] ([MANHAP])

ALTER TABLE [dbo].[tblCTPhieunhap] ADD FOREIGN KEY([MATHUOC])
REFERENCES [dbo].[tblThuoc] ([MATHUOC])

ALTER TABLE [dbo].[tblHoadonban] ADD FOREIGN KEY([MAKHACH])
REFERENCES [dbo].[tblKhachhang] ([MAKHACH])

ALTER TABLE [dbo].[tblHoadonban] ADD FOREIGN KEY ([MANHANVIEN]) 
REFERENCES [dbo].[tblNhanvien] ([MANHANVIEN])

ALTER TABLE [dbo].[tblPhieunhap] ADD FOREIGN KEY([MANCC])
REFERENCES [dbo].[tblNhacungcap] ([MANCC])

ALTER TABLE [dbo].[tblThuoc] ADD FOREIGN KEY([MANHOM])
REFERENCES [dbo].[tblNhomthuoc] ([MANHOM])

--Thêm dữ liệu cho các bảng

-- index: 1
INSERT [dbo].[tblNhomthuoc] ([MANHOM], [TENNHOM], [GHICHU]) VALUES (N'N001', N'Thực phẩm chức năng', N'123       ')
INSERT [dbo].[tblNhomthuoc] ([MANHOM], [TENNHOM], [GHICHU]) VALUES (N'N002', N'Thuốc kháng sinh', N'          ')
INSERT [dbo].[tblNhomthuoc] ([MANHOM], [TENNHOM], [GHICHU]) VALUES (N'N003', N'Thuốc trẻ em', N'          ')
INSERT [dbo].[tblNhomthuoc] ([MANHOM], [TENNHOM], [GHICHU]) VALUES (N'N004', N'Thuốc ho', N'Cảm cúm   ')
INSERT [dbo].[tblNhomthuoc] ([MANHOM], [TENNHOM], [GHICHU]) VALUES (N'N005', N'Nhóm khác', NULL)

-- index: 2 
delete from tblThuoc
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000002', N'N003', N'ELUMATIC III', N'Technectium (Tc99m)', N'Technectium (Tc99m)', N'Pháp', N'', N'đóng gói 20GBq/ lọ', N'mCi')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000009', N'N002', N'MIBG - D', N'Iobenguane (I131)', N'Iobenguane (I131)', N'pháp', N'', N'lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000017', N'N003', N'Bisocar 2.5', N'Bisoprolol fumarate 2,5mg', N'', N'Rusan Pharma Ltd.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000019', N'N003', N'Coxwell-60', N'Etoricoxib 60mg - 60mg', N'', N'Micro Labs Limited', N'', N'Hộp 03 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000020', N'N002', N'Lipicard-160', N'Fenofibrat micronised 160 mg', N'', N'USV Ltd.', N'', N'Hộp 4vỉ x 7viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000022', N'N002', N'Synartan-16', N'Candesartan Cilexetil 16mg', N'', N'Synmedic Laboratories', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000027', N'N001', N'Aziplus', N'Azithromycin dihydrate', N'250mg', N'M/S Nova Med Pharmaceuticals', N'', N'Hộp 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000028', N'N004', N'Corosan', N'Valsartan 80mg', N'', N'Balkanpharma - Dupnitsa AD', N'', N'Hộp 4 vỉ x 7 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000029', N'N003', N'Losarlife 50', N'Losartan kali 50mg', N'', N'Eurolife Healthcare Pvt., Ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000032', N'N001', N'Nilibac 500', N'Cefuroxim Acetil', N'500mg Cefuroxime', N'Square Cephalosporins Ltd.', N'', N'Hộp 1 vỉ x 6 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000035', N'N004', N'Pedomcad', N'Domperidon 10mg', N'', N'Cadila Pharmaceuticals Limited', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000039', N'N001', N'Fexogold-40', N'Febuxostat', N'40mg', N'Ấn Độ', N'', N'Hộp 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000040', N'N003', N'Mukex', N'Ambroxol  hydroclorid 30mg', N'', N'Kusum Healthcare Pvt. Ltd.', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000041', N'N001', N'CORRECTOL', N'Dinatri inosin monophosphat 0.1%', N'', N'ALCON CUSI S.A.,', N'', N'Hộp 1 lọ 10ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000042', N'N002', N'Gapivell', N'Gabapentin 300mg', N'', N'PT. Novell Pharmaceutical Laboratories', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000044', N'N002', N'Vatirino Paediatric', N'Cefpodoxim proxetil', N'20mg Cefpodoxim', N'Novo Healthcare and Pharma Ltd.', N'', N'Hộp 1 chai 30ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000045', N'N003', N'Cyclogyl 1%', N'Cyclopentolat Hydrochlorid', N'', N'S.a. Alcon Couvreur', N'', N'Hộp 1 lọ 15ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000046', N'N001', N'OTUNA 1%', N'Selenium Sulfide', N'', N'Thái Lan', N'', N'Hộp 1 chai 120ml', N'Hộp')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000050', N'N002', N'Oncofluor 250', N'Fluorouracil 250mg/5ml', N'', N'United Biotech (P) Limited', N'', N'Hộp 05 ống x 5ml', N'Ống')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000051', N'N001', N'Monoclarium', N'Clarithromycin', N'200mg', N'SMB Technology S.A', N'', N'Hộp 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000053', N'N001', N'Oncofluor 500', N'Fluorouracil 500mg/10ml', N'', N'United Biotech (P) Limited', N'', N'Hộp 05 ống x 10ml', N'Ống')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000054', N'N002', N'Maxocef-200', N'Cefixime 200mg', N'', N'Micro Labs Limited', N'', N'Hộp 1 vỉ x 10 viên, hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000055', N'N001', N'Brelmocef-500', N'Cefuroxime Axetil', N'500mg Cefuroxime', N'Micro Labs Ltd.', N'', N'Hộp 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000057', N'N001', N'Remirta 45mg', N'Mirtazapin 45mg', N'', N'Actavis Ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000065', N'N001', N'Eurodora', N'Desloratadine', N'5mg', N'Mystic pharmaceuticals ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000066', N'N001', N'Kipel 10', N'Montelukast natri', N'10mg Montelukast', N'MSN Laboratories Limited', N'Ấn Độ', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000072', N'N002', N'Avaxim 80', N'Viêm gan siêu vi A', N'80U/0,5ml', N'Sanofi Pasteur', N'Pháp', N'Hộp 1 liều', N'Hộp')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000073', N'N001', N'Medibro Tab', N'Ambroxol  hydroclorid 30mg', N'', N'Korea Arlico Pharm. Co., Ltd.', N'', N'Hộp 10 vỉ x 10 viên, hộp 5 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000074', N'N001', N'Seocelis Injection', N'Methocarbamol 1000mg/10ml', N'500mg', N'Huons Co. Ltd', N'', N'Hộp 10 ống', N'Ống')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000076', N'N001', N'Solupred 20mg', N'Prednisolone', N'20mg', N'pháp', N'', N'Hộp 1 lọ 20 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000077', N'N002', N'Sotalex 80mg', N'Chlorhydrate de Sotalol', N'80mg', N'pháp', N'', N'Hộp 30 viên', N'Viên')

-- index :3
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV001', N'Bùi Xuân Huấn', N'34 Hàng Bạc - Hoàn Kiếm - Hà Nội 1', N'(091) 353-6674', N'NV001', N'NV001', N'admin')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV002', N'Ngô Văn Khá', N'101 Đại Cồ Việt - Hai Bà Trưng - Hà Nội', N'0992016017', N'NV002', N'NV002', N'admin')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV003', N'Nguyễn Hữu Đa', N'Cổ Loa - Đông Anh - Hà Nội', N'0916930001', N'NV003', N'NV003', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV004', N'Nguyễn Văn Khoa', N'223 Bạch Mai - Hai Bà Trưng - Hà Nội', N'(090) 912-3668', N'NV004', N'NV004', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV005', N'Ngô Phương Nhung', N'469 Giải Phóng - Hoàng Mai - Hà Nội', N'(093) 469-1616', N'NV005', N'NV005', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV006', N'Hà Thị Thương', N'38 Phố Huế - Hai Bà Trưng - Hà Nội', N'0913536666', N'NV006', N'NV006', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV007', N'Lã Thu Thảo', N'115 Nguyễn Trãi - Thanh Xuân - Hà Nội', N'0931584158', N'NV007', N'NV007', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV008', N'Phùng Văn Chiến', N'Phù Lỗ - Đông Anh - Hà Nội', N'0929022001', N'NV008', N'NV008', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV009', N'Ngô Thanh Tân', N'195 Bạch Mai - Hai Bà - Hà Nội', N'0901023668', N'NV009', N'NV009', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV010', N'Đào Duy Từ', N'501 Giải Phóng - Hoàng Mai - Hà Nội', N'0933344416', N'NV010', N'NV010', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV011', N'Nguyễn Văn Tuân', N'275 Phố Huế - Hai Bà - Hà Nội', N'0913536618', N'NV011', N'NV011', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV012', N'Thùy Thị Hương', N'195 Mai Hắc Đế- Hai Bà - Hà Nội', N'0913246789', N'NV012', N'NV012', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV013', N'Phạm Xuân Lan', N'101 Hàng Bài - HoànKiếm - Hà Nội', N'0978787868', N'NV013', N'NV013', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV014', N'Vũ Phương Anh', N'19 Tôn Đức Thắng - Đống Đa - Hà Nội', N'0908343566', N'NV014', N'NV014', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV015', N'Vũ Hồng Liên', N'27 Lãn Ông - Hoàn Kiếm - Hà Nội', N'0909001122', N'NV015', N'NV015', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV016', N'Đào Thị Liễu', N'194 Xuân Thủy - Cầu Giấy - Hà Nội', N'0909091234', N'NV016', N'NV016', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV017', N'Nguyễn Văn Đạt', N'54 Chùa Bộc - Đống Đa - Hà Nội', N'0940001369', N'NV017', N'NV017', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV018', N'Dương Mạnh Hải', N'122 Đội Cấn - Ba Đình - Hà Nội', N'0913572266', N'NV018', N'NV018', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV019', N'Tống Minh', N'P2501 - T10 Times City - Hai Bà - Hà Nội', N'0934321234', N'NV019', N'NV019', N'nhanvien')
INSERT [dbo].[tblNhanvien] ([MANHANVIEN], [TENNHANVIEN], [DIACHI], [SDT], [TAIKHOAN], [MATKHAU], [QUYEN]) VALUES (N'NV020', N'Bùi Thị Liễu Dương', N'Vĩnh Phúc', N'(091) 236-5489', N'duonglieu2901', N'lieuduong2901', N'admin')

-- index: 4
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC001', N'Công Ty TNHH Lê Hào', N'(024) 371-9021', N'sales.lehaoco@gmail.com', N'a592347')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC002', N'Công Ty Cổ Phần Dưỡng Dược Vĩnh Kim', N'08485505526', N'kimluan32@gmail.com', N'b946771')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC003', N'Công Ty CP Nông Nghiệp Công Nghệ Cao Thăng Long', N'(058) 941-8003', N'cagaileosadu@gmail.com', N'a449584')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC004', N'Cửa Hàng Đông Trùng Hạ Thảo On Plaza', N'06629695707', N'dongtrungtaytangonplaza@gmail.com', N'a283280')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC005', N'Công Ty Hoa Bảo', N'06316110646', N'chuyenkhoangxoang@hotmail.com', N'b658380')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC006', N'Công Ty TNHH Thảo Dược Đại Thiên Nương', N'07960737872', N'lanuong@gmail.com', N'a703231')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC007', N'Công Ty CP Quốc Tế Nisepharm', N'01293646845', N'ketoanhanoi@gmail.com', N'a710749')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC008', N'Nhà Thuốc Thảo Dược An Bình', N'04580043833', N'baithuocdangian365@gmail.com', N'c855110')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC009', N'Nhà Thuốc MedPhar', N'05400222262', N'medphar.vn@gmail.com', N'b800790')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC010', N'Eva Shop', N'09030703381', N'diemthaicorp@gmail.com', N'c660684')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC011', N'Công Ty Cổ Phần Neemtree', N'06794641121', N'nemtree@gmail.com', N'd394761')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC012', N'Công Ty Cổ Phần Difoco', N'09240335593', N'difoco@gmail.com', N'a740029')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC013', N'Công Ty CP TM Dược Phẩm Ngọc Đông', N'04636329778', N'ngocdong@gmail.com', N'b672273')
INSERT [dbo].[tblNhacungcap] ([MANCC], [TENNCC], [SDT], [EMAIL], [MST]) VALUES (N'NCC014', N'Công Ty TNHH DNC Solution', N'02439952922', N'phamthiennhiendncsolution@gmail.com', N'a382419')

--index:5
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH001', N'Nguyễn Thị Hồng Chuyên', N'Số 386, đường Nguyễn Văn Linh', N'chuyen@gmail.com', N'(016) 8 9-59 5')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH002', N'Phạm Thị Hiền', N'Số 2, ngách 266/5, Nguyễn Văn Cừ, Long Biên, HN', N'hien@gmail.com', N'(091) 5 0-08 0')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH003', N'Nguyễn Thị Trang', N'Số 2, ngách 266/5, Nguyễn Văn Cừ, Long Biên, HN', N'trang@gmail.com', N'0914 753 234 ')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH004', N'Vũ Thanh Loan', N'Số 2, ngách 266/5, Nguyễn Văn Cừ, Long Biên, HN', N'loan@gmail.com', N'0977 293 043')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH005', N'Nguyễn Thị Gấm', N'Số 2, ngách 266/5, Nguyễn Văn Cừ, Long Biên, HN', N'gam@gmail.com', N'0912 632 979')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH006', N'Vũ Thị Hải Yến', N'Số 7, đường Thanh Bình Km số 0, Hà Đông', N'yen@gmail.com', N'0915 898 289')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH007', N'Nguyễn Quốc Tuấn', N'Số 7, đường Thanh Bình Km số 0, Hà Đông', N'tuan@gmail.com', N'0912 882 299 ')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH008', N'Nguyễn Thái Học', N'Xã Hưng Thịnh, Huyện Bình Giang, Hải Dương', N'hoc@gmail.com', N'0983 381 914')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH009', N'Nguyễn Trung Dũng', N'Xã Hưng Thịnh, Huyện Bình Giang, Hải Dương', N'dung@gmail.com', N'0983 118 283')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH010', N'Chu Anh Cường', N'Xã Hưng Thịnh, Huyện Bình Giang, Hải Dương', N'cuong@gmail.com', N'0986 562 345')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH011', N'Đoàn Mạnh Dũng', N'39 Lý Nam Đế', N'dung1@gmail.com', N'0945 568 648')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH012', N'Đoàn Vũ Long', N'39 Lý Nam Đế', N'long@gmail.com', N'0936 678 840')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH013', N'Nguyễn Văn Tùng', N'39 Lý Nam Đế', N'tung@gmail.com', N'0982 461 266')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH014', N'Đỗ Lê Hồng Nhung', N'Số 294/3 ngõ Bà Triệu', N'nhung@gmail.com', N'0904 438 340')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH015', N'Hoàng Thi Sỹ', N'26 Phương Mai', N'sy@gmail.com', N'(091) 8 7-64 2')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH016', N'Nguyễn Bích Hòa', N'26 Phương Mai', N'hoa@gmail.com', N'0982 050 088')
INSERT [dbo].[tblKhachhang] ([MAKHACH], [TENKHACH], [DIACHI], [EMAIL], [SDT]) VALUES (N'KH017', N'Nguyễn Hạnh Phương', N'164 Nguyễn Lương Bằng', N'phuong@gmail.com', N'0913 560 211')

-- index: 6
delete tblPhieunhap
INSERT [dbo].[tblPhieunhap] ([MANHAP], [NGAYNHAP], [MANCC], [TONGTIEN], [GHICHU]) VALUES (N'PN24112021112352', CAST(N'2021-01-24T00:00:00.000' AS DateTime), N'NCC001', 2710000, NULL)
INSERT [dbo].[tblPhieunhap] ([MANHAP], [NGAYNHAP], [MANCC], [TONGTIEN], [GHICHU]) VALUES (N'PN24112021113301', CAST(N'2021-02-24T00:00:00.000' AS DateTime), N'NCC010', 3200000, NULL)
INSERT [dbo].[tblPhieunhap] ([MANHAP], [NGAYNHAP], [MANCC], [TONGTIEN], [GHICHU]) VALUES (N'PN24112021113759', CAST(N'2021-03-24T00:00:00.000' AS DateTime), N'NCC010', 3600000, NULL)
INSERT [dbo].[tblPhieunhap] ([MANHAP], [NGAYNHAP], [MANCC], [TONGTIEN], [GHICHU]) VALUES (N'PN2511202125740', CAST(N'2021-01-25T00:00:00.000' AS DateTime), N'NCC011', 5000000, NULL)
INSERT [dbo].[tblPhieunhap] ([MANHAP], [NGAYNHAP], [MANCC], [TONGTIEN], [GHICHU]) VALUES (N'PN2511202160758', CAST(N'2021-01-25T00:00:00.000' AS DateTime), N'NCC005', 5000000, NULL)
INSERT [dbo].[tblPhieunhap] ([MANHAP], [NGAYNHAP], [MANCC], [TONGTIEN], [GHICHU]) VALUES (N'PN2511202161133', CAST(N'2021-02-25T00:00:00.000' AS DateTime), N'NCC012', 550000, NULL)

--index:7
DELETE FROM tblCTPhieunhap
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN24112021112352', N'DQG00000002', N'1', CAST(N'2026-01-24T00:00:00.000' AS DateTime), N'mCi', 10000, 100, 1000000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN24112021112352', N'DQG00000009', N'1', CAST(N'2026-01-24T00:00:00.000' AS DateTime), N'Lọ', 5000, 200, 1000000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN24112021112352', N'DQG00000017', N'1', CAST(N'2026-01-24T00:00:00.000' AS DateTime), N'Viên', 20000, 20, 400000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN24112021112352', N'DQG00000019', N'1', CAST(N'2026-01-24T00:00:00.000' AS DateTime), N'Viên', 2000, 30, 60000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN24112021112352', N'DQG00000022', N'1', CAST(N'2026-01-24T00:00:00.000' AS DateTime), N'Viên', 5000, 50, 250000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN24112021113301', N'DQG00000002', N'2', CAST(N'2026-02-24T00:00:00.000' AS DateTime), N'mCi', 10000, 100, 1000000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN24112021113301', N'DQG00000050', N'2', CAST(N'2026-02-24T00:00:00.000' AS DateTime), N'Ống', 20000, 60, 1200000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN24112021113759', N'DQG00000009', N'3', CAST(N'2026-03-24T00:00:00.000' AS DateTime), N'Lọ', 60000, 60, 3600000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN2511202125740', N'DQG00000002', N'100', CAST(N'2021-02-25T00:00:00.000' AS DateTime), N'mCi', 10000, 500, 5000000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN2511202160758', N'DQG00000017', N'101', CAST(N'2021-02-26T00:00:00.000' AS DateTime), N'Viên', 50000, 100, 5000000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN2511202161133', N'DQG00000032', N'102', CAST(N'2021-05-28T00:00:00.000' AS DateTime), N'Lọ', 5000, 40, 200000)
INSERT [dbo].[tblCTPhieunhap] ([MANHAP], [MATHUOC], [LOSX], [HSD], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'PN2511202161133', N'DQG00000019', N'102', CAST(N'2021-06-29T00:00:00.000' AS DateTime), N'Viên', 30000, 5, 150000)

--index:8
delete from tblHoadonban
INSERT [dbo].[tblHoadonban] ([MABAN], [NGAYNHAP], [MAKHACH], [MANHANVIEN], [TONGTIEN], [GHICHU]) VALUES (N'HD24112021112601', CAST(N'2021-01-25T00:00:00.000' AS DateTime), N'KH002', N'NV001', 70000, NULL)
INSERT [dbo].[tblHoadonban] ([MABAN], [NGAYNHAP], [MAKHACH], [MANHANVIEN], [TONGTIEN], [GHICHU]) VALUES (N'HD24112021112646', CAST(N'2021-01-26T00:00:00.000' AS DateTime), N'KH002', N'NV002', 60000, NULL)
INSERT [dbo].[tblHoadonban] ([MABAN], [NGAYNHAP], [MAKHACH], [MANHANVIEN], [TONGTIEN], [GHICHU]) VALUES (N'HD2511202164121', CAST(N'2021-11-25T00:00:00.000' AS DateTime), N'KH006', N'NV003', 600000, NULL)
INSERT [dbo].[tblHoadonban] ([MABAN], [NGAYNHAP], [MAKHACH], [MANHANVIEN], [TONGTIEN], [GHICHU]) VALUES (N'HD2511202164823', CAST(N'2021-02-12T00:00:00.000' AS DateTime), N'KH006', N'NV004', 100000, NULL)
INSERT [dbo].[tblHoadonban] ([MABAN], [NGAYNHAP], [MAKHACH], [MANHANVIEN], [TONGTIEN], [GHICHU]) VALUES (N'HD2511202164915', CAST(N'2021-02-15T00:00:00.000' AS DateTime), N'KH009', N'NV005', 1150000, NULL)

--index: 9
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD24112021112601', N'DQG00000002', N'1', N'mCi', 10000, 5, 50000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD24112021112601', N'DQG00000009', N'1', N'Lọ', 5000, 2, 10000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD24112021112601', N'DQG00000019', N'1', N'Viên', 2000, 5, 10000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD24112021112646', N'DQG00000002', N'1', N'mCi', 10000, 2, 20000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD24112021112646', N'DQG00000017', N'1', N'Viên', 20000, 2, 40000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD2511202164121', N'DQG00000002', N'1', N'mCi', 10000, 20, 200000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD2511202164121', N'DQG00000009', N'3', N'Lọ', 60000, 5, 300000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD2511202164121', N'DQG00000022', N'1', N'Viên', 5000, 20, 100000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD2511202164823', N'DQG00000002', N'100', N'mCi', 10000, 10, 100000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD2511202164915', N'DQG00000002', N'100', N'mCi', 10000, 15, 150000)
INSERT [dbo].[tblCTHoadonban] ([MABAN], [MATHUOC], [LOSX], [DVT], [DONGIA], [SLUONG], [THANHTIEN]) VALUES (N'HD2511202164915', N'DQG00000017', N'101', N'Viên', 50000, 20, 1000000)

--SELECT
select * from tblNhomthuoc
select * from tblThuoc
select * from tblNhanvien
select * from tblNhacungcap
select * from tblKhachhang
select * from tblCTPhieunhap
select * from tblCTPhieunhap
select * from tblHoadonban
select * from tblCTHoadonban



/*
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000078', N'N001', N'Cynomel 0.025mg', N'Liothyronin sodique', N'0.025mg', N'pháp', N'', N'Hộp 30 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000079', N'N001', N'Solupred 5mg', N'Prednisolone', N'5mg', N'pháp', N'', N'Hộp 30 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000080', N'N001', N'ADENOCOR 6mg/2ml', N'adenosin', N'6mg/2ml', N'Spain', N'', N'Hộp 6 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000081', N'N001', N'Akneyash', N'Adapalen 30mg', N'30mg', N'Yash Medicare Pvt. Ltd.', N'', N'Hộp 1 tuýp 30g', N'Tuýp')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000082', N'N001', N'Alkeran 50mg', N'Melphalan', N'50mg', N'Italy', N'', N'hộp 1 lọ bột + 1 lọ dung môi', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000084', N'N001', N'Cerazette', N'Desogestrel 0.075mg', N'0.075mg', N'N.V.  Organon', N'', N'Hộp 1 vỉ x 28 viên; hộp 3 vỉ x 28 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000085', N'N001', N'COSMEGEN LYOVAC 500MCG', N'Dactinomycin', N'500mcg', N'Germany', N'', N'Hộp 1 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000086', N'N001', N'DACARBAZINE MEDAC 200MG', N'Dacarbazine', N'200mg', N'Đức', N'', N'Hộp 10 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000087', N'N001', N'DaewoongURSA-S', N'Acid Ursodeoxycholic, thiamin mononitrat, riboflavin', N'50mg, 10mg, 5mg', N'R&P Korea Co.,Ltd.', N'', N'Hộp 6 vỉ 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000091', N'N003', N'ESMOLOL HYDROCHLORIDE INJ', N'esmolol', N'100mg/10ml', N'', N'', N'Hộp 25 lọ x 10ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000092', N'N005', N'FOY 100mg', N'Gabexate mesilate', N'100mg', N'Italy', N'', N'Hộp 1 lọ bột + 1 lọ dung môi', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000093', N'N001', N'Frazine Inj.', N'Ceftriaxone Sodium', N'1g Ceftriaxone', N'Kyung Dong Pharm. Co., Ltd.', N'', N'Hộp 10 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000096', N'N003', N'Fucidin', N'Acid Fusidic', N'', N'Leo Laboratories Limited', N'', N'Hộp 1 tuýp 15g', N'Tuýp')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000097', N'N003', N'Fucidin', N'Acid Fusidic', N'', N'Leo Laboratories Limited', N'', N'Hộp 1 tuýp 5g', N'Tuýp')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000098', N'N001', N'Fucidin H', N'Mỗi g chứa: acid fusidic 20mg; Hydrocortison acetat 10mg', N'', N'Leo Laboratories Limited', N'', N'Hộp 1 tuýp 15g', N'Tuýp')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000099', N'N003', N'Glimulin - 2', N'Glimepiride 2mg', N'', N'Glenmark Pharmaceuticals Ltd.', N'', N'Hộp lớn X 10 hộp nhỏ x 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000103', N'N005', N'Lezra 2,5mg', N'Letrozole 2,5mg', N'2,5mg', N'S.C. Sindan-Pharma S.R.L.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000104', N'N003', N'Milrinone Lactate Injection', N'Milrinone', N'10mg/10ml', N'Portugal', N'', N'Hộp 10 lọ x 10ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000106', N'N003', N'Omeprazole Capsules 20mg', N'Omeprazole (dạng hạt pellet bao tan trong ruột)', N'20mg Omeprazole', N'Macleods Pharmaceuticals Ltd.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000107', N'N001', N'Paclitaxel Actavis 6mg/ml', N'Paclitaxel 6mg/ml', N'', N'Actavis Italy S.p.A.', N'', N'Hộp 1 lọ 150mg/25ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000109', N'N001', N'SPECTRILA 10.000 IU', N'L-Asparaginase', N'10.000 IU', N'Germany', N'', N'Hộp 1 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000110', N'N005', N'Tamoxifen Sandoz 20mg', N'Tamoxifen (dưới dạng Tamoxifen citrate) 20mg', N'20mg', N'Salutas Pharma GmbH', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000112', N'N003', N'Viên nang mềm Dimorin', N'Isotretinoin 10mg', N'', N'Korean Drug Co., Ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000113', N'N001', N'Xorimax 500mg', N'Cefuroxim (dưới dạng Cefuroxim axetil) 500mg', N'500mg', N'Sandoz GmbH', N'', N'Hộp 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000114', N'N005', N'Biogermin', N'2 tỷ bào tử Bacillus Clausii', N'2 tỷ bào tử', N'Special Product''s Line S.P.A', N'', N'Hộp 20 ống x 5ml hỗn dịch uống', N'Ống')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000115', N'N005', N'Evinale gel', N'Mỗi 10g gel chứa: Tyrothricin 10mg', N'10mg', N'Korea Arlico Pharm. Co., Ltd.', N'', N'Hộp 1 tuýp 10g', N'Tuýp')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000117', N'N005', N'Kupunistin', N'Cisplatin 10mg/10ml', N'', N'Korea United Pharm. Inc.', N'', N'Hộp 1 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000118', N'N005', N'MyHep 400mg', N'Sofosbuvir 400mg', N'400mg', N'Mylan Laboratories Limited', N'', N'Hộp 1 lọ x 28 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000119', N'N005', N'MyVelpa', N'Sofosbuvir 400mg; Velpatasvir 100mg', N'400mg; 100mg', N'Mylan Laboratories Limited', N'', N'Hộp 1 lọ x 28 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000120', N'N001', N'Roschem-10', N'Rosuvastatin (dưới dạng Rosuvastatin calcium) 10mg', N'', N'Lessac Research Laboratories Private Limited', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000121', N'N001', N'Roschem-20', N'Rosuvastatin (dưới dạng Rosuvastatin calcium) 20mg', N'', N'Lessac Research Laboratories Private Limited', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000122', N'N004', N'Orkan SoftCapsule', N'Calcitriol 0,25mcg', N'0,25mcg', N'Young Poong Pharma. Co., Ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000123', N'N002', N'Verimed 135mg', N'Mebeverin hydroclorid 135mg', N'135mg', N'Medochemie Ltd.- central Factory', N'', N'Hộp 5 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000124', N'N005', N'Qiluxone', N'Ceftriaxon (dưới dạng Ceftriaxon natri) 2,0g', N'2,0g', N'Qilu Pharmaceutical Co., Ltd', N'', N'Hộp 10 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000128', N'N001', N'Jintra Tablet', N'Acetaminophen 325 mg; Tramadol hydroclorid 37,5 mg', N'', N'Korea Arlico Pharm. Co., Ltd.', N'', N'Hộp 3 vỉ, 5 vỉ, 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000129', N'N005', N'Receant', N'Cefuroxim (dưới dạng Cefuroxim natri) 750mg', N'750mg', N'Remedica S.A.', N'', N'Hộp 50 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000130', N'N004', N'Ambixol 15mg/5ml syrup', N'Mỗi 5ml sirô chứa: Ambroxol  hydrochlorid 15mg', N'15mg', N'Sopharma AD', N'', N'Hộp 1 chai 100 ml', N'Chai')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000132', N'N001', N'Wefree', N'Trimebutine maleate 100mg', N'', N'New Gene Pharm Inc.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000133', N'N004', N'Citopcin Injection 400mg/200ml', N'Ciprofloxacin  2mg/ml', N'2mg/ml', N'CJ HealthCare Corporation', N'', N'Túi nhựa dẻo 200ml', N'Túi')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000134', N'N005', N'Alprostapint 500mg', N'Alprostadil', N'500mcg', N'Germany', N'', N'ống 1 ml', N'Ống')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000135', N'N003', N'Cosmegen Lyovac 500mcg', N'Dactinomycin', N'500mcg', N'Germany', N'', N'hộp 1 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000136', N'N004', N'Kungcef Tab.', N'Citicoline (dưới dạng Citicoline natri) 500 mg', N'', N'Kyongbo Pharm. Co., Ltd.', N'', N'Hộp 5 vỉ 10 viên, hộp 10 vỉ 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000137', N'N005', N'Seovice film Coated Tablet', N'Citicoline (dưới dạng Citicoline natri) 500mg', N'', N'Theragen Etex Co., Ltd', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000139', N'N001', N'Seosaft Inj.1g', N'Ceftezol (dưới dạng Ceftezol natri) 1g', N'1g', N'Kyongbo Pharm. Co.,Ltd. - Korea', N'', N'Hộp 10 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000140', N'N003', N'Ursobil', N'Acid ursodeoxycholic 300mg', N'', N'ABC Farmaceutici S.P.A', N'', N'Hộp 3 vỉ x 10 viên; Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000141', N'N004', N'Takiqui', N'Tetryzoline hydrochloride 0,5mg/ml', N'5mg/ml Timolol', N'Farmak JSC', N'', N'Hộp 1 lọ 10ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000142', N'N001', N'Neurica 75', N'Pregabalin 75mg', N'', N'Micro Labs Limited', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000143', N'N003', N'Pentoxipharm', N'Pentoxifyllin', N'100mg', N'Bulgaria', N'', N'hộp 6 vỉ x 10 viên ,', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000144', N'N001', N'Fopranazol', N'Fluconazole 150mg', N'', N'Brawn Laboratories Ltd', N'', N'Hộp 1 vỉ 1 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000145', N'N004', N'Albendazole Tablets 400mg', N'Albendazol 400mg', N'400mg', N'Brawn Laboratories Limited', N'', N'Hộp 1 vỉ x 1 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000147', N'N001', N'Nivalin 5mg', N'Galantamine hydrobromide', N'5mg', N'Bulgaria', N'', N'hộp 1 vỉ x 20 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000148', N'N003', N'Sketixe', N'Desloratadin 5mg', N'', N'Micro Labs Limited', N'', N'Hộp 6 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000151', N'N001', N'Neurica 75', N'Pregabalin 75mg', N'', N'Micro Labs Limited', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000152', N'N001', N'Loacne', N'Cyproteron acetate 2mg; Ethinylestradiol 0,035mg', N'', N'Famy Care Ltd.', N'', N'Hộp 1 vỉ x 21 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000153', N'N001', N'Perglim M-1', N'Glimepiride 1mg; Metformin hydrochloride 500mg', N'1mg, 500mg', N'Inventia Healthcare Pvt. Ltd.', N'', N'Hộp lớn x 5 hộp nhỏ x 1 vỉ 20 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000154', N'N004', N'Perglim M-2', N'Glimepiride 2mg; Metformin hydrochloride 500mg', N'2mg, 500mg', N'Inventia Healthcare Pvt. Ltd.', N'', N'Hộp lớn x 5 hộp nhỏ x 1 vỉ 20 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000155', N'N004', N'Vigirmazone 200', N'Clotrimazol 200mg', N'', N'Bliss GVS Pharma Ltd.', N'', N'Hộp 1 vỉ x 3 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000156', N'N001', N'Omez', N'Omeprazole', N'20mg', N'Dr. Reddys Laboratories Ltd.', N'', N'Hộp lớn đựng 5 hộp nhỏ x 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000157', N'N001', N'Sulcilat 250mg/5ml', N'Sultamicillin 250mg/5ml', N'', N'Atabay Kimya San ve Tic A.S.', N'', N'Hộp 1 lọ bột để pha 40ml hỗn dịch', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000160', N'N004', N'Ul-Fate', N'Sucrafat 1g', N'1g', N'Synmedic Laboratories', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000161', N'N001', N'Nephgold', N'hỗn hợp các acid amin', N'.', N'JW Life Science Corporation', N'', N'Túi polypropylene 250ml', N'Túi')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000163', N'N004', N'Hyzaar 50mg/12.5mg', N'Losartan potassium 50mg; Hydrochlorothiazide 12,5mg', N'50mg, 12,5mg', N'Merck Sharp & Dohme Ltd.', N'', N'Hộp 2 vỉ x 14 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000167', N'N005', N'Iressa', N'Gefitinib 250mg', N'250mg', N'AstraZeneca UK Limited', N'', N'Hộp 1 túi nhôm x 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000168', N'N005', N'Biodroxil 500mg', N'Cefadroxil (dưới dạng Cefadroxil monohydrat) 500mg', N'500mg', N'Sandoz GmbH', N'', N'Hộp 1 vỉ x 12 viên.', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000169', N'N001', N'Diamicron MR 60mg', N'Gliclazide 60mg', N'60mg', N'Les Laboratoires Servier Industrie', N'', N'Hộp 2 vỉ x 15 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000171', N'N005', N'Rolavast 20', N'Rosuvastatin (dưới dạng Rosuvastatin calci) 20 mg', N'', N'Mepro Pharmaceuticals Pvt. Ltd- Unit II', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000172', N'N005', N'Torpace-5', N'Ramipril 5mg - 5mg', N'5mg', N'Torrent Pharmaceuticals Ltd.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000173', N'N005', N'Valbelis 80/12.5mg', N'Valsartan 80mg; Hydrochlorothiazide 12,5mg', N'', N'Laboratorios Lesvi, S.L.', N'', N'Hộp 2 vỉ x 14viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000175', N'N005', N'Cebrex S', N'Cao khô lá Ginkgo biloba', N'80mg', N'Dr. Willmar Schwabe GmbH & Co. KG', N'', N'Hộp 6 vỉ x 20 viên', N'Viên')
*/
-- index: 1
/*
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000176', N'N001', N'Klopenem', N'Meropenem', N'500mg', N'Klonal S.R.L', N'', N'Hộp 1 lọ, 25 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000179', N'N001', N'Aurotaz-P 4.5', N'Piperacillin sodium, Tazobactam sodium', N'4g Piperacillin; 0,5g Tazobactam', N'Aurobindo Pharma Ltd.', N'', N'Hộp 1 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000181', N'N001', N'Knox', N'Colistimethate natri 1.000.000 IU', N'', N'Gufic Biosciens Limited', N'', N'Hộp 1 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000182', N'N001', N'Chlorure de sodium 0,9%', N'Natri chloride', N'0,9% 500ml', N'France', N'', N'Hộp 1 túi 500ml', N'Túi')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000183', N'N001', N'Protamine Choay 1000UAH/ml', N'Protamin sulfate', N'1000UAH/ml, 10ml', N'Espagne', N'', N'Hộp 1 lọ 10ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000184', N'N001', N'Promag', N'Magnesi Valproat 200mg', N'200mg', N'Myung-In Pharm. Co., Ltd.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000185', N'N005', N'Coxwell-90', N'Etoricoxib 90mg - 90mg', N'', N'Micro Labs Limited', N'', N'Hộp 03 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000189', N'N001', N'Roxitis - 150', N'Roxithromycin', N'150mg', N'Medley Pharmaceuticals Ltd.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000191', N'N005', N'Denazox', N'Diltiazem hydrochloride', N'60mg', N'Remedica Ltd.', N'', N'Hộp 5 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000192', N'N001', N'Cyplosart 50 FC Tablets', N'Losartan kali 50mg', N'', N'Remedica Ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000193', N'N005', N'Carbaro 200mg, tablets', N'Carbamazepin 200mg', N'', N'S.C.Arena Group S.A.', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000196', N'N005', N'Isoptine 40mg', N'Verapamil Chlorhydrate', N'40mg', N'France', N'', N'Hộp 75 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000198', N'N001', N'Coumadine 2mg', N'Warfarine sodique', N'2mg', N'Greece', N'', N'Hộp 20 viên nén', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000199', N'N005', N'Helotec', N'L-Ornithine -L-aspartate', N'5g', N'Union Korea Pharm. Co., Ltd.', N'', N'Hộp 10 ống x 10ml', N'Ống')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000200', N'N001', N'Rokzy-150', N'Roxithromycin', N'150mg', N'Zim Labratories Ltd.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000201', N'N005', N'Clopicure', N'Clopidogrel (dưới dạng Clopidogrel bisulphate) 75mg', N'', N'Gracure Pharmaceuticals Ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000202', N'N001', N'Solupred 5mg', N'Prednisolone', N'5mg', N'France', N'', N'Hộp 30 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000203', N'N005', N'Solupred 5mg', N'Prednisolone', N'5mg', N'France', N'', N'Hộp 30 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000204', N'N005', N'Dostinex 0.5mg', N'Cabergoline', N'0,5mg', N'Italie', N'', N'Hộp 8 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000205', N'N001', N'Neozith 250', N'Azithromycin dihydrate', N'250mg azithromycin', N'Zim Labratories Ltd.', N'', N'Hộp 5 vỉ x 6 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000207', N'N005', N'Myzith MR 60', N'Gliclazide 60mg', N'60mg', N'M/s Windlas Healthcare (P) Ltd.', N'', N'Hộp 6 vỉ x 5 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000208', N'N001', N'Diulactone 25mg', N'Spironolactone', N'25mg', N'Searle Pakistan Limited', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000216', N'N001', N'Tobrin', N'Tobramycin sulfate', N'3mg Tobramycin/ml', N'Balkanpharma Razgrad AD', N'', N'Hộp 1lọ 5ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000217', N'N005', N'Bloktiene 5 mg', N'Montelukast (dưới dạng Montelukast natri) 5mg', N'5mg', N'Actavis Ltd.', N'', N'Hộp 4 vỉ x 7 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000218', N'N001', N'Cefazolin Actavis 1g', N'Cefazolin (dưới dạng Cefazolin natri) 1g', N'1g', N'Balkanpharma - Razgrad AD', N'', N'Hộp 1 lọ x 10 ống', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000219', N'N005', N'Cefazolin Actavis 2g', N'Cefazolin (dưới dạng Cefazolin natri) 2g', N'2g', N'Balkanpharma - Razgrad AD', N'', N'Hộp 1 lọ x 10 ống', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000223', N'N005', N'Pentasa Sachet 1g', N'Mesalazine 1000mg', N'1000mg', N'Ferring International Center S.A.', N'', N'Hộp 50 gói 1,06g', N'Gói')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000224', N'N005', N'Rinofil syrup 2,5mg/5ml', N'Desloratadin 2,5mg/5ml', N'', N'Laboratorios Recalcine S.A.', N'', N'Hộp 1 chai 15ml', N'Chai')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000225', N'N002', N'Tobrin 0.3%', N'Mỗi 1 ml chứa: Tobramycin 3mg', N'3mg', N'Balkanpharma - Razgrad AD', N'', N'Hộp 1 lọ x 5 ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000228', N'N005', N'Angiotan-H-Tablets', N'Valsartan 160mg; Hydrochlorothiazide 25mg', N'160mg, 25mg', N'Efroze Chemical Industries (Pvt) Ltd.', N'', N'Hộp 1 vỉ x 14 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000231', N'N005', N'Calibin Soft cap.', N'Calcitriol 0,25mcg', N'', N'Dae Han New Pharm Co., Ltd.', N'', N'Hộp 5 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000234', N'N005', N'Lisinopril ATB 10mg', N'Lisinopril (dưới dạng Lisinopril dihydrat) 10mg', N'10mg', N'S.C. Antibiotice S.A.', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000235', N'N005', N'Methyldopa 250 FC Tablets', N'Methyldopa BP (Anhydrous)', N'', N'Cyprus', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000236', N'N005', N'Momex Nasal Spray', N'Mỗi 1ml hỗn dịch chứa: Mometason furoat 0,5mg', N'0,5mg', N'Hanlim Pharm. Co., Ltd.', N'', N'Hộp 1 chai 18ml (140 liều xịt x 50mcg)', N'Chai')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000237', N'N005', N'Pectolvan Ivy', N'Mỗi 5 ml chứa: Cao khô lá thường xuân (4-8):1 35mg', N'35mg', N'JSC "Farmak"', N'', N'Hộp 1 chai 100 ml', N'Chai')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000240', N'N005', N'Unimone Inj.', N'Ceftizoxim (dưới dạng Ceftizoxim natri) 1g', N'1g', N'Hwail Pharm. Co., Ltd.', N'', N'Hộp 10 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000243', N'N005', N'Urokit', N'Kali citrate 3g/gói', N'', N'Laboratorios Casasco S.A.I.C', N'', N'Hộp 60 gói', N'Gói')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000244', N'N005', N'Pronivel', N'Erythropoietin 2000 IU', N'', N'argentina', N'', N'hộp 1 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000245', N'N005', N'Macdin 600', N'Linezolid 600mg', N'', N'Macleods Pharmaceuticals Ltd.', N'', N'Hộp 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000246', N'N005', N'Doxycyclin capsules', N'Doxycycline Hyclate', N'100mg Doxycyclin', N'Brawn Laboratories Ltd', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000247', N'N001', N'Alcomet', N'Metadoxin 500 mg', N'', N'Axon Drugs Private Ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000248', N'N001', N'Auropennz 1.5', N'Ampicillin  1g; Sulbactam  0,5g', N'', N'Aurobindo Pharma Ltd.', N'', N'Hộp 1 lọ + 1 ống nước pha tiêm 5ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000249', N'N001', N'Nebivox', N'Nebivolol (dưới dạng Nebivolol hydrochloride) 5mg', N'', N'Micro Labs Limited', N'', N'Hộp 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000250', N'N001', N'Farmazolin', N'Xylometazoline hydrochloride', N'5mg/10ml', N'JSC Farmak', N'', N'Hộp 1 lọ 10ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000251', N'N001', N'Aloxi', N'Palonosetron', N'0,25mg', N'Helsinn Birex Pharmaceuticals Ltd', N'', N'Hộp 1 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000257', N'N001', N'Orle', N'Omeprazol (Dạng vi hạt bao tan trong ruột) 20mg', N'', N'Emcure Pharmaceuticals Ltd.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000258', N'N001', N'Losarlife-H', N'Losartan kali 50mg; Hydrochlorothiazide 12,5mg', N'', N'Eurolife Healthcare Pvt., Ltd.', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000259', N'N003', N'Suresh 600mg', N'Acetylcystein', N'600mg', N'Temmler Pharma GmbH', N'', N'Ống chứa 10 viên nén sủi bọt', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000262', N'N005', N'Santazid', N'Ceftazidime pentahydrate', N'1g Ceftazidime', N'Sanjivani Paranteral Ltd.', N'', N'Hộp 1lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000266', N'N002', N'Catoprine', N'Mercaptopurin', N'50mg/viên', N'Korea United Pharm. Inc.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000267', N'N001', N'Elpertone', N'Erdosteine 300mg', N'300mg', N'Korea Prime Pharm. Co., Ltd.', N'', N'Hộp 6 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000269', N'N003', N'Minoxyl Solution 3%', N'Minoxidil 3g/100ml', N'3g/100ml', N'Hyundai Pharm. Co., Ltd', N'', N'Hộp 1 chai 60ml', N'Chai')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000274', N'N005', N'Anzatax 100mg/16,7ml', N'Paclitaxel 100mg/16,7ml', N'100mg/16,7ml', N'Hospira Australia Pty Ltd', N'', N'Hộp 1 lọ 16.7 ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000275', N'N001', N'Anzatax 150mg/25ml', N'Paclitaxel 150mg/25ml', N'150mg/25ml', N'Hospira Australia Pty Ltd', N'', N'Hộp 1 lọ 25 ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000276', N'N005', N'Carvisan-MR', N'Trimetazidine Hydrochloride', N'35mg', N'Micro Labs Limited', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000278', N'N001', N'Cetiam Inj. 1g', N'Cefotiam (dưới dạng Cefotiam dihydrochloride) 1g', N'', N'Kyung Dong Pharm Co., Ltd.', N'', N'Hộp 10 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000279', N'N005', N'Exelon Patch 10', N'Rivastigmine', N'18mg/10cm²', N'Đức', N'', N'Hộp 30 miếng', N'Miếng')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000280', N'N005', N'Exelon Patch 5', N'Rivastigmine', N'9mg/5cm²', N'Đức', N'', N'Hộp 30 miếng', N'Miếng')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000281', N'N001', N'Farmorubicina', N'Epirubicin hydrocloride 50mg', N'50mg', N'Actavis Italy S.P.A', N'', N'Hộp 1 lọ bột đông khô pha tiêm', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000283', N'N005', N'Flusort', N'Mỗi liều xịt chứa: Fluticasone propionate 50mcg', N'', N'Glenmark Pharmaceuticals Ltd.', N'', N'Hộp 1 bình xịt 120 liều', N'Bình')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000284', N'N001', N'Glimeco 4', N'Glimepiride 4mg', N'4mg', N'Coral Laboratories Limited', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000296', N'N001', N'Temozolimid Ribosepharm 100mg', N'Temozolomide 100mg', N'100mg', N'Haupt Pharma Amareg GmbH', N'', N'Hộp 1 chai 5, 20 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000297', N'N001', N'Tygacil', N'Tigecyclin 50mg - 50mg', N'', N'Wyeth Lederle S.r.l.', N'', N'Hộp 10 lọ', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000300', N'N003', N'Zantac Tablets', N'Ranitidin  (dưới dạng ranitidin HCl) 150mg', N'150mg', N'Glaxo Wellcome S.A,', N'', N'Hộp 6 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000305', N'N001', N'Microstun', N'Metronidazole 0,5g/100ml', N'', N'Denis Chem Lab limited', N'', N'Chai thủy tinh 100ml', N'Chai')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000306', N'N001', N'Evopride 1mg', N'Glimepiride 1mg', N'', N'PharmEvo Private Limited', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000309', N'N003', N'Aetoxisclerol Tampone', N'Lauromacrogol', N'40mg/2ml', N'Allemagne', N'', N'Hộp 5 ống 2ml', N'Ống')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000311', N'N003', N'Neurogap', N'Gabapentin 300mg', N'', N'Synmedic Laboratories', N'', N'Hộp 10vỉ x 10viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000312', N'N005', N'Eretab', N'Eperisone Hydrochloride 50mg', N'', N'Hutecs Korea Pharmaceutical Co., Ltd.', N'', N'Hộp 10 vỉ x 10 viên, lọ 200 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000313', N'N003', N'Highcera', N'Cetirizin dihydrochlorid 10mg', N'', N'Samjin Pharmaceutical Co., Ltd.', N'', N'Lọ 500viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000314', N'N003', N'Maorix Tablet', N'Chlorphenesin carbamat 125mg', N'', N'Sinil Pharm Co., Ltd.', N'', N'Lọ 100viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000315', N'N001', N'Nibixada', N'Cilostazol', N'100mg', N'Ba lan', N'', N'Hộp 3 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000317', N'N005', N'Diu-Tansin Tablet', N'Losartan kaki 50mg; Hydrochlorothiazid 12,5mg', N'', N'PharmEvo Private Limited', N'', N'Hộp 1 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000318', N'N005', N'Evopride 2mg', N'Glimepiride', N'2mg', N'PharmEvo Private Limited', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000322', N'N003', N'Arezol', N'Anastrozol 1mg', N'', N'Remedica Ltd.', N'', N'Hộp 2 vỉ x 14 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000323', N'N005', N'Panfor SR-1000', N'Metformin hydroclorid 1000mg', N'1000mg', N'Inventia Healthcare Pvt. Ltd.', N'', N'Hộp 5 vỉ x 20 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000324', N'N005', N'Stamlo 10', N'Amlodipin (dưới dạng amlodipin besilate) 10 mg', N'10 mg', N'Dr. Reddys Laboratories Ltd.', N'', N'Hộp 2 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000325', N'N001', N'Retento-800', N'Piracetam 800mg', N'800mg', N'XL Laboratories Pvt., Ltd.', N'', N'Hộp 10 vỉ x 10 viên', N'Viên')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000326', N'N005', N'New Oral', N'Cefpodoxime proxetil', N'50mg Cefpodoxime', N'Micro Labs Limited', N'', N'Hộp 1 lọ 60ml', N'Lọ')
INSERT [dbo].[tblThuoc] ([MATHUOC], [MANHOM], [TENTHUOC], [HOATCHATCHINH], [HAMLUONG], [HANGSX], [NUOCSX], [QUYCACHDONGGOI], [DVT]) VALUES (N'DQG00000328', N'N003', N'Glaritus', N'Insulin Glargine', N'100IU/ml', N'India', N'', N'Hộp 1 ống (cartridge) x 3ml, dung dịch tiêm', N'Ống')
*/
